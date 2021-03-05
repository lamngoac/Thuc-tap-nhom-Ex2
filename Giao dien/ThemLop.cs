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
    public partial class ThemLop : Form
    {
        private string maLop;
        public ThemLop(string maLop)
        {
            this.maLop = maLop;
            InitializeComponent();
        }

        private void ThemLop_Load(object sender, EventArgs e)
        {
            CSDL csdl = new CSDL();
            if (string.IsNullOrEmpty(maLop))
            {
                this.Text = "Thêm lớp mới";
            }
            else
            {
                this.Text = "Cập nhật thông tin lớp";
                DataRow dr = csdl.Select("select MaLop, TenLop from LOP where MaLop = '" + maLop + "'");
                txtTenLop.Text = dr["TenLop"].ToString();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql;
            string tenLop = txtTenLop.Text;

            if (string.IsNullOrEmpty(maLop))
            {
                sql = "insert into LOP(MaLop, TenLop) values('LP' + cast(next value for giaovienSeq as char(10)),";
                sql += "'" + tenLop + "'";
                sql += ")";
            }
            else
            {
                sql = "update LOP set TenLop = '" + tenLop + "' where MaLop = '" + maLop + "'";
            }
            bool rs = new CSDL().executeNonQuery(sql);
            if (rs)
            {
                if (string.IsNullOrEmpty(maLop))
                {
                    MessageBox.Show("Thêm mới thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thao tác không thành công");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
