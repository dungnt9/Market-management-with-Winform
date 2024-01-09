using DevExpress.XtraBars;
using DevExpress.XtraEditors;
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

            HienThiGioiTinh();
            HienThiMaGiamGia();
        }
        //Lấy data từ CSDL
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
            FrmThemKH frmKH = new FrmThemKH();
            frmKH.ShowDialog();
            frmKH.BringToFront();
        }

        private void BbiSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            var confirmationResult = XtraMessageBox.Show("Bạn có chắc chắn muốn sửa thông tin khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                try
                {
                    string s = string.Format("UPDATE KHACH_HANG SET " + "TenKH = N'{1}' where MaKH = {0} )", TeTenKH.Text, TeMaKH.Text);
                    dataAccess.UpdateData(s);
                    XtraMessageBox.Show("Cập nhật khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            TeMaKH.Text = "";
            TeTenKH.Text = "";
            CbeGioiTinh.Text = "";
            DeNgaySinh.Text = "";
            TeSDT.Text = "";
            CbeMaGiamGia.Text = "";
            TeDiaChi.Text = "";
        }
        private List<string> LayGioiTinh()
        {
            List<string> GioiTinh = new List<string>();
            string query = "SELECT DISTINCT GioiTinh FROM KHACH_HANG";

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
        
        private List<string> LayMaGiamGia()
        {
            List<string> MaGiamGia = new List<string>();
            string query = "SELECT MaGiamGia FROM MA_GIAM_GIA";

            using (SqlCommand cmd = new SqlCommand(query, dataAccess.objConnection))
            {
                dataAccess.objConnection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MaGiamGia.Add(reader["MaGiamGia"].ToString());
                    }
                }

                dataAccess.objConnection.Close();

            }
            return MaGiamGia;
        }
        private void HienThiGioiTinh()
        {
            List<string> GioiTinh = LayGioiTinh();
            CbeGioiTinh.Properties.Items.AddRange(GioiTinh);

            CbeGioiTinh.Properties.AutoComplete = true;
            CbeGioiTinh.Properties.CaseSensitiveSearch = false;
        }
        private void HienThiMaGiamGia()
        {
            List<string> MaGiamGia = LayMaGiamGia();
            CbeMaGiamGia.Properties.Items.AddRange(MaGiamGia);

            CbeMaGiamGia.Properties.AutoComplete = true;
            CbeMaGiamGia.Properties.CaseSensitiveSearch = false;
        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView currentView = (GridView)GcDanhMucKH.FocusedView;
            var MaKH = gridView.GetRowCellValue(e.FocusedRowHandle, currentView.Columns[0]).ToString();
            var TenKH = gridView.GetRowCellValue(e.FocusedRowHandle, currentView.Columns[1]).ToString();
            var NgaySinh = gridView.GetRowCellValue(e.FocusedRowHandle, currentView.Columns[2]).ToString();
            var GioiTinh = gridView.GetRowCellValue(e.FocusedRowHandle, currentView.Columns[3]).ToString();
            var SDT = gridView.GetRowCellValue(e.FocusedRowHandle, currentView.Columns[4]).ToString();
            var DiaChi = gridView.GetRowCellValue(e.FocusedRowHandle, currentView.Columns[5]).ToString();
            var MaGiamGia = gridView.GetRowCellValue(e.FocusedRowHandle, currentView.Columns[6]).ToString();
            TeMaKH.Text = MaKH;
            TeTenKH.Text = TenKH;
            CbeGioiTinh.Text = GioiTinh;
            if(DeNgaySinh.Text != "")
            {
                DeNgaySinh.Text = NgaySinh.Substring(0, 9);
            }
            else
            {
                DeNgaySinh.Text = NgaySinh;
            }
            TeSDT.Text = SDT;
            TeDiaChi.Text = DiaChi;
            CbeMaGiamGia.Text = MaGiamGia;
        }
    }
}
