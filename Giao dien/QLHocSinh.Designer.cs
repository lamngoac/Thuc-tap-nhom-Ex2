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
            this.dgvHocSinh = new System.Windows.Forms.DataGridView();
            this.cbbHSDanhSach = new System.Windows.Forms.ComboBox();
            this.txbHSThongTin = new System.Windows.Forms.TextBox();
            this.btnHSTimKiem = new System.Windows.Forms.Button();
            this.btnHSThem = new System.Windows.Forms.Button();
            this.btnHSXoa = new System.Windows.Forms.Button();
            this.btnHSQuayLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHocSinh
            // 
            this.dgvHocSinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinh.Location = new System.Drawing.Point(219, 294);
            this.dgvHocSinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.RowHeadersWidth = 51;
            this.dgvHocSinh.Size = new System.Drawing.Size(1287, 318);
            this.dgvHocSinh.TabIndex = 3;
            // 
            // cbbHSDanhSach
            // 
            this.cbbHSDanhSach.FormattingEnabled = true;
            this.cbbHSDanhSach.Items.AddRange(new object[] {
            "Mã học sinh",
            "Tên học sinh",
            "Mã lớp theo học"});
            this.cbbHSDanhSach.Location = new System.Drawing.Point(219, 57);
            this.cbbHSDanhSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbHSDanhSach.Name = "cbbHSDanhSach";
            this.cbbHSDanhSach.Size = new System.Drawing.Size(160, 24);
            this.cbbHSDanhSach.TabIndex = 0;
            // 
            // txbHSThongTin
            // 
            this.txbHSThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHSThongTin.Location = new System.Drawing.Point(469, 54);
            this.txbHSThongTin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbHSThongTin.Name = "txbHSThongTin";
            this.txbHSThongTin.Size = new System.Drawing.Size(417, 26);
            this.txbHSThongTin.TabIndex = 1;
            // 
            // btnHSTimKiem
            // 
            this.btnHSTimKiem.Location = new System.Drawing.Point(991, 49);
            this.btnHSTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHSTimKiem.Name = "btnHSTimKiem";
            this.btnHSTimKiem.Size = new System.Drawing.Size(139, 37);
            this.btnHSTimKiem.TabIndex = 2;
            this.btnHSTimKiem.Text = "Tìm kiếm";
            this.btnHSTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnHSThem
            // 
            this.btnHSThem.Location = new System.Drawing.Point(448, 721);
            this.btnHSThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHSThem.Name = "btnHSThem";
            this.btnHSThem.Size = new System.Drawing.Size(139, 37);
            this.btnHSThem.TabIndex = 4;
            this.btnHSThem.Text = "Thêm";
            this.btnHSThem.UseVisualStyleBackColor = true;
            this.btnHSThem.Click += new System.EventHandler(this.btnHSThem_Click);
            // 
            // btnHSXoa
            // 
            this.btnHSXoa.Location = new System.Drawing.Point(1061, 721);
            this.btnHSXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHSXoa.Name = "btnHSXoa";
            this.btnHSXoa.Size = new System.Drawing.Size(139, 37);
            this.btnHSXoa.TabIndex = 5;
            this.btnHSXoa.Text = "Xóa";
            this.btnHSXoa.UseVisualStyleBackColor = true;
            // 
            // btnHSQuayLai
            // 
            this.btnHSQuayLai.BackColor = System.Drawing.Color.Crimson;
            this.btnHSQuayLai.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHSQuayLai.Location = new System.Drawing.Point(1489, 49);
            this.btnHSQuayLai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHSQuayLai.Name = "btnHSQuayLai";
            this.btnHSQuayLai.Size = new System.Drawing.Size(139, 37);
            this.btnHSQuayLai.TabIndex = 6;
            this.btnHSQuayLai.Text = "Quay lại";
            this.btnHSQuayLai.UseVisualStyleBackColor = false;
            this.btnHSQuayLai.Click += new System.EventHandler(this.btnHSQuayLai_Click);
            // 
            // frmQLHocSinh
            // 
            this.AcceptButton = this.btnHSTimKiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.CancelButton = this.btnHSQuayLai;
            this.ClientSize = new System.Drawing.Size(1684, 932);
            this.Controls.Add(this.btnHSXoa);
            this.Controls.Add(this.btnHSThem);
            this.Controls.Add(this.btnHSQuayLai);
            this.Controls.Add(this.btnHSTimKiem);
            this.Controls.Add(this.txbHSThongTin);
            this.Controls.Add(this.cbbHSDanhSach);
            this.Controls.Add(this.dgvHocSinh);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmQLHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý học sinh";
            this.Load += new System.EventHandler(this.frmQLHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHocSinh;
        private System.Windows.Forms.ComboBox cbbHSDanhSach;
        private System.Windows.Forms.TextBox txbHSThongTin;
        private System.Windows.Forms.Button btnHSTimKiem;
        private System.Windows.Forms.Button btnHSThem;
        private System.Windows.Forms.Button btnHSXoa;
        private System.Windows.Forms.Button btnHSQuayLai;
    }
}