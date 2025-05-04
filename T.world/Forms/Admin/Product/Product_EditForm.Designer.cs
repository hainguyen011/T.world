namespace T.world.Forms.Admin.Product
{
    partial class Product_EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_EditForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.cateComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.proPicture = new System.Windows.Forms.PictureBox();
            this.proDesc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.proQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.proPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.savebtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.proName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(65, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.brandComboBox);
            this.panel1.Controls.Add(this.cateComboBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.proPicture);
            this.panel1.Controls.Add(this.proDesc);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.proQuantity);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.proPrice);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.savebtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.proName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(35, 43);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel1.Size = new System.Drawing.Size(972, 557);
            this.panel1.TabIndex = 5;
            // 
            // brandComboBox
            // 
            this.brandComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.brandComboBox.ItemHeight = 29;
            this.brandComboBox.Items.AddRange(new object[] {
            "hehe"});
            this.brandComboBox.Location = new System.Drawing.Point(706, 289);
            this.brandComboBox.MaxDropDownItems = 10;
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(235, 37);
            this.brandComboBox.TabIndex = 18;
            // 
            // cateComboBox
            // 
            this.cateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cateComboBox.FormattingEnabled = true;
            this.cateComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cateComboBox.ItemHeight = 29;
            this.cateComboBox.Items.AddRange(new object[] {
            "hehe"});
            this.cateComboBox.Location = new System.Drawing.Point(154, 289);
            this.cateComboBox.MaxDropDownItems = 10;
            this.cateComboBox.Name = "cateComboBox";
            this.cateComboBox.Size = new System.Drawing.Size(427, 37);
            this.cateComboBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(854, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Hình ảnh";
            // 
            // proPicture
            // 
            this.proPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.proPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("proPicture.InitialImage")));
            this.proPicture.Location = new System.Drawing.Point(685, 29);
            this.proPicture.Name = "proPicture";
            this.proPicture.Size = new System.Drawing.Size(256, 180);
            this.proPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.proPicture.TabIndex = 15;
            this.proPicture.TabStop = false;
            // 
            // proDesc
            // 
            this.proDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.proDesc.ForeColor = System.Drawing.Color.Black;
            this.proDesc.Location = new System.Drawing.Point(154, 397);
            this.proDesc.Multiline = true;
            this.proDesc.Name = "proDesc";
            this.proDesc.Size = new System.Drawing.Size(787, 37);
            this.proDesc.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Mô tả";
            // 
            // proQuantity
            // 
            this.proQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.proQuantity.ForeColor = System.Drawing.Color.Black;
            this.proQuantity.Location = new System.Drawing.Point(531, 341);
            this.proQuantity.Multiline = true;
            this.proQuantity.Name = "proQuantity";
            this.proQuantity.Size = new System.Drawing.Size(410, 37);
            this.proQuantity.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Số lượng";
            // 
            // proPrice
            // 
            this.proPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.proPrice.ForeColor = System.Drawing.Color.Black;
            this.proPrice.Location = new System.Drawing.Point(154, 341);
            this.proPrice.Multiline = true;
            this.proPrice.Name = "proPrice";
            this.proPrice.Size = new System.Drawing.Size(282, 37);
            this.proPrice.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Giá bán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(610, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nhãn hàng";
            // 
            // savebtn
            // 
            this.savebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.savebtn.AutoSize = true;
            this.savebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savebtn.Location = new System.Drawing.Point(33, 484);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(226, 48);
            this.savebtn.TabIndex = 0;
            this.savebtn.Text = "Lưu thông tin";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.onEdit_Clicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Danh mục";
            // 
            // proName
            // 
            this.proName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.proName.ForeColor = System.Drawing.Color.Black;
            this.proName.Location = new System.Drawing.Point(154, 239);
            this.proName.Multiline = true;
            this.proName.Name = "proName";
            this.proName.Size = new System.Drawing.Size(787, 37);
            this.proName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sản phẩm";
            // 
            // Product_EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 651);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Product_EditForm";
            this.Text = "Product_EditForm";
            this.Load += new System.EventHandler(this.Product_EditForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.ComboBox cateComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox proPicture;
        private System.Windows.Forms.TextBox proDesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox proQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox proPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox proName;
        private System.Windows.Forms.Label label2;
    }
}