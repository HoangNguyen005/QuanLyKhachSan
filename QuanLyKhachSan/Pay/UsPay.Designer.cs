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
            this.lbStatus = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            this.lbRoomNumber = new System.Windows.Forms.Label();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.AutoSize = true;
            this.guna2Panel3.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Panel3.BorderRadius = 25;
            this.guna2Panel3.BorderThickness = 2;
            this.guna2Panel3.Controls.Add(this.lbStatus);
            this.guna2Panel3.Controls.Add(this.category);
            this.guna2Panel3.Controls.Add(this.lbRoomNumber);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(200, 250);
            this.guna2Panel3.TabIndex = 4;
            this.guna2Panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel3_Paint);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbStatus.Location = new System.Drawing.Point(47, 165);
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
            this.category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.ForeColor = System.Drawing.Color.White;
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
            this.lbRoomNumber.AutoSize = true;
            this.lbRoomNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lbRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomNumber.ForeColor = System.Drawing.Color.White;
            this.lbRoomNumber.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbRoomNumber.Location = new System.Drawing.Point(31, 140);
            this.lbRoomNumber.Name = "lbRoomNumber";
            this.lbRoomNumber.Size = new System.Drawing.Size(120, 25);
            this.lbRoomNumber.TabIndex = 0;
            this.lbRoomNumber.Text = "Room code";
            this.lbRoomNumber.Click += new System.EventHandler(this.lbRoomNumber_Click);
            // 
            // UsPhay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel3);
            this.Name = "UsPhay";
            this.Size = new System.Drawing.Size(200, 250);
            this.Load += new System.EventHandler(this.UsPay_Load);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label lbRoomNumber;
    }
}
