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

namespace Myproject1
{
    public partial class frmImployee : Form
    {
        // Khai báo xâu kết nối CSDL
        //private string conStr = "Data Source=NVH;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        private string conStr = "Data Source=(local);Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        // Khai báo đối tượng kết nối CSDL
        private SqlConnection mySqlConnection;
        // Khai báo đối tượng truy vấn và cập nhật dữ liệu
        private SqlCommand mySqlCommand;
        private bool modeNew;
        private string sSql;

        public frmImployee()
        {
            InitializeComponent();

            // Thiết lập thứ tự Tab để di chuyển từ trên xuống dưới
            SetTabOrder();

            // Đăng ký sự kiện KeyDown cho tất cả các control nhập liệu
            SetupEnterKeyNavigation();
        }

        // Phương thức thiết lập thứ tự Tab
        private void SetTabOrder()
        {
            // Thiết lập TabIndex cho các control theo thứ tự từ trên xuống dưới
            txtMaNhanVien.TabIndex = 0;
            txtHoTen.TabIndex = 1;
            rbtnNam.TabIndex = 3;
            rbtnNu.TabIndex = 4;
            txtCCCD.TabIndex = 5;
            txtSoDienThoai.TabIndex = 6;
            txtGmail.TabIndex = 7;
            txtQueQuan.TabIndex = 8;
            txtChucVu.TabIndex = 9;
            txtLuong.TabIndex = 10;
            txtMoTa.TabIndex = 11;

        }

        // Phương thức thiết lập điều hướng bằng phím Enter
        private void SetupEnterKeyNavigation()
        {
            // Đăng ký sự kiện KeyDown cho tất cả các TextBox
            txtHoTen.KeyDown += TextBox_KeyDown;
            txtCCCD.KeyDown += TextBox_KeyDown;
            txtSoDienThoai.KeyDown += TextBox_KeyDown;
            txtGmail.KeyDown += TextBox_KeyDown;
            txtQueQuan.KeyDown += TextBox_KeyDown;
            txtChucVu.KeyDown += TextBox_KeyDown;
            txtLuong.KeyDown += TextBox_KeyDown;
            txtMoTa.KeyDown += TextBox_KeyDown;

            // Đăng ký sự kiện KeyDown cho DateTimePicker và RadioButton
            rbtnNam.KeyDown += Control_KeyDown;
            rbtnNu.KeyDown += Control_KeyDown;
        }

