using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market_management.UI
{
    public partial class UcQLNhapHang : DevExpress.XtraEditors.XtraUserControl
    {
        DataAccess dataAccess = new DataAccess();

        public UcQLNhapHang()
        {
            InitializeComponent();
            LoadData();
        }
        private void BbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmDonNhap frmDonNhap = new FrmDonNhap();
            frmDonNhap.ShowDialog();
        }
        void LoadData()
        {
            GcQLNhapHang.DataSource = dataAccess.GetDataTable("SELECT \r\n    HDN.MaHDN AS 'Mã đơn nhập',\r\n    HDN.TongTien AS 'Tổng tiền',\r\n    HDN.ThoiGian AS 'Thời gian',\r\n    HDN.MaNCC AS 'Mã nhà cung cấp',\r\n    NCC.TenNCC AS 'Tên nhà cung cấp',\r\n    NCC.SDT AS 'Số điện thoại NCC',\r\n    HDN.MaNV AS 'Mã nhân viên',\r\n    NV.TenNV AS 'Tên nhân viên'\r\nFROM \r\n    HOA_DON_NHAP HDN\r\n    JOIN NHA_CUNG_CAP NCC ON HDN.MaNCC = NCC.MaNCC\r\n    JOIN NHAN_VIEN NV ON HDN.MaNV = NV.MaNV;");
        }



    }
}
