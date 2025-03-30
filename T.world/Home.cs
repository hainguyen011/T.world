using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T.world
{
    public partial class Home: Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        

        private void btnMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Nhập từ khóa sản phẩm cần tìm kiếm")
            {
                txtSearch.Text = ""; // Xóa placeholder khi nhập
                txtSearch.ForeColor = Color.Black; // Đổi màu chữ về đen
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Nhập từ khóa sản phẩm cần tìm kiếm"; // Hiển thị lại placeholder nếu trống
                txtSearch.ForeColor = Color.Gray; // Đổi màu chữ thành xám
            }
        }
        ////////////// Thanh taskbar game
        private void btnGameList_MouseEnter(object sender, EventArgs e)
        {
            cbxGames.DroppedDown = true; // Mở danh sách khi di chuột vào Button
            cbxGames.Focus(); // Đảm bảo ComboBox nhận sự kiện
        }

        
        private void cbxGameList_Leave(object sender, EventArgs e)
        {
            cbxGames.DroppedDown = false; // Ẩn danh sách khi mất focus
        }

        ///////////// Nút ALL Menu
        private void btnALLList_MouseEnter(object sender, EventArgs e)
        {
            cbxAll.DroppedDown = true; // Mở danh sách khi di chuột vào Button
            cbxAll.Focus(); // Đảm bảo ComboBox nhận sự kiện
        }

        private void cbxAllList_MouseLeave(object sender, EventArgs e)
        {
            cbxAll.DroppedDown = false; // Ẩn danh sách khi rời chuột khỏi ComboBox
        }



    }
}
