
namespace utopiaSneakerShop
{
    partial class Brand
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
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.ActionButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BrandNameTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BrandsListBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NewButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActionLabel
            // 
            this.ActionLabel.AutoSize = true;
            this.ActionLabel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionLabel.Location = new System.Drawing.Point(59, 20);
            this.ActionLabel.Name = "ActionLabel";
            this.ActionLabel.Size = new System.Drawing.Size(144, 25);
            this.ActionLabel.TabIndex = 71;
            this.ActionLabel.Text = "Action Label";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F);
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(62, 147);
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
            this.ActionButton.Location = new System.Drawing.Point(96, 191);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(107, 31);
            this.ActionButton.TabIndex = 69;
            this.ActionButton.Text = "Action Button";
            this.ActionButton.UseVisualStyleBackColor = false;
            this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 62;
            this.label2.Text = "Name";
            // 
            // BrandNameTextBox
            // 
            this.BrandNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(219)))), ((int)(((byte)(192)))));
            this.BrandNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BrandNameTextBox.Font = new System.Drawing.Font("JetBrains Mono", 11.25F);
            this.BrandNameTextBox.Location = new System.Drawing.Point(64, 103);
            this.BrandNameTextBox.Name = "BrandNameTextBox";
            this.BrandNameTextBox.Size = new System.Drawing.Size(162, 27);
            this.BrandNameTextBox.TabIndex = 55;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BrandsListBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 364);
            this.panel1.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 72;
            this.label1.Text = "List of Brands";
            // 
            // BrandsListBox
            // 
            this.BrandsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(219)))), ((int)(((byte)(192)))));
            this.BrandsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BrandsListBox.Font = new System.Drawing.Font("JetBrains Mono", 11.25F);
            this.BrandsListBox.FormattingEnabled = true;
            this.BrandsListBox.ItemHeight = 19;
            this.BrandsListBox.Location = new System.Drawing.Point(23, 59);
            this.BrandsListBox.Name = "BrandsListBox";
            this.BrandsListBox.Size = new System.Drawing.Size(278, 285);
            this.BrandsListBox.TabIndex = 74;
            this.BrandsListBox.SelectedIndexChanged += new System.EventHandler(this.BrandsListBox_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ActionLabel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BrandNameTextBox);
            this.panel2.Controls.Add(this.ErrorLabel);
            this.panel2.Controls.Add(this.ActionButton);
            this.panel2.Location = new System.Drawing.Point(542, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 364);
            this.panel2.TabIndex = 73;
            // 
            // NewButton
            // 
            this.NewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.NewButton.FlatAppearance.BorderSize = 0;
            this.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewButton.Font = new System.Drawing.Font("JetBrains Mono", 11.25F);
            this.NewButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NewButton.Location = new System.Drawing.Point(374, 130);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(107, 31);
            this.NewButton.TabIndex = 72;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = false;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.DeleteButton.Enabled = false;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("JetBrains Mono", 11.25F);
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteButton.Location = new System.Drawing.Point(374, 186);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(107, 31);
            this.DeleteButton.TabIndex = 75;
            this.DeleteButton.Text = "Delete Brand";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Brand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(219)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Brand";
            this.Size = new System.Drawing.Size(864, 364);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ActionLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button ActionButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BrandNameTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox BrandsListBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label1;
    }
}
