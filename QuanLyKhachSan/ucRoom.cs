using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyKhachSan
{
  
    public partial class ucRoom: UserControl
    {
        public ucRoom()
        {
            InitializeComponent();
        }

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
                    this.BackColor = Color.Green;
                else
                    this.BackColor = Color.FromArgb(64, 64, 64);
               
            }
        }

        public string LoaiPhong
        {
            get => category.Text;
            set => category.Text = value;
        }

        // Tương tự cho các thuộc tính như TenKhach, SoNgay, DonDep, etc.


        private void ucRoom_Load(object sender, EventArgs e)
        {

        }

        private void lbStatus_Click(object sender, EventArgs e)
        {

        }

        private void ucRoom_Click(object sender, EventArgs e)
        {
            Global.ROOM_CODE = int.Parse(lbRoomNumber.Text.Trim());
            if (lbStatus.Text != "Trống") return;
            else
            {
                Form bookingDetail = new frmBookingRoomDetail();
                bookingDetail.ShowDialog();
            }
        }

        private void category_Click(object sender, EventArgs e)
        {

        }
    }
}
