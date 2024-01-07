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

namespace market_management
{
    public partial class UcKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        DataAccess dataAccess = new DataAccess();

        public UcKhachHang()
        {
            InitializeComponent();
            LoadData();

            CbeGioiTinh.Properties.Items.Add("Nam");
            CbeGioiTinh.Properties.Items.Add("Nữ");
            CbeGioiTinh.Properties.Items.Add("Khác");
        }

        void LoadData()
        {
            GcDanhMucKH.DataSource = dataAccess.GetDataTable("select MaKH as 'Mã Khách Hàng', " +
                                                                    "TenKH as 'Tên Khách Hàng',   " +
                                                                    "NgaySinh as 'Ngày Sinh'," +
                                                                    "GioiTinh as 'Giới Tính', " +
                                                                    "SDT as 'Số Điện Thoại'," +
                                                                    "DiaChi as 'Địa Chỉ', " +
                                                                    "MaGiamGia as 'Mã Giảm Giá'" +
                                                                    "from KHACH_HANG");
        }

        private void BbiThemMoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (TeMaKH.Text != "" & TeTenKH.Text != "")
            {
                string s = string.Format("INSERT INTO KHACH_HANG (TenKH,GioiTinh,SDT,DiaChi,MaGiamGia, NgaySinh) VALUES" + "(N'{0}',N'{1}','{2}',N'{3}','{4}','{5}')", TeTenKH.Text, CbeGioiTinh.Text, TeSDT.Text, TeDiaChi.Text, CbeMaGiamGia.Text, DeNgaySinh.Text);
                MessageBox.Show("Thêm thành công");
                GcDanhMucKH.DataSource = dataAccess.GetDataTable(s);
                LoadData();
            }
            else
            {
                MessageBox.Show("Không được để trống các trường sau \n - Tên Khách Hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

}

        private void BbiXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xác nhận xoá?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (true)
            {
                GridView currentView = (GridView)GcDanhMucKH.FocusedView;

                string _MaKH = currentView.GetRowCellValue(currentView.FocusedRowHandle, currentView.Columns[0]).ToString();

                dataAccess.UpdateData(string.Format("delete from KHACH_HANG where MaKH = {0}", _MaKH));
                LoadData();
            }
        }

        private void BbiSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            string s = string.Format("UPDATE NHAN_VIEN SET " + "TenKH = N'{1}' where MaKH = {0} )", TeMaKH.Text, TeMaKH.Text);
            MessageBox.Show("Sửa thành công!");
            GcDanhMucKH.DataSource = dataAccess.GetDataTable(s);
            LoadData();
        }
    }
}
