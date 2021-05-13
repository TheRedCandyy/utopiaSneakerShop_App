using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace utopiaSneakerShop
{
    public partial class UserLoginForm : Form
    {
        public static String conString;
        public static String sessionUsername = "";
        public UserLoginForm()
        {
            InitializeComponent();
            conString = Form1.conString;
            this.ActiveControl = pictureBox1;
            this.UsernameTextBox.BorderStyle = BorderStyle.None;
            this.UsernameTextBox.AutoSize = false; //Allows you to change height to have bottom padding
            this.UsernameTextBox.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });
            this.PasswordTextBox.BorderStyle = BorderStyle.None;
            this.PasswordTextBox.AutoSize = false; //Allows you to change height to have bottom padding
            this.PasswordTextBox.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });

            LoginButton.Enabled = false;
        }

        private void UserLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            var userRegisterForm = new UserRegisterForm();
            userRegisterForm.Show();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            var form1 = new Form1();
            form1.Show();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void RegisterLabel_MouseEnter(object sender, EventArgs e)
        {
            RegisterLabel.Font = new Font(RegisterLabel.Font.Name, RegisterLabel.Font.SizeInPoints, FontStyle.Underline);
        }

        private void RegisterLabel_MouseLeave(object sender, EventArgs e)
        {
            RegisterLabel.Font = new Font(RegisterLabel.Font.Name, RegisterLabel.Font.SizeInPoints, FontStyle.Regular);
        }

        private void RegisterLabel_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void LoginButton_Click(object sender, EventArgs e) { 
        
            MySqlConnection con1 = new MySqlConnection(Form1.conString);
            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM user WHERE userUsername = @username AND userPassword = @password", con1);
            cmd1.Parameters.AddWithValue("@username", this.UsernameTextBox.Text);
            cmd1.Parameters.AddWithValue("@password", this.PasswordTextBox.Text);

            con1.Open();
            MySqlDataReader reader = cmd1.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    MySqlConnection con2 = new MySqlConnection(Form1.conString);
                    sessionUsername = reader.GetString("userUsername");
                    MySqlCommand cmd2 = new MySqlCommand("INSERT INTO login(loginDate, user_userUsername) VALUES (NOW(), @username)", con2);
                    cmd2.Parameters.AddWithValue("@username", sessionUsername);
                    try
                    {
                        con2.Open();
                        cmd2.ExecuteNonQuery();
                        con2.Close();
                        this.Close();
                        var form1 = new Form1();
                        form1.Show();
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("Error!" + e1, "An error has ocurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                ErrorLabel.Visible = true;
            }
            con1.Close();
        }

        private void usernameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(String.IsNullOrEmpty(UsernameTextBox.Text) || String.IsNullOrEmpty(PasswordTextBox.Text)))
            {
                LoginButton.Enabled = true;
            }
            else
            {
                LoginButton.Enabled = false;
            }
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(String.IsNullOrEmpty(UsernameTextBox.Text) || String.IsNullOrEmpty(PasswordTextBox.Text)))
            {
                LoginButton.Enabled = true;
            }
            else
            {
                LoginButton.Enabled = false;
            }
            if((int)e.KeyChar == 13)
            {
                LoginButton.PerformClick();
            }
        }
    }
}
