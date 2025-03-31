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
            this.cbxAll = new System.Windows.Forms.ComboBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbxGames = new System.Windows.Forms.ComboBox();
            this.btnGameList = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.cbxAll);
            this.panel1.Controls.Add(this.btnAll);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1848, 78);
            this.panel1.TabIndex = 0;
            // 
            // cbxAll
            // 
            this.cbxAll.DropDownWidth = 120;
            this.cbxAll.FormattingEnabled = true;
            this.cbxAll.IntegralHeight = false;
            this.cbxAll.ItemHeight = 16;
            this.cbxAll.Items.AddRange(new object[] {
            "Sales",
            "Games",
            "PC",
            "APPLE",
            "SURFACE",
            "SỬA CHỮA",
            "LEGO",
            "MÁY Game Cũ"});
            this.cbxAll.Location = new System.Drawing.Point(12, 38);
            this.cbxAll.Name = "cbxAll";
            this.cbxAll.Size = new System.Drawing.Size(88, 24);
            this.cbxAll.TabIndex = 1;
            this.cbxAll.Visible = false;
            this.cbxAll.MouseLeave += new System.EventHandler(this.cbxAllList_MouseLeave);
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAll.Location = new System.Drawing.Point(12, 26);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(57, 35);
            this.btnAll.TabIndex = 1;
            this.btnAll.Text = "ALL";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.MouseEnter += new System.EventHandler(this.btnALLList_MouseEnter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(360, 26);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 36);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearch.Location = new System.Drawing.Point(63, 26);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 35);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Nhập từ khóa sản phẩm cần tìm kiếm";
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.BackColor = System.Drawing.Color.DarkGray;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(813, 25);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(215, 44);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "TechGear";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Location = new System.Drawing.Point(813, 177);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 59);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 826);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1848, 134);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(0, 78);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1848, 748);
            this.panel4.TabIndex = 3;
            this.panel4.Leave += new System.EventHandler(this.cbxGameList_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.cbxGames);
            this.panel5.Controls.Add(this.btnGameList);
            this.panel5.Controls.Add(this.btnSale);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1848, 56);
            this.panel5.TabIndex = 0;
            // 
            // cbxGames
            // 
            this.cbxGames.DropDownWidth = 120;
            this.cbxGames.FormattingEnabled = true;
            this.cbxGames.IntegralHeight = false;
            this.cbxGames.ItemHeight = 16;
            this.cbxGames.Items.AddRange(new object[] {
            "PlayStation 5 Pro",
            "PlayStation 5",
            "PlayStation 4",
            "Xbox Series X | S",
            "Máy Game Cũ",
            "Toy/Gift",
            "Phụ kiện",
            "Máy Game Retro",
            "Digital Cards"});
            this.cbxGames.Location = new System.Drawing.Point(165, 32);
            this.cbxGames.Name = "cbxGames";
            this.cbxGames.Size = new System.Drawing.Size(121, 24);
            this.cbxGames.TabIndex = 1;
            this.cbxGames.Visible = false;
            this.cbxGames.Leave += new System.EventHandler(this.cbxGameList_Leave);
            // 
            // btnGameList
            // 
            this.btnGameList.FlatAppearance.BorderSize = 0;
            this.btnGameList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGameList.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGameList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGameList.Location = new System.Drawing.Point(175, 6);
            this.btnGameList.Name = "btnGameList";
            this.btnGameList.Size = new System.Drawing.Size(111, 41);
            this.btnGameList.TabIndex = 2;
            this.btnGameList.Text = "GAMES";
            this.btnGameList.UseVisualStyleBackColor = false;
            this.btnGameList.MouseEnter += new System.EventHandler(this.btnGameList_MouseEnter);
            // 
            // btnSale
            // 
            this.btnSale.FlatAppearance.BorderSize = 0;
            this.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSale.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSale.Location = new System.Drawing.Point(26, 7);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(98, 41);
            this.btnSale.TabIndex = 1;
            this.btnSale.Text = "SALES";
            this.btnSale.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1848, 960);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.ComboBox cbxGames;
        private System.Windows.Forms.Button btnGameList;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.ComboBox cbxAll;
    }
}

