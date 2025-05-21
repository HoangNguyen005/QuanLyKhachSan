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
    public partial class frmLogin: Form
    {
        //khai báo xâu kết nối tới CSDL
        private string conStr = "Data Source=(local);Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        //định nghĩa đối tượng kết nối với CSDL
        private SqlConnection mySqlConnection;
        //định nghĩa đối tượng truy vấn/cập nhật dữ liệu
        private SqlCommand mySqlCommand;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text.Trim() == "" || tbPassword.Text.Trim() == "")
            {
                MessageBox.Show("Các trường dữ liệu là bắt buộc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                mySqlConnection = new SqlConnection(conStr);
                mySqlConnection.Open();
                string query = $"select * from TaiKhoan where TaiKhoan.TenDangNhap = N'{tbUserName.Text}' and TaiKhoan.MatKhau = N'{tbPassword.Text}'";
                SqlCommand cmd = new SqlCommand(query, mySqlConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                string userName = "";
                string password = "";
                while (reader.Read())
                {
                    userName = reader["TenDangNhap"].ToString();
                    password =  reader["MatKhau"].ToString();
                    //MessageBox.Show(userName, "sdfsdf");
                }

                 if (userName != "" && password != "")
                {
                    Form main = new frmMain();
                    main.ShowDialog();
                } else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            catch(Exception exception)
            {
                MessageBox.Show("Error" + exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUserName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                tbPassword.Focus();
            }
        }

        private void tbPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.AcceptButton = btnLogin;
            }
        }
    }
}