        // Xử lý sự kiện KeyDown cho TextBox
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Ngăn chặn tiếng "beep"
                e.Handled = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        // Xử lý sự kiện KeyDown cho các control khác
        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void frmnhanvien_Load(object sender, EventArgs e)
        {
            try
            {
                mySqlConnection = new SqlConnection(conStr);
                mySqlConnection.Open();

                // Hiển thị dữ liệu trong bảng NhanVien lên lưới
                Display();
                SetControls(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetControls(bool check)
        {
            txtMaNhanVien.Enabled = false; // Không cho phép sửa Mã nhân viên (tự tăng)
            txtHoTen.Enabled = check;
            dtpNgaySinh.Enabled = check;
            rbtnNam.Enabled = check;
            rbtnNu.Enabled = check;
            txtCCCD.Enabled = check;
            txtSoDienThoai.Enabled = check;
            txtGmail.Enabled = check;
            txtQueQuan.Enabled = check;
            txtChucVu.Enabled = check;
            txtLuong.Enabled = check;
            txtMoTa.Enabled = check;

            btnNew.Enabled = !check;
            btnEdit.Enabled = !check;
            btnDelete.Enabled = !check;
            btnSave.Enabled = check;
            btnCancel.Enabled = check;
            btnClose.Enabled = true; // Luôn cho phép đóng form
        }

        private void Display()
        {
            string sSql = "SELECT * FROM NhanVien";
            // Truy vấn dữ liệu từ bảng NhanVien vào 1 đối tượng DataTable
            SqlDataAdapter adapter = new SqlDataAdapter(sSql, mySqlConnection);
            DataTable dtNhanVien = new DataTable();
            adapter.Fill(dtNhanVien);

            // Hiển thị dữ liệu trong dtNhanVien lên lưới
            dataGridView1.DataSource = dtNhanVien;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            modeNew = true;
            SetControls(true);

            // Không cần clear MaNhanVien vì nó là identity
            txtMaNhanVien.Clear();
            txtHoTen.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            rbtnNam.Checked = true;
            txtCCCD.Clear();
            txtSoDienThoai.Clear();
            txtGmail.Clear();
            txtQueQuan.Clear();
            txtChucVu.Clear();
            txtLuong.Clear();
            txtMoTa.Clear();

            // Chuyển con trỏ về txtHoTen
            txtHoTen.Focus();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaNhanVien.Text = dataGridView1.Rows[e.RowIndex].Cells["MaNhanVien"].Value.ToString();
                txtHoTen.Text = dataGridView1.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();

                // Kiểm tra và gán giá trị ngày sinh
                if (dataGridView1.Rows[e.RowIndex].Cells["NgaySinh"].Value != DBNull.Value)
                {
                    dtpNgaySinh.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["NgaySinh"].Value);
                }

                // Xử lý giới tính
                string gioiTinh = dataGridView1.Rows[e.RowIndex].Cells["GioiTinh"].Value?.ToString();
                if (gioiTinh == "Nam")
                    rbtnNam.Checked = true;
                else if (gioiTinh == "Nữ")
                    rbtnNu.Checked = true;


                // Gán giá trị cho các controls khác
                txtCCCD.Text = dataGridView1.Rows[e.RowIndex].Cells["CCCD"].Value?.ToString();
                txtChucVu.Text = dataGridView1.Rows[e.RowIndex].Cells["ChucVu"].Value?.ToString();
                txtLuong.Text = dataGridView1.Rows[e.RowIndex].Cells["Luong"].Value?.ToString();
                txtQueQuan.Text = dataGridView1.Rows[e.RowIndex].Cells["QueQuan"].Value?.ToString();
                txtSoDienThoai.Text = dataGridView1.Rows[e.RowIndex].Cells["SoDienThoai"].Value?.ToString();
                txtGmail.Text = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value?.ToString();
                txtMoTa.Text = dataGridView1.Rows[e.RowIndex].Cells["MoTa"].Value?.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            modeNew = false;
            SetControls(true);
            txtHoTen.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Hỏi xác nhận xóa dữ liệu
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;

            try
            {
                // Lấy mã nhân viên cần xóa
                string maNhanVien = txtMaNhanVien.Text;

                // Định nghĩa câu lệnh SQL để xóa
                string sSql = "DELETE FROM NhanVien WHERE MaNhanVien = @MaNhanVien";
                mySqlCommand = new SqlCommand(sSql, mySqlConnection);

                // Thêm tham số
                mySqlCommand.Parameters.Add("@MaNhanVien", SqlDbType.Int).Value = Convert.ToInt32(maNhanVien);

                // Thực hiện lệnh xóa
                mySqlCommand.ExecuteNonQuery();

                MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hiển thị lại dữ liệu
                Display();

                // Clear các controls sau khi xóa
                txtMaNhanVien.Clear();
                txtHoTen.Clear();
                dtpNgaySinh.Value = DateTime.Now;
                rbtnNam.Checked = true;
                txtCCCD.Clear();
                txtSoDienThoai.Clear();
                txtGmail.Clear();
                txtQueQuan.Clear();
                txtChucVu.Clear();
                txtLuong.Clear();
                txtMoTa.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message +
                    "\nCó thể nhân viên này đang có tài khoản hoặc liên quan đến dữ liệu khác.",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập/sửa
            if (txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
                return;
            }

            try
            {
                // Lấy giới tính từ RadioButton
                string gioiTinh = rbtnNam.Checked ? "Nam" : (rbtnNu.Checked ? "Nữ" : null);

                // Lấy giá trị lương, xử lý trường hợp không nhập
                decimal luong = 0;
                if (!string.IsNullOrEmpty(txtLuong.Text))
                {
                    if (!decimal.TryParse(txtLuong.Text, out luong))
                    {
                        MessageBox.Show("Lương phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtLuong.Focus();
                        return;
                    }
                }

                if (modeNew)
                {
                    // Thêm mới nhân viên
                    sSql = @"INSERT INTO NhanVien (HoTen, NgaySinh, GioiTinh, CCCD, ChucVu, Luong, QueQuan, SoDienThoai, Email, MoTa)
                           VALUES (@HoTen, @NgaySinh, @GioiTinh, @CCCD, @ChucVu, @Luong, @QueQuan, @SoDienThoai, @Email, @MoTa)";

                    mySqlCommand = new SqlCommand(sSql, mySqlConnection);
                }
                else
                {
                    // Cập nhật thông tin nhân viên
                    sSql = @"UPDATE NhanVien SET 
                           HoTen = @HoTen, 
                           NgaySinh = @NgaySinh, 
                           GioiTinh = @GioiTinh, 
                           CCCD = @CCCD, 
                           ChucVu = @ChucVu, 
                           Luong = @Luong, 
                           QueQuan = @QueQuan, 
                           SoDienThoai = @SoDienThoai, 
                           Email = @Email, 
                           MoTa = @MoTa 
                           WHERE MaNhanVien = @MaNhanVien";

                    mySqlCommand = new SqlCommand(sSql, mySqlConnection);
                    mySqlCommand.Parameters.Add("@MaNhanVien", SqlDbType.Int).Value = Convert.ToInt32(txtMaNhanVien.Text);
                }

                // Thêm các tham số chung
                mySqlCommand.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100).Value = txtHoTen.Text;
                mySqlCommand.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = dtpNgaySinh.Value;
                mySqlCommand.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 10).Value = gioiTinh;
                mySqlCommand.Parameters.Add("@CCCD", SqlDbType.NVarChar, 20).Value =
                    string.IsNullOrEmpty(txtCCCD.Text) ? (object)DBNull.Value : txtCCCD.Text;
                mySqlCommand.Parameters.Add("@ChucVu", SqlDbType.NVarChar, 50).Value =
                    string.IsNullOrEmpty(txtChucVu.Text) ? (object)DBNull.Value : txtChucVu.Text;
                mySqlCommand.Parameters.Add("@Luong", SqlDbType.Decimal).Value = luong == 0 ? (object)DBNull.Value : luong;
                mySqlCommand.Parameters.Add("@QueQuan", SqlDbType.NVarChar, 50).Value =
                    string.IsNullOrEmpty(txtQueQuan.Text) ? (object)DBNull.Value : txtQueQuan.Text;
                mySqlCommand.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar, 20).Value =
                    string.IsNullOrEmpty(txtSoDienThoai.Text) ? (object)DBNull.Value : txtSoDienThoai.Text;
                mySqlCommand.Parameters.Add("@Email", SqlDbType.NVarChar, 100).Value =
                    string.IsNullOrEmpty(txtGmail.Text) ? (object)DBNull.Value : txtGmail.Text;
                mySqlCommand.Parameters.Add("@MoTa", SqlDbType.NVarChar, 255).Value =
                    string.IsNullOrEmpty(txtMoTa.Text) ? (object)DBNull.Value : txtMoTa.Text;

                // Thực hiện lệnh
                mySqlCommand.ExecuteNonQuery();

                // Thông báo thành công
                MessageBox.Show(modeNew ? "Thêm nhân viên thành công!" : "Cập nhật thông tin nhân viên thành công!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hiển thị lại dữ liệu
                Display();

                // Thiết lập lại trạng thái các điều khiển
                SetControls(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message +
                    "\nNếu lỗi liên quan đến Email, có thể email đã tồn tại trong hệ thống.",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetControls(false);

            // Nếu đang ở chế độ thêm mới, clear hết các controls
            if (modeNew)
            {
                txtMaNhanVien.Clear();
                txtHoTen.Clear();
                dtpNgaySinh.Value = DateTime.Now;
                rbtnNam.Checked = true;
                txtCCCD.Clear();
                txtSoDienThoai.Clear();
                txtGmail.Clear();
                txtQueQuan.Clear();
                txtChucVu.Clear();
                txtLuong.Clear();
                txtMoTa.Clear();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Đóng kết nối trước khi đóng form
            if (mySqlConnection != null && mySqlConnection.State == ConnectionState.Open)
            {
                mySqlConnection.Close();
            }

            this.Close();
        }

        private void frmnhanvien_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Đóng kết nối khi form đóng
            if (mySqlConnection != null && mySqlConnection.State == ConnectionState.Open)
            {
                mySqlConnection.Close();
            }
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {

        }
    }
}