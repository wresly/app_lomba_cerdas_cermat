using System;
using System.Collections.Generic;
using System.Data;
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
                db.cmd = new MySqlCommand("select * from users", db.conn);
                db.reader = db.cmd.ExecuteReader();
                while (db.reader.Read())
                {
                    Userscmb.Items.Add(db.reader["username"].ToString());
                }
                db.reader.Close();
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
                db.cmd = new MySqlCommand("select * from users where username = '" + Userscmb.Text + "'", db.conn);
                db.reader = db.cmd.ExecuteReader();
                while (db.reader.Read())
                {
                    userType = Int32.Parse(db.reader["usertype"].ToString());
                    username = db.reader["username"].ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    db.reader.Close();
                    return;
                }
                db.reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            db.conn.Close();
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }

                Userscmb.Items.Clear();

                //input combo box peserta
                db.cmd = new MySqlCommand("select * from users", db.conn);
                db.reader = db.cmd.ExecuteReader();
                while (db.reader.Read())
                {
                    Userscmb.Items.Add(db.reader["username"].ToString());
                }
                db.reader.Close();
                Userscmb.SelectedIndex = 0;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
