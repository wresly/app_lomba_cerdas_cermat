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
using System.IO;
using app_lomba_cerdas_cermat.Classes;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace app_lomba_cerdas_cermat
{
    public partial class Mainfrm : KryptonForm
    {
        private bool isAltKeyPressed = false;
        private bool isAKeyPressed = false;

        public Mainfrm()
        {
            InitializeComponent();
        }

        private void Mainfrm_Load(object sender, EventArgs e)
        {
            Taskbar.Show();
            this.FormClosed += (sender, e) => Taskbar.Show();
            //Testfrm123 testfrm123 = new Testfrm123();
            //testfrm123.MdiParent = this;
            //testfrm123.Show();

            StreamReader stream = new StreamReader("server.txt");
            string filedata = stream.ReadToEnd();
            db.conn = new MySqlConnection(filedata.ToString());
            //MessageBox.Show(db.connectionString);
            stream.Close();

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
                    this.WindowState = FormWindowState.Maximized;
                    this.FormBorderStyle = FormBorderStyle.None;
                    this.TopMost = true;

                    Taskbar.Hide();

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

