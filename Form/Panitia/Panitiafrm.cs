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
    public partial class Panitiafrm : KryptonForm
    {
        MainGame mainGame;
        DataPesertafrm dataPesertafrm;
        Settingfrm settingfrm;
        MainBoard mainBoard;
        public Panitiafrm()
        {
            InitializeComponent();
        }

        private void Panitiafrm_Load(object sender, EventArgs e)
        {
            mainGame = new MainGame();
            mainGame.TopLevel = false;
            Mainpnl.Controls.Add(mainGame);

            mainGame.Show();

            kryptonPanel2.Hide();
        }

        private void Gamebtn_Click(object sender, EventArgs e)
        {
            mainGame = new MainGame();
            mainGame.TopLevel = false;
            Mainpnl.Controls.Add(mainGame);

            mainGame.Show();
            if (dataPesertafrm != null && !dataPesertafrm.IsDisposed)
            {
                dataPesertafrm.Close();
            }
            if (mainBoard != null && !mainBoard.IsDisposed)
            {
                mainBoard.Close();
            }
        }

        //private void DataPesertabtn_Click(object sender, EventArgs e)
        //{
        //    dataPesertafrm = new DataPesertafrm();
        //    dataPesertafrm.TopLevel = false;
        //    Mainpnl.Controls.Add(dataPesertafrm);


        //    dataPesertafrm.Show();
        //    if (mainGame != null && !mainGame.IsDisposed)
        //    {
        //        mainGame.Close();
        //    }
        //    if (mainBoard != null && !mainBoard.IsDisposed)
        //    {
        //        mainBoard.Close();
        //    }

        //    dataPesertafrm.Height = Mainpnl.Height;
        //    dataPesertafrm.Width = Mainpnl.Width;
        //}

        private void ScoreBoardbtn_Click(object sender, EventArgs e)
        {
            mainBoard = new MainBoard();
            mainBoard.TopLevel = false;
            Mainpnl.Controls.Add(mainBoard);

            mainBoard.Show();
            if (mainGame != null && !mainGame.IsDisposed)
            {
                mainGame.Close();
            }
            if (dataPesertafrm != null && !dataPesertafrm.IsDisposed)
            {
                dataPesertafrm.Close();
            }

            mainBoard.Height = Mainpnl.Height;
            mainBoard.Width = Mainpnl.Width;
        }


        private void Closebtn_Click(object sender, EventArgs e)
        {
            Openbtn.Show();
            kryptonPanel2.Hide();
        }

        private void Openbtn_Click(object sender, EventArgs e)
        {
            Openbtn.Hide();
            kryptonPanel2.Show();
        }

        private void Keluarbtn_click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Yakin Ingin Keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (msg == DialogResult.Yes)
            {
                this.MdiParent.Close();
            }
        }
    }
}
