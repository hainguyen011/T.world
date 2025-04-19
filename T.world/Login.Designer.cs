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
            this.email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.Login_title = new System.Windows.Forms.Label();
            this.Login_button = new System.Windows.Forms.Button();
            this.Register_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(25, 130);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(406, 22);
            this.email.TabIndex = 0;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(25, 168);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(406, 22);
            this.password.TabIndex = 1;
            // 
            // Login_title
            // 
            this.Login_title.AutoSize = true;
            this.Login_title.Location = new System.Drawing.Point(22, 76);
            this.Login_title.Name = "Login_title";
            this.Login_title.Size = new System.Drawing.Size(72, 16);
            this.Login_title.TabIndex = 2;
            this.Login_title.Text = "Đăng nhập";
            // 
            // Login_button
            // 
            this.Login_button.Location = new System.Drawing.Point(211, 232);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(220, 35);
            this.Login_button.TabIndex = 3;
            this.Login_button.Text = "Đăng nhập";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_Clicked);
            // 
            // Register_button
            // 
            this.Register_button.Location = new System.Drawing.Point(19, 232);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(114, 35);
            this.Register_button.TabIndex = 4;
            this.Register_button.Text = "Đăng kí";
            this.Register_button.UseVisualStyleBackColor = true;
            this.Register_button.Click += new System.EventHandler(this.Register_Clicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hoặc";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Register_button);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Login_title);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label Login_title;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Button Register_button;
        private System.Windows.Forms.Label label2;
    }
}