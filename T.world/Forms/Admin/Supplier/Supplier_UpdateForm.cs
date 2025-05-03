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

namespace T.world.Forms.Admin.Supplier
{
    public partial class Supplier_UpdateForm: Form
    {
        private SupplierDTO supplier;
        private readonly SupplierService _supplierService;
        public event EventHandler SupplierDataReload;


        public Supplier_UpdateForm(SupplierDTO supplierData)
        {
            InitializeComponent();
            _supplierService = new SupplierService();
            supplier = supplierData;
        }

        private void OnSupplierDataReload()
        {
            SupplierDataReload?.Invoke(this, EventArgs.Empty);
        }

        private void Supplier_UpdateForm_Load(object sender, EventArgs e)
        {
            this.suppName.Text = supplier.name;
            this.suppPhone.Text = supplier.phone;
            this.suppLocation.Text = supplier.location;
        }

        private void onUpdate_Clicked(object sender, EventArgs e)
        {
            using (var db = new TworldDBEntities())
            {
                SupplierDTO updateSupplier = new SupplierDTO
                {
                    name = this.suppName.Text,
                    phone = this.suppPhone.Text,
                    location = this.suppLocation.Text,
                };

                
                var response = _supplierService.UpdateSupplier(supplier.id ?? Guid.Empty, updateSupplier);
                if (response.Success)
                {
                    MessageBox.Show(response.Message);
                    OnSupplierDataReload();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(response.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void onReset_Clicked(object sender, EventArgs e)
        {

        }
    }
}
