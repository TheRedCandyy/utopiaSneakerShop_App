
namespace utopiaSneakerShop
{
    partial class Product
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DeleteButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ModelsListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BrandsListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("JetBrains Mono", 11.25F);
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteButton.Location = new System.Drawing.Point(728, 212);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(133, 31);
            this.DeleteButton.TabIndex = 83;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.NewButton.FlatAppearance.BorderSize = 0;
            this.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewButton.Font = new System.Drawing.Font("JetBrains Mono", 11.25F);
            this.NewButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NewButton.Location = new System.Drawing.Point(728, 109);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(133, 31);
            this.NewButton.TabIndex = 81;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = false;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(222, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 76;
            this.label3.Text = "List of Models";
            // 
            // ProductsListBox
            // 
            this.ProductsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(219)))), ((int)(((byte)(192)))));
            this.ProductsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductsListBox.Font = new System.Drawing.Font("JetBrains Mono", 11.25F);
            this.ProductsListBox.FormattingEnabled = true;
            this.ProductsListBox.ItemHeight = 19;
            this.ProductsListBox.Location = new System.Drawing.Point(484, 58);
            this.ProductsListBox.Name = "ProductsListBox";
            this.ProductsListBox.Size = new System.Drawing.Size(235, 285);
            this.ProductsListBox.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 72;
            this.label1.Text = "List of Products";
            // 
            // ModelsListBox
            // 
            this.ModelsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(219)))), ((int)(((byte)(192)))));
            this.ModelsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ModelsListBox.Font = new System.Drawing.Font("JetBrains Mono", 11.25F);
            this.ModelsListBox.FormattingEnabled = true;
            this.ModelsListBox.ItemHeight = 19;
            this.ModelsListBox.Location = new System.Drawing.Point(227, 58);
            this.ModelsListBox.Name = "ModelsListBox";
            this.ModelsListBox.Size = new System.Drawing.Size(251, 285);
            this.ModelsListBox.TabIndex = 74;
            this.ModelsListBox.SelectedIndexChanged += new System.EventHandler(this.ModelsListBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BrandsListBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ProductsListBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ModelsListBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 364);
            this.panel1.TabIndex = 80;
            // 
            // BrandsListBox
            // 
            this.BrandsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(219)))), ((int)(((byte)(192)))));
            this.BrandsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BrandsListBox.Font = new System.Drawing.Font("JetBrains Mono", 11.25F);
            this.BrandsListBox.FormattingEnabled = true;
            this.BrandsListBox.ItemHeight = 19;
            this.BrandsListBox.Location = new System.Drawing.Point(18, 58);
            this.BrandsListBox.Name = "BrandsListBox";
            this.BrandsListBox.Size = new System.Drawing.Size(203, 285);
            this.BrandsListBox.TabIndex = 78;
            this.BrandsListBox.SelectedIndexChanged += new System.EventHandler(this.BrandsListBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 25);
            this.label6.TabIndex = 77;
            this.label6.Text = "List of Brands";
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("JetBrains Mono", 11.25F);
            this.EditButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditButton.Location = new System.Drawing.Point(728, 161);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(133, 31);
            this.EditButton.TabIndex = 84;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(219)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.panel1);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(864, 364);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ProductsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ModelsListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox BrandsListBox;
        private System.Windows.Forms.Button EditButton;
    }
}
