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
            if (db.conn.State == ConnectionState.Closed)
            {
                db.conn.Open();
            }
            Userstimer.Enabled = true;
        }



        private void Tambahbtn_Click(object sender, EventArgs e)
        {
            if (Usertxt.Text.Replace(" ", "") == "")
            {
                Usertxt.Focus();
                MessageBox.Show("isi kolom username!");
                return;
            }

            if (Passtxt.Text.Replace(" ", "") == "")
            {
                Passtxt.Focus();
                MessageBox.Show("isi kolom password!");
                return;
            }
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();
                }
                MySqlCommand cmd1 = new MySqlCommand("select * from users where username = '" + Usertxt.Text.Replace(" ", "") + "'", db.conn);
                MySqlDataReader reader = cmd1.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    MessageBox.Show("username Sudah Dipakai");
                    return;
                }
                else
                {
                    reader.Close();
                }
                MySqlCommand cmd = new MySqlCommand("insert into users(username, password) values('" + Usertxt.Text.Replace(" ", "") + "', '" + Passtxt.Text.Replace(" ", "") + "')", db.conn);
                int rowAffected = cmd.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    MessageBox.Show("Sukses Mengnambah Peserta : " + Usertxt.Text.Replace(" ", ""));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Hapusbtn_Click(object sender, EventArgs e)
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
                MySqlCommand cmd = new MySqlCommand("delete from users where username = '" + Usertxt.Text.Replace(" ", "") + "'", db.conn);
                int rowAffected = cmd.ExecuteNonQuery();

                if (rowAffected > 0)
                {
                    MessageBox.Show("Sukses Menghapus Peserta : " + Usertxt.Text.Replace(" ", ""));
                }
                else
                {
                    MessageBox.Show("Peserta Tidak Ditemukan!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                MySqlCommand cmd = new MySqlCommand("select * from users where usertype = 1", db.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
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
