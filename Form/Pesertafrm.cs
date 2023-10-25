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

        private static bool NoUser()
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
                    if (reader["peserta"].ToString() == "none")
                    {
                        reader.Close();
                        return true;
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        private void Pesertafrm_Load(object sender, EventArgs e)
        {
            TimerCheckUser.Enabled = true;
        }
        private void Spacebtn_Click(object sender, EventArgs e)
        {
            _sound.Play();
            if (NoUser())
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
                catch
                {
                }
            }
        }

        private void TimerCheckUser_Tick(object sender, EventArgs e)
        {
            if (NoUser())
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
