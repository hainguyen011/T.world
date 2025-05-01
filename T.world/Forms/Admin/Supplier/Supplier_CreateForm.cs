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
using T.world.Services;
using T.world.Shared.DTOs;
using T.world.Shared.Models;

namespace T.world.Forms.Admin.Supplier
{
    public partial class Supplier_CreateForm: Form
    {
        private readonly SupplierService _supplierService;
        public Supplier_CreateForm()
        {
            InitializeComponent();
            _supplierService = new SupplierService();

        }
        public event EventHandler SupplierDataCreated;
        private void OnSupplierDataCreated()
        {
            SupplierDataCreated?.Invoke(this, EventArgs.Empty);
        }

        private void Supplier_CreateForm_Load(object sender, EventArgs e)
        {
            this.Text = "Thêm nhà cung cấp";
            this.TopMost = true;
        }


        private void OnCreate_Clicked(object sender, EventArgs e)
        {
            using (var db = new TworldDBEntities())
            {

                var newSupplier = new SupplierDTO
                {
                   name = this.suppName.Text,
                   phone = this.suppPhone.Text,
                   location = this.suppLocation.Text,
                };

                var registedResult = _supplierService.CreateSupplier(newSupplier);
                if (registedResult.Success)
                {
                    MessageBox.Show(registedResult.Message);
                    OnSupplierDataCreated();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(registedResult.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
