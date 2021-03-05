
namespace Giao_dien
{
    partial class frmQLLop
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
            this.refreshBTN = new System.Windows.Forms.Button();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.btnLopXoa = new System.Windows.Forms.Button();
            this.btnLopThem = new System.Windows.Forms.Button();
            this.btnGVQuayLai = new System.Windows.Forms.Button();
            this.btnLopTimKiem = new System.Windows.Forms.Button();
            this.txbLopThongTin = new System.Windows.Forms.TextBox();
            this.cbbLopDanhSach = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // refreshBTN
            // 
            this.refreshBTN.Location = new System.Drawing.Point(309, 144);
            this.refreshBTN.Margin = new System.Windows.Forms.Padding(4);
            this.refreshBTN.Name = "refreshBTN";
            this.refreshBTN.Size = new System.Drawing.Size(139, 37);
            this.refreshBTN.TabIndex = 15;
            this.refreshBTN.Text = "Làm Mới";
            this.refreshBTN.UseVisualStyleBackColor = true;
            this.refreshBTN.Click += new System.EventHandler(this.refreshBTN_Click);
            // 
            // dgvLop
            // 
            this.dgvLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Location = new System.Drawing.Point(59, 299);
            this.dgvLop.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.RowHeadersWidth = 51;
            this.dgvLop.Size = new System.Drawing.Size(461, 315);
            this.dgvLop.TabIndex = 11;
            this.dgvLop.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLop_CellDoubleClick);
            // 
            // btnLopXoa
            // 
            this.btnLopXoa.Location = new System.Drawing.Point(587, 459);
            this.btnLopXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnLopXoa.Name = "btnLopXoa";
            this.btnLopXoa.Size = new System.Drawing.Size(139, 37);
            this.btnLopXoa.TabIndex = 13;
            this.btnLopXoa.Text = "Xóa";
            this.btnLopXoa.UseVisualStyleBackColor = true;
            this.btnLopXoa.Click += new System.EventHandler(this.btnLopXoa_Click);
            // 
            // btnLopThem
            // 
            this.btnLopThem.Location = new System.Drawing.Point(587, 327);
            this.btnLopThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnLopThem.Name = "btnLopThem";
            this.btnLopThem.Size = new System.Drawing.Size(139, 37);
            this.btnLopThem.TabIndex = 12;
            this.btnLopThem.Text = "Thêm";
            this.btnLopThem.UseVisualStyleBackColor = true;
            this.btnLopThem.Click += new System.EventHandler(this.btnLopThem_Click);
            // 
            // btnGVQuayLai
            // 
            this.btnGVQuayLai.BackColor = System.Drawing.Color.Crimson;
            this.btnGVQuayLai.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGVQuayLai.Location = new System.Drawing.Point(587, 144);
            this.btnGVQuayLai.Margin = new System.Windows.Forms.Padding(4);
            this.btnGVQuayLai.Name = "btnGVQuayLai";
            this.btnGVQuayLai.Size = new System.Drawing.Size(139, 37);
            this.btnGVQuayLai.TabIndex = 14;
            this.btnGVQuayLai.Text = "Quay lại";
            this.btnGVQuayLai.UseVisualStyleBackColor = false;
            this.btnGVQuayLai.Click += new System.EventHandler(this.btnLopQuayLai_Click);
            // 
            // btnLopTimKiem
            // 
            this.btnLopTimKiem.Location = new System.Drawing.Point(59, 144);
            this.btnLopTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnLopTimKiem.Name = "btnLopTimKiem";
            this.btnLopTimKiem.Size = new System.Drawing.Size(139, 37);
            this.btnLopTimKiem.TabIndex = 10;
            this.btnLopTimKiem.Text = "Tìm kiếm";
            this.btnLopTimKiem.UseVisualStyleBackColor = true;
            this.btnLopTimKiem.Click += new System.EventHandler(this.btnLopTimKiem_Click);
            // 
            // txbLopThongTin
            // 
            this.txbLopThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLopThongTin.Location = new System.Drawing.Point(309, 59);
            this.txbLopThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.txbLopThongTin.Name = "txbLopThongTin";
            this.txbLopThongTin.Size = new System.Drawing.Size(417, 26);
            this.txbLopThongTin.TabIndex = 9;
            // 
            // cbbLopDanhSach
            // 
            this.cbbLopDanhSach.Items.AddRange(new object[] {
            "Mã lớp",
            "Tên lớp"});
            this.cbbLopDanhSach.Location = new System.Drawing.Point(59, 62);
            this.cbbLopDanhSach.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLopDanhSach.Name = "cbbLopDanhSach";
            this.cbbLopDanhSach.Size = new System.Drawing.Size(160, 24);
            this.cbbLopDanhSach.TabIndex = 8;
            // 
            // frmQLLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 701);
            this.Controls.Add(this.refreshBTN);
            this.Controls.Add(this.dgvLop);
            this.Controls.Add(this.btnLopXoa);
            this.Controls.Add(this.btnLopThem);
            this.Controls.Add(this.btnGVQuayLai);
            this.Controls.Add(this.btnLopTimKiem);
            this.Controls.Add(this.txbLopThongTin);
            this.Controls.Add(this.cbbLopDanhSach);
            this.Name = "frmQLLop";
            this.Text = "frmQLLop";
            this.Load += new System.EventHandler(this.frmQLLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refreshBTN;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.Button btnLopXoa;
        private System.Windows.Forms.Button btnLopThem;
        private System.Windows.Forms.Button btnGVQuayLai;
        private System.Windows.Forms.Button btnLopTimKiem;
        private System.Windows.Forms.TextBox txbLopThongTin;
        private System.Windows.Forms.ComboBox cbbLopDanhSach;
    }
}