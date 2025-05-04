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
using T.world.Shared.Sessions;
using T.world.Services;

namespace T.world.Forms.Admin
{
    public partial class Dashboard: Form
    {
        private readonly SupplierService _supplierService;
        private readonly CategoryService _categoryService;
        private readonly ProductService _productService;
        private readonly BrandService _brandService;
        private readonly AccountService _accountService;

        public event EventHandler DataReload;

        private List<FormActions> tabActionForms;
        private FormActions currentForm; 

        public Dashboard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            _supplierService = new SupplierService();
            _categoryService = new CategoryService();
            _productService = new ProductService();
            _brandService = new BrandService();
            _accountService = new AccountService();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //SupplierData_Load(this, EventArgs.Empty);
            //CategoryData_Load(this, EventArgs.Empty);
            OverviewData_Load(this, EventArgs.Empty);
        }


        // Listen tab changed
        private void Dashboard_Tabchanged(object sender, EventArgs e)
        {
            switch (this.dashboard_tabcontrol.SelectedIndex)
            {
                case 0:
                    OverviewData_Load(this, EventArgs.Empty);
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
                case 5:
                    BrandData_Load(this, EventArgs.Empty);
                    break;
                case 6:
                    AccountData_Load(this, EventArgs.Empty);
                    break;
            }
        }

        private void OverviewData_Load(object sender, EventArgs e)
        {
            this.adTxt.Text = LoginSession.FullName;
            this.totalProduct.Text = _productService.GetTotalProductInStock().ToString();
        }

        // Load dữ liệu supplier
        private void AccountData_Load(object sender, EventArgs e)
        {

            var accountList = this._accountService.GetListAccount("", 1, 50);

            this.accGridView.Rows.Clear();
            this.accGridView.Columns.Clear();

            //// Thiết lập cột DataGridView
            this.accGridView.Columns.Add("id", "ID");
            this.accGridView.Columns.Add("first_name", "Họ");
            this.accGridView.Columns.Add("last_name", "Tên");
            this.accGridView.Columns.Add("email", "Email");
            this.accGridView.Columns.Add("phone", "Số điện thoại");
            this.accGridView.Columns.Add("address", "Địa chỉ");
            this.accGridView.Columns.Add("role", "Vai trò");
            this.accGridView.Columns.Add("created_at", "Ngày tạo");
            this.accGridView.Columns.Add("updated_at", "Ngày cập nhật");

            //// Thiết lập chiều rộng cột theo phần trăm
            int totalWidth = this.suppDataGridView.ClientSize.Width; 

            this.accGridView.Columns[0].Width = (int)(totalWidth * 0.12); 
            this.accGridView.Columns[1].Width = (int)(totalWidth * 0.10); 
            this.accGridView.Columns[2].Width = (int)(totalWidth * 0.10); 
            this.accGridView.Columns[3].Width = (int)(totalWidth * 0.2); 
            this.accGridView.Columns[4].Width = (int)(totalWidth * 0.12); 
            this.accGridView.Columns[5].Width = (int)(totalWidth * 0.15); 
            this.accGridView.Columns[6].Width = (int)(totalWidth * 0.08); 
            this.accGridView.Columns[7].Width = (int)(totalWidth * 0.09); 
            this.accGridView.Columns[8].Width = (int)(totalWidth * 0.09);


            //// Thiết lập màu nền và màu chữ cho header
            this.accGridView.EnableHeadersVisualStyles = false; // Bắt buộc để style có hiệu lực
            this.accGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(1, 48, 63); // Màu nền header
            this.accGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Màu chữ header
            this.accGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold); // Phông chữ header
            this.accGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.accGridView.ColumnHeadersHeight = 50;


            //// Thiết lập styles rows
            this.accGridView.RowTemplate.Height = 40;
            this.accGridView.DefaultCellStyle.SelectionForeColor = Color.White;

            //// Tắt tính năng chỉnh sửa trong DataGridView
            this.accGridView.AllowUserToAddRows = false;   // Không cho phép thêm dòng mới
            this.accGridView.ReadOnly = true;               // Chỉ đọc, không cho phép chỉnh sửa


