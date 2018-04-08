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
    public partial class Footer : UserControl
    {
        public Footer()
        {
            InitializeComponent();
        }

        private void Footer_Load(object sender, EventArgs e)
        {
            bunifuCustomLabel13.Text = @"Copyright © " + DateTime.Now.Year + @". All rights reserved. HertLog Solutions";
        }
    }
}
