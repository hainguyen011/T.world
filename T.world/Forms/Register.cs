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
using System.Text.RegularExpressions;

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
        // check null
        public  bool isEmpty(string str)
        {
            if (string.IsNullOrEmpty(str)) return true;
            return false;

        }
        // check email vali
        public bool IsValiEmail( string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch 
            {

                return false ;
            }
        }

        // check phone vali
        public bool IsValiPhone (string phone)
        {
            return Regex.IsMatch(phone, @"^0\d{9,10}$");
        }

        // check First and Last Name
        public bool IsValiName (string name)
        {
            return Regex.IsMatch(name, @"^[a-zA-ZÀ-ỹ\s]+$");
        }

        //check Address
        public bool IsValiAddress(string address)
        {
            return Regex.IsMatch(address, @"^[a-zA-Z0-9Á-ỹ]");
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

                if (isEmpty(firstName) || isEmpty(lastName) || isEmpty(email) || isEmpty(phone) || isEmpty(password) || isEmpty(address)) 
                {
                    MessageBox.Show("Thông tin không được bỏ trống", "Thông tin không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                
                else if (!IsValiEmail(email))
                {
                    MessageBox.Show("Email không hợp lệ ", "Thông tin sai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                } 
                
                else if (!IsValiPhone(phone))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ", "Thông tin sai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                else if (password.Length < 8)
                {
                    MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự", "Thông tin sai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                else if (!IsValiName(firstName) || !IsValiName(lastName))
                {
                    MessageBox.Show("Tên và Họ không được chứa số hoặc ký tự đặc biệt", "Thông tin sai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                else if (!IsValiAddress(address))
                {
                    MessageBox.Show("Địa chỉ không hợp lệ. Vui lòng nhập địa chỉ rõ ràng.", "Thông tin sai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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
