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
        //string connectionString = @"Data Source=KEBAO-MACBOOK\SQLSEVER;Initial Catalog=QuanLyKhachSan;Integrated Security=True";

        //khai báo xâu kết nối tới CSDL
        private string conStr = "Data Source=(local);Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        //định nghĩa đối tượng kết nối với CSDL
        private SqlConnection mySqlConnection;
        //định nghĩa đối tượng truy vấn/cập nhật dữ liệu
        private SqlCommand mySqlCommand;

        private string cusID = "";

        public frmClient()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            mySqlConnection = new SqlConnection(conStr);
            mySqlConnection.Open();
            string sSql = "SELECT * FROM KhachHang";

            //truy vấn dữ liệu vào đối tượng SqlDataReader
            mySqlCommand = new SqlCommand(sSql, mySqlConnection);
            SqlDataReader drSuppliers = mySqlCommand.ExecuteReader();
            //chuyển dữ liệu từ đối tượng SqlDataReader sang DataTable để hiển thị lên lưới
            DataTable dtSupplier = new DataTable();
            dtSupplier.Load(drSuppliers);
            //hiển thị dữ liệu từ DataTable lên lưới
            dataGridView1.DataSource = dtSupplier;
            //đóng đối tượng DataReader
            drSuppliers.Close();
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            // Gọi hàm load khách hàng khi form mở
            loadData();
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
            //try
            //{
            //    using (SqlConnection conn = new SqlConnection(conStr))
            //    {
            //        conn.Open();
            //        string query = "INSERT INTO KhachHang (HoTen, SoDienThoai, CMND_CCCD, DiaChi, QuocTich, MoTa) " +
            //                       "VALUES (@HoTen, @SoDienThoai, @CMND_CCCD, @DiaChi, @QuocTich, @MoTa)";

            //        SqlCommand cmd = new SqlCommand(query, conn);
            //        cmd.Parameters.AddWithValue("@HoTen", txtTenKH.Text);
            //        cmd.Parameters.AddWithValue("@SoDienThoai", txtSDT.Text);
            //        cmd.Parameters.AddWithValue("@CMND_CCCD", txtCMND.Text);
            //        cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
            //        cmd.Parameters.AddWithValue("@QuocTich", txtQuocTich.Text);
            //        //cmd.Parameters.AddWithValue("@MoTa", txtLoaiPhong.Text);

            //        cmd.ExecuteNonQuery();
            //        MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        LoadKhachHang(); // Load lại data
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi: " + ex.Message);
            //}
        }


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            //    txtTenKH.Text = row.Cells["TenKH"].Value.ToString();
            //    txtSDT.Text = row.Cells["SDT"].Value.ToString();
            //    txtCMND.Text = row.Cells["CMND"].Value.ToString();
            //    txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            //    txtQuocTich.Text = row.Cells["QuocTich"].Value.ToString();
            
            //    txtNgayDangKy.Text = row.Cells["NgayDangKy"].Value.ToString();
            //    //txtLoaiPhong.Text = row.Cells["LoaiPhong"].Value.ToString();
            //    txtSoPhong.Text = row.Cells["SoPhong"].Value.ToString();
            //    //txtGiaTien.Text = row.Cells["GiaTien"].Value.ToString();
            //}
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                cusID = dataGridView1.Rows[r].Cells["MaKhachHang"].Value.ToString();
                customeName.Text = dataGridView1.Rows[r].Cells["HoTen"].Value.ToString();
                phoneNumber.Text = dataGridView1.Rows[r].Cells["SoDienThoai"].Value.ToString();
                customeID.Text = dataGridView1.Rows[r].Cells["CMND_CCCD"].Value.ToString();
                nationality.Text = dataGridView1.Rows[r].Cells["QuocTich"].Value.ToString();
                address.Text = dataGridView1.Rows[r].Cells["DiaChi"].Value.ToString();
                customeName.Text = dataGridView1.Rows[r].Cells["HoTen"].Value.ToString();
            }
        }

        //Delete customer
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = new DialogResult();
            confirm = MessageBox.Show("Chắc chắn muốn xóa khách hàng này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;
            try
            {
                mySqlConnection = new SqlConnection(conStr);
                mySqlConnection.Open();
                string query = $"exec deleteCus {int.Parse(cusID)}";
                mySqlCommand = new SqlCommand(query, mySqlConnection);
                mySqlCommand.ExecuteReader();
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnRecord_Click(object sender, EventArgs e)
        {

        }
    }
}