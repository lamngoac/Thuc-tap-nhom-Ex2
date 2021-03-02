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
    public partial class SearchOut : Form
    {
        string sqlSearch;
        public SearchOut()
        {
            InitializeComponent();
        }

        public SearchOut(string sql)
        {
            sqlSearch = sql;
            InitializeComponent();
        }


        private void LoadDSHS()
        {
            dvgSearch.DataSource = null;
            dvgSearch.DataSource = new CSDL().SelectData(sqlSearch);
            dvgSearch.Columns["MaHS"].HeaderText = "Mã HS";
            dvgSearch.Columns["TenHS"].HeaderText = "Tên HS";
            dvgSearch.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dvgSearch.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dvgSearch.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dvgSearch.Columns["MaLop"].HeaderText = "Mã Lớp";
        }

        private void SearchOut_Load(object sender, EventArgs e)
        {
            LoadDSHS();
        }
    }
}
