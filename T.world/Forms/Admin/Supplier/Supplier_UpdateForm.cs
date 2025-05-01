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

        private readonly SupplierService _supplierService;
        public Supplier_UpdateForm()
        {
            InitializeComponent();
            _supplierService = new SupplierService();
        }

        private void Supplier_UpdateForm_Load(object sender, EventArgs e)
        {

        }

        private void onUpdate_Clicked(object sender, EventArgs e)
        {
            using (var db = new TworldDBEntities())
            {

                Guid suppId = new Guid();
                SupplierDTO newSupplier = new SupplierDTO
                {
                    name = "Samsung",
                    phone = "bla bla",
                    location = "Trái đất",
                };
 
                var registedResult = _supplierService.UpdateSupplier(suppId, newSupplier);
            }
        }

        private void onReset_Clicked(object sender, EventArgs e)
        {

        }
    }
}
