namespace app_lomba_cerdas_cermat.Form.Sub_form
{
    partial class Settingfrm
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
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            SuspendLayout();
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Anchor = AnchorStyles.None;
            kryptonLabel1.Location = new Point(94, 160);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(638, 122);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Arial", 72F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "Coming Soon";
            // 
            // Settingfrm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 463);
            Controls.Add(kryptonLabel1);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Settingfrm";
            Text = "Settingfrm";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}