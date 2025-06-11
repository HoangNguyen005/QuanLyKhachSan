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

namespace QuanLyKhachSan.DichVu
{
    public partial class frmDichVu : Form
    {
        private string conStr = "Data Source=(local);Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        public frmDichVu()
        {
            InitializeComponent();
          //  guna2Panel1.Size = new Size(1008, 645);
        }
        private void LoadDichVu()
        {
            flowLayoutPanel1.Controls.Clear();
            string query = "";

            // if (txtTimKiemDichVu.Text == "")
            //{
            query = "SELECT * from DichVu  ";
            // }

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                flowLayoutPanel1.Controls.Clear();

                while (reader.Read())
                {
                    var us = new UsDichVuPay();
                    us.CheDo = 1;
                    us.MaDichVu = reader["MaDichVu"].ToString();
                    us.TenDichVu = reader["TenDichVu"].ToString();
                    us.DonGia = reader["DonGia"].ToString();

                    flowLayoutPanel1.Controls.Add(us);
                }
                conn.Close();
            }

        }
        public void LoadDuLieu()
        {
            btnHoanThanh.Text = "Lưu";
                
                string sql = $"SELECT dv.* FROM DichVu dv  WHERE dv.MaDichVu = {Global.MaDichVu}";


                using (SqlConnection conn = new SqlConnection(conStr))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    //cmd.Parameters.AddWithValue("@MaPhong", Global.ROOM_CODE);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                    adapter.Fill(dt); 
                    if (dt.Rows.Count > 0)
                        {
                            txtTen.Text = dt.Rows[0]["TenDichVu"].ToString();
                            txtGia.Text = dt.Rows[0]["DonGia"].ToString();
                            txtMoTa.Text = dt.Rows[0]["MoTa"].ToString();


                        }
                         else MessageBox.Show("Lỗi: " );
                }
                    conn.Close();
                }
            }
        
        private void frmDichVu_Load(object sender, EventArgs e)
        {
            LoadDichVu();
            //LoadDuLieu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            guna2Panel1.Size = new Size(407, 645);

            guna2Panel2.Visible = true;
            guna2Panel2.Location = new Point(425, 41);
            guna2Panel2.Size = new Size(608, 645);
            btnHoanThanh.Text = "Thêm";
            txtTen.Text = "";
            txtGia.Text = "";
            txtMoTa.Text = "";
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            if (btnHoanThanh.Text == "Lưu")
            {
                string sql = @"UPDATE DichVu 
                       SET TenDichVu = @TenDichVu, 
                           DonGia = @DonGia, 
                           MoTa = @MoTa 
                       WHERE MaDichVu = @MaDichVu";

                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        // Gán tham số
                        cmd.Parameters.AddWithValue("@TenDichVu", txtTen.Text);
                        cmd.Parameters.AddWithValue("@DonGia", decimal.Parse(txtGia.Text)); // nên kiểm tra parse
                        cmd.Parameters.AddWithValue("@MoTa", txtMoTa.Text);
                        cmd.Parameters.AddWithValue("@MaDichVu", Global.MaDichVu);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Chỉnh sửa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDichVu();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy dịch vụ để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            if (btnHoanThanh.Text == "Thêm")
            {
                string sql = @"INSERT INTO DichVu (TenDichVu, DonGia, MoTa)
                   VALUES (@TenDichVu, @DonGia, @MoTa)";

                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            // Gán tham số
                            cmd.Parameters.AddWithValue("@TenDichVu", txtTen.Text);
                            cmd.Parameters.AddWithValue("@DonGia", decimal.Parse(txtGia.Text)); // kiểm tra trước khi parse
                            cmd.Parameters.AddWithValue("@MoTa", txtMoTa.Text);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Thêm dịch vụ mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Không thể thêm dịch vụ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Giá dịch vụ không hợp lệ. Vui lòng nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LoadDichVu();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
