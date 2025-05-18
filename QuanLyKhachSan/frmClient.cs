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
    public partial class frmClient : Form
    {
        // Kết nối tới SQL Server (bạn đổi connection string cho phù hợp)
        string connectionString = @"Data Source=KEBAO-MACBOOK\SQLSEVER;Initial Catalog=QuanLyKhachSan;Integrated Security=True";


        public frmClient()
        {
            InitializeComponent();
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            // Gọi hàm load khách hàng khi form mở
            LoadKhachHang();
        }

        private void LoadKhachHang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM KhachHang";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO KhachHang (HoTen, SoDienThoai, CMND_CCCD, DiaChi, QuocTich, MoTa) " +
                                   "VALUES (@HoTen, @SoDienThoai, @CMND_CCCD, @DiaChi, @QuocTich, @MoTa)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@HoTen", txtTenKH.Text);
                    cmd.Parameters.AddWithValue("@SoDienThoai", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@CMND_CCCD", txtCMND.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                    cmd.Parameters.AddWithValue("@QuocTich", txtQuocTich.Text);
                    cmd.Parameters.AddWithValue("@MoTa", txtLoaiPhong.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadKhachHang(); // Load lại data
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtTenKH.Text = row.Cells["TenKH"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtCMND.Text = row.Cells["CMND"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtQuocTich.Text = row.Cells["QuocTich"].Value.ToString();
                txtGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                txtNgaySinh.Text = row.Cells["NgaySinh"].Value.ToString();
                txtNgayDangKy.Text = row.Cells["NgayDangKy"].Value.ToString();
                txtLoaiPhong.Text = row.Cells["LoaiPhong"].Value.ToString();
                txtSoPhong.Text = row.Cells["SoPhong"].Value.ToString();
                txtGiaTien.Text = row.Cells["GiaTien"].Value.ToString();
            }
        }
    }
}