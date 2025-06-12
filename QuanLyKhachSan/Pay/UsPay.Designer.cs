namespace QuanLyKhachSan
{
    partial class UsPay
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
            this.pnTrangThai = new System.Windows.Forms.Panel();
            this.category = new System.Windows.Forms.Label();
            this.lbRoomNumber = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.AutoSize = true;
            this.guna2Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2Panel3.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Panel3.BorderRadius = 25;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.pnTrangThai);
            this.guna2Panel3.Controls.Add(this.category);
            this.guna2Panel3.Controls.Add(this.lbRoomNumber);
            this.guna2Panel3.Controls.Add(this.guna2Panel1);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(200, 250);
            this.guna2Panel3.TabIndex = 4;
            this.guna2Panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel3_Paint);
            // 
            // pnTrangThai
            // 
            this.pnTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTrangThai.BackColor = System.Drawing.Color.White;
            this.pnTrangThai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnTrangThai.Location = new System.Drawing.Point(31, 19);
            this.pnTrangThai.Name = "pnTrangThai";
            this.pnTrangThai.Size = new System.Drawing.Size(129, 147);
            this.pnTrangThai.TabIndex = 3;
            // 
            // category
            // 
            this.category.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.category.AutoSize = true;
            this.category.BackColor = System.Drawing.Color.White;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.ForeColor = System.Drawing.Color.Black;
            this.category.Location = new System.Drawing.Point(54, 205);
            this.category.Name = "category";
            this.category.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.category.Size = new System.Drawing.Size(92, 25);
            this.category.TabIndex = 2;
            this.category.Text = "Category";
            this.category.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.category.Click += new System.EventHandler(this.category_Click);
            // 
            // lbRoomNumber
            // 
            this.lbRoomNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRoomNumber.BackColor = System.Drawing.Color.White;
            this.lbRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomNumber.ForeColor = System.Drawing.Color.Black;
            this.lbRoomNumber.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbRoomNumber.Location = new System.Drawing.Point(40, 180);
            this.lbRoomNumber.Name = "lbRoomNumber";
            this.lbRoomNumber.Size = new System.Drawing.Size(120, 25);
            this.lbRoomNumber.TabIndex = 0;
            this.lbRoomNumber.Text = "Room code";
            this.lbRoomNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbRoomNumber.Click += new System.EventHandler(this.lbRoomNumber_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.Color.White;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.Black;
            this.lbStatus.Location = new System.Drawing.Point(3, 39);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(63, 20);
            this.lbStatus.TabIndex = 1;
            this.lbStatus.Text = "Status";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbStatus.Visible = false;
            this.lbStatus.Click += new System.EventHandler(this.lbStatus_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoSize = true;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2Panel1.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Panel1.BorderRadius = 25;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.lbStatus);
            this.guna2Panel1.CustomizableEdges.TopLeft = false;
            this.guna2Panel1.CustomizableEdges.TopRight = false;
            this.guna2Panel1.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 172);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(200, 78);
            this.guna2Panel1.TabIndex = 4;
            this.guna2Panel1.Visible = false;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel3_Paint);
            // 
            // UsPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel3);
            this.Name = "UsPay";
            this.Size = new System.Drawing.Size(200, 250);
            this.Load += new System.EventHandler(this.UsPay_Load);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label lbRoomNumber;
        private System.Windows.Forms.Panel pnTrangThai;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
