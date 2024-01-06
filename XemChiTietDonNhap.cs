using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market_management
{
    public partial class XemChiTietDonNhap : Form
    {
        DataAccess dataAccess = new DataAccess();
        public XemChiTietDonNhap(string maDonNhap)
        {
            this.maDonNhap = maDonNhap;
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            string query = $"SELECT * FROM CT_HOA_DON_NHAP WHERE MaHDN = '{maDonNhap}'";
            GcChiTiet.DataSource = dataAccess.GetDataTable(query);
        }

        private string maDonNhap;




    }
}
