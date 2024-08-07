﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app_lomba_cerdas_cermat.Classes;
using app_lomba_cerdas_cermat.Form.Sub_form;
using Krypton.Toolkit;
using MySql.Data.MySqlClient;

namespace app_lomba_cerdas_cermat.Form.Panitia.Sub_form_panitia
{
    public partial class Game1TimerOnlyfrm : KryptonForm
    {
        int timer;
        private SoundPlayer _timesUpSound = new SoundPlayer("times_up_sound.wav");
        public Game1TimerOnlyfrm()
        {
            InitializeComponent();
        }


        //helper
        private void MinuteMinusbtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Minutetxt.Text, out _))
            {
                Minutetxt.Text = "0";
            }
            Minutetxt.Text = (Int32.Parse(Minutetxt.Text) - 1).ToString();
        }

        private void MinutePlusbtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Minutetxt.Text, out _))
            {
                Minutetxt.Text = "0";
            }
            Minutetxt.Text = (Int32.Parse(Minutetxt.Text) + 1).ToString();
        }

        private void Secondcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Secondtxt.Text = Secondcmb.Text;
        }

        private void Seconds15btn_Click(object sender, EventArgs e)
        {
            Secondtxt.Text = "15";
        }

        private void Seconds30btn_Click(object sender, EventArgs e)
        {
            Secondtxt.Text = "30";
        }

        private void Seconds60btn_Click(object sender, EventArgs e)
        {
            Secondtxt.Text = "60";
        }
        //

        private void Game1TimerOnlyfrm_Load(object sender, EventArgs e)
        {
            this.FormClosed += (sender, e) => CountDownTimer.Enabled = false;
            Finishbtn.Enabled = false;

            //cek for running game
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }

                //runnning game checker
                db.cmd = new MySqlCommand("select * from game where game_status = 'game 1'", db.conn);
                db.reader = db.cmd.ExecuteReader();
                if (db.reader.Read())
                {
                    DateTime time = DateTime.ParseExact(db.reader["time"].ToString(), "HH:mm:ss", null);
                    DateTime currentTime = DateTime.Now;
                    time = time.AddSeconds(Int32.Parse(db.reader["timer"].ToString()));
                    if (time > currentTime)
                    {
                        //timer
                        TimeSpan timeDifference = time - currentTime;
                        timer = (int)timeDifference.TotalSeconds;
                        CountDownTimer.Enabled = true;

                        //game status
                        Timerlbl.Text = ": " + ((int)timeDifference.TotalSeconds / 60 < 9 ? "0" : "") + (int)timeDifference.TotalSeconds / 60 + ":" + ((int)timeDifference.TotalSeconds % 60 < 9 ? "0" : "") + (int)timeDifference.TotalSeconds % 60;

                        //controls enabled/disabled
                        Startbtn.Enabled = false;
                        Resetbtn.Enabled = true;
                        Finishbtn.Enabled = true;

                        db.reader.Close();
                        MessageBox.Show("game masih berjalan", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        db.reader.Close();
                        MessageBox.Show("game telah selesai mohon reset game", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Startbtn.Enabled = false;
                        Resetbtn.Enabled = true;
                    }
                }
                db.reader.Close();
            }
            catch (Exception ex)
            {
                db.reader.Close();
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void CountDownTimer_Tick(object sender, EventArgs e)
        {
            timer -= 1;
            var minute = timer / 60;
            var second = timer % 60;

            Timerlbl.Text = (minute < 10 ? "0" : "") + minute + ":" + (second < 10 ? "0" : "") + second;
            //waktu habis
            if (timer <= 0)
            {
                //reset game status
                Timerlbl.Text = "00:00";

                //controls enabled/disabled
                CountDownTimer.Enabled = false;
                Resetbtn.Enabled = false;
                Finishbtn.Enabled = false;
                Startbtn.Enabled = true;
                _timesUpSound.Play();

                //reset game
                try
                {
                    db.cmd = new MySqlCommand("UPDATE `game` SET `game_status`='none',`peserta`='none',`time`='00:00:00',`timer`=0,`plus_scores`=0,`minus_scores`=0,`answer_status`=0", db.conn);
                    db.cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    db.reader.Close();
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            //validasi
            if ((Secondtxt.Text == "00" && Minutetxt.Text == "00") || Secondtxt.Text.Trim() == "" || Minutetxt.Text.Trim() == "")
            {
                MessageBox.Show("Atur Timer!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Startbtn.Enabled = true;
                return;
            }

            if (!int.TryParse(Minutetxt.Text, out _) || !int.TryParse(Secondtxt.Text, out _))
            {
                MessageBox.Show("Timer Harus Angka!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Startbtn.Enabled = true;
                return;
            }

            timer = Int32.Parse(Minutetxt.Text) * 60 + Int32.Parse(Secondtxt.Text);

            //controls enabled/disabled
            Startbtn.Enabled = false;
            Resetbtn.Enabled = true;
            CountDownTimer.Enabled = true;
            Finishbtn.Enabled = true;

            //update game data
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();
                }
                db.cmd = new MySqlCommand("UPDATE game SET game_status='game 1',`time`='" + DateTime.Now.ToLongTimeString() + "',`timer`=" + (timer + db.dbDelayTimer) + " WHERE 1", db.conn);
                db.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                db.reader.Close();
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            timer += db.dbDelayTimer - 0;
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
            CountDownTimer.Enabled = false;

            Timerlbl.Text = ": 00:00";

            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }
                //reset game table
                db.cmd = new MySqlCommand("UPDATE `game` SET `game_status`='none',`peserta`='none',`time`='00:00:00',`timer`=0,`plus_scores`=0,`minus_scores`=0,`answer_status`=0", db.conn);
                db.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                db.reader.Close();
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
