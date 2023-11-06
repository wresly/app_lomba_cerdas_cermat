﻿using System;
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

        private void reset()
        {
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }
                //reset game table
                db.cmd = new MySqlCommand("UPDATE `game` SET `game_status`='none', `peserta`='none', `time`='00:00:00', `timer`=0, `plus_scores`=0, `minus_scores`=0, `answer_status`=0", db.conn);
                db.cmd.ExecuteNonQuery();

                //reset blacklist
                db.cmd = new MySqlCommand("DELETE FROM `game_blacklist`", db.conn);
                db.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Resetbtn.Enabled = false;
        }

        private void Game3frm_Load(object sender, EventArgs e)
        {
            //cek for reset
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }

                //checked asigned peserta to game
                db.cmd = new MySqlCommand("SELECT * FROM `game` WHERE game_status = 'game 3'", db.conn);
                db.reader = db.cmd.ExecuteReader();
                if (db.reader.HasRows)
                {
                    db.reader.Read();
                    Statuslbl.Text = ": Error need reset";
                    Pesertalbl.Text = ": " + (db.reader["peserta"].ToString() == "none" ? "-" : db.reader["peserta"].ToString());
                    Pluslbl.Text = ": error";
                    Minuslbl.Text = ": error";
                    Timerlbl.Text = ": " + (Int32.Parse(db.reader["timer"].ToString()) / 60 < 9 ? "0" : "") + Int32.Parse(db.reader["timer"].ToString()) / 60 + ":" + (Int32.Parse(db.reader["timer"].ToString()) % 60 < 9 ? "0" : "") + Int32.Parse(db.reader["timer"].ToString()) % 60;

                    Resetbtn.Enabled = true;
                    db.reader.Close();
                    MessageBox.Show("terjadi kesalahan, mohon restart game", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                db.reader.Close();

                //checked blacklist
                db.cmd = new MySqlCommand("SELECT * FROM `game_blacklist`", db.conn);
                db.reader = db.cmd.ExecuteReader();
                if (db.reader.HasRows)
                {
                    Resetbtn.Enabled = true;
                    db.reader.Close();
                    MessageBox.Show("daftar blacklist tidak kosong, mohon direset untuk menghapus daftar blacklist", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                db.reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Statuslbl.Text = ": waiting";
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
                db.cmd = new MySqlCommand("UPDATE `game` SET `game_status`='game 3', `timer`= " + (Int32.Parse(Minutetxt.Text) * 60 + Int32.Parse(Secondtxt.Text)) + ", `plus_scores`= " + Plustxt.Text + ", `minus_scores`= " + Minustxt.Text, db.conn);
                db.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //waiting user
            Waitingfrm waitingfrm = new Waitingfrm();
            waitingfrm.ShowDialog();
            if (waitingfrm.DialogResult == DialogResult.OK)
            {
                peserta = waitingfrm.peserta;
                Pesertalbl.Text = waitingfrm.peserta;

                AnswerCheckerUser answerCheckerUser = new AnswerCheckerUser();
                answerCheckerUser.timer = Int32.Parse(Minutetxt.Text) * 60 + Int32.Parse(Secondtxt.Text);
                answerCheckerUser.ShowDialog();

                //true answer
                if (answerCheckerUser.DialogResult == DialogResult.OK)
                {
                    reset();
                    try
                    {
                        if (db.conn.State == ConnectionState.Closed)
                        {
                            db.conn.Open();

                        }
                        db.cmd = new MySqlCommand("UPDATE users SET scores = scores + " + Int32.Parse(Plustxt.Text) + " WHERE username = '" + peserta + "'", db.conn);
                        db.cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        db.cmd = new MySqlCommand("UPDATE users SET scores = scores - " + Int32.Parse(Minustxt.Text) + " WHERE username = '" + peserta + "'", db.conn);
                        db.cmd.ExecuteNonQuery();

                        //blacklist peserta
                        db.cmd = new MySqlCommand("INSERT INTO `game_blacklist`(`peserta`) VALUES ('" + peserta + "')", db.conn);
                        db.cmd.ExecuteNonQuery();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Startbtn.Enabled = true;
                }
            }

            //cancel
            if (waitingfrm.DialogResult == DialogResult.Abort)
            {
                Startbtn.Enabled = true;
                //reset();
            }

            //reset game table
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }
                //reset game table
                db.cmd = new MySqlCommand("UPDATE `game` SET `game_status`='none', `peserta`='none', `time`='00:00:00', `timer`=0, `plus_scores`=0, `minus_scores`=0,`answer_status`=0", db.conn);
                db.cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //enabled form
            Plustxt.Enabled = true;
            Minustxt.Enabled = true;
            Minutetxt.Enabled = true;
            Secondtxt.Enabled = true;
            Startbtn.Enabled = true;

            //game status
            Statuslbl.Text = ": Not Started";
            Pesertalbl.Text = ": -";
            Pluslbl.Text = ": -";
            Minuslbl.Text = ": -";
            Timerlbl.Text = ": 00:00";

        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Tidakan Ini Akan Mereset Game", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (confirm == DialogResult.OK)
            {
                Startbtn.Enabled = true;
                reset();
            }
        }

        private void PlusScorescmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Plustxt.Text = PlusScorescmb.Text;
        }

        private void MinusScorescmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Minustxt.Text = MinusScorescmb.Text;
        }

        //private void Timercmb_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Minutetxt.Text = Timercmb.Text;
        //}

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
    }
}