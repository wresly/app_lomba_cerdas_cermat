using app_lomba_cerdas_cermat.Classes;
using Krypton.Toolkit;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_lomba_cerdas_cermat.Form.Panitia.Sub_form_panitia
{
    public partial class AddScoresfrm : KryptonForm
    {
        public AddScoresfrm()
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
                db.cmd = new MySqlCommand("select * from game_status", db.conn);
                db.reader = db.cmd.ExecuteReader();
                if (db.reader.Read())
                {
                    if (db.reader["game_status_sesi"].ToString() == "penyisihan")
                    {
                        db.reader.Close();
                        db.cmd = new MySqlCommand("UPDATE users SET scores = scores + " + Int32.Parse(GroupAtxt.Text) + " WHERE username = 'A';" + "UPDATE users SET scores = scores + " + Int32.Parse(GroupBtxt.Text) + " WHERE username = 'B';" + "UPDATE users SET scores = scores + " + Int32.Parse(GroupCtxt.Text) + " WHERE username = 'C'", db.conn);
                        db.cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        db.reader.Close();
                        db.cmd = new MySqlCommand("UPDATE users SET scores = scores + " + Int32.Parse(GroupAtxt.Text) + " WHERE username = 'A';" + "UPDATE users SET scores = scores + " + Int32.Parse(GroupBtxt.Text) + " WHERE username = 'B';" + "UPDATE users SET scores = scores + " + Int32.Parse(GroupCtxt.Text) + " WHERE username = 'C';" + "UPDATE users SET scores = scores + " + Int32.Parse(GroupDtxt.Text) + " WHERE username = 'D'", db.conn);
                        db.cmd.ExecuteNonQuery();
                    }

                }
                db.reader.Close();
                Addbtn.Enabled = true;
                this.Close();
            }
            catch (Exception ex)
            {
                db.reader.Close();
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Addbtn.Enabled = true;
        }

        private void AddScoresfrm_Load(object sender, EventArgs e)
        {
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }
                db.cmd = new MySqlCommand("select * from game_status", db.conn);
                db.reader = db.cmd.ExecuteReader();
                if (db.reader.Read())
                {
                    if (db.reader["game_status_sesi"].ToString() == "penyisihan")
                    {
                        GroupDtxt.Enabled = false;
                    }
                    else
                    {
                        GroupDtxt.Enabled = true;
                    }

                }
                db.reader.Close();

            }
            catch (Exception ex)
            {
                db.reader.Close();
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
