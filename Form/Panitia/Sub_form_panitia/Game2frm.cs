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
        Waitingfrm waitingfrm;
        private bool isWaitingFormVisible = false;
        string peserta;
        int scores;


        public Game2frm()
        {
            InitializeComponent();
        }

        private void continueGame()
        {
            timer1.Enabled = false;
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }
                //reset game table
                db.cmd = new MySqlCommand("select * from game", db.conn);
                db.reader = db.cmd.ExecuteReader();
                db.reader.Read();
                if (db.reader["answer_status"].ToString() == "2")
                {
                    if (db.reader["peserta"].ToString() != "none")
                    {
                        peserta = db.reader["peserta"].ToString();

                        //checked user answer 
                        if (isWaitingFormVisible)
                        {
                            waitingfrm.Close();
                        }
                        AnswerCheckerUser answerCheckerUser = new AnswerCheckerUser();
                        answerCheckerUser.timer = Int32.Parse(db.reader["timer"].ToString());
                        db.reader.Close();
                        answerCheckerUser.ShowDialog();

                        //true
                        if (answerCheckerUser.DialogResult == DialogResult.OK)
                        {
                            try
                            {
                                if (db.conn.State == ConnectionState.Closed)
                                {
                                    db.conn.Open();

                                }
                                db.cmd = new MySqlCommand("UPDATE users SET scores = scores + " + Int32.Parse(Scorestxt.Text) + " WHERE username = '" + peserta + "'", db.conn);
                                db.cmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            Resetbtn.Enabled = false;
                            reset();
                            reLoad();
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
                                db.cmd = new MySqlCommand("INSERT INTO `game_blacklist`(`peserta`) VALUES ('" + peserta + "')", db.conn);
                                db.cmd.ExecuteNonQuery();

                                // continue game
                                db.cmd = new MySqlCommand("UPDATE `game` SET `game_status`='game 2', `peserta` = 'none',`time`='" + DateTime.Now.ToLongTimeString() + "', `timer`= 30, `answer_status`=2", db.conn);
                                db.cmd.ExecuteNonQuery();

                                //reset if no more peserta
                                if (Pesertacmb.Items.Count == 0)
                                {
                                    Scorestxt.Text = "";
                                    Minutetxt.Text = "00";
                                    Secondtxt.Text = "00";
                                    reset();
                                    reLoad();
                                }

                                return;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                    else
                    {
                        db.reader.Close();
                        if (!isWaitingFormVisible)
                        {
                            waitingfrm = new Waitingfrm();
                            waitingfrm.FormClosed += (sender, e) => cancelFrm(); // Update the flag when the form is closed
                            waitingfrm.ShowDialog();
                            isWaitingFormVisible = true; // Set the flag to indicate the form is now visible
                        }
                    }
                }
                db.reader.Close();
                db.reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                timer1.Enabled = true;
            }
        }

        private void cancelFrm()
        {
            timer1.Enabled = false;
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }
                isWaitingFormVisible = false;
                db.cmd = new MySqlCommand("select * from game", db.conn);
                db.reader = db.cmd.ExecuteReader();
                if (db.reader.HasRows)
                {

                    db.reader.Read();
                    DateTime time = DateTime.ParseExact(db.reader["time"].ToString(), "HH:mm:ss", null);
                    DateTime currentTime = DateTime.Now;
                    time = time.AddSeconds(Int32.Parse(db.reader["timer"].ToString()));
                    db.reader.Close();
                    if (time > currentTime)
                    {
                        reset();
                        reLoad();
                        //reset controls
                        Pesertacmb.SelectedIndex = 0;
                        Pesertacmb.Enabled = true;
                        Scorestxt.Enabled = true;
                        Minutetxt.Enabled = true;
                        Secondtxt.Enabled = true;
                        Startbtn.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                timer1.Enabled = true;
            }

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
                db.cmd = new MySqlCommand("UPDATE `game` SET `game_status`='none',`peserta`='none',`time`='00:00:00',`timer`=0,`plus_scores`=0,`minus_scores`=0", db.conn);
                db.cmd.ExecuteNonQuery();

                //reset blacklist
                db.cmd = new MySqlCommand("DELETE FROM `game_blacklist`", db.conn);
                db.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                db.cmd = new MySqlCommand("SELECT * FROM users LEFT JOIN game_blacklist on users.username = game_blacklist.peserta WHERE users.usertype = 1 AND game_blacklist.peserta IS NULL;", db.conn);
                db.reader = db.cmd.ExecuteReader();
                while (db.reader.Read())
                {
                    Pesertacmb.Items.Add(db.reader["username"].ToString());
                }
                db.reader.Close();
                Pesertacmb.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void Game2frm_Load(object sender, EventArgs e)
        {
            //cek for reset
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }

                //checked game data
                db.cmd = new MySqlCommand("select * from game where game_status = 'game 2'", db.conn);
                db.reader = db.cmd.ExecuteReader();
                if (db.reader.HasRows && db.reader.Read())
                {
                    MessageBox.Show("terjadi kesalahan, mohon restart game", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Scorestxt.Text = db.reader["plus_scores"].ToString();
                    Resetbtn.Enabled = true;
                    Startbtn.Enabled = false;
                    Statuslbl.Text = "Error need reset";
                    db.reader.Close();
                    reLoad();
                    return;
                }
                db.reader.Close();

                //checked blacklist
                db.cmd = new MySqlCommand("SELECT * FROM `game_blacklist`", db.conn);
                db.reader = db.cmd.ExecuteReader();
                if (db.reader.HasRows)
                {
                    MessageBox.Show("daftar blacklist tidak kosong, mohon direset untuk menghapus daftar blacklist", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Resetbtn.Enabled = true;
                }
                db.reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            reLoad();
            timer1.Enabled = true;
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
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

            //game status
            Statuslbl.Text = ": started";
            Pesertalbl.Text = ": " + Pesertacmb.Text;
            Scoreslbl.Text = ": " + Scorestxt.Text;
            Timerlbl.Text = ": " + (Minutetxt.Text.Length == 1 ? "0" : "") + Minutetxt.Text + ":" + (Secondtxt.Text.Length == 1 ? "0" : "") + Secondtxt.Text;


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
                db.cmd = new MySqlCommand("UPDATE `game` SET `game_status`='game 2', `peserta` = '" + peserta + "',`time`='" + DateTime.Now.ToLongTimeString() + "', `timer`= " + (Int32.Parse(Minutetxt.Text) * 60 + Int32.Parse(Secondtxt.Text)) + ", `plus_scores`=" + Scorestxt.Text, db.conn);
                db.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //checked user answer 
            AnswerCheckerUser answerCheckerUser = new AnswerCheckerUser();
            answerCheckerUser.timer = Int32.Parse(Minutetxt.Text) * 60 + Int32.Parse(Secondtxt.Text);
            answerCheckerUser.ShowDialog();
            timer1.Enabled = true;
            //true
            if (answerCheckerUser.DialogResult == DialogResult.OK)
            {
                try
                {
                    if (db.conn.State == ConnectionState.Closed)
                    {
                        db.conn.Open();

                    }
                    db.cmd = new MySqlCommand("UPDATE users SET scores = scores + " + Int32.Parse(Scorestxt.Text) + " WHERE username = '" + peserta + "'", db.conn);
                    db.cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Resetbtn.Enabled = false;
                reset();
                reLoad();

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
                    db.cmd = new MySqlCommand("INSERT INTO `game_blacklist`(`peserta`) VALUES ('" + peserta + "')", db.conn);
                    db.cmd.ExecuteNonQuery();

                    // continue game
                    db.cmd = new MySqlCommand("UPDATE `game` SET `game_status`='game 2', `peserta` = 'none',`time`='" + DateTime.Now.ToLongTimeString() + "', `timer`= 30, `answer_status`=2", db.conn);
                    db.cmd.ExecuteNonQuery();

                    //reset if no more peserta
                    if (Pesertacmb.Items.Count == 0)
                    {
                        Scorestxt.Text = "";
                        Minutetxt.Text = "00";
                        Secondtxt.Text = "00";
                        reset();
                        reLoad();
                    }

                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //reset controls
            Pesertacmb.SelectedIndex = 0;
            Pesertacmb.Enabled = true;
            Scorestxt.Enabled = true;
            Minutetxt.Enabled = true;
            Secondtxt.Enabled = true;
            Startbtn.Enabled = true;

            //reset status
            Statuslbl.Text = ": not started";
            Pesertalbl.Text = ": -";
            Scoreslbl.Text = ": -";
            Timerlbl.Text = ": 00:00";

            //Update game table
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }
                db.cmd = new MySqlCommand("UPDATE `game` SET `game_status`='none', `peserta` = 'none',`time`='00:00:00', `timer`= 0,`plus_scores`=0,`minus_scores`=0", db.conn);
                db.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Tidakan Ini Akan Mereset Game", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (confirm == DialogResult.OK)
            {
                Resetbtn.Enabled = false;
                Startbtn.Enabled = true;
                reset();
                reLoad();
            }
        }

        private void Scorescmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Scorestxt.Text = Scorescmb.Text;
        }

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            continueGame();
        }
    }
}
