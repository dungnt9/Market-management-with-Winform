using DevExpress.XtraEditors;
using market_management;
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
    public partial class FrmXemCT_HDNhap : DevExpress.XtraEditors.XtraForm
    {
        DataAccess dataAccess = new DataAccess();
        private string maDonNhap;
        public FrmXemCT_HDNhap(string maDonNhap)
        {
            this.maDonNhap = maDonNhap;
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            string query = $"SELECT CT.MaCTHDN AS 'Mã chi tiết hóa đơn nhập', CT.MaHDN AS 'Mã hóa đơn nhập', CT.MaSP AS 'Mã sản phẩm', SP.TenSP AS 'Tên sản phẩm', CT.SoLuong AS 'Số lượng', CT.ThanhTien AS 'Thành tiền' " +
                           $"FROM CT_HOA_DON_NHAP CT " +
                           $"INNER JOIN SAN_PHAM SP ON CT.MaSP = SP.MaSP " +
                           $"WHERE CT.MaHDN = '{maDonNhap}'";

            GcChiTiet.DataSource = dataAccess.GetDataTable(query);
        }
    }
}