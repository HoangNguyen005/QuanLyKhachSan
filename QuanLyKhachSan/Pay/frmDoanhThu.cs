using Guna.UI2.WinForms;
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
    public partial class frmDoanhThu: Form
    {
        public frmDoanhThu()
        {
            InitializeComponent();
        }
        private string conStr = "Data Source=(local);Initial Catalog=QuanLyKhachSan;Integrated Security=True";

        private void btnXemDoanhThu_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = @"
        SELECT 
            hd.MaHoaDon, 
            kh.HoTen, 
            hd.NgayLap, 
            ISNULL(SUM(tt.TongTien), 0) AS TongTien
        FROM HoaDon hd
        JOIN ThanhToan tt ON hd.MaHoaDon = tt.MaHoaDon
        JOIN ChiTietDatPhong ctdp ON hd.MaHoaDon = ctdp.MaHoaDon
        JOIN DatPhong dp ON ctdp.MaDatPhong = dp.MaDatPhong
        JOIN KhachHang kh ON dp.MaKhachHang = kh.MaKhachHang
        WHERE CAST(tt.NgayThanhToan AS DATE) = @Ngay
        GROUP BY hd.MaHoaDon, hd.NgayLap, kh.HoTen
    ";

            using (SqlConnection conn = new SqlConnection(conStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@Ngay", dtpNgay.Value.Date);
                conn.Open();
                adapter.Fill(dt);
            }

            dvgHoaDon.DataSource = dt;

            if (dvgHoaDon.Columns.Contains("TongTien"))
            {
                dvgHoaDon.Columns["TongTien"].DefaultCellStyle.Format = "c0";
                dvgHoaDon.Columns["TongTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            // Tính tổng doanh thu
            decimal tong = 0;
            foreach (DataRow row in dt.Rows)
            {
                tong += Convert.ToDecimal(row["TongTien"]);
            }

            guna2TextBox1.Text = tong.ToString("N0") + " VNĐ";
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            dtpNgay.Value = DateTime.Now;
            btnXemDoanhThu.PerformClick();
        }

        /*private void btnXemDoanhThu_Click(object sender, EventArgs e)
        {

        }*/

        private void dvgHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // đảm bảo không phải header
            {
                // Lấy mã hóa đơn từ cột đầu tiên (giả sử là "MaHoaDon")
                string maHoaDon = dvgHoaDon.Rows[e.RowIndex].Cells["MaHoaDon"].Value.ToString();

                // Mở form hóa đơn
                frmHoaDon HoaDon = new frmHoaDon(int.Parse(maHoaDon));
               // HoaDon.MaHoaDon = int.Parse(maHoaDon); // gán mã hóa đơn cho form
                HoaDon.ShowDialog();
            }
        }
    }
}
