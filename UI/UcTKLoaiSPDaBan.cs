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

            // Bảng loại sản phẩm có số lượng bán từ cao đến thấp
            DataTable dataTable2 = LayLoaiSPDaBan();
            GcLoaiSanPhamDaBan.DataSource = dataTable2;
        }
        private void LayLoaiSPBanNhieuNhat()
        {
            DataRow maxSoldProductTypeRow = LayDongLoaiSPBanNhieuNhat();

            if (maxSoldProductTypeRow != null)
            {
                LbcTenLoaiSP.Text = maxSoldProductTypeRow["TenLoaiSP"].ToString();
                LbcSoLoaiSP.Text = maxSoldProductTypeRow["SoLuongDaBan"].ToString() + " sản phẩm";
            }
        }
        private DataRow LayDongLoaiSPBanNhieuNhat()
        {
            DataTable dataTable = LayLoaiSPDaBan();
            DataRow maxSoldProductTypeRow = dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
            return maxSoldProductTypeRow;
        }
        private DataTable LayLoaiSPDaBan()
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT LSP.MaLoaiSP, LSP.TenLoaiSP, SUM(CT.SoLuong) AS SoLuongDaBan " +
                           "FROM LOAI_SAN_PHAM LSP " +
                           "JOIN SAN_PHAM SP ON LSP.MaLoaiSP = SP.MaLoaiSP " +
                           "JOIN CT_HOA_DON_BAN CT ON SP.MaSP = CT.MaSP " +
                           "GROUP BY LSP.MaLoaiSP, LSP.TenLoaiSP " +
                           "ORDER BY SoLuongDaBan DESC";

            dataTable = dataAccess.GetDataTable(query);

            return dataTable;
        }
    }
}
