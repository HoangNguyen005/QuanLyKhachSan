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

namespace QuanLyKhachSan
{
    public partial class frmRoomManage: Form
    {

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

        private void displayData()
        {
            mySqlConnection = new SqlConnection(conStr);
            mySqlConnection.Open();
            string sSql = "SELECT * FROM Phong";
       
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

        //Enable field data
        private void enable(bool enable)
        {
            if(enable)
            {
                tbRoomId.ReadOnly = false;
                cbCategoryRoom.Enabled = true;
                tbNumberPeople.ReadOnly = false;
                tbRoomPrice.ReadOnly = false;
                tbArea.ReadOnly = false;
                cbNumberBed.Enabled = true;
                utilities.ReadOnly = false;
                cbFloor.Enabled = true;
                utilities.BackColor = Color.WhiteSmoke;
            } else
            {
                tbRoomId.ReadOnly = true;
                cbCategoryRoom.Enabled = false;
                tbNumberPeople.ReadOnly = true;
                tbRoomPrice.ReadOnly = true;
                tbArea.ReadOnly = true;
                cbNumberBed.Enabled = false;
                utilities.ReadOnly = true;
                cbFloor.Enabled = false;
                utilities.BackColor = Color.LightGray;
            }
        }

        private void unEnable()
        {

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
            tbRoomId.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            cbCategoryRoom.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            tbNumberPeople.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            tbRoomPrice.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            tbArea.Text = dataGridView1.Rows[r].Cells[5].Value.ToString();
            cbNumberBed.Text = dataGridView1.Rows[r].Cells[6].Value.ToString();
            utilities.Text = dataGridView1.Rows[r].Cells[7].Value.ToString();
            cbFloor.Text = dataGridView1.Rows[r].Cells[8].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            enable(true);
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            try
            {
                int roomId = int.Parse(tbRoomId.Text);
                string categoryRoom = cbCategoryRoom.Text;
                mySqlConnection = new SqlConnection(conStr);
                mySqlConnection.Open();
                string query = $"exec updateRoom {roomId}, N'{categoryRoom}', {tbNumberPeople.Text}, {tbRoomPrice.Text}, {tbArea.Text}, {cbNumberBed.Text}, N'{utilities.Text}', {cbFloor.Text}";
                mySqlCommand = new SqlCommand(query, mySqlConnection);
                mySqlCommand.ExecuteReader();
                MessageBox.Show("Chỉnh sửa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                displayData();
              
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //DialogResult confirm = new DialogResult();

            var confirm =  MessageBox.Show("Bạn chắc chắn muốn xóa phòng này!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm.ToString() != "yes")
            {
                return;
            } else
            {
                try
                {
                    //Delete field
                    
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
