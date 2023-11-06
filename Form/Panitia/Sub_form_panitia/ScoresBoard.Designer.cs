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
            Logopb.Location = new Point(648, 46);
            Logopb.Name = "Logopb";
            Logopb.Size = new Size(254, 318);
            Logopb.TabIndex = 1;
            Logopb.TabStop = false;
            // 
            // PesertaTimer
            // 
            PesertaTimer.Tick += PesertaTimer_Tick;
            // 
            // PanelA
            // 
            PanelA.BorderStyle = BorderStyle.FixedSingle;
            PanelA.Controls.Add(AScoreslbl);
            PanelA.Controls.Add(APesertalbl);
            PanelA.Controls.Add(GrupAlbl);
            PanelA.Location = new Point(28, 522);
            PanelA.Name = "PanelA";
            PanelA.Size = new Size(344, 302);
            PanelA.TabIndex = 2;
            // 
            // AScoreslbl
            // 
            AScoreslbl.Location = new Point(140, 202);
            AScoreslbl.Name = "AScoreslbl";
            AScoreslbl.Size = new Size(64, 82);
            AScoreslbl.StateCommon.ShortText.Color1 = Color.SteelBlue;
            AScoreslbl.StateCommon.ShortText.Color2 = Color.SteelBlue;
            AScoreslbl.StateCommon.ShortText.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point);
            AScoreslbl.TabIndex = 3;
            AScoreslbl.Values.Text = "0";
            // 
            // APesertalbl
            // 
            APesertalbl.Location = new Point(79, 140);
            APesertalbl.Name = "APesertalbl";
            APesertalbl.Size = new Size(186, 48);
            APesertalbl.StateCommon.ShortText.Color1 = Color.Black;
            APesertalbl.StateCommon.ShortText.Color2 = Color.Black;
            APesertalbl.StateCommon.ShortText.Font = new Font("Arial", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            APesertalbl.TabIndex = 2;
            APesertalbl.Values.Text = "Peserta A";
            // 
            // GrupAlbl
            // 
            GrupAlbl.Location = new Point(16, 18);
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
            PanelB.BorderStyle = BorderStyle.FixedSingle;
            PanelB.Controls.Add(BScoreslbl);
            PanelB.Controls.Add(BPesertalbl);
            PanelB.Controls.Add(GrupBlbl);
            PanelB.Location = new Point(406, 522);
            PanelB.Name = "PanelB";
            PanelB.Size = new Size(344, 302);
            PanelB.TabIndex = 3;
            // 
            // BScoreslbl
            // 
            BScoreslbl.Location = new Point(140, 202);
            BScoreslbl.Name = "BScoreslbl";
            BScoreslbl.Size = new Size(64, 82);
            BScoreslbl.StateCommon.ShortText.Color1 = Color.SteelBlue;
            BScoreslbl.StateCommon.ShortText.Color2 = Color.SteelBlue;
            BScoreslbl.StateCommon.ShortText.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point);
            BScoreslbl.TabIndex = 5;
            BScoreslbl.Values.Text = "0";
            // 
            // BPesertalbl
            // 
            BPesertalbl.Location = new Point(79, 140);
            BPesertalbl.Name = "BPesertalbl";
            BPesertalbl.Size = new Size(186, 48);
            BPesertalbl.StateCommon.ShortText.Color1 = Color.Black;
            BPesertalbl.StateCommon.ShortText.Color2 = Color.Black;
            BPesertalbl.StateCommon.ShortText.Font = new Font("Arial", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            BPesertalbl.TabIndex = 3;
            BPesertalbl.Values.Text = "Peserta B";
            // 
            // GrupBlbl
            // 
            GrupBlbl.Location = new Point(16, 18);
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
            PanelC.BorderStyle = BorderStyle.FixedSingle;
            PanelC.Controls.Add(CScoreslbl);
            PanelC.Controls.Add(CPesertalbl);
            PanelC.Controls.Add(GrupClbl);
            PanelC.Location = new Point(784, 522);
            PanelC.Name = "PanelC";
            PanelC.Size = new Size(344, 302);
            PanelC.TabIndex = 4;
            // 
            // CScoreslbl
            // 
            CScoreslbl.Location = new Point(140, 202);
            CScoreslbl.Name = "CScoreslbl";
            CScoreslbl.Size = new Size(64, 82);
            CScoreslbl.StateCommon.ShortText.Color1 = Color.SteelBlue;
            CScoreslbl.StateCommon.ShortText.Color2 = Color.SteelBlue;
            CScoreslbl.StateCommon.ShortText.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point);
            CScoreslbl.TabIndex = 6;
            CScoreslbl.Values.Text = "0";
            // 
            // CPesertalbl
            // 
            CPesertalbl.Location = new Point(78, 140);
            CPesertalbl.Name = "CPesertalbl";
            CPesertalbl.Size = new Size(188, 48);
            CPesertalbl.StateCommon.ShortText.Color1 = Color.Black;
            CPesertalbl.StateCommon.ShortText.Color2 = Color.Black;
            CPesertalbl.StateCommon.ShortText.Font = new Font("Arial", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            CPesertalbl.TabIndex = 5;
            CPesertalbl.Values.Text = "Peserta C";
            // 
            // GrupClbl
            // 
            GrupClbl.Location = new Point(16, 18);
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
            PanelD.BorderStyle = BorderStyle.FixedSingle;
            PanelD.Controls.Add(DScoreslbl);
            PanelD.Controls.Add(DPesertalbl);
            PanelD.Controls.Add(GrupDlbl);
            PanelD.Location = new Point(1162, 522);
            PanelD.Name = "PanelD";
            PanelD.Size = new Size(344, 302);
            PanelD.TabIndex = 5;
            // 
            // DScoreslbl
            // 
            DScoreslbl.Location = new Point(140, 202);
            DScoreslbl.Name = "DScoreslbl";
            DScoreslbl.Size = new Size(64, 82);
            DScoreslbl.StateCommon.ShortText.Color1 = Color.SteelBlue;
            DScoreslbl.StateCommon.ShortText.Color2 = Color.SteelBlue;
            DScoreslbl.StateCommon.ShortText.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point);
            DScoreslbl.TabIndex = 6;
            DScoreslbl.Values.Text = "0";
            // 
            // DPesertalbl
            // 
            DPesertalbl.Location = new Point(78, 140);
            DPesertalbl.Name = "DPesertalbl";
            DPesertalbl.Size = new Size(188, 48);
            DPesertalbl.StateCommon.ShortText.Color1 = Color.Black;
            DPesertalbl.StateCommon.ShortText.Color2 = Color.Black;
            DPesertalbl.StateCommon.ShortText.Font = new Font("Arial", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            DPesertalbl.TabIndex = 5;
            DPesertalbl.Values.Text = "Peserta D";
            // 
            // GrupDlbl
            // 
            GrupDlbl.Location = new Point(16, 18);
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
            Headinglbl.Location = new Point(460, 382);
            Headinglbl.Name = "Headinglbl";
            Headinglbl.Size = new Size(613, 62);
            Headinglbl.StateCommon.ShortText.Color1 = Color.Black;
            Headinglbl.StateCommon.ShortText.Color2 = Color.Black;
            Headinglbl.StateCommon.ShortText.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            Headinglbl.TabIndex = 6;
            Headinglbl.Values.Text = "Lomba Cerdas Teknologi";
            // 
            // ScoresBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1540, 941);
            Controls.Add(Headinglbl);
            Controls.Add(PanelD);
            Controls.Add(PanelC);
            Controls.Add(PanelB);
            Controls.Add(PanelA);
            Controls.Add(Logopb);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
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