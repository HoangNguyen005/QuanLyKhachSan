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

        private string category = "";
        private string status = "";
        private string floor = "";
        
        public frmBookingRoom()
        {
            InitializeComponent();
        }

        private void LoadDanhSachPhong(int roomNumber = 0, string category = "", string status = "", string floor = "")
        {
           
            string query = "";

            if (category == "" && status == "" && floor == "")
            {
                query = "SELECT dbo.Phong.*, dbo.TrangThaiPhong.TrangThai\r\nFROM     dbo.Phong INNER JOIN\r\n                  dbo.TrangThaiPhong ON dbo.Phong.MaPhong = dbo.TrangThaiPhong.MaPhong";
            }
            if (category != "" || status != "" || floor != "")
            {
                query = $"SELECT dbo.Phong.*, dbo.TrangThaiPhong.TrangThai\r\nFROM     dbo.Phong INNER JOIN\r\n                  dbo.TrangThaiPhong ON dbo.Phong.MaPhong = dbo.TrangThaiPhong.MaPhong WHERE LoaiPhong LIKE  N'%{category}' AND TrangThai LIKE N'%{status}' AND Tang LIKE '%{floor}'";
            }

            if (roomNumber != 0)
            {
                query = $"SELECT * FROM Phong WHERE MaPhong = {roomNumber}";
            }
           

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
                        uc.LoaiPhong = reader["LoaiPhong"].ToString();

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            category = cbCategory.Text;
            LoadDanhSachPhong(0, category, status, floor);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            status = cbStatus.Text;
            LoadDanhSachPhong(0, category, status, floor);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbSearchRoomNumber.Text.Trim() == "")
            {
                LoadDanhSachPhong();
                tbSearchRoomNumber.Clear();
                return;
            }
            LoadDanhSachPhong(int.Parse(tbSearchRoomNumber.Text.Trim()));
            tbSearchRoomNumber.Clear();

        }

        private void tbSearchRoomNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSearchRoomNumber_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                LoadDanhSachPhong(int.Parse(tbSearchRoomNumber.Text.Trim()));
            }
        }

        private void cbFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            floor = cbFloor.Text;
            LoadDanhSachPhong(0, category, status, floor);

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
              
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadDanhSachPhong();
        }
    }
}
