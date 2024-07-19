namespace app_lomba_cerdas_cermat.Form
{
    partial class Pesertafrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesertafrm));
            TimerCheckUser = new System.Windows.Forms.Timer(components);
            Pesertapnl = new Krypton.Toolkit.KryptonPanel();
            BackColorTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Pesertapnl).BeginInit();
            SuspendLayout();
            // 
            // TimerCheckUser
            // 
            TimerCheckUser.Tick += TimerCheckUser_Tick;
            // 
            // Pesertapnl
            // 
            Pesertapnl.Dock = DockStyle.Fill;
            Pesertapnl.Location = new Point(0, 0);
            Pesertapnl.Name = "Pesertapnl";
            Pesertapnl.Size = new Size(901, 505);
            Pesertapnl.TabIndex = 0;
            // 
            // BackColorTimer
            // 
            BackColorTimer.Interval = 1000;
            BackColorTimer.Tick += BackColorTimer_Tick;
            // 
            // Pesertafrm
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(901, 505);
            Controls.Add(Pesertapnl);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "Pesertafrm";
            Text = "Peserta";
            WindowState = FormWindowState.Maximized;
            Load += Pesertafrm_Load;
            ((System.ComponentModel.ISupportInitialize)Pesertapnl).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer TimerCheckUser;
        private Krypton.Toolkit.KryptonPanel Pesertapnl;
        private System.Windows.Forms.Timer BackColorTimer;
    }
}