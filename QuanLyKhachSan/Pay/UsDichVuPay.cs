using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.DichVu;

namespace QuanLyKhachSan
{
    public partial class UsDichVuPay: UserControl
    {
        public UsDichVuPay()
        {
            InitializeComponent();
        }
        int cheDo=0;
        public int CheDo
        {
            get =>cheDo; set => cheDo = value;
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

            }
        }

        public string DonGia
        {
            get => category.Text;
            set => category.Text = value;
        }

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
            if(cheDo==0) btnUcThem.Visible = true; // Hiện lại button đã ẩn
            else if (cheDo == 1)
            {
                Global.MaDichVu = int.Parse(lbRoomNumber.Text.Trim());
                ((frmDichVu)this.ParentForm).LoadDuLieu();
            }


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

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
