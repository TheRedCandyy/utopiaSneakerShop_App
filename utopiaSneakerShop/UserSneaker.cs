using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace utopiaSneakerShop
{
    public partial class UserSneaker : UserControl
    {
        String con;
        public UserSneaker(string conString)
        {
            InitializeComponent();
            con = conString;
        }
    }
}
