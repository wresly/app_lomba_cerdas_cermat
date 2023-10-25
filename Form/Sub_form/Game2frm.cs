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
    public partial class Game2frm : KryptonForm
    {
        string peserta;
        public Game2frm()
        {
            InitializeComponent();
        }

        private void Game2frm_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            Startbtn.Enabled = false;
            //peserta = Pesertacmb.Text;
            if (Scorestxt.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Atur Scores!!");
                Startbtn.Enabled = true;
                return;
            }
            if (!int.TryParse(Scorestxt.Text, out _))
            {
                MessageBox.Show("Scores harus angka!!");
                Startbtn.Enabled = true;
                return;
            }

            if ((Secondtxt.Text == "00" && Minutetxt.Text == "00") || Secondtxt.Text.Trim() == "" || Minutetxt.Text.Trim() == "")
            {
                MessageBox.Show("Atur TImer!!");
                Startbtn.Enabled = true;
                return;
            }

            if (!int.TryParse(Minutetxt.Text, out _) || !int.TryParse(Secondtxt.Text, out _))
            {
                MessageBox.Show("Timer Harus Angka!!");
                Startbtn.Enabled = true;
                return;
            }

            peserta = Pesertacmb.Text;
            Pesertacmb.Enabled = false;
            Scorestxt.Enabled = false;
            Minutetxt.Enabled = false;
            Secondtxt.Enabled = false;

            TimerGamefrm timerGame2 = new TimerGamefrm();
            timerGame2.timer = Int32.Parse(Minutetxt.Text) * 60 + Int32.Parse(Secondtxt.Text);
            timerGame2.ShowDialog();
            if (timerGame2.DialogResult == DialogResult.OK)
            {

                try
                {
                    if (db.conn.State == ConnectionState.Closed)
                    {
                        db.conn.Open();

                    }
                    MySqlCommand cmd = new MySqlCommand("UPDATE users SET scores = scores + " + Int32.Parse(Scorestxt.Text) + " WHERE username = '" + peserta + "'", db.conn);
                    cmd.ExecuteNonQuery();
                    reset();
                }
                catch (Exception)
                {
                    MessageBox.Show("terjadi kesalahan");
                    Startbtn.Enabled = true;
                }

            }

            if (timerGame2.DialogResult == DialogResult.Cancel)
            {
                Pesertacmb.Enabled = true;
                Scorestxt.Enabled = true;
                Minutetxt.Enabled = true;
                Secondtxt.Enabled = true;
                Startbtn.Enabled = true;
                Resetbtn.Enabled = true;

                Pesertacmb.Items.Remove(peserta);

                if (Pesertacmb.Items.Count == 0)
                {
                    Scorestxt.Text = "";
                    Minutetxt.Text = "00";
                    Secondtxt.Text = "00";
                    reset();
                    return;
                }
                Pesertacmb.SelectedIndex = 0;
            }
        }

        private void reset()
        {
            try
            {
                Pesertacmb.Items.Clear();
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

            }
            catch
            {
                MessageBox.Show("Server Putus!");
                this.Close();
            }
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Tidakan Ini Akan Mereset Game", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);
            if (confirm == DialogResult.OK)
            {
                reset();
            }
        }
    }
}
