using QuanLyKhachSan.Pay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyKhachSan
{
    public partial class frmHome: Form
    {
        //khai báo xâu kết nối tới CSDL
        private string conStr = "Data Source=(local);Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        //định nghĩa đối tượng kết nối với CSDL
        private SqlConnection mySqlConnection;
        //định nghĩa đối tượng truy vấn/cập nhật dữ liệu
        private SqlCommand mySqlCommand;
        
        public frmHome()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void statusRoom()
        {
            mySqlConnection = new SqlConnection(conStr);
            mySqlConnection.Open();

            string query = "SELECT count(dbo.Phong.MaPhong) as 'fullRoom'\r\nFROM     dbo.TrangThaiPhong INNER JOIN\r\n                  dbo.Phong ON dbo.TrangThaiPhong.MaPhong = dbo.Phong.MaPhong\r\n\t\t\t\t  where dbo.TrangThaiPhong.TrangThai = N'Đang sử dụng'";
            mySqlCommand = new SqlCommand(query, mySqlConnection);
            SqlDataReader reader = mySqlCommand.ExecuteReader();
            string fullRoom = "";
            string allRoom = "";
            while( reader.Read())
            {
                fullRoom = reader["fullRoom"].ToString();
            }
            reader.Close();

            query = "select count(dbo.Phong.MaPhong) as 'allRoom' from dbo.Phong";
            mySqlCommand = new SqlCommand(query, mySqlConnection);
            reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                allRoom = reader["allRoom"].ToString();
            }

            lbFullRoom.Text = $"{fullRoom}/{allRoom}";
            //fullRoom;
            //lbAllRoom.Text = allRoom;
            lbname.Text=  Global.AUTHORIZATION;

        }

        private void statusEmployee()
        {
            mySqlConnection = new SqlConnection(conStr);
            mySqlConnection.Open();

            string query = "select count(MaNhanVien) as 'on' from dbo.NhanVien where dbo.NhanVien.MoTa is null";
            mySqlCommand = new SqlCommand(query, mySqlConnection);
            SqlDataReader reader = mySqlCommand.ExecuteReader();
            string daNghi = "";
            string allEmployee = "";
            while (reader.Read())
            {
                daNghi = reader["on"].ToString();
            }
            reader.Close();

            query = "select count(MaNhanVien) as 'allEmployee' from dbo.NhanVien";
            mySqlCommand = new SqlCommand(query, mySqlConnection);
            reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                allEmployee = reader["allEmployee"].ToString();
            }

            lbNghi.Text = $"{daNghi}/{allEmployee}";
                //daNghi;
            //lbAllEmployee.Text = allEmployee;

        }

        private void hoadon()
        {
            mySqlConnection = new SqlConnection(conStr);
            mySqlConnection.Open();

            string query = "select count(MaHoaDon) as 'count' from dbo.HoaDon";
            mySqlCommand = new SqlCommand(query, mySqlConnection);
            SqlDataReader reader = mySqlCommand.ExecuteReader();
           
            while (reader.Read())
            {
                lbHoaDon.Text = reader["count"].ToString();
            }
        }

        private void LoadThongBao()
        {

            string query = "";
            query = $"SELECT * FROM ThongBao";



            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                flowLayoutPanel1.Controls.Clear();

                while (reader.Read())
                {
                    var uc = new UsHome();
                    uc.Name = reader["MaThongBao"].ToString();
                    uc.NoiDung = reader["NoiDung"].ToString();


                    flowLayoutPanel1.Controls.Add(uc);
                }

            }
        }
        private void VatTu()
        {
            mySqlConnection = new SqlConnection(conStr);
            mySqlConnection.Open();

            string query = "select count(MaDichVu) as 'count' from dbo.DichVu";
            mySqlCommand = new SqlCommand(query, mySqlConnection);
            SqlDataReader reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                lbVatTu.Text =  $"{reader["count"].ToString()}%";
                progress.Value = int.Parse(reader["count"].ToString());
            }
            
        }


        private void frmHome_Load(object sender, EventArgs e)
        {
            statusRoom();
            statusEmployee();
            hoadon();
            LoadThongBao();
            VatTu();
            BieuDo();
        }

        private void BieuDo()
        {
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();

            // 2. Truy vấn doanh thu theo tháng
            string query = @"
        SELECT 
    MONTH(NgayThanhToan) AS Thang, 
    SUM(ISNULL(TongTien, 0)) AS DoanhThu
FROM ThanhToan
GROUP BY MONTH(NgayThanhToan)
ORDER BY Thang";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Legends.Clear(); // ❌ Xóa phần chú thích "Series1"

            ChartArea area = new ChartArea("DoanhThuArea");
            area.AxisX.MajorGrid.Enabled = false;   // ❌ Tắt grid dọc
            area.AxisY.MajorGrid.Enabled = false;   // ❌ Tắt grid ngang
            area.AxisX.LineWidth = 0;               // ❌ Tắt đường trục X
            area.AxisY.LineWidth = 0;               // ❌ Tắt đường trục Y
            area.AxisY.LabelStyle.Enabled = false;  // ❌ Ẩn số trục Y
            area.BackColor = Color.White;
            chart1.ChartAreas.Add(area);

            Series series = new Series("Doanh thu")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Teal,
                IsValueShownAsLabel = true,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                LabelForeColor = Color.Black,
                LabelFormat = "#,##0",
            };

            while (reader.Read())
            {
                // Kiểm tra nếu tháng hoặc doanh thu bị NULL thì bỏ qua dòng đó
                if (reader.IsDBNull(0) || reader.IsDBNull(1))
                    continue;

                string thang = "Tháng " + reader.GetInt32(0).ToString();
                double doanhThu = Convert.ToDouble(reader[1]);
                series.Points.AddXY(thang, doanhThu);
            }

            chart1.Series.Add(series);
        }


        
        

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

           
        }

        private void guna2Shapes1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form DoanhThu = new frmDoanhThu();
            DoanhThu.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbNghi_Click(object sender, EventArgs e)
        {

        }

        private void lbDangXuat_Click(object sender, EventArgs e)
        {
            ((frmMain)this.ParentForm).Close1();
        }

        private void lbVatTu_Click(object sender, EventArgs e)
        {

        }
    }
}
