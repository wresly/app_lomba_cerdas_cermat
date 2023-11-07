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
        public string peserta = "";
        public AddScores()
        {
            InitializeComponent();
        }

        private void AddScores_Load(object sender, EventArgs e)
        {
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }
                db.cmd = new MySqlCommand("select * from users where usertype = 1", db.conn);
                db.reader = db.cmd.ExecuteReader();
                while (db.reader.Read())
                {
                    Pesertacmb.Items.Add(db.reader["username"].ToString());
                }
                db.reader.Close();
                Pesertacmb.SelectedIndexChanged += (sender, e) => Pesertacmb_SelectedIndexChanged(sender, e);
                if (peserta != "")
                {
                    Pesertacmb.Enabled = false;
                    Pesertacmb.SelectedIndex = Pesertacmb.Items.IndexOf(peserta);
                }
                else
                {
                    Pesertacmb.SelectedIndex = 0;
                }

            }
            catch (Exception ex)
            {
                db.reader.Close();
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void Pesertacmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            peserta = Pesertacmb.Text;
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
                db.cmd = new MySqlCommand("UPDATE users SET scores = scores + " + Int32.Parse(Scorestxt.Text) + " WHERE username = '" + peserta + "'", db.conn);
                db.cmd.ExecuteNonQuery();
                Addbtn.Enabled = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Addbtn.Enabled = true;

        }

    }
}
