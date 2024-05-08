using app_lomba_cerdas_cermat.Form;
using Krypton.Toolkit;
using app_lomba_cerdas_cermat.Classes;
using MySql.Data.MySqlClient;

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
            Taskbar.Show();
            this.FormClosed += (sender, e) => Taskbar.Show();


            StreamReader stream = new StreamReader("server.txt");
            string filedata = stream.ReadToEnd();
            db.conn = new MySqlConnection(filedata.ToString());
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

