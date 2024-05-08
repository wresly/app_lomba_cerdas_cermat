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
            GameStatuslbl = new Krypton.Toolkit.KryptonLabel();
            Game2btn = new Krypton.Toolkit.KryptonButton();
            Game3btn = new Krypton.Toolkit.KryptonButton();
            Resetbtn = new Krypton.Toolkit.KryptonButton();
            AddScoresbtn = new Krypton.Toolkit.KryptonButton();
            GameCheckerTimer = new System.Windows.Forms.Timer(components);
            Game1btn = new Krypton.Toolkit.KryptonButton();
            SetGamebtn = new Krypton.Toolkit.KryptonButton();
            EditPLayerbtn = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // GameStatuslbl
            // 
            GameStatuslbl.Anchor = AnchorStyles.None;
            GameStatuslbl.Location = new Point(266, 114);
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
            Game2btn.Location = new Point(310, 262);
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
            Game3btn.Location = new Point(310, 309);
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
            Resetbtn.Location = new Point(310, 450);
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
            AddScoresbtn.Location = new Point(310, 356);
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
            // Game1btn
            // 
            Game1btn.Anchor = AnchorStyles.None;
            Game1btn.CornerRoundingRadius = -1F;
            Game1btn.Location = new Point(310, 215);
            Game1btn.Margin = new Padding(5, 4, 5, 4);
            Game1btn.Name = "Game1btn";
            Game1btn.Size = new Size(162, 37);
            Game1btn.TabIndex = 6;
            Game1btn.Values.Text = "Game 1";
            Game1btn.Click += Game1btn_Click;
            // 
            // SetGamebtn
            // 
            SetGamebtn.Anchor = AnchorStyles.None;
            SetGamebtn.CornerRoundingRadius = -1F;
            SetGamebtn.Location = new Point(310, 168);
            SetGamebtn.Margin = new Padding(5, 4, 5, 4);
            SetGamebtn.Name = "SetGamebtn";
            SetGamebtn.Size = new Size(162, 37);
            SetGamebtn.TabIndex = 7;
            SetGamebtn.Values.Text = "Set Game";
            SetGamebtn.Click += SetGamebtn_Click;
            // 
            // EditPLayerbtn
            // 
            EditPLayerbtn.Anchor = AnchorStyles.None;
            EditPLayerbtn.CornerRoundingRadius = -1F;
            EditPLayerbtn.Location = new Point(310, 403);
            EditPLayerbtn.Margin = new Padding(5, 4, 5, 4);
            EditPLayerbtn.Name = "EditPLayerbtn";
            EditPLayerbtn.Size = new Size(162, 37);
            EditPLayerbtn.TabIndex = 8;
            EditPLayerbtn.Values.Text = "Edit Player";
            EditPLayerbtn.Click += EditPLayerbtn_Click;
            // 
            // MainGame
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(787, 587);
            Controls.Add(EditPLayerbtn);
            Controls.Add(SetGamebtn);
            Controls.Add(Game1btn);
            Controls.Add(AddScoresbtn);
            Controls.Add(Resetbtn);
            Controls.Add(Game3btn);
            Controls.Add(Game2btn);
            Controls.Add(GameStatuslbl);
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
        private Krypton.Toolkit.KryptonLabel GameStatuslbl;
        private Krypton.Toolkit.KryptonButton Game2btn;
        private Krypton.Toolkit.KryptonButton Game3btn;
        private Krypton.Toolkit.KryptonButton Resetbtn;
        private Krypton.Toolkit.KryptonButton AddScoresbtn;
        private System.Windows.Forms.Timer GameCheckerTimer;
        private Krypton.Toolkit.KryptonButton Game1btn;
        private Krypton.Toolkit.KryptonButton SetGamebtn;
        private Krypton.Toolkit.KryptonButton EditPLayerbtn;
    }
}