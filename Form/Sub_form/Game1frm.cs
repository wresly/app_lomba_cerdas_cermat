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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

            //cek for running game
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }

                //checked game data
                MySqlCommand cmd = new MySqlCommand("select * from game where game_status = 'game 1'", db.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    DateTime time = DateTime.ParseExact(reader["time"].ToString(), "HH:mm:ss", null);
                    DateTime currentTime = DateTime.Now;
                    time = time.AddSeconds(double.Parse(reader["timer"].ToString()));
                    if (time > currentTime)
                    {
                        //game status
                        Statuslbl.Text = ": Started";
                        Pesertalbl.Text = ": " + reader["peserta"].ToString();
                        Timer2lbl.Text = ": " + (Int32.Parse(reader["timer"].ToString()) / 60 < 9 ? "0" : "") + Int32.Parse(reader["timer"].ToString()) / 60 + ":" + (Int32.Parse(reader["timer"].ToString()) % 60 < 9 ? "0" : "") + Int32.Parse(reader["timer"].ToString()) % 60;

                        //controls enabled/disabled
                        Startbtn.Enabled = false;
                        Resetbtn.Enabled = true;
                        timer1.Enabled = true;
                        Finishbtn.Enabled = true;

                        //timer
                        TimeSpan timeDifference = time - currentTime;
                        timer = (int)timeDifference.TotalSeconds;
                        timer1.Enabled = true;

                        reader.Close();
                        MessageBox.Show("game masih berjalan", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("game telah selesai mohon reset game", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Startbtn.Enabled = false;
                        Resetbtn.Enabled = true;
                    }
                }
                reader.Close();

                //input combo box peserta
                cmd = new MySqlCommand("select * from users where usertype = 1", db.conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Pesertacmb.Items.Add(reader["username"].ToString());
                }
                reader.Close();
                Pesertacmb.SelectedIndex = 0;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {

            peserta = Pesertacmb.Text;

            //game status
            Statuslbl.Text = ": Started";
            Pesertalbl.Text = ": " + Pesertacmb.Text;
            Timer2lbl.Text = ": " + (Minutetxt.Text.Length == 1 ? "0" : "") + Minutetxt.Text + ":" + (Secondtxt.Text.Length == 1 ? "0" : "") + Secondtxt.Text;

            //controls enabled/disabled
            Startbtn.Enabled = false;
            Resetbtn.Enabled = true;
            timer1.Enabled = true;
            Finishbtn.Enabled = true;

            //validasi
            if ((Secondtxt.Text == "00" && Minutetxt.Text == "00") || Secondtxt.Text.Trim() == "" || Minutetxt.Text.Trim() == "")
            {
                MessageBox.Show("Atur Timer!!");
                Startbtn.Enabled = true;
                return;
            }

            if (!int.TryParse(Minutetxt.Text, out _) || !int.TryParse(Secondtxt.Text, out _))
            {
                MessageBox.Show("Timer Harus Angka!!");
                Startbtn.Enabled = true;
                return;
            }

            //update game table
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();
                }
                timer = Int32.Parse(Minutetxt.Text) * 60 + Int32.Parse(Secondtxt.Text);
                MySqlCommand cmd = new MySqlCommand("UPDATE game SET game_status='game 1',`peserta`='" + Pesertacmb.Text + "',`time`='" + DateTime.Now.ToLongTimeString() + "',`timer`='" + timer + "' WHERE 1", db.conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer -= 1;
            var minute = timer / 60;
            var second = timer % 60;

            //waktu habis
            Timerlbl.Text = (minute < 10 ? "0" : "") + minute + ":" + (second < 10 ? "0" : "") + second;
            if (timer <= 0)
            {
                //reset game status
                Statuslbl.Text = ": Not Started";
                Pesertalbl.Text = ": -";
                Timer2lbl.Text = ": 00:00";
                Timerlbl.Text = "00:00";

                //controls enabled/disabled
                timer1.Enabled = false;
                Resetbtn.Enabled = false;
                Finishbtn.Enabled = false;
                Startbtn.Enabled = true;
                _soundTest.Play();

                //tambah scores
                try
                {
                    //get peserta
                    AddScores addScores = new AddScores();
                    MySqlCommand cmd = new MySqlCommand("select * from game", db.conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        addScores.peserta = reader["peserta"].ToString();
                    }
                    reader.Close();

                    //reset game
                    cmd = new MySqlCommand("UPDATE `game` SET `game_status`='none',`peserta`='none',`time`='00:00:00',`timer`=0,`plus_scores`=0,`minus_scores`=0", db.conn);
                    cmd.ExecuteNonQuery();

                    addScores.ControlBox = false;
                    addScores.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
        }

        private void Finishbtn_Click(object sender, EventArgs e)
        {
            timer = 1;
        }
        private void Resetbtn_Click(object sender, EventArgs e)
        {
            //controls enabled/disabled
            Resetbtn.Enabled = false;
            Finishbtn.Enabled = false;
            Startbtn.Enabled = true;
            timer1.Enabled = false;

            Timer2lbl.Text = ": 00:00";


            //reset game status
            Statuslbl.Text = ": Not Started";
            Pesertalbl.Text = ": -";
            Timer2lbl.Text = ": 00:00";
            Timerlbl.Text = "00:00";
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }
                //reset game table
                MySqlCommand cmd = new MySqlCommand("UPDATE `game` SET `game_status`='none',`peserta`='none',`time`='00:00:00',`timer`=0,`plus_scores`=0,`minus_scores`=0", db.conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void Timercmb_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Minutetxt.Text = Timercmb.Text;
        //}

        private void MinuteMinusbtn_Click(object sender, EventArgs e)
        {
            Minutetxt.Text = (Int32.Parse(Minutetxt.Text) - 1).ToString();
        }

        private void MinutePlusbtn_Click(object sender, EventArgs e)
        {
            Minutetxt.Text = (Int32.Parse(Minutetxt.Text) + 1).ToString();
        }
    }


}

