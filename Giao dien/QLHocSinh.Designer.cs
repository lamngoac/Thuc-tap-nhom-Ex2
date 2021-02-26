namespace Giao_dien
{
    partial class frmQLHocSinh
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
            this.cbbHSDanhSach = new System.Windows.Forms.ComboBox();
            this.txbHSThongTin = new System.Windows.Forms.TextBox();
            this.btnHSTimKiem = new System.Windows.Forms.Button();
            this.btnHSThem = new System.Windows.Forms.Button();
            this.btnHSXoa = new System.Windows.Forms.Button();
            this.btnHSQuayLai = new System.Windows.Forms.Button();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLop,
            this.MaHS,
            this.TenHS,
            this.GioiTinh,
            this.NgaySinh,
            this.DiaChi});
            this.dataGridView1.Location = new System.Drawing.Point(164, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(965, 258);
            this.dataGridView1.TabIndex = 3;
            // 
            // cbbHSDanhSach
            // 
            this.cbbHSDanhSach.FormattingEnabled = true;
            this.cbbHSDanhSach.Items.AddRange(new object[] {
            "Mã học sinh",
            "Tên học sinh",
            "Mã lớp theo học"});
            this.cbbHSDanhSach.Location = new System.Drawing.Point(164, 46);
            this.cbbHSDanhSach.Name = "cbbHSDanhSach";
            this.cbbHSDanhSach.Size = new System.Drawing.Size(121, 21);
            this.cbbHSDanhSach.TabIndex = 0;
            // 
            // txbHSThongTin
            // 
            this.txbHSThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHSThongTin.Location = new System.Drawing.Point(352, 44);
            this.txbHSThongTin.Name = "txbHSThongTin";
            this.txbHSThongTin.Size = new System.Drawing.Size(314, 23);
            this.txbHSThongTin.TabIndex = 1;
            // 
            // btnHSTimKiem
            // 
            this.btnHSTimKiem.Location = new System.Drawing.Point(743, 40);
            this.btnHSTimKiem.Name = "btnHSTimKiem";
            this.btnHSTimKiem.Size = new System.Drawing.Size(104, 30);
            this.btnHSTimKiem.TabIndex = 2;
            this.btnHSTimKiem.Text = "Tìm kiếm";
            this.btnHSTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnHSThem
            // 
            this.btnHSThem.Location = new System.Drawing.Point(336, 586);
            this.btnHSThem.Name = "btnHSThem";
            this.btnHSThem.Size = new System.Drawing.Size(104, 30);
            this.btnHSThem.TabIndex = 4;
            this.btnHSThem.Text = "Thêm";
            this.btnHSThem.UseVisualStyleBackColor = true;
            // 
            // btnHSXoa
            // 
            this.btnHSXoa.Location = new System.Drawing.Point(796, 586);
            this.btnHSXoa.Name = "btnHSXoa";
            this.btnHSXoa.Size = new System.Drawing.Size(104, 30);
            this.btnHSXoa.TabIndex = 5;
            this.btnHSXoa.Text = "Xóa";
            this.btnHSXoa.UseVisualStyleBackColor = true;
            // 
            // btnHSQuayLai
            // 
            this.btnHSQuayLai.BackColor = System.Drawing.Color.Crimson;
            this.btnHSQuayLai.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHSQuayLai.Location = new System.Drawing.Point(1117, 40);
            this.btnHSQuayLai.Name = "btnHSQuayLai";
            this.btnHSQuayLai.Size = new System.Drawing.Size(104, 30);
            this.btnHSQuayLai.TabIndex = 6;
            this.btnHSQuayLai.Text = "Quay lại";
            this.btnHSQuayLai.UseVisualStyleBackColor = false;
            this.btnHSQuayLai.Click += new System.EventHandler(this.btnHSQuayLai_Click);
            // 
            // MaLop
            // 
            this.MaLop.HeaderText = "Mã lớp";
            this.MaLop.Name = "MaLop";
            // 
            // MaHS
            // 
            this.MaHS.HeaderText = "Mã học sinh";
            this.MaHS.Name = "MaHS";
            // 
            // TenHS
            // 
            this.TenHS.HeaderText = "Tên học sinh";
            this.TenHS.Name = "TenHS";
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // NgaySinh
            // 
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // frmQLHocSinh
            // 
            this.AcceptButton = this.btnHSTimKiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.CancelButton = this.btnHSQuayLai;
            this.ClientSize = new System.Drawing.Size(1263, 757);
            this.Controls.Add(this.btnHSXoa);
            this.Controls.Add(this.btnHSThem);
            this.Controls.Add(this.btnHSQuayLai);
            this.Controls.Add(this.btnHSTimKiem);
            this.Controls.Add(this.txbHSThongTin);
            this.Controls.Add(this.cbbHSDanhSach);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmQLHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý học sinh";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbbHSDanhSach;
        private System.Windows.Forms.TextBox txbHSThongTin;
        private System.Windows.Forms.Button btnHSTimKiem;
        private System.Windows.Forms.Button btnHSThem;
        private System.Windows.Forms.Button btnHSXoa;
        private System.Windows.Forms.Button btnHSQuayLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
    }
}