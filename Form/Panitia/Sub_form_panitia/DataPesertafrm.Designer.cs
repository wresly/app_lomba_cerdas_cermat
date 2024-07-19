namespace app_lomba_cerdas_cermat
{
    partial class DataPesertafrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataPesertafrm));
            Usersdgv = new DataGridView();
            Tambahbtn = new Krypton.Toolkit.KryptonButton();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            Usertxt = new Krypton.Toolkit.KryptonTextBox();
            Userstimer = new System.Windows.Forms.Timer(components);
            Userscmb = new Krypton.Toolkit.KryptonComboBox();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)Usersdgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Userscmb).BeginInit();
            SuspendLayout();
            // 
            // Usersdgv
            // 
            Usersdgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Usersdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Usersdgv.BackgroundColor = SystemColors.Control;
            Usersdgv.BorderStyle = BorderStyle.Fixed3D;
            Usersdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Usersdgv.Location = new Point(56, 376);
            Usersdgv.Margin = new Padding(4);
            Usersdgv.Name = "Usersdgv";
            Usersdgv.ReadOnly = true;
            Usersdgv.RowHeadersVisible = false;
            Usersdgv.RowHeadersWidth = 51;
            Usersdgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            Usersdgv.RowTemplate.Height = 25;
            Usersdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Usersdgv.Size = new Size(1073, 261);
            Usersdgv.TabIndex = 10;
            Usersdgv.SelectionChanged += Usersdgv_SelectionChanged;
            Usersdgv.KeyDown += Usersdgv_KeyDown;
            // 
            // Tambahbtn
            // 
            Tambahbtn.CornerRoundingRadius = 5F;
            Tambahbtn.Location = new Point(56, 306);
            Tambahbtn.Margin = new Padding(6, 5, 6, 5);
            Tambahbtn.Name = "Tambahbtn";
            Tambahbtn.OverrideDefault.Back.Color1 = Color.FromArgb(166, 209, 230);
            Tambahbtn.OverrideDefault.Back.Color2 = Color.FromArgb(166, 209, 230);
            Tambahbtn.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Tambahbtn.OverrideDefault.Border.Width = 0;
            Tambahbtn.Size = new Size(176, 54);
            Tambahbtn.StateCommon.Back.Color1 = Color.FromArgb(58, 176, 255);
            Tambahbtn.StateCommon.Back.Color2 = Color.FromArgb(58, 176, 255);
            Tambahbtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Tambahbtn.StateCommon.Border.Rounding = 5F;
            Tambahbtn.StateCommon.Border.Width = 1;
            Tambahbtn.StateCommon.Content.Padding = new Padding(0);
            Tambahbtn.StateCommon.Content.ShortText.Color1 = Color.White;
            Tambahbtn.StateCommon.Content.ShortText.Color2 = Color.White;
            Tambahbtn.StateCommon.Content.ShortText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Tambahbtn.StateTracking.Back.Color1 = Color.FromArgb(58, 176, 255);
            Tambahbtn.StateTracking.Back.Color2 = Color.FromArgb(58, 176, 255);
            Tambahbtn.StateTracking.Border.Color1 = Color.FromArgb(58, 176, 255);
            Tambahbtn.StateTracking.Border.Color2 = Color.FromArgb(58, 176, 255);
            Tambahbtn.StateTracking.Border.ColorAngle = 45F;
            Tambahbtn.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Tambahbtn.StateTracking.Border.Rounding = 10F;
            Tambahbtn.StateTracking.Border.Width = 1;
            Tambahbtn.TabIndex = 3;
            Tambahbtn.Values.Text = "Set";
            Tambahbtn.Click += Setbtn_click;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Anchor = AnchorStyles.Top;
            kryptonLabel1.Location = new Point(440, 44);
            kryptonLabel1.Margin = new Padding(4);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(311, 60);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.Black;
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.Black;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 16;
            kryptonLabel1.Values.Text = "Data Peserta";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(56, 230);
            kryptonLabel2.Margin = new Padding(6, 5, 6, 5);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(120, 27);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.Black;
            kryptonLabel2.StateCommon.ShortText.Color2 = Color.Black;
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel2.TabIndex = 18;
            kryptonLabel2.Values.Text = "Nama Tim :";
            // 
            // Usertxt
            // 
            Usertxt.Location = new Point(56, 259);
            Usertxt.Margin = new Padding(6, 5, 6, 5);
            Usertxt.Name = "Usertxt";
            Usertxt.Size = new Size(230, 34);
            Usertxt.StateCommon.Border.Color1 = Color.FromArgb(170, 170, 170);
            Usertxt.StateCommon.Border.Color2 = Color.FromArgb(170, 170, 170);
            Usertxt.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Usertxt.StateCommon.Content.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Usertxt.TabIndex = 0;
            // 
            // Userstimer
            // 
            Userstimer.Interval = 1000;
            Userstimer.Tick += Userstimer_Tick;
            // 
            // Userscmb
            // 
            Userscmb.CornerRoundingRadius = -1F;
            Userscmb.DropDownStyle = ComboBoxStyle.DropDownList;
            Userscmb.DropDownWidth = 230;
            Userscmb.IntegralHeight = false;
            Userscmb.Location = new Point(56, 178);
            Userscmb.Name = "Userscmb";
            Userscmb.Size = new Size(230, 33);
            Userscmb.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Userscmb.StateCommon.ComboBox.Content.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Userscmb.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            Userscmb.TabIndex = 19;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(60, 148);
            kryptonLabel3.Margin = new Padding(6, 5, 6, 5);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(68, 27);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.Black;
            kryptonLabel3.StateCommon.ShortText.Color2 = Color.Black;
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel3.TabIndex = 20;
            kryptonLabel3.Values.Text = "User :";
            // 
            // DataPesertafrm
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1184, 711);
            Controls.Add(kryptonLabel3);
            Controls.Add(Userscmb);
            Controls.Add(kryptonLabel2);
            Controls.Add(Usertxt);
            Controls.Add(kryptonLabel1);
            Controls.Add(Tambahbtn);
            Controls.Add(Usersdgv);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "DataPesertafrm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Panitia Form";
            Load += DataPesertafrm_Load;
            ((System.ComponentModel.ISupportInitialize)Usersdgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)Userscmb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Usersdgv;
        private Krypton.Toolkit.KryptonButton Tambahbtn;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox Usertxt;
        private System.Windows.Forms.Timer Userstimer;
        private Krypton.Toolkit.KryptonComboBox Userscmb;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
    }
}