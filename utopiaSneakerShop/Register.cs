using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace utopiaSneakerShop
{
    public partial class UserRegisterForm : Form
    {
        public static String conString;
        public UserRegisterForm()
        {
            InitializeComponent();
            conString = Form1.conString;
            MySqlConnection con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM user", con);
            con.Open();
            MySqlDataReader ler = cmd.ExecuteReader();
            try
            {
                con.Open();
                ler = cmd.ExecuteReader();
                while (ler.Read())
                {
                    if (ler.GetString("")) ;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (con.State.Equals(System.Data.ConnectionState.Open))
                {
                    con.Close();
                }
            }

            this.UsernameTextBox.BorderStyle = BorderStyle.None;
            this.UsernameTextBox.AutoSize = false;
            this.UsernameTextBox.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });
            this.EmailTextBox.BorderStyle = BorderStyle.None;
            this.EmailTextBox.AutoSize = false;
            this.EmailTextBox.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });
            this.PasswordTextBox.BorderStyle = BorderStyle.None;
            this.PasswordTextBox.AutoSize = false;
            this.PasswordTextBox.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });


            RegisterButton.Enabled = false;
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            var userLoginForm = new UserLoginForm();
            userLoginForm.Show();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(Form1.conString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO user(userUsername, userPassword, userEmail) VALUES (@username, @password, @email)", con);
            cmd.Parameters.AddWithValue("@username", this.UsernameTextBox.Text);
            cmd.Parameters.AddWithValue("@password", this.PasswordTextBox.Text);
            cmd.Parameters.AddWithValue("@email", this.EmailTextBox.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success!", "Registered with success!", MessageBoxButtons.OK);
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error!" + e1, "An error has ocurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void UsernameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(String.IsNullOrEmpty(UsernameTextBox.Text) || String.IsNullOrEmpty(EmailTextBox.Text) || String.IsNullOrEmpty(PasswordTextBox.Text)))
            {
                RegisterButton.Enabled = true;
            }
            else
            {
                RegisterButton.Enabled = false;
            }
        }

        private void EmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(String.IsNullOrEmpty(UsernameTextBox.Text) || String.IsNullOrEmpty(EmailTextBox.Text) || String.IsNullOrEmpty(PasswordTextBox.Text)))
            {
                RegisterButton.Enabled = true;
            }
            else
            {
                RegisterButton.Enabled = false;
            }
        }

        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(String.IsNullOrEmpty(UsernameTextBox.Text) || String.IsNullOrEmpty(EmailTextBox.Text) || String.IsNullOrEmpty(PasswordTextBox.Text)))
            {
                RegisterButton.Enabled = true;
            }
            else
            {
                RegisterButton.Enabled = false;
            }
        }
    }
}
