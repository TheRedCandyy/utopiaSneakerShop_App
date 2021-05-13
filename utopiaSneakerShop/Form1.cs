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
        public static String conString = "server=192.168.56.103;user id=alex;database=utopia;Password=Passw0rd_123";
        PrivateFontCollection pfc = new PrivateFontCollection();
        UserProfile u_prof;
        UserClothing u_clothing;
        UserSneaker u_sneaker;
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = pictureBox1;
            u_prof = new UserProfile(conString);
            u_clothing = new UserClothing(conString);
            u_sneaker = new UserSneaker(conString);
            u_prof.Visible = false;
            u_clothing.Visible = false;
            u_sneaker.Visible = false;
            panel1.Controls.Add(u_prof);
            panel1.Controls.Add(u_clothing);
            panel1.Controls.Add(u_sneaker);
            if (UserLoginForm.sessionUsername.Equals(""))
            {
                LoginButton.Text = "Login";
            }
            else
            {
                LoginButton.Text = UserLoginForm.sessionUsername;
            }
            MySqlConnection con = new MySqlConnection(Form1.conString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM user", con);
            con.Open();
            MySqlDataReader ler = cmd.ExecuteReader();
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
                u_prof.Visible = true;
            }
        }

        private void SneakersButton_Click(object sender, EventArgs e)
        {
            u_sneaker.Visible = true;
            u_clothing.Visible = false;
            u_prof.Visible = false;
        }

        private void ClothingButton_Click(object sender, EventArgs e)
        {
            u_sneaker.Visible = false;
            u_clothing.Visible = true;
            u_prof.Visible = false;
        }
    }
}
