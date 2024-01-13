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
        string maHDN;
        string tongTien;
        string thoigian;
        public UcQLNhapHang()
        {
            InitializeComponent();
            LoadData();
            LbcMaHDN.Text = "";
        }
        void LoadData()
        {
            string stringQuery = "SELECT \r\n" +
                "    HDN.MaHDN AS 'Mã Đơn Nhập',\r\n" +
                "    NCC.TenNCC AS 'Tên Nhà Cung Cấp',\r\n" +
                "    NCC.SDT AS 'Số Điện Thoại',\r\n" +
                "    HDN.TongTien AS 'Tổng Tiền',\r\n" +
                "    HDN.ThoiGian AS 'Thời Gian',\r\n" +
                "    NV.TenNV AS 'Tên Nhân Viên'\r\n" +
                "FROM \r\n" +
                "    HOA_DON_NHAP HDN\r\n" +
                "    JOIN NHA_CUNG_CAP NCC ON HDN.MaNCC = NCC.MaNCC\r\n" +
                "    JOIN NHAN_VIEN NV ON HDN.MaNV = NV.MaNV;";
            GcQLNhapHang.DataSource = dataAccess.GetDataTable(stringQuery);
            DataTable dataTable = dataAccess.GetDataTable(stringQuery);
        }

        private void UcQLNhapHang_Load(object sender, EventArgs e)
        {

        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            maHDN = gridView.GetRowCellValue(e.FocusedRowHandle, "Mã Đơn Nhập").ToString();
            LbcMaHDN.Text = maHDN;
            tongTien = gridView.GetRowCellValue(e.FocusedRowHandle, "Tổng Tiền").ToString();
            thoigian = gridView.GetRowCellValue(e.FocusedRowHandle, "Thời Gian").ToString();
        }

        private void BbiLamMoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
            LbcMaHDN.Text = "";
        }

        private void BsiXemChiTiet_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (maHDN == null)
            {
                return;
            }
            FrmXemCT_HDNhap xem = new FrmXemCT_HDNhap(maHDN, tongTien, thoigian);
            xem.ShowDialog();
        }

        private void BbiXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(maHDN))
            {
                XtraMessageBox.Show("Vui lòng chọn hóa đơn nhập cần xóa", "Thông báo");
                return;
            }

            var confirmationResult = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn nhập này?", 
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                var sqlDelete1 = $"DELETE FROM CT_HOA_DON_NHAP WHERE MaHDN = '{maHDN}'";
                var sqlDelete = $"DELETE FROM HOA_DON_NHAP WHERE MaHDN = '{maHDN}'";
                DataAccess dataAccess = new DataAccess();
                try
                {
                    dataAccess.UpdateData(sqlDelete1);
                    dataAccess.UpdateData(sqlDelete);
                    XtraMessageBox.Show("Xóa hóa đơn nhập thành công", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    LbcMaHDN.Text = "";
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"Lỗi xóa hóa đơn nhập: {ex.Message}", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmTaoHDNhap frmTaoHDN = new FrmTaoHDNhap();
            frmTaoHDN.ShowDialog();
        }
    }
}
