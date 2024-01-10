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
            GcDanhMucNV.DataSource = dataAccess.GetDataTable("select MaNV as 'Mã Nhân Viên', " +
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
            FrmThemNV f = new FrmThemNV();
            f.ShowDialog();
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
                    if(CbeGioiTinh.Properties.Items.Contains(CbeGioiTinh.Text) & CbeChucVu.Properties.Items.Contains(CbeChucVu.Text))
                    {
                        string s = string.Format("UPDATE NHAN_VIEN SET " + "TenNV = {1},NgaySinh = '{2}', GioiTinh = '{3}', SDT = '{4}', DiaChi = N'{5}', CanCuoc = N'{6}', Email = {7}, ChucVu = {8}" +
                                             " where MaKH = {0} )", TeMaNV.Text, TeTenNV.Text, DeNgaySinh.Text, CbeGioiTinh.Text, TeSDT.Text, TeDiaChi.Text, TeCCCD.Text, TeEmail.Text, CbeChucVu.Text);
                        dataAccess.UpdateData(s);
                        XtraMessageBox.Show("Cập nhật nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else if (CbeChucVu.Properties.Items.Contains(CbeChucVu.Text) == false)
                    {
                        XtraMessageBox.Show("Chức vụ không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (CbeGioiTinh.Properties.Items.Contains(CbeGioiTinh.Text) == false)
                    {
                        XtraMessageBox.Show("Giới tính không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"Lỗi cập nhật nhân viên: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (dr == DialogResult.Yes)
            {
                GridView currentView = (GridView)GcDanhMucNV.FocusedView;

                int _MaNV = (int) currentView.GetRowCellValue(currentView.FocusedRowHandle, currentView.Columns[0]);

                dataAccess.UpdateData(string.Format("delete from NHAN_VIEN where MaNV = "+ _MaNV));
                XtraMessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            GridView currentView = (GridView)GcDanhMucNV.FocusedView;
            var MaNV = currentView.GetRowCellValue(e.FocusedRowHandle, currentView.Columns[0]).ToString();
            var TenNV = gridView.GetRowCellValue(e.FocusedRowHandle, currentView.Columns[1]).ToString();
            var NgaySinh = gridView.GetRowCellValue(e.FocusedRowHandle, currentView.Columns[2]).ToString();
            var GioiTinh = gridView.GetRowCellValue(e.FocusedRowHandle, currentView.Columns[3]).ToString();
            var SDT = gridView.GetRowCellValue(e.FocusedRowHandle, currentView.Columns[5]).ToString();
            var Email = gridView.GetRowCellValue(e.FocusedRowHandle, currentView.Columns[6]).ToString();
            var DiaChi = gridView.GetRowCellValue(e.FocusedRowHandle, currentView.Columns[7]).ToString();
            var CCCD = gridView.GetRowCellValue(e.FocusedRowHandle, currentView.Columns[4]).ToString();
            var ChucVu = gridView.GetRowCellValue(e.FocusedRowHandle, currentView.Columns[8]).ToString();
            TeMaNV.Text = MaNV;
            TeTenNV.Text = TenNV;
            CbeGioiTinh.Text = GioiTinh;
            if (DeNgaySinh.Text != "")
            {
                DeNgaySinh.Text = NgaySinh.Substring(0, 9);
            }
            else
            {
                DeNgaySinh.Text = NgaySinh;
            }
            TeSDT.Text = SDT;
            TeDiaChi.Text = DiaChi;
            TeCCCD.Text = CCCD;
            CbeChucVu.Text = ChucVu;
            TeEmail.Text = Email;
        }
    }
}
