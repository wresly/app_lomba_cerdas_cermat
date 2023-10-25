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



        private void Startbtn_Click(object sender, EventArgs e)
        {
            if (Plustxt.Text.Replace(" ", "") == "" || Minustxt.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Atur Scores!!");
                Startbtn.Enabled = true;
                return;
            }
            if (!int.TryParse(Plustxt.Text, out _) || !int.TryParse(Minustxt.Text, out _))
            {
                MessageBox.Show("Scores harus angka!!");
                Startbtn.Enabled = true;
                return;
            }

            if ((Secondtxt.Text == "00" && Minutetxt.Text == "00") || Secondtxt.Text.Trim() == "" || Minutetxt.Text.Trim() == "")
            {
                MessageBox.Show("Atur TImer!!");
                Startbtn.Enabled = true;
                return;
            }

            if (!int.TryParse(Minutetxt.Text, out _) || !int.TryParse(Secondtxt.Text, out _))
            {
                MessageBox.Show("Timer Harus Angka!!");
                Startbtn.Enabled = true;
                return;
            }

            Plustxt.Enabled = false;
            Minustxt.Enabled = false;
            Minutetxt.Enabled = false;
            Secondtxt.Enabled = false;
            Startbtn.Enabled = false;

            Statuslbl.Text = "waiting";
            Pluslbl.Text = ": " + Plustxt.Text;
            Minuslbl.Text = ": " + Minustxt.Text;
            Timerlbl.Text = ": " + (Minutetxt.Text.Length == 1 ? "0" : "") + Minutetxt.Text + ":" + (Secondtxt.Text.Length == 1 ? "0" : "") + Secondtxt.Text;

            Waitingfrm waitingfrm = new Waitingfrm();
            waitingfrm.ShowDialog();


            if (waitingfrm.DialogResult == DialogResult.OK)
            {
                try
                {
                    if (db.conn.State == ConnectionState.Closed)
                    {
                        db.conn.Open();

                    }
                    MySqlCommand cmd = new MySqlCommand("select * from game", db.conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        peserta = reader["peserta"].ToString();
                    }
                    reader.Close();
                    return;

                }
                catch
                {
                    MessageBox.Show("Server Putus!");
                    this.Close();
                }

                TimerGamefrm timerGamefrm = new TimerGamefrm();
                timerGamefrm.timer = Int32.Parse(Minutetxt.Text) * 60 + Int32.Parse(Secondtxt.Text);
                timerGamefrm.ShowDialog();
                if (timerGamefrm.DialogResult == DialogResult.OK)
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
                    catch (Exception)
                    {
                        MessageBox.Show("terjadi kesalahan");
                        Startbtn.Enabled = true;
                    }
                }

                if (timerGamefrm.DialogResult == DialogResult.Cancel)
                {
                    try
                    {
                        if (db.conn.State == ConnectionState.Closed)
                        {
                            db.conn.Open();

                        }
                        MySqlCommand cmd = new MySqlCommand("UPDATE users SET scores = scores - " + Int32.Parse(Minustxt.Text) + " WHERE username = '" + peserta + "'", db.conn);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("terjadi kesalahan");
                        Startbtn.Enabled = true;
                    }
                }
            }
            else
            {

            }
        }

    }
}
