using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Giao_dien
{
    public partial class frmQLHocSinh : Form
    {
        public frmQLHocSinh()
        {
            InitializeComponent();
        }

        private void btnHSQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQLHocSinh_Load(object sender, EventArgs e)
        {
            LoadHS();
        }
        private void LoadHS()
        {
            dgvHocSinh.DataSource = new CSDL().SelectData("exec selectAllHS");

            dgvHocSinh.Columns["MaHS"].HeaderText = "Mã HS";
            dgvHocSinh.Columns["TenHS"].HeaderText = "Tên HS";
            dgvHocSinh.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgvHocSinh.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dgvHocSinh.Columns["GioiTinh"].HeaderText = "Giới Tính";
        }

        private void btnHSThem_Click(object sender, EventArgs e)
        {
            new ThemHocSinh(null).ShowDialog();
            LoadHS();
        }

        private void dgvHocSinh_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var msv = dgvHocSinh.Rows[e.RowIndex].Cells["MaHS"].Value.ToString();
                new ThemHocSinh(msv).ShowDialog();
                LoadHS();
            }
        }

        private void btnHSXoa_Click(object sender, EventArgs e)
        {
            var db = new CSDL();
            if (MessageBox.Show("Bạn muốn xóa học sinh " + dgvHocSinh.CurrentRow.Cells["TenHS"].Value.ToString() + " ?", "Warning!!!" ,MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes )
            {
                db.del_dataHS(dgvHocSinh.CurrentRow.Cells["MaHS"].Value.ToString());
            }
            
            // Hien thi mess thong bao
         
            LoadHS();
        }

        private void resetValue()
        {
            txbHSThongTin.Text = "";
        }


        private void btnHSTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbHSThongTin.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (cbbHSDanhSach.SelectedIndex != -1)
                {
                    String valueSearch = txbHSThongTin.Text;
                    var db = new CSDL();
                    String sqlSearch = "";
                    if (cbbHSDanhSach.SelectedIndex == 0)
                    {
                        sqlSearch = "exec searchMHS '" + valueSearch + "'";
                        if (db.SelectData(sqlSearch).Rows.Count != 0)
                        {
                            new SearchOut(sqlSearch).Show();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (cbbHSDanhSach.SelectedIndex == 1)
                    {
                        sqlSearch = "exec searchTHS N'" + valueSearch + "'";
                        if (db.SelectData(sqlSearch).Rows.Count != 0)
                        {
                            new SearchOut(sqlSearch).Show();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (cbbHSDanhSach.SelectedIndex == 2)
                    {
                        sqlSearch = "exec searchHSfromML N'" + valueSearch + "'";
                        if (db.SelectData(sqlSearch).Rows.Count != 0)
                        {
                            new SearchOut(sqlSearch).Show();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                resetValue();
            }
        }
    }
}
