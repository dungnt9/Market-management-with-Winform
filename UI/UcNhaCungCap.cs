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
            TeTenNCC.Text = "";
            TeDiaChiNCC.Text = "";
            TeSĐTNCC.Text = "";
            CbeLoaiSanPham.Text = "";
        }

        private void LoadData()
        {
            GcNCC.DataSource = dataAccess.GetDataTable("SELECT NCC.MaNCC AS 'Mã Nhà Cung Cấp', NCC.TenNCC AS 'Tên Nhà Cung Cấp', NCC.DiaChi AS 'Địa Chỉ', NCC.SDT AS 'Số Điện Thoại', LSP.TenLoaiSP AS 'Loại Sản Phẩm'  FROM NHA_CUNG_CAP NCC JOIN LOAI_SAN_PHAM LSP ON NCC.MaLoaiSP = LSP.MaLoaiSP");
        }
        
        private void BbiThemNCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmThemNCC frmNhaCungCap = new FrmThemNCC();
            frmNhaCungCap.ShowDialog();
            frmNhaCungCap.BringToFront();

            LoadData();
        }

        private void BbiSuaNCC_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (string.IsNullOrEmpty(maNCC))
            {
                XtraMessageBox.Show("Vui Lòng Chọn Nhà Cung Cấp Cần Sửa", "Thông Báo");
                return;
            }

            var xacnhan = XtraMessageBox.Show("Bạn Có Chắc Chắn Muốn Sửa Nhà Cung Cấp Này?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            string tenNCC = TeTenNCC.Text;
            string sdtNCC = TeSĐTNCC.Text;
            string diachiNCC = TeDiaChiNCC.Text;

            if (xacnhan == DialogResult.Yes)
            {
                var sqlDelete = $"UPDATE NHA_CUNG_CAP SET TenNCC = N'{tenNCC}', DiaChi = N'{diachiNCC}', SDT = '{sdtNCC}' WHERE MaNCC = '{maNCC}'";

                try
                {
                    dataAccess.UpdateData(sqlDelete);
                    XtraMessageBox.Show("Cập Nhật Nhà Cung Cấp Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Gọi lại phương thức để cập nhật GridView
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"Lỗi Cập Nhật Nhà Cung Cấp: {ex.Message}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            var xacnhan = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa Nhà Cung Cấp Này?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (xacnhan == DialogResult.Yes)
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
            LoadData();
            TeTenNCC.Text = "";
            TeDiaChiNCC.Text = "";
            TeSĐTNCC.Text = "";
            CbeLoaiSanPham.Text = "";
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
