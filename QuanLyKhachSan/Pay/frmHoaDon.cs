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

namespace QuanLyKhachSan.Pay
{
    public partial class frmHoaDon : Form
    {
        private int maHoaDon;
        public frmHoaDon(int MaHoaDon)
        {
            InitializeComponent();
            maHoaDon = MaHoaDon;
        }
        private string conStr = "Data Source=(local);Initial Catalog=QuanLyKhachSan;Integrated Security=True";

        public DataTable GetChiTietHoaDon(int maHoaDon)
        {
            DataTable dt = new DataTable();

            string query = @"
                SELECT Ten, SoLuong, DonGia, ThanhTien 
                FROM dbo.fn_ChiTietHoaDon(@MaHoaDon)
                ORDER BY Loai, Ten";

            using (SqlConnection conn = new SqlConnection(conStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                conn.Open();
                adapter.Fill(dt);
            }

            return dt;
        }

        private void LoadChiTietHoaDon(int maHoaDon)
        {
            DataTable dt = GetChiTietHoaDon(maHoaDon);
            guna2DataGridView1.DataSource = dt;

        }
        public void LoadThongTinHoaDon(int maHoaDon)
        {
            string query = @"
        SELECT 
            hd.MaHoaDon,
            hd.NgayLap,
            kh.HoTen,
            kh.SoDienThoai,
            (SELECT SUM(ThanhTien) FROM dbo.fn_ChiTietHoaDon(@MaHoaDon)) AS TongTien
        FROM KhachHang kh 
        JOIN DatPhong dp ON kh.MaKhachHang = dp.MaKhachHang
        JOIN ChiTietDatPhong ctd ON dp.MaDatPhong = ctd.MaDatPhong
        JOIN HoaDon hd ON ctd.MaHoaDon = hd.MaHoaDon
        WHERE hd.MaHoaDon = @MaHoaDon
    ";

            using (SqlConnection conn = new SqlConnection(conStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtMHoaDon.Text = $"HD{reader["MaHoaDon"].ToString()}";
                        txtNgay.Text = Convert.ToDateTime(reader["NgayLap"]).ToShortDateString();
                        txtTen.Text = reader["HoTen"].ToString();
                        txtSDT.Text = reader["SoDienThoai"].ToString();

                        decimal tongTien = Convert.ToDecimal(reader["TongTien"]);
                        txtTongTien.Text = tongTien.ToString("N0");

                        decimal chietKhau = 0;
                        decimal thanhToan = tongTien - tongTien * (chietKhau / 100);
                        txtTongTienTT.Text = thanhToan.ToString("N0");
                    }
                }
            }
        }




        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoadChiTietHoaDon(maHoaDon);
            LoadThongTinHoaDon(maHoaDon);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTongTienTT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
