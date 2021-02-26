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
    public partial class frmQuanLy : Form
    {
        public frmQuanLy()
        {
            InitializeComponent();
        }

        private void pnHocSinh_Click(object sender, EventArgs e)
        {
            frmQLHocSinh qlHocSinh = new frmQLHocSinh();
            qlHocSinh.Visible = true;
        }

        private void pnGiaoVien_Click(object sender, EventArgs e)
        {
            frmQLGiaoVien qlGiaoVien = new frmQLGiaoVien();
            qlGiaoVien.Visible = true;
        }
    }
}
