﻿namespace Giao_dien
{
    partial class frmQLGiaoVien
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
            this.cbbGVDanhSach = new System.Windows.Forms.ComboBox();
            this.txbGVThongTin = new System.Windows.Forms.TextBox();
            this.btnGVTimKiem = new System.Windows.Forms.Button();
            this.btnGVQuayLai = new System.Windows.Forms.Button();
            this.dgvGiaoVien = new System.Windows.Forms.DataGridView();
            this.btnGVThem = new System.Windows.Forms.Button();
            this.btnGVXoa = new System.Windows.Forms.Button();
            this.refreshBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbGVDanhSach
            // 
            this.cbbGVDanhSach.FormattingEnabled = true;
            this.cbbGVDanhSach.Items.AddRange(new object[] {
            "Mã giáo viên",
            "Tên giáo viên",
            "Mã lớp dạy"});
            this.cbbGVDanhSach.Location = new System.Drawing.Point(164, 46);
            this.cbbGVDanhSach.Name = "cbbGVDanhSach";
            this.cbbGVDanhSach.Size = new System.Drawing.Size(121, 21);
            this.cbbGVDanhSach.TabIndex = 0;
            // 
            // txbGVThongTin
            // 
            this.txbGVThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGVThongTin.Location = new System.Drawing.Point(352, 44);
            this.txbGVThongTin.Name = "txbGVThongTin";
            this.txbGVThongTin.Size = new System.Drawing.Size(314, 23);
            this.txbGVThongTin.TabIndex = 1;
            // 
            // btnGVTimKiem
            // 
            this.btnGVTimKiem.Location = new System.Drawing.Point(743, 40);
            this.btnGVTimKiem.Name = "btnGVTimKiem";
            this.btnGVTimKiem.Size = new System.Drawing.Size(104, 30);
            this.btnGVTimKiem.TabIndex = 2;
            this.btnGVTimKiem.Text = "Tìm kiếm";
            this.btnGVTimKiem.UseVisualStyleBackColor = true;
            this.btnGVTimKiem.Click += new System.EventHandler(this.btnGVTimKiem_Click);
            // 
            // btnGVQuayLai
            // 
            this.btnGVQuayLai.BackColor = System.Drawing.Color.Crimson;
            this.btnGVQuayLai.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGVQuayLai.Location = new System.Drawing.Point(1117, 40);
            this.btnGVQuayLai.Name = "btnGVQuayLai";
            this.btnGVQuayLai.Size = new System.Drawing.Size(104, 30);
            this.btnGVQuayLai.TabIndex = 6;
            this.btnGVQuayLai.Text = "Quay lại";
            this.btnGVQuayLai.UseVisualStyleBackColor = false;
            this.btnGVQuayLai.Click += new System.EventHandler(this.btnGVQuayLai_Click);
            // 
            // dgvGiaoVien
            // 
            this.dgvGiaoVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoVien.Location = new System.Drawing.Point(164, 239);
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.RowHeadersWidth = 51;
            this.dgvGiaoVien.Size = new System.Drawing.Size(965, 256);
            this.dgvGiaoVien.TabIndex = 3;
            this.dgvGiaoVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaoVien_CellContentClick);
            this.dgvGiaoVien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaoVien_CellDoubleClick);
            // 
            // btnGVThem
            // 
            this.btnGVThem.Location = new System.Drawing.Point(336, 586);
            this.btnGVThem.Name = "btnGVThem";
            this.btnGVThem.Size = new System.Drawing.Size(104, 30);
            this.btnGVThem.TabIndex = 4;
            this.btnGVThem.Text = "Thêm";
            this.btnGVThem.UseVisualStyleBackColor = true;
            this.btnGVThem.Click += new System.EventHandler(this.btnGVThem_Click);
            // 
            // btnGVXoa
            // 
            this.btnGVXoa.Location = new System.Drawing.Point(796, 586);
            this.btnGVXoa.Name = "btnGVXoa";
            this.btnGVXoa.Size = new System.Drawing.Size(104, 30);
            this.btnGVXoa.TabIndex = 5;
            this.btnGVXoa.Text = "Xóa";
            this.btnGVXoa.UseVisualStyleBackColor = true;
            this.btnGVXoa.Click += new System.EventHandler(this.btnGVXoa_Click);
            // 
            // refreshBTN
            // 
            this.refreshBTN.Location = new System.Drawing.Point(886, 40);
            this.refreshBTN.Name = "refreshBTN";
            this.refreshBTN.Size = new System.Drawing.Size(104, 30);
            this.refreshBTN.TabIndex = 7;
            this.refreshBTN.Text = "Làm Mới";
            this.refreshBTN.UseVisualStyleBackColor = true;
            this.refreshBTN.Click += new System.EventHandler(this.refreshBTN_Click);
            // 
            // frmQLGiaoVien
            // 
            this.AcceptButton = this.btnGVTimKiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.CancelButton = this.btnGVQuayLai;
            this.ClientSize = new System.Drawing.Size(1231, 716);
            this.Controls.Add(this.refreshBTN);
            this.Controls.Add(this.dgvGiaoVien);
            this.Controls.Add(this.btnGVXoa);
            this.Controls.Add(this.btnGVThem);
            this.Controls.Add(this.btnGVQuayLai);
            this.Controls.Add(this.btnGVTimKiem);
            this.Controls.Add(this.txbGVThongTin);
            this.Controls.Add(this.cbbGVDanhSach);
            this.Name = "frmQLGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý giáo viên";
            this.Load += new System.EventHandler(this.frmQLGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbGVDanhSach;
        private System.Windows.Forms.TextBox txbGVThongTin;
        private System.Windows.Forms.Button btnGVTimKiem;
        private System.Windows.Forms.Button btnGVQuayLai;
        private System.Windows.Forms.DataGridView dgvGiaoVien;
        private System.Windows.Forms.Button btnGVThem;
        private System.Windows.Forms.Button btnGVXoa;
        private System.Windows.Forms.Button refreshBTN;
    }
}