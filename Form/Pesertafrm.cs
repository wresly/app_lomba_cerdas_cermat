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
using Krypton.Toolkit;
using MySql.Data.MySqlClient;

namespace app_lomba_cerdas_cermat.Form
{
    public partial class Pesertafrm : KryptonForm
    {
        public string username;
        private SoundPlayer _sound = new SoundPlayer("sound.wav");
        public Pesertafrm()
        {
            InitializeComponent();
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
                MySqlCommand cmd = new MySqlCommand("select * from game", db.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (reader["peserta"].ToString() == "none" && reader["game_status"].ToString() == "game 3")
                    {
                        reader.Close();
                        return true;
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
                MySqlCommand cmd = new MySqlCommand("select * from game_blacklist where peserta = '" + username + "'", db.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    return false;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
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
            TimerCheckUser.Enabled = true;
        }
        private void Spacebtn_Click(object sender, EventArgs e)
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
                    MySqlCommand cmd = new MySqlCommand("update game set peserta = '" + username + "'", db.conn);
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Spacebtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Spacebtn.PerformClick();
            }
        }
        private void Extendbtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Spacebtn.PerformClick();
            }
        }
        private void Pesertafrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Spacebtn.PerformClick();
            }
        }
        private void TimerCheckUser_Tick(object sender, EventArgs e)
        {
            if (NoUser() && notBlacklist())
            {
                Spacebtn.Enabled = true;
            }
            else
            {
                Spacebtn.Enabled = false;
            }
        }




        private void Extendbtn_Click(object sender, EventArgs e)
        {
            Extendbtn.Enabled = false;

            PesertaScoresfrm pesertaScoresfrm = new PesertaScoresfrm();
            pesertaScoresfrm.username = username;
            pesertaScoresfrm.Show();
            pesertaScoresfrm.FormClosed += new FormClosedEventHandler(pesertaScoresClosed);
        }
        private void pesertaScoresClosed(object sender, FormClosedEventArgs e)
        {
            Extendbtn.Enabled = true;
        }
    }
}
