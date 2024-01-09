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
    public partial class UcQLMaGiamGia : DevExpress.XtraEditors.XtraUserControl
    {
        DataAccess dataAccess = new DataAccess();
        public UcQLMaGiamGia()
        {
            InitializeComponent();
            LoadData();

            CbePhanTram.Properties.Items.Add("5");
            CbePhanTram.Properties.Items.Add("10");
            CbePhanTram.Properties.Items.Add("15");
            CbePhanTram.Properties.Items.Add("20");
            CbePhanTram.Properties.Items.Add("25");
            CbePhanTram.Properties.Items.Add("30");
            CbePhanTram.Properties.Items.Add("40");
            CbePhanTram.Properties.Items.Add("50");

        }
        //Lất data từ CSDL
        void LoadData()
        {
            GcMaGiamGia.DataSource = dataAccess.GetDataTable("select MaGiamGia as 'Mã Giảm Giá', " +
                                                                    "TenChuongTrinh as 'Tên Chuong Trinh'," +
                                                                    "PhanTram as 'Phần Trăm'," +
                                                                    "NgayTao as 'Ngày Tạo', " +
                                                                    "TrangThai as 'Trạng Thái'," +
                                                                    "MoTa as 'Mô Tả'" +
                                                                    "from MA_GIAM_GIA");
        }

        private void BbiSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(TeMaGiamGia.Text))
            {
                XtraMessageBox.Show("Vui lòng chọn mã giảm giá cần sửa", "Thông báo");
                return;
            }

            var confirmationResult = XtraMessageBox.Show("Bạn có chắc chắn muốn sửa mã giảm giá này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                try
                {
                    string s = string.Format("UPDATE MA_GIAM_GIA SET " + "TenNV = N'{1}' where MaNV = N'{0}' )", TeMaGiamGia.Text, TeTenChuongTrinh.Text);
                    dataAccess.UpdateData(s);
                    XtraMessageBox.Show("Cập nhật nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Gọi lại phương thức để cập nhật GridView

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"Lỗi cập nhật nhà cung cấp: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BbiLamMoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
            TeMaGiamGia.Text = "";
            TeTenChuongTrinh.Text = "";
            CbePhanTram.Text = "";
            DeNgayTao.Text = "";
            TeMoTa.Text = "";
            RbConHieuLuc.Checked = false;
            RbHetHan.Checked = false;
        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var MaGiamGia = gridView.GetRowCellValue(e.FocusedRowHandle,).ToString();
            var TenChuongTrinh = gridView.GetRowCellValue(e.FocusedRowHandle, "Tên Nhân Viên").ToString();
            var NgayTao = gridView.GetRowCellValue(e.FocusedRowHandle, "Ngày Sinh").ToString();
            var PhanTram = gridView.GetRowCellValue(e.FocusedRowHandle, "Giới Tính").ToString();
            var MoTa = gridView.GetRowCellValue(e.FocusedRowHandle, "Email").ToString();
            TeMaGiamGia.Text = MaGiamGia;
            TeTenChuongTrinh.Text = TenChuongTrinh;
            DeNgayTao.Text = NgayTao;
            CbePhanTram.Text = PhanTram;
            TeMoTa.Text = MoTa;
            
        }

        private void BbiTaoMoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmThemMGG f = new FrmThemMGG();
            f.ShowDialog();
        }
    }
}
