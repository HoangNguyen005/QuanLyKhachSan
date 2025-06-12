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
using QuanLyKhachSan.Pay;

namespace QuanLyKhachSan
{
    public partial class frmPay : Form
    {
        //khai báo xâu kết nối tới CSDL
        private string conStr = "Data Source=(local);Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        //định nghĩa đối tượng kết nối với CSDL
        //private SqlConnection mySqlConnection;
        //định nghĩa đối tượng truy vấn/cập nhật dữ liệu
        //private SqlCommand mySqlCommand;
        // private SqlDataAdapter mySqlDataAdapter;
        // private SqlCommandBuilder mySqlCommandBuilder;
        //Khai báo đối tượng để lưu dữ liệu của bảng Customer trên form
        // private DataTable dtCustomer;
        //khai báo biến để kiểm tra đã <thêm mới> hay sửa
        private bool modeNew;

        private string category = "";
        private string status = "";
        private string floor = "";
        private int mmahoadon;

        public frmPay(int i)
        {
            InitializeComponent();
            guna2Panel2.Size = new Size(1016, 645);
            // int phong=Phong;
            if (i == 1) LoiGoi();
        }
        private void LoiGoi()
        {
            LoadUse();
            LoadDataPhong();
        }
        public class Phong
        {
            public string MaPhong { get; set; }
            public string LoaiPhong { get; set; }
            public string TrangThai { get; set; }
        }



