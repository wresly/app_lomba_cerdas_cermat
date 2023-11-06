﻿using System;
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
using Org.BouncyCastle.Crmf;

namespace app_lomba_cerdas_cermat.Form
{
    public partial class PesertaScoresfrm : KryptonForm
    {
        public string username;
        public PesertaScoresfrm()
        {
            InitializeComponent();
        }

        private void PesertaScoresfrm_Load(object sender, EventArgs e)
        {

            Usernamelbl.Text = "Grup " + username;
            TimerScores.Enabled = true;

        }

        private void TimerScores_Tick(object sender, EventArgs e)
        {
            TimerScores.Enabled = false;
            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();

                }
                db.cmd = new MySqlCommand("select * from users where username = '" + username + "'", db.conn);
                db.reader = db.cmd.ExecuteReader();
                if (db.reader.Read())
                {
                    Pointlbl.Text = db.reader["scores"].ToString();
                    Pesertalbl.Text = db.reader["peserta"].ToString();
                }
                db.reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                TimerScores.Enabled = true;
            }
        }


    }
}