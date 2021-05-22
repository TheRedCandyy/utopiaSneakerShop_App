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
    public partial class AdminProfile : UserControl
    {
        String con;
        NewAdmin adm_new;
        Brand adm_Brand;
        Model adm_Model;
        Product adm_Product;
        public AdminProfile()
        {
            InitializeComponent();
            WelcomeLabel.Text = "Welcome, administrator " + UserLoginForm.sessionUsername + "!";
            menuStrip1.BackColor = Color.FromArgb(226, 219, 192);
            adm_new = new NewAdmin();
            adm_Brand = new Brand();
            adm_Model = new Model();
            adm_Product = new Product();
            adm_new.Visible = false;
            adm_Brand.Visible = false;
            adm_Model.Visible = false;
            adm_Product.Visible = false;
            panel1.Controls.Add(adm_new);
            panel1.Controls.Add(adm_Brand);
            panel1.Controls.Add(adm_Model);
            panel1.Controls.Add(adm_Product);
        }

        private void newAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adm_new = new NewAdmin();
            panel1.Controls.Add(adm_new);
            adm_new.Visible = true;
            adm_Brand.Visible = false;
            WelcomeLabel.Visible = false;
            adm_Model.Visible = false;
            adm_Product.Visible = false;
        }

        private void newBrandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adm_Brand = new Brand();
            panel1.Controls.Add(adm_Brand);
            adm_new.Visible = false;
            adm_Brand.Visible = true;
            WelcomeLabel.Visible = false;
            adm_Model.Visible = false;
            adm_Product.Visible = false;
        }

        private void newModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adm_Model = new Model();
            panel1.Controls.Add(adm_Model);
            adm_new.Visible = false;
            adm_Brand.Visible = false;
            WelcomeLabel.Visible = false;
            adm_Model.Visible = true;
            adm_Product.Visible = false;
        }

        private void newProductToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            adm_Product = new Product();
            panel1.Controls.Add(adm_Product);
            adm_new.Visible = false;
            adm_Brand.Visible = false;
            WelcomeLabel.Visible = false;
            adm_Model.Visible = false;
            adm_Product.Visible = true;
        }
    }
}
