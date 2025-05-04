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

namespace T.world.Forms.Admin.Brand
{
    public partial class Brand_CreateForm: Form
    {

        private readonly BrandService _brandService;

        public Brand_CreateForm()
        {
            InitializeComponent();
            _brandService = new BrandService(); 

        }

        private void Brand_CreateForm_Load(object sender, EventArgs e)
        {

        }

        private void onBrand_Clicked(object sender, EventArgs e)
        {
            using (var db = new TworldDBEntities())
            {

                var newBrand = new BrandDTO
                {
                    name = this.brandName.Text,
                    description = this.brandDesc.Text,
                };

                var response = _brandService.CreateBrand(newBrand);
                if (response.Success)
                {
                    MessageBox.Show(response.Message);
                    //OnDataReload();
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
