namespace QuanLyKhachSan
{
    partial class UsHome
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbNoiDung = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.lbNoiDung);
            this.guna2Panel1.Controls.Add(this.lbName);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(2, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(268, 54);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // lbNoiDung
            // 
            this.lbNoiDung.AutoSize = true;
            this.lbNoiDung.BackColor = System.Drawing.Color.White;
            this.lbNoiDung.Location = new System.Drawing.Point(3, 26);
            this.lbNoiDung.Name = "lbNoiDung";
            this.lbNoiDung.Size = new System.Drawing.Size(19, 16);
            this.lbNoiDung.TabIndex = 1;
            this.lbNoiDung.Text = "....";
            this.lbNoiDung.Click += new System.EventHandler(this.lbNoiDung_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(3, 10);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(31, 16);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Tên";
            // 
            // UsHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UsHome";
            this.Size = new System.Drawing.Size(271, 63);
            this.Load += new System.EventHandler(this.UsHome_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbNoiDung;
    }
}
