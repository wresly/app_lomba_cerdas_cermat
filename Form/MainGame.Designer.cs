namespace app_lomba_cerdas_cermat.Form
{
    partial class MainGame
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
            Game1btn = new Krypton.Toolkit.KryptonButton();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            Game2btn = new Krypton.Toolkit.KryptonButton();
            Game3btn = new Krypton.Toolkit.KryptonButton();
            Resetbtn = new Krypton.Toolkit.KryptonButton();
            AddScoresbtn = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // Game1btn
            // 
            Game1btn.Anchor = AnchorStyles.None;
            Game1btn.CornerRoundingRadius = -1F;
            Game1btn.Location = new Point(312, 140);
            Game1btn.Margin = new Padding(5, 4, 5, 4);
            Game1btn.Name = "Game1btn";
            Game1btn.Size = new Size(162, 37);
            Game1btn.TabIndex = 0;
            Game1btn.Values.Text = "Game 1";
            Game1btn.Click += Game1_Click;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Anchor = AnchorStyles.None;
            kryptonLabel1.Location = new Point(263, 78);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(260, 36);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 1;
            kryptonLabel1.Values.Text = "Game Status: None";
            // 
            // Game2btn
            // 
            Game2btn.Anchor = AnchorStyles.None;
            Game2btn.CornerRoundingRadius = -1F;
            Game2btn.Location = new Point(312, 189);
            Game2btn.Margin = new Padding(5, 4, 5, 4);
            Game2btn.Name = "Game2btn";
            Game2btn.Size = new Size(162, 37);
            Game2btn.TabIndex = 2;
            Game2btn.Values.Text = "Game 2";
            Game2btn.Click += Game2btn_Click;
            // 
            // Game3btn
            // 
            Game3btn.Anchor = AnchorStyles.None;
            Game3btn.CornerRoundingRadius = -1F;
            Game3btn.Location = new Point(312, 238);
            Game3btn.Margin = new Padding(5, 4, 5, 4);
            Game3btn.Name = "Game3btn";
            Game3btn.Size = new Size(162, 37);
            Game3btn.TabIndex = 3;
            Game3btn.Values.Text = "Game 3";
            Game3btn.Click += Game3btn_Click;
            // 
            // Resetbtn
            // 
            Resetbtn.Anchor = AnchorStyles.None;
            Resetbtn.CornerRoundingRadius = -1F;
            Resetbtn.Location = new Point(312, 336);
            Resetbtn.Margin = new Padding(5, 4, 5, 4);
            Resetbtn.Name = "Resetbtn";
            Resetbtn.Size = new Size(162, 37);
            Resetbtn.TabIndex = 4;
            Resetbtn.Values.Text = "Reset Game";
            Resetbtn.Click += Reset_Click;
            // 
            // AddScoresbtn
            // 
            AddScoresbtn.Anchor = AnchorStyles.None;
            AddScoresbtn.CornerRoundingRadius = -1F;
            AddScoresbtn.Location = new Point(312, 287);
            AddScoresbtn.Margin = new Padding(5, 4, 5, 4);
            AddScoresbtn.Name = "AddScoresbtn";
            AddScoresbtn.Size = new Size(162, 37);
            AddScoresbtn.TabIndex = 5;
            AddScoresbtn.Values.Text = "Add Scores Manual";
            AddScoresbtn.Click += AddScoresbtn_Click;
            // 
            // MainGame
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(787, 422);
            Controls.Add(AddScoresbtn);
            Controls.Add(Resetbtn);
            Controls.Add(Game3btn);
            Controls.Add(Game2btn);
            Controls.Add(kryptonLabel1);
            Controls.Add(Game1btn);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "MainGame";
            Text = "MainGame";
            WindowState = FormWindowState.Maximized;
            Load += MainGame_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonButton Game1btn;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton Game2btn;
        private Krypton.Toolkit.KryptonButton Game3btn;
        private Krypton.Toolkit.KryptonButton Resetbtn;
        private Krypton.Toolkit.KryptonButton AddScoresbtn;
    }
}