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
    public partial class Model : UserControl
    {
        MySqlConnection con = new MySqlConnection(Form1.conString);
        public Model()
        {
            InitializeComponent();
            ActionLabel.Text = "New Model";
            ActionButton.Text = "Add Model";
            loadBrands();
        }

        public void loadBrands()
        {
            BrandsListBox.Items.Clear();
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
                    BrandsListBox.Items.Add(brand);
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

        public void newModel()
        {
            if (BrandComboBox.SelectedIndex > -1)
            {
                if (ModelIdTextBox.Text.Equals(""))
                {
                    ErrorLabel.ForeColor = Color.Red;
                    ErrorLabel.Text = "Insert a name for the brand!";
                    ErrorLabel.Visible = true;
                    return;
                }
                if (ModelNameTextBox.Text.Equals(""))
                {
                    ErrorLabel.ForeColor = Color.Red;
                    ErrorLabel.Text = "Insert a name for the brand!";
                    ErrorLabel.Visible = true;
                    return;
                }
                MySqlConnection con = new MySqlConnection(Form1.conString);
                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM productModel WHERE productModelID = @modelid", con);
                cmd1.Parameters.AddWithValue("@modelid", this.ModelIdTextBox.Text);

                con.Open();
                MySqlDataReader reader = cmd1.ExecuteReader();
                if (reader.HasRows)
                {
                    ErrorLabel.ForeColor = Color.Red;
                    ErrorLabel.Text = "A model with that ID already exists!";
                    ErrorLabel.Visible = true;
                    con.Close();
                }
                else
                {
                    con.Close();
                    MySqlCommand cmd2 = new MySqlCommand("INSERT INTO productModel(productModelID, productModelName, productBrand_productBrandID) VALUES (@modelid, @name, @brandid)", con);
                    cmd2.Parameters.AddWithValue("@modelid", this.ModelIdTextBox.Text);
                    cmd2.Parameters.AddWithValue("@name", this.ModelNameTextBox.Text);
                    cmd2.Parameters.AddWithValue("@brandid", ((BrandClass)this.BrandComboBox.SelectedItem).Id);
                    con.Open();
                    MessageBox.Show("yooo");
                    try
                    {
                        MessageBox.Show("yo");
                        cmd2.ExecuteNonQuery();
                        ErrorLabel.ForeColor = Color.Green;
                        ErrorLabel.Text = "New model created with success!";
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
                }
            }
            else
            {
                ErrorLabel.Text = "Select a brand first!";
            }
        }

        public void editModel()
        {
            if (BrandComboBox.SelectedIndex > -1)
            {
                if (ModelIdTextBox.Text.Equals(""))
                {
                    ErrorLabel.ForeColor = Color.Red;
                    ErrorLabel.Text = "Insert a name for the brand!";
                    ErrorLabel.Visible = true;
                    return;
                }
                if (ModelNameTextBox.Text.Equals(""))
                {
                    ErrorLabel.ForeColor = Color.Red;
                    ErrorLabel.Text = "Insert a name for the brand!";
                    ErrorLabel.Visible = true;
                    return;
                }
                con.Close();
                MySqlCommand cmd2 = new MySqlCommand("UPDATE productModel SET productModelName = @name, productBrand_productBrandID = @brandid WHERE productModelID = @modelid", con);
                cmd2.Parameters.AddWithValue("@modelid", this.ModelIdTextBox.Text);
                cmd2.Parameters.AddWithValue("@name", this.ModelNameTextBox.Text);
                cmd2.Parameters.AddWithValue("@brandid", ((BrandClass)this.BrandComboBox.SelectedItem).Id);
                try
                {
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    ErrorLabel.ForeColor = Color.Green;
                    ErrorLabel.Text = "Model edited with success!";
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
            }
            else
            {
                ErrorLabel.Text = "Select a brand first!";
            }
        }

        private void BrandsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadModels(((BrandClass)this.BrandsListBox.SelectedItem).Id);
        }

        private void ModelsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelClass model = (ModelClass)ModelsListBox.SelectedItem;
            ModelIdTextBox.Text = Convert.ToString(model.ModelID);
            ModelNameTextBox.Text = model.Name;
            BrandComboBox.SelectedItem = BrandsListBox.SelectedItem;
            ActionLabel.Text = "Edit Model";
            ActionButton.Text = "Edit";
            ModelIdTextBox.Enabled = false;
            DeleteButton.Enabled = true;
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            if (ActionLabel.Text.Equals("New Model"))
            {
                newModel();
            }
            else if (ActionLabel.Text.Equals("Edit Model"))
            {
                editModel();
            }
            loadModels(((BrandClass)this.BrandsListBox.SelectedItem).Id);
        }
        public void deleteModel()
        {
            ModelClass model = (ModelClass)this.ModelsListBox.SelectedItem;
            MySqlCommand cmd = new MySqlCommand("DELETE FROM productModel WHERE productModelID = @id", con);
            cmd.Parameters.AddWithValue("@id", model.ModelID);
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
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            deleteModel();
            loadModels(((BrandClass)this.BrandComboBox.SelectedItem).Id);
            ModelIdTextBox.Text = "";
            ModelNameTextBox.Text = "";
            BrandComboBox.SelectedIndex = 0;
        }

        private void ModelIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            ModelIdTextBox.Text = "";
            ModelNameTextBox.Text = "";
            BrandComboBox.SelectedIndex = 0;
            ActionLabel.Text = "New Model";
            ActionButton.Text = "New";
            ModelIdTextBox.Enabled = true;
            DeleteButton.Enabled = false;
        }

    }
}
