using DevExpress.CodeParser;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Import.OpenXml;
using market_management.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Utils.Drawing.Helpers.NativeMethods;

namespace market_management
{
    public partial class FormChiTietDonBan : DevExpress.XtraEditors.XtraForm
    {
        DataAccess dataAccess = new DataAccess();
        public FormChiTietDonBan(string MaHDB, string tongTien, string thoigian)
        {
            InitializeComponent();
            HienThiThongTinHoaDon(MaHDB, tongTien, thoigian);
            HienThiSanPham(MaHDB);
        }

        private void HienThiThongTinHoaDon(string MaHDB, string tongTien, string thoigian)
        {
            HienThiThongTinKH(MaHDB);

            LbTongTien.Text = tongTien;
            LbThoiGian.Text = thoigian;
            LbTenNV.Text = "";

            HienThiSanPham(MaHDB);
        }

        private void HienThiThongTinKH(string maHDB)
        {
            string query = $"select TenKH, SDT, GioiTinh, DiaChi, NgaySinh from KHACH_HANG join HOA_DON_BAN on KHACH_HANG.MaKH = HOA_DON_BAN.MaKH where MaHDB = {maHDB}";
            DataTable dataTable = dataAccess.GetDataTable(query);

            LbTenKH.Text = dataTable.Rows[0]["TenKH"].ToString();
            LbSDT.Text = dataTable.Rows[0]["SDT"].ToString();
            LbDiaChi.Text = dataTable.Rows[0]["DiaChi"].ToString();
        }    

        private void HienThiSanPham(string MaHDB)
        {
            GcSP_HDB.DataSource = dataAccess.GetDataTable($"SELECT SP.MaSP AS 'Mã sản phẩm', SP.TenSP AS 'Tên sản phẩm', SP.GiaBanLe AS 'Giá Bán Lẻ', CTHDB.SoLuong AS 'Số Lượng' FROM SAN_PHAM AS SP JOIN CT_HOA_DON_BAN AS CTHDB ON SP.MaSP = CTHDB.MaSP JOIN HOA_DON_BAN HDB ON HDB.MaHDB = CTHDB.MaHDB WHERE HDB.MaHDB = '{MaHDB}'; ");
        }
    }
}