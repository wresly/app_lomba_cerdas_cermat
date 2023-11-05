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
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }

                //input combo box peserta
                MySqlCommand cmd = new MySqlCommand("select * from users", db.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Userscmb.Items.Add(reader["username"].ToString());
                }
                reader.Close();
                Userscmb.SelectedIndex = 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Keluarbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }
                MySqlCommand cmd = new MySqlCommand("select * from users where username = '" + Userscmb.Text + "'", db.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    userType = Int32.Parse(reader["usertype"].ToString());
                    username = reader["username"].ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    reader.Close();
                    return;
                }
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
