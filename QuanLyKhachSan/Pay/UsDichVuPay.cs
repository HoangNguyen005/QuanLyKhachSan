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
    public partial class UsDichVuPay: UserControl
    {
        public UsDichVuPay()
        {
            InitializeComponent();
        }

        public string MaDichVu
        {
            get => lbRoomNumber.Text;

            set => lbRoomNumber.Text = value;

        }
        public string TenDichVu
        {
            get => lbStatus.Text;
            set
            {
                lbStatus.Text = value;
                /* if (value == "Trống")
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
                */
            }
        }

        public string DonGia
        {
            get => category.Text;
            set => category.Text = value;
        }




        // Tương tự cho các thuộc tính như TenKhach, SoNgay, DonDep, etc.

        private void RegisterClickEvents(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl != btnUcThem) // Loại trừ btnUcThem
                {
                    ctrl.Click += UsDichVuPay_Click;
                    RegisterClickEvents(ctrl); // Đệ quy cho control con
                    btnUcThem.Visible = false; // Ẩn button khỏi giao diện
                }
                /* parent.Click += usDichVu_Click;
                 foreach (Control ctrl in parent.Controls)
                 {
                     RegisterClickEvents(ctrl); // Gán đệ quy cho tất cả control con
                 }*/
            }
        }
        private void UsDichVuPay_Load(object sender, EventArgs e)
        {
            btnUcThem.Visible = false; // Ẩn button khỏi giao diện

            RegisterClickEvents(this);
        }

        private void btnUcThem_Click(object sender, EventArgs e)
        {
            Global.MaDichVu = int.Parse(lbRoomNumber.Text.Trim());
            ((frmPay)this.ParentForm).ThemDichVu();
            btnUcThem.Visible = false;
        }

        private void UsDichVuPay_Click(object sender, EventArgs e)
        {

            //if (lbStatus.Text != "Trống") return;
            //Global.MaDichVu = int.Parse(lbRoomNumber.Text.Trim());
            btnUcThem.Visible = true; // Hiện lại button đã ẩn
            


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
