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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbHocSinh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnGiaoVien = new System.Windows.Forms.Panel();
            this.lbGiaoVien = new System.Windows.Forms.Label();
            this.pnLop = new System.Windows.Forms.Panel();
            this.pnHocSinh.SuspendLayout();
            this.pnGiaoVien.SuspendLayout();
            this.pnLop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHocSinh
            // 
            this.pnHocSinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnHocSinh.Controls.Add(this.panel1);
            this.pnHocSinh.Controls.Add(this.lbHocSinh);
            this.pnHocSinh.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnHocSinh.Location = new System.Drawing.Point(0, 0);
            this.pnHocSinh.Name = "pnHocSinh";
            this.pnHocSinh.Size = new System.Drawing.Size(402, 609);
            this.pnHocSinh.TabIndex = 0;
            this.pnHocSinh.Click += new System.EventHandler(this.pnHocSinh_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(400, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 697);
            this.panel1.TabIndex = 2;
            // 
            // lbHocSinh
            // 
            this.lbHocSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHocSinh.AutoSize = true;
            this.lbHocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHocSinh.Location = new System.Drawing.Point(56, 307);
            this.lbHocSinh.Name = "lbHocSinh";
            this.lbHocSinh.Size = new System.Drawing.Size(237, 63);
            this.lbHocSinh.TabIndex = 0;
            this.lbHocSinh.Text = "Học sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 307);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lớp";
            // 
            // pnGiaoVien
            // 
            this.pnGiaoVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnGiaoVien.Controls.Add(this.lbGiaoVien);
            this.pnGiaoVien.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnGiaoVien.Location = new System.Drawing.Point(639, 0);
            this.pnGiaoVien.Name = "pnGiaoVien";
            this.pnGiaoVien.Size = new System.Drawing.Size(389, 609);
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
            this.lbGiaoVien.Location = new System.Drawing.Point(92, 307);
            this.lbGiaoVien.Name = "lbGiaoVien";
            this.lbGiaoVien.Size = new System.Drawing.Size(256, 63);
            this.lbGiaoVien.TabIndex = 0;
            this.lbGiaoVien.Text = "Giáo viên";
            // 
            // pnLop
            // 
            this.pnLop.BackColor = System.Drawing.Color.Cyan;
            this.pnLop.Controls.Add(this.label1);
            this.pnLop.Location = new System.Drawing.Point(352, 0);
            this.pnLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnLop.Name = "pnLop";
            this.pnLop.Size = new System.Drawing.Size(343, 706);
            this.pnLop.TabIndex = 2;
            this.pnLop.Click += new System.EventHandler(this.pnLop_Click);
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.pnLop);
            this.Controls.Add(this.pnGiaoVien);
            this.Controls.Add(this.pnHocSinh);
            this.Name = "frmQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.pnHocSinh.ResumeLayout(false);
            this.pnHocSinh.PerformLayout();
            this.pnGiaoVien.ResumeLayout(false);
            this.pnGiaoVien.PerformLayout();
            this.pnLop.ResumeLayout(false);
            this.pnLop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHocSinh;
        private System.Windows.Forms.Label lbHocSinh;
        private System.Windows.Forms.Panel pnGiaoVien;
        private System.Windows.Forms.Label lbGiaoVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnLop;
    }
}