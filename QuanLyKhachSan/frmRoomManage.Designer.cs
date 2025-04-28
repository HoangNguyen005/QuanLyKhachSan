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
            this.numberPeople = new System.Windows.Forms.Label();
            this.tbNumberPeople = new System.Windows.Forms.TextBox();
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
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lbRoomId = new System.Windows.Forms.Label();
            this.tbRoomId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 481);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1062, 287);
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
            "Phòng thường",
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
            this.priceRoom.Location = new System.Drawing.Point(33, 166);
            this.priceRoom.Name = "priceRoom";
            this.priceRoom.Size = new System.Drawing.Size(108, 25);
            this.priceRoom.TabIndex = 3;
            this.priceRoom.Text = "Giá phòng:";
            // 
            // numberPeople
            // 
            this.numberPeople.AutoSize = true;
            this.numberPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberPeople.Location = new System.Drawing.Point(33, 120);
            this.numberPeople.Name = "numberPeople";
            this.numberPeople.Size = new System.Drawing.Size(96, 25);
            this.numberPeople.TabIndex = 4;
            this.numberPeople.Text = "Số người:";
            // 
            // tbNumberPeople
            // 
            this.tbNumberPeople.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNumberPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumberPeople.Location = new System.Drawing.Point(159, 120);
            this.tbNumberPeople.Name = "tbNumberPeople";
            this.tbNumberPeople.ReadOnly = true;
            this.tbNumberPeople.Size = new System.Drawing.Size(309, 30);
            this.tbNumberPeople.TabIndex = 5;
            // 
            // tbRoomPrice
            // 
            this.tbRoomPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRoomPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRoomPrice.Location = new System.Drawing.Point(159, 166);
            this.tbRoomPrice.Name = "tbRoomPrice";
            this.tbRoomPrice.ReadOnly = true;
            this.tbRoomPrice.Size = new System.Drawing.Size(309, 30);
            this.tbRoomPrice.TabIndex = 6;
            // 
            // lbS
            // 
            this.lbS.AutoSize = true;
            this.lbS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbS.Location = new System.Drawing.Point(33, 212);
            this.lbS.Name = "lbS";
            this.lbS.Size = new System.Drawing.Size(93, 25);
            this.lbS.TabIndex = 7;
            this.lbS.Text = "Diện tích:";
            // 
            // lbUtilities
            // 
            this.lbUtilities.AutoSize = true;
            this.lbUtilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUtilities.Location = new System.Drawing.Point(606, 120);
            this.lbUtilities.Name = "lbUtilities";
            this.lbUtilities.Size = new System.Drawing.Size(87, 25);
            this.lbUtilities.TabIndex = 8;
            this.lbUtilities.Text = "Tiện ích:";
            // 
            // floor
            // 
            this.floor.AutoSize = true;
            this.floor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floor.Location = new System.Drawing.Point(606, 25);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(64, 25);
            this.floor.TabIndex = 9;
            this.floor.Text = "Tầng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(606, 74);
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
            this.tbArea.Location = new System.Drawing.Point(159, 212);
            this.tbArea.Name = "tbArea";
            this.tbArea.ReadOnly = true;
            this.tbArea.Size = new System.Drawing.Size(309, 30);
            this.tbArea.TabIndex = 11;
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
            this.cbFloor.Location = new System.Drawing.Point(732, 25);
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
            this.cbNumberBed.Location = new System.Drawing.Point(732, 74);
            this.cbNumberBed.Name = "cbNumberBed";
            this.cbNumberBed.Size = new System.Drawing.Size(309, 33);
            this.cbNumberBed.TabIndex = 13;
            // 
            // utilities
            // 
            this.utilities.BackColor = System.Drawing.SystemColors.ControlLight;
            this.utilities.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.utilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilities.Location = new System.Drawing.Point(732, 123);
            this.utilities.Name = "utilities";
            this.utilities.ReadOnly = true;
            this.utilities.Size = new System.Drawing.Size(309, 119);
            this.utilities.TabIndex = 15;
            this.utilities.Text = "";
            // 
            // tbnAdd
            // 
            this.tbnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tbnAdd.Location = new System.Drawing.Point(203, 260);
            this.tbnAdd.Name = "tbnAdd";
            this.tbnAdd.Size = new System.Drawing.Size(100, 41);
            this.tbnAdd.TabIndex = 16;
            this.tbnAdd.Text = "Thêm";
            this.tbnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(481, 260);
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
            this.btnUpdate.Location = new System.Drawing.Point(339, 260);
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
            this.btnRecord.Location = new System.Drawing.Point(620, 260);
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
            this.btnCancel.Location = new System.Drawing.Point(766, 260);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 41);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(61, 323);
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
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(335, 30);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(120, 26);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Loại phòng";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(66, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(108, 26);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Số phòng";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
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
            // frmRoomManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 768);
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
            this.Controls.Add(this.tbNumberPeople);
            this.Controls.Add(this.numberPeople);
            this.Controls.Add(this.priceRoom);
            this.Controls.Add(this.cbCategoryRoom);
            this.Controls.Add(this.roomCategory);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Label numberPeople;
        private System.Windows.Forms.TextBox tbNumberPeople;
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
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbRoomId;
        private System.Windows.Forms.TextBox tbRoomId;
    }
}