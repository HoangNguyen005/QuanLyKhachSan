namespace QuanLyKhachSan
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.currentActive = new System.Windows.Forms.Panel();
            this.roomManage = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnRoomBook = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel_body = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 746);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(26, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 99);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.currentActive);
            this.panel2.Controls.Add(this.roomManage);
            this.panel2.Controls.Add(this.btnPay);
            this.panel2.Controls.Add(this.btnClient);
            this.panel2.Controls.Add(this.btnEmployee);
            this.panel2.Controls.Add(this.btnRoomBook);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 527);
            this.panel2.TabIndex = 0;
            // 
            // currentActive
            // 
            this.currentActive.BackColor = System.Drawing.Color.Maroon;
            this.currentActive.Cursor = System.Windows.Forms.Cursors.Default;
            this.currentActive.Location = new System.Drawing.Point(12, 60);
            this.currentActive.Name = "currentActive";
            this.currentActive.Size = new System.Drawing.Size(6, 49);
            this.currentActive.TabIndex = 0;
            // 
            // roomManage
            // 
            this.roomManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roomManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roomManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roomManage.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.roomManage.FlatAppearance.BorderSize = 0;
            this.roomManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomManage.ForeColor = System.Drawing.Color.White;
            this.roomManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomManage.Location = new System.Drawing.Point(48, 388);
            this.roomManage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomManage.Name = "roomManage";
            this.roomManage.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.roomManage.Size = new System.Drawing.Size(202, 49);
            this.roomManage.TabIndex = 11;
            this.roomManage.Text = "Quản lý phòng";
            this.roomManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomManage.UseVisualStyleBackColor = false;
            this.roomManage.Click += new System.EventHandler(this.roomManage_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.Location = new System.Drawing.Point(48, 324);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnPay.Size = new System.Drawing.Size(202, 49);
            this.btnPay.TabIndex = 7;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClient.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.Color.White;
            this.btnClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.Location = new System.Drawing.Point(48, 190);
            this.btnClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClient.Name = "btnClient";
            this.btnClient.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnClient.Size = new System.Drawing.Size(202, 49);
            this.btnClient.TabIndex = 5;
            this.btnClient.Text = "Khách hàng";
            this.btnClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(48, 257);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnEmployee.Size = new System.Drawing.Size(202, 49);
            this.btnEmployee.TabIndex = 6;
            this.btnEmployee.Text = "Nhân viên";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnRoomBook
            // 
            this.btnRoomBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRoomBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRoomBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomBook.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnRoomBook.FlatAppearance.BorderSize = 0;
            this.btnRoomBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomBook.ForeColor = System.Drawing.Color.White;
            this.btnRoomBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoomBook.Location = new System.Drawing.Point(48, 125);
            this.btnRoomBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRoomBook.Name = "btnRoomBook";
            this.btnRoomBook.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnRoomBook.Size = new System.Drawing.Size(202, 49);
            this.btnRoomBook.TabIndex = 4;
            this.btnRoomBook.Text = "Đặt phòng";
            this.btnRoomBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoomBook.UseVisualStyleBackColor = false;
            this.btnRoomBook.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(48, 60);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(202, 49);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseHover += new System.EventHandler(this.btnHome_MouseHover);
            // 
            // panel_body
            // 
            this.panel_body.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(283, 0);
            this.panel_body.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1050, 746);
            this.panel_body.TabIndex = 2;
            this.panel_body.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_body_Paint);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 746);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnRoomBook;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Button roomManage;
        private System.Windows.Forms.Panel currentActive;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel3;
    }
}