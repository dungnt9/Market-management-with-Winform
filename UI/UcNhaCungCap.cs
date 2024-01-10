using DevExpress.DataAccess.Sql;
using DevExpress.Xpo;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Import.Html;
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
    public partial class UcNhaCungCap : DevExpress.XtraEditors.XtraUserControl
    {
        DataAccess dataAccess = new DataAccess();
        string maNCC = "";
        public UcNhaCungCap()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            GcNCC.DataSource = dataAccess.GetDataTable("SELECT NCC.MaNCC AS 'Mã Nhà Cung Cấp', NCC.TenNCC AS 'Tên Nhà Cung Cấp', NCC.DiaChi AS 'Địa Chỉ', NCC.SDT AS 'Số Điện Thoại', LSP.TenLoaiSP AS 'Loại Sản Phẩm'  FROM NHA_CUNG_CAP NCC JOIN LOAI_SAN_PHAM LSP ON NCC.MaLoaiSP = LSP.MaLoaiSP");
        }
        
        private void BbiThemNCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormNhaCungCap frmNhaCungCap = new FormNhaCungCap();
            frmNhaCungCap.ShowDialog();
            frmNhaCungCap.BringToFront();
        }

        private void BbiSuaNCC_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (string.IsNullOrEmpty(maNCC))
            {
                XtraMessageBox.Show("Vui lòng chọn nhà cung cấp cần sửa", "Thông báo");
                return;
            }

            var confirmationResult = XtraMessageBox.Show("Bạn có chắc chắn muốn sửa nhà cung cấp này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            string tenNCC = TeTenNCC.Text;
            string sdtNCC = TeSĐTNCC.Text;
            string diachiNCC = TeDiaChiNCC.Text;

            if (confirmationResult == DialogResult.Yes)
            {
                var sqlDelete = $"UPDATE NHA_CUNG_CAP SET TenNCC = N'{tenNCC}', DiaChi = N'{diachiNCC}', SDT = '{sdtNCC}' WHERE MaNCC = '{maNCC}'";

                try
                {
                    dataAccess.UpdateData(sqlDelete);
                    XtraMessageBox.Show("Cập nhật nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Gọi lại phương thức để cập nhật GridView
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"Lỗi cập nhật nhà cung cấp: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BbiXoaNCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(maNCC))
            {
                XtraMessageBox.Show("Vui lòng chọn nhà cung cấp cần xóa", "Thông báo");
                return;
            }

            var confirmationResult = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                var sqlDelete = $"DELETE FROM NHA_CUNG_CAP WHERE MaNCC = '{maNCC}'";

                try
                {
                    dataAccess.UpdateData(sqlDelete);
                    XtraMessageBox.Show("Xóa nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"Lỗi xóa nhà cung cấp: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            maNCC = gridView.GetRowCellValue(e.FocusedRowHandle, "Mã Nhà Cung Cấp").ToString();
            var tenNCC = gridView.GetRowCellValue(e.FocusedRowHandle, "Tên Nhà Cung Cấp").ToString();
            var diachiNCC = gridView.GetRowCellValue(e.FocusedRowHandle, "Địa Chỉ").ToString();
            var sdtNCC = gridView.GetRowCellValue(e.FocusedRowHandle, "Số Điện Thoại").ToString();
            var loaiSP = gridView.GetRowCellValue(e.FocusedRowHandle, "Loại Sản Phẩm").ToString();

            TeTenNCC.Text = tenNCC;
            TeDiaChiNCC.Text = diachiNCC;
            TeSĐTNCC.Text = sdtNCC;
            CbeLoaiSanPham.Text = loaiSP;
        }
    }
}
