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
            Spacebtn = new Krypton.Toolkit.KryptonButton();
            Extendbtn = new Krypton.Toolkit.KryptonButton();
            TimerCheckUser = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Spacebtn
            // 
            Spacebtn.Anchor = AnchorStyles.None;
            Spacebtn.CornerRoundingRadius = 5F;
            Spacebtn.Location = new Point(296, 186);
            Spacebtn.Name = "Spacebtn";
            Spacebtn.OverrideDefault.Back.Color1 = Color.FromArgb(80, 216, 144);
            Spacebtn.OverrideDefault.Back.Color2 = Color.FromArgb(80, 216, 144);
            Spacebtn.OverrideFocus.Back.Color1 = Color.FromArgb(80, 216, 144);
            Spacebtn.OverrideFocus.Back.Color2 = Color.FromArgb(80, 216, 144);
            Spacebtn.Size = new Size(294, 138);
            Spacebtn.StateCommon.Back.Color1 = Color.FromArgb(80, 216, 144);
            Spacebtn.StateCommon.Back.Color2 = Color.FromArgb(80, 216, 144);
            Spacebtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Spacebtn.StateCommon.Border.Rounding = 5F;
            Spacebtn.StateCommon.Content.ShortText.Color1 = Color.White;
            Spacebtn.StateCommon.Content.ShortText.Color2 = Color.White;
            Spacebtn.StateCommon.Content.ShortText.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Spacebtn.StateDisabled.Back.Color1 = Color.Silver;
            Spacebtn.StateDisabled.Back.Color2 = Color.Silver;
            Spacebtn.StateTracking.Back.Color1 = Color.FromArgb(80, 216, 144);
            Spacebtn.StateTracking.Back.Color2 = Color.FromArgb(80, 216, 144);
            Spacebtn.TabIndex = 0;
            Spacebtn.Values.Text = "Press Space";
            Spacebtn.Click += Spacebtn_Click;
            // 
            // Extendbtn
            // 
            Extendbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Extendbtn.CornerRoundingRadius = 5F;
            Extendbtn.Location = new Point(680, 34);
            Extendbtn.Name = "Extendbtn";
            Extendbtn.OverrideDefault.Back.Color1 = Color.FromArgb(79, 152, 202);
            Extendbtn.OverrideDefault.Back.Color2 = Color.FromArgb(79, 152, 202);
            Extendbtn.OverrideFocus.Back.Color1 = Color.FromArgb(79, 152, 202);
            Extendbtn.OverrideFocus.Back.Color2 = Color.FromArgb(79, 152, 202);
            Extendbtn.Size = new Size(186, 48);
            Extendbtn.StateCommon.Back.Color1 = Color.FromArgb(79, 152, 202);
            Extendbtn.StateCommon.Back.Color2 = Color.FromArgb(79, 152, 202);
            Extendbtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Extendbtn.StateCommon.Border.Rounding = 5F;
            Extendbtn.StateCommon.Content.ShortText.Color1 = Color.White;
            Extendbtn.StateCommon.Content.ShortText.Color2 = Color.White;
            Extendbtn.StateCommon.Content.ShortText.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Extendbtn.StateDisabled.Back.Color1 = Color.Silver;
            Extendbtn.StateDisabled.Back.Color2 = Color.Silver;
            Extendbtn.StateTracking.Back.Color1 = Color.FromArgb(79, 152, 202);
            Extendbtn.StateTracking.Back.Color2 = Color.FromArgb(79, 152, 202);
            Extendbtn.TabIndex = 1;
            Extendbtn.Values.Text = "Extend Scores";
            Extendbtn.Click += Extendbtn_Click;
            // 
            // TimerCheckUser
            // 
            TimerCheckUser.Tick += TimerCheckUser_Tick;
            // 
            // Pesertafrm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(901, 505);
            Controls.Add(Extendbtn);
            Controls.Add(Spacebtn);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Pesertafrm";
            Text = "Peserta";
            WindowState = FormWindowState.Maximized;
            Load += Pesertafrm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonButton Spacebtn;
        private Krypton.Toolkit.KryptonButton Extendbtn;
        private System.Windows.Forms.Timer TimerCheckUser;
    }
}