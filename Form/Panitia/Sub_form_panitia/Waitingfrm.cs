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
            this.FormClosed += (sender, e) => WaitingTimer.Enabled = false;
            WaitingTimer.Enabled = true;
        }

        private void WaitingTimer_Tick(object sender, EventArgs e)
        {
            WaitingTimer.Enabled = false;
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
                        WaitingTimer.Enabled = false;
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

                db.reader.Read();
                if (db.reader.HasRows)
                {

                    DateTime time = DateTime.ParseExact(db.reader["time"].ToString(), "HH:mm:ss", null);
                    DateTime currentTime = DateTime.Now;
                    time = time.AddSeconds(Int32.Parse(db.reader["timer"].ToString()));
                    if (!(time > currentTime))
                    {
                        db.reader.Close();
                        this.DialogResult = DialogResult.Abort;
                        WaitingTimer.Enabled = false;
                        this.Close();
                    }
                    db.reader.Close();
                }
                db.reader.Close();
            }
            catch (Exception ex)
            {
                db.reader.Close();
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            finally
            {
                WaitingTimer.Enabled = true;
            }
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            db.reader.Close();
            this.DialogResult = DialogResult.Abort;
            WaitingTimer.Enabled = false;
            this.Close();
        }
    }
}
