using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class UcChucVu : DevExpress.XtraEditors.XtraUserControl
    {
        DataAccess dataAccess = new DataAccess();
        string maCV = "";
        public UcChucVu()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            GcChucVu.DataSource = dataAccess.GetDataTable("SELECT CV.MaCV AS 'Mã Chức Vụ', CV.TenCV AS 'Tên Chức Vụ', CV.CapQuanLy AS 'Cấp Quản Lý', CV.MoTa AS 'Mô Tả'  FROM CHUC_VU CV");
        }

        private void BbiSuaCV_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(maCV))
            {
                XtraMessageBox.Show("Vui Lòng Chọn Chức Vụ Cần Sửa", "Thông Báo");
                return;
            }

            var xacnhan = XtraMessageBox.Show("Bạn Có Chắc Chắn Muốn Sửa Chức Vụ Này?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            string tenCV = TeTenCV.Text;
            string capCV = CbeCapQuanLy.Text;
            bool capQL;
            string mota = TeMoTa.Text;

            if(capCV == "Có")
            {
                capQL = true;
            }    
            else
            {
                capQL = false;
            }

            if (xacnhan == DialogResult.Yes)
            {
                var sqlDelete = $"UPDATE CHUC_VU SET TenCV = N'{tenCV}', CapQuanLy = '{capQL}', MoTa = '{mota}' WHERE MaCV = '{maCV}'";

                try
                {
                    dataAccess.UpdateData(sqlDelete);
                    XtraMessageBox.Show("Cập Nhật Chức Vụ Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Gọi lại phương thức để cập nhật GridView
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"Lỗi Cập Nhật Chức Vụ: {ex.Message}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GvChucVu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            maCV = GvChucVu.GetRowCellValue(e.FocusedRowHandle, "Mã Chức Vụ").ToString();
            string tenCV = GvChucVu.GetRowCellValue(e.FocusedRowHandle, "Tên Chức Vụ").ToString();
            bool capQL = Convert.ToBoolean(GvChucVu.GetRowCellValue(e.FocusedRowHandle, "Cấp Quản Lý"));
            string motaCV = GvChucVu.GetRowCellValue(e.FocusedRowHandle, "Mô Tả").ToString();

            TeTenCV.Text = tenCV;
            TeMoTa.Text = motaCV;
            if (capQL == true)
            {
                CbeCapQuanLy.Text = "Có";
            }    
            else
            {
                CbeCapQuanLy.Text = "Không";
            }    
        }

        private void BbiXoaCV_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(maCV))
            {
                XtraMessageBox.Show("Vui Lòng Chọn Chức Vụ Cần Xóa", "Thông Báo");
                return;
            }

            var xacnhan = XtraMessageBox.Show("Bạn Có Chắc Chắn Muốn Xóa Chức Vụ Này?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (xacnhan == DialogResult.Yes)
            {
                string sqlDeleteCV = $"DELETE FROM CHUC_VU WHERE MaCV = {maCV}";
                string sqlUpdateCV_NV = $"UPDATE NHAN_VIEN SET MaCV = null WHERE MaCV = '{maCV}'";

                try
                {
                    dataAccess.UpdateData(sqlUpdateCV_NV);
                    dataAccess.UpdateData(sqlDeleteCV);
                    XtraMessageBox.Show("Xóa Chức Vụ Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Gọi lại phương thức để cập nhật GridView
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"Lỗi Xóa Chức Vụ: {ex.Message}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BbiThemCV_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmThemChucVu frmThemChucVu = new FrmThemChucVu();
            frmThemChucVu.ShowDialog();
            frmThemChucVu.BringToFront();

            LoadData();
        }

        private void BbiLamMoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
        }
    }
}
