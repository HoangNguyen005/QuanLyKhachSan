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
    public partial class UsHome : UserControl
    {
        public UsHome()
        {
            InitializeComponent();
        }
        public string Name
        {
            get => lbName.Text;
            set => lbName.Text = value;
        }

        public string NoiDung
        {
            get => lbNoiDung.Text;
            set => lbNoiDung.Text = value;
        }

        

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UsHome_Load(object sender, EventArgs e)
        {

        }

        private void lbNoiDung_Click(object sender, EventArgs e)
        {

        }
    }
}
