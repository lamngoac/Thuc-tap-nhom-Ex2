using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giao_dien
{
    public partial class frmQLGiaoVien : Form
    {
        public frmQLGiaoVien()
        {
            InitializeComponent();
        }

        private void btnGVQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGVThem_Click(object sender, EventArgs e)
        {
            new ThemGiaoVien(null).ShowDialog();
            LoadDSGV();
        }
        private void LoadDSGV()
        {
            dgvGiaoVien.DataSource = new CSDL().SelectData("exec selectAllGV");

            dgvGiaoVien.Columns["MaGV"].HeaderText = "Mã GV";
            dgvGiaoVien.Columns["TenGV"].HeaderText = "Tên GV";
            dgvGiaoVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgvGiaoVien.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dgvGiaoVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dgvGiaoVien.Columns["DayMon"].HeaderText = "Dạy Môn";
            dgvGiaoVien.Columns["HocVan"].HeaderText = "Học Vấn";
            dgvGiaoVien.Columns["MaLop"].HeaderText = "Mã Lớp";

        }

        private void dgvGiaoVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmQLGiaoVien_Load(object sender, EventArgs e)
        {
            LoadDSGV();
        }

        private void refreshBTN_Click(object sender, EventArgs e)
        {
            LoadDSGV();
        }

        private void dgvGiaoVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mgv = dgvGiaoVien.Rows[e.RowIndex].Cells["MaGV"].Value.ToString();
                new ThemGiaoVien(mgv).ShowDialog();
                LoadDSGV();
            }
        }

        private void resetValue()
        {
            txbGVThongTin.Text = "";
        }

        private void btnGVTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbGVThongTin.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (cbbGVDanhSach.SelectedIndex != -1)
                {
                    String valueSearch = txbGVThongTin.Text;
                    var db = new CSDL();
                    String sqlSearch = "";
                    if (cbbGVDanhSach.SelectedIndex == 0)
                    {
                        sqlSearch = "exec searchMGV '" + valueSearch + "'";
                        if (db.SelectData(sqlSearch).Rows.Count != 0)
                        {
                            new SearchOutGV(sqlSearch).Show();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (cbbGVDanhSach.SelectedIndex == 1)
                    {
                        sqlSearch = "exec searchTGV N'" + valueSearch + "'";
                        if (db.SelectData(sqlSearch).Rows.Count != 0)
                        {
                            new SearchOutGV(sqlSearch).Show();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (cbbGVDanhSach.SelectedIndex == 2)
                    {
                        sqlSearch = "exec searchGVfromML N'" + valueSearch + "'";
                        if (db.SelectData(sqlSearch).Rows.Count != 0)
                        {
                            new SearchOutGV(sqlSearch).Show();
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

        private void btnGVXoa_Click(object sender, EventArgs e)
        {
            var db = new CSDL();
            if (MessageBox.Show("Bạn muốn xóa giáo viên " + dgvGiaoVien.CurrentRow.Cells["TenGV"].Value.ToString() + " ?", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var tenGV = dgvGiaoVien.CurrentRow.Cells["TenGV"].Value.ToString();
                var idGV = dgvGiaoVien.CurrentRow.Cells["MaGV"].Value.ToString();
                db.del_data(idGV);
                MessageBox.Show("Đã xóa giáo viên : " + tenGV);
            }
            LoadDSGV();
        }
    }
}
