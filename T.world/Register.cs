using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T.world.Shared.Models;
using T.world.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace T.world
{
    public partial class Register: Form
    {
        private readonly AccountService _accountService;

        public Register()
        {
            InitializeComponent();
            _accountService = new AccountService();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private bool CheckRegisterFormValid(Panel form)
        {
          

            // Check form valid
            return false;
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            using (var db = new TworldDBEntities())
            {

                string firstName = txtFName.Text;
                string lastName = txtLName.Text;
                string email = txtEmail.Text;
                string phone = txtPhone.Text;
                string password = txtPass.Text;
                string address = txtAddress.Text;

                var registedResult = _accountService.RegisterAccount(firstName, lastName, email, phone, password, address);
                if (registedResult.Success)
                {
                    MessageBox.Show(registedResult.Message);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(registedResult.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void inputText1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
