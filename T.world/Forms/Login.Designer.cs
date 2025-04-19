namespace T.world
{
    partial class Login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Login_title = new System.Windows.Forms.Label();
            this.Login_button = new System.Windows.Forms.Button();
            this.Register_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(107, 116);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(406, 36);
            this.txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(107, 174);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(406, 36);
            this.txtPassword.TabIndex = 1;
            // 
            // Login_title
            // 
            this.Login_title.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_title.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Login_title.Location = new System.Drawing.Point(172, 68);
            this.Login_title.Name = "Login_title";
            this.Login_title.Size = new System.Drawing.Size(194, 46);
            this.Login_title.TabIndex = 2;
            this.Login_title.Text = "Đăng nhập";
            this.Login_title.Click += new System.EventHandler(this.Login_title_Click);
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.Login_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Login_button.Location = new System.Drawing.Point(293, 254);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(220, 35);
            this.Login_button.TabIndex = 3;
            this.Login_button.Text = "Đăng nhập";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_Clicked);
            // 
            // Register_button
            // 
            this.Register_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.Register_button.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Register_button.Location = new System.Drawing.Point(107, 254);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(114, 35);
            this.Register_button.TabIndex = 4;
            this.Register_button.Text = "Đăng kí";
            this.Register_button.UseVisualStyleBackColor = false;
            this.Register_button.Click += new System.EventHandler(this.Register_Clicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(37, 174);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Register_button);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Login_title);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label Login_title;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Button Register_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}