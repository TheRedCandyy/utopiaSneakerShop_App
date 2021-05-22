using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace utopiaSneakerShop
{
    public partial class Form1 : Form
    {
        public static String conString = "";
        PrivateFontCollection pfc = new PrivateFontCollection();
        UserProfile u_prof;
        UserClothing u_clothing;
        UserSneaker u_sneaker;
        AdminProfile adm_prof;
        public Form1()
        {
            InitializeComponent();
            if (conString.Equals(""))
            {
                DBConnect db = new DBConnect();
                db.ShowDialog();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = pictureBox1;
            u_prof = new UserProfile();
            u_clothing = new UserClothing();
            u_sneaker = new UserSneaker();
            adm_prof = new AdminProfile();
            u_prof.Visible = false;
            u_clothing.Visible = false;
            u_sneaker.Visible = false;
            adm_prof.Visible = false;
            panel1.Controls.Add(u_prof);
            panel1.Controls.Add(u_clothing);
            panel1.Controls.Add(u_sneaker);
            panel1.Controls.Add(adm_prof);
            if (UserLoginForm.sessionUsername.Equals(""))
            {
                LoginButton.Text = "Login";
                LogoutButton.Visible = false;
                LogoutButton.Enabled = false;
            }
            else
            {
                LogoutButton.Visible = true;
                LogoutButton.Enabled = true;
                LoginButton.Text = UserLoginForm.sessionUsername;
            }
        }
        private void QuitButton_Click(object sender, EventArgs e)
        {
            string msg1 = "Are you sure you want to leave?";
            string titulo1 = "Quit Utopia";
            var dr = MessageBox.Show(msg1, titulo1, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void HoverButton(Button btn, bool x)
        {
            btn.FlatStyle = FlatStyle.Flat;
            if (x)
            {
                btn.ForeColor = Color.White;
            }
            else
            {
                btn.ForeColor = Color.Black;
            }
        }
        private void SneakersButton_MouseEnter(object sender, EventArgs e)
        {
            HoverButton(SneakersButton, true);
        }

        private void ClothingButton_MouseEnter(object sender, EventArgs e)
        {
            HoverButton(ClothingButton, true);
        }

        private void LoginButton_MouseEnter(object sender, EventArgs e)
        {
            HoverButton(LoginButton, true);
        }
        private void LogoutButton_MouseEnter(object sender, EventArgs e)
        {
            HoverButton(LogoutButton, true);
        }
        private void SneakersButton_MouseLeave(object sender, EventArgs e)
        {
            HoverButton(SneakersButton, false);
        }

        private void ClothingButton_MouseLeave(object sender, EventArgs e)
        {
            HoverButton(ClothingButton, false);
        }

        private void LoginButton_MouseLeave(object sender, EventArgs e)
        {
            HoverButton(LoginButton, false);
        }
        private void LogoutButton_MouseLeave(object sender, EventArgs e)
        {
            HoverButton(LogoutButton, false);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UserLoginForm.sessionUsername.Equals(""))
            {
                this.Hide();
                var userForm = new UserLoginForm();
                userForm.Show();
            }
            else
            {
                if (UserLoginForm.isAdmin == true)
                {
                    adm_prof.Visible = true;
                    u_sneaker.Visible = false;
                    u_clothing.Visible = false;
                    u_prof.Visible = false;
                }
                else
                {
                    u_prof.Visible = true;
                    adm_prof.Visible = false;
                    u_sneaker.Visible = false;
                    u_clothing.Visible = false;
                }
            }
        }

        private void SneakersButton_Click(object sender, EventArgs e)
        {
            u_sneaker.Visible = true;
            u_clothing.Visible = false;
            u_prof.Visible = false;
            adm_prof.Visible = false;
        }

        private void ClothingButton_Click(object sender, EventArgs e)
        {
            u_sneaker.Visible = false;
            u_clothing.Visible = true;
            u_prof.Visible = false;
            adm_prof.Visible = false;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            UserLoginForm.sessionUsername = "";
            Application.Restart();
        }
    }
}
