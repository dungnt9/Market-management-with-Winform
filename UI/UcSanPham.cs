using DevExpress.DataAccess.Sql;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask.Design;
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
using static DevExpress.Utils.Drawing.Helpers.NativeMethods;

namespace market_management.UI
{
    public partial class UcSanPham : DevExpress.XtraEditors.XtraUserControl
    {
        DataAccess dataAccess = new DataAccess();
        public UcSanPham()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            GcSP.DataSource = dataAccess.GetDataTable(
                "SELECT SP.MaSP AS 'Mã sản phẩm'," +
                "SP.TenSP AS 'Tên sản phẩm'," +
                "LSP.TenLoaiSP AS 'Phân loại'," +
                "SP.SoLuong AS 'Số lượng'," +
                "SP.GiaNhap AS 'Giá nhập'," +
                "SP.GiaBanLe AS 'Giá bán lẻ'," +
                "CASE " +
                "   WHEN SP.TrangThai = 1 THEN 'Đang kinh doanh'" +
                "   WHEN SP.TrangThai = 0 THEN 'Không còn kinh doanh'" +
                "   ELSE 'NULL' END AS 'Trạng thái'" +
                " FROM SAN_PHAM SP JOIN LOAI_SAN_PHAM LSP ON SP.MaLoaiSP = LSP.MaLoaiSP;");
        }


