using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmMain: Form

    {
        public int ROOM_CODE;

        public frmMain()
        {
            InitializeComponent();
        }


        private Form frmCurrent;
        private void openChild(Form frmChild)
        {
            if (frmCurrent != null)
            {
                frmCurrent.Close();
            }
            frmCurrent = frmChild;
            frmChild.TopLevel = false;
            frmChild.FormBorderStyle = FormBorderStyle.None;
            frmChild.Dock = DockStyle.Fill;
            panel_body.Controls.Add(frmChild);
            panel_body.Tag = frmChild;
            frmChild.BringToFront();
            frmChild.Show();
            //MessageBox.Show("hello wordl", "thong boa");
           
        }


     

        private void btnHome_Click(object sender, EventArgs e)
        {
            //button1.BackColor += Color.Aqua;
            openChild(new frmHome());
            
        }
     
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            openChild(new frmImployee());
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            openChild(new frmBookingRoom());
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            openChild(new frmClient());
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            openChild(new frmPay());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            openChild(new frmHome());
        }

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            //btnHome.BackColor = Color.LightGray;

        }
    }
}
