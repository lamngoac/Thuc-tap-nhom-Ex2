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
            dgvGiaoVien.Columns["HocVan"].HeaderText = "Học Vấn";

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

        private void btnGVTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}
