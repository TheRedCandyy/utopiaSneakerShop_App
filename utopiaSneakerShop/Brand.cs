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
    public partial class Brand : UserControl
    {
        MySqlConnection con = new MySqlConnection(Form1.conString);
        public Brand()
        {
            InitializeComponent();
            ActionLabel.Text = "New Brand";
            ActionButton.Text = "Add Brand";
            loadBrands();
        }

        private void BrandsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteButton.Enabled = true;
            BrandNameTextBox.Text = BrandsListBox.SelectedItem.ToString();
            ActionLabel.Text = "Edit Brand";
            ActionButton.Text = "Edit";
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            if (ActionLabel.Text.Equals("New Brand"))
            {
                newBrand();
            }
            else if(ActionLabel.Text.Equals("Edit Brand"))
            {
                editBrand();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            deleteBrand();
        }

        public void loadBrands()
        {
            BrandsListBox.Items.Clear();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM productBrand", con);
            MySqlDataReader ler;
            BrandClass brand;
            try
            {
                con.Open();
                ler = cmd.ExecuteReader();
                while (ler.Read())
                {
                    brand = new BrandClass(ler.GetString("productBrandName"), ler.GetInt32("productBrandID"));
                    BrandsListBox.Items.Add(brand);
                }
                con.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (con.State.Equals(System.Data.ConnectionState.Open))
                    con.Close();
            }

        }

        public void newBrand()
        {
            if (BrandNameTextBox.Text.Equals(""))
            {
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Text = "Insert a name for the brand!";
                return;
            }
            MySqlCommand cmd = new MySqlCommand("INSERT INTO productBrand(productBrandName) VALUES (@name)", con);
            cmd.Parameters.AddWithValue("@name", this.BrandNameTextBox.Text);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                ErrorLabel.ForeColor = Color.Green;
                ErrorLabel.Text = "New brand created with success!";
                ErrorLabel.Visible = true;
                con.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Text = "An error has ocurred, try again!";
                ErrorLabel.Visible = true;
            }
            finally
            {
                if (con.State.Equals(System.Data.ConnectionState.Open))
                    con.Close();
            }
            loadBrands();
        }
        public void editBrand()
        {
            if (BrandNameTextBox.Text.Equals(""))
            {
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Text = "Insert a name for the brand!";
                return;
            }
            BrandClass brand = (BrandClass)this.BrandsListBox.SelectedItem;
            MySqlCommand cmd = new MySqlCommand("UPDATE productBrand SET productBrandName = @name WHERE productBrandID = @id", con);
            cmd.Parameters.AddWithValue("@name", this.BrandNameTextBox.Text);
            cmd.Parameters.AddWithValue("@id", brand.Id);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                ErrorLabel.ForeColor = Color.Green;
                ErrorLabel.Text = "Brand edited with success!";
                ErrorLabel.Visible = true;
                con.Close();
            }
            catch (Exception)
            {
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Text = "An error has ocurred, try again!";
                ErrorLabel.Visible = true;
            }
            finally
            {
                if (con.State.Equals(System.Data.ConnectionState.Open))
                    con.Close();
            }
            loadBrands();
        }
        public void deleteBrand()
        {
            BrandClass brand = (BrandClass)this.BrandsListBox.SelectedItem;
            MySqlCommand cmd = new MySqlCommand("DELETE FROM productBrand WHERE productBrandID = @id", con);
            cmd.Parameters.AddWithValue("@id", brand.Id);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                ErrorLabel.ForeColor = Color.Green;
                ErrorLabel.Text = "Brand deleted with success!";
                ErrorLabel.Visible = true;
                con.Close();
            }
            catch (Exception e)
            {
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Text = "An error has ocurred, try again!";
                ErrorLabel.Visible = true;
                MessageBox.Show(e.ToString());
            }
            finally
            {
                if (con.State.Equals(System.Data.ConnectionState.Open))
                    con.Close();
            }
            loadBrands();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            ActionLabel.Text = "New Brand";
            ActionButton.Text = "Add Brand";
            BrandNameTextBox.Text = "";
        }
    }
}
