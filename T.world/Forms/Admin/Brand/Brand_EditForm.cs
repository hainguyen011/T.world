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
    public partial class Brand_EditForm: Form
    {
        private BrandDTO brand;
        public event EventHandler DataReload;
        private readonly BrandService _brandService;

        public Brand_EditForm(BrandDTO brandData)
        {
            InitializeComponent();
       
            _brandService = new BrandService();
            brand = brandData;
        }

        private void Brand_EditForm_Load(object sender, EventArgs e)
        {
            this.brandName.Text = brand.name;
            this.brandDesc.Text = brand.description;

        }

        private void OnDataReload()
        {
            DataReload?.Invoke(this, EventArgs.Empty);
        }

        
        private void onSave_Clicked(object sender, EventArgs e)
        {
            using (var db = new TworldDBEntities())
            {
                BrandDTO brandUpdate = new BrandDTO
                {
                    name = this.brandName.Text,
                    description = this.brandDesc.Text
                };

                var response = _brandService.UpdateBrand(brand.id ?? Guid.Empty, brandUpdate);
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
