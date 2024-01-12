using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market_management.UI
{
    public partial class UcTKLoaiSPDaBan : DevExpress.XtraEditors.XtraUserControl
    {
        public UcTKLoaiSPDaBan()
        {
            InitializeComponent();
            LoadData();
            LayLoaiSPBanNhieuNhat();
        }
        DataAccess dataAccess = new DataAccess();

        private void LoadData()
        {
            DataTable dataTable1 = LayLoaiSPDaBan();
            GcLoaiSanPhamDaBan.DataSource = dataTable1;
        }
        private void LayLoaiSPBanNhieuNhat()
        {
            DataRow dongLoaiSPBanNhieuNhat = LayDongLoaiSPBanNhieuNhat();

            if (dongLoaiSPBanNhieuNhat != null)
            {
                LbcTenLoaiSP.Text = dongLoaiSPBanNhieuNhat["Loại Sản Phẩm"].ToString();
                LbcSoLoaiSP.Text = dongLoaiSPBanNhieuNhat["Số Lượng Đã Bán"].ToString() + " sản phẩm";
            }
        }
        private DataRow LayDongLoaiSPBanNhieuNhat()
        {
            DataTable dataTable = LayLoaiSPDaBan();
            DataRow dongLoaiSPBanNhieuNhat = dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
            return dongLoaiSPBanNhieuNhat;
        }
        private DataTable LayLoaiSPDaBan()
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT LSP.MaLoaiSP AS 'Mã Loại Sản Phẩm', LSP.TenLoaiSP AS 'Loại Sản Phẩm', SUM(CT.SoLuong) AS 'Số Lượng Đã Bán' " +
                           "FROM LOAI_SAN_PHAM LSP " +
                           "JOIN SAN_PHAM SP ON LSP.MaLoaiSP = SP.MaLoaiSP " +
                           "JOIN CT_HOA_DON_BAN CT ON SP.MaSP = CT.MaSP " +
                           "GROUP BY LSP.MaLoaiSP, LSP.TenLoaiSP " +
                           "ORDER BY [Số Lượng Đã Bán] DESC";

            dataTable = dataAccess.GetDataTable(query);

            return dataTable;
        }
    }
}
