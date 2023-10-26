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
    public partial class AddScores : KryptonForm
    {
        public int scores;
        public string peserta = "";
        public AddScores()
        {
            InitializeComponent();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            Addbtn.Enabled = false;
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }
                MySqlCommand cmd = new MySqlCommand("UPDATE users SET scores = scores + " + Int32.Parse(Scorestxt.Text) + " WHERE username = '" + peserta + "'", db.conn);
                cmd.ExecuteNonQuery();
                Addbtn.Enabled = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Addbtn.Enabled = true;

        }

        private void AddScores_Load(object sender, EventArgs e)
        {
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }
                MySqlCommand cmd = new MySqlCommand("select * from users where usertype = 1", db.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Pesertacmb.Items.Add(reader["username"].ToString());
                }
                reader.Close();
                Pesertacmb.SelectedIndex = 0;
                if (peserta != "")
                {
                    Pesertacmb.Enabled = false;
                    Pesertacmb.SelectedIndex = Pesertacmb.Items.IndexOf(peserta);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
