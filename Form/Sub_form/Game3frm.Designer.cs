﻿namespace app_lomba_cerdas_cermat.Form.Sub_form
{
    partial class Game3frm
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
            Gamepnl = new Krypton.Toolkit.KryptonPanel();
            Minuslbl = new Krypton.Toolkit.KryptonLabel();
            Pluslbl = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel16 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel15 = new Krypton.Toolkit.KryptonLabel();
            Timerlbl = new Krypton.Toolkit.KryptonLabel();
            Pesertalbl = new Krypton.Toolkit.KryptonLabel();
            Statuslbl = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            Minustxt = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel14 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel13 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            Secondtxt = new Krypton.Toolkit.KryptonTextBox();
            Minutetxt = new Krypton.Toolkit.KryptonTextBox();
            Startbtn = new Krypton.Toolkit.KryptonButton();
            Plustxt = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            Resetbtn = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)Gamepnl).BeginInit();
            Gamepnl.SuspendLayout();
            SuspendLayout();
            // 
            // Gamepnl
            // 
            Gamepnl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Gamepnl.Controls.Add(Minuslbl);
            Gamepnl.Controls.Add(Pluslbl);
            Gamepnl.Controls.Add(kryptonLabel16);
            Gamepnl.Controls.Add(kryptonLabel15);
            Gamepnl.Controls.Add(Timerlbl);
            Gamepnl.Controls.Add(Pesertalbl);
            Gamepnl.Controls.Add(Statuslbl);
            Gamepnl.Controls.Add(kryptonLabel8);
            Gamepnl.Controls.Add(kryptonLabel7);
            Gamepnl.Controls.Add(kryptonLabel6);
            Gamepnl.Controls.Add(kryptonLabel5);
            Gamepnl.Location = new Point(502, 162);
            Gamepnl.Name = "Gamepnl";
            Gamepnl.Size = new Size(340, 254);
            Gamepnl.TabIndex = 33;
            // 
            // Minuslbl
            // 
            Minuslbl.Location = new Point(140, 170);
            Minuslbl.Name = "Minuslbl";
            Minuslbl.Size = new Size(42, 32);
            Minuslbl.StateCommon.ShortText.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Minuslbl.TabIndex = 10;
            Minuslbl.Values.Text = ": 0";
            // 
            // Pluslbl
            // 
            Pluslbl.Location = new Point(140, 134);
            Pluslbl.Name = "Pluslbl";
            Pluslbl.Size = new Size(42, 32);
            Pluslbl.StateCommon.ShortText.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Pluslbl.TabIndex = 9;
            Pluslbl.Values.Text = ": 0";
            // 
            // kryptonLabel16
            // 
            kryptonLabel16.Location = new Point(10, 170);
            kryptonLabel16.Name = "kryptonLabel16";
            kryptonLabel16.Size = new Size(123, 32);
            kryptonLabel16.StateCommon.ShortText.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel16.TabIndex = 8;
            kryptonLabel16.Values.Text = "Scores (-)";
            // 
            // kryptonLabel15
            // 
            kryptonLabel15.Location = new Point(10, 134);
            kryptonLabel15.Name = "kryptonLabel15";
            kryptonLabel15.Size = new Size(129, 32);
            kryptonLabel15.StateCommon.ShortText.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel15.TabIndex = 7;
            kryptonLabel15.Values.Text = "Scores (+)";
            // 
            // Timerlbl
            // 
            Timerlbl.Location = new Point(140, 206);
            Timerlbl.Name = "Timerlbl";
            Timerlbl.Size = new Size(90, 32);
            Timerlbl.StateCommon.ShortText.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Timerlbl.TabIndex = 6;
            Timerlbl.Values.Text = ": 00:00";
            // 
            // Pesertalbl
            // 
            Pesertalbl.Location = new Point(140, 98);
            Pesertalbl.Name = "Pesertalbl";
            Pesertalbl.Size = new Size(36, 32);
            Pesertalbl.StateCommon.ShortText.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Pesertalbl.TabIndex = 5;
            Pesertalbl.Values.Text = ": -";
            // 
            // Statuslbl
            // 
            Statuslbl.Location = new Point(140, 62);
            Statuslbl.Name = "Statuslbl";
            Statuslbl.Size = new Size(111, 32);
            Statuslbl.StateCommon.ShortText.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Statuslbl.TabIndex = 4;
            Statuslbl.Values.Text = ": Waiting";
            // 
            // kryptonLabel8
            // 
            kryptonLabel8.Location = new Point(10, 62);
            kryptonLabel8.Name = "kryptonLabel8";
            kryptonLabel8.Size = new Size(85, 32);
            kryptonLabel8.StateCommon.ShortText.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel8.TabIndex = 3;
            kryptonLabel8.Values.Text = "Status";
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Location = new Point(10, 206);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new Size(78, 32);
            kryptonLabel7.StateCommon.ShortText.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel7.TabIndex = 2;
            kryptonLabel7.Values.Text = "Timer ";
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Location = new Point(10, 98);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(100, 32);
            kryptonLabel6.StateCommon.ShortText.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel6.TabIndex = 1;
            kryptonLabel6.Values.Text = "Peserta ";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(4, 8);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(186, 36);
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel5.TabIndex = 0;
            kryptonLabel5.Values.Text = "Game Status";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(338, 18);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(201, 62);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 26;
            kryptonLabel1.Values.Text = "Game 3";
            // 
            // Minustxt
            // 
            Minustxt.Location = new Point(170, 256);
            Minustxt.Name = "Minustxt";
            Minustxt.Size = new Size(190, 29);
            Minustxt.StateCommon.Content.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Minustxt.TabIndex = 2;
            // 
            // kryptonLabel14
            // 
            kryptonLabel14.Location = new Point(20, 254);
            kryptonLabel14.Name = "kryptonLabel14";
            kryptonLabel14.Size = new Size(123, 32);
            kryptonLabel14.StateCommon.ShortText.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel14.TabIndex = 50;
            kryptonLabel14.Values.Text = "Scores (-)";
            // 
            // kryptonLabel13
            // 
            kryptonLabel13.Location = new Point(154, 259);
            kryptonLabel13.Name = "kryptonLabel13";
            kryptonLabel13.Size = new Size(16, 22);
            kryptonLabel13.StateCommon.ShortText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel13.TabIndex = 49;
            kryptonLabel13.Values.Text = ": ";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(203, 308);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(16, 22);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel4.TabIndex = 46;
            kryptonLabel4.Values.Text = ": ";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(20, 303);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(78, 32);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel3.TabIndex = 45;
            kryptonLabel3.Values.Text = "Timer ";
            // 
            // Secondtxt
            // 
            Secondtxt.Location = new Point(224, 305);
            Secondtxt.MaxLength = 2;
            Secondtxt.Name = "Secondtxt";
            Secondtxt.Size = new Size(28, 29);
            Secondtxt.StateCommon.Content.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Secondtxt.TabIndex = 4;
            Secondtxt.Text = "00";
            // 
            // Minutetxt
            // 
            Minutetxt.Location = new Point(170, 305);
            Minutetxt.MaxLength = 2;
            Minutetxt.Name = "Minutetxt";
            Minutetxt.Size = new Size(28, 29);
            Minutetxt.StateCommon.Content.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Minutetxt.TabIndex = 3;
            Minutetxt.Text = "00";
            // 
            // Startbtn
            // 
            Startbtn.CornerRoundingRadius = 5F;
            Startbtn.Location = new Point(170, 375);
            Startbtn.Margin = new Padding(5, 4, 5, 4);
            Startbtn.Name = "Startbtn";
            Startbtn.OverrideDefault.Back.Color1 = Color.FromArgb(58, 176, 255);
            Startbtn.OverrideDefault.Back.Color2 = Color.FromArgb(58, 176, 255);
            Startbtn.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Startbtn.OverrideDefault.Border.Width = 0;
            Startbtn.OverrideFocus.Back.Color1 = Color.FromArgb(58, 176, 255);
            Startbtn.OverrideFocus.Back.Color2 = Color.FromArgb(58, 176, 255);
            Startbtn.Size = new Size(101, 32);
            Startbtn.StateCommon.Back.Color1 = Color.FromArgb(58, 176, 255);
            Startbtn.StateCommon.Back.Color2 = Color.FromArgb(58, 176, 255);
            Startbtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Startbtn.StateCommon.Border.Rounding = 5F;
            Startbtn.StateCommon.Border.Width = 1;
            Startbtn.StateCommon.Content.Padding = new Padding(0);
            Startbtn.StateCommon.Content.ShortText.Color1 = Color.White;
            Startbtn.StateCommon.Content.ShortText.Color2 = Color.White;
            Startbtn.StateCommon.Content.ShortText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Startbtn.StateDisabled.Back.Color1 = Color.Silver;
            Startbtn.StateDisabled.Back.Color2 = Color.Silver;
            Startbtn.StateTracking.Back.Color1 = Color.FromArgb(58, 176, 255);
            Startbtn.StateTracking.Back.Color2 = Color.FromArgb(58, 176, 255);
            Startbtn.StateTracking.Border.Color1 = Color.FromArgb(58, 176, 255);
            Startbtn.StateTracking.Border.Color2 = Color.FromArgb(58, 176, 255);
            Startbtn.StateTracking.Border.ColorAngle = 45F;
            Startbtn.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Startbtn.StateTracking.Border.Rounding = 5F;
            Startbtn.StateTracking.Border.Width = 1;
            Startbtn.TabIndex = 5;
            Startbtn.Values.Text = "Start";
            Startbtn.Click += Startbtn_Click;
            // 
            // Plustxt
            // 
            Plustxt.Location = new Point(170, 207);
            Plustxt.Name = "Plustxt";
            Plustxt.Size = new Size(190, 29);
            Plustxt.StateCommon.Content.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Plustxt.TabIndex = 1;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(20, 205);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(129, 32);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel2.TabIndex = 54;
            kryptonLabel2.Values.Text = "Scores (+)";
            // 
            // kryptonLabel9
            // 
            kryptonLabel9.Location = new Point(154, 210);
            kryptonLabel9.Name = "kryptonLabel9";
            kryptonLabel9.Size = new Size(16, 22);
            kryptonLabel9.StateCommon.ShortText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel9.TabIndex = 53;
            kryptonLabel9.Values.Text = ": ";
            // 
            // kryptonLabel10
            // 
            kryptonLabel10.Location = new Point(154, 308);
            kryptonLabel10.Name = "kryptonLabel10";
            kryptonLabel10.Size = new Size(16, 22);
            kryptonLabel10.StateCommon.ShortText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel10.TabIndex = 56;
            kryptonLabel10.Values.Text = ": ";
            // 
            // timer1
            // 
            timer1.Interval = 500;
            // 
            // Resetbtn
            // 
            Resetbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Resetbtn.CornerRoundingRadius = 5F;
            Resetbtn.Enabled = false;
            Resetbtn.Location = new Point(20, 375);
            Resetbtn.Margin = new Padding(5, 4, 5, 4);
            Resetbtn.Name = "Resetbtn";
            Resetbtn.OverrideDefault.Back.Color1 = Color.FromArgb(255, 89, 89);
            Resetbtn.OverrideDefault.Back.Color2 = Color.FromArgb(255, 89, 89);
            Resetbtn.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Resetbtn.OverrideDefault.Border.Width = 0;
            Resetbtn.OverrideFocus.Back.Color1 = Color.FromArgb(255, 89, 89);
            Resetbtn.OverrideFocus.Back.Color2 = Color.FromArgb(255, 89, 89);
            Resetbtn.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Resetbtn.OverrideFocus.Border.Rounding = 5F;
            Resetbtn.Size = new Size(101, 32);
            Resetbtn.StateCommon.Back.Color1 = Color.FromArgb(255, 89, 89);
            Resetbtn.StateCommon.Back.Color2 = Color.FromArgb(255, 89, 89);
            Resetbtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Resetbtn.StateCommon.Border.Rounding = 5F;
            Resetbtn.StateCommon.Border.Width = 1;
            Resetbtn.StateCommon.Content.Padding = new Padding(0);
            Resetbtn.StateCommon.Content.ShortText.Color1 = Color.White;
            Resetbtn.StateCommon.Content.ShortText.Color2 = Color.White;
            Resetbtn.StateCommon.Content.ShortText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Resetbtn.StateDisabled.Back.Color1 = Color.Silver;
            Resetbtn.StateDisabled.Back.Color2 = Color.Silver;
            Resetbtn.StateTracking.Back.Color1 = Color.FromArgb(255, 89, 89);
            Resetbtn.StateTracking.Back.Color2 = Color.FromArgb(255, 89, 89);
            Resetbtn.StateTracking.Border.Color1 = Color.FromArgb(255, 89, 89);
            Resetbtn.StateTracking.Border.Color2 = Color.FromArgb(255, 89, 89);
            Resetbtn.StateTracking.Border.ColorAngle = 45F;
            Resetbtn.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Resetbtn.StateTracking.Border.Rounding = 5F;
            Resetbtn.StateTracking.Border.Width = 1;
            Resetbtn.TabIndex = 57;
            Resetbtn.Values.Text = "Reset";
            Resetbtn.Click += Resetbtn_Click;
            // 
            // Game3frm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 458);
            Controls.Add(Resetbtn);
            Controls.Add(kryptonLabel10);
            Controls.Add(Plustxt);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonLabel9);
            Controls.Add(Minustxt);
            Controls.Add(kryptonLabel14);
            Controls.Add(kryptonLabel13);
            Controls.Add(kryptonLabel4);
            Controls.Add(kryptonLabel3);
            Controls.Add(Secondtxt);
            Controls.Add(Minutetxt);
            Controls.Add(Startbtn);
            Controls.Add(Gamepnl);
            Controls.Add(kryptonLabel1);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Game3frm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game 3";
            Load += Game3frm_Load;
            ((System.ComponentModel.ISupportInitialize)Gamepnl).EndInit();
            Gamepnl.ResumeLayout(false);
            Gamepnl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel Gamepnl;
        private Krypton.Toolkit.KryptonLabel Timerlbl;
        private Krypton.Toolkit.KryptonLabel Pesertalbl;
        private Krypton.Toolkit.KryptonLabel Statuslbl;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox Minustxt;
        private Krypton.Toolkit.KryptonLabel kryptonLabel14;
        private Krypton.Toolkit.KryptonLabel kryptonLabel13;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonTextBox Secondtxt;
        private Krypton.Toolkit.KryptonTextBox Minutetxt;
        private Krypton.Toolkit.KryptonButton Startbtn;
        private Krypton.Toolkit.KryptonTextBox Plustxt;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonLabel Minuslbl;
        private Krypton.Toolkit.KryptonLabel Pluslbl;
        private Krypton.Toolkit.KryptonLabel kryptonLabel16;
        private Krypton.Toolkit.KryptonLabel kryptonLabel15;
        private System.Windows.Forms.Timer timer1;
        private Krypton.Toolkit.KryptonButton Resetbtn;
    }
}