        private async void LoadDanhSachPhongAsync(int CheDo, int Trangthai)
        {
            string query = "";

            if (((txtSearch.Text == "") && (CheDo == 0)) || (Trangthai == 1))//Tìm mặc định
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

            flowLayoutPanel1.Controls.Clear();
            // Chạy truy vấn ở thread nền
            List<Phong> danhSachPhong = await Task.Run(() =>
            {
                var list = new List<Phong>();
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Phong
                        {
                            MaPhong = reader["MaPhong"].ToString(),
                            LoaiPhong = reader["LoaiPhong"].ToString(),
                            TrangThai = reader["TrangThai"].ToString()
                        });
                    }
                    conn.Close();
                }
                return list;
            });

            // Sau khi có dữ liệu, load vào UI
            flowLayoutPanel1.SuspendLayout();

            foreach (var phong in danhSachPhong)
            {
                var uc = new UsPay();
                uc.MaPhong = phong.MaPhong;
                uc.LoaiPhong = phong.LoaiPhong;
                uc.TrangThai = phong.TrangThai;

                flowLayoutPanel1.Controls.Add(uc);
            }

            flowLayoutPanel1.ResumeLayout();
            // lblStatus.Text = $"Đã tải {danhSachPhong.Count} phòng.";
        }

        private void LoadDanhSachDichVu()
        {
            flowLayoutPanel1.Controls.Clear();
            string query = "";

            // if (txtTimKiemDichVu.Text == "")
            //{
            query = "SELECT dv.MaDichVu,dv.TenDichVu,dv.DonGia from DichVu dv  ";
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
                    us.MaDichVu = reader["MaDichVu"].ToString();
                    us.TenDichVu = reader["TenDichVu"].ToString();
                    us.DonGia = reader["DonGia"].ToString();

                    flowLayoutPanel1.Controls.Add(us);
                }
                conn.Close();
            }
        }
        Size originalSize;
        private void frmPay_Load(object sender, EventArgs e)
        {
            LoadDanhSachPhongAsync(0, 0);
            originalSize = guna2Panel2.Size;
        }
        //table dung chung cho
        // private DataTable dt;

        public void LoadDataPhong()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                string sql = $"SELECT p.MaPhong,p.LoaiPhong,p.GiaPhong FROM Phong p  where p.MaPhong = {Global.ROOM_CODE}";

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
                conn.Close();
            }
        }

        private void LoadUse()
        {
            string sql = @"
        SELECT kh.MaKhachHang,kh.HoTen,kh.SoDienThoai,kh.CMND_CCCD,kh.DiaChi, ctd.MaPhong, ctd.MaHoaDon , hd.NgayLap as NgayNhan,dp.NgayTraPhong as NgayTra, hd.MoTa
        FROM ThanhToan tt
        INNER JOIN HoaDon hd ON tt.MaHoaDon = hd.MaHoaDon
        INNER JOIN ChiTietDatPhong ctd ON hd.MaHoaDon = ctd.MaHoaDon
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
                            mmahoadon = Convert.ToInt32(dt.Rows[0]["MaHoaDon"]);
                            Global.MaHoaDon = Convert.ToInt32(dt.Rows[0]["MaHoaDon"]);
                        }
                        else
                        {
                            mmahoadon = 0;
                            Global.MaHoaDon = 0;
                        }
                        if (dt.Rows.Count > 0 && dt.Rows[0]["MoTa"].ToString() == "R")
                        {
                            //guna2Panel2.Size = originalSize;
                            Size defaultSize = new Size(506, 645);

                            if (guna2Panel3.Height < 700)
                            {
                                guna2Panel2.Size = new Size(506, 645);
                                guna2Panel3.Location = new Point(519, 49);
                            }
                            else
                            {
                                guna2Panel3.Location = new Point(665, 49);
                                guna2Panel2.Width = guna2Panel3.Width-135;
                                //guna2Panel3.Size = guna2Panel2.Size;

                            }

                            guna2Panel3.Visible = true;
                            /* if (guna2Panel3.Size == new Size(506, 645)) guna2Panel2.Size = new Size(506, 645);
                             else guna2Panel3.Size = guna2Panel2.Size;
                                 guna2Panel3.Visible = true;*/
                            txtCustomerName.Text = $"Tên: {dt.Rows[0]["HoTen"].ToString()}";
                            txtPhoneNumber.Text = $"SĐT: {dt.Rows[0]["SoDienThoai"].ToString()}";
                            txtIDCard.Text = $"CCCD: {dt.Rows[0]["CMND_CCCD"].ToString()}";
                            txtTenPhong.Text = $"Phòng:{dt.Rows[0]["MaPhong"].ToString()}";
                            txtHoaDon.Text = $"HĐ{dt.Rows[0]["MaHoaDon"].ToString()}";
                            txtNgayNhan.Text = $"Ngày nhận:{dt.Rows[0]["NgayNhan"].ToString()}";
                            txtNgayTra.Text = $"Ngày trả:{dt.Rows[0]["NgayTra"].ToString()}";

                            //loadTongTien();
                            loadDichVu();
                            btnThanhToan.Enabled = true;
                            btmNhanPhong.Enabled = false;
                            btnThanhToan.Text = "Thanh toán";


                        }
                        else
                        {
                            txtCustomerName.Text = "";
                            txtPhoneNumber.Text = "";
                            txtIDCard.Text = "";
                            txtTongTien.Text = "";
                            txtTenPhong.Text = "";
                            txtHoaDon.Text = "";
                            txtNgayNhan.Text = "";
                            txtNgayTra.Text = "";
                            guna2DataGridView2.DataSource = null;
                            btnThanhToan.Enabled = false;
                            if (mmahoadon == 0)
                            {
                                btmNhanPhong.Enabled = false;
                            }
                            else
                            {
                                btmNhanPhong.Enabled = true;
                                btmNhanPhong.FillColor = Color.ForestGreen;
                                btmNhanPhong.ForeColor = Color.White;

                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi khi tải thông tin khách hàng: " + ex.Message);
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
                        decimal tongTien = Convert.ToDecimal(dt.Rows[0]["TongTien"]);
                        txtTongTien.Text = $"Tổng:{tongTien.ToString("N0")}Đ";
                        MaHoaDonn = Convert.ToInt32(dt.Rows[0]["MaHoaDon"]);
                        btnThanhToan.Enabled = true;
                        btnThanhToan.FillColor = Color.ForestGreen;
                        btnThanhToan.ForeColor = Color.White;

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

                        if (dt.Rows.Count > 0 && txtCustomerName.Text != "")
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
                            MessageBox.Show("Không tìm thấy hóa đơn hoặc dịch vụ.");
                            Global.MaDichVu = 0;
                        }
                    }
                }
                conn.Close();

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
                conn.Close();
            }
        }
        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_CapNhatDaThanhToan", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHoaDon", MaHoaDonn);

                    try
                    {
                        conn.Open();
                        MessageBox.Show("Chắc chắn thanh toán đơn hàng này không! ", "Thông báo", MessageBoxButtons.YesNo);

                        cmd.ExecuteNonQuery();
                        frmHoaDon hoaDon = new frmHoaDon(MaHoaDonn);
                        hoaDon.ShowDialog();
                        LoadDanhSachPhongAsync(0, 0);
                        loadDichVu();
                        LoadUse();
                        MessageBox.Show("Thanh toán thành công!");
                        conn.Close();

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
            LoadDanhSachPhongAsync(0, 0);
            btnPhong.Size = new Size(105, 46);
        }



        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // LoadDanhSachPhongAsync(0, 1);
            string searchText = txtSearch.Text.Trim().ToLower();



            foreach (System.Windows.Forms.Control ctrl in flowLayoutPanel1.Controls)
            {
                if (ctrl is UsPay room)
                {
                    //  tìm theo Mã phòng hoặc Loại phòng
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
            // txtTimKiemDichVu.Text = "";
        }

        private void btnShearch_Click(object sender, EventArgs e)
        {

        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadDanhSachPhongAsync(0, 0);
        }

        private void btnSuDung_Click(object sender, EventArgs e)
        {
            LoadDanhSachPhongAsync(1, 0);
        }

        private void BtnChuaSuDung_Click(object sender, EventArgs e)
        {
            LoadDanhSachPhongAsync(2, 0);
        }

        private void txtTenPhong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTimKiemDichVu_TextChanged(object sender, EventArgs e)
        {
            LoadDanhSachDichVu();
            string searchText = txtTimKiemDichVu.Text.Trim().ToLower();



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
            txtSearch.Text = "";
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
            // Size size = TextRenderer.MeasureText(txtTongTien.Text, txtTongTien.Font);

            // Cập nhật chiều rộng (thêm padding nếu cần)
            //txtTongTien.Width = size.Width + 15;
        }

        private void txtHoaDon_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form DoanhThu = new frmDoanhThu();
            DoanhThu.ShowDialog();
        }

        private void btmNhanPhong_Click(object sender, EventArgs e)
        {
            if (mmahoadon == 0) return;
            else
            {
                string maHoaDon = mmahoadon.ToString(); // hoặc nơi bạn đang giữ mã hóa đơn

                string sql = @"
        UPDATE HoaDon 
        SET MoTa = @MoTa, 
            NgayLap = @NgayLap
        WHERE MaHoaDon = @MaHoaDon";

                try
                {
                    using (SqlConnection conn = new SqlConnection(conStr))
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MoTa", "R");
                        cmd.Parameters.AddWithValue("@NgayLap", DateTime.Now);
                        cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);

                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Đã cập nhật trạng thái nhận phòng thành công!");
                            LoadUse();
                            mmahoadon = 0;
                        }
                        else
                            MessageBox.Show("Không tìm thấy hóa đơn để cập nhật.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật nhận phòng: " + ex.Message);
                }
            }
        }

        private void btnDichVu_Click_1(object sender, EventArgs e)
        {

            if (txtCustomerName.Text != null)
            {
                flowLayoutPanel1.Controls.Clear();
                LoadDanhSachDichVu();
                btnPhong.Size = new Size(105, 33);
            }


        }

        private void full(object sender, EventArgs e)
        {
            guna2Panel2.Size = new Size(833, 969);
        }
    }
}
