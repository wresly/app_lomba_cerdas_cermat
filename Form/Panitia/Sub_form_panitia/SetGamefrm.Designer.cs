namespace app_lomba_cerdas_cermat.Form.Panitia.Sub_form_panitia
{
    partial class SetGamefrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetGamefrm));
            SesiGamecmb = new Krypton.Toolkit.KryptonComboBox();
            label1 = new Label();
            label2 = new Label();
            GroupAtxt = new Krypton.Toolkit.KryptonTextBox();
            label3 = new Label();
            label4 = new Label();
            GroupBtxt = new Krypton.Toolkit.KryptonTextBox();
            label5 = new Label();
            GroupCtxt = new Krypton.Toolkit.KryptonTextBox();
            label6 = new Label();
            GroupDtxt = new Krypton.Toolkit.KryptonTextBox();
            SetGamebtn = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)SesiGamecmb).BeginInit();
            SuspendLayout();
            // 
            // SesiGamecmb
            // 
            SesiGamecmb.CornerRoundingRadius = -1F;
            SesiGamecmb.DropDownStyle = ComboBoxStyle.DropDownList;
            SesiGamecmb.DropDownWidth = 170;
            SesiGamecmb.IntegralHeight = false;
            SesiGamecmb.Items.AddRange(new object[] { "Penyisihan", "Final" });
            SesiGamecmb.Location = new Point(30, 144);
            SesiGamecmb.Margin = new Padding(5, 4, 5, 4);
            SesiGamecmb.Name = "SesiGamecmb";
            SesiGamecmb.Size = new Size(200, 33);
            SesiGamecmb.StateCommon.ComboBox.Content.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SesiGamecmb.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            SesiGamecmb.TabIndex = 0;
            SesiGamecmb.SelectedIndexChanged += SesiGamecmb_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(104, 36);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(204, 46);
            label1.TabIndex = 1;
            label1.Text = "Set Game";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 120);
            label2.Name = "label2";
            label2.Size = new Size(118, 27);
            label2.TabIndex = 2;
            label2.Text = "Pilih Sesi:";
            // 
            // GroupAtxt
            // 
            GroupAtxt.Location = new Point(30, 234);
            GroupAtxt.Margin = new Padding(6, 5, 6, 5);
            GroupAtxt.Name = "GroupAtxt";
            GroupAtxt.Size = new Size(328, 34);
            GroupAtxt.StateCommon.Border.Color1 = Color.FromArgb(170, 170, 170);
            GroupAtxt.StateCommon.Border.Color2 = Color.FromArgb(170, 170, 170);
            GroupAtxt.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            GroupAtxt.StateCommon.Content.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            GroupAtxt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 210);
            label3.Name = "label3";
            label3.Size = new Size(108, 27);
            label3.TabIndex = 4;
            label3.Text = "Group A:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 290);
            label4.Name = "label4";
            label4.Size = new Size(110, 27);
            label4.TabIndex = 7;
            label4.Text = "Group B:";
            // 
            // GroupBtxt
            // 
            GroupBtxt.Location = new Point(30, 314);
            GroupBtxt.Margin = new Padding(6, 5, 6, 5);
            GroupBtxt.Name = "GroupBtxt";
            GroupBtxt.Size = new Size(328, 34);
            GroupBtxt.StateCommon.Border.Color1 = Color.FromArgb(170, 170, 170);
            GroupBtxt.StateCommon.Border.Color2 = Color.FromArgb(170, 170, 170);
            GroupBtxt.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            GroupBtxt.StateCommon.Content.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBtxt.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 370);
            label5.Name = "label5";
            label5.Size = new Size(111, 27);
            label5.TabIndex = 10;
            label5.Text = "Group C:";
            // 
            // GroupCtxt
            // 
            GroupCtxt.Location = new Point(30, 394);
            GroupCtxt.Margin = new Padding(6, 5, 6, 5);
            GroupCtxt.Name = "GroupCtxt";
            GroupCtxt.Size = new Size(328, 34);
            GroupCtxt.StateCommon.Border.Color1 = Color.FromArgb(170, 170, 170);
            GroupCtxt.StateCommon.Border.Color2 = Color.FromArgb(170, 170, 170);
            GroupCtxt.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            GroupCtxt.StateCommon.Content.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            GroupCtxt.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 450);
            label6.Name = "label6";
            label6.Size = new Size(111, 27);
            label6.TabIndex = 13;
            label6.Text = "Group D:";
            // 
            // GroupDtxt
            // 
            GroupDtxt.Location = new Point(30, 474);
            GroupDtxt.Margin = new Padding(6, 5, 6, 5);
            GroupDtxt.Name = "GroupDtxt";
            GroupDtxt.Size = new Size(328, 34);
            GroupDtxt.StateCommon.Border.Color1 = Color.FromArgb(170, 170, 170);
            GroupDtxt.StateCommon.Border.Color2 = Color.FromArgb(170, 170, 170);
            GroupDtxt.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            GroupDtxt.StateCommon.Content.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            GroupDtxt.TabIndex = 12;
            // 
            // SetGamebtn
            // 
            SetGamebtn.CornerRoundingRadius = 5F;
            SetGamebtn.Location = new Point(100, 554);
            SetGamebtn.Margin = new Padding(6, 5, 6, 5);
            SetGamebtn.Name = "SetGamebtn";
            SetGamebtn.OverrideDefault.Back.Color1 = Color.FromArgb(166, 209, 230);
            SetGamebtn.OverrideDefault.Back.Color2 = Color.FromArgb(166, 209, 230);
            SetGamebtn.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            SetGamebtn.OverrideDefault.Border.Width = 0;
            SetGamebtn.Size = new Size(188, 40);
            SetGamebtn.StateCommon.Back.Color1 = Color.FromArgb(58, 176, 255);
            SetGamebtn.StateCommon.Back.Color2 = Color.FromArgb(58, 176, 255);
            SetGamebtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            SetGamebtn.StateCommon.Border.Rounding = 5F;
            SetGamebtn.StateCommon.Border.Width = 1;
            SetGamebtn.StateCommon.Content.Padding = new Padding(0);
            SetGamebtn.StateCommon.Content.ShortText.Color1 = Color.White;
            SetGamebtn.StateCommon.Content.ShortText.Color2 = Color.White;
            SetGamebtn.StateCommon.Content.ShortText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SetGamebtn.StateTracking.Back.Color1 = Color.FromArgb(58, 176, 255);
            SetGamebtn.StateTracking.Back.Color2 = Color.FromArgb(58, 176, 255);
            SetGamebtn.StateTracking.Border.Color1 = Color.FromArgb(58, 176, 255);
            SetGamebtn.StateTracking.Border.Color2 = Color.FromArgb(58, 176, 255);
            SetGamebtn.StateTracking.Border.ColorAngle = 45F;
            SetGamebtn.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            SetGamebtn.StateTracking.Border.Rounding = 10F;
            SetGamebtn.StateTracking.Border.Width = 1;
            SetGamebtn.TabIndex = 15;
            SetGamebtn.Values.Text = "SetGame";
            SetGamebtn.Click += SetGamebtn_Click;
            // 
            // SetGamefrm
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 623);
            Controls.Add(SetGamebtn);
            Controls.Add(label6);
            Controls.Add(GroupDtxt);
            Controls.Add(label5);
            Controls.Add(GroupCtxt);
            Controls.Add(label4);
            Controls.Add(GroupBtxt);
            Controls.Add(label3);
            Controls.Add(GroupAtxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SesiGamecmb);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SetGamefrm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SetGamefrm";
            Load += SetGamefrm_Load;
            ((System.ComponentModel.ISupportInitialize)SesiGamecmb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonComboBox SesiGamecmb;
        private Label label1;
        private Label label2;
        private Krypton.Toolkit.KryptonTextBox GroupAtxt;
        private Label label3;
        private Label label4;
        private Krypton.Toolkit.KryptonTextBox GroupBtxt;
        private Label label5;
        private Krypton.Toolkit.KryptonTextBox GroupCtxt;
        private Label label6;
        private Krypton.Toolkit.KryptonTextBox GroupDtxt;
        private Krypton.Toolkit.KryptonButton SetGamebtn;
    }
}