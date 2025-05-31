namespace QuanLyKhachSan
{
    partial class frmRoomManage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roomCategory = new System.Windows.Forms.Label();
            this.cbCategoryRoom = new System.Windows.Forms.ComboBox();
            this.priceRoom = new System.Windows.Forms.Label();
            this.tbRoomPrice = new System.Windows.Forms.TextBox();
            this.lbS = new System.Windows.Forms.Label();
            this.lbUtilities = new System.Windows.Forms.Label();
            this.floor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.cbFloor = new System.Windows.Forms.ComboBox();
            this.cbNumberBed = new System.Windows.Forms.ComboBox();
            this.utilities = new System.Windows.Forms.RichTextBox();
            this.tbnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rBtnCategoryRoom = new System.Windows.Forms.RadioButton();
            this.rBtnRoomNumber = new System.Windows.Forms.RadioButton();
            this.lbRoomId = new System.Windows.Forms.Label();
            this.tbRoomId = new System.Windows.Forms.TextBox();
            this.roomStatus = new System.Windows.Forms.Label();
            this.cbRoomStatus = new System.Windows.Forms.ComboBox();
            this.tbDescribe = new System.Windows.Forms.RichTextBox();
            this.describe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 487);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 251);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // roomCategory
            // 
            this.roomCategory.AutoSize = true;
            this.roomCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomCategory.Location = new System.Drawing.Point(33, 74);
            this.roomCategory.Name = "roomCategory";
            this.roomCategory.Size = new System.Drawing.Size(120, 25);
            this.roomCategory.TabIndex = 1;
            this.roomCategory.Text = "Loại phòng: ";
            this.roomCategory.Click += new System.EventHandler(this.roomCategory_Click);
            // 
            // cbCategoryRoom
            // 
            this.cbCategoryRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCategoryRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoryRoom.Enabled = false;
            this.cbCategoryRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoryRoom.FormattingEnabled = true;
            this.cbCategoryRoom.Items.AddRange(new object[] {
            "Phòng đơn",
            "Phòng đôi",
            "Phòng VIP"});
            this.cbCategoryRoom.Location = new System.Drawing.Point(159, 71);
            this.cbCategoryRoom.Name = "cbCategoryRoom";
            this.cbCategoryRoom.Size = new System.Drawing.Size(309, 33);
            this.cbCategoryRoom.TabIndex = 2;
            // 
            // priceRoom
            // 
            this.priceRoom.AutoSize = true;
            this.priceRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceRoom.Location = new System.Drawing.Point(31, 120);
            this.priceRoom.Name = "priceRoom";
            this.priceRoom.Size = new System.Drawing.Size(108, 25);
            this.priceRoom.TabIndex = 3;
            this.priceRoom.Text = "Giá phòng:";
            // 
            // tbRoomPrice
            // 
            this.tbRoomPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRoomPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRoomPrice.Location = new System.Drawing.Point(159, 123);
            this.tbRoomPrice.Name = "tbRoomPrice";
            this.tbRoomPrice.ReadOnly = true;
            this.tbRoomPrice.Size = new System.Drawing.Size(309, 30);
            this.tbRoomPrice.TabIndex = 6;
            // 
            // lbS
            // 
            this.lbS.AutoSize = true;
            this.lbS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbS.Location = new System.Drawing.Point(33, 173);
            this.lbS.Name = "lbS";
            this.lbS.Size = new System.Drawing.Size(93, 25);
            this.lbS.TabIndex = 7;
            this.lbS.Text = "Diện tích:";
            // 
            // lbUtilities
            // 
            this.lbUtilities.AutoSize = true;
            this.lbUtilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUtilities.Location = new System.Drawing.Point(583, 120);
            this.lbUtilities.Name = "lbUtilities";
            this.lbUtilities.Size = new System.Drawing.Size(87, 25);
            this.lbUtilities.TabIndex = 8;
            this.lbUtilities.Text = "Tiện ích:";
            // 
            // floor
            // 
            this.floor.AutoSize = true;
            this.floor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floor.Location = new System.Drawing.Point(583, 25);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(64, 25);
            this.floor.TabIndex = 9;
            this.floor.Text = "Tầng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(583, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số giường:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbArea
            // 
            this.tbArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArea.Location = new System.Drawing.Point(159, 173);
            this.tbArea.Name = "tbArea";
            this.tbArea.ReadOnly = true;
            this.tbArea.Size = new System.Drawing.Size(309, 30);
            this.tbArea.TabIndex = 11;
            this.tbArea.TextChanged += new System.EventHandler(this.tbArea_TextChanged);
            // 
            // cbFloor
            // 
            this.cbFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFloor.Enabled = false;
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
            this.cbFloor.Location = new System.Drawing.Point(709, 25);
            this.cbFloor.Name = "cbFloor";
            this.cbFloor.Size = new System.Drawing.Size(309, 33);
            this.cbFloor.TabIndex = 12;
            // 
            // cbNumberBed
            // 
            this.cbNumberBed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbNumberBed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumberBed.Enabled = false;
            this.cbNumberBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNumberBed.FormattingEnabled = true;
            this.cbNumberBed.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbNumberBed.Location = new System.Drawing.Point(709, 74);
            this.cbNumberBed.Name = "cbNumberBed";
            this.cbNumberBed.Size = new System.Drawing.Size(309, 33);
            this.cbNumberBed.TabIndex = 13;
            // 
            // utilities
            // 
            this.utilities.BackColor = System.Drawing.SystemColors.ControlLight;
            this.utilities.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.utilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilities.Location = new System.Drawing.Point(709, 123);
            this.utilities.Name = "utilities";
            this.utilities.ReadOnly = true;
            this.utilities.Size = new System.Drawing.Size(309, 59);
            this.utilities.TabIndex = 15;
            this.utilities.Text = "";
            // 
            // tbnAdd
            // 
            this.tbnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tbnAdd.Location = new System.Drawing.Point(201, 291);
            this.tbnAdd.Name = "tbnAdd";
            this.tbnAdd.Size = new System.Drawing.Size(100, 41);
            this.tbnAdd.TabIndex = 16;
            this.tbnAdd.Text = "Thêm";
            this.tbnAdd.UseVisualStyleBackColor = false;
            this.tbnAdd.Click += new System.EventHandler(this.tbnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(479, 291);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 41);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(337, 291);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 41);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRecord.Location = new System.Drawing.Point(618, 291);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(100, 41);
            this.btnRecord.TabIndex = 19;
            this.btnRecord.Text = "Ghi";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(764, 291);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 41);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.rBtnCategoryRoom);
            this.groupBox1.Controls.Add(this.rBtnRoomNumber);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(61, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(957, 118);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Location = new System.Drawing.Point(84, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 40);
            this.panel1.TabIndex = 23;
            // 
            // tbSearch
            // 
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(13, 12);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(656, 23);
            this.tbSearch.TabIndex = 22;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Location = new System.Drawing.Point(675, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 39);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(598, 30);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(133, 26);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rBtnCategoryRoom
            // 
            this.rBtnCategoryRoom.AutoSize = true;
            this.rBtnCategoryRoom.Location = new System.Drawing.Point(335, 30);
            this.rBtnCategoryRoom.Name = "rBtnCategoryRoom";
            this.rBtnCategoryRoom.Size = new System.Drawing.Size(120, 26);
            this.rBtnCategoryRoom.TabIndex = 1;
            this.rBtnCategoryRoom.TabStop = true;
            this.rBtnCategoryRoom.Text = "Loại phòng";
            this.rBtnCategoryRoom.UseVisualStyleBackColor = true;
            // 
            // rBtnRoomNumber
            // 
            this.rBtnRoomNumber.AutoSize = true;
            this.rBtnRoomNumber.Location = new System.Drawing.Point(66, 30);
            this.rBtnRoomNumber.Name = "rBtnRoomNumber";
            this.rBtnRoomNumber.Size = new System.Drawing.Size(108, 26);
            this.rBtnRoomNumber.TabIndex = 0;
            this.rBtnRoomNumber.TabStop = true;
            this.rBtnRoomNumber.Text = "Số phòng";
            this.rBtnRoomNumber.UseVisualStyleBackColor = true;
            this.rBtnRoomNumber.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lbRoomId
            // 
            this.lbRoomId.AutoSize = true;
            this.lbRoomId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomId.Location = new System.Drawing.Point(33, 25);
            this.lbRoomId.Name = "lbRoomId";
            this.lbRoomId.Size = new System.Drawing.Size(106, 25);
            this.lbRoomId.TabIndex = 22;
            this.lbRoomId.Text = "Mã phòng:";
            // 
            // tbRoomId
            // 
            this.tbRoomId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRoomId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRoomId.Location = new System.Drawing.Point(159, 25);
            this.tbRoomId.Name = "tbRoomId";
            this.tbRoomId.ReadOnly = true;
            this.tbRoomId.Size = new System.Drawing.Size(309, 30);
            this.tbRoomId.TabIndex = 23;
            // 
            // roomStatus
            // 
            this.roomStatus.AutoSize = true;
            this.roomStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomStatus.Location = new System.Drawing.Point(33, 222);
            this.roomStatus.Name = "roomStatus";
            this.roomStatus.Size = new System.Drawing.Size(106, 25);
            this.roomStatus.TabIndex = 24;
            this.roomStatus.Text = "Tình trạng:";
            // 
            // cbRoomStatus
            // 
            this.cbRoomStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbRoomStatus.Enabled = false;
            this.cbRoomStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoomStatus.FormattingEnabled = true;
            this.cbRoomStatus.Items.AddRange(new object[] {
            "Bình thường",
            "Đang sửa chữa"});
            this.cbRoomStatus.Location = new System.Drawing.Point(159, 222);
            this.cbRoomStatus.Name = "cbRoomStatus";
            this.cbRoomStatus.Size = new System.Drawing.Size(309, 33);
            this.cbRoomStatus.TabIndex = 25;
            // 
            // tbDescribe
            // 
            this.tbDescribe.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbDescribe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescribe.Location = new System.Drawing.Point(709, 204);
            this.tbDescribe.Name = "tbDescribe";
            this.tbDescribe.ReadOnly = true;
            this.tbDescribe.Size = new System.Drawing.Size(309, 64);
            this.tbDescribe.TabIndex = 27;
            this.tbDescribe.Text = "";
            // 
            // describe
            // 
            this.describe.AutoSize = true;
            this.describe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.describe.Location = new System.Drawing.Point(583, 204);
            this.describe.Name = "describe";
            this.describe.Size = new System.Drawing.Size(67, 25);
            this.describe.TabIndex = 26;
            this.describe.Text = "Mô tả:";
            // 
            // frmRoomManage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 750);
            this.Controls.Add(this.tbDescribe);
            this.Controls.Add(this.describe);
            this.Controls.Add(this.cbRoomStatus);
            this.Controls.Add(this.roomStatus);
            this.Controls.Add(this.tbRoomId);
            this.Controls.Add(this.lbRoomId);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbnAdd);
            this.Controls.Add(this.utilities);
            this.Controls.Add(this.cbNumberBed);
            this.Controls.Add(this.cbFloor);
            this.Controls.Add(this.tbArea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.lbUtilities);
            this.Controls.Add(this.lbS);
            this.Controls.Add(this.tbRoomPrice);
            this.Controls.Add(this.priceRoom);
            this.Controls.Add(this.cbCategoryRoom);
            this.Controls.Add(this.roomCategory);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmRoomManage";
            this.Text = "frmRoomManage";
            this.Load += new System.EventHandler(this.frmRoomManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label roomCategory;
        private System.Windows.Forms.ComboBox cbCategoryRoom;
        private System.Windows.Forms.Label priceRoom;
        private System.Windows.Forms.TextBox tbRoomPrice;
        private System.Windows.Forms.Label lbS;
        private System.Windows.Forms.Label lbUtilities;
        private System.Windows.Forms.Label floor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.ComboBox cbFloor;
        private System.Windows.Forms.ComboBox cbNumberBed;
        private System.Windows.Forms.RichTextBox utilities;
        private System.Windows.Forms.Button tbnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rBtnCategoryRoom;
        private System.Windows.Forms.RadioButton rBtnRoomNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbRoomId;
        private System.Windows.Forms.TextBox tbRoomId;
        private System.Windows.Forms.Label roomStatus;
        private System.Windows.Forms.ComboBox cbRoomStatus;
        private System.Windows.Forms.RichTextBox tbDescribe;
        private System.Windows.Forms.Label describe;
    }
}