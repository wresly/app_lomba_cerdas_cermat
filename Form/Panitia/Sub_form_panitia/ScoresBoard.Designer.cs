namespace app_lomba_cerdas_cermat.Form
{
    partial class ScoresBoard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoresBoard));
            Logopb = new PictureBox();
            PesertaTimer = new System.Windows.Forms.Timer(components);
            PanelA = new Panel();
            AScoreslbl = new Krypton.Toolkit.KryptonLabel();
            APesertalbl = new Krypton.Toolkit.KryptonLabel();
            GrupAlbl = new Krypton.Toolkit.KryptonLabel();
            PanelB = new Panel();
            BScoreslbl = new Krypton.Toolkit.KryptonLabel();
            BPesertalbl = new Krypton.Toolkit.KryptonLabel();
            GrupBlbl = new Krypton.Toolkit.KryptonLabel();
            PanelC = new Panel();
            CScoreslbl = new Krypton.Toolkit.KryptonLabel();
            CPesertalbl = new Krypton.Toolkit.KryptonLabel();
            GrupClbl = new Krypton.Toolkit.KryptonLabel();
            PanelD = new Panel();
            DScoreslbl = new Krypton.Toolkit.KryptonLabel();
            DPesertalbl = new Krypton.Toolkit.KryptonLabel();
            GrupDlbl = new Krypton.Toolkit.KryptonLabel();
            Headinglbl = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)Logopb).BeginInit();
            PanelA.SuspendLayout();
            PanelB.SuspendLayout();
            PanelC.SuspendLayout();
            PanelD.SuspendLayout();
            SuspendLayout();
            // 
            // Logopb
            // 
            Logopb.Image = (Image)resources.GetObject("Logopb.Image");
            Logopb.Location = new Point(616, 10);
            Logopb.Margin = new Padding(5, 4, 5, 4);
            Logopb.Name = "Logopb";
            Logopb.Size = new Size(320, 320);
            Logopb.SizeMode = PictureBoxSizeMode.Zoom;
            Logopb.TabIndex = 1;
            Logopb.TabStop = false;
            // 
            // PesertaTimer
            // 
            PesertaTimer.Tick += PesertaTimer_Tick;
            // 
            // PanelA
            // 
            PanelA.Anchor = AnchorStyles.None;
            PanelA.AutoSize = true;
            PanelA.BorderStyle = BorderStyle.FixedSingle;
            PanelA.Controls.Add(AScoreslbl);
            PanelA.Controls.Add(APesertalbl);
            PanelA.Controls.Add(GrupAlbl);
            PanelA.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            PanelA.Location = new Point(22, 496);
            PanelA.Margin = new Padding(5, 4, 5, 4);
            PanelA.MaximumSize = new Size(346, 350);
            PanelA.MinimumSize = new Size(346, 350);
            PanelA.Name = "PanelA";
            PanelA.Size = new Size(346, 350);
            PanelA.TabIndex = 2;
            // 
            // AScoreslbl
            // 
            AScoreslbl.Location = new Point(123, 212);
            AScoreslbl.Margin = new Padding(5, 4, 5, 4);
            AScoreslbl.Name = "AScoreslbl";
            AScoreslbl.Size = new Size(93, 122);
            AScoreslbl.StateCommon.ShortText.Color1 = Color.SteelBlue;
            AScoreslbl.StateCommon.ShortText.Color2 = Color.SteelBlue;
            AScoreslbl.StateCommon.ShortText.Font = new Font("Arial", 72F, FontStyle.Bold, GraphicsUnit.Point);
            AScoreslbl.TabIndex = 3;
            AScoreslbl.Values.Text = "0";
            // 
            // APesertalbl
            // 
            APesertalbl.Location = new Point(49, 134);
            APesertalbl.Margin = new Padding(5, 4, 5, 4);
            APesertalbl.Name = "APesertalbl";
            APesertalbl.Size = new Size(240, 62);
            APesertalbl.StateCommon.ShortText.Color1 = Color.Black;
            APesertalbl.StateCommon.ShortText.Color2 = Color.Black;
            APesertalbl.StateCommon.ShortText.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            APesertalbl.TabIndex = 2;
            APesertalbl.Values.Text = "Peserta A";
            // 
            // GrupAlbl
            // 
            GrupAlbl.Location = new Point(14, 6);
            GrupAlbl.Margin = new Padding(5, 4, 5, 4);
            GrupAlbl.Name = "GrupAlbl";
            GrupAlbl.Size = new Size(312, 102);
            GrupAlbl.StateCommon.ShortText.Color1 = Color.Red;
            GrupAlbl.StateCommon.ShortText.Color2 = Color.Red;
            GrupAlbl.StateCommon.ShortText.Font = new Font("Arial", 60F, FontStyle.Bold, GraphicsUnit.Point);
            GrupAlbl.TabIndex = 0;
            GrupAlbl.Values.Text = "Grup A";
            // 
            // PanelB
            // 
            PanelB.Anchor = AnchorStyles.None;
            PanelB.AutoSize = true;
            PanelB.BorderStyle = BorderStyle.FixedSingle;
            PanelB.Controls.Add(BScoreslbl);
            PanelB.Controls.Add(BPesertalbl);
            PanelB.Controls.Add(GrupBlbl);
            PanelB.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            PanelB.Location = new Point(404, 496);
            PanelB.Margin = new Padding(5, 4, 5, 4);
            PanelB.MaximumSize = new Size(346, 350);
            PanelB.MinimumSize = new Size(346, 350);
            PanelB.Name = "PanelB";
            PanelB.Size = new Size(346, 350);
            PanelB.TabIndex = 3;
            // 
            // BScoreslbl
            // 
            BScoreslbl.Location = new Point(123, 212);
            BScoreslbl.Margin = new Padding(5, 4, 5, 4);
            BScoreslbl.Name = "BScoreslbl";
            BScoreslbl.Size = new Size(93, 122);
            BScoreslbl.StateCommon.ShortText.Color1 = Color.SteelBlue;
            BScoreslbl.StateCommon.ShortText.Color2 = Color.SteelBlue;
            BScoreslbl.StateCommon.ShortText.Font = new Font("Arial", 72F, FontStyle.Bold, GraphicsUnit.Point);
            BScoreslbl.TabIndex = 5;
            BScoreslbl.Values.Text = "0";
            // 
            // BPesertalbl
            // 
            BPesertalbl.Location = new Point(49, 134);
            BPesertalbl.Margin = new Padding(5, 4, 5, 4);
            BPesertalbl.Name = "BPesertalbl";
            BPesertalbl.Size = new Size(240, 62);
            BPesertalbl.StateCommon.ShortText.Color1 = Color.Black;
            BPesertalbl.StateCommon.ShortText.Color2 = Color.Black;
            BPesertalbl.StateCommon.ShortText.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            BPesertalbl.TabIndex = 3;
            BPesertalbl.Values.Text = "Peserta B";
            // 
            // GrupBlbl
            // 
            GrupBlbl.Location = new Point(14, 6);
            GrupBlbl.Margin = new Padding(5, 4, 5, 4);
            GrupBlbl.Name = "GrupBlbl";
            GrupBlbl.Size = new Size(312, 102);
            GrupBlbl.StateCommon.ShortText.Color1 = Color.Red;
            GrupBlbl.StateCommon.ShortText.Color2 = Color.Red;
            GrupBlbl.StateCommon.ShortText.Font = new Font("Arial", 60F, FontStyle.Bold, GraphicsUnit.Point);
            GrupBlbl.TabIndex = 0;
            GrupBlbl.Values.Text = "Grup B";
            // 
            // PanelC
            // 
            PanelC.Anchor = AnchorStyles.None;
            PanelC.AutoSize = true;
            PanelC.BorderStyle = BorderStyle.FixedSingle;
            PanelC.Controls.Add(CScoreslbl);
            PanelC.Controls.Add(CPesertalbl);
            PanelC.Controls.Add(GrupClbl);
            PanelC.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            PanelC.Location = new Point(786, 496);
            PanelC.Margin = new Padding(5, 4, 5, 4);
            PanelC.MaximumSize = new Size(346, 350);
            PanelC.MinimumSize = new Size(346, 350);
            PanelC.Name = "PanelC";
            PanelC.Size = new Size(346, 350);
            PanelC.TabIndex = 4;
            // 
            // CScoreslbl
            // 
            CScoreslbl.Location = new Point(123, 212);
            CScoreslbl.Margin = new Padding(5, 4, 5, 4);
            CScoreslbl.Name = "CScoreslbl";
            CScoreslbl.Size = new Size(93, 122);
            CScoreslbl.StateCommon.ShortText.Color1 = Color.SteelBlue;
            CScoreslbl.StateCommon.ShortText.Color2 = Color.SteelBlue;
            CScoreslbl.StateCommon.ShortText.Font = new Font("Arial", 72F, FontStyle.Bold, GraphicsUnit.Point);
            CScoreslbl.TabIndex = 6;
            CScoreslbl.Values.Text = "0";
            // 
            // CPesertalbl
            // 
            CPesertalbl.Location = new Point(49, 134);
            CPesertalbl.Margin = new Padding(5, 4, 5, 4);
            CPesertalbl.Name = "CPesertalbl";
            CPesertalbl.Size = new Size(242, 62);
            CPesertalbl.StateCommon.ShortText.Color1 = Color.Black;
            CPesertalbl.StateCommon.ShortText.Color2 = Color.Black;
            CPesertalbl.StateCommon.ShortText.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            CPesertalbl.TabIndex = 5;
            CPesertalbl.Values.Text = "Peserta C";
            // 
            // GrupClbl
            // 
            GrupClbl.Location = new Point(14, 6);
            GrupClbl.Margin = new Padding(5, 4, 5, 4);
            GrupClbl.Name = "GrupClbl";
            GrupClbl.Size = new Size(312, 102);
            GrupClbl.StateCommon.ShortText.Color1 = Color.Red;
            GrupClbl.StateCommon.ShortText.Color2 = Color.Red;
            GrupClbl.StateCommon.ShortText.Font = new Font("Arial", 60F, FontStyle.Bold, GraphicsUnit.Point);
            GrupClbl.TabIndex = 0;
            GrupClbl.Values.Text = "Grup C";
            // 
            // PanelD
            // 
            PanelD.Anchor = AnchorStyles.None;
            PanelD.AutoSize = true;
            PanelD.BorderStyle = BorderStyle.FixedSingle;
            PanelD.Controls.Add(DScoreslbl);
            PanelD.Controls.Add(DPesertalbl);
            PanelD.Controls.Add(GrupDlbl);
            PanelD.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            PanelD.Location = new Point(1168, 496);
            PanelD.Margin = new Padding(5, 4, 5, 4);
            PanelD.MaximumSize = new Size(346, 350);
            PanelD.MinimumSize = new Size(346, 350);
            PanelD.Name = "PanelD";
            PanelD.Size = new Size(346, 350);
            PanelD.TabIndex = 5;
            // 
            // DScoreslbl
            // 
            DScoreslbl.Location = new Point(124, 212);
            DScoreslbl.Margin = new Padding(5, 4, 5, 4);
            DScoreslbl.Name = "DScoreslbl";
            DScoreslbl.Size = new Size(93, 122);
            DScoreslbl.StateCommon.ShortText.Color1 = Color.SteelBlue;
            DScoreslbl.StateCommon.ShortText.Color2 = Color.SteelBlue;
            DScoreslbl.StateCommon.ShortText.Font = new Font("Arial", 72F, FontStyle.Bold, GraphicsUnit.Point);
            DScoreslbl.TabIndex = 6;
            DScoreslbl.Values.Text = "0";
            // 
            // DPesertalbl
            // 
            DPesertalbl.Location = new Point(49, 134);
            DPesertalbl.Margin = new Padding(5, 4, 5, 4);
            DPesertalbl.Name = "DPesertalbl";
            DPesertalbl.Size = new Size(242, 62);
            DPesertalbl.StateCommon.ShortText.Color1 = Color.Black;
            DPesertalbl.StateCommon.ShortText.Color2 = Color.Black;
            DPesertalbl.StateCommon.ShortText.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            DPesertalbl.TabIndex = 5;
            DPesertalbl.Values.Text = "Peserta D";
            // 
            // GrupDlbl
            // 
            GrupDlbl.Location = new Point(14, 6);
            GrupDlbl.Margin = new Padding(5, 4, 5, 4);
            GrupDlbl.Name = "GrupDlbl";
            GrupDlbl.Size = new Size(312, 102);
            GrupDlbl.StateCommon.ShortText.Color1 = Color.Red;
            GrupDlbl.StateCommon.ShortText.Color2 = Color.Red;
            GrupDlbl.StateCommon.ShortText.Font = new Font("Arial", 60F, FontStyle.Bold, GraphicsUnit.Point);
            GrupDlbl.TabIndex = 0;
            GrupDlbl.Values.Text = "Grup D";
            // 
            // Headinglbl
            // 
            Headinglbl.Location = new Point(378, 340);
            Headinglbl.Margin = new Padding(5, 4, 5, 4);
            Headinglbl.Name = "Headinglbl";
            Headinglbl.Size = new Size(797, 62);
            Headinglbl.StateCommon.ShortText.Color1 = Color.Black;
            Headinglbl.StateCommon.ShortText.Color2 = Color.Black;
            Headinglbl.StateCommon.ShortText.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            Headinglbl.TabIndex = 6;
            Headinglbl.Values.Text = "Lomba Cerdas Cermat Teknologi";
            // 
            // ScoresBoard
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1540, 941);
            Controls.Add(Headinglbl);
            Controls.Add(PanelD);
            Controls.Add(PanelC);
            Controls.Add(PanelB);
            Controls.Add(PanelA);
            Controls.Add(Logopb);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "ScoresBoard";
            Text = "AllPesertaScores";
            WindowState = FormWindowState.Maximized;
            Load += AllPesertaScores_Load;
            ((System.ComponentModel.ISupportInitialize)Logopb).EndInit();
            PanelA.ResumeLayout(false);
            PanelA.PerformLayout();
            PanelB.ResumeLayout(false);
            PanelB.PerformLayout();
            PanelC.ResumeLayout(false);
            PanelC.PerformLayout();
            PanelD.ResumeLayout(false);
            PanelD.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox Logopb;
        private System.Windows.Forms.Timer PesertaTimer;
        private Panel PanelA;
        private Krypton.Toolkit.KryptonLabel GrupAlbl;
        private Panel PanelB;
        private Krypton.Toolkit.KryptonLabel GrupBlbl;
        private Panel PanelC;
        private Krypton.Toolkit.KryptonLabel GrupClbl;
        private Panel PanelD;
        private Krypton.Toolkit.KryptonLabel GrupDlbl;
        private Krypton.Toolkit.KryptonLabel APesertalbl;
        private Krypton.Toolkit.KryptonLabel CPesertalbl;
        private Krypton.Toolkit.KryptonLabel DPesertalbl;
        private Krypton.Toolkit.KryptonLabel AScoreslbl;
        private Krypton.Toolkit.KryptonLabel BScoreslbl;
        private Krypton.Toolkit.KryptonLabel CScoreslbl;
        private Krypton.Toolkit.KryptonLabel DScoreslbl;
        private Krypton.Toolkit.KryptonLabel Headinglbl;
        private Krypton.Toolkit.KryptonLabel BPesertalbl;
    }
}