namespace Giao_dien
{
    partial class frmQuanLy
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
            this.pnHocSinh = new System.Windows.Forms.Panel();
            this.lbHocSinh = new System.Windows.Forms.Label();
            this.pnGiaoVien = new System.Windows.Forms.Panel();
            this.lbGiaoVien = new System.Windows.Forms.Label();
            this.pnHocSinh.SuspendLayout();
            this.pnGiaoVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHocSinh
            // 
            this.pnHocSinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnHocSinh.Controls.Add(this.lbHocSinh);
            this.pnHocSinh.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnHocSinh.Location = new System.Drawing.Point(0, 0);
            this.pnHocSinh.Name = "pnHocSinh";
            this.pnHocSinh.Size = new System.Drawing.Size(618, 697);
            this.pnHocSinh.TabIndex = 0;
            this.pnHocSinh.Click += new System.EventHandler(this.pnHocSinh_Click);
            // 
            // lbHocSinh
            // 
            this.lbHocSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHocSinh.AutoSize = true;
            this.lbHocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHocSinh.Location = new System.Drawing.Point(190, 307);
            this.lbHocSinh.Name = "lbHocSinh";
            this.lbHocSinh.Size = new System.Drawing.Size(237, 63);
            this.lbHocSinh.TabIndex = 0;
            this.lbHocSinh.Text = "Học sinh";
            // 
            // pnGiaoVien
            // 
            this.pnGiaoVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnGiaoVien.Controls.Add(this.lbGiaoVien);
            this.pnGiaoVien.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnGiaoVien.Location = new System.Drawing.Point(619, 0);
            this.pnGiaoVien.Name = "pnGiaoVien";
            this.pnGiaoVien.Size = new System.Drawing.Size(618, 697);
            this.pnGiaoVien.TabIndex = 1;
            this.pnGiaoVien.Click += new System.EventHandler(this.pnGiaoVien_Click);
            // 
            // lbGiaoVien
            // 
            this.lbGiaoVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGiaoVien.AutoSize = true;
            this.lbGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaoVien.Location = new System.Drawing.Point(199, 307);
            this.lbGiaoVien.Name = "lbGiaoVien";
            this.lbGiaoVien.Size = new System.Drawing.Size(256, 63);
            this.lbGiaoVien.TabIndex = 0;
            this.lbGiaoVien.Text = "Giáo viên";
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 697);
            this.Controls.Add(this.pnGiaoVien);
            this.Controls.Add(this.pnHocSinh);
            this.Name = "frmQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.pnHocSinh.ResumeLayout(false);
            this.pnHocSinh.PerformLayout();
            this.pnGiaoVien.ResumeLayout(false);
            this.pnGiaoVien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHocSinh;
        private System.Windows.Forms.Label lbHocSinh;
        private System.Windows.Forms.Panel pnGiaoVien;
        private System.Windows.Forms.Label lbGiaoVien;
    }
}