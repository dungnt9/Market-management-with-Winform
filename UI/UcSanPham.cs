using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask.Design;
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
    public partial class UcSanPham : DevExpress.XtraEditors.XtraUserControl
    {
        DataAccess dataAccess = new DataAccess();
        public UcSanPham()
        {
            InitializeComponent();
            LoadData();
        }
        
        void LoadData()
        {
            GcSP.DataSource = dataAccess.GetDataTable("SELECT \r\n    SP.MaSP AS 'Mã sản phẩm',\r\n    SP.TenSP AS 'Tên sản phẩm',\r\n    LSP.TenLoaiSP AS 'Phân loại',\r\n    SP.SoLuong AS 'Số lượng',\r\n    SP.GiaNhap AS 'Giá nhập',\r\n    SP.GiaBanLe AS 'Giá bán lẻ'\r\nFROM \r\n    SAN_PHAM SP\r\nJOIN \r\n    LOAI_SAN_PHAM LSP ON SP.MaLoaiSP = LSP.MaLoaiSP;");
        }


        private void gridView_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var maSP = gridView.GetRowCellValue(e.FocusedRowHandle, "Mã sản phẩm").ToString();
            var tenSP = gridView.GetRowCellValue(e.FocusedRowHandle, "Tên sản phẩm").ToString();
            var phanLoai= gridView.GetRowCellValue(e.FocusedRowHandle, "Phân loại").ToString();
            var soLuong = gridView.GetRowCellValue(e.FocusedRowHandle, "Số lượng").ToString();
            var giaNhap = gridView.GetRowCellValue(e.FocusedRowHandle, "Giá nhập").ToString();
            var giaBan = gridView.GetRowCellValue(e.FocusedRowHandle, "Giá bán lẻ").ToString();
            CmbMaSP.Text = maSP;
            CmbTenSP.Text = tenSP;
            CmbPhanLoai.Text = phanLoai;
            TeSoLuong.Text = soLuong;
            TeGiaNhap.Text = giaNhap;
            TeGiaBan.Text = giaBan;

        }

        private void BbiLamMoi_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            LoadData();
            CmbMaSP.Text = "";
            CmbTenSP.Text = "";
            CmbPhanLoai.Text = "";
            TeSoLuong.Text = "";
            TeGiaNhap.Text = "";
            TeGiaBan.Text = "";
        }

        private void BbiXoa_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            var maSP = CmbMaSP.Text;

            if (string.IsNullOrEmpty(maSP))
            {
                XtraMessageBox.Show("Vui lòng chọn sản phẩm cần xóa", "Thông báo");
                return;
            }

            var confirmationResult = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                var sqlDelete = $"DELETE FROM SAN_PHAM WHERE MaSP = '{maSP}'";

                DataAccess dataAccess = new DataAccess();
                try
                {
                    dataAccess.UpdateData(sqlDelete);
                    XtraMessageBox.Show("Xóa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Gọi lại phương thức để cập nhật GridView

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"Lỗi xóa sản phẩm: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BbiSua_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            var maSP = CmbMaSP.Text;
            var tenSP = CmbTenSP.Text;
            var phanLoai = CmbPhanLoai.Text;
            var soLuong = TeSoLuong.Text;
            var giaNhap = TeGiaNhap.Text;
            var giaBan = TeGiaBan.Text;

            if (string.IsNullOrEmpty(maSP) || string.IsNullOrEmpty(tenSP))
            {
                XtraMessageBox.Show("Vui lòng chọn loại sản phẩm cần cập nhật và nhập thông tin mới", "Thông báo");
                return;
            }

            var sqlUpdate = $"UPDATE SAN_PHAM SET TenSP = N'{tenSP}', PhanLoai = N'{phanLoai}', SoLuong = '{soLuong}', GiaNhap = '{giaNhap}', GiaBan = '{giaBan}' WHERE MaSP = '{maSP}'";

            DataAccess dataAccess = new DataAccess();
            try
            {
                dataAccess.UpdateData(sqlUpdate);
                XtraMessageBox.Show("Cập nhật sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Gọi lại phương thức để cập nhật GridView
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Lỗi cập nhật sản phẩm: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
