using MySql.Data.MySqlClient;
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
    public partial class NewAdmin : UserControl
    {
        public NewAdmin()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;
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
            if (NIFTextBox.TextLength != 9)
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
            MySqlCommand cmd3 = new MySqlCommand("INSERT INTO user(userUsername, userPassword, userEmail, userName, userSurname, userNIF, userType) " +
            "VALUES (@username, @password, @email, @firstname, @lastname, @nif, 1)", con);
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
            var msgbox = MessageBox.Show("Created a new administrator with sucess!", "New Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UsernameTextBox.Text = "";
            EmailTextBox.Text = "";
            PasswordTextBox.Text = "";
            ConfirmPasswordTextBox.Text = "";
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            NIFTextBox.Text = "";
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
