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
using Org.BouncyCastle.Asn1.X509;

namespace app_lomba_cerdas_cermat
{
    public partial class DataPesertafrm : KryptonForm
    {
        public DataPesertafrm()
        {
            InitializeComponent();
        }

        private void DataPesertafrm_Load(object sender, EventArgs e)
        {
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }

                //input combo box peserta
                db.cmd = new MySqlCommand("select * from users where usertype = 1", db.conn);
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
            Userstimer.Enabled = true;
        }



        private void Setbtn_click(object sender, EventArgs e)
        {
            if (Usertxt.Text.Replace(" ", "") == "")
            {
                Usertxt.Focus();
                MessageBox.Show("isi kolom username!");
                return;
            }

            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();
                }
                db.cmd = new MySqlCommand("UPDATE `users` SET `peserta`='" + Usertxt.Text.Trim() + "' WHERE `username`='" + Userscmb.Text + "'", db.conn);
                int rowAffected = db.cmd.ExecuteNonQuery();

                if (rowAffected > 0)
                {
                    MessageBox.Show("Sukses Mengatur Peserta : " + Usertxt.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Gagal Mengatur");
                }
            }
            catch (Exception)
            {
            }
        }


        private void Userstimer_Tick(object sender, EventArgs e)
        {
            Userstimer.Enabled = false;
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();
                }
                db.cmd = new MySqlCommand("select * from users where usertype = 1", db.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(db.cmd);
                DataSet data = new DataSet();
                da.Fill(data, "users");
                Usersdgv.DataSource = data.Tables["users"];
                Usersdgv.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Userstimer.Enabled = true;
            }
        }
        private void Usersdgv_SelectionChanged(Object sender, EventArgs e)
        {
            Usersdgv.ClearSelection();
        }
        private void Usersdgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                SelectNextControl(Usersdgv, true, true, true, true);
                // or Parent.SelectNextControl() if the grid is an only child, etc.
                e.Handled = true;
            }
        }

    }
}
