using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
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
using DevExpress.XtraExport.Helpers;
using System.Data.SqlClient;

namespace market_management.UI
{
    public partial class UcLoaiSanPham : DevExpress.XtraEditors.XtraUserControl
    {
        DataAccess dataAccess = new DataAccess();
        public UcLoaiSanPham()
        {
            InitializeComponent();
            LoadData();
        }
        
        void LoadData()
        {
            GcLoaiSP.DataSource = dataAccess.GetDataTable("SELECT \r\n\tMaLoaiSP as 'Mã loại sản phẩm', \r\n\tTenLoaiSP as 'Tên loại sản phẩm'\r\nfrom LOAI_SAN_PHAM");
        }
        
        /*private bool IsMaLoaiSPExists(string maLoaiSP)
        {
            // Thực hiện truy vấn để lấy danh sách các MaLoaiSP từ bảng LOAI_SAN_PHAM
            DataTable dataTable = dataAccess.GetDataTable($"SELECT MaLoaiSP FROM LOAI_SAN_PHAM WHERE MaLoaiSP = '{maLoaiSP}'");

            // Kiểm tra sự tồn tại của maLoaiSP trong danh sách
            return dataTable.Rows.Count > 0;
        }
        */
        private void BbiThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var maLoaiSP = CbeMaLoaiSP.Text;
            var tenLoaiSP = CbeTenLoaiSP.Text;

            if (string.IsNullOrEmpty(maLoaiSP))
            {
                XtraMessageBox.Show("Bạn phải nhập mã loại sản phẩm", "Thông báo");
                CbeMaLoaiSP.Focus();
                return;
            }

            /*var isExist = IsMaLoaiSPExists(maLoaiSP);

            if (isExist)
            {
                XtraMessageBox.Show($"Mã loại sản phẩm {maLoaiSP} đã tồn tại!", "Thông báo");
                CbeMaLoaiSP.Focus();
                CbeMaLoaiSP.SelectAll();
                return;
            }
            */
            if (string.IsNullOrEmpty(tenLoaiSP))
            {
                XtraMessageBox.Show("Nhập tên loại sản phẩm", "Thông báo");
                return;
            }

            // Thực hiện thêm loại sản phẩm vào cơ sở dữ liệu
            var sqlInsert = $"INSERT INTO LOAI_SAN_PHAM (MaLoaiSP, TenLoaiSP) VALUES ('{maLoaiSP}', N'{tenLoaiSP}')";

            DataAccess dataAccess = new DataAccess();
            try
            {
                dataAccess.UpdateData(sqlInsert);

                XtraMessageBox.Show("Thêm loại sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sau khi thêm thành công, bạn có thể làm sạch các trường nhập liệu hoặc load lại dữ liệu
                CbeMaLoaiSP.Text = "";
                CbeTenLoaiSP.Text = "";
                LoadData(); // Gọi lại phương thức để cập nhật GridView
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Lỗi thêm loại sản phẩm: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
            var maLoaiSP = gridView1.GetRowCellValue(e.FocusedRowHandle, "Mã loại sản phẩm").ToString();
            var tenLoaiSP = gridView1.GetRowCellValue(e.FocusedRowHandle, "Tên loại sản phẩm").ToString();
            CbeMaLoaiSP.Text = maLoaiSP;
            CbeTenLoaiSP.Text = tenLoaiSP;
            
        }
        


        private void BbiSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            var maLoaiSP = CbeMaLoaiSP.Text;
            var tenLoaiSP = CbeTenLoaiSP.Text;

            if (string.IsNullOrEmpty(maLoaiSP) || string.IsNullOrEmpty(tenLoaiSP))
            {
                XtraMessageBox.Show("Vui lòng chọn loại sản phẩm cần cập nhật và nhập thông tin mới", "Thông báo");
                return;
            }

            var sqlUpdate = $"UPDATE LOAI_SAN_PHAM SET TenLoaiSP = N'{tenLoaiSP}' WHERE MaLoaiSP = '{maLoaiSP}'";

            DataAccess dataAccess = new DataAccess();
            try
            {
                dataAccess.UpdateData(sqlUpdate);
                XtraMessageBox.Show("Cập nhật loại sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Gọi lại phương thức để cập nhật GridView
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Lỗi cập nhật loại sản phẩm: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BbiLamMoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
            CbeMaLoaiSP.Text = "";
            CbeTenLoaiSP.Text = "";
        }




        private List<string> LayMaLoaiSP()
        {
            List<string> MaLoaiSP = new List<string>();
            string connectionString = @"Data Source= DESKTOP-IAMCQPA\SQLEXPRESS;Initial Catalog=QLST;Integrated Security=True ";
            string query = "SELECT MaLoaiSP FROM LOAI_SAN_PHAM";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MaLoaiSP.Add(reader["MaLoaiSP"].ToString());
                        }
                    }
                }
            }

            return MaLoaiSP;
        }
        private void HienThiMaLoaiSP()
        {
            List<string> MaLoaiSP = LayMaLoaiSP();
            CbeMaLoaiSP.Properties.Items.AddRange(MaLoaiSP);

            // Nếu bạn muốn có tính năng tự động hoàn tất khi người dùng nhập
            CbeMaLoaiSP.Properties.AutoComplete = true;
            CbeMaLoaiSP.Properties.CaseSensitiveSearch = false;
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
            CbeTenLoaiSP.Properties.Items.AddRange(TenLoaiSP);

            // Nếu bạn muốn có tính năng tự động hoàn tất khi người dùng nhập
            CbeTenLoaiSP.Properties.AutoComplete = true;
            CbeTenLoaiSP.Properties.CaseSensitiveSearch = false;
        }


        private void UcLoaiSanPham_Load(object sender, EventArgs e)
        {
            HienThiMaLoaiSP();
            HienThiTenLoaiSP();
        }





        private void bsiRecordsCount_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        private void CbeMaLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
