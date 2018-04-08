namespace EduPortal.UserControls
{
    partial class TitleBar
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
            this.profile1 = new EduPortal.UserControls.Profile();
            this.SuspendLayout();
            // 
            // profile1
            // 
            this.profile1.BackColor = System.Drawing.Color.White;
            this.profile1.Dock = System.Windows.Forms.DockStyle.Right;
            this.profile1.Location = new System.Drawing.Point(1038, 0);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(204, 88);
            this.profile1.TabIndex = 0;
            // 
            // TitleBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.profile1);
            this.Name = "TitleBar";
            this.Size = new System.Drawing.Size(1242, 88);
            this.Load += new System.EventHandler(this.TitleBar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Profile profile1;
    }
}
