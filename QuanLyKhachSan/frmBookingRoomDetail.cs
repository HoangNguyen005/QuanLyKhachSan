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
using System.Text.RegularExpressions;

namespace QuanLyKhachSan
{
    public partial class frmBookingRoomDetail: Form
    {
        //khai báo xâu kết nối tới CSDL
        private string conStr = "Data Source=(local);Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        //định nghĩa đối tượng kết nối với CSDL
        private SqlConnection mySqlConnection;
        //định nghĩa đối tượng truy vấn/cập nhật dữ liệu
        private SqlCommand mySqlCommand;
        public frmBookingRoomDetail()
        {
            InitializeComponent();
        }

        private int checkDaysInMonth(DateTimePicker Date)
        {

            switch(Date.Value.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    int year = Date.Value.Year;
                    int daysInFebruary = DateTime.IsLeapYear(year) ? 29 : 28;
                    return daysInFebruary;
                default:
                    return 0;             
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bookingDate_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(bookingDate.Value.ToString(), "thongba");
        }

        private void frmBookingRoomDetail_Load(object sender, EventArgs e)
        {
            mySqlConnection = new SqlConnection(conStr);
            mySqlConnection.Open();
            string sSql;
         
              
             sSql = $"SELECT * FROM Phong WHERE MaPhong = {Global.ROOM_CODE}";
            
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

        private void tbPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            //Check if phoneNumber field is NOT NUMBER
            Regex regex = new Regex("^[0-9]+$");
            if (!regex.IsMatch(tbPhoneNumber.Text))
            {
                msgErrorIsNotNumber.Visible = true;
            }
            else
            {
                msgErrorIsNotNumber.Visible = false;
            }

        }

        private void customerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                tbPhoneNumber.Focus();
        }

        private void tbPhoneNumber_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                tbIdCode.Focus();
        }

        private void tbIdCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                tbAddress.Focus();
        }

        private void tbAddress_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                tbNationality.Focus();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            float totalDateBoking = returnDate.Value.Day - bookingDate.Value.Day;
            if (returnDate.Value.Month > bookingDate.Value.Month)
            {
                totalDateBoking = checkDaysInMonth(bookingDate) - bookingDate.Value.Day + returnDate.Value.Day;

            }
  
            //float MONEY = float.Parse(dataGridView1.Rows[0].Cells[3].Value.ToString());
            //float total = MONEY * totalDateBoking;
            //MessageBox.Show(total.ToString(), "thongad");
            lbTotal.Text = $"{float.Parse(dataGridView1.Rows[0].Cells[2].Value.ToString()) * totalDateBoking}d";
        }

        private void tbIdCode_TextChanged(object sender, EventArgs e)
        {
            //Check if phoneNumber field is NOT NUMBER
            Regex regex = new Regex("^[0-9]+$");
            if (!regex.IsMatch(tbIdCode.Text))
            {
                label3.Visible = true;
            }
            else
            {
                label3.Visible = false;
            }
        }

        //Handle booking room
        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            //Confirm Booking room
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Chắc chắn muốn đặt phòng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.No)
            {
                return;
            }

            string query = "";
            string roomCode = dataGridView1.Rows[0].Cells["MaPhong"].Value.ToString();
                  
            try
            {
                mySqlConnection = new SqlConnection(conStr);
                mySqlConnection.Open();
                query = $"exec bookingRoom {int.Parse(roomCode)}, '{customerName.Text}', '{tbPhoneNumber.Text}', '{tbIdCode.Text}', '{tbAddress.Text}', '{tbNationality.Text}', NULL, '{bookingDate.Value}', '{returnDate.Value}'";
                mySqlCommand = new SqlCommand(query, mySqlConnection);
                mySqlCommand.ExecuteReader();

                MessageBox.Show("Đặt phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmBookingRoomDetail newForm = new frmBookingRoomDetail();
                newForm.Close();
            } catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
