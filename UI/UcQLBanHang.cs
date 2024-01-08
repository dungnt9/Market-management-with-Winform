﻿using DevExpress.XtraBars;
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
    public partial class UcQLBanHang : DevExpress.XtraEditors.XtraUserControl
    {
        DataAccess dataAccess = new DataAccess();
        string maHDB = null;
        public UcQLBanHang()
        {
            InitializeComponent();
            LoadData();

        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormDonBan frmDonBan = new FormDonBan();
            frmDonBan.ShowDialog();
        }

        private void LoadData()
        {
            GcQLBanHang.DataSource = dataAccess.GetDataTable("SELECT \r\n" +
                "    HDB.MaHDB AS 'Mã Hóa Đơn Bán',\r\n" +
                "    KH.TenKH AS 'Tên Khách Hàng',\r\n" +
                "    KH.SDT AS 'Số Điện Thoại Khách Hàng',\r\n" +
                "    HDB.TongTien AS 'Tổng Tiền',\r\n" +
                "    HDB.ThoiGian AS 'Thời Gian',\r\n" +
                "    NV.TenNV AS 'Tên nhân viên'\r\n" +
                "FROM \r\n" +
                "    HOA_DON_BAN HDB\r\n" +
                "    JOIN KHACH_HANG KH ON HDB.MaKH = KH.MaKH\r\n" +
                "    JOIN NHAN_VIEN NV ON HDB.MaNV = NV.MaNV;");
        }

        private void BbiXemChiTietHDB_ItemClick(object sender, ItemClickEventArgs e)
        {

            FormChiTietDonBan frmChiTietDonBan = new FormChiTietDonBan(maHDB);
            frmChiTietDonBan.ShowDialog();
        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            maHDB = gridView.GetRowCellValue(e.FocusedRowHandle, "Mã Hóa Đơn Bán").ToString();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(maHDB))
            {
                XtraMessageBox.Show("Vui lòng chọn hóa đơn bán cần xóa", "Thông báo");
                return;
            }

            var confirmationResult = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn bán này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                var sqlDelete = $"DELETE FROM HOA_DON_BAN WHERE MaHDB = '{maHDB}'";

                try
                {
                    dataAccess.UpdateData(sqlDelete);
                    XtraMessageBox.Show("Xóa hóa đơn bán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Gọi lại phương thức để cập nhật GridView

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"Lỗi xóa hóa đơn bán: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}