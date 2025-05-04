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
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using T.world.Forms.Admin.Product;
using System.IO;
using T.world.Forms.Admin.Brand;

namespace T.world.Forms.Admin
{
    public partial class Dashboard: Form
    {
        private readonly SupplierService _supplierService;
        private readonly CategoryService _categoryService;
        private readonly ProductService _productService;
        private List<FormActions> tabActionForms;
        private FormActions currentForm; 

        public Dashboard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            _supplierService = new SupplierService();
            _categoryService = new CategoryService();
            _productService = new ProductService();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //SupplierData_Load(this, EventArgs.Empty);
            //CategoryData_Load(this, EventArgs.Empty);
        }

        // Load form action
        private void FormAction_Load(object sender, EventArgs e)
        {

        }

        // Listen tab changed
        private void Dashboard_Tabchanged(object sender, EventArgs e)
        {
            switch (this.dashboard_tabcontrol.SelectedIndex)
            {
                case 0:

                    break;
                case 1:
                    ProductData_Load(this, EventArgs.Empty);
                    break;
                case 2:

                    break;
                case 3:
                    SupplierData_Load(this, EventArgs.Empty);
                    break;
                case 4:
                    CategoryData_Load(this, EventArgs.Empty);
                    break;
            }
        }

        // Setup form styles
        private void FormStyles_Load(object sender, EventArgs e)
        {

        }

        // Load dữ liệu supplier
        private void SupplierData_Load(object sender, EventArgs e)
        {

            var supplierList = this._supplierService.GetListSupplier("", 1, 15);

            this.suppDataGridView.Rows.Clear();
            this.suppDataGridView.Columns.Clear();

            // Thiết lập cột DataGridView
            this.suppDataGridView.Columns.Add("id", "Mã nhà cung cấp");
            this.suppDataGridView.Columns.Add("name", "Tên nhà cung cấp");       
            this.suppDataGridView.Columns.Add("phone", "Số điện thoại");      
            this.suppDataGridView.Columns.Add("location", "Địa chỉ");
            this.suppDataGridView.Columns.Add("created_at", "Ngày tạo");
            this.suppDataGridView.Columns.Add("updated_at", "Ngày cập nhật");

            // Thiết lập chiều rộng cột theo phần trăm
            int totalWidth = this.suppDataGridView.ClientSize.Width; // Lấy chiều rộng của DataGridView

            this.suppDataGridView.Columns[0].Width = (int)(totalWidth * 0.2);
            this.suppDataGridView.Columns[1].Width = (int)(totalWidth * 0.3); 
            this.suppDataGridView.Columns[2].Width = (int)(totalWidth * 0.2); 
            this.suppDataGridView.Columns[3].Width = (int)(totalWidth * 0.2); 
            this.suppDataGridView.Columns[4].Width = (int)(totalWidth * 0.2);
            this.suppDataGridView.Columns[5].Width = (int)(totalWidth * 0.2);

            // Thiết lập màu nền và màu chữ cho header
            this.suppDataGridView.EnableHeadersVisualStyles = false; // Bắt buộc để style có hiệu lực
            this.suppDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(1, 48, 63); // Màu nền header
            this.suppDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Màu chữ header
            this.suppDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold); // Phông chữ header
            this.suppDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.suppDataGridView.ColumnHeadersHeight = 50;


            // Thiết lập styles rows
            this.suppDataGridView.RowTemplate.Height = 40;
            this.suppDataGridView.DefaultCellStyle.SelectionForeColor = Color.White;     

