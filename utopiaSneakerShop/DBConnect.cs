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
    public partial class DBConnect : Form
    {
        public DBConnect()
        {
            InitializeComponent();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            Form1.conString = "server="+IPTextBox.Text+";port="+PortTextBox.Text+";user id="+UserTextBox.Text+";database="+DatabaseTextBox.Text+";Password="+PasswordTextBox.Text;
            MySqlConnection con = new MySqlConnection(Form1.conString);
            try
            {
                con.Open();
                MessageBox.Show("Success!");
                con.Close();
                this.Close();
            }
            catch (MySqlException e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                if (con.State.Equals(ConnectionState.Open))
                {
                    con.Close();
                }
            }
        }
    }
}
