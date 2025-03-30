namespace T.world
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbMenu = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbMenu);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 63);
            this.panel1.TabIndex = 0;
            // 
            // cmbMenu
            // 
            this.cmbMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbMenu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMenu.DropDownWidth = 100;
            this.cmbMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMenu.FormattingEnabled = true;
            this.cmbMenu.IntegralHeight = false;
            this.cmbMenu.Items.AddRange(new object[] {
            "Laptop",
            "Điện thoại",
            "Tai nghe",
            "Phụ kiện",
            "Gaming Gear",
            "Smartwatch"});
            this.cmbMenu.Location = new System.Drawing.Point(3, 29);
            this.cmbMenu.Name = "cmbMenu";
            this.cmbMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbMenu.Size = new System.Drawing.Size(46, 21);
            this.cmbMenu.TabIndex = 0;
            this.cmbMenu.TabStop = false;
            this.cmbMenu.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbxMenu_DrawItem);
            this.cmbMenu.SelectedIndexChanged += new System.EventHandler(this.cbxMenu_MouseLeave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(270, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 29);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(64, 27);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(46, 29);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 29);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "TechGear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Location = new System.Drawing.Point(610, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 48);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 671);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1386, 109);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMenu);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1386, 608);
            this.panel4.TabIndex = 3;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 780);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbMenu;
        private System.Windows.Forms.Button btnMenu;
    }
}

