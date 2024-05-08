namespace app_lomba_cerdas_cermat.Form
{
    partial class TimerBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerBoard));
            Headinglbl = new Krypton.Toolkit.KryptonLabel();
            Logopb = new PictureBox();
            Timerlbl = new Krypton.Toolkit.KryptonLabel();
            GameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Logopb).BeginInit();
            SuspendLayout();
            // 
            // Headinglbl
            // 
            Headinglbl.Location = new Point(421, 412);
            Headinglbl.Name = "Headinglbl";
            Headinglbl.Size = new Size(613, 62);
            Headinglbl.StateCommon.ShortText.Color1 = Color.Black;
            Headinglbl.StateCommon.ShortText.Color2 = Color.Black;
            Headinglbl.StateCommon.ShortText.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            Headinglbl.TabIndex = 8;
            Headinglbl.Values.Text = "Lomba Cerdas Teknologi";
            // 
            // Logopb
            // 
            Logopb.Image = (Image)resources.GetObject("Logopb.Image");
            Logopb.Location = new Point(567, 70);
            Logopb.Name = "Logopb";
            Logopb.Size = new Size(320, 320);
            Logopb.SizeMode = PictureBoxSizeMode.Zoom;
            Logopb.TabIndex = 7;
            Logopb.TabStop = false;
            // 
            // Timerlbl
            // 
            Timerlbl.Location = new Point(427, 578);
            Timerlbl.Name = "Timerlbl";
            Timerlbl.Size = new Size(600, 251);
            Timerlbl.StateCommon.ShortText.Font = new Font("Arial", 150F, FontStyle.Bold, GraphicsUnit.Point);
            Timerlbl.TabIndex = 9;
            Timerlbl.Values.Text = "00:00";
            // 
            // GameTimer
            // 
            GameTimer.Interval = 1000;
            GameTimer.Tick += GameTimer_Tick;
            // 
            // TimerBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1540, 941);
            Controls.Add(Timerlbl);
            Controls.Add(Headinglbl);
            Controls.Add(Logopb);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TimerBoard";
            Text = "TimerBoard";
            WindowState = FormWindowState.Maximized;
            Load += TimerBoard_Load;
            Shown += TimerBoard_Shown;
            ((System.ComponentModel.ISupportInitialize)Logopb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel Headinglbl;
        private PictureBox Logopb;
        public Krypton.Toolkit.KryptonLabel Timerlbl;
        public System.Windows.Forms.Timer GameTimer;
    }
}