using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private string currentActive = "";

        public frmClient()
        {
            InitializeComponent();
        }

        private void loadData(string query = "")
        {
            mySqlConnection = new SqlConnection(conStr);
            mySqlConnection.Open();
            if (query == "")
            {
                query = "SELECT * FROM KhachHang";

            }

            //truy vấn dữ liệu vào đối tượng SqlDataReader
            mySqlCommand = new SqlCommand(query, mySqlConnection);
            SqlDataReader drSuppliers = mySqlCommand.ExecuteReader();
            //chuyển dữ liệu từ đối tượng SqlDataReader sang DataTable để hiển thị lên lưới
            DataTable dtSupplier = new DataTable();
            dtSupplier.Load(drSuppliers);
            //hiển thị dữ liệu từ DataTable lên lưới
            dataGridView1.DataSource = dtSupplier;
            //đóng đối tượng DataReader
            drSuppliers.Close();
            //mySqlConnection.Close();
        }

        private void enable(bool result)
        {
            if(result)
            {
                customeName.ReadOnly = false;
                phoneNumber.ReadOnly = false;
                customeID.ReadOnly = false;
                roomNumber.ReadOnly = false;
                nationality.ReadOnly = false;
                address.ReadOnly = false;
            } else
            {
                customeName.ReadOnly = true;
                phoneNumber.ReadOnly = true;
                customeID.ReadOnly = true;
                roomNumber.ReadOnly = true;
                nationality.ReadOnly = true;
                address.ReadOnly = true;
            }
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            // Gọi hàm load khách hàng khi form mở
            rdBtnName.Checked = true;
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
          
        }


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            enable(false);
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
                //mySqlConnection.Close();
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
            enable(true);
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {

            try
            {
                mySqlConnection = new SqlConnection(conStr);
                mySqlConnection.Open();
                string query = $"exec updateCus {cusID}, '{customeName.Text}', '{phoneNumber.Text}', {customeID.Text}, '{address.Text}', '{nationality.Text}', null";
                mySqlCommand = new SqlCommand(query, mySqlConnection);
                mySqlCommand.ExecuteReader();
                MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //mySqlConnection.Close();
                loadData();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void rdBtnName_CheckedChanged(object sender, EventArgs e)
        {
            //if (rdBtnName.Checked) currentActive = 
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
         
            string query = "";
            if (rdBtnName.Checked)
            {
                query = $"select * from KhachHang where KhachHang.HoTen LIKE N'%{tbSearch.Text.Trim()}%'";
            }
            else if (btnNationality.Checked)
            {
                query = $"select * from KhachHang where KhachHang.QuocTich LIKE N'%{tbSearch.Text.Trim()}%'";
            }
            loadData(query);
        }

        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
              
            }
        }

        private void phoneNumber_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]+$");
            if (!regex.IsMatch(phoneNumber.Text))
            {
                MessageBox.Show("Trường này phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void customeID_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]+$");
            if (!regex.IsMatch(customeID.Text))
            {
                MessageBox.Show("Trường này phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}