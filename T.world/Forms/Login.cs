using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T.world.Services;

namespace T.world
{
    public partial class Login: Form
    {

        private readonly AccountService _accountService;
        public Login()
        {
            InitializeComponent();
            _accountService = new AccountService();
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }
        
        private void Login_Clicked(object sender, EventArgs e)
        {
            string emailOrPhone = txtEmail.Text;
            string password = txtPassword.Text;

            var result = _accountService.Login(emailOrPhone, password);

            if (result.Success)
            {
                MessageBox.Show("Đăng nhập thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Register_Clicked(object sender, EventArgs e)
        {

            this.Hide(); // Ẩn form hiện tại 

            // Tạo form Register
            Register registerForm = new Register();

            // Hiển thị form Register
            registerForm.ShowDialog();

            this.Show(); // Hiện lại form sau khi Register đóng
        }

        private void Login_title_Click(object sender, EventArgs e)
        {

        }
    }
}
