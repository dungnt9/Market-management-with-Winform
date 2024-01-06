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
            GcSP.DataSource = dataAccess.GetDataTable("SELECT \r\n    SP.MaSP AS 'Mã sản phẩm',\r\n    SP.TenSP AS 'Tên sản phẩm',\r\n    LSP.TenLoaiSP AS 'Phân loại',\r\n    SP.SoLuong AS 'Số lượng',\r\n    SP.GiaNhap AS 'Giá nhập',\r\n    SP.GiaBanLe AS 'Giá bán lẻ'\r\nFROM \r\n    SAN_PHAM SP\r\nJOIN \r\n    LOAI_SAN_PHAM LSP ON SP.MaLoaiSP = LSP.MaLoaiSP;");
        }


        private void gridView_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var maSP = gridView.GetRowCellValue(e.FocusedRowHandle, "Mã sản phẩm").ToString();
            var tenSP = gridView.GetRowCellValue(e.FocusedRowHandle, "Tên sản phẩm").ToString();
            var phanLoai= gridView.GetRowCellValue(e.FocusedRowHandle, "Phân loại").ToString();
            var soLuong = gridView.GetRowCellValue(e.FocusedRowHandle, "Số lượng").ToString();
            var giaNhap = gridView.GetRowCellValue(e.FocusedRowHandle, "Giá nhập").ToString();
            var giaBan = gridView.GetRowCellValue(e.FocusedRowHandle, "Giá bán lẻ").ToString();
            CmbMaSP.Text = maSP;
            CbeTenSP.Text = tenSP;
            CbePhanLoai.Text = phanLoai;
            TeSoLuong.Text = soLuong;
            TeGiaNhap.Text = giaNhap;
            TeGiaBan.Text = giaBan;

        }

        private void BbiLamMoi_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            LoadData();
            CmbMaSP.Text = "";
            CbeTenSP.Text = "";
            CbePhanLoai.Text = "";
            TeSoLuong.Text = "";
            TeGiaNhap.Text = "";
            TeGiaBan.Text = "";
        }

        private void BbiSua_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            var maSP = CmbMaSP.Text;
            var tenSP = CbeTenSP.Text;
            var phanLoai = CbePhanLoai.Text;
            var soLuong = TeSoLuong.Text;
            var giaNhap = TeGiaNhap.Text;
            var giaBan = TeGiaBan.Text;

            if (string.IsNullOrEmpty(maSP) || string.IsNullOrEmpty(tenSP))
            {
                XtraMessageBox.Show("Vui lòng chọn sản phẩm cần cập nhật và nhập thông tin mới", "Thông báo");
                return;
            }

            var sqlUpdate = $"UPDATE SAN_PHAM \r\nSET TenSP = N'{tenSP}', \r\n    MaLoaiSP = (SELECT MaLoaiSP FROM LOAI_SAN_PHAM WHERE TenLoaiSP = N'{phanLoai}'), \r\n    SoLuong = '{soLuong}', \r\n    GiaNhap = '{giaNhap}', \r\n    GiaBanLe = '{giaBan}' \r\nWHERE MaSP = '{maSP}';\r\n";

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




        private List<string> LayTenSP()
        {
            List<string> TenSP = new List<string>();
            string connectionString = @"Data Source= DESKTOP-IAMCQPA\SQLEXPRESS;Initial Catalog=QLST;Integrated Security=True ";
            string query = "SELECT TenSP FROM SAN_PHAM";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TenSP.Add(reader["TenSP"].ToString());
                        }
                    }
                }
            }

            return TenSP;
        }
        private void HienThiTenSP()
        {
            List<string> TenSP = LayTenSP();
            CbeTenSP.Properties.Items.AddRange(TenSP);

            // Nếu bạn muốn có tính năng tự động hoàn tất khi người dùng nhập
            CbeTenSP.Properties.AutoComplete = true;
            CbeTenSP.Properties.CaseSensitiveSearch = false;
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
        private List<string> LayMaSP()
        {
            List<string> MaSP = new List<string>();
            string connectionString = @"Data Source= DESKTOP-IAMCQPA\SQLEXPRESS;Initial Catalog=QLST;Integrated Security=True ";
            string query = "SELECT MaSP FROM SAN_PHAM";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MaSP.Add(reader["MaSP"].ToString());
                        }
                    }
                }
            }

            return MaSP;
        }
        private void HienThiMaSP()
        {
            List<string> MaSP = LayMaSP();

            // Assuming CmbMaSP is your ComboBox control
            CmbMaSP.Items.AddRange(MaSP.ToArray());

            // If you want to enable auto-complete and case-insensitive search
            CmbMaSP.AutoCompleteMode = AutoCompleteMode.Suggest;
            CmbMaSP.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void UcSanPham_Load(object sender, EventArgs e)
        {
            HienThiTenSP();
            HienThiTenLoaiSP();
            HienThiMaSP();
        }






        private bool IsMaLoaiSPExists(string maSP)
        {
            // Thực hiện truy vấn để lấy danh sách các MaSP từ bảng SAN_PHAM
            DataTable dataTable = dataAccess.GetDataTable($"SELECT MaSP FROM SAN_PHAM WHERE MaSP = '{maSP}'");

            // Kiểm tra sự tồn tại của maSP trong danh sách
            return dataTable.Rows.Count > 0;
        }

        private void BbiThem_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            var maSP = CmbMaSP.Text;
            var tenSP = CbeTenSP.Text;
            var phanLoai = CbePhanLoai.Text;
            var soLuong = TeSoLuong.Text;
            var giaNhap = TeGiaNhap.Text;
            var giaBan = TeGiaBan.Text;

            if (string.IsNullOrEmpty(maSP))
            {
                XtraMessageBox.Show("Bạn phải nhập mã sản phẩm", "Thông báo");
                CmbMaSP.Focus();
                return;
            }

            var isExist = IsMaLoaiSPExists(maSP);

            if (isExist)
            {
                XtraMessageBox.Show($"Mã sản phẩm {maSP} đã tồn tại!", "Thông báo");
                CmbMaSP.Focus();
                CmbMaSP.SelectAll();
                return;
            }

            if (string.IsNullOrEmpty(tenSP))
            {
                XtraMessageBox.Show("Nhập tên sản phẩm", "Thông báo");
                return;
            }

            // Thực hiện thêm sản phẩm vào cơ sở dữ liệu
            var sqlInsert = $"INSERT INTO SAN_PHAM (MaSP, TenSP, GiaBan, GiaNhap, MaLoaiSP, SoLuong) VALUES ('{maSP}', N'{tenSP}', {giaBan}, {giaNhap}, (SELECT MaLoaiSP FROM LOAI_SAN_PHAM WHERE TenLoaiSP = N'{phanLoai}'), {soLuong})";

            DataAccess dataAccess = new DataAccess();
            try
            {
                dataAccess.UpdateData(sqlInsert);

                XtraMessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CmbMaSP.Text = "";
                CbeTenSP.Text = "";
                CbePhanLoai.Text = "";
                TeSoLuong.Text = "";
                TeGiaNhap.Text = "";
                TeGiaBan.Text = "";
                LoadData(); // Gọi lại phương thức để cập nhật GridView
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Lỗi thêm sản phẩm: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
