using Myproject1;
using QuanLyKhachSan.Pay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        private void handleActive(object sender)
        {
            Button btn = sender as Button;
            if(btn != null)
            {
                var location = currentActive.Location;
                location.Y = btn.Location.Y;
                currentActive.Location = location;
            }
        }

     

        private void btnHome_Click(object sender, EventArgs e)
        {
            //button1.BackColor += Color.Aqua;
            handleActive(sender);

            openChild(new frmHome());
        
        }
     
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            handleActive(sender);

            openChild(new frmImployee());
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            handleActive(sender);

            openChild(new frmBookingRoom());
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            handleActive(sender);

            openChild(new frmClient());
        }

       /* private void btnPay_Click(object sender, EventArgs e)
        {

            handleActive(sender);

             openChild(new frmPay());

            
        }*/



         private void frmMain_Load(object sender, EventArgs e)
         {
             handleActive(sender);

             openChild(new frmHome());

         }
        private frmLoading loadingForm;
        private async void btnPay_Click(object sender, EventArgs e)
        {
            loadingForm = new frmLoading();

            // Show form loading trên UI thread
            handleActive(sender);

            openChild(loadingForm);

            await Task.Run(() =>
            {
                // Giả lập xử lý lâu
                //Thread.Sleep(3000);

                // Đóng form loading phải chạy trên UI thread
                if (loadingForm.InvokeRequired)
                {
                    loadingForm.Invoke((MethodInvoker)delegate {
                        loadingForm.Close();
                    });
                }
                else
                {
                    loadingForm.Close();
                }
            });

            // Sau khi loading xong, mở form thanh toán
            handleActive(sender);

            openChild(new frmPay());
        }


        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            //btnHome.BackColor = Color.LightGray;

        }

        private void panel_body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roomManage_Click(object sender, EventArgs e)
        {
            handleActive(sender);
            //Location

            //currentActive.BackColor = Color.Black;

            openChild(new frmRoomManage());
        }
    }
}
