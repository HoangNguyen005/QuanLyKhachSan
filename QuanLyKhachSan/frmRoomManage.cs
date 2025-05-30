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
using System.Reflection.Emit;
using System.Text.RegularExpressions;

namespace QuanLyKhachSan
{
    public partial class frmRoomManage: Form
    {
        private string btnActive = "";

        //khai báo xâu kết nối tới CSDL
        private string conStr = "Data Source=(local);Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        //định nghĩa đối tượng kết nối với CSDL
        private SqlConnection mySqlConnection;
        //định nghĩa đối tượng truy vấn/cập nhật dữ liệu
        private SqlCommand mySqlCommand;
        public frmRoomManage()
        {
            InitializeComponent();
        }

        private void displayData(string query = "")
        {
            mySqlConnection = new SqlConnection(conStr);
            mySqlConnection.Open();

            if (query == "")
                query = "SELECT * FROM Phong";
          

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
        }

        //Enable field data
        private void enable(bool enable)
        {
            if(enable)
            {
                tbRoomId.ReadOnly = false;
                cbCategoryRoom.Enabled = true;
                cbRoomStatus.Enabled = true;
                tbRoomPrice.ReadOnly = false;
                tbArea.ReadOnly = false;
                cbNumberBed.Enabled = true;
                utilities.ReadOnly = false;
                cbFloor.Enabled = true;
                tbDescribe.ReadOnly = false;
                utilities.BackColor = Color.WhiteSmoke;
                tbDescribe.BackColor = Color.WhiteSmoke;
            } else
            {
                tbRoomId.ReadOnly = true;
                cbCategoryRoom.Enabled = false;
                cbRoomStatus.Enabled = false;
                tbDescribe.ReadOnly = true;

                tbRoomPrice.ReadOnly = true;
                tbArea.ReadOnly = true;
                cbNumberBed.Enabled = false;
                utilities.ReadOnly = true;
                cbFloor.Enabled = false;
                utilities.BackColor = Color.LightGray;
                tbDescribe.BackColor = Color.LightGray;
            }
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmRoomManage_Load(object sender, EventArgs e)
        {
        
            displayData();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            enable(false);
            int r = e.RowIndex;
            if(r >= 0)
            {
                tbRoomPrice.Text = dataGridView1.Rows[r].Cells["GiaPhong"].Value.ToString();
                tbRoomId.Text = dataGridView1.Rows[r].Cells["MaPhong"].Value.ToString();
                cbCategoryRoom.Text = dataGridView1.Rows[r].Cells["LoaiPhong"].Value.ToString();           
                tbArea.Text = dataGridView1.Rows[r].Cells["DienTich"].Value.ToString();
                cbNumberBed.Text = dataGridView1.Rows[r].Cells["SoGiuong"].Value.ToString();
                utilities.Text = dataGridView1.Rows[r].Cells["TienIch"].Value.ToString();
                cbFloor.Text = dataGridView1.Rows[r].Cells["Tang"].Value.ToString();
                cbRoomStatus.Text = dataGridView1.Rows[r].Cells["TinhTrang"].Value.ToString();
                tbDescribe.Text = dataGridView1.Rows[r].Cells["MoTa"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnActive = "update";
            enable(true);
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (tbRoomId.Text == "" || cbCategoryRoom.Text == "" || tbRoomPrice.Text == "" || tbArea.Text == "" || cbFloor.Text == "" || cbRoomStatus.Text == "" || cbNumberBed.Text == "")
            {
                MessageBox.Show("Các trường dữ liệu là bắt buộc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.Parse(tbArea.Text) <= 0 || int.Parse(tbArea.Text) > 100)
            {
                MessageBox.Show("Trường diện tích không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            string query = "";
            try
            {
                mySqlConnection = new SqlConnection(conStr);
                mySqlConnection.Open();
                // Update room
                if (btnActive == "update")
                {
                    DialogResult confirm = new DialogResult();
                    confirm = MessageBox.Show("Bạn chắc chắn muốn cập nhập thông tin này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.No) return;
                    int roomId = int.Parse(tbRoomId.Text);
                    string categoryRoom = cbCategoryRoom.Text;
                    query = $"exec updateRoom {roomId}, N'{categoryRoom}', {tbRoomPrice.Text}, {tbArea.Text}, {cbNumberBed.Text}, N'{utilities.Text}', {cbFloor.Text}";
                    mySqlCommand = new SqlCommand(query, mySqlConnection);
                    mySqlCommand.ExecuteReader();
                    MessageBox.Show("Chỉnh sửa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    displayData();
                } else if (btnActive == "add")
                {
                    //Create new room
                    query = $"exec addRoom {tbRoomId.Text}, N'{cbCategoryRoom.Text}', {tbRoomPrice.Text}, N'{cbRoomStatus.Text}', {tbArea.Text}, {cbNumberBed.Text}, N'{utilities.Text}', {cbFloor.Text}, N'{tbDescribe.Text}'";
                    mySqlCommand = new SqlCommand(query, mySqlConnection);
                    mySqlCommand.ExecuteReader();
                    MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    displayData();
                }
              
            }
            catch (Exception exception)
            {
                //Display a message when app have an error
                MessageBox.Show(exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void roomCategory_Click(object sender, EventArgs e)
        {

        }

        //Delete room
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = new DialogResult();

            confirm =  MessageBox.Show("Bạn chắc chắn muốn xóa phòng này!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
            {
                return;
            } else
            {
                try
                {
                    //Delete field
                    mySqlConnection = new SqlConnection(conStr); 
                    mySqlConnection.Open();
                    string query = $"exec deleteRoom {int.Parse(tbRoomId.Text.Trim())}";
                    mySqlCommand = new SqlCommand(query, mySqlConnection);
                    mySqlCommand.ExecuteReader();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    displayData();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void tbArea_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9\\.]+$");
            if (!regex.IsMatch(tbArea.Text))
            {
                //label3.Visible = true;
            }
            else
            {
                //label3.Visible = false;
            }
        }

        private void numberPeople_Click(object sender, EventArgs e)
        {

        }

        private void tbnAdd_Click(object sender, EventArgs e)
        {
            //Change state button
            btnActive = "add";
            enable(true);
            tbRoomId.Clear();
            cbCategoryRoom.SelectedItem = null;       
            tbRoomPrice.Clear();
            tbArea.Clear();
            cbNumberBed.SelectedItem = null;
            utilities.Clear();
            tbDescribe.Clear();
            cbFloor.SelectedItem = null;
        }

        // Handle search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "";
            if (rBtnCategoryRoom.Checked)
            {
                query = $"select * from Phong where Phong.LoaiPhong LIKE N'%{tbSearch.Text.Trim()}%'";
            }
            else if (rBtnRoomNumber.Checked)
            {
                query = $"select * from Phong where Phong.MaPhong LIKE N'%{tbSearch.Text.Trim()}%'";
            }
            displayData(query);
        }
    }
}
