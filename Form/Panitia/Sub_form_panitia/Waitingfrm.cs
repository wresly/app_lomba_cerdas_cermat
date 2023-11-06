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
            timer1.Enabled = false;
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }
                db.cmd = new MySqlCommand("select * from game", db.conn);
                db.reader = db.cmd.ExecuteReader();
                if (db.reader.Read())
                {
                    if (db.reader["peserta"].ToString() != "none")
                    {
                        timer1.Enabled = false;
                        peserta = db.reader["peserta"].ToString();
                        this.DialogResult = DialogResult.OK;
                        db.reader.Close();
                        this.Close();
                    }
                    db.reader.Close();
                }
                db.reader.Close();

                db.cmd = new MySqlCommand("select * from game", db.conn);
                db.reader = db.cmd.ExecuteReader();
                if (db.reader.HasRows)
                {

                    db.reader.Read();
                    DateTime time = DateTime.ParseExact(db.reader["time"].ToString(), "HH:mm:ss", null);
                    DateTime currentTime = DateTime.Now;
                    time = time.AddSeconds(Int32.Parse(db.reader["timer"].ToString()));
                    if (!(time > currentTime))
                    {
                        this.DialogResult = DialogResult.OK;
                        db.reader.Close();
                        Cancelbtn.PerformClick();
                    }
                    db.reader.Close();
                }
                db.reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            finally
            {
                timer1.Enabled = true;
            }
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }
                //reset game table
                db.cmd = new MySqlCommand("UPDATE `game` SET `game_status`='none',`peserta`='none',`timer`=0,`plus_scores`=0,`minus_scores`=0,`answer_status`=0", db.conn);
                db.cmd.ExecuteNonQuery();

                //reset blacklist
                db.cmd = new MySqlCommand("DELETE FROM `game_blacklist`", db.conn);
                db.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            timer1.Enabled = false;
            this.Close();
        }
    }
}
