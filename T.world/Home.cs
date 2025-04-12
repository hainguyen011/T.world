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
            // Lấy kích thước màn hình
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            // Kích thước form mong muốn (80%)
            int formWidth = (int)(screenWidth * 0.8);
            int formHeight = (int)(screenHeight * 0.8);

            // Gán kích thước
            this.Width = formWidth;
            this.Height = formHeight;

            // Tính toán vị trí để căn giữa
            int posX = (screenWidth - formWidth) / 2;
            int posY = (screenHeight - formHeight) / 2;

            // Gán vị trí
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(posX, posY);

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

        private void btnGameList_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
