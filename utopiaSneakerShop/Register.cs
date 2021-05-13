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
            this.ActiveControl = pictureBox1;

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
            this.ConfirmPasswordTextBox.BorderStyle = BorderStyle.None;
            this.ConfirmPasswordTextBox.AutoSize = false;
            this.ConfirmPasswordTextBox.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });
            this.FirstNameTextBox.BorderStyle = BorderStyle.None;
            this.FirstNameTextBox.AutoSize = false;
            this.FirstNameTextBox.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });
            this.LastNameTextBox.BorderStyle = BorderStyle.None;
            this.LastNameTextBox.AutoSize = false;
            this.LastNameTextBox.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });
            this.NIFTextBox.BorderStyle = BorderStyle.None;
            this.NIFTextBox.AutoSize = false;
            this.NIFTextBox.Controls.Add(new Label()
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
            //Verificar se a password tem mais de 3 caracteres
            if (PasswordTextBox.TextLength < 3 && ConfirmPasswordTextBox.TextLength < 3)
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Passwords minimum length is 3 chars!";
                PasswordTextBox.Text = "";
                ConfirmPasswordTextBox.Text = "";
                PasswordTextBox.Focus();
                return;
            }
            //Verificar se as passwords sao iguais
            if (!PasswordTextBox.Text.Equals(ConfirmPasswordTextBox.Text))
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Passwords aren't equal!";
                PasswordTextBox.Text = "";
                ConfirmPasswordTextBox.Text = "";
                PasswordTextBox.Focus();
                return;
            }
            //Verificar se o NIF tem 9 caracteres
            if(NIFTextBox.TextLength != 9)
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Passwords aren't equal!";
                PasswordTextBox.Text = "";
                ConfirmPasswordTextBox.Text = "";
                PasswordTextBox.Focus();
                return;
            }

            //Verificar se já existe algum user com o username e email inserido
            MySqlConnection con = new MySqlConnection(Form1.conString);
            MySqlCommand cmd1 = new MySqlCommand("SELECT COUNT(*) FROM user WHERE userEmail=@email OR userUsername = @username", con);
            cmd1.Parameters.AddWithValue("@email", this.EmailTextBox.Text);
            cmd1.Parameters.AddWithValue("@username", this.UsernameTextBox.Text);

            con.Open();
            if (int.Parse(cmd1.ExecuteScalar().ToString()) > 0)
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Email or Username is already being used!";
                EmailTextBox.Text = "";
                UsernameTextBox.Focus();
                con.Close();
                return;
            }

            //Verificar se ja existe um user com o NIF inserido
            MySqlCommand cmd2 = new MySqlCommand("SELECT COUNT(*) FROM user WHERE userNIF = @nif", con);
            cmd2.Parameters.AddWithValue("@nif", this.NIFTextBox.Text);

            if (int.Parse(cmd2.ExecuteScalar().ToString()) > 0)
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "NIF is already being used!";
                NIFTextBox.Text = "";
                NIFTextBox.Focus();
                con.Close();
                return;
            }

            //Finalmente inserir o utilizador
            MySqlCommand cmd3 = new MySqlCommand("INSERT INTO user(userUsername, userPassword, userEmail, userName, userSurname, userNIF) " +
            "VALUES (@username, @password, @email, @firstname, @lastname, @nif)", con);
            cmd3.Parameters.AddWithValue("@username", this.UsernameTextBox.Text);
            cmd3.Parameters.AddWithValue("@password", this.PasswordTextBox.Text);
            cmd3.Parameters.AddWithValue("@email", this.EmailTextBox.Text);
            cmd3.Parameters.AddWithValue("@firstname", this.FirstNameTextBox.Text);
            cmd3.Parameters.AddWithValue("@lastname", this.LastNameTextBox.Text);
            cmd3.Parameters.AddWithValue("@nif", this.NIFTextBox.Text);
            try
            {
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Success!", "Registered with success!", MessageBoxButtons.OK);
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error!" + e1, "An error has ocurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            this.Close();
            var userLoginForm = new UserLoginForm();
            userLoginForm.Show();
        }

        private void UsernameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(String.IsNullOrEmpty(UsernameTextBox.Text) || String.IsNullOrEmpty(EmailTextBox.Text) || String.IsNullOrEmpty(PasswordTextBox.Text)
                || String.IsNullOrEmpty(ConfirmPasswordTextBox.Text) || String.IsNullOrEmpty(FirstNameTextBox.Text) || String.IsNullOrEmpty(LastNameTextBox.Text)
                || String.IsNullOrEmpty(NIFTextBox.Text)))
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
            if (!(String.IsNullOrEmpty(UsernameTextBox.Text) || String.IsNullOrEmpty(EmailTextBox.Text) || String.IsNullOrEmpty(PasswordTextBox.Text)
                || String.IsNullOrEmpty(ConfirmPasswordTextBox.Text) || String.IsNullOrEmpty(FirstNameTextBox.Text) || String.IsNullOrEmpty(LastNameTextBox.Text)
                || String.IsNullOrEmpty(NIFTextBox.Text)))
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
            if (!(String.IsNullOrEmpty(UsernameTextBox.Text) || String.IsNullOrEmpty(EmailTextBox.Text) || String.IsNullOrEmpty(PasswordTextBox.Text)
                || String.IsNullOrEmpty(ConfirmPasswordTextBox.Text) || String.IsNullOrEmpty(FirstNameTextBox.Text) || String.IsNullOrEmpty(LastNameTextBox.Text)
                || String.IsNullOrEmpty(NIFTextBox.Text)))
            {
                RegisterButton.Enabled = true;
            }
            else
            {
                RegisterButton.Enabled = false;
            }
        }

        private void ConfirmPasswordTextBox_KeyPress(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(UsernameTextBox.Text) || String.IsNullOrEmpty(EmailTextBox.Text) || String.IsNullOrEmpty(PasswordTextBox.Text)
                || String.IsNullOrEmpty(ConfirmPasswordTextBox.Text) || String.IsNullOrEmpty(FirstNameTextBox.Text) || String.IsNullOrEmpty(LastNameTextBox.Text)
                || String.IsNullOrEmpty(NIFTextBox.Text)))
            {
                RegisterButton.Enabled = true;
            }
            else
            {
                RegisterButton.Enabled = false;
            }
        }

        private void FirstNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(String.IsNullOrEmpty(UsernameTextBox.Text) || String.IsNullOrEmpty(EmailTextBox.Text) || String.IsNullOrEmpty(PasswordTextBox.Text)
                || String.IsNullOrEmpty(ConfirmPasswordTextBox.Text) || String.IsNullOrEmpty(FirstNameTextBox.Text) || String.IsNullOrEmpty(LastNameTextBox.Text)
                || String.IsNullOrEmpty(NIFTextBox.Text)))
            {
                RegisterButton.Enabled = true;
            }
            else
            {
                RegisterButton.Enabled = false;
            }
        }

        private void LastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(String.IsNullOrEmpty(UsernameTextBox.Text) || String.IsNullOrEmpty(EmailTextBox.Text) || String.IsNullOrEmpty(PasswordTextBox.Text)
                || String.IsNullOrEmpty(ConfirmPasswordTextBox.Text) || String.IsNullOrEmpty(FirstNameTextBox.Text) || String.IsNullOrEmpty(LastNameTextBox.Text)
                || String.IsNullOrEmpty(NIFTextBox.Text)))
            {
                RegisterButton.Enabled = true;
            }
            else
            {
                RegisterButton.Enabled = false;
            }
        }

        private void NIFTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (!(String.IsNullOrEmpty(UsernameTextBox.Text) || String.IsNullOrEmpty(EmailTextBox.Text) || String.IsNullOrEmpty(PasswordTextBox.Text)
                || String.IsNullOrEmpty(ConfirmPasswordTextBox.Text) || String.IsNullOrEmpty(FirstNameTextBox.Text) || String.IsNullOrEmpty(LastNameTextBox.Text)
                || String.IsNullOrEmpty(NIFTextBox.Text)))
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
