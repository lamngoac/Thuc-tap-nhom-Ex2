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
    public partial class SearchOutGV : Form
    {
        string sqlSearch;
        public SearchOutGV()
        {
            InitializeComponent();
        }

        public SearchOutGV(string sql)
        {
            sqlSearch = sql;
            InitializeComponent();
        }


        private void LoadDSGV()
        {
            dvgSearch.DataSource = null;
            dvgSearch.DataSource = new CSDL().SelectData(sqlSearch);
            dvgSearch.Columns["MaGV"].HeaderText = "Mã HS";
            dvgSearch.Columns["TenGV"].HeaderText = "Tên HS";
            dvgSearch.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dvgSearch.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dvgSearch.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dvgSearch.Columns["DayMon"].HeaderText = "Dạy Môn";
            dvgSearch.Columns["HocVan"].HeaderText = "Học Vấn";
            dvgSearch.Columns["MaLop"].HeaderText = "Mã Lớp";
        }

        private void SearchOutGV_Load(object sender, EventArgs e)
        {
            LoadDSGV();
        }
    }
}
