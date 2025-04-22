namespace QuanLyKhachSan
{
    partial class ucRoom
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
            this.lbRoomNumber = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbRoomNumber
            // 
            this.lbRoomNumber.AutoSize = true;
            this.lbRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomNumber.ForeColor = System.Drawing.Color.White;
            this.lbRoomNumber.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbRoomNumber.Location = new System.Drawing.Point(3, 9);
            this.lbRoomNumber.Name = "lbRoomNumber";
            this.lbRoomNumber.Size = new System.Drawing.Size(120, 25);
            this.lbRoomNumber.TabIndex = 0;
            this.lbRoomNumber.Text = "Room code";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbStatus.Location = new System.Drawing.Point(75, 65);
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
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.ForeColor = System.Drawing.Color.White;
            this.category.Location = new System.Drawing.Point(157, 115);
            this.category.Name = "category";
            this.category.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.category.Size = new System.Drawing.Size(92, 25);
            this.category.TabIndex = 2;
            this.category.Text = "Category";
            this.category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.category.Click += new System.EventHandler(this.category_Click);
            // 
            // ucRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Green;
            this.Controls.Add(this.category);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbRoomNumber);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(300, 160);
            this.MinimumSize = new System.Drawing.Size(300, 160);
            this.Name = "ucRoom";
            this.Size = new System.Drawing.Size(300, 160);
            this.Load += new System.EventHandler(this.ucRoom_Load);
            this.Click += new System.EventHandler(this.ucRoom_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRoomNumber;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label category;
    }
}
