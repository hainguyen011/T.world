using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T.world.Server.Repositories;
using T.world.Server.Services;
using T.world.Shared.DTOs;
using T.world.Shared.Models;

namespace T.world.Forms.Admin.Category
{
    public partial class Category_CreateForm: Form
    {
        private readonly CategoryService _categoryService;
        public Category_CreateForm()
        {
            InitializeComponent();
            _categoryService = new CategoryService();
        }

        private void Category_CreateForm_Load(object sender, EventArgs e)
        {
            this.Text = "Thêm nhà danh mục";
            this.TopMost = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void onCreate_Clicked(object sender, EventArgs e)
        {
            using (var db = new TworldDBEntities())
            {

                var newCategory = new CategoryDTO
                {
                    name = this.cateName.Text
                };

                var registedResult = _categoryService.CreateCategory(newCategory);
                if (registedResult.Success)
                {
                    MessageBox.Show(registedResult.Message);
                    //OnSupplierDataCreated();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(registedResult.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}
