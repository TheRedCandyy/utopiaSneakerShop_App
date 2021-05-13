
namespace utopiaSneakerShop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MinimizeButton = new System.Windows.Forms.PictureBox();
            this.QuitButton = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SneakersButton = new System.Windows.Forms.Button();
            this.ClothingButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::utopiaSneakerShop.Properties.Resources.logo_website;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.Image = global::utopiaSneakerShop.Properties.Resources.minimize_icon1;
            this.MinimizeButton.Location = new System.Drawing.Point(799, -1);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(30, 30);
            this.MinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuitButton.Image = global::utopiaSneakerShop.Properties.Resources.quit_icon;
            this.QuitButton.Location = new System.Drawing.Point(834, -1);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(30, 30);
            this.QuitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QuitButton.TabIndex = 3;
            this.QuitButton.TabStop = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 394);
            this.panel1.TabIndex = 4;
            // 
            // SneakersButton
            // 
            this.SneakersButton.BackColor = System.Drawing.Color.Transparent;
            this.SneakersButton.FlatAppearance.BorderSize = 0;
            this.SneakersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.SneakersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SneakersButton.Font = new System.Drawing.Font("JetBrains Mono", 11.25F);
            this.SneakersButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SneakersButton.Location = new System.Drawing.Point(157, -1);
            this.SneakersButton.Name = "SneakersButton";
            this.SneakersButton.Size = new System.Drawing.Size(97, 67);
            this.SneakersButton.TabIndex = 5;
            this.SneakersButton.Text = "Sneakers";
            this.SneakersButton.UseVisualStyleBackColor = false;
            this.SneakersButton.Click += new System.EventHandler(this.SneakersButton_Click);
            this.SneakersButton.MouseEnter += new System.EventHandler(this.SneakersButton_MouseEnter);
            this.SneakersButton.MouseLeave += new System.EventHandler(this.SneakersButton_MouseLeave);
            // 
            // ClothingButton
            // 
            this.ClothingButton.BackColor = System.Drawing.Color.Transparent;
            this.ClothingButton.FlatAppearance.BorderSize = 0;
            this.ClothingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.ClothingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClothingButton.Font = new System.Drawing.Font("JetBrains Mono", 11.25F);
            this.ClothingButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClothingButton.Location = new System.Drawing.Point(259, -1);
            this.ClothingButton.Name = "ClothingButton";
            this.ClothingButton.Size = new System.Drawing.Size(97, 67);
            this.ClothingButton.TabIndex = 6;
            this.ClothingButton.Text = "Clothing";
            this.ClothingButton.UseVisualStyleBackColor = false;
            this.ClothingButton.Click += new System.EventHandler(this.ClothingButton_Click);
            this.ClothingButton.MouseEnter += new System.EventHandler(this.ClothingButton_MouseEnter);
            this.ClothingButton.MouseLeave += new System.EventHandler(this.ClothingButton_MouseLeave);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("JetBrains Mono", 11.25F);
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoginButton.Location = new System.Drawing.Point(729, -1);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(65, 30);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            this.LoginButton.MouseEnter += new System.EventHandler(this.LoginButton_MouseEnter);
            this.LoginButton.MouseLeave += new System.EventHandler(this.LoginButton_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(219)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(864, 465);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.ClothingButton);
            this.Controls.Add(this.SneakersButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utopia SneakerShop";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuitButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox QuitButton;
        private System.Windows.Forms.PictureBox MinimizeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SneakersButton;
        private System.Windows.Forms.Button ClothingButton;
        private System.Windows.Forms.Button LoginButton;
    }
}

