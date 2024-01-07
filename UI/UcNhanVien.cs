using DevExpress.DataAccess.Native.EntityFramework;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
    public partial class UcNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        DataAccess dataAccess = new DataAccess();
        public UcNhanVien()
        {
            InitializeComponent();
            LoadData();

            CbeGioiTinh.Properties.Items.Add("Nam");
            CbeGioiTinh.Properties.Items.Add("Nữ");
            CbeGioiTinh.Properties.Items.Add("Khác");

            //CbeChucVu.DataBindings.Add(new Binding("Value", dataAccess,"NHAN_VIEN.ChucVu"));
            CbeChucVu.Properties.Items.Add("Quản lý");
            CbeChucVu.Properties.Items.Add("Nhân Viên");
        }
        //Lất data từ CSDL
        void LoadData()
        {
            GcDanhMucNV.DataSource = dataAccess.GetDataTable("select MaNV as 'Mã Nhân VIên', " +
                                                                    "TenNV as 'Tên Nhân Viên',   " +
                                                                    "NgaySinh as 'Ngày Sinh'," +
                                                                    "GioiTinh as 'Giới Tính', " +
                                                                    "CanCuoc as 'Căn cước'," +
                                                                    "SDT as 'Số Điện Thoại'," +
                                                                    "Email as Email," +
                                                                    "DiaChi as 'Địa Chỉ', " +
                                                                    "ChucVu as 'Chức Vụ'" +
                                                                    "from NHAN_VIEN");
        }

        private void BbiThemMoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (TeTenNV.Text != "")
            {
                if (TeMaNV.Text != "")
                {
                    XtraMessageBox.Show("Mã Nhân Viên cần để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string s = string.Format("INSERT INTO NHAN_VIEN (TenNV,GioiTinh, SDT, DiaChi, CanCuoc, NgaySinh, Email ,ChucVu) VALUES" + "(N'{0}',N'{1}','{2}',N'{3}','{4}','{5}', '{6}', N'{7}')", TeTenNV.Text, CbeGioiTinh.Text, TeSDT.Text, TeDiaChi.Text, TeCCCD.Text, DeNgaySinh.Text, TeEmail.Text, CbeChucVu.Text);
                    XtraMessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GcDanhMucNV.DataSource = dataAccess.GetDataTable(s);
                    LoadData();
                }
            }
            else
            {
                XtraMessageBox.Show("Không được để trống các trường sau \n - Tên Nhân Viên ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BbiSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(TeMaNV.Text != "" & TeMaNV.Text != "")
            {
                DialogResult dr = XtraMessageBox.Show("Xác nhận sửa?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (true)
                {
                    string s = string.Format("UPDATE NHAN_VIEN SET " + "TenNV = N'{1}' where MaNV = N'{0}' )", TeMaNV.Text, TeMaNV.Text);
                    XtraMessageBox.Show("Sửa thành công!");
                    GcDanhMucNV.DataSource = dataAccess.GetDataTable(s);
                    LoadData();
                }
            }
            else
            {
                XtraMessageBox.Show("Không được để trống các trường sau\n - Mã Nhân Viên \n - Tên Nhân Viên ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BbiLamMoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
        }

        private void BbiXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("Xác nhận xoá?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (true)
            {
                GridView currentView = (GridView)GcDanhMucNV.FocusedView;

                string _MaNV = currentView.GetRowCellValue(currentView.FocusedRowHandle, currentView.Columns[0]).ToString();

                dataAccess.UpdateData(string.Format(" delete from NHAN_VIEN where MaNV = {0})", _MaNV));
                LoadData();
            }
        }
    }
}
