﻿namespace T.world.Forms.Admin.Supplier
{
    partial class Supplier_EditForm
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
            this.suppLocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.suppPhone = new System.Windows.Forms.TextBox();
            this.edit_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.suppName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "CẬP NHẬT THÔNG TIN NHÀ CUNG CẤP";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.suppLocation);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.suppPhone);
            this.panel1.Controls.Add(this.edit_button);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.suppName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(19, 39);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel1.Size = new System.Drawing.Size(757, 442);
            this.panel1.TabIndex = 3;
            // 
            // suppLocation
            // 
            this.suppLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.suppLocation.ForeColor = System.Drawing.Color.Black;
            this.suppLocation.Location = new System.Drawing.Point(185, 156);
            this.suppLocation.Multiline = true;
            this.suppLocation.Name = "suppLocation";
            this.suppLocation.Size = new System.Drawing.Size(518, 37);
            this.suppLocation.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Địa chỉ";
            // 
            // suppPhone
            // 
            this.suppPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.suppPhone.ForeColor = System.Drawing.Color.Black;
            this.suppPhone.Location = new System.Drawing.Point(185, 108);
            this.suppPhone.Multiline = true;
            this.suppPhone.Name = "suppPhone";
            this.suppPhone.Size = new System.Drawing.Size(357, 37);
            this.suppPhone.TabIndex = 4;
            // 
            // edit_button
            // 
            this.edit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_button.Location = new System.Drawing.Point(40, 350);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(518, 48);
            this.edit_button.TabIndex = 0;
            this.edit_button.Text = "Lưu thông tin";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.onUpdate_Clicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số điện thoại";
            // 
            // suppName
            // 
            this.suppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.suppName.ForeColor = System.Drawing.Color.Black;
            this.suppName.Location = new System.Drawing.Point(185, 61);
            this.suppName.Multiline = true;
            this.suppName.Name = "suppName";
            this.suppName.Size = new System.Drawing.Size(473, 37);
            this.suppName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhà cung cấp";
            // 
            // Supplier_EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Supplier_EditForm";
            this.Text = "Supplier_UpdateForm";
            this.Load += new System.EventHandler(this.Supplier_UpdateForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox suppLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox suppName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox suppPhone;
    }
}