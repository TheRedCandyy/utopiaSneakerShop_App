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
    public partial class EditProduct : Form
    {
        MySqlConnection con = new MySqlConnection(Form1.conString);
        int prodID;
        public EditProduct(int brandID, string brandName, string modelName, int productID)
        {
            InitializeComponent();
            loadBrands();
            loadModels(brandID);
            loadProduct(productID);
            prodID = productID;
            for (int i = 0; i < BrandComboBox.Items.Count; i++)
            {
                if (BrandComboBox.Items[i].ToString() == brandName)
                {
                    BrandComboBox.SelectedIndex = i;
                }
            }
            BrandComboBox.SelectedItem = brandName;
            for (int i = 0; i < ModelComboBox.Items.Count; i++)
            {
                if (ModelComboBox.Items[i].ToString() == modelName)
                {
                    ModelComboBox.SelectedIndex = i;
                }
            }
        }

        public void loadBrands()
        {
            BrandComboBox.Items.Clear();
            BrandClass brand;
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM productBrand", con);
            MySqlDataReader ler;
            try
            {
                con.Open();
                ler = cmd.ExecuteReader();
                while (ler.Read())
                {
                    brand = new BrandClass(ler.GetString("productBrandName"), ler.GetInt32("productBrandID"));
                    BrandComboBox.Items.Add(brand);
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
        public void loadModels(int brandID)
        {
            ModelComboBox.Items.Clear();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM productModel WHERE productBrand_productBrandID = @brandID", con);
            cmd.Parameters.AddWithValue("@brandID", brandID);
            MySqlDataReader ler;
            ModelClass model;
            try
            {
                con.Open();
                ler = cmd.ExecuteReader();
                while (ler.Read())
                {
                    model = new ModelClass(ler.GetInt32("productModelID"), ler.GetString("productModelName"), ler.GetInt32("productBrand_productBrandID"));
                    ModelComboBox.Items.Add(model);
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
        public void loadProduct(int productID)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM products WHERE productID = @productID", con);
            cmd.Parameters.AddWithValue("@productID", productID);
            MySqlDataReader ler;
            try
            {
                con.Open();
                ler = cmd.ExecuteReader();
                while (ler.Read())
                {
                    for (int i = 0; i < ModelComboBox.Items.Count; i++)
                    {
                        if (ModelComboBox.Items[i].Equals(ler.GetInt32("productModel_productModelID"))){
                            ModelComboBox.SelectedIndex = i;
                        }
                    }
                    ColorTextBox.Text = ler.GetString("productColor");
                    PriceTextBox.Text = ler.GetFloat("productPrice").ToString();
                    StyleCodeTextBox.Text = ler.GetString("productStyleCode");
                    for (int i = 0; i < ConditionComboBox.Items.Count; i++)
                    {
                        if (ConditionComboBox.Items[i].Equals(ler.GetString("productCondition")))
                        {
                            ConditionComboBox.SelectedIndex = i;
                        }
                    }
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

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 mainForm = new Form1();
            mainForm.Visible = true;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (BrandComboBox.SelectedIndex == -1)
            {
                ErrorLabel.Visible = true;
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Text = "Select a brand!";
                return;
            }

            if (ModelComboBox.SelectedIndex == -1)
            {
                ErrorLabel.Visible = true;
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Text = "Select a model!";
                return;
            }
            if (ConditionComboBox.SelectedIndex == -1)
            {
                ErrorLabel.Visible = true;
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Text = "Select a condition!";
                return;
            }
            if (ColorTextBox.Text.Equals(""))
            {
                ErrorLabel.Visible = true;
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Text = "Insert a color!";
                return;
            }
            if (PriceTextBox.Text.Equals(""))
            {
                ErrorLabel.Visible = true;
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Text = "Insert a price!";
                return;
            }
            if (StyleCodeTextBox.Text.Equals(""))
            {
                ErrorLabel.Visible = true;
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Text = "Insert a Style Code!";
                return;
            }
            string condition = "";
            switch (ConditionComboBox.SelectedIndex)
            {
                case 0:
                    condition = "Brand New";
                    break;
                case 1:
                    condition = "Good";
                    break;
                case 2:
                    condition = "Average";
                    break;
                case 3:
                    condition = "Very Used";
                    break;
                case 4:
                    condition = "Bad";
                    break;
                default:
                    condition = "Brand New";
                    break;
            }

            MySqlCommand cmd = new MySqlCommand("UPDATE products SET productColor = @color, productPrice = @price, productStyleCode = @stylecode, productCondition = @condition, " +
                                                "productModel_productModelID = @modelID WHERE productID = @productID", con);
            cmd.Parameters.AddWithValue("@color", this.ColorTextBox.Text);
            cmd.Parameters.AddWithValue("@price", this.PriceTextBox.Text);
            cmd.Parameters.AddWithValue("@stylecode", this.StyleCodeTextBox.Text);
            cmd.Parameters.AddWithValue("@condition", condition);
            cmd.Parameters.AddWithValue("@modelID", ((ModelClass)this.ModelComboBox.SelectedItem).ModelID);
            cmd.Parameters.AddWithValue("@productID", prodID);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                ErrorLabel.ForeColor = Color.Green;
                ErrorLabel.Text = "Product edited with success!";
                ErrorLabel.Visible = true;
                con.Close();
            }
            catch (Exception e1)
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
        }
    }
}
