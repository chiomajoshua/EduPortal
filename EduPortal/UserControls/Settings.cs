using System;
using System.Windows.Forms;

namespace EduPortal.UserControls
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            switch (bunifuMetroTextbox6.isPassword)
            {
                case false:
                    bunifuMetroTextbox6.isPassword = true;
                    break;
                default:
                    bunifuMetroTextbox6.isPassword = false;
                    break;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            switch (bunifuMetroTextbox7.isPassword)
            {
                case false:
                    bunifuMetroTextbox7.isPassword = true;
                    break;
                default:
                    bunifuMetroTextbox7.isPassword = false;
                    break;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            switch (bunifuMetroTextbox8.isPassword)
            {
                case false:
                    bunifuMetroTextbox8.isPassword = true;
                    break;
                default:
                    bunifuMetroTextbox8.isPassword = false;
                    break;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (InfoBox.InformationBox.Show("Do You Really Want To Exit The Application?", "EduPortal || Confirm Action", InfoBox.InformationBoxButtons.YesNo, InfoBox.InformationBoxIcon.Question).ToString() == "No")
            {
                
            }
            else
            {
                Application.ExitThread();
               Application.Exit();
            }
        }
    }
}
