namespace app_lomba_cerdas_cermat.Form.Panitia.Sub_form_panitia
{
    partial class Game1TimerOnlyfrm
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
            Seconds60btn = new Krypton.Toolkit.KryptonButton();
            Seconds30btn = new Krypton.Toolkit.KryptonButton();
            Seconds15btn = new Krypton.Toolkit.KryptonButton();
            Secondcmb = new Krypton.Toolkit.KryptonComboBox();
            MinuteMinusbtn = new Krypton.Toolkit.KryptonButton();
            MinutePlusbtn = new Krypton.Toolkit.KryptonButton();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            Secondtxt = new Krypton.Toolkit.KryptonTextBox();
            Minutetxt = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            Resetbtn = new Krypton.Toolkit.KryptonButton();
            Startbtn = new Krypton.Toolkit.KryptonButton();
            Finishbtn = new Krypton.Toolkit.KryptonButton();
            Timerlbl = new Label();
            CountDownTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Secondcmb).BeginInit();
            SuspendLayout();
            // 
            // Seconds60btn
            // 
            Seconds60btn.CornerRoundingRadius = -1F;
            Seconds60btn.Location = new Point(487, 137);
            Seconds60btn.Name = "Seconds60btn";
            Seconds60btn.Size = new Size(28, 25);
            Seconds60btn.TabIndex = 57;
            Seconds60btn.Values.Text = "60";
            Seconds60btn.Click += Seconds60btn_Click;
            // 
            // Seconds30btn
            // 
            Seconds30btn.CornerRoundingRadius = -1F;
            Seconds30btn.Location = new Point(449, 137);
            Seconds30btn.Name = "Seconds30btn";
            Seconds30btn.Size = new Size(28, 25);
            Seconds30btn.TabIndex = 56;
            Seconds30btn.Values.Text = "30";
            Seconds30btn.Click += Seconds30btn_Click;
            // 
            // Seconds15btn
            // 
            Seconds15btn.CornerRoundingRadius = -1F;
            Seconds15btn.Location = new Point(411, 137);
            Seconds15btn.Name = "Seconds15btn";
            Seconds15btn.Size = new Size(28, 25);
            Seconds15btn.TabIndex = 55;
            Seconds15btn.Values.Text = "15";
            Seconds15btn.Click += Seconds15btn_Click;
            // 
            // Secondcmb
            // 
            Secondcmb.CornerRoundingRadius = -1F;
            Secondcmb.DropDownStyle = ComboBoxStyle.DropDownList;
            Secondcmb.DropDownWidth = 52;
            Secondcmb.IntegralHeight = false;
            Secondcmb.Items.AddRange(new object[] { "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55", "60" });
            Secondcmb.Location = new Point(348, 136);
            Secondcmb.Name = "Secondcmb";
            Secondcmb.Size = new Size(52, 27);
            Secondcmb.StateCommon.ComboBox.Content.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Secondcmb.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            Secondcmb.TabIndex = 54;
            Secondcmb.SelectedIndexChanged += Secondcmb_SelectedIndexChanged;
            // 
            // MinuteMinusbtn
            // 
            MinuteMinusbtn.CornerRoundingRadius = -1F;
            MinuteMinusbtn.Location = new Point(159, 135);
            MinuteMinusbtn.Name = "MinuteMinusbtn";
            MinuteMinusbtn.Size = new Size(26, 29);
            MinuteMinusbtn.StateCommon.Content.ShortText.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            MinuteMinusbtn.TabIndex = 53;
            MinuteMinusbtn.Values.Text = "<";
            MinuteMinusbtn.Click += MinuteMinusbtn_Click;
            // 
            // MinutePlusbtn
            // 
            MinutePlusbtn.CornerRoundingRadius = -1F;
            MinutePlusbtn.Location = new Point(189, 135);
            MinutePlusbtn.Name = "MinutePlusbtn";
            MinutePlusbtn.Size = new Size(26, 29);
            MinutePlusbtn.StateCommon.Content.ShortText.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            MinutePlusbtn.TabIndex = 52;
            MinutePlusbtn.Values.Text = ">";
            MinutePlusbtn.Click += MinutePlusbtn_Click;
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(275, 138);
            kryptonLabel4.Margin = new Padding(4, 3, 4, 3);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(16, 22);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel4.TabIndex = 51;
            kryptonLabel4.Values.Text = ": ";
            // 
            // Secondtxt
            // 
            Secondtxt.Location = new Point(297, 135);
            Secondtxt.Margin = new Padding(4, 3, 4, 3);
            Secondtxt.MaxLength = 2;
            Secondtxt.Name = "Secondtxt";
            Secondtxt.Size = new Size(39, 29);
            Secondtxt.StateCommon.Content.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Secondtxt.TabIndex = 50;
            Secondtxt.Text = "00";
            Secondtxt.TextAlign = HorizontalAlignment.Center;
            // 
            // Minutetxt
            // 
            Minutetxt.Location = new Point(231, 135);
            Minutetxt.Margin = new Padding(4, 3, 4, 3);
            Minutetxt.MaxLength = 2;
            Minutetxt.Name = "Minutetxt";
            Minutetxt.Size = new Size(38, 29);
            Minutetxt.StateCommon.Content.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Minutetxt.TabIndex = 49;
            Minutetxt.Text = "00";
            Minutetxt.TextAlign = HorizontalAlignment.Center;
            // 
            // kryptonLabel9
            // 
            kryptonLabel9.Location = new Point(133, 138);
            kryptonLabel9.Margin = new Padding(4, 3, 4, 3);
            kryptonLabel9.Name = "kryptonLabel9";
            kryptonLabel9.Size = new Size(16, 22);
            kryptonLabel9.StateCommon.ShortText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel9.TabIndex = 59;
            kryptonLabel9.Values.Text = ": ";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(21, 133);
            kryptonLabel3.Margin = new Padding(4, 3, 4, 3);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(78, 32);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel3.TabIndex = 58;
            kryptonLabel3.Values.Text = "Timer";
            // 
            // Resetbtn
            // 
            Resetbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Resetbtn.CornerRoundingRadius = 5F;
            Resetbtn.Enabled = false;
            Resetbtn.Location = new Point(21, 211);
            Resetbtn.Margin = new Padding(6, 4, 6, 4);
            Resetbtn.Name = "Resetbtn";
            Resetbtn.OverrideDefault.Back.Color1 = Color.FromArgb(255, 89, 89);
            Resetbtn.OverrideDefault.Back.Color2 = Color.FromArgb(255, 89, 89);
            Resetbtn.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Resetbtn.OverrideDefault.Border.Width = 0;
            Resetbtn.OverrideFocus.Back.Color1 = Color.FromArgb(255, 89, 89);
            Resetbtn.OverrideFocus.Back.Color2 = Color.FromArgb(255, 89, 89);
            Resetbtn.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Resetbtn.OverrideFocus.Border.Rounding = 5F;
            Resetbtn.Size = new Size(128, 39);
            Resetbtn.StateCommon.Back.Color1 = Color.FromArgb(255, 89, 89);
            Resetbtn.StateCommon.Back.Color2 = Color.FromArgb(255, 89, 89);
            Resetbtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Resetbtn.StateCommon.Border.Rounding = 5F;
            Resetbtn.StateCommon.Border.Width = 1;
            Resetbtn.StateCommon.Content.Padding = new Padding(0);
            Resetbtn.StateCommon.Content.ShortText.Color1 = Color.White;
            Resetbtn.StateCommon.Content.ShortText.Color2 = Color.White;
            Resetbtn.StateCommon.Content.ShortText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Resetbtn.StateDisabled.Back.Color1 = Color.Silver;
            Resetbtn.StateDisabled.Back.Color2 = Color.Silver;
            Resetbtn.StateTracking.Back.Color1 = Color.FromArgb(255, 89, 89);
            Resetbtn.StateTracking.Back.Color2 = Color.FromArgb(255, 89, 89);
            Resetbtn.StateTracking.Border.Color1 = Color.FromArgb(255, 89, 89);
            Resetbtn.StateTracking.Border.Color2 = Color.FromArgb(255, 89, 89);
            Resetbtn.StateTracking.Border.ColorAngle = 45F;
            Resetbtn.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Resetbtn.StateTracking.Border.Rounding = 5F;
            Resetbtn.StateTracking.Border.Width = 1;
            Resetbtn.TabIndex = 60;
            Resetbtn.Values.Text = "Reset";
            Resetbtn.Click += Resetbtn_Click;
            // 
            // Startbtn
            // 
            Startbtn.CornerRoundingRadius = 5F;
            Startbtn.Location = new Point(179, 211);
            Startbtn.Margin = new Padding(6, 4, 6, 4);
            Startbtn.Name = "Startbtn";
            Startbtn.OverrideDefault.Back.Color1 = Color.FromArgb(166, 209, 230);
            Startbtn.OverrideDefault.Back.Color2 = Color.FromArgb(166, 209, 230);
            Startbtn.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Startbtn.OverrideDefault.Border.Width = 0;
            Startbtn.OverrideFocus.Back.Color1 = Color.FromArgb(166, 209, 230);
            Startbtn.OverrideFocus.Back.Color2 = Color.FromArgb(166, 209, 230);
            Startbtn.Size = new Size(128, 39);
            Startbtn.StateCommon.Back.Color1 = Color.FromArgb(58, 176, 255);
            Startbtn.StateCommon.Back.Color2 = Color.FromArgb(58, 176, 255);
            Startbtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Startbtn.StateCommon.Border.Rounding = 5F;
            Startbtn.StateCommon.Border.Width = 1;
            Startbtn.StateCommon.Content.Padding = new Padding(0);
            Startbtn.StateCommon.Content.ShortText.Color1 = Color.White;
            Startbtn.StateCommon.Content.ShortText.Color2 = Color.White;
            Startbtn.StateCommon.Content.ShortText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Startbtn.StateDisabled.Back.Color1 = Color.Silver;
            Startbtn.StateDisabled.Back.Color2 = Color.Silver;
            Startbtn.StateTracking.Back.Color1 = Color.FromArgb(58, 176, 255);
            Startbtn.StateTracking.Back.Color2 = Color.FromArgb(58, 176, 255);
            Startbtn.StateTracking.Border.Color1 = Color.FromArgb(58, 176, 255);
            Startbtn.StateTracking.Border.Color2 = Color.FromArgb(58, 176, 255);
            Startbtn.StateTracking.Border.ColorAngle = 45F;
            Startbtn.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Startbtn.StateTracking.Border.Rounding = 5F;
            Startbtn.StateTracking.Border.Width = 1;
            Startbtn.TabIndex = 61;
            Startbtn.Values.Text = "Start";
            Startbtn.Click += Startbtn_Click;
            // 
            // Finishbtn
            // 
            Finishbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Finishbtn.CornerRoundingRadius = 5F;
            Finishbtn.Location = new Point(290, 32);
            Finishbtn.Margin = new Padding(6, 4, 6, 4);
            Finishbtn.Name = "Finishbtn";
            Finishbtn.OverrideDefault.Back.Color1 = Color.FromArgb(166, 209, 230);
            Finishbtn.OverrideDefault.Back.Color2 = Color.FromArgb(166, 209, 230);
            Finishbtn.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Finishbtn.OverrideDefault.Border.Width = 0;
            Finishbtn.OverrideFocus.Back.Color1 = Color.FromArgb(255, 89, 89);
            Finishbtn.OverrideFocus.Back.Color2 = Color.FromArgb(255, 89, 89);
            Finishbtn.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Finishbtn.OverrideFocus.Border.Rounding = 5F;
            Finishbtn.Size = new Size(128, 39);
            Finishbtn.StateCommon.Back.Color1 = Color.FromArgb(255, 89, 89);
            Finishbtn.StateCommon.Back.Color2 = Color.FromArgb(255, 89, 89);
            Finishbtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Finishbtn.StateCommon.Border.Rounding = 5F;
            Finishbtn.StateCommon.Border.Width = 1;
            Finishbtn.StateCommon.Content.Padding = new Padding(0);
            Finishbtn.StateCommon.Content.ShortText.Color1 = Color.White;
            Finishbtn.StateCommon.Content.ShortText.Color2 = Color.White;
            Finishbtn.StateCommon.Content.ShortText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Finishbtn.StateDisabled.Back.Color1 = Color.Silver;
            Finishbtn.StateDisabled.Back.Color2 = Color.Silver;
            Finishbtn.StateTracking.Back.Color1 = Color.FromArgb(255, 89, 89);
            Finishbtn.StateTracking.Back.Color2 = Color.FromArgb(255, 89, 89);
            Finishbtn.StateTracking.Border.Color1 = Color.FromArgb(255, 89, 89);
            Finishbtn.StateTracking.Border.Color2 = Color.FromArgb(255, 89, 89);
            Finishbtn.StateTracking.Border.ColorAngle = 45F;
            Finishbtn.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Finishbtn.StateTracking.Border.Rounding = 5F;
            Finishbtn.StateTracking.Border.Width = 1;
            Finishbtn.TabIndex = 63;
            Finishbtn.Values.Text = "Finish";
            Finishbtn.Click += Finishbtn_Click;
            // 
            // Timerlbl
            // 
            Timerlbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Timerlbl.AutoSize = true;
            Timerlbl.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Timerlbl.Location = new Point(421, 33);
            Timerlbl.Margin = new Padding(6, 0, 6, 0);
            Timerlbl.Name = "Timerlbl";
            Timerlbl.Size = new Size(99, 37);
            Timerlbl.TabIndex = 62;
            Timerlbl.Text = "00:00";
            // 
            // CountDownTimer
            // 
            CountDownTimer.Interval = 1000;
            CountDownTimer.Tick += CountDownTimer_Tick;
            // 
            // Game1TimerOnlyfrm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 283);
            Controls.Add(Finishbtn);
            Controls.Add(Timerlbl);
            Controls.Add(Resetbtn);
            Controls.Add(Startbtn);
            Controls.Add(kryptonLabel9);
            Controls.Add(kryptonLabel3);
            Controls.Add(Seconds60btn);
            Controls.Add(Seconds30btn);
            Controls.Add(Seconds15btn);
            Controls.Add(Secondcmb);
            Controls.Add(MinuteMinusbtn);
            Controls.Add(MinutePlusbtn);
            Controls.Add(kryptonLabel4);
            Controls.Add(Secondtxt);
            Controls.Add(Minutetxt);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Game1TimerOnlyfrm";
            Text = "Game1TimerOnlyfrm";
            Load += Game1TimerOnlyfrm_Load;
            ((System.ComponentModel.ISupportInitialize)Secondcmb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonButton Seconds60btn;
        private Krypton.Toolkit.KryptonButton Seconds30btn;
        private Krypton.Toolkit.KryptonButton Seconds15btn;
        private Krypton.Toolkit.KryptonComboBox Secondcmb;
        private Krypton.Toolkit.KryptonButton MinuteMinusbtn;
        private Krypton.Toolkit.KryptonButton MinutePlusbtn;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonTextBox Secondtxt;
        private Krypton.Toolkit.KryptonTextBox Minutetxt;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonButton Resetbtn;
        private Krypton.Toolkit.KryptonButton Startbtn;
        private Krypton.Toolkit.KryptonButton Finishbtn;
        private Label Timerlbl;
        private System.Windows.Forms.Timer CountDownTimer;
    }
}