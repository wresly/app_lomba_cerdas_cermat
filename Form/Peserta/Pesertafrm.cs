using System;
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

namespace app_lomba_cerdas_cermat.Form
{
    public partial class Pesertafrm : KryptonForm
    {
        public string username;
        bool spaceBtn = false;
        PesertaScoresfrm scorefrm;
        private SoundPlayer _sound = new SoundPlayer("sound.wav");
        public Pesertafrm()
        {
            InitializeComponent();
        }

        private bool ActiveUser()
        {
            TimerCheckUser.Enabled = false;
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }
                db.cmd = new MySqlCommand("select * from game", db.conn);
                db.reader = db.cmd.ExecuteReader();
                if (db.reader.Read())
                {
                    if (db.reader["peserta"].ToString() == username)
                    {
                        db.reader.Close();
                        return true;
                    }
                }
                db.reader.Close();
            }
            catch (Exception ex)
            {
                db.reader.Close();
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                TimerCheckUser.Enabled = true;
            }
            return false;
        }
        private bool NoUser()
        {
            TimerCheckUser.Enabled = false;
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }
                db.cmd = new MySqlCommand("select * from game", db.conn);
                db.reader = db.cmd.ExecuteReader();
                if (db.reader.Read())
                {
                    if (db.reader["peserta"].ToString() == "none" && (db.reader["game_status"].ToString() == "game 3" || db.reader["game_status"].ToString() == "game 2"))
                    {
                        db.reader.Close();
                        return true;
                    }
                }
                db.reader.Close();
            }
            catch (Exception ex)
            {
                db.reader.Close();
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                TimerCheckUser.Enabled = true;
            }
            return false;
        }

        private bool notBlacklist()
        {
            TimerCheckUser.Enabled = false;
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }
                db.cmd = new MySqlCommand("select * from game_blacklist where peserta = '" + username + "'", db.conn);
                db.reader = db.cmd.ExecuteReader();
                if (db.reader.HasRows)
                {
                    db.reader.Close();
                    return false;
                }
                db.reader.Close();
            }
            catch (Exception ex)
            {
                db.reader.Close();
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                TimerCheckUser.Enabled = true;
            }
            return true;
        }

        private void Pesertafrm_Load(object sender, EventArgs e)
        {
            scorefrm = new PesertaScoresfrm();
            scorefrm.TopLevel = false;
            Pesertapnl.Controls.Add(scorefrm);


            scorefrm.username = username;
            scorefrm.Show();

            scorefrm.Width = Pesertapnl.Width;
            scorefrm.Height = Pesertapnl.Height;
            TimerCheckUser.Enabled = true;
        }

        //handle space button clicked
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Space && spaceBtn)
            {
                _sound.Play();
                if (NoUser() || notBlacklist())
                {
                    try
                    {
                        if (db.conn.State == ConnectionState.Closed)
                        {
                            db.conn.Open();

                        }

                        db.cmd = new MySqlCommand("select * from game", db.conn);
                        db.reader = db.cmd.ExecuteReader();
                        if (db.reader.Read())
                        {
                            DateTime time = DateTime.ParseExact(db.reader["time"].ToString(), "HH:mm:ss", null);
                            DateTime currentTime = DateTime.Now;
                            time = time.AddSeconds(double.Parse(db.reader["timer"].ToString()));
                            if (time > currentTime || (db.reader["game_status"].ToString() == "game 3" && db.reader["answer_status"].ToString() != "2" && db.reader["peserta"].ToString() == "none"))
                            {

                                if (db.reader["game_status"].ToString() == "game 2")
                                {

                                    db.reader.Close();
                                    TimeSpan timeDifference = time - currentTime;
                                    if ((int)timeDifference.TotalSeconds < 10)
                                    {
                                        int secondTemp = (10 - (int)timeDifference.TotalSeconds) + 2;
                                        db.cmd = new MySqlCommand("UPDATE `game` SET `peserta` = '" + username + "', `timer`=timer + " + secondTemp, db.conn);
                                        db.cmd.ExecuteNonQuery();
                                    }
                                    else
                                    {
                                        db.cmd = new MySqlCommand("update game set peserta = '" + username + "'", db.conn);
                                        db.cmd.ExecuteNonQuery();
                                    }
                                }
                                else if (db.reader["game_status"].ToString() == "game 3")
                                {
                                    if (db.reader["answer_status"].ToString() == "2")
                                    {
                                        db.reader.Close();
                                        TimeSpan timeDifference = time - currentTime;
                                        if ((int)timeDifference.TotalSeconds < 10)
                                        {
                                            int secondTemp = (10 - (int)timeDifference.TotalSeconds) + 2;
                                            db.cmd = new MySqlCommand("UPDATE `game` SET `peserta` = '" + username + "', `timer`=timer + " + secondTemp, db.conn);
                                            db.cmd.ExecuteNonQuery();
                                        }
                                        else
                                        {
                                            db.cmd = new MySqlCommand("update game set peserta = '" + username + "'", db.conn);
                                            db.cmd.ExecuteNonQuery();
                                        } 
                                    }
                                    else
                                    {
                                        db.reader.Close();
                                        db.cmd = new MySqlCommand("update game set peserta = '" + username + "', `time`='" + DateTime.Now.ToLongTimeString() + "'", db.conn);
                                        db.cmd.ExecuteNonQuery(); 
                                    }
                                }
                                db.reader.Close();
                            }
                            db.reader.Close();
                        }
                        db.reader.Close();
                    }
                    catch (Exception ex)
                    {
                        db.reader.Close();
                        MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void TimerCheckUser_Tick(object sender, EventArgs e)
        {
            if (NoUser() && notBlacklist())
            {
                spaceBtn = true;
                BackColorTimer.Enabled = false;
                scorefrm.BackColor = Color.FromArgb(137, 253, 137);
            }
            else if (!notBlacklist())
            {
                spaceBtn = false;
                BackColorTimer.Enabled = false;
                scorefrm.BackColor = Color.FromArgb(253, 74, 27);
            }
            else if (ActiveUser())
            {
                spaceBtn = false;
                BackColorTimer.Enabled = true;
            }
            else
            {
                spaceBtn = false;
                BackColorTimer.Enabled = false;
                scorefrm.BackColor = Color.FromArgb(232, 232, 231);
            }
            TimerCheckUser.Enabled = false;
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }
                db.cmd = new MySqlCommand("select * from game where peserta = '" + username + "'", db.conn);
                db.reader = db.cmd.ExecuteReader();
                if (db.reader.HasRows)
                {
                    db.reader.Read();
                    DateTime time = DateTime.ParseExact(db.reader["time"].ToString(), "HH:mm:ss", null);
                    DateTime currentTime = DateTime.Now;
                    time = time.AddSeconds(double.Parse(db.reader["timer"].ToString()));
                    if (time > currentTime)
                    {
                        db.reader.Close();
                        PesertaTimer pesertaTimer = new PesertaTimer();
                        TimeSpan timeDifference = time - currentTime;
                        pesertaTimer.timer = (int)timeDifference.TotalSeconds;
                        pesertaTimer.username = username;
                        pesertaTimer.ShowDialog();
                    }
                }
                db.reader.Close();
            }
            catch (Exception ex)
            {
                db.reader.Close();
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                TimerCheckUser.Enabled = true;
            }
        }

        private void BackColorTimer_Tick(object sender, EventArgs e)
        {
            if (scorefrm.BackColor != Color.White)
            {
                scorefrm.BackColor = Color.White;
            }
            else
            {
                scorefrm.BackColor = Color.FromArgb(228, 236, 39);
            }
        }
    }
}
