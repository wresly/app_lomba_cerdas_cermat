using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app_lomba_cerdas_cermat.Form;
using Krypton.Toolkit;

namespace app_lomba_cerdas_cermat
{
    public partial class Mainfrm : KryptonForm
    {
        public Mainfrm()
        {
            InitializeComponent();
        }

        private void Mainfrm_Load(object sender, EventArgs e)
        {
            Loginfrm loginfrm = new Loginfrm();
            loginfrm.ShowDialog();
            if (loginfrm.DialogResult == DialogResult.OK)
            {


                if (loginfrm.userType == 0)
                {
                    Panitiafrm panitiafrm = new Panitiafrm();
                    panitiafrm.MdiParent = this;
                    panitiafrm.Show();
                }
                else
                {
                    Pesertafrm pesertafrm = new Pesertafrm();
                    pesertafrm.MdiParent = this;
                    pesertafrm.username = loginfrm.username;
                    pesertafrm.Show();
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}
