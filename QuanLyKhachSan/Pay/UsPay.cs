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

                }
                else {

                    guna2Panel1.Visible = true;
                    guna2Panel3.BorderThickness = 2;
                    lbRoomNumber.BackColor = Color.Gainsboro;
                    category.BackColor = Color.Gainsboro;
                    guna2Panel3.BorderColor = Color.Black;


                }


            }
        }

        public string LoaiPhong
        {
            get => category.Text;
            set => category.Text = value;
        }



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

            Global.ROOM_CODE = int.Parse(lbRoomNumber.Text.Trim());
            // Gọi hàm LoadDataPhong() của form cha
            ((frmPay)this.ParentForm).LoadDataPhong();

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
