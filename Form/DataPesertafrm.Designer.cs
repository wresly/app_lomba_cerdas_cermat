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
            Usersdgv = new DataGridView();
            Tambahbtn = new Krypton.Toolkit.KryptonButton();
            Hapusbtn = new Krypton.Toolkit.KryptonButton();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            Passtxt = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            Usertxt = new Krypton.Toolkit.KryptonTextBox();
            Userstimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Usersdgv).BeginInit();
            SuspendLayout();
            // 
            // Usersdgv
            // 
            Usersdgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Usersdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Usersdgv.BackgroundColor = SystemColors.Control;
            Usersdgv.BorderStyle = BorderStyle.Fixed3D;
            Usersdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Usersdgv.Location = new Point(46, 308);
            Usersdgv.Name = "Usersdgv";
            Usersdgv.ReadOnly = true;
            Usersdgv.RowHeadersVisible = false;
            Usersdgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            Usersdgv.RowTemplate.Height = 25;
            Usersdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Usersdgv.Size = new Size(1112, 374);
            Usersdgv.TabIndex = 10;
            Usersdgv.SelectionChanged += Usersdgv_SelectionChanged;
            Usersdgv.KeyDown += Usersdgv_KeyDown;
            // 
            // Tambahbtn
            // 
            Tambahbtn.CornerRoundingRadius = 5F;
            Tambahbtn.Location = new Point(206, 260);
            Tambahbtn.Margin = new Padding(5, 4, 5, 4);
            Tambahbtn.Name = "Tambahbtn";
            Tambahbtn.OverrideDefault.Back.Color1 = Color.FromArgb(166, 209, 230);
            Tambahbtn.OverrideDefault.Back.Color2 = Color.FromArgb(166, 209, 230);
            Tambahbtn.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Tambahbtn.OverrideDefault.Border.Width = 0;
            Tambahbtn.Size = new Size(144, 44);
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
            Tambahbtn.Values.Text = "Tambah";
            Tambahbtn.Click += Tambahbtn_Click;
            // 
            // Hapusbtn
            // 
            Hapusbtn.CornerRoundingRadius = 5F;
            Hapusbtn.Location = new Point(46, 260);
            Hapusbtn.Margin = new Padding(5, 4, 5, 4);
            Hapusbtn.Name = "Hapusbtn";
            Hapusbtn.OverrideDefault.Back.Color1 = Color.FromArgb(166, 209, 230);
            Hapusbtn.OverrideDefault.Back.Color2 = Color.FromArgb(166, 209, 230);
            Hapusbtn.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Hapusbtn.OverrideDefault.Border.Width = 0;
            Hapusbtn.Size = new Size(144, 44);
            Hapusbtn.StateCommon.Back.Color1 = Color.FromArgb(255, 89, 89);
            Hapusbtn.StateCommon.Back.Color2 = Color.FromArgb(255, 89, 89);
            Hapusbtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Hapusbtn.StateCommon.Border.Rounding = 5F;
            Hapusbtn.StateCommon.Border.Width = 1;
            Hapusbtn.StateCommon.Content.Padding = new Padding(0);
            Hapusbtn.StateCommon.Content.ShortText.Color1 = Color.White;
            Hapusbtn.StateCommon.Content.ShortText.Color2 = Color.White;
            Hapusbtn.StateCommon.Content.ShortText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Hapusbtn.StateTracking.Back.Color1 = Color.FromArgb(255, 89, 89);
            Hapusbtn.StateTracking.Back.Color2 = Color.FromArgb(255, 89, 89);
            Hapusbtn.StateTracking.Border.Color1 = Color.FromArgb(255, 89, 89);
            Hapusbtn.StateTracking.Border.Color2 = Color.FromArgb(255, 89, 89);
            Hapusbtn.StateTracking.Border.ColorAngle = 45F;
            Hapusbtn.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Hapusbtn.StateTracking.Border.Rounding = 10F;
            Hapusbtn.StateTracking.Border.Width = 1;
            Hapusbtn.TabIndex = 2;
            Hapusbtn.Values.Text = "Hapus";
            Hapusbtn.Click += Hapusbtn_Click;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Anchor = AnchorStyles.Top;
            kryptonLabel1.Location = new Point(477, 36);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(250, 48);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.Black;
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.Black;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 16;
            kryptonLabel1.Values.Text = "Data Peserta";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(46, 200);
            kryptonLabel3.Margin = new Padding(5, 4, 5, 4);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(93, 22);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.Black;
            kryptonLabel3.StateCommon.ShortText.Color2 = Color.Black;
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel3.TabIndex = 20;
            kryptonLabel3.Values.Text = "Password :";
            // 
            // Passtxt
            // 
            Passtxt.Location = new Point(46, 222);
            Passtxt.Margin = new Padding(5, 4, 5, 4);
            Passtxt.Name = "Passtxt";
            Passtxt.Size = new Size(304, 29);
            Passtxt.StateCommon.Border.Color1 = Color.FromArgb(170, 170, 170);
            Passtxt.StateCommon.Border.Color2 = Color.FromArgb(170, 170, 170);
            Passtxt.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Passtxt.StateCommon.Content.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Passtxt.TabIndex = 1;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(46, 137);
            kryptonLabel2.Margin = new Padding(5, 4, 5, 4);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(97, 22);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.Black;
            kryptonLabel2.StateCommon.ShortText.Color2 = Color.Black;
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel2.TabIndex = 18;
            kryptonLabel2.Values.Text = "Username :";
            // 
            // Usertxt
            // 
            Usertxt.Location = new Point(46, 160);
            Usertxt.Margin = new Padding(5, 4, 5, 4);
            Usertxt.Name = "Usertxt";
            Usertxt.Size = new Size(304, 29);
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
            // DataPesertafrm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1203, 742);
            Controls.Add(kryptonLabel3);
            Controls.Add(Passtxt);
            Controls.Add(kryptonLabel2);
            Controls.Add(Usertxt);
            Controls.Add(kryptonLabel1);
            Controls.Add(Hapusbtn);
            Controls.Add(Tambahbtn);
            Controls.Add(Usersdgv);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "DataPesertafrm";
            Text = "Panitia Form";
            WindowState = FormWindowState.Maximized;
            Load += DataPesertafrm_Load;
            ((System.ComponentModel.ISupportInitialize)Usersdgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Usersdgv;
        private Krypton.Toolkit.KryptonButton Tambahbtn;
        private Krypton.Toolkit.KryptonButton Hapusbtn;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonTextBox Passtxt;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox Usertxt;
        private System.Windows.Forms.Timer Userstimer;
    }
}