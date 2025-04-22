using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
            this.ActiveControl = Login_title;

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
        private bool isPasswordHidden = true;
        private void pcEye_Click(object sender, EventArgs e)
        {
            string imageFolder = @"D:\LTCSDL\Picture"; // Đường dẫn đến thư mục chứa ảnh
            string openEyePath = Path.Combine(imageFolder, "eye_open.png");
            string closedEyePath = Path.Combine(imageFolder, "eye_closed.png");

            if (isPasswordHidden)
            {
                txtPassword.PasswordChar = '\0'; // Hiện mật khẩu

                if (File.Exists(openEyePath))
                {
                    pcEye.Image = Image.FromFile(openEyePath);
                }
            }
            else
            {
                txtPassword.PasswordChar = '*'; // Ẩn mật khẩu

                if (File.Exists(closedEyePath))
                {
                    pcEye.Image = Image.FromFile(closedEyePath);
                }
            }

            // Cập nhật trạng thái
            isPasswordHidden = !isPasswordHidden;

            // Đảm bảo ảnh hiển thị đúng kích thước
            pcEye.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        
        
        ////////////////// sự kiện nahapj ô Login email or phone
        
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email or Phone")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Gray;
            }
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = "Email or Phone";
                txtEmail.ForeColor = Color.Gray;
            }
        }

    }
}
