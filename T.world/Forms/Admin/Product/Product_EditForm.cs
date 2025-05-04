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
using T.world.Server.Services;
using T.world.Shared.DTOs;
using T.world.Shared.Models;

namespace T.world.Forms.Admin.Product
{
    public partial class Product_EditForm: Form
    {
        private ProductDTO product;
        private readonly ProductService _productService;
        private readonly CategoryService _categoryService;
        private readonly BrandService _brandService;

        public event EventHandler DataReload;
        public Product_EditForm(ProductDTO productData)
        {
            InitializeComponent();
            _productService = new ProductService();
            _categoryService = new CategoryService();
            _brandService = new BrandService();
            product = productData;
        }

        private void OnDataReload()
        {
            DataReload?.Invoke(this, EventArgs.Empty);
        }

        private void Product_EditForm_Load(object sender, EventArgs e)
        {

            this.proName.Text = product.name;
            this.proDesc.Text = product.description;
            this.proPrice.Text = product.priceSell.ToString();
            this.proQuantity.Text = product.quantity.ToString();
           
          

            if (product.image != null)
            {
                string imagePath = Path.Combine(Application.StartupPath, product.image);

                
                if (File.Exists(imagePath))
                {
                    this.proPicture.Image = Image.FromFile(imagePath);
                }
            }

            CategoriesComboBoxData_Load();
            BrandComboBoxData_Load();

        }

        private void CategoriesComboBoxData_Load()
        {
            var categoryList = this._categoryService.GetListCategory("", 1, 10);
            this.cateComboBox.DataSource = categoryList;
            this.cateComboBox.DisplayMember = "name";
            this.cateComboBox.ValueMember = "id";
            this.cateComboBox.SelectedValue = product.categoryId;
        }

        private void BrandComboBoxData_Load()
        {
            var brandList = this._brandService.GetListBrand("", 1, 10);
            this.brandComboBox.DataSource = brandList;
            this.brandComboBox.DisplayMember = "name";
            this.brandComboBox.ValueMember = "id";
            this.brandComboBox.SelectedValue = product.brandId;
        }

        private void onEdit_Clicked(object sender, EventArgs e)
        {
            using (var db = new TworldDBEntities())
            {
                ProductDTO updateProduct = new ProductDTO
                {
                    name = this.proName.Text,
                    categoryId = Guid.Parse(this.cateComboBox.SelectedValue.ToString()),
                    brandId = Guid.Parse(this.brandComboBox.SelectedValue.ToString()),
                    image = product.image,
                    description = this.proDesc.Text,
                    priceSell = decimal.Parse(this.proPrice.Text),
                    quantity = int.Parse(this.proQuantity.Text),
                };


                var response = _productService.UpdateProduct(product.id ?? Guid.Empty, updateProduct);
                if (response.Success)
                {
                    MessageBox.Show(response.Message);
                    OnDataReload();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(response.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}
