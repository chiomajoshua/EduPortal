namespace EduPortal
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.operationMenu1 = new EduPortal.UserControls.OperationMenu();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton20 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.titleBar1 = new EduPortal.UserControls.TitleBar();
            this.footer1 = new EduPortal.UserControls.Footer();
            this.settings1 = new EduPortal.UserControls.Settings();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 1102);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.flowLayoutPanel1.Controls.Add(this.operationMenu1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 88);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(334, 1014);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // operationMenu1
            // 
            this.operationMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(84)))));
            this.operationMenu1.Location = new System.Drawing.Point(3, 3);
            this.operationMenu1.Name = "operationMenu1";
            this.operationMenu1.Size = new System.Drawing.Size(331, 1011);
            this.operationMenu1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(198)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 88);
            this.panel2.TabIndex = 1;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(96, 35);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(110, 24);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "Edu-Portal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::EduPortal.Properties.Resources.Graduate_40px;
            this.pictureBox1.Location = new System.Drawing.Point(71, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuFlatButton20
            // 
            this.bunifuFlatButton20.Active = false;
            this.bunifuFlatButton20.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.bunifuFlatButton20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.bunifuFlatButton20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton20.BorderRadius = 0;
            this.bunifuFlatButton20.ButtonText = "     Class";
            this.bunifuFlatButton20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton20.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton20.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton20.Iconimage = global::EduPortal.Properties.Resources.Classroom_20px;
            this.bunifuFlatButton20.Iconimage_right = global::EduPortal.Properties.Resources.More_Than_20px;
            this.bunifuFlatButton20.Iconimage_right_Selected = global::EduPortal.Properties.Resources.dropdownwhite;
            this.bunifuFlatButton20.Iconimage_Selected = null;
            this.bunifuFlatButton20.IconMarginLeft = 0;
            this.bunifuFlatButton20.IconMarginRight = 0;
            this.bunifuFlatButton20.IconRightVisible = true;
            this.bunifuFlatButton20.IconRightZoom = 0D;
            this.bunifuFlatButton20.IconVisible = true;
            this.bunifuFlatButton20.IconZoom = 30D;
            this.bunifuFlatButton20.IsTab = false;
            this.bunifuFlatButton20.Location = new System.Drawing.Point(4, 1186);
            this.bunifuFlatButton20.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton20.Name = "bunifuFlatButton20";
            this.bunifuFlatButton20.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.bunifuFlatButton20.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.bunifuFlatButton20.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton20.selected = false;
            this.bunifuFlatButton20.Size = new System.Drawing.Size(351, 74);
            this.bunifuFlatButton20.TabIndex = 14;
            this.bunifuFlatButton20.Text = "     Class";
            this.bunifuFlatButton20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton20.Textcolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton20.TextFont = new System.Drawing.Font("Segoe UI", 10.8F);
            // 
            // titleBar1
            // 
            this.titleBar1.BackColor = System.Drawing.Color.White;
            this.titleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar1.Location = new System.Drawing.Point(334, 0);
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.Size = new System.Drawing.Size(1419, 88);
            this.titleBar1.TabIndex = 1;
            // 
            // footer1
            // 
            this.footer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer1.Location = new System.Drawing.Point(334, 1072);
            this.footer1.Name = "footer1";
            this.footer1.Size = new System.Drawing.Size(1419, 30);
            this.footer1.TabIndex = 16;
            // 
            // settings1
            // 
            this.settings1.Location = new System.Drawing.Point(340, 94);
            this.settings1.Name = "settings1";
            this.settings1.Size = new System.Drawing.Size(1467, 838);
            this.settings1.TabIndex = 17;
            this.settings1.Load += new System.EventHandler(this.settings1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1753, 1102);
            this.Controls.Add(this.settings1);
            this.Controls.Add(this.footer1);
            this.Controls.Add(this.bunifuFlatButton20);
            this.Controls.Add(this.titleBar1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private UserControls.OperationMenu operationMenu1;
        private UserControls.TitleBar titleBar1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton20;
        private UserControls.Footer footer1;
        private UserControls.Settings settings1;
    }
}

