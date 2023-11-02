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

namespace app_lomba_cerdas_cermat.Form.Sub_form
{
    public partial class AnswerCheckerUser : KryptonForm
    {
        private SoundPlayer _soundTest = new SoundPlayer("times_up_sound.wav");
        private SoundPlayer _correctSound = new SoundPlayer("correct-sound.wav");
        private SoundPlayer _wrongSound = new SoundPlayer("wrong-sound.wav");
        public int timer = 0;
        public AnswerCheckerUser()
        {
            InitializeComponent();
        }

        private void TimerGamefrm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Timerlbl.Left = (this.ClientSize.Width - Timerlbl.Width) / 2;
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
                //reset
                timer1.Enabled = false;
                _soundTest.Play();
            }
        }

        private void Benarbtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.DialogResult = DialogResult.OK;
            _correctSound.Play();
            this.Close();
        }

        private void Salahbtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.DialogResult = DialogResult.Cancel;
            _wrongSound.Play();
            this.Close();
        }


    }
}
