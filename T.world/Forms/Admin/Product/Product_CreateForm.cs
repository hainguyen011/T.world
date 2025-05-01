using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using T.world.Server.Services;
using T.world.Shared.Models;

namespace T.world.Forms.Admin.Product
{
    public partial class Product_CreateForm: Form
    {

        private readonly ProductService _productService;
        public Product_CreateForm()
        {
            InitializeComponent();
            _productService = new ProductService();
        }

        private void OnCreate_Clicked(object sender, EventArgs e)
        {


            //var productDTO = new ProductDTO
            //{
            //    name = "Sample Product",
            //    categoryId = 1,
            //    brandId = 2,
            //    proSpecId = 3,
            //    title = "Amazing Product Title",
            //    shortDesc = "Short description of the product.",
            //    description = "This is a detailed description of the product. It provides all necessary information about the product's features and benefits.",
            //    priceSell = 29.99m,
            //    createdAt = new DateTime(2025, 4, 22),
            //    updatedAt = new DateTime(2025, 4, 22)
            //};



            //var registedResult = _productService.CreateProduct(ProductDTO);
            //if (registedResult.Success)
            //{
            //    MessageBox.Show(registedResult.Message);
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show(registedResult.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void Product_CreateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
