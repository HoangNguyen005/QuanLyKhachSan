using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class UsPay: UserControl
    {
        public UsPay()
        {
            InitializeComponent();
        }
        public event EventHandler RoomClicked; // Khai báo sự kiện
        public string MaPhong
        {
            get => lbRoomNumber.Text;
            set => lbRoomNumber.Text = value;
        }




        public string TrangThai
        {
            get => lbStatus.Text;
            set
            {
                lbStatus.Text = value;
                if (value == "Trống")
                {
                    guna2Panel3.FillColor = Color.Transparent;
                    lbRoomNumber.ForeColor = Color.Black;
                    lbStatus.ForeColor = Color.Black;
                    category.ForeColor = Color.Black;
                    lbRoomNumber.BackColor = Color.White;
                    lbStatus.BackColor = Color.White;
                    category.BackColor = Color.White;
                }
                // else
                //   guna2Panel3.FillColor = Color.Transparent;

            }
        }

        public string LoaiPhong
        {
            get => category.Text;
            set => category.Text = value;
        }

        // Tương tự cho các thuộc tính như TenKhach, SoNgay, DonDep, etc.


        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void RegisterClickEvents(Control parent)
        {
            parent.Click += UsPay_Click;
            foreach (Control ctrl in parent.Controls)
            {
                RegisterClickEvents(ctrl); // Gán đệ quy cho tất cả control con
            }
        }

        private void UsPay_Load(object sender, EventArgs e)
        {
            RegisterClickEvents(this);
        }
        private string fl;
        private void UsPay_Click(object sender, EventArgs e)
        {

            //if (lbStatus.Text != "Trống") return;
            Global.ROOM_CODE = int.Parse(lbRoomNumber.Text.Trim());
            // Gọi hàm LoadDataPhong() của form cha
            ((frmPay)this.ParentForm).LoadDataPhong();

            //  frmPay _frmPay = new frmPay();
            // _frmPay.gualLoatl();  // Gọi load dữ liệu trước
            //_frmPay.ShowDialog(); // Rồi mở form
            /*  if (lbStatus.Text != "Trống") return;
              Global.ROOM_CODE = int.Parse(lbRoomNumber.Text.Trim());
              frmPay _frmPay = new frmPay();
              //_frmPay.();
             //frmPay.
              Form bookingDetail = _frmPay.gualLoatl();
              bookingDetail.ShowDialog();
             //  RoomClicked?.Invoke(this, EventArgs.Empty); // Gọi sự kiện*/
        }

        private void lbRoomNumber_Click(object sender, EventArgs e)
        {

        }

        private void lbStatus_Click(object sender, EventArgs e)
        {

        }

        private void category_Click(object sender, EventArgs e)
        {

        }
    }
}
