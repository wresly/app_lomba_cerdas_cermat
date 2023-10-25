using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app_lomba_cerdas_cermat.Classes;
using Krypton.Toolkit;
using MySql.Data.MySqlClient;

namespace app_lomba_cerdas_cermat.Form.Sub_form
{
    public partial class Game3frm : KryptonForm
    {
        string peserta;
        public Game3frm()
        {
            InitializeComponent();
        }

        private void Game3frm_Load(object sender, EventArgs e)
        {
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }

                //checked asigned peserta to game
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM `game` WHERE peserta != 'none'", db.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    Resetbtn.Enabled = true;
                }
                reader.Close();

                //checked blacklist
                cmd = new MySqlCommand("SELECT * FROM `game_blacklist`", db.conn);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    Resetbtn.Enabled = true;
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            //validasi
            if (Plustxt.Text.Replace(" ", "") == "" || Minustxt.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Atur Scores!!");
                return;
            }
            if (!int.TryParse(Plustxt.Text, out _) || !int.TryParse(Minustxt.Text, out _))
            {
                MessageBox.Show("Scores harus angka!!");
                return;
            }

            if ((Secondtxt.Text == "00" && Minutetxt.Text == "00") || Secondtxt.Text.Trim() == "" || Minutetxt.Text.Trim() == "")
            {
                MessageBox.Show("Atur TImer!!");
                return;
            }

            if (!int.TryParse(Minutetxt.Text, out _) || !int.TryParse(Secondtxt.Text, out _))
            {
                MessageBox.Show("Timer Harus Angka!!");
                return;
            }
            Resetbtn.Enabled = true;

            //disabled form
            Plustxt.Enabled = false;
            Minustxt.Enabled = false;
            Minutetxt.Enabled = false;
            Secondtxt.Enabled = false;
            Startbtn.Enabled = false;

            //game status
            Statuslbl.Text = "waiting";
            Pluslbl.Text = ": " + Plustxt.Text;
            Minuslbl.Text = ": " + Minustxt.Text;
            Timerlbl.Text = ": " + (Minutetxt.Text.Length == 1 ? "0" : "") + Minutetxt.Text + ":" + (Secondtxt.Text.Length == 1 ? "0" : "") + Secondtxt.Text;

            //Update game table
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }
                MySqlCommand cmd = new MySqlCommand("UPDATE `game` SET `game_status`='game 3', `timer`= " + (Int32.Parse(Minutetxt.Text) * 60 + Int32.Parse(Secondtxt.Text)), db.conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //waiting user
            Waitingfrm waitingfrm = new Waitingfrm();
            waitingfrm.ShowDialog();
            if (waitingfrm.DialogResult == DialogResult.OK)
            {
                peserta = waitingfrm.peserta;

                AnswerCheckerUser answerCheckerUser = new AnswerCheckerUser();
                answerCheckerUser.timer = Int32.Parse(Minutetxt.Text) * 60 + Int32.Parse(Secondtxt.Text);
                answerCheckerUser.ShowDialog();

                //true answer
                if (answerCheckerUser.DialogResult == DialogResult.OK)
                {
                    try
                    {
                        if (db.conn.State == ConnectionState.Closed)
                        {
                            db.conn.Open();

                        }
                        MySqlCommand cmd = new MySqlCommand("UPDATE users SET scores = scores + " + Int32.Parse(Plustxt.Text) + " WHERE username = '" + peserta + "'", db.conn);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        Startbtn.Enabled = true;
                    }
                    Startbtn.Enabled = true;
                }

                //false answer
                if (answerCheckerUser.DialogResult == DialogResult.Cancel)
                {
                    try
                    {
                        if (db.conn.State == ConnectionState.Closed)
                        {
                            db.conn.Open();

                        }
                        MySqlCommand cmd = new MySqlCommand("UPDATE users SET scores = scores - " + Int32.Parse(Minustxt.Text) + " WHERE username = '" + peserta + "'", db.conn);
                        cmd.ExecuteNonQuery();

                        //blacklist peserta
                        cmd = new MySqlCommand("INSERT INTO `game_blacklist`(`peserta`) VALUES ('" + peserta + "')", db.conn);
                        cmd.ExecuteNonQuery();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        Startbtn.Enabled = true;
                    }
                    Startbtn.Enabled = true;
                }
            }
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Tidakan Ini Akan Mereset Game", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (confirm == DialogResult.OK)
            {
                try
                {
                    if (db.conn.State == ConnectionState.Closed)
                    {
                        db.conn.Open();

                    }
                    //reset game table
                    MySqlCommand cmd = new MySqlCommand("UPDATE `game` SET `game_status`='none',`peserta`='none',`timer`=0 ", db.conn);
                    cmd.ExecuteNonQuery();

                    //reset blacklist
                    cmd = new MySqlCommand("DELETE FROM `game_blacklist`", db.conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Startbtn.Enabled = true;
                }
            }
        }


    }
}
