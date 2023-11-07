namespace app_lomba_cerdas_cermat.Form.Sub_form
{
    partial class PesertaTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesertaTimer));
            Timerlbl = new Label();
            GameTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Timerlbl
            // 
            Timerlbl.Anchor = AnchorStyles.None;
            Timerlbl.AutoSize = true;
            Timerlbl.Font = new Font("Arial", 70F, FontStyle.Bold, GraphicsUnit.Point);
            Timerlbl.Location = new Point(116, 86);
            Timerlbl.Margin = new Padding(8, 0, 8, 0);
            Timerlbl.Name = "Timerlbl";
            Timerlbl.Size = new Size(284, 108);
            Timerlbl.TabIndex = 29;
            Timerlbl.Text = "00:00";
            // 
            // GameTimer
            // 
            GameTimer.Interval = 1000;
            GameTimer.Tick += GameTimer_Tick;
            // 
            // PesertaTimer
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 296);
            ControlBox = false;
            Controls.Add(Timerlbl);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "PesertaTimer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PesertaTimer";
            Load += PesertaTimer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Timerlbl;
        private System.Windows.Forms.Timer GameTimer;
    }
}