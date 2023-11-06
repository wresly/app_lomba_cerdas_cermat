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
            Pesertalbl = new Krypton.Toolkit.KryptonLabel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // Pointlbl
            // 
            Pointlbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Pointlbl.AutoSize = false;
            Pointlbl.Location = new Point(2, 724);
            Pointlbl.Margin = new Padding(5, 4, 5, 4);
            Pointlbl.Name = "Pointlbl";
            Pointlbl.Size = new Size(1555, 179);
            Pointlbl.StateCommon.ShortText.Color1 = Color.SteelBlue;
            Pointlbl.StateCommon.ShortText.Color2 = Color.SteelBlue;
            Pointlbl.StateCommon.ShortText.Font = new Font("Arial", 150F, FontStyle.Bold, GraphicsUnit.Point);
            Pointlbl.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            Pointlbl.TabIndex = 0;
            Pointlbl.Values.Text = "100";
            // 
            // Usernamelbl
            // 
            Usernamelbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Usernamelbl.AutoSize = false;
            Usernamelbl.Location = new Point(2, 396);
            Usernamelbl.Margin = new Padding(5, 4, 5, 4);
            Usernamelbl.Name = "Usernamelbl";
            Usernamelbl.Size = new Size(1555, 179);
            Usernamelbl.StateCommon.ShortText.Font = new Font("Arial", 100F, FontStyle.Bold, GraphicsUnit.Point);
            Usernamelbl.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            Usernamelbl.TabIndex = 1;
            Usernamelbl.Values.Text = "Grup A";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(90, 198);
            pictureBox1.Margin = new Padding(5, 4, 5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // TimerScores
            // 
            TimerScores.Interval = 500;
            TimerScores.Tick += TimerScores_Tick;
            // 
            // Pesertalbl
            // 
            Pesertalbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Pesertalbl.AutoSize = false;
            Pesertalbl.Location = new Point(0, 538);
            Pesertalbl.Margin = new Padding(5, 4, 5, 4);
            Pesertalbl.Name = "Pesertalbl";
            Pesertalbl.Size = new Size(1555, 179);
            Pesertalbl.StateCommon.ShortText.Color1 = Color.Black;
            Pesertalbl.StateCommon.ShortText.Color2 = Color.Black;
            Pesertalbl.StateCommon.ShortText.Font = new Font("Arial", 72F, FontStyle.Regular, GraphicsUnit.Point);
            Pesertalbl.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            Pesertalbl.TabIndex = 3;
            Pesertalbl.Values.Text = "Peserta";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1194, 173);
            pictureBox2.Margin = new Padding(5, 4, 5, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(234, 219);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(652, 70);
            pictureBox3.Margin = new Padding(5, 4, 5, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(256, 322);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // PesertaScoresfrm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1540, 941);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(Pesertalbl);
            Controls.Add(pictureBox1);
            Controls.Add(Usernamelbl);
            Controls.Add(Pointlbl);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(5, 4, 5, 4);
            Name = "PesertaScoresfrm";
            Text = "PesertaScoresfrm";
            WindowState = FormWindowState.Maximized;
            Load += PesertaScoresfrm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel Pointlbl;
        private Krypton.Toolkit.KryptonLabel Usernamelbl;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer TimerScores;
        private Krypton.Toolkit.KryptonLabel Pesertalbl;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}