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
    public partial class frmsigin: Form
    {

        // Khai báo xâu kết nối CSDL
        //private string conStr = "Data Source=NVH;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        private string conStr = "Data Source=(local);Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        // Khai báo đối tượng kết nối CSDL
        private SqlConnection mySqlConnection;
        // Khai báo đối tượng truy vấn và cập nhật dữ liệu
        private SqlCommand mySqlCommand;
   
        public frmsigin()
        {
            InitializeComponent();
        }

        // Handle singin
        private void btnSigin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();
            // Check if username or password is empty
            if (username == "" || password == "")
            {
                MessageBox.Show("Các trường dữ liệu là bắt buộc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string query = $"select * from TaiKhoan where TaiKhoan.TenDangNhap = N'{username}'";
                mySqlConnection = new SqlConnection(conStr);
                mySqlConnection.Open();

                mySqlCommand = new SqlCommand(query, mySqlConnection);
                SqlDataReader reader = mySqlCommand.ExecuteReader();

                while(reader.Read())
                {
                    if (username == reader["TenDangNhap"].ToString())
                    {
                        MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbUsername.Clear();
                        tbUsername.Focus();
                        tbPassword.Clear();
                        return;
                    }
                }
                reader.Close();

                query = $"exec createAcc N'{username}', N'{password}'";
                mySqlCommand = new SqlCommand(query, mySqlConnection);
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;

            }
            catch (Exception exception)
            {
                MessageBox.Show("Error" + exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void tbPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.AcceptButton = btnSigin;
            }
        }

        private void tbUsername_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                tbPassword.Focus();
            }
        }

        private void frmsigin_Load(object sender, EventArgs e)
        {
            tbUsername.Focus();
        }
    }
}
