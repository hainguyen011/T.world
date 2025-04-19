namespace T.world
{
    partial class Register
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
            this.Register_button = new System.Windows.Forms.Button();
            this.register_form = new System.Windows.Forms.Panel();
            this.register_form.SuspendLayout();
            this.SuspendLayout();
            // 
            // Register_button
            // 
            this.Register_button.Location = new System.Drawing.Point(30, 393);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(1080, 44);
            this.Register_button.TabIndex = 11;
            this.Register_button.Text = "Đăng kí";
            this.Register_button.UseVisualStyleBackColor = true;
            this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // register_form
            // 
            this.register_form.Controls.Add(this.Register_button);
            this.register_form.Location = new System.Drawing.Point(12, 23);
            this.register_form.Name = "register_form";
            this.register_form.Size = new System.Drawing.Size(1138, 480);
            this.register_form.TabIndex = 18;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 525);
            this.Controls.Add(this.register_form);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.register_form.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Register_button;
        private System.Windows.Forms.Panel register_form;
    }
}