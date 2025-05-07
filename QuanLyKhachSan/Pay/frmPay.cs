using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Guna.UI2.WinForms;

namespace QuanLyKhachSan
{
    public partial class frmPay: Form
    {
        //khai báo xâu kết nối tới CSDL
        private string conStr = "Data Source=(local);Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        //định nghĩa đối tượng kết nối với CSDL
        private SqlConnection mySqlConnection;
        //định nghĩa đối tượng truy vấn/cập nhật dữ liệu
        private SqlCommand mySqlCommand;
        private SqlDataAdapter mySqlDataAdapter;
        private SqlCommandBuilder mySqlCommandBuilder;
        //Khai báo đối tượng để lưu dữ liệu của bảng Customer trên form
        private DataTable dtCustomer;
        //khai báo biến để kiểm tra đã <thêm mới> hay sửa
        private bool modeNew;

        private string category = "";
        private string status = "";
        private string floor = "";

        public frmPay()
        {
            InitializeComponent();
        }

        private void LoadDanhSachPhong(int CheDo = 0)
        {

            string query = "";

            if ((txtSearch.Text == "") && (CheDo == 0))//Tìm mặc định
            {
                query = "SELECT p.* , ttp.TrangThai FROM Phong p join TrangThaiPhong ttp on p.MaPhong=ttp.MaPhong";
            }
            else//Tìm phòng đang ss
                if (CheDo == 1)
            {
                query = "SELECT p.* , ttp.TrangThai FROM Phong p join TrangThaiPhong ttp on p.MaPhong=ttp.MaPhong where ttp.TrangThai = N'Đang sử dụng'";
            }
            else
                   if (CheDo == 2)//tìm phòng trống
            {
                query = "SELECT p.* , ttp.TrangThai FROM Phong p join TrangThaiPhong ttp on p.MaPhong=ttp.MaPhong where ttp.TrangThai  = N'Trống'";
            }
            //= mã phong hoặc loại
            else query = "SELECT p.* , ttp.TrangThai FROM Phong p join TrangThaiPhong ttp on p.MaPhong=ttp.MaPhong  WHERE  (p.MaPhong LIKE N'%" + txtSearch.Text + "%')or (p.LoaiPhong LIKE N'%" + txtSearch.Text + "%') or (ttp.TrangThai LIKE N'%" + txtSearch.Text + "%') ";

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                flowLayoutPanel1.Controls.Clear();
                while (reader.Read())
                {
                    var uc = new UsPay();
                    uc.MaPhong = reader["MaPhong"].ToString();
                    uc.TrangThai = reader["TrangThai"].ToString();
                    uc.LoaiPhong = reader["LoaiPhong"].ToString();

                    flowLayoutPanel1.Controls.Add(uc);
                    // Đổi màu buttom
                    btnDichVu.FillColor = Color.Gray;
                    btnPhong.FillColor = Color.White;
                    btnDichVu.ForeColor = Color.White;
                    btnPhong.ForeColor = Color.Black;
                    btnThanhToan.Enabled = false;
                    btnThanhToan.FillColor = Color.LightGray; // Làm màu mờ đi (tuỳ chỉnh)
                    btnThanhToan.ForeColor = Color.DarkGray;  // Làm màu chữ nhạt đi

                }
            }
        }
        private void LoadDanhSachDichVu()
        {
            flowLayoutPanel1.Controls.Clear();
            string query = "";

            if (txtTimKiemDichVu.Text == "")
            {
                query = "SELECT dv.MaDichVu,dv.TenDichVu,dv.DonGia from DichVu dv  ";
            }

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                flowLayoutPanel1.Controls.Clear();

                while (reader.Read())
                {
                    var us = new UsDichVuPay();
                    us.MaDichVu = reader["MaDichVu"].ToString();
                    us.TenDichVu = reader["TenDichVu"].ToString();
                    us.DonGia = reader["DonGia"].ToString();

                    flowLayoutPanel1.Controls.Add(us);
                    //Màu buttom
                    btnDichVu.FillColor = Color.White;
                    btnPhong.FillColor = Color.Gray;
                    btnDichVu.ForeColor = Color.Black;
                    btnPhong.ForeColor = Color.White;
                }
            }
        }

        private void frmPay_Load(object sender, EventArgs e)
        {
            //kết nối tới CSDL
           // mySqlConnection = new SqlConnection(conStr);
          //  mySqlConnection.Open();

            //hiển thị các phòng
            LoadDanhSachPhong(0);
            // panel_Load();
        }
        //table dung chung cho
        private DataTable dt;

        public void LoadDataPhong()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                string sql = $"SELECT p.* FROM Phong p  where p.MaPhong = {Global.ROOM_CODE}";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        guna2DataGridView1.DataSource = dt;
                        LoadUse();


                    }
                }
            }
        }

        private void LoadUse()
        {
            string sql = @"
        SELECT kh.*, p.GiaPhong, p.MaPhong, ctd.MaHoaDon
        FROM TrangThaiPhong ttp
        INNER JOIN Phong p ON ttp.MaPhong = p.MaPhong
        INNER JOIN ChiTietDatPhong ctd ON p.MaPhong = ctd.MaPhong
        INNER JOIN DatPhong dp ON ctd.MaDatPhong = dp.MaDatPhong
        INNER JOIN KhachHang kh ON dp.MaKhachHang = kh.MaKhachHang
        WHERE ctd.MaPhong = @MaPhong AND ctd.TrangThai = 0";

            try
            {
                using (SqlConnection conn = new SqlConnection(conStr))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaPhong", Global.ROOM_CODE);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            txtCustomerName.Text = dt.Rows[0]["HoTen"].ToString();
                            txtPhoneNumber.Text = dt.Rows[0]["SoDienThoai"].ToString();
                            txtIDCard.Text = dt.Rows[0]["CMND_CCCD"].ToString();
                            txtTenPhong.Text = dt.Rows[0]["MaPhong"].ToString();
                            txtHoaDon.Text = dt.Rows[0]["MaHoaDon"].ToString();

                            //loadTongTien();   // Nếu muốn tính lại tổng tiền
                            loadDichVu();      // Gọi hàm load dịch vụ
                        }
                        else
                        {
                            txtCustomerName.Text = "";
                            txtPhoneNumber.Text = "";
                            txtIDCard.Text = "";
                            txtTongTien.Text = "";
                            txtTenPhong.Text = "";
                            txtHoaDon.Text = "";
                            guna2DataGridView2.DataSource = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin khách hàng: " + ex.Message);
            }
        }

        int MaHoaDonn;
        private void LoadTongTien()
        {
            string sql = @"
        SELECT tt.TongTien, tt.MaHoaDon
        FROM TrangThaiPhong ttp
        INNER JOIN Phong p ON ttp.MaPhong = p.MaPhong
        INNER JOIN ChiTietDatPhong ctd ON p.MaPhong = ctd.MaPhong
        INNER JOIN HoaDon hd ON ctd.MaHoaDon = hd.MaHoaDon
        INNER JOIN ThanhToan tt ON hd.MaHoaDon = tt.MaHoaDon
        WHERE ctd.MaPhong = @MaPhong AND ctd.TrangThai = 0";

            using (SqlConnection conn = new SqlConnection(conStr)) // hoặc mySqlConnection nếu cố định
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaPhong", Global.ROOM_CODE);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        decimal tongTien = Convert.ToDecimal(dt.Rows[0]["TongTien"]);
                        txtTongTien.Text = tongTien.ToString("N0");
                        MaHoaDonn = Convert.ToInt32(dt.Rows[0]["MaHoaDon"]);
                        btnThanhToan.Enabled = true;
                        btnThanhToan.FillColor = Color. ForestGreen; // màu gốc bạn dùng
                        btnThanhToan.ForeColor = Color. White;

                    }
                    else
                    {
                        txtTongTien.Text = "0";
                    }
                }
            }
        }



        public void ThemDichVu()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                string sql2 = $"SELECT cth.MaHoaDon, dv.MaDichVu " + // <- thêm dấu cách cuối dòng này
                "FROM ChiTietDatPhong ctd " +
                "INNER JOIN HoaDon hd ON ctd.MaHoaDon = hd.MaHoaDon " +
                "INNER JOIN ChiTietHoaDon cth ON hd.MaHoaDon = cth.MaHoaDon " +
                "INNER JOIN DichVu dv ON cth.MaDichVu = dv.MaDichVu " +
                $"WHERE ctd.MaPhong = {Global.ROOM_CODE} AND ctd.TrangThai = 0";


                using (SqlCommand cmd1 = new SqlCommand(sql2, conn))
                {
                    using (SqlDataReader reader = cmd1.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        if (dt.Rows.Count > 0)
                        {
                            int maHoaDon = Convert.ToInt32(dt.Rows[0]["MaHoaDon"]);
                            int maDichVu = Global.MaDichVu;// Giả sử label chứa mã dịch vụ

                            // Lúc này mới mở kết nối thêm (nếu cần)
                            using (SqlCommand cmd2 = new SqlCommand("sp_ThemDichVuVaoHoaDon", conn))
                            {
                                cmd2.CommandType = CommandType.StoredProcedure;
                                cmd2.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                                cmd2.Parameters.AddWithValue("@MaDichVu", maDichVu);

                                try
                                {
                                    cmd2.ExecuteNonQuery();
                                    MessageBox.Show("Thêm dịch vụ thành công!");
                                    this.loadDichVu(); // Không cần cast ParentForm
                                    LoadTongTien();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("MaDichVu: " + Global.MaDichVu);

                                    MessageBox.Show("Lỗi: " + ex.Message);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("MaDichVu: " + Global.MaDichVu);

                            MessageBox.Show("Không tìm thấy hóa đơn hoặc dịch vụ.");
                        }
                    }
                }

            }
        }


        public void loadDichVu()
        {

            using (SqlConnection conn = new SqlConnection(conStr/*connectionString*/))
            {
                conn.Open();
                string sql = $"SELECT dv.TenDichVu, cth.SoLuong, dv.DonGia " +
                $"FROM ChiTietDatPhong ctd " +
                $"INNER JOIN HoaDon hd ON ctd.MaHoaDon = hd.MaHoaDon " +
                $"INNER JOIN ChiTietHoaDon cth ON hd.MaHoaDon = cth.MaHoaDon " +
                $"INNER JOIN DichVu dv ON cth.MaDichVu = dv.MaDichVu " +
                $"WHERE ctd.MaPhong = {Global.ROOM_CODE} AND ctd.TrangThai = 0";


                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        guna2DataGridView2.DataSource = dt;
                        LoadTongTien();



                    }
                }
            }
        }
        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            //string connectionString = "Data Source=(local);Initial Catalog=QuanLyKhachSan;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_CapNhatDaThanhToan", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHoaDon", MaHoaDonn);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thanh toán thành công!");
                        LoadDanhSachPhong();
                        loadDichVu();
                        LoadUse();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xác nhận thanh toán: " + ex.Message);
                    }
                }
            }
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            LoadDanhSachPhong();
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text != null)
            {
                flowLayoutPanel1.Controls.Clear();
                LoadDanhSachDichVu();

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();

            foreach (System.Windows.Forms.Control ctrl in flowLayoutPanel1.Controls)
            {
                if (ctrl is UsPay room)
                {
                    // Giả sử tìm theo Mã phòng hoặc Loại phòng
                    string maPhong = room.MaPhong.ToLower();
                    string loaiPhong = room.LoaiPhong.ToLower();

                    // Kiểm tra nếu chuỗi nhập vào có chứa MaPhong hoặc LoaiPhong
                    if (maPhong.Contains(searchText) || loaiPhong.Contains(searchText))
                    {
                        room.Visible = true; // Hiện phòng
                    }
                    else
                    {
                        room.Visible = false; // Ẩn phòng
                    }
                }
            }
        }

        private void btnShearch_Click(object sender, EventArgs e)
        {

        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadDanhSachPhong(0);
        }

        private void btnSuDung_Click(object sender, EventArgs e)
        {
            LoadDanhSachPhong(1);
        }

        private void BtnChuaSuDung_Click(object sender, EventArgs e)
        {
            LoadDanhSachPhong(2);
        }

        private void txtTenPhong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTimKiemDichVu_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();

            foreach (System.Windows.Forms.Control ctrl in flowLayoutPanel1.Controls)
            {
                if (ctrl is UsDichVuPay roomm)
                {
                    // Giả sử tìm theo Mã phòng hoặc Loại phòng
                    string MaDichVu = roomm.MaDichVu.ToLower();
                    string TenDichVu = roomm.TenDichVu.ToLower();

                    // Kiểm tra nếu chuỗi nhập vào có chứa MaPhong hoặc LoaiPhong
                    if (MaDichVu.Contains(searchText) || TenDichVu.Contains(searchText))
                    {
                        roomm.Visible = true; // Hiện phòng
                    }
                    else
                    {
                        roomm.Visible = false; // Ẩn phòng
                    }
                }
            }
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDCard_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpCheckIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpCheckOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            // Tính kích thước văn bản
            Size size = TextRenderer.MeasureText(txtTongTien.Text, txtTongTien.Font);

            // Cập nhật chiều rộng (thêm padding nếu cần)
            txtTongTien.Width = size.Width + 15;
        }

        private void txtHoaDon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
