using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace utopiaSneakerShop
{
    public partial class UserProfile : UserControl
    {
        public UserProfile()
        {
            InitializeComponent();
            menuStrip1.BackColor = Color.FromArgb(226, 219, 192);
            WelcomeLabel.Text = "Welcome, " + UserLoginForm.sessionUsername + "!";
        }

        private void yourAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void yourAddressToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
