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
using app_lomba_cerdas_cermat.Form.Sub_form;
using Krypton.Toolkit;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace app_lomba_cerdas_cermat.Form
{
    public partial class MainBoard : KryptonForm
    {
        ScoresBoard scoresBoard;
        TimerBoard timerBoard;
        public MainBoard()
        {
            InitializeComponent();
        }

        private void MainBoard_Load(object sender, EventArgs e)
        {
            //inisiasi form
            scoresBoard = new ScoresBoard();
            timerBoard = new TimerBoard();

            timerBoard.TopLevel = false;
            scoresBoard.TopLevel = false;

            MainBoardpnl.Controls.Add(timerBoard);
            MainBoardpnl.Controls.Add(scoresBoard);

            timerBoard.Width = (MainBoardpnl.Width - timerBoard.Width) / 2;
            timerBoard.Height = (MainBoardpnl.Height - timerBoard.Height) / 2;

            scoresBoard.Width = (MainBoardpnl.Width - scoresBoard.Width) / 2;
            scoresBoard.Height = (MainBoardpnl.Height - scoresBoard.Height) / 2;

            scoresBoard.Show();
            timerBoard.Hide();

            //enabled timer
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Check Running Game
            timer1.Enabled = false;
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }
                db.cmd = new MySqlCommand("select * from game", db.conn);
                db.reader = db.cmd.ExecuteReader();
                if (db.reader.HasRows)
                {

                    db.reader.Read();
                    DateTime time = DateTime.ParseExact(db.reader["time"].ToString(), "HH:mm:ss", null);
                    DateTime currentTime = DateTime.Now;
                    time = time.AddSeconds(Int32.Parse(db.reader["timer"].ToString()));
                    if (time > currentTime)
                    {
                        db.reader.Close();
                        TimeSpan timeDifference = time - currentTime;
                        timerBoard.timer = (int)timeDifference.TotalSeconds;
                        scoresBoard.Hide();
                        timerBoard.Show();

                    }
                    else
                    {
                        db.reader.Close();
                        timerBoard.Hide();
                        scoresBoard.Show();
                    }
                }
                db.reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                timer1.Enabled = true;
            }
        }
    }
}
