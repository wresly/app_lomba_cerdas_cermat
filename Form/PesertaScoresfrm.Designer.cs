namespace app_lomba_cerdas_cermat.Form
{
    partial class PesertaScoresfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesertaScoresfrm));
            Pointlbl = new Krypton.Toolkit.KryptonLabel();
            Usernamelbl = new Krypton.Toolkit.KryptonLabel();
            pictureBox1 = new PictureBox();
            TimerScores = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Pointlbl
            // 
            Pointlbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Pointlbl.AutoSize = false;
            Pointlbl.Location = new Point(0, 804);
            Pointlbl.Margin = new Padding(5, 4, 5, 4);
            Pointlbl.Name = "Pointlbl";
            Pointlbl.Size = new Size(1333, 179);
            Pointlbl.StateCommon.ShortText.Color1 = Color.Red;
            Pointlbl.StateCommon.ShortText.Color2 = Color.Red;
            Pointlbl.StateCommon.ShortText.Font = new Font("Arial", 100F, FontStyle.Bold, GraphicsUnit.Point);
            Pointlbl.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            Pointlbl.TabIndex = 0;
            Pointlbl.Values.Text = "100";
            // 
            // Usernamelbl
            // 
            Usernamelbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Usernamelbl.AutoSize = false;
            Usernamelbl.Location = new Point(0, 563);
            Usernamelbl.Margin = new Padding(5, 4, 5, 4);
            Usernamelbl.Name = "Usernamelbl";
            Usernamelbl.Size = new Size(1333, 179);
            Usernamelbl.StateCommon.ShortText.Font = new Font("Arial", 100F, FontStyle.Bold, GraphicsUnit.Point);
            Usernamelbl.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            Usernamelbl.TabIndex = 1;
            Usernamelbl.Values.Text = "XII RPL";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(387, 67);
            pictureBox1.Margin = new Padding(5, 4, 5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(559, 461);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // TimerScores
            // 
            TimerScores.Interval = 500;
            TimerScores.Tick += TimerScores_Tick;
            // 
            // PesertaScoresfrm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1334, 941);
            Controls.Add(pictureBox1);
            Controls.Add(Usernamelbl);
            Controls.Add(Pointlbl);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "PesertaScoresfrm";
            Text = "PesertaScoresfrm";
            Load += PesertaScoresfrm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel Pointlbl;
        private Krypton.Toolkit.KryptonLabel Usernamelbl;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer TimerScores;
    }
}