namespace QuanLyKhachSan
{
    partial class frmBookingRoom
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbSearchRoomNumber = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.roomNumber = new System.Windows.Forms.Label();
            this.lbFloor = new System.Windows.Forms.Label();
            this.cbFloor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 115);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(744, 432);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // tbSearchRoomNumber
            // 
            this.tbSearchRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchRoomNumber.Location = new System.Drawing.Point(18, 26);
            this.tbSearchRoomNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSearchRoomNumber.Name = "tbSearchRoomNumber";
            this.tbSearchRoomNumber.Size = new System.Drawing.Size(201, 26);
            this.tbSearchRoomNumber.TabIndex = 3;
            this.tbSearchRoomNumber.TextChanged += new System.EventHandler(this.tbSearchRoomNumber_TextChanged);
            this.tbSearchRoomNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearchRoomNumber_KeyUp);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DimGray;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(238, 22);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 37);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Phòng thường",
            "Phòng VIP"});
            this.cbCategory.Location = new System.Drawing.Point(141, 83);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(108, 28);
            this.cbCategory.TabIndex = 5;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Loại Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Trạng thái";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Trống",
            "Đang sử dụng"});
            this.cbStatus.Location = new System.Drawing.Point(18, 83);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(120, 28);
            this.cbStatus.TabIndex = 7;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // roomNumber
            // 
            this.roomNumber.AutoSize = true;
            this.roomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumber.Location = new System.Drawing.Point(21, 7);
            this.roomNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.Size = new System.Drawing.Size(69, 17);
            this.roomNumber.TabIndex = 9;
            this.roomNumber.Text = "Số phòng";
            // 
            // lbFloor
            // 
            this.lbFloor.AutoSize = true;
            this.lbFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFloor.Location = new System.Drawing.Point(249, 64);
            this.lbFloor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFloor.Name = "lbFloor";
            this.lbFloor.Size = new System.Drawing.Size(41, 17);
            this.lbFloor.TabIndex = 11;
            this.lbFloor.Text = "Tầng";
            // 
            // cbFloor
            // 
            this.cbFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFloor.FormattingEnabled = true;
            this.cbFloor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbFloor.Location = new System.Drawing.Point(252, 83);
            this.cbFloor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFloor.Name = "cbFloor";
            this.cbFloor.Size = new System.Drawing.Size(108, 28);
            this.cbFloor.TabIndex = 10;
            this.cbFloor.SelectedIndexChanged += new System.EventHandler(this.cbFloor_SelectedIndexChanged);
            // 
            // frmBookingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 547);
            this.Controls.Add(this.lbFloor);
            this.Controls.Add(this.cbFloor);
            this.Controls.Add(this.roomNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearchRoomNumber);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmBookingRoom";
            this.Text = "frmBookingRoom";
            this.Load += new System.EventHandler(this.frmBookingRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox tbSearchRoomNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label roomNumber;
        private System.Windows.Forms.Label lbFloor;
        private System.Windows.Forms.ComboBox cbFloor;
    }
}