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
    public partial class ThemHocSinh : Form
    {
        public ThemHocSinh(string mhs)
        {
            this.mhs = mhs;
            InitializeComponent();
        }
        private string mhs;



        private void ThemHocSinh_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Mã SV nhận được: " + msv);
            CSDL csdl = new CSDL();
            string getAllMaLop = "SELECT MaLop FROM LOP";
            DataTable maLopTable = csdl.SelectData(getAllMaLop);
            cbMaLop.DataSource = maLopTable.Copy();
            cbMaLop.DisplayMember = "MaLop";
            cbMaLop.ValueMember = "MaLop";
            if (!string.IsNullOrEmpty(mhs))
            {
                this.Text = "Cập nhật thông tin sinh viên";

                var r = new CSDL().Select(string.Format("selectHSById '" + mhs + "'"));
                //MessageBox.Show(r[0].ToString());

                txtTenHS.Text = r["TenHS"].ToString();
                //mtbNS.Text = r["NgaySinh"].ToString();
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
                //cbTenNGS.SelectedText = r["TenNGS"].ToString();
                //cbTenPB.SelectedText = r["TenPB"].ToString();
            }
            else
            {
                this.Text = "Thêm mới nhân viên";
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql;
            string TenHS = txtTenHS.Text;
            DateTime NgaySinh = dtpBirthday.Value;
            string DiaChi = txtDC.Text;
            string GioiTinh = rbtNam.Checked ? "Nam" : "Nu";
            DataRowView drvMaLop = (DataRowView)cbMaLop.SelectedItem;
            string MaLop = drvMaLop.Row.Field<string>("MaLop");

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
            lstPara.Add(new CustomParameter()
            {
                key = "@MaLop",
                value = MaLop
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
