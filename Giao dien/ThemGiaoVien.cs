using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giao_dien
{
    public partial class ThemGiaoVien : Form
    {
        public ThemGiaoVien(string mgv)
        {
            this.mgv = mgv;
            InitializeComponent();
        }
        private string mgv;

        private void ThemGiaoVien_Load(object sender, EventArgs e)
        {
            CSDL csdl = new CSDL();
            string getAllMaLop = "SELECT MaLop FROM LOP";
            DataTable maLopTable = csdl.SelectData(getAllMaLop);
            cbMaLop.DataSource = maLopTable.Copy();
            cbMaLop.DisplayMember = "MaLop";
            cbMaLop.ValueMember = "MaLop";
            if (string.IsNullOrEmpty(mgv))
            {
                this.Text = "Thêm mới nhân viên";
            }
            else
            {
                this.Text = "Cập nhật thông tin giáo viên";

                var r = new CSDL().Select(string.Format("selectGVById '" + mgv + "'"));

                txtTenGV.Text = r["TenGV"].ToString();
                dtpBirthday.Value = DateTime.ParseExact(r["NgaySinh"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                txtDC.Text = r["DiaChi"].ToString();
                if (r["GioiTinh"].ToString() == "Nam")
                {
                    rbtNam.Checked = true;
                }
                else
                {
                    rbtNu.Checked = true;
                }
                txtHocVan.Text = r["HocVan"].ToString();
                txtDayMon.Text = r["DayMon"].ToString();
                string maLop = r["MaLop"].ToString();
                cbMaLop.SelectedValue = maLop;
                //cbMaLop.SelectedIndex();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql;
            string TenGV = txtTenGV.Text;
            DateTime NgaySinh = dtpBirthday.Value;
            string DiaChi = txtDC.Text;
            string GioiTinh = rbtNam.Checked ? "Nam" : "Nu";
            string HocVan = txtHocVan.Text;
            string DayMon = txtDayMon.Text;
            DataRowView drvMaLop = (DataRowView)cbMaLop.SelectedItem;
            string MaLop = drvMaLop.Row.Field<string>("MaLop");

            List<CustomParameter> lstPara = new List<CustomParameter>();

            if (string.IsNullOrEmpty(mgv))
            {
                sql = "ThemMoiGV";
            }
            else
            {
                sql = "UpdateGV";
                lstPara.Add(new CustomParameter()
                {
                    key = "@MaGV",
                    value = mgv
                });
            }

            lstPara.Add(new CustomParameter()
            {
                key = "@TenGV",
                value = TenGV
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

            lstPara.Add(new CustomParameter()
            {
                key = "@HocVan",
                value = HocVan
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@DayMon",
                value = DayMon
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@MaLop",
                value = MaLop
            });

            var rs = new CSDL().ExeCute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(mgv))
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
