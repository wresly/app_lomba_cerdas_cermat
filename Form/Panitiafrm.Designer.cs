namespace app_lomba_cerdas_cermat.Form
{
    partial class Panitiafrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panitiafrm));
            Mainpnl = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            Closedbtn = new Krypton.Toolkit.KryptonButton();
            Settingbtn = new Krypton.Toolkit.KryptonButton();
            DataPesertabtn = new Krypton.Toolkit.KryptonButton();
            Gamebtn = new Krypton.Toolkit.KryptonButton();
            Openbtn = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)Mainpnl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // Mainpnl
            // 
            Mainpnl.Dock = DockStyle.Fill;
            Mainpnl.Location = new Point(0, 0);
            Mainpnl.Margin = new Padding(0);
            Mainpnl.Name = "Mainpnl";
            Mainpnl.Size = new Size(1258, 660);
            Mainpnl.TabIndex = 1;
            Mainpnl.Paint += Mainpnl_Paint;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(Closedbtn);
            kryptonPanel2.Controls.Add(Settingbtn);
            kryptonPanel2.Controls.Add(DataPesertabtn);
            kryptonPanel2.Controls.Add(Gamebtn);
            kryptonPanel2.Dock = DockStyle.Left;
            kryptonPanel2.Location = new Point(0, 0);
            kryptonPanel2.Margin = new Padding(4);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(249, 660);
            kryptonPanel2.StateCommon.Color1 = Color.FromArgb(35, 40, 45);
            kryptonPanel2.TabIndex = 0;
            // 
            // Closedbtn
            // 
            Closedbtn.CornerRoundingRadius = -1F;
            Closedbtn.Location = new Point(20, 24);
            Closedbtn.Margin = new Padding(4);
            Closedbtn.Name = "Closedbtn";
            Closedbtn.Size = new Size(34, 31);
            Closedbtn.StateCommon.Back.Color1 = Color.Transparent;
            Closedbtn.StateCommon.Back.Color2 = Color.Transparent;
            Closedbtn.TabIndex = 7;
            Closedbtn.Values.Image = (Image)resources.GetObject("Closedbtn.Values.Image");
            Closedbtn.Values.Text = "";
            Closedbtn.Click += Closebtn_Click;
            // 
            // Settingbtn
            // 
            Settingbtn.CornerRoundingRadius = -1F;
            Settingbtn.Location = new Point(12, 346);
            Settingbtn.Margin = new Padding(4);
            Settingbtn.Name = "Settingbtn";
            Settingbtn.OverrideDefault.Back.Color1 = Color.Transparent;
            Settingbtn.OverrideDefault.Back.Color2 = Color.Transparent;
            Settingbtn.OverrideDefault.Border.Color1 = Color.Transparent;
            Settingbtn.OverrideDefault.Border.Color2 = Color.Transparent;
            Settingbtn.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Settingbtn.Size = new Size(237, 31);
            Settingbtn.StateCommon.Back.Color1 = Color.Transparent;
            Settingbtn.StateCommon.Back.Color2 = Color.Transparent;
            Settingbtn.StateCommon.Border.Color1 = Color.Transparent;
            Settingbtn.StateCommon.Border.Color2 = Color.Transparent;
            Settingbtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Settingbtn.StateCommon.Content.ShortText.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Settingbtn.StateNormal.Content.ShortText.Color1 = Color.White;
            Settingbtn.StateNormal.Content.ShortText.Color2 = Color.White;
            Settingbtn.StateNormal.Content.ShortText.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Settingbtn.StatePressed.Back.Color1 = Color.Transparent;
            Settingbtn.StatePressed.Back.Color2 = Color.Transparent;
            Settingbtn.StatePressed.Border.Color1 = Color.Transparent;
            Settingbtn.StatePressed.Border.Color2 = Color.Transparent;
            Settingbtn.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Settingbtn.StateTracking.Back.Color1 = Color.Transparent;
            Settingbtn.StateTracking.Back.Color2 = Color.Transparent;
            Settingbtn.StateTracking.Border.Color1 = Color.Transparent;
            Settingbtn.StateTracking.Border.Color2 = Color.Transparent;
            Settingbtn.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Settingbtn.TabIndex = 6;
            Settingbtn.Values.Text = "Setting";
            Settingbtn.Click += Settingbtn_Click;
            // 
            // DataPesertabtn
            // 
            DataPesertabtn.CornerRoundingRadius = -1F;
            DataPesertabtn.Location = new Point(12, 276);
            DataPesertabtn.Margin = new Padding(4);
            DataPesertabtn.Name = "DataPesertabtn";
            DataPesertabtn.OverrideDefault.Back.Color1 = Color.Transparent;
            DataPesertabtn.OverrideDefault.Back.Color2 = Color.Transparent;
            DataPesertabtn.OverrideDefault.Border.Color1 = Color.Transparent;
            DataPesertabtn.OverrideDefault.Border.Color2 = Color.Transparent;
            DataPesertabtn.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            DataPesertabtn.Size = new Size(237, 31);
            DataPesertabtn.StateCommon.Back.Color1 = Color.Transparent;
            DataPesertabtn.StateCommon.Back.Color2 = Color.Transparent;
            DataPesertabtn.StateCommon.Border.Color1 = Color.Transparent;
            DataPesertabtn.StateCommon.Border.Color2 = Color.Transparent;
            DataPesertabtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            DataPesertabtn.StateCommon.Content.ShortText.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            DataPesertabtn.StateNormal.Content.ShortText.Color1 = Color.White;
            DataPesertabtn.StateNormal.Content.ShortText.Color2 = Color.White;
            DataPesertabtn.StateNormal.Content.ShortText.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            DataPesertabtn.StatePressed.Back.Color1 = Color.Transparent;
            DataPesertabtn.StatePressed.Back.Color2 = Color.Transparent;
            DataPesertabtn.StatePressed.Border.Color1 = Color.Transparent;
            DataPesertabtn.StatePressed.Border.Color2 = Color.Transparent;
            DataPesertabtn.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            DataPesertabtn.StateTracking.Back.Color1 = Color.Transparent;
            DataPesertabtn.StateTracking.Back.Color2 = Color.Transparent;
            DataPesertabtn.StateTracking.Border.Color1 = Color.Transparent;
            DataPesertabtn.StateTracking.Border.Color2 = Color.Transparent;
            DataPesertabtn.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            DataPesertabtn.TabIndex = 5;
            DataPesertabtn.Values.Text = "Peserta";
            DataPesertabtn.Click += DataPesertabtn_Click;
            // 
            // Gamebtn
            // 
            Gamebtn.CornerRoundingRadius = -1F;
            Gamebtn.Location = new Point(12, 207);
            Gamebtn.Margin = new Padding(4);
            Gamebtn.Name = "Gamebtn";
            Gamebtn.OverrideDefault.Back.Color1 = Color.Transparent;
            Gamebtn.OverrideDefault.Back.Color2 = Color.Transparent;
            Gamebtn.OverrideDefault.Border.Color1 = Color.Transparent;
            Gamebtn.OverrideDefault.Border.Color2 = Color.Transparent;
            Gamebtn.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Gamebtn.Size = new Size(237, 31);
            Gamebtn.StateCommon.Back.Color1 = Color.Transparent;
            Gamebtn.StateCommon.Back.Color2 = Color.Transparent;
            Gamebtn.StateCommon.Border.Color1 = Color.Transparent;
            Gamebtn.StateCommon.Border.Color2 = Color.Transparent;
            Gamebtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Gamebtn.StateCommon.Content.ShortText.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Gamebtn.StateNormal.Content.ShortText.Color1 = Color.White;
            Gamebtn.StateNormal.Content.ShortText.Color2 = Color.White;
            Gamebtn.StateNormal.Content.ShortText.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Gamebtn.StatePressed.Back.Color1 = Color.Transparent;
            Gamebtn.StatePressed.Back.Color2 = Color.Transparent;
            Gamebtn.StatePressed.Border.Color1 = Color.Transparent;
            Gamebtn.StatePressed.Border.Color2 = Color.Transparent;
            Gamebtn.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Gamebtn.StateTracking.Back.Color1 = Color.Transparent;
            Gamebtn.StateTracking.Back.Color2 = Color.Transparent;
            Gamebtn.StateTracking.Border.Color1 = Color.Transparent;
            Gamebtn.StateTracking.Border.Color2 = Color.Transparent;
            Gamebtn.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Gamebtn.TabIndex = 4;
            Gamebtn.Values.Text = "Game";
            Gamebtn.Click += Gamebtn_Click;
            // 
            // Openbtn
            // 
            Openbtn.CornerRoundingRadius = -1F;
            Openbtn.Location = new Point(20, 24);
            Openbtn.Margin = new Padding(4);
            Openbtn.Name = "Openbtn";
            Openbtn.Size = new Size(34, 31);
            Openbtn.StateCommon.Back.Color1 = Color.Transparent;
            Openbtn.StateCommon.Back.Color2 = Color.Transparent;
            Openbtn.TabIndex = 8;
            Openbtn.Values.Image = (Image)resources.GetObject("Openbtn.Values.Image");
            Openbtn.Values.Text = "";
            Openbtn.Click += Openbtn_Click;
            // 
            // Panitiafrm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1258, 660);
            Controls.Add(Openbtn);
            Controls.Add(kryptonPanel2);
            Controls.Add(Mainpnl);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "Panitiafrm";
            Text = "Panitia";
            WindowState = FormWindowState.Maximized;
            Load += Panitiafrm_Load;
            ((System.ComponentModel.ISupportInitialize)Mainpnl).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel Mainpnl;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonButton Settingbtn;
        private Krypton.Toolkit.KryptonButton DataPesertabtn;
        private Krypton.Toolkit.KryptonButton Gamebtn;
        private Krypton.Toolkit.KryptonButton Closedbtn;
        private Krypton.Toolkit.KryptonButton Openbtn;
    }
}