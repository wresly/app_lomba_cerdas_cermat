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
            timer1.Enabled = true;
        }

        private void Game1_Click(object sender, EventArgs e)
        {
            Game1frm game1Frm = new Game1frm();
            timer1.Enabled = false;
            game1Frm.ShowDialog();
            timer1.Enabled = true;
        }
        private void Game2btn_Click(object sender, EventArgs e)
        {
            Game2frm game2Frm = new Game2frm();
            timer1.Enabled = false;
            game2Frm.ShowDialog();
            timer1.Enabled = true;
        }


        private void Game3btn_Click(object sender, EventArgs e)
        {
            Game3frm game3Frm = new Game3frm();
            timer1.Enabled = false;
            game3Frm.ShowDialog();
            timer1.Enabled = true;
        }
        private void AddScoresbtn_Click(object sender, EventArgs e)
        {
            AddScores addScores = new AddScores();
            timer1.Enabled = false;
            addScores.ShowDialog();
            timer1.Enabled = true;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Tidakan Ini Akan Mereset Keseluruhan Scores dan Game", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (confirm == DialogResult.OK)
            {
                try
                {
                    if (db.conn.State == ConnectionState.Closed)
                    {
                        db.conn.Open();

                    }

                    //reset scores
                    MySqlCommand cmd = new MySqlCommand("UPDATE `users` SET `scores`= 0", db.conn);
                    cmd.ExecuteNonQuery();

                    //reset game
                    cmd = new MySqlCommand("UPDATE `game` SET `game_status`='none',`peserta`='none',`timer`=0 ", db.conn);
                    cmd.ExecuteNonQuery();

                    //reset blacklist
                    cmd = new MySqlCommand("DELETE FROM `game_blacklist`", db.conn);
                    cmd.ExecuteNonQuery();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
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
                    if (reader["game_status"].ToString() == "game 1")
                    {
                        GameStatuslbl.Text = "Game Status : Game 1";
                        Game1btn.Enabled = true;
                        Game2btn.Enabled = false;
                        Game3btn.Enabled = false;
                        AddScoresbtn.Enabled = false;
                    }

                    if (reader["game_status"].ToString() == "game 2")
                    {
                        GameStatuslbl.Text = "Game Status : Game 2";
                        Game1btn.Enabled = false;
                        Game2btn.Enabled = true;
                        Game3btn.Enabled = false;
                        AddScoresbtn.Enabled = false;
                    }

                    if (reader["game_status"].ToString() == "game 3")
                    {
                        GameStatuslbl.Text = "Game Status : Game 3";
                        Game1btn.Enabled = false;
                        Game2btn.Enabled = false;
                        Game3btn.Enabled = true;
                        AddScoresbtn.Enabled = false;
                    }

                    if (reader["game_status"].ToString() == "none")
                    {
                        GameStatuslbl.Text = "Game Status : none";
                        Game1btn.Enabled = true;
                        Game2btn.Enabled = true;
                        Game3btn.Enabled = true;
                        AddScoresbtn.Enabled = true;
                    }
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                timer1.Enabled = true;
            }
        }
    }
}
