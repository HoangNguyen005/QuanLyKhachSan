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


        private void frmHome_Load(object sender, EventArgs e)
        {
            statusRoom();
            statusEmployee();
            hoadon();
            LoadThongBao();
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
    }
}
