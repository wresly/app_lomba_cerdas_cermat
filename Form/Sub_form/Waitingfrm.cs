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

namespace app_lomba_cerdas_cermat.Form.Sub_form
{
    public partial class Waitingfrm : KryptonForm
    {
        public string peserta;
        public Waitingfrm()
        {
            InitializeComponent();
        }

        private void Waiting_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }
                MySqlCommand cmd = new MySqlCommand("select * from game", db.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (reader["peserta"].ToString() != "none")
                    {
                        peserta = reader["peserta"].ToString();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                reader.Close();
                return;

            }
            catch
            {
                MessageBox.Show("Server Putus!");
                this.Close();
            }
        }
    }
}
