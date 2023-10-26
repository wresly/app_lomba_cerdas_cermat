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
    public partial class Game2frm : KryptonForm
    {
        string peserta;
        public Game2frm()
        {
            InitializeComponent();
        }

        private void reset()
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
        private void reLoad()
        {
            try
            {
                Pesertacmb.Items.Clear();
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM users LEFT JOIN game_blacklist on users.username = game_blacklist.peserta WHERE users.usertype = 1 AND game_blacklist.peserta IS NULL;", db.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Pesertacmb.Items.Add(reader["username"].ToString());
                }
                reader.Close();
                Pesertacmb.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }
        private void Game2frm_Load(object sender, EventArgs e)
        {
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }

                //checked game data
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM `game` WHERE game_status != 'none'", db.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("game sedang berjalan, mohon reset game kembali atau lanjutkan", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Resetbtn.Enabled = true;
                }
                reader.Close();

                //checked blacklist
                cmd = new MySqlCommand("SELECT * FROM `game_blacklist`", db.conn);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("game sedang berjalan, mohon reset game kembali atau lanjutkan", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Resetbtn.Enabled = true;
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
            reLoad();
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            //validasi
            if (Scorestxt.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Atur Scores!!");
                return;
            }
            if (!int.TryParse(Scorestxt.Text, out _))
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


            peserta = Pesertacmb.Text;

            //disabled form
            Startbtn.Enabled = false;
            Pesertacmb.Enabled = false;
            Scorestxt.Enabled = false;
            Minutetxt.Enabled = false;
            Secondtxt.Enabled = false;

            //Update game table
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }
                MySqlCommand cmd = new MySqlCommand("UPDATE `game` SET `game_status`='game 2', `peserta` = '" + peserta + "', `timer`= " + (Int32.Parse(Minutetxt.Text) * 60 + Int32.Parse(Secondtxt.Text)), db.conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //checked user answer 
            AnswerCheckerUser answerCheckerUser = new AnswerCheckerUser();
            answerCheckerUser.timer = Int32.Parse(Minutetxt.Text) * 60 + Int32.Parse(Secondtxt.Text);
            answerCheckerUser.ShowDialog();

            //reset controls
            Pesertacmb.Enabled = true;
            Scorestxt.Enabled = true;
            Minutetxt.Enabled = true;
            Secondtxt.Enabled = true;
            Startbtn.Enabled = true;

            //true
            if (answerCheckerUser.DialogResult == DialogResult.OK)
            {
                Resetbtn.Enabled = true;
                reset();
                reLoad();
                try
                {
                    if (db.conn.State == ConnectionState.Closed)
                    {
                        db.conn.Open();

                    }
                    MySqlCommand cmd = new MySqlCommand("UPDATE users SET scores = scores + " + Int32.Parse(Scorestxt.Text) + " WHERE username = '" + peserta + "'", db.conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Startbtn.Enabled = true;
                }
                Startbtn.Enabled = true;

            }

            //false
            if (answerCheckerUser.DialogResult == DialogResult.Cancel)
            {
                Resetbtn.Enabled = true;
                //blacklist peserta
                Pesertacmb.Items.Remove(peserta);
                try
                {
                    if (db.conn.State == ConnectionState.Closed)
                    {
                        db.conn.Open();

                    }

                    //blacklist peserta
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO `game_blacklist`(`peserta`) VALUES ('" + peserta + "')", db.conn);
                    cmd.ExecuteNonQuery();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Startbtn.Enabled = true;
                }

                //reset if no more peserta
                if (Pesertacmb.Items.Count == 0)
                {
                    Scorestxt.Text = "";
                    Minutetxt.Text = "00";
                    Secondtxt.Text = "00";
                    reset();
                    reLoad();
                    return;
                }
                Pesertacmb.SelectedIndex = 0;
            }
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Tidakan Ini Akan Mereset Game", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (confirm == DialogResult.OK)
            {
                reset();
                reLoad();
            }
        }
    }
}
