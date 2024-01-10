using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace market_management
{
    public partial class FrmThemSP : DevExpress.XtraEditors.XtraForm
    {
        public FrmThemSP()
        {
            InitializeComponent();
        }
        DataAccess dataAccess = new DataAccess();
        private bool IsTenSPExists(string tenSP)
        {
            DataTable dataTable = dataAccess.GetDataTable($"SELECT TenSP FROM SAN_PHAM WHERE TenSP = N'{tenSP}'");
            return dataTable.Rows.Count > 0;
        }
        private List<string> LayTenLoaiSP()
        {
            List<string> TenLoaiSP = new List<string>();
            string query = "SELECT TenLoaiSP FROM LOAI_SAN_PHAM";

            using (SqlCommand cmd = new SqlCommand(query, dataAccess.objConnection))
            {
                dataAccess.objConnection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TenLoaiSP.Add(reader["TenLoaiSP"].ToString());
                    }
                }
                dataAccess.objConnection.Close();
            }
            return TenLoaiSP;
        }

        private void HienThiTenLoaiSP()
        {
            List<string> TenLoaiSP = LayTenLoaiSP();
            CbePhanLoai.Properties.Items.AddRange(TenLoaiSP);

            CbePhanLoai.Properties.AutoComplete = true;
            CbePhanLoai.Properties.CaseSensitiveSearch = false;
        }

        private void BtnThemSP_Click(object sender, EventArgs e)
        {
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

            if (string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(phanLoai) || string.IsNullOrEmpty(soLuong) || string.IsNullOrEmpty(giaNhap) || string.IsNullOrEmpty(giaBan) || string.IsNullOrEmpty(trangThai))
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

            try
            {
                dataAccess.UpdateData(sqlInsert);

                // Hiển thị thông báo và xử lý khi đóng Form
                var result = XtraMessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    this.Close(); // Tắt Form hiện tại
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Lỗi thêm sản phẩm: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmThemSP_Load(object sender, EventArgs e)
        {
            HienThiTenLoaiSP();
        }
    }
}