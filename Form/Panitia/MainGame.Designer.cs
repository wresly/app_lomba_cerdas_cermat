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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGame));
            Game1btn = new Krypton.Toolkit.KryptonButton();
            GameStatuslbl = new Krypton.Toolkit.KryptonLabel();
            Game2btn = new Krypton.Toolkit.KryptonButton();
            Game3btn = new Krypton.Toolkit.KryptonButton();
            Resetbtn = new Krypton.Toolkit.KryptonButton();
            AddScoresbtn = new Krypton.Toolkit.KryptonButton();
            GameCheckerTimer = new System.Windows.Forms.Timer(components);
            Timerbtn = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // Game1btn
            // 
            Game1btn.Anchor = AnchorStyles.None;
            Game1btn.CornerRoundingRadius = -1F;
            Game1btn.Location = new Point(312, 142);
            Game1btn.Margin = new Padding(5, 4, 5, 4);
            Game1btn.Name = "Game1btn";
            Game1btn.Size = new Size(162, 37);
            Game1btn.TabIndex = 0;
            Game1btn.Values.Text = "Game 1";
            Game1btn.Click += Game1_Click;
            // 
            // GameStatuslbl
            // 
            GameStatuslbl.Anchor = AnchorStyles.None;
            GameStatuslbl.Location = new Point(266, 32);
            GameStatuslbl.Name = "GameStatuslbl";
            GameStatuslbl.Size = new Size(260, 36);
            GameStatuslbl.StateCommon.ShortText.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            GameStatuslbl.TabIndex = 1;
            GameStatuslbl.Values.Text = "Game Status: None";
            // 
            // Game2btn
            // 
            Game2btn.Anchor = AnchorStyles.None;
            Game2btn.CornerRoundingRadius = -1F;
            Game2btn.Location = new Point(312, 190);
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
            Resetbtn.Location = new Point(312, 334);
            Resetbtn.Margin = new Padding(5, 4, 5, 4);
            Resetbtn.Name = "Resetbtn";
            Resetbtn.Size = new Size(162, 37);
            Resetbtn.TabIndex = 4;
            Resetbtn.Values.Text = "Reset All";
            Resetbtn.Click += Reset_Click;
            // 
            // AddScoresbtn
            // 
            AddScoresbtn.Anchor = AnchorStyles.None;
            AddScoresbtn.CornerRoundingRadius = -1F;
            AddScoresbtn.Location = new Point(312, 286);
            AddScoresbtn.Margin = new Padding(5, 4, 5, 4);
            AddScoresbtn.Name = "AddScoresbtn";
            AddScoresbtn.Size = new Size(162, 37);
            AddScoresbtn.TabIndex = 5;
            AddScoresbtn.Values.Text = "Add Scores Manual";
            AddScoresbtn.Click += AddScoresbtn_Click;
            // 
            // GameCheckerTimer
            // 
            GameCheckerTimer.Interval = 250;
            GameCheckerTimer.Tick += GameCheckerTimer_Tick;
            // 
            // Timerbtn
            // 
            Timerbtn.Anchor = AnchorStyles.None;
            Timerbtn.CornerRoundingRadius = -1F;
            Timerbtn.Location = new Point(312, 94);
            Timerbtn.Margin = new Padding(5, 4, 5, 4);
            Timerbtn.Name = "Timerbtn";
            Timerbtn.Size = new Size(162, 37);
            Timerbtn.TabIndex = 6;
            Timerbtn.Values.Text = "Timer";
            Timerbtn.Click += Timerbtn_Click;
            // 
            // MainGame
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(787, 422);
            Controls.Add(Timerbtn);
            Controls.Add(AddScoresbtn);
            Controls.Add(Resetbtn);
            Controls.Add(Game3btn);
            Controls.Add(Game2btn);
            Controls.Add(GameStatuslbl);
            Controls.Add(Game1btn);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Krypton.Toolkit.KryptonLabel GameStatuslbl;
        private Krypton.Toolkit.KryptonButton Game2btn;
        private Krypton.Toolkit.KryptonButton Game3btn;
        private Krypton.Toolkit.KryptonButton Resetbtn;
        private Krypton.Toolkit.KryptonButton AddScoresbtn;
        private System.Windows.Forms.Timer GameCheckerTimer;
        private Krypton.Toolkit.KryptonButton Timerbtn;
    }
}