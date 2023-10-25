using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app_lomba_cerdas_cermat.Form.Sub_form;
using Krypton.Toolkit;

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

        }

        private void Game1_Click(object sender, EventArgs e)
        {
            Game1frm game1Frm = new Game1frm();
            game1Frm.Show();
        }
        private void Game2btn_Click(object sender, EventArgs e)
        {
            Game2frm game2Frm = new Game2frm();
            game2Frm.Show();
        }


        private void Game3btn_Click(object sender, EventArgs e)
        {
            Game3frm game3Frm = new Game3frm();
            game3Frm.Show();
        }
        private void AddScoresbtn_Click(object sender, EventArgs e)
        {
            AddScores addScores = new AddScores();
            addScores.Show();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Tidakan Ini Akan Mereset Keseluruhan Scores dan Game", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);
            if (confirm == DialogResult.OK)
            {
                try
                {

                }
                catch
                {
                }
            }
        }

    }
}
