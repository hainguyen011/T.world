using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using T.world.Server.Services;
using T.world.Shared.DTOs;
using T.world.Shared.Models;

namespace T.world.Forms.Admin.Product
{
    public partial class Product_CreateForm: Form
    {

        private readonly ProductService _productService;
        private readonly CategoryService _categoryService;
        private readonly BrandService _brandService;
        private string selectedImagePath;
        public event EventHandler DataReload;


        public Product_CreateForm()
        {
            InitializeComponent();
            _productService = new ProductService();
            _categoryService = new CategoryService();
            _brandService = new BrandService();
        }

        private void Product_CreateForm_Load(object sender, EventArgs e)
        {
            CategoriesComboBoxData_Load();
            BrandComboBoxData_Load();
        }
        private void OnDataReload()
        {
            DataReload?.Invoke(this, EventArgs.Empty);
        }

        private void OnCreate_Clicked(object sender, EventArgs e)
        {
            var productDTO = new ProductDTO
            {
                name = this.proName.Text,
                categoryId = (Guid)this.cateComboBox.SelectedValue,
                brandId = (Guid)this.brandComboBox.SelectedValue,
                image = this.selectedImagePath,
                description = this.proDesc.Text,
                priceSell = decimal.Parse(this.proPrice.Text),
                quantity = int.Parse(this.proQuantity.Text),
                createdAt = new DateTime(2025, 4, 22),
                updatedAt = new DateTime(2025, 4, 22)
            };

            var registedResult = _productService.CreateProduct(productDTO);
            if (registedResult.Success)
            {
                MessageBox.Show(registedResult.Message);
                OnDataReload();
                this.Close();
            }
            else
            {
                MessageBox.Show(registedResult.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CategoriesComboBoxData_Load()
        {
            var categoryList = this._categoryService.GetListCategory("", 1, 10);
            this.cateComboBox.DataSource = categoryList;
            this.cateComboBox.DisplayMember = "name";
            this.cateComboBox.ValueMember = "id";
        }

        private void BrandComboBoxData_Load()
        {
            var brandList = this._brandService.GetListBrand("", 1, 10);
            this.brandComboBox.DataSource = brandList;
            this.brandComboBox.DisplayMember = "name";
            this.brandComboBox.ValueMember = "id";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void suppLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductImage_Paint(object sender, PaintEventArgs e)
        {
            Control control = (Control)sender;

            using (Pen dashedPen = new Pen(Color.Gray))
            {
                dashedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                e.Graphics.DrawRectangle(
                    dashedPen,
                    0, 0,
                    control.Width - 1,
                    control.Height - 1
                );
            }
        }

        private void suppPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void cateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void priceSell_TextChanged(object sender, EventArgs e)
        {

        }

        private void brandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void proPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            string uploadFolder = Path.Combine(Application.StartupPath, "Assets", "Upload");

            if (!Directory.Exists(uploadFolder))
            {
                Directory.CreateDirectory(uploadFolder);
            }

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(ofd.FileName);
                string destinationPath = Path.Combine(uploadFolder, fileName);

                proPicture.Image = Image.FromFile(ofd.FileName);
                File.Copy(ofd.FileName, destinationPath);
 
                string relativePath = Path.Combine("Assets", "Upload", fileName);

                this.selectedImagePath = relativePath;
            }
        }
    }
}
