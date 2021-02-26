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
    }
}
