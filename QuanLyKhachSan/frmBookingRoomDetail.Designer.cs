namespace QuanLyKhachSan
{
    partial class frmBookingRoomDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.tbIdCode = new System.Windows.Forms.TextBox();
            this.lbCCCD = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNationality = new System.Windows.Forms.TextBox();
            this.lbNationality = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.customerInfo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.msgErrorIsNotNumber = new System.Windows.Forms.Label();
            this.lbReturnDate = new System.Windows.Forms.Label();
            this.returnDate = new System.Windows.Forms.DateTimePicker();
            this.lbBookingDate = new System.Windows.Forms.Label();
            this.bookingDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConfirmBooking = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.customerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerName.Location = new System.Drawing.Point(88, 46);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(69, 25);
            this.lbCustomerName.TabIndex = 0;
            this.lbCustomerName.Text = "Họ tên";
            // 
            // customerName
            // 
            this.customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName.Location = new System.Drawing.Point(93, 74);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(219, 30);
            this.customerName.TabIndex = 1;
            this.customerName.TextChanged += new System.EventHandler(this.customerName_TextChanged);
            this.customerName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.customerName_KeyUp);
            // 
            // tbIdCode
            // 
            this.tbIdCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdCode.Location = new System.Drawing.Point(639, 77);
            this.tbIdCode.Name = "tbIdCode";
            this.tbIdCode.Size = new System.Drawing.Size(219, 30);
            this.tbIdCode.TabIndex = 3;
            this.tbIdCode.TextChanged += new System.EventHandler(this.tbIdCode_TextChanged);
            this.tbIdCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbIdCode_KeyUp);
            // 
            // lbCCCD
            // 
            this.lbCCCD.AutoSize = true;
            this.lbCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCCCD.Location = new System.Drawing.Point(634, 49);
            this.lbCCCD.Name = "lbCCCD";
            this.lbCCCD.Size = new System.Drawing.Size(137, 25);
            this.lbCCCD.TabIndex = 2;
            this.lbCCCD.Text = "CMND/CCCD";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNumber.Location = new System.Drawing.Point(375, 74);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(219, 30);
            this.tbPhoneNumber.TabIndex = 5;
            this.tbPhoneNumber.TextChanged += new System.EventHandler(this.tbPhoneNumber_TextChanged);
            this.tbPhoneNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbPhoneNumber_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số điện thoại\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbNationality
            // 
            this.tbNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNationality.Location = new System.Drawing.Point(375, 160);
            this.tbNationality.Name = "tbNationality";
            this.tbNationality.Size = new System.Drawing.Size(219, 30);
            this.tbNationality.TabIndex = 7;
            this.tbNationality.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lbNationality
            // 
            this.lbNationality.AutoSize = true;
            this.lbNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNationality.Location = new System.Drawing.Point(370, 132);
            this.lbNationality.Name = "lbNationality";
            this.lbNationality.Size = new System.Drawing.Size(95, 25);
            this.lbNationality.TabIndex = 6;
            this.lbNationality.Text = "Quốc tịch";
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(93, 160);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(219, 30);
            this.tbAddress.TabIndex = 9;
            this.tbAddress.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbAddress_KeyUp);
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(88, 132);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(71, 25);
            this.lbAddress.TabIndex = 8;
            this.lbAddress.Text = "Địa chỉ";
            // 
            // customerInfo
            // 
            this.customerInfo.BackColor = System.Drawing.Color.White;
            this.customerInfo.Controls.Add(this.label3);
            this.customerInfo.Controls.Add(this.msgErrorIsNotNumber);
            this.customerInfo.Controls.Add(this.lbReturnDate);
            this.customerInfo.Controls.Add(this.returnDate);
            this.customerInfo.Controls.Add(this.lbBookingDate);
            this.customerInfo.Controls.Add(this.bookingDate);
            this.customerInfo.Controls.Add(this.lbNationality);
            this.customerInfo.Controls.Add(this.tbAddress);
            this.customerInfo.Controls.Add(this.lbCustomerName);
            this.customerInfo.Controls.Add(this.lbAddress);
            this.customerInfo.Controls.Add(this.customerName);
            this.customerInfo.Controls.Add(this.tbNationality);
            this.customerInfo.Controls.Add(this.lbCCCD);
            this.customerInfo.Controls.Add(this.tbIdCode);
            this.customerInfo.Controls.Add(this.tbPhoneNumber);
            this.customerInfo.Controls.Add(this.label2);
            this.customerInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.customerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customerInfo.Location = new System.Drawing.Point(0, 0);
            this.customerInfo.Name = "customerInfo";
            this.customerInfo.Size = new System.Drawing.Size(1166, 235);
            this.customerInfo.TabIndex = 10;
            this.customerInfo.TabStop = false;
            this.customerInfo.Text = "Thông tin khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(636, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Trường này phải là số";
            this.label3.Visible = false;
            // 
            // msgErrorIsNotNumber
            // 
            this.msgErrorIsNotNumber.AutoSize = true;
            this.msgErrorIsNotNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgErrorIsNotNumber.ForeColor = System.Drawing.Color.Red;
            this.msgErrorIsNotNumber.Location = new System.Drawing.Point(372, 116);
            this.msgErrorIsNotNumber.Name = "msgErrorIsNotNumber";
            this.msgErrorIsNotNumber.Size = new System.Drawing.Size(157, 16);
            this.msgErrorIsNotNumber.TabIndex = 14;
            this.msgErrorIsNotNumber.Text = "Trường này phải là số";
            this.msgErrorIsNotNumber.Visible = false;
            // 
            // lbReturnDate
            // 
            this.lbReturnDate.AutoSize = true;
            this.lbReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReturnDate.Location = new System.Drawing.Point(869, 130);
            this.lbReturnDate.Name = "lbReturnDate";
            this.lbReturnDate.Size = new System.Drawing.Size(85, 25);
            this.lbReturnDate.TabIndex = 13;
            this.lbReturnDate.Text = "Ngày trả";
            // 
            // returnDate
            // 
            this.returnDate.Location = new System.Drawing.Point(874, 158);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(200, 30);
            this.returnDate.TabIndex = 12;
            this.returnDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbBookingDate
            // 
            this.lbBookingDate.AutoSize = true;
            this.lbBookingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookingDate.Location = new System.Drawing.Point(634, 132);
            this.lbBookingDate.Name = "lbBookingDate";
            this.lbBookingDate.Size = new System.Drawing.Size(90, 25);
            this.lbBookingDate.TabIndex = 11;
            this.lbBookingDate.Text = "Ngày đặt";
            // 
            // bookingDate
            // 
            this.bookingDate.Location = new System.Drawing.Point(639, 160);
            this.bookingDate.Name = "bookingDate";
            this.bookingDate.Size = new System.Drawing.Size(200, 30);
            this.bookingDate.TabIndex = 10;
            this.bookingDate.ValueChanged += new System.EventHandler(this.bookingDate_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1166, 78);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnConfirmBooking
            // 
            this.btnConfirmBooking.BackColor = System.Drawing.Color.DimGray;
            this.btnConfirmBooking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirmBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmBooking.ForeColor = System.Drawing.Color.White;
            this.btnConfirmBooking.Location = new System.Drawing.Point(905, 543);
            this.btnConfirmBooking.Name = "btnConfirmBooking";
            this.btnConfirmBooking.Size = new System.Drawing.Size(249, 54);
            this.btnConfirmBooking.TabIndex = 12;
            this.btnConfirmBooking.Text = "Xác nhận đặt phòng";
            this.btnConfirmBooking.UseVisualStyleBackColor = false;
            this.btnConfirmBooking.Click += new System.EventHandler(this.btnConfirmBooking_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 556);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tổng tiền cần thanh toán: ";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(304, 556);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(34, 25);
            this.lbTotal.TabIndex = 14;
            this.lbTotal.Text = "0đ";
            // 
            // frmBookingRoomDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1166, 626);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmBooking);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.customerInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBookingRoomDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBookingRoomDetail";
            this.Load += new System.EventHandler(this.frmBookingRoomDetail_Load);
            this.customerInfo.ResumeLayout(false);
            this.customerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.TextBox tbIdCode;
        private System.Windows.Forms.Label lbCCCD;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNationality;
        private System.Windows.Forms.Label lbNationality;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.GroupBox customerInfo;
        private System.Windows.Forms.Label lbBookingDate;
        private System.Windows.Forms.DateTimePicker bookingDate;
        private System.Windows.Forms.Label lbReturnDate;
        private System.Windows.Forms.DateTimePicker returnDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label msgErrorIsNotNumber;
        private System.Windows.Forms.Button btnConfirmBooking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label3;
    }
}