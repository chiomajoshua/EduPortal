using System;
using System.Drawing;
using System.Windows.Forms;

namespace EduPortal.UserControls
{
    public partial class MyMenu : UserControl
    {
        public MyMenu()
        {
            InitializeComponent();
        }

        private void MyMenu_Load(object sender, EventArgs e)
        {
           
        }

        private void LoadUserDetails()
        {
            var menuinstance = new MyMenu();
            var m = (menuinstance.Size.Width - bunifuCustomLabel1.Size.Width) / 2;
            bunifuCustomLabel1.Location = new Point(m, bunifuCustomLabel1.Location.Y);
            var n = (menuinstance.Size.Width - bunifuCustomLabel2.Size.Width) / 2;
            bunifuCustomLabel2.Location = new Point(n, bunifuCustomLabel2.Location.Y);
        }

        private void MyMenu_Click(object sender, EventArgs e)
        {
           // Hide();
        }
    }
}