        private void gridView_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var maSP = gridView.GetRowCellValue(e.FocusedRowHandle, "Mã sản phẩm").ToString();
            var tenSP = gridView.GetRowCellValue(e.FocusedRowHandle, "Tên sản phẩm").ToString();
            var phanLoai= gridView.GetRowCellValue(e.FocusedRowHandle, "Phân loại").ToString();
            var soLuong = gridView.GetRowCellValue(e.FocusedRowHandle, "Số lượng").ToString();
            var giaNhap = gridView.GetRowCellValue(e.FocusedRowHandle, "Giá nhập").ToString();
            var giaBan = gridView.GetRowCellValue(e.FocusedRowHandle, "Giá bán lẻ").ToString();
            var trangThai = gridView.GetRowCellValue(e.FocusedRowHandle, "Trạng thái").ToString();
            LbcMaSP.Text = maSP;
            TeTenSP.Text = tenSP;
            CbePhanLoai.Text = phanLoai;
            TeSoLuong.Text = soLuong;
            TeGiaNhap.Text = giaNhap;
            TeGiaBan.Text = giaBan;
            CmbTrangThai.Text = trangThai;
        }

        private void BbiLamMoi_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            LoadData();
            LbcMaSP.Text = "";
            TeTenSP.Text = "";
            CbePhanLoai.Text = "";
            TeSoLuong.Text = "";
            TeGiaNhap.Text = "";
            TeGiaBan.Text = "";
            CmbTrangThai.Text = "";
        }

        private void BbiSua_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            var maSP = LbcMaSP.Text;
            var tenSP = TeTenSP.Text;
            var phanLoai = CbePhanLoai.Text;
            var soLuong = TeSoLuong.Text;
            var giaNhap = TeGiaNhap.Text;
            var giaBan = TeGiaBan.Text;
            var trangThai = CmbTrangThai.Text;

            if (string.IsNullOrEmpty(maSP) || string.IsNullOrEmpty(tenSP))
            {
                XtraMessageBox.Show("Vui lòng chọn sản phẩm cần cập nhật và nhập thông tin mới", "Thông báo");
                return;
            }

            var sqlUpdate = $"UPDATE SAN_PHAM SET " +
                            $"TenSP = N'{tenSP}', " +
                            $"MaLoaiSP = (SELECT MaLoaiSP FROM LOAI_SAN_PHAM WHERE TenLoaiSP = N'{phanLoai}'), " +
                            $"SoLuong = {soLuong}, " +
                            $"GiaNhap = {giaNhap}, " +
                            $"GiaBanLe = {giaBan}, " +
                            $"TrangThai = ";

            if (trangThai == "Đang kinh doanh")
            {
                sqlUpdate += "1";
            }
            else if (trangThai == "Không còn kinh doanh")
            {
                sqlUpdate += "0";
            }
            else
            {
                sqlUpdate += "NULL";
            }
            sqlUpdate += $" WHERE MaSP = '{maSP}'";




            DataAccess dataAccess = new DataAccess();
            try
            {
                dataAccess.UpdateData(sqlUpdate);
                XtraMessageBox.Show("Cập nhật sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Gọi lại phương thức để cập nhật GridView
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Lỗi cập nhật sản phẩm: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<string> LayTenLoaiSP()
        {
            List<string> TenLoaiSP = new List<string>();
            string connectionString = @"Data Source= DESKTOP-IAMCQPA\SQLEXPRESS;Initial Catalog=QLST;Integrated Security=True ";
            string query = "SELECT TenLoaiSP FROM LOAI_SAN_PHAM";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TenLoaiSP.Add(reader["TenLoaiSP"].ToString());
                        }
                    }
                }
            }

            return TenLoaiSP;
        }
        private void HienThiTenLoaiSP()
        {
            List<string> TenLoaiSP = LayTenLoaiSP();
            CbePhanLoai.Properties.Items.AddRange(TenLoaiSP);

            // Nếu bạn muốn có tính năng tự động hoàn tất khi người dùng nhập
            CbePhanLoai.Properties.AutoComplete = true;
            CbePhanLoai.Properties.CaseSensitiveSearch = false;
        }
        private void UcSanPham_Load(object sender, EventArgs e)
        {
            HienThiTenLoaiSP();
        }


        private bool IsTenSPExists(string tenSP)
        {
            DataTable dataTable = dataAccess.GetDataTable($"SELECT TenSP FROM SAN_PHAM WHERE TenSP = N'{tenSP}'");
            return dataTable.Rows.Count > 0;
        }
        private void BbiThem_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            var maSP = LbcMaSP.Text;
            var tenSP = TeTenSP.Text;
            var phanLoai = CbePhanLoai.Text;
            var soLuong = TeSoLuong.Text;
            var giaNhap = TeGiaNhap.Text;
            var giaBan = TeGiaBan.Text;
            var trangThai = CmbTrangThai.Text;

            var isExist = IsTenSPExists(tenSP);

            if (isExist)
            {
                XtraMessageBox.Show($"Sản phẩm đã tồn tại!", "Thông báo");
                return;
            }
            

            if (string.IsNullOrEmpty(tenSP)|| string.IsNullOrEmpty(phanLoai) || string.IsNullOrEmpty(soLuong) || string.IsNullOrEmpty(giaNhap) || string.IsNullOrEmpty(giaBan) || string.IsNullOrEmpty(trangThai))
            {
                XtraMessageBox.Show("Nhập đầy đủ thông tin sản phẩm", "Thông báo");
                return;
            }


            var sqlInsert = $"INSERT INTO SAN_PHAM (TenSP, MaLoaiSP, SoLuong, GiaNhap, GiaBanLe, TrangThai) " +
                            $"VALUES (N'{tenSP}', " +
                            $"(SELECT MaLoaiSP FROM LOAI_SAN_PHAM WHERE TenLoaiSP = N'{phanLoai}'), {soLuong}, {giaNhap}, {giaBan},";
            if (trangThai == "Đang kinh doanh")
            {
                sqlInsert += "1";
            }
            else if (trangThai == "Không còn kinh doanh")
            {
                sqlInsert += "0";
            }
            else
            {
                sqlInsert += "NULL";
            }
            sqlInsert += ")";













            DataAccess dataAccess = new DataAccess();
            try
            {
                dataAccess.UpdateData(sqlInsert);

                XtraMessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LbcMaSP.Text = "";
                TeTenSP.Text = "";
                CbePhanLoai.Text = "";
                TeSoLuong.Text = "";
                TeGiaNhap.Text = "";
                TeGiaBan.Text = "";
                CmbTrangThai.Text = "";

                LoadData(); // Gọi lại phương thức để cập nhật GridView
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Lỗi thêm sản phẩm: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
