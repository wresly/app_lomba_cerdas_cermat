﻿namespace app_lomba_cerdas_cermat.Form
{
    partial class MainBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainBoard));
            MainBoardpnl = new Krypton.Toolkit.KryptonPanel();
            GameCheckerTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)MainBoardpnl).BeginInit();
            SuspendLayout();
            // 
            // MainBoardpnl
            // 
            MainBoardpnl.Dock = DockStyle.Fill;
            MainBoardpnl.Location = new Point(0, 0);
            MainBoardpnl.Margin = new Padding(3, 4, 3, 4);
            MainBoardpnl.Name = "MainBoardpnl";
            MainBoardpnl.Size = new Size(914, 600);
            MainBoardpnl.TabIndex = 0;
            // 
            // GameCheckerTimer
            // 
            GameCheckerTimer.Interval = 1000;
            GameCheckerTimer.Tick += GameCheckerTimer_Tick;
            // 
            // MainBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(MainBoardpnl);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainBoard";
            Text = "MainBoard";
            WindowState = FormWindowState.Maximized;
            Load += MainBoard_Load;
            ((System.ComponentModel.ISupportInitialize)MainBoardpnl).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel MainBoardpnl;
        private System.Windows.Forms.Timer GameCheckerTimer;
    }
}