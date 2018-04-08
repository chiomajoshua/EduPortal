namespace EduPortal.UserControls
{
    partial class Footer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(20, 16);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(375, 20);
            this.bunifuCustomLabel13.TabIndex = 1;
            this.bunifuCustomLabel13.Text = "Copyright ©2018. All rights reserved. HertLog Solutions";
            // 
            // Footer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCustomLabel13);
            this.Name = "Footer";
            this.Size = new System.Drawing.Size(1103, 52);
            this.Load += new System.EventHandler(this.Footer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
    }
}