            // Tắt tính năng chỉnh sửa trong DataGridView
            this.suppDataGridView.AllowUserToAddRows = false;   // Không cho phép thêm dòng mới
            this.suppDataGridView.ReadOnly = true;               // Chỉ đọc, không cho phép chỉnh sửa

          
            // Thêm một dòng cho mỗi nhà cung cấp
            foreach (var supplier in supplierList)
            {
                var row = new string[] { supplier.id.ToString(), supplier.name, supplier.phone, supplier.location, supplier.created_at.ToString(), supplier.updated_at.ToString() };
                // Thêm dòng vào DataGridView
                this.suppDataGridView.Rows.Add(row);
            };
            this.suppDataGridView.Invalidate();
        }

        // load dữ liệu category
        private void CategoryData_Load(object sender, EventArgs e)
        {
            var categoryList = this._categoryService.GetListCategory("", 1, 10);
            this.cateDataGridView.Rows.Clear();
            this.cateDataGridView.Columns.Clear();

            // Thiết lập cột DataGridView
            this.cateDataGridView.Columns.Add("name", "Tên danh mục");       // Cột Tên
            this.cateDataGridView.Columns.Add("created_at", "Ngày tạo"); // Cột Địa chỉ
            this.cateDataGridView.Columns.Add("updated_at", "Ngày cập nhật"); // Cột Địa chỉ

            // Thiết lập chiều rộng cột theo phần trăm
            int totalWidth = this.cateDataGridView.ClientSize.Width; // Lấy chiều rộng của DataGridView

            this.cateDataGridView.Columns[0].Width = (int)(totalWidth * 0.4); // Cột 1 40%
            this.cateDataGridView.Columns[1].Width = (int)(totalWidth * 0.3); // Cột 2 30%
            this.cateDataGridView.Columns[2].Width = (int)(totalWidth * 0.3); // Cột 3 30%

            // Thiết lập màu nền và màu chữ cho header
            this.cateDataGridView.EnableHeadersVisualStyles = false; // Bắt buộc để style có hiệu lực
            this.cateDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(1, 48, 63); // Màu nền header
            this.cateDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Màu chữ header
            this.cateDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold); // Phông chữ header
            this.cateDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.cateDataGridView.ColumnHeadersHeight = 50;


            // Thiết lập styles rows
            this.cateDataGridView.RowTemplate.Height = 40;
            this.cateDataGridView.DefaultCellStyle.SelectionForeColor = Color.White;

            // Tắt tính năng chỉnh sửa trong DataGridView
            this.cateDataGridView.AllowUserToAddRows = false;   // Không cho phép thêm dòng mới
            this.cateDataGridView.ReadOnly = true;               // Chỉ đọc, không cho phép chỉnh sửa
            this.cateDataGridView.Invalidate();

            // Thêm một dòng cho mỗi nhà cung cấp
            foreach (var category in categoryList)
            {
                // Tạo một mảng dữ liệu cho từng dòng
                var row = new string[] { category.name, category.created_at.ToString(), category.updated_at.ToString() };

                // Thêm dòng vào DataGridView
                this.cateDataGridView.Rows.Add(row);
            };
        }

        // load dữ liệu product
        private void ProductData_Load(object sender, EventArgs e)
        {
            var productList = this._productService.GetListProduct("", 1, 10);
            this.ProDatagridView.Rows.Clear();
            this.ProDatagridView.Columns.Clear();

            this.ProDatagridView.Columns.Add("id", "ID");
            this.ProDatagridView.Columns.Add("name", "Tên sản phẩm");

            // Thêm cột hình ảnh
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.Name = "image";
            imgCol.HeaderText = "Hình ảnh";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            this.ProDatagridView.Columns.Add(imgCol);

            this.ProDatagridView.Columns.Add("image_path", "Đường dẫn hình ảnh");

            //this.ProDatagridView.Columns.Add("image", "Hình ảnh");
            this.ProDatagridView.Columns.Add("category_id", "Danh mục");
            this.ProDatagridView.Columns.Add("brand_id", "Thương hiệu");
            this.ProDatagridView.Columns.Add("description", "Mô tả");
            this.ProDatagridView.Columns.Add("price_sell", "Giá bán");
            this.ProDatagridView.Columns.Add("quantity", "Số lượng");
            this.ProDatagridView.Columns.Add("created_at", "Ngày tạo");
            this.ProDatagridView.Columns.Add("updated_at", "Ngày cập nhật");


            // Thiết lập chiều rộng cột theo phần trăm
            int totalWidth = this.ProDatagridView.ClientSize.Width; // Lấy chiều rộng của DataGridView

            this.ProDatagridView.Columns[0].Width = (int)(totalWidth * 0.2); // Cột 1 40%
            this.ProDatagridView.Columns[1].Width = (int)(totalWidth * 0.1); // Cột 2 30%
            this.ProDatagridView.Columns[2].Width = (int)(totalWidth * 0.1); // Cột 3 30%
            this.ProDatagridView.Columns[3].Width = (int)(totalWidth * 0.1); // Cột 3 30%
            this.ProDatagridView.Columns[4].Width = (int)(totalWidth * 0.1); // Cột 3 30%
            this.ProDatagridView.Columns[5].Width = (int)(totalWidth * 0.1); // Cột 3 30%
            this.ProDatagridView.Columns[6].Width = (int)(totalWidth * 0.1); // Cột 3 30%
            this.ProDatagridView.Columns[7].Width = (int)(totalWidth * 0.1); // Cột 3 30%
            this.ProDatagridView.Columns[8].Width = (int)(totalWidth * 0.1); // Cột 3 30%
            this.ProDatagridView.Columns[9].Width = (int)(totalWidth * 0.1); // Cột 3 30%

            // Thiết lập màu nền và màu chữ cho header
            this.ProDatagridView.EnableHeadersVisualStyles = false; // Bắt buộc để style có hiệu lực
            this.ProDatagridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(1, 48, 63); // Màu nền header
            this.ProDatagridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Màu chữ header
            this.ProDatagridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold); // Phông chữ header
            this.ProDatagridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProDatagridView.ColumnHeadersHeight = 50;


            // Thiết lập styles rows
            this.ProDatagridView.RowTemplate.Height = 120;
            this.ProDatagridView.DefaultCellStyle.SelectionForeColor = Color.White;

            // Tắt tính năng chỉnh sửa trong DataGridView
            this.ProDatagridView.AllowUserToAddRows = false;   // Không cho phép thêm dòng mới
            this.ProDatagridView.ReadOnly = true;               // Chỉ đọc, không cho phép chỉnh sửa
            this.ProDatagridView.Invalidate();

            // Thêm một dòng cho mỗi nhà cung cấp
            foreach (var product in productList)
            {
                Image image = null;

                if (product.image != null)
                {
                    // Đường dẫn tới thư mục Assets/Upload (nằm cùng thư mục .exe)
                    string fullPath = Path.Combine(Application.StartupPath, product.image);
            
                    if (File.Exists(fullPath))
                    {
                        using (var tempImage = Image.FromFile(fullPath))
                        {
                            image = new Bitmap(tempImage); // Tránh lỗi file đang bị dùng
                            
                        }
                    }
                }
               
              

                this.ProDatagridView.Rows.Add(
                     product.id.ToString(),
                     product.name,
                     image, 
                     product.image,
                     product.Category.name,
                     "brand", 
                     product.description,
                     product.price_sell.ToString(),
                     product.quantity.ToString(),
                     product.created_at.ToString(),
                     product.updated_at.ToString()
                );


            };
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      
        // Handler Custom
        private void SupplierDataReload_Handler(object sender, EventArgs e)
        {
            SupplierData_Load(this, EventArgs.Empty);
        }

        private void ProductDataReload_Handler(object sender, EventArgs e)
        {
            ProductData_Load(this, EventArgs.Empty);
        }

        private void CategoryDataReload_Handler(object sender, EventArgs e)
        {
            CategoryData_Load(this, EventArgs.Empty);
        }
        private void onSuppEdit_Handler(object sender, EventArgs e)
        {
            SupplierDTO editSupplier = new SupplierDTO();

            if (suppDataGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = suppDataGridView.SelectedRows[0];
                SupplierDTO supplier = new SupplierDTO
                {
                    id = Guid.Parse(selectedRow.Cells["id"].Value.ToString()),
                    name = selectedRow.Cells["name"].Value?.ToString(),
                    location = selectedRow.Cells["location"].Value?.ToString(),
                    phone = selectedRow.Cells["phone"].Value?.ToString()
                };


                Supplier_UpdateForm suppUpdateFrom = new Supplier_UpdateForm(supplier);
                suppUpdateFrom.SupplierDataReload += SupplierDataReload_Handler;
                suppUpdateFrom.Show();
            }
            else
            {
                MessageBox.Show("Chọn duy nhất một dòng để thực hiện hành động này!");
            }
        }
        private void onSuppDelete_Handler(object sender, EventArgs e)
        {
            SupplierDTO editSupplier = new SupplierDTO();

            if (suppDataGridView.SelectedRows.Count >= 1)
            {
                DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa dữ liệu đã chọn không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {

                    DataGridViewRow selectedRow = suppDataGridView.SelectedRows[0];
                    foreach (DataGridViewRow row in this.suppDataGridView.SelectedRows)
                    {
                        Guid id = Guid.Parse(row.Cells["id"].Value.ToString());
                        this._supplierService.DeleteSupplier(id);
                    }

                   this.SupplierData_Load(this, EventArgs.Empty);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu để thực hiện thao tác này ");
            }
        }
        private void onProEdit_Handler(object sender, EventArgs e)
        {
            if (ProDatagridView.SelectedRows.Count == 1)
            {

                DataGridViewRow selectedRow = ProDatagridView.SelectedRows[0];
                


                ProductDTO product = new ProductDTO
                {
                    id = Guid.Parse(selectedRow.Cells["id"].Value.ToString()),
                    name = selectedRow.Cells["name"].Value?.ToString(),
                    image = selectedRow.Cells["image_path"].Value.ToString(), 
                    description = selectedRow.Cells["description"].Value?.ToString(),
                    priceSell = decimal.Parse(selectedRow.Cells["price_sell"].Value?.ToString() ?? "0"),
                    quantity = int.Parse(selectedRow.Cells["quantity"].Value?.ToString() ?? "0"),
                    // bạn cần ánh xạ thêm category_id và brand_id nếu có
                };

                MessageBox.Show(selectedRow.Cells["image_path"].Value.ToString());
              
                Product_EditForm productEditForm = new Product_EditForm(product);
                productEditForm.DataReload += ProductDataReload_Handler;
                productEditForm.Show();
            }
            else
            {
                MessageBox.Show("Chọn duy nhất một dòng để thực hiện hành động này!");
            }
        }
        private void onProDelete_Handler(object sender, EventArgs e)
        {
           

            if (ProDatagridView.SelectedRows.Count >= 1)
            {
                DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa dữ liệu đã chọn không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {

                    DataGridViewRow selectedRow = ProDatagridView.SelectedRows[0];
                    foreach (DataGridViewRow row in this.ProDatagridView.SelectedRows)
                    {
                        Guid id = Guid.Parse(row.Cells["id"].Value.ToString());
                        this._productService.DeleteProduct(id);
                    }

                    this.ProductData_Load(this, EventArgs.Empty);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu để thực hiện thao tác này ");
            }
        }


        // Common Admin actions
        private void onDelete_Clicked(object sender, EventArgs e)
        {
            switch (this.dashboard_tabcontrol.SelectedIndex)
            {
                case 0:

                    break;
                case 1:
                    onProDelete_Handler(this, EventArgs.Empty);
                    break;
                case 2:

                    break;
                case 3:
                    onSuppDelete_Handler(this, EventArgs.Empty);
                    break;
            }
        }

        private void onEdit_Clicked(object sender, EventArgs e)
        {
            switch (this.dashboard_tabcontrol.SelectedIndex)
            {
                case 0:

                    break;
                case 1:
                    onProEdit_Handler(this, EventArgs.Empty);
                    break;
                case 2:

                    break;
                case 3:
                    onSuppEdit_Handler(this, EventArgs.Empty);
                    break;
            }
        }

        private void onCreate_Clicked(object sender, EventArgs e)
        {
            switch (this.dashboard_tabcontrol.SelectedIndex)
            {
                case 0:
               
                    break;
                case 1:
                    Product_CreateForm proCreateFrom = new Product_CreateForm();
                    proCreateFrom.DataReload += ProductDataReload_Handler;
                    proCreateFrom.Show();
                    break;
                case 2:
                 
                    break;
                case 3:
                    Supplier_CreateForm suppCreateFrom = new Supplier_CreateForm();
                    suppCreateFrom.SupplierDataReload += SupplierDataReload_Handler;
                    suppCreateFrom.Show();
                    break;
                case 4:
                    Category_CreateForm cateCreateForm = new Category_CreateForm();
                    cateCreateForm.DataReload += CategoryDataReload_Handler;
                    cateCreateForm.Show();
                    break;
                case 5:
                    Brand_CreateForm brandCreateForm = new Brand_CreateForm();
                    //brandCreateForm.DataReload += CategoryDataReload_Handler;
                    brandCreateForm.Show();
                    break;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Brand_CreateForm brandCreateForm = new Brand_CreateForm();
            //brandCreateForm.Show();
        }

        private void btnAddPromotions_Click(object sender, EventArgs e)
        {
            //Promotions_CreateForm promotions_Create = new Promotions_CreateForm();
            //promotions_Create.Show();
        }
    }
}
