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
                    this.BackColor = Color.ForestGreen;
                else
                    this.BackColor = Color.LightSteelBlue;
               
            }
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
            if (lbStatus.Text != "Trống") return;
            MessageBox.Show("hello", "thong bao");
        }
    }
}
