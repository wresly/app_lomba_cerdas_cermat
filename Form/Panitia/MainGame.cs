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
using app_lomba_cerdas_cermat.Form.Panitia.Sub_form_panitia;
using app_lomba_cerdas_cermat.Form.Sub_form;
using Krypton.Toolkit;
using MySql.Data.MySqlClient;

namespace app_lomba_cerdas_cermat.Form
{
    public partial class MainGame : KryptonForm
    {
        public MainGame()
        {
            InitializeComponent();
        }

        private void MainGame_Load(object sender, EventArgs e)
        {
            GameCheckerTimer.Enabled = true;
        }

        private void Game1_Click(object sender, EventArgs e)
        {
            Game1frm game1Frm = new Game1frm();
            GameCheckerTimer.Enabled = false;
            game1Frm.ShowDialog();
            GameCheckerTimer.Enabled = true;
        }
        private void Game2btn_Click(object sender, EventArgs e)
        {
            Game2frm game2Frm = new Game2frm();
            GameCheckerTimer.Enabled = false;
            game2Frm.ShowDialog();
            GameCheckerTimer.Enabled = true;
        }


        private void Game3btn_Click(object sender, EventArgs e)
        {
            Game3frm game3Frm = new Game3frm();
            GameCheckerTimer.Enabled = false;
            game3Frm.ShowDialog();
            GameCheckerTimer.Enabled = true;
        }
        private void AddScoresbtn_Click(object sender, EventArgs e)
        {
            AddScores addScores = new AddScores();
            GameCheckerTimer.Enabled = false;
            addScores.ShowDialog();
            GameCheckerTimer.Enabled = true;
        }

        private void Timerbtn_Click(object sender, EventArgs e)
        {
            Game1TimerOnlyfrm game1TimerFrm = new Game1TimerOnlyfrm();
            GameCheckerTimer.Enabled = false;
            game1TimerFrm.ShowDialog();
            GameCheckerTimer.Enabled = true;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Tidakan Ini Akan Mereset Keseluruhan Peserta dan Game", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (confirm == DialogResult.OK)
            {
                try
                {
                    if (db.conn.State == ConnectionState.Closed)
                    {
                        db.conn.Open();

                    }

                    //reset scores
                    db.cmd = new MySqlCommand("UPDATE `users` SET `peserta`='', `scores`= 0", db.conn);
                    db.cmd.ExecuteNonQuery();

                    //reset game
                    db.cmd = new MySqlCommand("UPDATE `game` SET `game_status`='none',`peserta`='none',`time`='00:00:00',`timer`=0,`plus_scores`=0,`minus_scores`=0,`answer_status`=0", db.conn);
                    db.cmd.ExecuteNonQuery();

                    //reset blacklist
                    db.cmd = new MySqlCommand("DELETE FROM `game_blacklist`", db.conn);
                    db.cmd.ExecuteNonQuery();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void GameCheckerTimer_Tick(object sender, EventArgs e)
        {
            GameCheckerTimer.Enabled = false;
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
                    if (db.reader["game_status"].ToString() == "game 1")
                    {
                        GameStatuslbl.Text = "Game Status : Game 1";
                        Timerbtn.Enabled = true;
                        Game1btn.Enabled = true;
                        Game2btn.Enabled = false;
                        Game3btn.Enabled = false;
                        AddScoresbtn.Enabled = false;
                    }

                    if (db.reader["game_status"].ToString() == "game 2")
                    {
                        GameStatuslbl.Text = "Game Status : Game 2";
                        Timerbtn.Enabled = false;
                        Game1btn.Enabled = false;
                        Game2btn.Enabled = true;
                        Game3btn.Enabled = false;
                        AddScoresbtn.Enabled = false;
                    }

                    if (db.reader["game_status"].ToString() == "game 3")
                    {
                        GameStatuslbl.Text = "Game Status : Game 3";
                        Timerbtn.Enabled = false;
                        Game1btn.Enabled = false;
                        Game2btn.Enabled = false;
                        Game3btn.Enabled = true;
                        AddScoresbtn.Enabled = false;
                    }

                    if (db.reader["game_status"].ToString() == "none")
                    {
                        GameStatuslbl.Text = "Game Status : none";
                        Timerbtn.Enabled = true;
                        Game1btn.Enabled = true;
                        Game2btn.Enabled = true;
                        Game3btn.Enabled = true;
                        AddScoresbtn.Enabled = true;
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
                GameCheckerTimer.Enabled = true;
            }
        }


    }
}
