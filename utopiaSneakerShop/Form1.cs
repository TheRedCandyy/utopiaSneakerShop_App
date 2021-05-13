using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = pictureBox1;
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
        private void HoverButton(Button btn)
        {
            btn.BackColor = Color.FromArgb(226, 219, 192);
            btn.FlatStyle = FlatStyle.Flat;
        }
        private void SneakersButton_MouseHover(object sender, EventArgs e)
        {
            HoverButton(SneakersButton);
        }

        private void ClothingButton_MouseHover(object sender, EventArgs e)
        {
            HoverButton(ClothingButton);
        }

        private void LoginButton_MouseHover(object sender, EventArgs e)
        {
            HoverButton(LoginButton);
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
                //Show profile info
            }
        }
    }
}
