﻿using System;
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
using T.world.Forms.Admin;
using T.world.Services;
using T.world.Shared.Models;
using T.world.Shared.Sessions;

namespace T.world
{
    public partial class Login: Form
    {

        private readonly AccountService _accountService;
        public event EventHandler result;


        public Login()
        {
            InitializeComponent();
            _accountService = new AccountService();

            

        }


        private void Login_Load(object sender, EventArgs e)
        {
            

        }

        private void OnDataLogin()
        {
            result?.Invoke(this, EventArgs.Empty);
        }

        // check null
        public bool isEmpty(string str)
        {
            if (string.IsNullOrEmpty(str)) return true;
            return false;

        }

        private void Login_Clicked(object sender, EventArgs e)
        {
            string emailOrPhone = txtEmail.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(emailOrPhone) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Thông tin không được bỏ trống", "Thông tin không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                var result = _accountService.Login(emailOrPhone, password);

                if (result.Success)
                {
                    var loginInfo = result.Data;
                    if (loginInfo.Role == "ADMIN")
                    {
                        LoginSession.AccountId = Guid.Parse(loginInfo.Id);
                        LoginSession.FullName = loginInfo.Fullname;
                        LoginSession.Role = loginInfo.Role;
                        LoginSession.Email = loginInfo.Email;
                        OnDataLogin();
                        MessageBox.Show("Đăng nhập thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản của bạn không có quyền truy cập!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
