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
    public partial class Product : UserControl
    {
        MySqlConnection con = new MySqlConnection(Form1.conString);
        public Product()
        {
            InitializeComponent();
            loadBrands();
        }
        public void loadBrands()
        {
            BrandsListBox.Items.Clear();
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
        public void loadModels(int brandID)
        {
            ModelsListBox.Items.Clear();
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
                    ModelsListBox.Items.Add(model);
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

        public void loadProducts(int modelID)
        {
            ProductsListBox.Items.Clear();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM products WHERE productModel_productModelID = @modelID", con);
            cmd.Parameters.AddWithValue("@modelID", modelID);
            MySqlDataReader ler;
            ProductClass product;
            try
            {
                con.Open();
                ler = cmd.ExecuteReader();
                while (ler.Read())
                {
                    product = new ProductClass(ler.GetInt32("productID"), ler.GetString("productColor"), ler.GetDouble("productPrice"), ler.GetString("productStyleCode"), ler.GetString("productCondition"), modelID);
                    ProductsListBox.Items.Add(product);
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


        private void ModelsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadProducts(((ModelClass)ModelsListBox.SelectedItem).ModelID);
        }

        private void BrandsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadModels(((BrandClass)this.BrandsListBox.SelectedItem).Id);
            ProductsListBox.Items.Clear();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Visible = false;
            NewProduct new_P = new NewProduct();
            new_P.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Visible = false;
            EditProduct edit_P = new EditProduct(((BrandClass)BrandsListBox.SelectedItem).Id, ((BrandClass)BrandsListBox.SelectedItem).Name, ((ModelClass)ModelsListBox.SelectedItem).Name, ((ProductClass)ProductsListBox.SelectedItem).ProductID);
            edit_P.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ProductClass product= (ProductClass)this.ProductsListBox.SelectedItem;
            MySqlCommand cmd = new MySqlCommand("DELETE FROM products WHERE productID = @id", con);
            cmd.Parameters.AddWithValue("@id", product.ProductID);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product deleted with success!", "Success!", MessageBoxButtons.OK);
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("An error has ocurred, try again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(e.ToString());
            }
            finally
            {
                if (con.State.Equals(System.Data.ConnectionState.Open))
                    con.Close();
            }
            ModelClass model = (ModelClass)ModelsListBox.SelectedItem;
            loadProducts(model.ModelID);
        }

    }
}
