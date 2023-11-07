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
using Org.BouncyCastle.Crmf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace app_lomba_cerdas_cermat.Form.Sub_form
{
    public partial class PesertaTimer : KryptonForm
    {
        private SoundPlayer _timesUpSound = new SoundPlayer("times_up_sound.wav");
        public int timer = 1;
        public string username;
        public PesertaTimer()
        {
            InitializeComponent();
        }

        private void PesertaTimer_Load(object sender, EventArgs e)
        {
            GameTimer.Enabled = true;
            Timerlbl.Left = (this.ClientSize.Width - Timerlbl.Width) / 2;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            GameTimer.Enabled = false;
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }
                db.cmd = new MySqlCommand("select * from game where peserta != '" + username + "'", db.conn);
                db.reader = db.cmd.ExecuteReader();
                if (db.reader.Read())
                {
                    timer = 1;
                }
                db.reader.Close();
            }
            catch (Exception ex)
            {
                db.reader.Close();
                //MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                GameTimer.Enabled = true;
            }

            timer -= 1;
            var minute = timer / 60;
            var second = timer % 60;

            //waktu habis
            Timerlbl.Text = (minute < 10 ? "0" : "") + minute + ":" + (second < 10 ? "0" : "") + second;
            if (timer <= 0)
            {
                //reset
                GameTimer.Enabled = false;
                _timesUpSound.Play();
                this.Close();
            }
        }
    }
}
