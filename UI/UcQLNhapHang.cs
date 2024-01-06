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
            GcQLNhapHang.DataSource = dataAccess.GetDataTable("SELECT \r\n" +
                "    HDN.MaHDN AS 'Mã đơn nhập',\r\n" +
                "    NCC.TenNCC AS 'Tên nhà cung cấp',\r\n" +
                "    NCC.SDT AS 'Số điện thoại NCC',\r\n" +
                "    HDN.TongTien AS 'Tổng tiền',\r\n" +
                "    HDN.ThoiGian AS 'Thời gian',\r\n" +
                "    NV.TenNV AS 'Tên nhân viên'\r\n" +
                "FROM \r\n" +
                "    HOA_DON_NHAP HDN\r\n" +
                "    JOIN NHA_CUNG_CAP NCC ON HDN.MaNCC = NCC.MaNCC\r\n" +
                "    JOIN NHAN_VIEN NV ON HDN.MaNV = NV.MaNV;");
        }






        private void UcQLNhapHang_Load(object sender, EventArgs e)
        {

        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
            var maDonNhap = gridView.GetRowCellValue(e.FocusedRowHandle, "Mã đơn nhập").ToString();
            var tongtien = gridView.GetRowCellValue(e.FocusedRowHandle, "Tổng tiền").ToString();
            var thoiGian = gridView.GetRowCellValue(e.FocusedRowHandle, "Thời gian").ToString();
            var tenNCC = gridView.GetRowCellValue(e.FocusedRowHandle, "Tên nhà cung cấp").ToString();
            var tenNV = gridView.GetRowCellValue(e.FocusedRowHandle, "Tên nhân viên").ToString();
            LbcMaDN.Text = maDonNhap;
            TeTongtien.Text = tongtien;
            DeThoiGian.Text = thoiGian;
            CmbTenNCC.Text = tenNCC;
            CmbTenNV.Text = tenNV;
        }

        private void BbiLamMoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
            LbcMaDN.Text = "";
            TeTongtien.Text = "";
            DeThoiGian.Text = "";
            CmbTenNCC.Text = "";
            CmbTenNV.Text = "";
        }

        private void BsiXemChiTiet_ItemClick(object sender, ItemClickEventArgs e)
        {
            XemChiTietDonNhap xem = new XemChiTietDonNhap();
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
                var sqlDelete = $"DELETE FROM HOA_DON_NHAP WHERE MaHDN = '{maDN}'";

                DataAccess dataAccess = new DataAccess();
                try
                {
                    dataAccess.UpdateData(sqlDelete);
                    XtraMessageBox.Show("Xóa hóa đơn nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Gọi lại phương thức để cập nhật GridView

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"Lỗi xóa hóa đơn nhập: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
