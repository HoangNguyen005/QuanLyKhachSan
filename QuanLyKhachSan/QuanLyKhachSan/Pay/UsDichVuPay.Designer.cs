namespace QuanLyKhachSan
{
    partial class UsDichVuPay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnUcThem = new Guna.UI2.WinForms.Guna2Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            this.lbRoomNumber = new System.Windows.Forms.Label();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.AutoSize = true;
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel3.BorderRadius = 25;
            this.guna2Panel3.BorderThickness = 2;
            this.guna2Panel3.Controls.Add(this.guna2Panel1);
            this.guna2Panel3.Controls.Add(this.lbStatus);
            this.guna2Panel3.Controls.Add(this.category);
            this.guna2Panel3.Controls.Add(this.lbRoomNumber);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(200, 250);
            this.guna2Panel3.TabIndex = 5;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel1.BorderRadius = 25;
            this.guna2Panel1.Controls.Add(this.btnUcThem);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(194, 134);
            this.guna2Panel1.TabIndex = 3;
            // 
            // btnUcThem
            // 
            this.btnUcThem.BorderColor = System.Drawing.Color.Gray;
            this.btnUcThem.BorderRadius = 25;
            this.btnUcThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUcThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUcThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUcThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUcThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUcThem.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUcThem.ForeColor = System.Drawing.Color.White;
            this.btnUcThem.Location = new System.Drawing.Point(0, 0);
            this.btnUcThem.Name = "btnUcThem";
            this.btnUcThem.Size = new System.Drawing.Size(194, 134);
            this.btnUcThem.TabIndex = 0;
            this.btnUcThem.Text = "+";
            this.btnUcThem.Click += new System.EventHandler(this.btnUcThem_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.Color.White;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbStatus.Location = new System.Drawing.Point(47, 176);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(85, 29);
            this.lbStatus.TabIndex = 1;
            this.lbStatus.Text = "Status";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbStatus.Click += new System.EventHandler(this.lbStatus_Click);
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.BackColor = System.Drawing.Color.White;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.ForeColor = System.Drawing.Color.Black;
            this.category.Location = new System.Drawing.Point(45, 205);
            this.category.Name = "category";
            this.category.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.category.Size = new System.Drawing.Size(92, 25);
            this.category.TabIndex = 2;
            this.category.Text = "Category";
            this.category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.category.Click += new System.EventHandler(this.category_Click);
            // 
            // lbRoomNumber
            // 
            this.lbRoomNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbRoomNumber.AutoSize = true;
            this.lbRoomNumber.BackColor = System.Drawing.Color.White;
            this.lbRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomNumber.ForeColor = System.Drawing.Color.Black;
            this.lbRoomNumber.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbRoomNumber.Location = new System.Drawing.Point(31, 140);
            this.lbRoomNumber.Name = "lbRoomNumber";
            this.lbRoomNumber.Size = new System.Drawing.Size(120, 25);
            this.lbRoomNumber.TabIndex = 0;
            this.lbRoomNumber.Text = "Room code";
            this.lbRoomNumber.Click += new System.EventHandler(this.lbRoomNumber_Click);
            // 
            // UsDichVuPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel3);
            this.Name = "UsDichVuPay";
            this.Size = new System.Drawing.Size(200, 250);
            this.Load += new System.EventHandler(this.UsDichVuPay_Load);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnUcThem;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label lbRoomNumber;
    }
}
