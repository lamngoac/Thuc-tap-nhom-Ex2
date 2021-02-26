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
    public partial class ThemHocSinh : Form
    {
        public ThemHocSinh(string mhs)
        {
            this.mhs = mhs;
            InitializeComponent();
        }
        private string mhs;

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql;
            string TenHS = txtTenHS.Text;
            DateTime NgaySinh = dtpBirthday.Value;
            string DiaChi = txtDC.Text;
            string GioiTinh = rbtNam.Checked ? "Nam" : "Nu";

            List<CustomParameter> lstPara = new List<CustomParameter>();

            if (string.IsNullOrEmpty(mhs))
            {
                sql = "ThemMoiHS";
            }
            else
            {
                sql = "UpdateHS";
                lstPara.Add(new CustomParameter()
                {
                    key = "@MaHS",
                    value = mhs
                });
            }

            lstPara.Add(new CustomParameter()
            {
                key = "@TenHS",
                value = TenHS
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@NS",
                value = NgaySinh.ToString("yyyy-MM-dd")
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@DC",
                value = DiaChi
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@GT",
                value = GioiTinh
            });


            var rs = new CSDL().ExeCute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(mhs))
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
