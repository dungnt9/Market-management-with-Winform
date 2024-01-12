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
        void LoadData()
        {

            string stringQuery = "SELECT \r\n" +
                "    HDN.MaHDN AS 'Mã đơn nhập',\r\n" +
                "    NCC.TenNCC AS 'Tên nhà cung cấp',\r\n" +
                "    NCC.SDT AS 'Số điện thoại',\r\n" +
                "    HDN.TongTien AS 'Tổng tiền',\r\n" +
                "    HDN.ThoiGian AS 'Thời gian',\r\n" +
                "    NV.TenNV AS 'Tên nhân viên'\r\n" +
                "FROM \r\n" +
                "    HOA_DON_NHAP HDN\r\n" +
                "    JOIN NHA_CUNG_CAP NCC ON HDN.MaNCC = NCC.MaNCC\r\n" +
                "    JOIN NHAN_VIEN NV ON HDN.MaNV = NV.MaNV;";
            GcQLNhapHang.DataSource = dataAccess.GetDataTable(stringQuery);
            DataTable dataTable = dataAccess.GetDataTable(stringQuery);
            bsiRecordsCount.Caption = "RECORDS : " + dataTable.Rows.Count;
        }

        private void UcQLNhapHang_Load(object sender, EventArgs e)
        {

        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var maDonNhap = gridView.GetRowCellValue(e.FocusedRowHandle, "Mã đơn nhập").ToString();
            LbcMaDN.Text = maDonNhap;
        }

        private void BbiLamMoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
            LbcMaDN.Text = "";
        }

        private void BsiXemChiTiet_ItemClick(object sender, ItemClickEventArgs e)
        {
            var maDonNhap = LbcMaDN.Text;

            // Kiểm tra xem có đơn nhập nào được chọn không
            if (string.IsNullOrEmpty(maDonNhap))
            {
                XtraMessageBox.Show("Vui lòng chọn đơn nhập cần xem chi tiết", "Thông báo");
                return;
            }
            FrmXemCT_HDNhap xem = new FrmXemCT_HDNhap(maDonNhap);
            xem.ShowDialog();
        }

        private void BbiXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            var maDN = LbcMaDN.Text;

            if (string.IsNullOrEmpty(maDN))
            {
                XtraMessageBox.Show("Vui lòng chọn hóa đơn nhập cần xóa", "Thông báo");
                return;
            }

            var confirmationResult = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn nhập này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                var sqlDelete1 = $"DELETE FROM CT_HOA_DON_NHAP WHERE MaHDN = '{maDN}'";
                var sqlDelete = $"DELETE FROM HOA_DON_NHAP WHERE MaHDN = '{maDN}'";
                DataAccess dataAccess = new DataAccess();
                try
                {
                    dataAccess.UpdateData(sqlDelete1);
                    dataAccess.UpdateData(sqlDelete);
                    XtraMessageBox.Show("Xóa hóa đơn nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    LbcMaDN.Text = "";
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"Lỗi xóa hóa đơn nhập: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmTaoHDNhap frmTaoDonNhap = new FrmTaoHDNhap();
            frmTaoDonNhap.ShowDialog();
        }
    }
}
