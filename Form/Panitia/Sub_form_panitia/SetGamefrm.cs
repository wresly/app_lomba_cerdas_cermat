using app_lomba_cerdas_cermat.Classes;
using Krypton.Toolkit;
using MySql.Data.MySqlClient;
using System.Data;

namespace app_lomba_cerdas_cermat.Form.Panitia.Sub_form_panitia
{
    public partial class SetGamefrm : KryptonForm
    {
        public SetGamefrm()
        {
            InitializeComponent();
        }

        private void SetGamefrm_Load(object sender, EventArgs e)
        {
            GroupAtxt.Enabled = false;
            GroupBtxt.Enabled = false;
            GroupCtxt.Enabled = false;
            GroupDtxt.Enabled = false;
        }

        private void SesiGamecmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SesiGamecmb.Text.ToLower() == "penyisihan")
            {
                GroupAtxt.Enabled = true;
                GroupBtxt.Enabled = true;
                GroupCtxt.Enabled = true;
                GroupDtxt.Enabled = false;
            }

            if (SesiGamecmb.Text.ToLower() == "final")
            {
                GroupAtxt.Enabled = true;
                GroupBtxt.Enabled = true;
                GroupCtxt.Enabled = true;
                GroupDtxt.Enabled = true;
            }
        }

        private void SetGamebtn_Click(object sender, EventArgs e)
        {
            if (SesiGamecmb.Text.ToLower() == "penyisihan")
            {
                try
                {
                    if (db.conn.State == ConnectionState.Closed)
                    {
                        db.conn.Open();

                    }

                    //update sesi game
                    db.cmd = new MySqlCommand("UPDATE game_status SET game_status_sesi = 'penyisihan'", db.conn);
                    db.cmd.ExecuteNonQuery();


                    //insert player group A
                    db.cmd = new MySqlCommand("INSERT INTO `users`(`username`, `peserta`, `scores`, `usertype`) VALUES ('A','" + GroupAtxt.Text + "','0','1')", db.conn);
                    db.cmd.ExecuteNonQuery();


                    //insert player group B
                    db.cmd = new MySqlCommand("INSERT INTO `users`(`username`, `peserta`, `scores`, `usertype`) VALUES ('B','" + GroupBtxt.Text + "','0','1')", db.conn);
                    db.cmd.ExecuteNonQuery();


                    //insert player group C
                    db.cmd = new MySqlCommand("INSERT INTO `users`(`username`, `peserta`, `scores`, `usertype`) VALUES ('C','" + GroupCtxt.Text + "','0','1')", db.conn);
                    db.cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (SesiGamecmb.Text.ToLower() == "final")
            {
                try
                {
                    if (db.conn.State == ConnectionState.Closed)
                    {
                        db.conn.Open();

                    }

                    //update sesi game
                    db.cmd = new MySqlCommand("UPDATE game_status SET game_status_sesi = 'final'", db.conn);
                    db.cmd.ExecuteNonQuery();


                    //insert player group A
                    db.cmd = new MySqlCommand("INSERT INTO `users`(`username`, `peserta`, `scores`, `usertype`) VALUES ('A','" + GroupAtxt.Text + "','0','1')", db.conn);
                    db.cmd.ExecuteNonQuery();


                    //insert player group B
                    db.cmd = new MySqlCommand("INSERT INTO `users`(`username`, `peserta`, `scores`, `usertype`) VALUES ('B','" + GroupBtxt.Text + "','0','1')", db.conn);
                    db.cmd.ExecuteNonQuery();


                    //insert player group C
                    db.cmd = new MySqlCommand("INSERT INTO `users`(`username`, `peserta`, `scores`, `usertype`) VALUES ('C','" + GroupCtxt.Text + "','0','1')", db.conn);
                    db.cmd.ExecuteNonQuery();

                    //insert player group D
                    db.cmd = new MySqlCommand("INSERT INTO `users`(`username`, `peserta`, `scores`, `usertype`) VALUES ('D','" + GroupDtxt.Text + "','0','1')", db.conn);
                    db.cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            this.Close();
        }
    }
}
