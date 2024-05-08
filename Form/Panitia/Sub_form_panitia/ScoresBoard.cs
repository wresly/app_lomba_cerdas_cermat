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

namespace app_lomba_cerdas_cermat.Form
{
    public partial class ScoresBoard : KryptonForm
    {
        public ScoresBoard()
        {
            InitializeComponent();
        }

        private void centering()
        {

            //Heading
            Logopb.Left = (this.ClientSize.Width - Logopb.Width) / 2;
            Headinglbl.Left = (this.ClientSize.Width - Headinglbl.Width) / 2;

            //A 
            GrupAlbl.Left = (PanelA.Width - GrupAlbl.Width) / 2;
            APesertalbl.Left = (PanelA.Width - APesertalbl.Width) / 2;
            AScoreslbl.Left = (PanelA.Width - AScoreslbl.Width) / 2;


            //B
            GrupBlbl.Left = (PanelB.Width - GrupBlbl.Width) / 2;
            BPesertalbl.Left = (PanelB.Width - BPesertalbl.Width) / 2;
            BScoreslbl.Left = (PanelB.Width - BScoreslbl.Width) / 2;

            //C
            GrupClbl.Left = (PanelC.Width - GrupClbl.Width) / 2;
            CPesertalbl.Left = (PanelC.Width - CPesertalbl.Width) / 2;
            CScoreslbl.Left = (PanelC.Width - CScoreslbl.Width) / 2;

            //D
            GrupDlbl.Left = (PanelD.Width - GrupDlbl.Width) / 2;
            DPesertalbl.Left = (PanelD.Width - DPesertalbl.Width) / 2;
            DScoreslbl.Left = (PanelD.Width - DScoreslbl.Width) / 2;

        }

        public void SetGame()
        {

            //cek sesi game
            db.cmd = new MySqlCommand("select * from game_status", db.conn);
            db.reader = db.cmd.ExecuteReader();
            if (db.reader.Read())
            {
                if (db.reader["game_status_sesi"].ToString() == "none")
                {
                    PanelA.Visible = false;
                    PanelB.Visible = false;
                    PanelC.Visible = false;
                    PanelD.Visible = false;
                    db.reader.Close();
                    return;
                }

                if (db.reader["game_status_sesi"].ToString() == "penyisihan")
                {
                    PanelA.Visible = true;
                    PanelB.Visible = true;
                    PanelC.Visible = true;
                    PanelD.Visible = false;

                    PanelB.Left = (this.ClientSize.Width - PanelB.Width) / 2;
                    PanelA.Left = (PanelB.Left - PanelA.Width - 50);
                    PanelC.Left = (PanelB.Left + PanelC.Width + 50);
                    db.reader.Close();
                    return;
                }

                if (db.reader["game_status_sesi"].ToString() == "final")
                {
                    PanelA.Visible = true;
                    PanelB.Visible = true;
                    PanelC.Visible = true;
                    PanelD.Visible = true;

                    PanelA.Left = (PanelB.Left - PanelA.Width - 30);
                    PanelB.Left = (this.ClientSize.Width) / 2 - PanelB.Width - 15;
                    PanelC.Left = (this.ClientSize.Width) / 2 + 15;
                    PanelD.Left = (PanelC.Left + PanelC.Width + 30);
                    db.reader.Close();
                    return;
                }
            }

        }
        private void PesertaTimer_Tick(object sender, EventArgs e)
        {
            PesertaTimer.Enabled = false;
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
                    if (db.reader["username"].ToString() == "A")
                    {
                        APesertalbl.Text = db.reader["peserta"].ToString();
                        AScoreslbl.Text = db.reader["scores"].ToString();
                    }

                    if (db.reader["username"].ToString() == "B")
                    {
                        BPesertalbl.Text = db.reader["peserta"].ToString();
                        BScoreslbl.Text = db.reader["scores"].ToString();
                    }

                    if (db.reader["username"].ToString() == "C")
                    {
                        CPesertalbl.Text = db.reader["peserta"].ToString();
                        CScoreslbl.Text = db.reader["scores"].ToString();
                    }

                    if (db.reader["username"].ToString() == "D")
                    {
                        DPesertalbl.Text = db.reader["peserta"].ToString();
                        DScoreslbl.Text = db.reader["scores"].ToString();
                    }
                }
                db.reader.Close();

            }
            catch (Exception ex)
            {
                db.reader.Close();
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                PesertaTimer.Enabled = true;
            }
            centering();
            SetGame();
        }

        private void AllPesertaScores_Load(object sender, EventArgs e)
        {
            PesertaTimer.Enabled = true;
            centering();
            SetGame();
        }
    }
}
