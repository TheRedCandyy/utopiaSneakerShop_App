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
        String con;
        public UserProfile(string conString)
        {
            InitializeComponent();
            con = conString;
            menuStrip1.BackColor = Color.FromArgb(226, 219, 192);
        }
    }
}
