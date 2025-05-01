using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T.world.Forms.Admin.Supplier;
using T.world.Server.Services;
using T.world.Shared.DTOs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using T.world.Shared.Models;
using T.world.Forms.Admin.Category;
using T.world.Forms.Admin.NewFolder1;
using T.world.Forms.Admin.Promotions;

namespace T.world.Forms.Admin
{
    public partial class Dashboard: Form
    {
        private readonly SupplierService _supplierService;
        public Dashboard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            _supplierService = new SupplierService();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            SupplierData_Load(this, EventArgs.Empty);
        }

        private void SupplierData_Load(object sender, EventArgs e)
        {
            var supplierList = this._supplierService.GetListSupplier("", 1, 10);
            this.suppDataGridView.Rows.Clear();
            this.suppDataGridView.Columns.Clear();



            // Thiết lập cột DataGridView
            this.suppDataGridView.Columns.Add("name", "Tên");       // Cột Tên
            this.suppDataGridView.Columns.Add("phone", "Số điện thoại");      // Cột SĐT
            this.suppDataGridView.Columns.Add("location", "Địa chỉ"); // Cột Địa chỉ

            // Thiết lập chiều rộng cột theo phần trăm
            int totalWidth = this.suppDataGridView.ClientSize.Width; // Lấy chiều rộng của DataGridView

            this.suppDataGridView.Columns[0].Width = (int)(totalWidth * 0.4); // Cột Tên 40%
            this.suppDataGridView.Columns[1].Width = (int)(totalWidth * 0.3); // Cột SĐT 30%
            this.suppDataGridView.Columns[2].Width = (int)(totalWidth * 0.3); // Cột Địa chỉ 30%

            // Thiết lập màu nền và màu chữ cho header
            this.suppDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue; // Màu nền header
            this.suppDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Màu chữ header
            this.suppDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold); // Phông chữ header

            // Tắt tính năng chỉnh sửa trong DataGridView
            this.suppDataGridView.AllowUserToAddRows = false;   // Không cho phép thêm dòng mới
            this.suppDataGridView.ReadOnly = true;               // Chỉ đọc, không cho phép chỉnh sửa

            this.suppDataGridView.Invalidate();
            // Thêm một dòng cho mỗi nhà cung cấp
            foreach (var supplier in supplierList)
            {
                // Tạo một mảng dữ liệu cho từng dòng
                var row = new string[] { supplier.name, supplier.phone, supplier.location };

                // Thêm dòng vào DataGridView
                this.suppDataGridView.Rows.Add(row);
            };
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Supplier_CreateForm suppCreateFrom = new Supplier_CreateForm();
            suppCreateFrom.SupplierDataCreated += SupplierDataCreated_Handler;
            suppCreateFrom.Show();
        }


        private void SupplierDataCreated_Handler(object sender, EventArgs e)
        {
            // Cập nhật lại dữ liệu trong DataGridView
            SupplierData_Load(this, EventArgs.Empty);
        }

        private void onCreateCategory_Clicked(object sender, EventArgs e)
        {
            Category_CreateForm cateCreateForm = new Category_CreateForm();
            cateCreateForm.Show();
            //suppCreateFrom.SupplierDataCreated += SupplierDataCreated_Handler;
            //suppCreateFrom.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void suppDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Brand_CreateForm brandCreateForm = new Brand_CreateForm();
            brandCreateForm.Show();
        }

        private void btnAddPromotions_Click(object sender, EventArgs e)
        {
            Promotions_CreateForm promotions_Create = new Promotions_CreateForm();
            promotions_Create.Show();
        }
    }
}