            //// Thêm một dòng cho mỗi nhà cung cấp
            foreach (var account in accountList)
            {
                var row = new string[]
                    {
                        account.id.ToString(),
                        account.first_name,
                        account.last_name,
                        account.email,
                        account.phone,
                        account.address,
                        account.role,
                        account.created_at.ToString(),
                        account.updated_at.ToString()
                    };
                this.accGridView.Rows.Add(row);
            }
            ;
            this.accGridView.Invalidate();
        }

        // Load dữ liệu supplier
        private void SupplierData_Load(object sender, EventArgs e)
        {

            var supplierList = this._supplierService.GetListSupplier("", 1, 50);

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
            var categoryList = this._categoryService.GetListCategory("", 1, 50);
            this.cateDataGridView.Rows.Clear();
            this.cateDataGridView.Columns.Clear();

            // Thiết lập cột DataGridView
            this.cateDataGridView.Columns.Add("id", "ID");       // Cột Tên
            this.cateDataGridView.Columns.Add("name", "Tên danh mục");       // Cột Tên
            this.cateDataGridView.Columns.Add("created_at", "Ngày tạo"); // Cột Địa chỉ
            this.cateDataGridView.Columns.Add("updated_at", "Ngày cập nhật"); // Cột Địa chỉ

            // Thiết lập chiều rộng cột theo phần trăm
            int totalWidth = this.cateDataGridView.ClientSize.Width; // Lấy chiều rộng của DataGridView

            this.cateDataGridView.Columns[0].Width = (int)(totalWidth * 0.2); 
            this.cateDataGridView.Columns[1].Width = (int)(totalWidth * 0.4); 
            this.cateDataGridView.Columns[2].Width = (int)(totalWidth * 0.3); 
            this.cateDataGridView.Columns[3].Width = (int)(totalWidth * 0.3); 

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
           

            // Thêm một dòng cho mỗi nhà cung cấp
            foreach (var category in categoryList)
            {
                // Tạo một mảng dữ liệu cho từng dòng
                var row = new string[] { category.id.ToString(), category.name, category.created_at.ToString(), category.updated_at.ToString() };

                // Thêm dòng vào DataGridView
                this.cateDataGridView.Rows.Add(row);
            };
            this.cateDataGridView.Invalidate();
        }

        // load dữ liệu category
        private void BrandData_Load(object sender, EventArgs e)
        {
            var brandList = this._brandService.GetListBrand("", 1, 50);
            this.brandDataGridView.Rows.Clear();
            this.brandDataGridView.Columns.Clear();

            // Thiết lập cột DataGridView
            this.brandDataGridView.Columns.Add("id", "ID");
            this.brandDataGridView.Columns.Add("name", "Tên thương hiệu");       
            this.brandDataGridView.Columns.Add("description", "Mô tả");
            this.brandDataGridView.Columns.Add("created_at", "Ngày tạo");
            this.brandDataGridView.Columns.Add("updated_at", "Ngày cập nhật");

            // Thiết lập chiều rộng cột theo phần trăm
            int totalWidth = this.brandDataGridView.ClientSize.Width; // Lấy chiều rộng của DataGridView

            this.brandDataGridView.Columns[0].Width = (int)(totalWidth * 0.2); // Cột 1 40%
            this.brandDataGridView.Columns[1].Width = (int)(totalWidth * 0.2); // Cột 2 30%
            this.brandDataGridView.Columns[2].Width = (int)(totalWidth * 0.2); // Cột 3 30%
            this.brandDataGridView.Columns[3].Width = (int)(totalWidth * 0.2); // Cột 2 30%
            this.brandDataGridView.Columns[4].Width = (int)(totalWidth * 0.2); // Cột 2 30%

            // Thiết lập màu nền và màu chữ cho header
            this.brandDataGridView.EnableHeadersVisualStyles = false; // Bắt buộc để style có hiệu lực
            this.brandDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(1, 48, 63); // Màu nền header
            this.brandDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Màu chữ header
            this.brandDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold); // Phông chữ header
            this.brandDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.brandDataGridView.ColumnHeadersHeight = 50;


            // Thiết lập styles rows
            this.brandDataGridView.RowTemplate.Height = 40;
            this.brandDataGridView.DefaultCellStyle.SelectionForeColor = Color.White;

            // Tắt tính năng chỉnh sửa trong DataGridView
            this.brandDataGridView.AllowUserToAddRows = false;   // Không cho phép thêm dòng mới
            this.brandDataGridView.ReadOnly = true;               // Chỉ đọc, không cho phép chỉnh sửa
 
            // Thêm một dòng cho mỗi nhà cung cấp
            foreach (var brand in brandList)
            {
                // Tạo một mảng dữ liệu cho từng dòng
                var row = new string[] { 
                    brand.id.ToString(),
                    brand.name, 
                    brand.description,
                    brand.created_at.ToString(), 
                    brand.updated_at.ToString() 
                };

                // Thêm dòng vào DataGridView
                this.brandDataGridView.Rows.Add(row);
            };

            this.brandDataGridView.Invalidate();
        }

        // load dữ liệu product
        private void ProductData_Load(object sender, EventArgs e)
        {
            var productList = this._productService.GetListProduct("", 1, 50);
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
            this.ProDatagridView.Columns.Add("category", "Danh mục");
            this.ProDatagridView.Columns.Add("brand", "Thương hiệu");
            this.ProDatagridView.Columns.Add("description", "Mô tả");
            this.ProDatagridView.Columns.Add("price_sell", "Giá bán");
            this.ProDatagridView.Columns.Add("quantity", "Số lượng");
            this.ProDatagridView.Columns.Add("created_at", "Ngày tạo");
            this.ProDatagridView.Columns.Add("updated_at", "Ngày cập nhật");

            this.ProDatagridView.Columns.Add("category_id", "ID Danh mục");
            this.ProDatagridView.Columns.Add("brand_id", "ID Thường hiệu");

            // Thiết lập chiều rộng cột theo phần trăm
            int totalWidth = this.ProDatagridView.ClientSize.Width; // Lấy chiều rộng của DataGridView

            this.ProDatagridView.Columns[0].Width = (int)(totalWidth * 0.2); 
            this.ProDatagridView.Columns[1].Width = (int)(totalWidth * 0.1); 
            this.ProDatagridView.Columns[2].Width = (int)(totalWidth * 0.1); 
            this.ProDatagridView.Columns[3].Width = (int)(totalWidth * 0.1);
            this.ProDatagridView.Columns[4].Width = (int)(totalWidth * 0.1); 
            this.ProDatagridView.Columns[5].Width = (int)(totalWidth * 0.1); 
            this.ProDatagridView.Columns[6].Width = (int)(totalWidth * 0.1); 
            this.ProDatagridView.Columns[7].Width = (int)(totalWidth * 0.1); 
            this.ProDatagridView.Columns[8].Width = (int)(totalWidth * 0.1); 
            this.ProDatagridView.Columns[9].Width = (int)(totalWidth * 0.1); 


            // Thiết lập màu nền và màu chữ cho header
            this.ProDatagridView.EnableHeadersVisualStyles = false; 
            this.ProDatagridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(1, 48, 63); 
            this.ProDatagridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; 
            this.ProDatagridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold); 
            this.ProDatagridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProDatagridView.ColumnHeadersHeight = 50;


            // Ẩn cột chứa id ( khóa ngoại )
            this.ProDatagridView.Columns["category_id"].Visible = false;
            this.ProDatagridView.Columns["brand_id"].Visible = false;

            // Thiết lập styles rows
            this.ProDatagridView.RowTemplate.Height = 120;
            this.ProDatagridView.DefaultCellStyle.SelectionForeColor = Color.White;

            // Tắt tính năng chỉnh sửa trong DataGridView
            this.ProDatagridView.AllowUserToAddRows = false;  
            this.ProDatagridView.ReadOnly = true;           
            this.ProDatagridView.Invalidate();

            // Thêm một dòng cho mỗi nhà cung cấp
            foreach (var product in productList)
            {
                Image image = null;

                if (product.image != null)
                {
 
                    string fullPath = Path.Combine(Application.StartupPath, product.image);
            
                    if (File.Exists(fullPath))
                    {
                        using (var tempImage = Image.FromFile(fullPath))
                        {
                            image = new Bitmap(tempImage); 
                            
                        }
                    }
                }
               
              

                this.ProDatagridView.Rows.Add(
                     product.id.ToString(),
                     product.name,
                     image, 
                     product.image,
                     product.Category.name,
                     product.Brand.name, 
                     product.description,
                     product.price_sell.ToString(),
                     product.quantity.ToString(),
                     product.created_at.ToString(),
                     product.updated_at.ToString(),

                     product.Category.id.ToString(),
                     product.Brand.id.ToString()
                );


            };
        }

        // load dữ liệu sau khi dang nhap
        private void LoginResult_Load(object sender, EventArgs e)
        {
            if(LoginSession.Role == "ADMIN")
            {
                this.adTxt.Text = "Chào mừng quay lại " + LoginSession.FullName;
                this.dashboard_tabcontrol.Visible = true;
                this.loginBtn.Visible = false;
                this.registerBtn.Visible = false;
                this.logoutbtn.Visible = true;
            }
            else
            {
                this.adTxt.Text = "";
                this.dashboard_tabcontrol.Visible = false;
                this.loginBtn.Visible = true;
                this.registerBtn.Visible = true;
                this.logoutbtn.Visible = false;
            }
        }


        // Data Handler reload
        private void LoginDataRerult_Handler(object sender, EventArgs e)
        {
            LoginResult_Load(this, EventArgs.Empty);
        }
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
        private void BrandDataReload_Handler(object sender, EventArgs e)
        {
            BrandData_Load(this, EventArgs.Empty);
        }


        // Action Handler
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


                Supplier_EditForm suppUpdateFrom = new Supplier_EditForm(supplier);
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
                    categoryId = Guid.Parse(selectedRow.Cells["category_id"].Value.ToString()),
                    brandId = Guid.Parse(selectedRow.Cells["brand_id"].Value.ToString()),
                    description = selectedRow.Cells["description"].Value?.ToString(),
                    priceSell = decimal.Parse(selectedRow.Cells["price_sell"].Value?.ToString() ?? "0"),
                    quantity = int.Parse(selectedRow.Cells["quantity"].Value?.ToString() ?? "0"),

                };

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
        private void onCateEdit_Handler(object sender, EventArgs e)
        {
            if (cateDataGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = cateDataGridView.SelectedRows[0];
                CategoryDTO category = new CategoryDTO
                {
                    id = Guid.Parse(selectedRow.Cells["id"].Value.ToString()),
                    name = selectedRow.Cells["name"].Value?.ToString(),
                };
                Category_EditForm categoryUpdateForm = new Category_EditForm(category);
                categoryUpdateForm.DataReload += CategoryDataReload_Handler;
                categoryUpdateForm.Show();
            }
            else
            {
                MessageBox.Show("Chọn duy nhất một dòng để thực hiện hành động này!");
            }
        }
        private void onCateDelete_Handler(object sender, EventArgs e)
        {
            if (cateDataGridView.SelectedRows.Count >= 1)
            {
                DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa dữ liệu đã chọn không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {

                    DataGridViewRow selectedRow = cateDataGridView.SelectedRows[0];
                    foreach (DataGridViewRow row in this.cateDataGridView.SelectedRows)
                    {
                        Guid id = Guid.Parse(row.Cells["id"].Value.ToString());
                        this._categoryService.DeleteCategory(id);
                    }

                    this.CategoryData_Load(this, EventArgs.Empty);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu để thực hiện thao tác này ");
            }
        }
        private void onBrandEdit_Handler(object sender, EventArgs e)
        {
            if (brandDataGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = brandDataGridView.SelectedRows[0];
                BrandDTO brand = new BrandDTO
                {
                    id = Guid.Parse(selectedRow.Cells["id"].Value.ToString()),
                    name = selectedRow.Cells["name"].Value?.ToString(),
                    description = selectedRow.Cells["description"].Value?.ToString(),
                };
                Brand_EditForm brandUpdateForm = new Brand_EditForm(brand);
                brandUpdateForm.DataReload += BrandDataReload_Handler;
                brandUpdateForm.Show();
            }
            else
            {
                MessageBox.Show("Chọn duy nhất một dòng để thực hiện hành động này!");
            }
        }
        private void onBrandDelete_Handler(object sender, EventArgs e)
        {
            if (brandDataGridView.SelectedRows.Count >= 1)
            {
                DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa dữ liệu đã chọn không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {

                    DataGridViewRow selectedRow = brandDataGridView.SelectedRows[0];
                    foreach (DataGridViewRow row in this.brandDataGridView.SelectedRows)
                    {
                        Guid id = Guid.Parse(row.Cells["id"].Value.ToString());
                        this._brandService.DeleteBrand(id);
                    }

                    this.BrandData_Load(this, EventArgs.Empty);
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
                case 4:
                    onCateDelete_Handler(this, EventArgs.Empty);
                    break;
                case 5:
                    onBrandDelete_Handler(this, EventArgs.Empty);
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
                case 4:
                    onCateEdit_Handler(this, EventArgs.Empty);
                    break;
                case 5:
                    onBrandEdit_Handler(this, EventArgs.Empty);
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
                    brandCreateForm.DataReload += BrandDataReload_Handler;
                    brandCreateForm.Show();
                    break;
            }
        }

        // Listen click event
        private void onLogin_Clicked(object sender, EventArgs e)
        {

            // Tạo form Login
            Login loginForm = new Login();
            loginForm.result += LoginDataRerult_Handler;

            // Hiển thị form Login
            loginForm.ShowDialog();


            this.Refresh();
        }
        private void onRegister_Click(object sender, EventArgs e)
        {
            // Tạo form Register
            Register registerForm = new Register();

            // Hiển thị form Register
            registerForm.ShowDialog();
        }
        private void onLogout_Clicked(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất khỏi tài khoản này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                LoginSession.Logout();
                LoginResult_Load(this, EventArgs.Empty);

            }
        }
    }
}
