﻿namespace app_lomba_cerdas_cermat.Form.Sub_form
{
    partial class AddScores
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
            Scorestxt = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            Addbtn = new Krypton.Toolkit.KryptonButton();
            Pesertacmb = new Krypton.Toolkit.KryptonComboBox();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)Pesertacmb).BeginInit();
            SuspendLayout();
            // 
            // Scorestxt
            // 
            Scorestxt.Location = new Point(70, 148);
            Scorestxt.Name = "Scorestxt";
            Scorestxt.Size = new Size(192, 29);
            Scorestxt.StateCommon.Content.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Scorestxt.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(70, 126);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(109, 22);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 1;
            kryptonLabel1.Values.Text = "Input Scores:";
            // 
            // Addbtn
            // 
            Addbtn.CornerRoundingRadius = 5F;
            Addbtn.Location = new Point(113, 198);
            Addbtn.Name = "Addbtn";
            Addbtn.OverrideFocus.Back.Color1 = Color.FromArgb(80, 216, 144);
            Addbtn.OverrideFocus.Back.Color2 = Color.FromArgb(80, 216, 144);
            Addbtn.Size = new Size(106, 34);
            Addbtn.StateCommon.Back.Color1 = Color.FromArgb(80, 216, 144);
            Addbtn.StateCommon.Back.Color2 = Color.FromArgb(80, 216, 144);
            Addbtn.StateCommon.Border.Color1 = Color.FromArgb(80, 216, 144);
            Addbtn.StateCommon.Border.Color2 = Color.FromArgb(80, 216, 144);
            Addbtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Addbtn.StateCommon.Border.Rounding = 5F;
            Addbtn.StateCommon.Content.ShortText.Color1 = Color.White;
            Addbtn.StateCommon.Content.ShortText.Color2 = Color.White;
            Addbtn.StateCommon.Content.ShortText.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Addbtn.TabIndex = 2;
            Addbtn.Values.Text = "ADD";
            Addbtn.Click += Addbtn_Click;
            // 
            // Pesertacmb
            // 
            Pesertacmb.CornerRoundingRadius = -1F;
            Pesertacmb.DropDownStyle = ComboBoxStyle.DropDownList;
            Pesertacmb.DropDownWidth = 121;
            Pesertacmb.IntegralHeight = false;
            Pesertacmb.Location = new Point(70, 72);
            Pesertacmb.Name = "Pesertacmb";
            Pesertacmb.Size = new Size(192, 27);
            Pesertacmb.StateCommon.ComboBox.Content.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Pesertacmb.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            Pesertacmb.TabIndex = 3;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(70, 48);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(73, 22);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel2.TabIndex = 4;
            kryptonLabel2.Values.Text = "Peserta:";
            // 
            // AddScores
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 272);
            Controls.Add(kryptonLabel2);
            Controls.Add(Pesertacmb);
            Controls.Add(Addbtn);
            Controls.Add(kryptonLabel1);
            Controls.Add(Scorestxt);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "AddScores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addScoresGame1";
            Load += AddScores_Load;
            ((System.ComponentModel.ISupportInitialize)Pesertacmb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox Scorestxt;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton Addbtn;
        private Krypton.Toolkit.KryptonComboBox Pesertacmb;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
    }
}