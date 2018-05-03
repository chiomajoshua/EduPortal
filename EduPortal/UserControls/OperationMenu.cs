using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduPortal.UserControls
{
    public partial class OperationMenu : UserControl
    {
        public OperationMenu()
        {
            InitializeComponent();
        }

        private void OperationMenu_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //var screenPoint = button1.PointToScreen(new Point(button1.Left, button1.Bottom));
            //contextMenuStrip1.Show(button1,
            //    screenPoint.Y + contextMenuStrip1.Size.Height > Screen.PrimaryScreen.WorkingArea.Height
            //        ? new Point(0, -contextMenuStrip1.Size.Height)
            //        : new Point(0, button1.Height));
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
                bunifuFlatButton5.Iconimage_right = Properties.Resources.dropdownwhite;
            }
            else
            {
                panel1.Visible = false;
                bunifuFlatButton5.Iconimage_right = Properties.Resources.More_Than_20px;
            }
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            if (panel3.Visible == false)
            {
                panel3.Visible = true;
                bunifuFlatButton9.Iconimage_right = Properties.Resources.dropdownwhite;
            }
            else
            {
                panel3.Visible = false;
                bunifuFlatButton9.Iconimage_right = Properties.Resources.More_Than_20px;
            }
        }

        private void bunifuFlatButton15_Click(object sender, EventArgs e)
        {
            if (panel4.Visible == false)
            {
                panel4.Visible = true;
                bunifuFlatButton15.Iconimage_right = Properties.Resources.dropdownwhite;
            }
            else
            {
                panel4.Visible = false;
                bunifuFlatButton15.Iconimage_right = Properties.Resources.More_Than_20px;
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {
                panel2.Visible = true;
                bunifuFlatButton4.Iconimage_right = Properties.Resources.dropdownwhite;
            }
            else
            {
                panel2.Visible = false;
                bunifuFlatButton4.Iconimage_right = Properties.Resources.More_Than_20px;
            }
        }

        private void bunifuFlatButton20_Click_1(object sender, EventArgs e)
        {
            if (panel5.Visible == false)
            {
                panel5.Visible = true;
                bunifuFlatButton20.Iconimage_right = Properties.Resources.dropdownwhite;
            }
            else
            {
                panel5.Visible = false;
                bunifuFlatButton20.Iconimage_right = Properties.Resources.More_Than_20px;
            }
        }

        private void bunifuFlatButton26_Click(object sender, EventArgs e)
        {
            switch (settings1.Visible)
            {
                case false:
                    settings1.Visible = true;
                    addStudent1.Visible = false;
                    allStudents1.Visible = false;
                    break;
                default:
                    settings1.Visible = false;
                    break;
            }
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            switch (addStudent1.Visible)
            {
                case false:
                    addStudent1.Visible = true;
                    settings1.Visible = false;
                    allStudents1.Visible = false;
                    break;
                default:
                    addStudent1.Visible = false;
                    break;
            }
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            switch (allStudents1.Visible)
            {
                case false:
                    addStudent1.Visible = false;
                    settings1.Visible = false;
                    allStudents1.Visible = true;
                    break;
                default:
                    allStudents1.Visible = false;
                    break;
            }
        }
    }
}
