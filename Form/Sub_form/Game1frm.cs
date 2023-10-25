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
using System.Media;

namespace app_lomba_cerdas_cermat.Form.Sub_form
{
    public partial class Game1frm : KryptonForm
    {
        int timer;
        string peserta;
        private SoundPlayer _soundTest = new SoundPlayer("times_up_sound.wav");
        public Game1frm()
        {
            InitializeComponent();
        }

        private void Game1frm_Load(object sender, EventArgs e)
        {
            Finishbtn.Enabled = false;

            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }
                MySqlCommand cmd = new MySqlCommand("select * from users where usertype = 1", db.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Pesertacmb.Items.Add(reader["username"].ToString());
                }
                reader.Close();
                Pesertacmb.SelectedIndex = 0;

            }
            catch
            {
                MessageBox.Show("Server Putus!");
                this.Close();
            }
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            Startbtn.Enabled = false;
            peserta = Pesertacmb.Text;
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

            try
            {
                Statuslbl.Text = ": Started";
                Pesertalbl.Text = ": " + Pesertacmb.Text;
                Timer2lbl.Text = ": " + (Minutetxt.Text.Length == 1 ? "0" : "") + Minutetxt.Text + ":" + (Secondtxt.Text.Length == 1 ? "0" : "") + Secondtxt.Text;


                timer1.Enabled = true;
                Finishbtn.Enabled = true;

                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();
                }
                timer = Int32.Parse(Minutetxt.Text) * 60 + Int32.Parse(Secondtxt.Text);
                MySqlCommand cmd = new MySqlCommand("UPDATE game SET game_status='game 1',`peserta`='" + Pesertacmb.Text + "',`timer`='" + timer + "' WHERE 1", db.conn);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Timerlbl.Text = "00:00";
                timer1.Enabled = false;
                Startbtn.Enabled = true;
                Finishbtn.Enabled = false;
            }
        }
        private void Finishbtn_Click(object sender, EventArgs e)
        {
            timer = 1;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer -= 1;
            var minute = timer / 60;
            var second = timer % 60;

            //waktu habis
            Timerlbl.Text = (minute < 10 ? "0" : "") + minute + ":" + (second < 10 ? "0" : "") + second;
            if (timer == 0)
            {
                //reset
                Statuslbl.Text = ": Not Started";
                Pesertalbl.Text = ": -";
                Timer2lbl.Text = ": 00:00";

                timer1.Enabled = false;
                Finishbtn.Enabled = false;
                Startbtn.Enabled = true;
                _soundTest.Play();

                //tambah scores
                AddScores addScores = new AddScores();
                MySqlCommand cmd = new MySqlCommand("select * from game", db.conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    addScores.peserta = reader["peserta"].ToString();
                }
                reader.Close();

                addScores.Show();
                return;
            }
        }


    }


}

