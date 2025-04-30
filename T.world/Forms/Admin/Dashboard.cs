using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using T.world.Shared.Models;

namespace T.world.Forms.Admin
{
    public partial class Dashboard: Form
    {
        public Dashboard()
        {
            InitializeComponent();
            
        }
        

    


    private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        // Khi người dùng nhấn vào ô tìm kiếm
        private void txtSearch_GotFocus(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        // Khi người dùng rời khỏi ô tìm kiếm
        private void txtSearch_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search...";
                txtSearch.ForeColor = Color.Gray;
            }
        }
        private int GetUserCount()
        {
            using (var db = new TworldDBEntities())
            {
                return db.Accounts.Count(a => a.role == "USER");
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Xóa dữ liệu cũ
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            // Tạo vùng vẽ
            ChartArea chartArea = new ChartArea("MainArea");
            chart1.ChartAreas.Add(chartArea);

            // Tạo Series kiểu Line
            Series series = new Series("Số lượng bán");
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 2;
            series.Color = Color.Blue;

            // Thêm dữ liệu (giả lập)
            series.Points.AddXY("T1", 10);
            series.Points.AddXY("T2", 20);
            series.Points.AddXY("T3", 15);
            series.Points.AddXY("T4", 25);
            series.Points.AddXY("T5", 18);

            // Thêm series vào biểu đồ
            chart1.Series.Add(series);

            // Cấu hình trục
            chart1.ChartAreas[0].AxisX.Title = "Tháng";
            chart1.ChartAreas[0].AxisY.Title = "Số lượng";

            // Hiển thị Gridline mờ
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            // Hiển thị số lượng user
            
            int userCount = GetUserCount();
            lbTotaluser.Text = userCount.ToString();
        

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void lbTotaluser_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
