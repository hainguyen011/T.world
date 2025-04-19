namespace T.world.common
{
    partial class InputText
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
            this.InputText_value = new System.Windows.Forms.TextBox();
            this.InputText_title = new System.Windows.Forms.Label();
            this.InputText_message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputText_value
            // 
            this.InputText_value.Location = new System.Drawing.Point(3, 15);
            this.InputText_value.Multiline = true;
            this.InputText_value.Name = "InputText_value";
            this.InputText_value.Size = new System.Drawing.Size(448, 45);
            this.InputText_value.TabIndex = 0;
            // 
            // InputText_title
            // 
            this.InputText_title.AutoSize = true;
            this.InputText_title.Location = new System.Drawing.Point(3, -7);
            this.InputText_title.Name = "InputText_title";
            this.InputText_title.Size = new System.Drawing.Size(33, 16);
            this.InputText_title.TabIndex = 1;
            this.InputText_title.Text = "Title";
            // 
            // InputText_message
            // 
            this.InputText_message.AutoSize = true;
            this.InputText_message.BackColor = System.Drawing.Color.White;
            this.InputText_message.ForeColor = System.Drawing.Color.Red;
            this.InputText_message.Location = new System.Drawing.Point(384, 29);
            this.InputText_message.Name = "InputText_message";
            this.InputText_message.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.InputText_message.Size = new System.Drawing.Size(44, 16);
            this.InputText_message.TabIndex = 2;
            this.InputText_message.Text = "label2";
            this.InputText_message.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InputText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.InputText_message);
            this.Controls.Add(this.InputText_title);
            this.Controls.Add(this.InputText_value);
            this.Name = "InputText";
            this.Size = new System.Drawing.Size(454, 88);
            this.Load += new System.EventHandler(this.InputText_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputText_value;
        private System.Windows.Forms.Label InputText_title;
        private System.Windows.Forms.Label InputText_message;
    }
}
