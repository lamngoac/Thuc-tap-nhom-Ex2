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

        private void btnGVXoa_Click(object sender, EventArgs e)
        {
            var db = new CSDL();
            if (MessageBox.Show("Bạn muốn xóa học sinh " + dgvGiaoVien.CurrentRow.Cells["TenGV"].Value.ToString() + " ?", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var tenGV = dgvGiaoVien.CurrentRow.Cells["TenGV"].Value.ToString();
                var idGV = dgvGiaoVien.CurrentRow.Cells["MaGV"].Value.ToString();
                db.del_data(idGV);
                MessageBox.Show("Đã xóa giáo viên : " + tenGV);
            }
            clearData();
            LoadDSGV();

        }



        public void clearData()
        {
            txtTenGV.Text = "";
            txtHocVan.Text = "";
            txtGioiTinh.Text = "";
            txtDiaChi.Text = "";
            txtDayMon.Text = "";
            txtNgaySinh.Text = "";  
        }

        class GiaoVien
        {
            public string maGV { get; set; }
            public string tenGV { get; set; }

            public string GioiTinh { get; set; }
            public DateTime NgaySinh { get; set; }
            public string DiaChi { get; set; }
            public string DayMon { get; set; }

            public string HocVan { get; set; }

            public string MaLop { get; set; }
        }

        private void dgvGiaoVien_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvGiaoVien.CurrentRow.Index != -1)
                {
                    GiaoVien gv = new GiaoVien();
                    gv.maGV = dgvGiaoVien.CurrentRow.Cells[0].Value.ToString();
                    txtTenGV.Text = dgvGiaoVien.CurrentRow.Cells[1].Value.ToString();
                    txtNgaySinh.Text = dgvGiaoVien.CurrentRow.Cells[2].Value.ToString();
                    txtDiaChi.Text = dgvGiaoVien.CurrentRow.Cells[3].Value.ToString();
                    txtGioiTinh.Text = dgvGiaoVien.CurrentRow.Cells[4].Value.ToString();
                    txtHocVan.Text = dgvGiaoVien.CurrentRow.Cells[5].Value.ToString();
                    //gv.MaLop = dgvGiaoVien.CurrentRow.Cells[6].Value.ToString();
                    
                    //dtpGiaoVien.Value = DateTime.ParseExact(r["NgaySinh"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    //DateTime ngaysinh = Convert.ToDateTime(txtNgaySinh.Text);
                    //string ngaysinhStr = ngaysinh.ToString("yyyyMMdd");


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var db = new CSDL();
            string mgv = dgvGiaoVien.CurrentRow.Cells[0].Value.ToString();
            string TenGV = txtTenGV.Text;
            DateTime NgaySinh = txtNgaySinh.Value;
            string DiaChi = txtDiaChi.Text;
            string GioiTinh = txtGioiTinh.Text;
            string HocVan = txtHocVan.Text;
            string DayMon = txtDayMon.Text;
            string MaLop = dgvGiaoVien.CurrentRow.Cells[6].Value.ToString();
            
            string sql = "UpdateGV";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@MaGV",
                value = mgv
            });
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
                MessageBox.Show("Cập nhật thành công");
                this.Dispose();
            }
        }
    }
}
