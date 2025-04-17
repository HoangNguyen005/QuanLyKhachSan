using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Thu vien ket noi sql 
using System.Data.SqlClient;

namespace QuanLyKhachSan
{
    public partial class frmBookingRoom: Form
    {

        //khai báo xâu kết nối tới CSDL
        private string conStr = "Data Source=(local);Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        //định nghĩa đối tượng kết nối với CSDL
        private SqlConnection mySqlConnection;
        //định nghĩa đối tượng truy vấn/cập nhật dữ liệu
        private SqlCommand mySqlCommand;
        public frmBookingRoom()
        {
            InitializeComponent();
        }

        private void LoadDanhSachPhong()
        {
           
            string query = "SELECT * FROM Phong";

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                flowLayoutPanel1.Controls.Clear();

                while (reader.Read())
                {
                    var uc = new ucRoom();
                    uc.MaPhong = reader["MaPhong"].ToString();
                    uc.TrangThai = reader["TrangThai"].ToString();
                    //uc.TenKhach = reader["TenKhach"]?.ToString();
                    //uc.SoNgay = TinhSoNgay(reader["NgayNhan"], reader["NgayTra"]);
                    //uc.DonDep = reader["DaDonDep"].ToString() == "1" ? "Đã dọn dẹp" : "Chưa dọn";

                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
        }


        private void frmBookingRoom_Load(object sender, EventArgs e)
        {
            //kết nối tới CSDL
            mySqlConnection = new SqlConnection(conStr);
            mySqlConnection.Open();
            //hiển thị dữ liệu
            //button1.PerformClick();
            LoadDanhSachPhong();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////định nghĩa xâu truy vấn
            //string sSql;
          
            //    //tìm theo tên người liên lạc
            //    sSql = "SELECT * FROM Phong";
            
            ////truy vấn dữ liệu vào đối tượng SqlDataReader
            //mySqlCommand = new SqlCommand(sSql, mySqlConnection);
            //SqlDataReader drSuppliers = mySqlCommand.ExecuteReader();
            ////chuyển dữ liệu từ đối tượng SqlDataReader sang DataTable để hiển thị lên lưới
            //DataTable dtSupplier = new DataTable();
            //dtSupplier.Load(drSuppliers);
            ////hiển thị dữ liệu từ DataTable lên lưới
            //dataGridView1.DataSource = dtSupplier;
            ////đóng đối tượng DataReader
            //drSuppliers.Close();
        }
    }
}
