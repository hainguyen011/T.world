﻿namespace T.world.Forms.Admin.Brand
{
    partial class Brand_EditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.brandDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.createbtn = new System.Windows.Forms.Button();
            this.brandName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(79, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "THÔNG TIN THƯƠNG HIỆU";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.brandDesc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.createbtn);
            this.panel1.Controls.Add(this.brandName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(50, 59);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel1.Size = new System.Drawing.Size(697, 333);
            this.panel1.TabIndex = 7;
            // 
            // brandDesc
            // 
            this.brandDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.brandDesc.ForeColor = System.Drawing.Color.Black;
            this.brandDesc.Location = new System.Drawing.Point(186, 115);
            this.brandDesc.Multiline = true;
            this.brandDesc.Name = "brandDesc";
            this.brandDesc.Size = new System.Drawing.Size(473, 37);
            this.brandDesc.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mô tả";
            // 
            // createbtn
            // 
            this.createbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.createbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createbtn.Location = new System.Drawing.Point(32, 245);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(213, 52);
            this.createbtn.TabIndex = 0;
            this.createbtn.Text = "Lưu thông tin";
            this.createbtn.UseVisualStyleBackColor = true;
            this.createbtn.Click += new System.EventHandler(this.onSave_Clicked);
            // 
            // brandName
            // 
            this.brandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.brandName.ForeColor = System.Drawing.Color.Black;
            this.brandName.Location = new System.Drawing.Point(185, 61);
            this.brandName.Multiline = true;
            this.brandName.Name = "brandName";
            this.brandName.Size = new System.Drawing.Size(473, 37);
            this.brandName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhãn hàng";
            // 
            // Brand_EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Brand_EditForm";
            this.Text = "Brand_EditForm";
            this.Load += new System.EventHandler(this.Brand_EditForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox brandDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createbtn;
        private System.Windows.Forms.TextBox brandName;
        private System.Windows.Forms.Label label2;
    }
}