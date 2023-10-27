namespace app_lomba_cerdas_cermat.Form.Sub_form
{
    partial class Waitingfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Waitingfrm));
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            Cancelbtn = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(46, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // Cancelbtn
            // 
            Cancelbtn.CornerRoundingRadius = -1F;
            Cancelbtn.Location = new Point(104, 172);
            Cancelbtn.Name = "Cancelbtn";
            Cancelbtn.Size = new Size(90, 25);
            Cancelbtn.TabIndex = 1;
            Cancelbtn.Values.Text = "Cancel";
            Cancelbtn.Click += Cancelbtn_Click;
            // 
            // Waitingfrm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(300, 223);
            ControlBox = false;
            Controls.Add(Cancelbtn);
            Controls.Add(pictureBox1);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Waitingfrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Waiting";
            Load += Waiting_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Krypton.Toolkit.KryptonButton Cancelbtn;
    }
}