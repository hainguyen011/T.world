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
            // Hiển thị ComboBox và mở danh sách lựa chọn
            cmbMenu.Visible = true;
            cmbMenu.DroppedDown = true;
        }

        private void cmbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ẩn ComboBox khi rời chuột
            cmbMenu.Visible = false;
        }

        private void cbxMenu_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return; // Tránh lỗi khi danh sách rỗng

            // Chọn màu nền
            e.Graphics.FillRectangle(Brushes.LightBlue, e.Bounds);

            // Chọn màu chữ
            using (Brush brush = new SolidBrush(Color.Black))
            {
                e.Graphics.DrawString(cmbMenu.Items[e.Index].ToString(),
                                      e.Font,
                                      brush,
                                      e.Bounds);
            }

            e.DrawFocusRectangle(); // Hiển thị focus khi chọn
        }
        private void cbxMenu_MouseEnter(object sender, EventArgs e)
        {
            cmbMenu.DroppedDown = true; // Mở danh sách khi đưa chuột vào
        }

        private void cbxMenu_MouseLeave(object sender, EventArgs e)
        {
            cmbMenu.DroppedDown = false; // Ẩn danh sách khi rời chuột
        }

    }
}
