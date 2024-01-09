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
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            HienThiGioiTinh();
            HienThiChucVu();
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
            if (string.IsNullOrEmpty(TeMaNV.Text))
            {
                XtraMessageBox.Show("Vui lòng chọn nhân viên cần sửa", "Thông báo");
                return;
            }

            var confirmationResult = XtraMessageBox.Show("Bạn có chắc chắn muốn sửa thông tin nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                try
                {
                    string s = string.Format("UPDATE NHAN_VIEN SET " + "TenNV = N'{1}' where MaNV = N'{0}' )", TeMaNV.Text, TeMaNV.Text);
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
            TeMaNV.Text = "";
            TeTenNV.Text = "";
            CbeGioiTinh.Text = "";
            DeNgaySinh.Text = "";
            TeSDT.Text = "";
            TeEmail.Text = "";
            TeDiaChi.Text = "";
            TeCCCD.Text = "";
            CbeChucVu.Text = "";
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
        private List<string> LayGioiTinh()
        {
            List<string> GioiTinh = new List<string>();
            string query = "SELECT DISTINCT GioiTinh FROM NHAN_VIEN";

            using (SqlCommand cmd = new SqlCommand(query, dataAccess.objConnection))
            {
                dataAccess.objConnection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        GioiTinh.Add(reader["GioiTinh"].ToString());
                    }
                }

                dataAccess.objConnection.Close();

            }
            return GioiTinh;
        }

        private List<string> LayChucVu()
        {
            List<string> ChucVu = new List<string>();
            string query = "SELECT DISTINCT ChucVu FROM NHAN_VIEN";

            using (SqlCommand cmd = new SqlCommand(query, dataAccess.objConnection))
            {
                dataAccess.objConnection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ChucVu.Add(reader["ChucVu"].ToString());
                    }
                }

                dataAccess.objConnection.Close();

            }
            return ChucVu;
        }
        private void HienThiGioiTinh()
        {
            List<string> GioiTinh = LayGioiTinh();
            CbeGioiTinh.Properties.Items.AddRange(GioiTinh);

            CbeGioiTinh.Properties.AutoComplete = true;
            CbeGioiTinh.Properties.CaseSensitiveSearch = false;
        }
        private void HienThiChucVu()
        {
            List<string> ChucVu = LayChucVu();
            CbeChucVu.Properties.Items.AddRange(ChucVu);

            CbeChucVu.Properties.AutoComplete = true;
            CbeChucVu.Properties.CaseSensitiveSearch = false;
        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //var MaNV = gridView.GetRowCellValue(e.FocusedRowHandle, "Mã Nhân Viên").ToString();
            //var TenNV = gridView.GetRowCellValue(e.FocusedRowHandle, "Tên Nhân Viên").ToString();
            var NgaySinh = gridView.GetRowCellValue(e.FocusedRowHandle, "Ngày Sinh").ToString();
           /* var GioiTinh = gridView.GetRowCellValue(e.FocusedRowHandle, "Giới Tính").ToString();
            var SDT = gridView.GetRowCellValue(e.FocusedRowHandle, "Số Điện Thoại").ToString();
            var Email = gridView.GetRowCellValue(e.FocusedRowHandle, "Email").ToString();
            var DiaChi = gridView.GetRowCellValue(e.FocusedRowHandle, "Địa Chỉ").ToString();
            var CCCD = gridView.GetRowCellValue(e.FocusedRowHandle, "Căn Cước").ToString();
            var ChucVu = gridView.GetRowCellValue(e.FocusedRowHandle, "Chức Vụ").ToString();*/
            //TeMaNV.Text = MaNV;
            //TeTenNV.Text = TenNV;
            //CbeGioiTinh.Text = GioiTinh;
            DeNgaySinh.Text = NgaySinh;
            /*TeSDT.Text = SDT;
            TeDiaChi.Text = DiaChi;
            TeCCCD.Text = CCCD;
            CbeChucVu.Text = ChucVu;
            TeEmail.Text = Email;*/
        }
    }
}
