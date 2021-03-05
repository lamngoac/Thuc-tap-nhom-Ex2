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
    public partial class frmQLLop : Form
    {
        public frmQLLop()
        {
            InitializeComponent();
        }

        private void btnLopQuayLai_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát??", "Exit", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    this.Close();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btnLopThem_Click(object sender, EventArgs e)
        {
            new ThemLop(null).Show();
            LoadDSLop();
        }

        private void LoadDSLop()
        {
            dgvLop.DataSource = new CSDL().SelectData("select MaLop, TenLop from LOP");

            dgvLop.Columns["MaLop"].HeaderText = "Mã Lớp";
            dgvLop.Columns["TenLop"].HeaderText = "Tên Lớp";
        }

        private void frmQLLop_Load(object sender, EventArgs e)
        {
            LoadDSLop();
        }

        private void refreshBTN_Click(object sender, EventArgs e)
        {
            LoadDSLop();
        }

        private void dgvLop_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var maLop = dgvLop.Rows[e.RowIndex].Cells["MaLop"].Value.ToString();
                new ThemLop(maLop).ShowDialog();
                LoadDSLop();
            }
        }

        private void resetValue()
        {
            txbLopThongTin.Text = "";
        }

        private void btnLopTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbLopThongTin.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (cbbLopDanhSach.SelectedIndex != -1)
                {
                    string valueSearch = txbLopThongTin.Text;
                    var db = new CSDL();
                    string sqlSearch = "";
                    switch (cbbLopDanhSach.SelectedItem)
                    {
                        case "Mã lớp":
                            sqlSearch = "select MaLop, TenLop from LOP where MaLop = '" + valueSearch + "'";
                            if (db.SelectData(sqlSearch).Rows.Count != 0)
                            {
                                dgvLop.DataSource = new CSDL().SelectData(sqlSearch);

                                dgvLop.Columns["MaLop"].HeaderText = "Mã Lớp";
                                dgvLop.Columns["TenLop"].HeaderText = "Tên Lớp";
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            break;
                        case "Tên lớp":
                            sqlSearch = "select MaLop, TenLop from LOP where TenLop = '" + valueSearch + "'";
                            if (db.SelectData(sqlSearch).Rows.Count != 0)
                            {
                                dgvLop.DataSource = new CSDL().SelectData(sqlSearch);

                                dgvLop.Columns["MaLop"].HeaderText = "Mã Lớp";
                                dgvLop.Columns["TenLop"].HeaderText = "Tên Lớp";
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            break;
                    }
                }
                resetValue();
            }
        }

        private void btnLopXoa_Click(object sender, EventArgs e)
        {
            var db = new CSDL();
            if (MessageBox.Show("Bạn muốn xóa lớp " + dgvLop.CurrentRow.Cells["TenLop"].Value.ToString() + " ?", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var tenLop = dgvLop.CurrentRow.Cells["TenLop"].Value.ToString();
                var idLop = dgvLop.CurrentRow.Cells["MaLop"].Value.ToString();
                db.del_dataLop(idLop);
                MessageBox.Show("Đã xóa lớp : " + tenLop);
            }
            LoadDSLop();
        }
    }
}
