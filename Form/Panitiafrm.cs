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
        public Panitiafrm()
        {
            InitializeComponent();
        }


        private void Gamebtn_Click(object sender, EventArgs e)
        {
            mainGame.Show();
            dataPesertafrm.Hide();
            settingfrm.Hide();
        }

        private void DataPesertabtn_Click(object sender, EventArgs e)
        {
            mainGame.Hide();
            dataPesertafrm.Show();
            settingfrm.Hide();

            dataPesertafrm.Height = Mainpnl.Height;
            dataPesertafrm.Width = Mainpnl.Width;
        }

        private void Settingbtn_Click(object sender, EventArgs e)
        {
            mainGame.Hide();
            dataPesertafrm.Hide();
            settingfrm.Show();
        }

        private void Panitiafrm_Load(object sender, EventArgs e)
        {
            mainGame = new MainGame();
            dataPesertafrm = new DataPesertafrm();
            settingfrm = new Settingfrm();

            mainGame.TopLevel = false;
            dataPesertafrm.TopLevel = false;
            settingfrm.TopLevel = false;

            Mainpnl.Controls.Add(mainGame);
            Mainpnl.Controls.Add(dataPesertafrm);
            Mainpnl.Controls.Add(settingfrm);



            mainGame.Show();
            dataPesertafrm.Hide();
            settingfrm.Hide();

            kryptonPanel2.Hide();
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

        private void Mainpnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
