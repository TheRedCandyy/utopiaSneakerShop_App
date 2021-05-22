
namespace utopiaSneakerShop
{
    partial class Model
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
            this.ActionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ModelNameTextBox = new System.Windows.Forms.TextBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.ActionButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ModelsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BrandsListBox = new System.Windows.Forms.ListBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.ModelIdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BrandComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActionLabel
            // 
            this.ActionLabel.AutoSize = true;
            this.ActionLabel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionLabel.Location = new System.Drawing.Point(38, 20);
            this.ActionLabel.Name = "ActionLabel";
            this.ActionLabel.Size = new System.Drawing.Size(144, 25);
            this.ActionLabel.TabIndex = 71;
            this.ActionLabel.Text = "Action Label";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 62;
            this.label2.Text = "Name";
            // 
            // ModelNameTextBox
            // 
            this.ModelNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(219)))), ((int)(((byte)(192)))));
            this.ModelNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModelNameTextBox.Font = new System.Drawing.Font("JetBrains Mono", 11.25F);
            this.ModelNameTextBox.Location = new System.Drawing.Point(43, 157);
            this.ModelNameTextBox.Name = "ModelNameTextBox";
            this.ModelNameTextBox.Size = new System.Drawing.Size(198, 27);
            this.ModelNameTextBox.TabIndex = 75;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F);
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(42, 262);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(42, 14);
            this.ErrorLabel.TabIndex = 70;
            this.ErrorLabel.Text = "Error";
            this.ErrorLabel.Visible = false;
            // 
            // ActionButton
            // 
            this.ActionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.ActionButton.FlatAppearance.BorderSize = 0;
            this.ActionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActionButton.Font = new System.Drawing.Font("JetBrains Mono", 11.25F);
            this.ActionButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ActionButton.Location = new System.Drawing.Point(85, 288);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(107, 31);
            this.ActionButton.TabIndex = 69;
            this.ActionButton.Text = "Action Button";
            this.ActionButton.UseVisualStyleBackColor = false;
            this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ModelsListBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BrandsListBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 364);
            this.panel1.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 76;
            this.label3.Text = "List of Brands";
            // 
            // ModelsListBox
            // 
            this.ModelsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(219)))), ((int)(((byte)(192)))));
            this.ModelsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ModelsListBox.Font = new System.Drawing.Font("JetBrains Mono", 11.25F);
            this.ModelsListBox.FormattingEnabled = true;
            this.ModelsListBox.ItemHeight = 19;
            this.ModelsListBox.Location = new System.Drawing.Point(208, 58);
            this.ModelsListBox.Name = "ModelsListBox";
            this.ModelsListBox.Size = new System.Drawing.Size(235, 285);
            this.ModelsListBox.TabIndex = 75;
            this.ModelsListBox.SelectedIndexChanged += new System.EventHandler(this.ModelsListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 72;
            this.label1.Text = "List of Models";
            // 
            // BrandsListBox
            // 
            this.BrandsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(219)))), ((int)(((byte)(192)))));
            this.BrandsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BrandsListBox.Font = new System.Drawing.Font("JetBrains Mono", 11.25F);
            this.BrandsListBox.FormattingEnabled = true;
            this.BrandsListBox.ItemHeight = 19;
            this.BrandsListBox.Location = new System.Drawing.Point(23, 58);
            this.BrandsListBox.Name = "BrandsListBox";
            this.BrandsListBox.Size = new System.Drawing.Size(179, 285);
            this.BrandsListBox.TabIndex = 74;
            this.BrandsListBox.SelectedIndexChanged += new System.EventHandler(this.BrandsListBox_SelectedIndexChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.DeleteButton.Enabled = false;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("JetBrains Mono", 11.25F);
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteButton.Location = new System.Drawing.Point(475, 179);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(107, 31);
            this.DeleteButton.TabIndex = 79;
            this.DeleteButton.Text = "Delete Brand";
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
            this.NewButton.Location = new System.Drawing.Point(475, 123);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(107, 31);
            this.NewButton.TabIndex = 77;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = false;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.ModelIdTextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.BrandComboBox);
            this.panel2.Controls.Add(this.ActionLabel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ModelNameTextBox);
            this.panel2.Controls.Add(this.ErrorLabel);
            this.panel2.Controls.Add(this.ActionButton);
            this.panel2.Location = new System.Drawing.Point(588, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 364);
            this.panel2.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 75;
            this.label5.Text = "Model ID";
            // 
            // ModelIdTextBox
            // 
            this.ModelIdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(219)))), ((int)(((byte)(192)))));
            this.ModelIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModelIdTextBox.Font = new System.Drawing.Font("JetBrains Mono", 11.25F);
            this.ModelIdTextBox.Location = new System.Drawing.Point(43, 101);
            this.ModelIdTextBox.Name = "ModelIdTextBox";
            this.ModelIdTextBox.Size = new System.Drawing.Size(198, 27);
            this.ModelIdTextBox.TabIndex = 74;
            this.ModelIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModelIdTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 73;
            this.label4.Text = "Brand";
            // 
            // BrandComboBox
            // 
            this.BrandComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(219)))), ((int)(((byte)(192)))));
            this.BrandComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BrandComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrandComboBox.Font = new System.Drawing.Font("JetBrains Mono", 11.25F);
            this.BrandComboBox.FormattingEnabled = true;
            this.BrandComboBox.Location = new System.Drawing.Point(41, 213);
            this.BrandComboBox.Name = "BrandComboBox";
            this.BrandComboBox.Size = new System.Drawing.Size(198, 27);
            this.BrandComboBox.TabIndex = 72;
            // 
            // Model
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(219)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.panel2);
            this.Name = "Model";
            this.Size = new System.Drawing.Size(864, 364);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ActionLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ModelNameTextBox;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button ActionButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ModelsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox BrandsListBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox BrandComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ModelIdTextBox;
    }
}
