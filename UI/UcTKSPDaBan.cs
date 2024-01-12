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
    public partial class UcTKSPDaBan : DevExpress.XtraEditors.XtraUserControl
    {
        public UcTKSPDaBan()
        {
            InitializeComponent();
            LoadData();
            LaySPBanNhieuNhat();
        }
        DataAccess dataAccess = new DataAccess();

        private void LoadData()
        {
            DataTable dataTable = LaySPDaBan();
            GcSanPhamDaBan.DataSource = dataTable;
        }


        private void LaySPBanNhieuNhat()
        {
            DataRow dongSPBanNhieuNhat = LayDongSPBanNhieuNhat();

            if (dongSPBanNhieuNhat != null)
            {
                LbcTenSP.Text = dongSPBanNhieuNhat["TenSP"].ToString();
                LbcSoSP.Text = dongSPBanNhieuNhat["SoLuongDaBan"].ToString() + " sản phẩm";
            }
        }
        private DataRow LayDongSPBanNhieuNhat()
        {
            DataTable dataTable = LaySPDaBan();
            DataRow dongSPBanNhieuNhat = dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
            return dongSPBanNhieuNhat;
        }
        private DataTable LaySPDaBan()
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT SP.MaSP, SP.TenSP, SP.SoLuong, SUM(CT.SoLuong) AS SoLuongDaBan " +
                           "FROM SAN_PHAM SP " +
                           "JOIN CT_HOA_DON_BAN CT ON SP.MaSP = CT.MaSP " +
                           "GROUP BY SP.MaSP, SP.TenSP, SP.SoLuong " +
                           "ORDER BY SoLuongDaBan DESC";

            dataTable = dataAccess.GetDataTable(query);

            return dataTable;
        }
    }
}
