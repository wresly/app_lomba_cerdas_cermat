using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app_lomba_cerdas_cermat.Classes;
using Krypton.Toolkit;
using MySql.Data.MySqlClient;

namespace app_lomba_cerdas_cermat
{
    public partial class Loginfrm : KryptonForm
    {
        public int userType;
        public string username;
        public Loginfrm()
        {
            InitializeComponent();
        }

        private void Loginfrm_Load(object sender, EventArgs e)
        {

        }

        private void Keluarbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                db.conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from users", db.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["username"].ToString() == Usertxt.Text)
                    {

                        if (reader["password"].ToString() == Passtxt.Text)
                        {
                            userType = Int32.Parse(reader["usertype"].ToString());
                            username = reader["username"].ToString();
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                            reader.Close();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("password salah");
                            return;
                        }
                    }
                }
                MessageBox.Show("username tidak di temukan");
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            db.conn.Close();


        }
    }
}
