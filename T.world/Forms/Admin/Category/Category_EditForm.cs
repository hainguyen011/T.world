using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T.world.Server.Services;
using T.world.Shared.DTOs;
using T.world.Shared.Models;

namespace T.world.Forms.Admin.Category
{
    public partial class Category_EditForm: Form
    {
        private CategoryDTO category;
        public event EventHandler DataReload;
        private readonly CategoryService _categoryService;


        public Category_EditForm(CategoryDTO categoryData)
        {
            InitializeComponent();
            category = categoryData;
            _categoryService = new CategoryService();
        }

        private void Category_UpdateForm_Load(object sender, EventArgs e)
        {
            this.cateName.Text = category.name;
        }

        private void OnDataReload()
        {
            DataReload?.Invoke(this, EventArgs.Empty);
        }

        private void onSave_Clicked(object sender, EventArgs e)
        {
            using (var db = new TworldDBEntities())
            {
                CategoryDTO categoryUpdate = new CategoryDTO
                {
                    name = this.cateName.Text,
                };


                var response = _categoryService.UpdateCategory(category.id ?? Guid.Empty, categoryUpdate);
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
