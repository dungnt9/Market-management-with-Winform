using DevExpress.Xpo;
using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market_management
{
    public partial class FrmTaoHDNhap : DevExpress.XtraEditors.XtraForm
    {
        DataAccess dataAccess = new DataAccess();
        System.Data.DataTable dataTable;
        public string maHDN = GenerateRandomString(8);
        string current_time = DateTime.Now.ToShortDateString();

        public FrmTaoHDNhap()
        {
            InitializeComponent();
           
            HienThiTenNCC();

            LbcTenNV.Text = Session.tenNV;
            LbcMaHDN.Text = maHDN;
            CmbTenNCC.SelectedIndexChanged += CmbTenNCC_SelectedIndexChanged;

            dataTable = new System.Data.DataTable();
            dataTable.Columns.Add("Mã Sản Phẩm", typeof(int));
            dataTable.Columns.Add("Tên Sản Phẩm", typeof(string));
            dataTable.Columns.Add("Giá Nhập", typeof(decimal));
            dataTable.Columns.Add("Số Lượng", typeof(int));

            LbcThoiGian.Text = current_time;

            TeSoLuong.KeyPress += TeSoLuong_KeyPress;
            GcSP.DataSource = dataTable;
        }
        
        private List<string> LayTenNCC()
        {
            List<string> TenNCC = new List<string>();
            string query = "SELECT TenNCC FROM NHA_CUNG_CAP";

            using (SqlCommand cmd = new SqlCommand(query, dataAccess.objConnection))
            {
                dataAccess.objConnection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TenNCC.Add(reader["TenNCC"].ToString());
                    }
                }
                dataAccess.objConnection.Close();
            }
            return TenNCC;
        }
        private void HienThiTenNCC()
        {
            List<string> TenNCC = LayTenNCC();
            foreach (string item in TenNCC)
            {
                CmbTenNCC.Items.Add(item);
            }
        }
        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmTaoDonNhap_Load(object sender, EventArgs e)
        {
            
        }
        private void BtnTaoHD_Click(object sender, EventArgs e)
        {
            try
            {
                CapNhatSanPham();
                LuuHoaDon();
                LuuCTHoaDon();
                var result = XtraMessageBox.Show("Thêm hóa đơn nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    this.Close(); 
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Lỗi tạo hóa đơn nhập: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void LuuHoaDon()
        {
            int tongTien = Convert.ToInt32(LbcTongTien.Text);
            string thoiGian = LbcThoiGian.Text;

            int maNV = Session.luuMaNV;

            string _maHDN = maHDN;
            string tenNCC = CmbTenNCC.SelectedItem.ToString();
            string query = $"SELECT MaNCC FROM NHA_CUNG_CAP WHERE TenNCC = N'{tenNCC}'";            

            DataTable NCCData = dataAccess.GetDataTable(query);

            int maNCC = Convert.ToInt32(NCCData.Rows[0]["MaNCC"]);

            
            dataAccess.UpdateData($"INSERT INTO HOA_DON_NHAP (MaHDN, MaNCC, MaNV, TongTien, ThoiGian) " +
                $"VALUES ('{_maHDN}', {maNCC}, {maNV}, {tongTien}, '{thoiGian}')");
        }
        private void LuuCTHoaDon()
        {
            foreach (DataRow row in dataTable.Rows)
            {
                string _maHDN = maHDN;
                double tongTien=Convert.ToDouble(row["Giá Nhập"]) * Convert.ToDouble(row["Số Lượng"]);
                int maSP = Convert.ToInt32(row["Mã Sản Phẩm"]);
                int soLuong = Convert.ToInt32(row["Số Lượng"]);
                dataAccess.UpdateData($"INSERT INTO CT_HOA_DON_NHAP (MaHDN, MaSP, SoLuong, ThanhTien) VALUES" +
                    $" ('{_maHDN}', {maSP}, {soLuong}, {tongTien})");
            }
        }
        private void CmbTenNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenNCC = CmbTenNCC.Text;

            string query = $"SELECT MaLoaiSP FROM NHA_CUNG_CAP WHERE TenNCC = N'{tenNCC}'";

            string maLoaiSP = "";
            using (SqlCommand cmd = new SqlCommand(query, dataAccess.objConnection))
            {
                dataAccess.objConnection.Open();

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    maLoaiSP = result.ToString();
                }
                dataAccess.objConnection.Close();
            }
            LaySPCuaMaLoaiSP(maLoaiSP);
        }
        private void LaySPCuaMaLoaiSP(string maLoaiSP)
        {
            string query = $"SELECT TenSP FROM SAN_PHAM WHERE MaLoaiSP = '{maLoaiSP}'";

            List<string> tenSPList = new List<string>();
            using (SqlCommand cmd = new SqlCommand(query, dataAccess.objConnection))
            {
                dataAccess.objConnection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tenSPList.Add(reader["TenSP"].ToString());
                    }
                }
                dataAccess.objConnection.Close();
            }

            CbeTenSP.Properties.Items.Clear();
            CbeTenSP.Properties.Items.AddRange(tenSPList);
            CbeTenSP.Properties.AutoComplete = true;
            CbeTenSP.Properties.CaseSensitiveSearch = false;
        }
        private void BtnThemSP_Click(object sender, EventArgs e)
        {
            string tenSP = CbeTenSP.Text;

            if (string.IsNullOrEmpty(tenSP))
            {
                MessageBox.Show("Bạn phải chọn một sản phẩm trước khi thêm vào hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = $"SELECT MaSP AS 'Mã Sản Phẩm', TenSP AS 'Tên Sản Phẩm', GiaNhap AS 'Giá Nhập', " +
                $"SoLuong AS 'Số Lượng' FROM SAN_PHAM WHERE TenSP = '{tenSP}'";

            System.Data.DataTable sanpham = dataAccess.GetDataTable(query);

            if (sanpham.Rows.Count > 0)
            {
                DataRow newRow = dataTable.NewRow();
                newRow["Mã Sản Phẩm"] = sanpham.Rows[0]["Mã Sản Phẩm"];
                newRow["Tên Sản Phẩm"] = sanpham.Rows[0]["Tên Sản Phẩm"];
                newRow["Giá Nhập"] = sanpham.Rows[0]["Giá Nhập"];
                newRow["Số Lượng"] = TeSoLuong.Text;
                
                dataTable.Rows.Add(newRow);
            }

            LbcTongTien.Text = TinhTongTien().ToString();

        }
        private double TinhTongTien()
        {
            double tongTien = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                if (row["Giá Nhập"] != DBNull.Value)
                {
                    tongTien += Convert.ToDouble(row["Giá Nhập"]) * Convert.ToDouble(row["Số Lượng"]);
                }
            }

            return tongTien;
        }
        private void CapNhatSanPham()
        {
            foreach (DataRow row in dataTable.Rows)
            {
                int maSP = Convert.ToInt32(row["Mã Sản Phẩm"]);
                int soLuongNhap = Convert.ToInt32(row["Số Lượng"]);
                dataAccess.UpdateData(string.Format($"UPDATE SAN_PHAM SET SoLuong = SoLuong + {soLuongNhap} where MaSP = {maSP}"));
            }
        }
        static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            Random random = new Random();
            char[] randomArray = new char[length];

            for (int i = 0; i < length; i++)
            {
                randomArray[i] = chars[random.Next(chars.Length)];
            }
            return new string(randomArray);
        }
        
        private void TeSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CbeTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GvSP_HDN_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            LbcTongTien.Text = TinhTongTien().ToString();
        }

        private void GvSP_HDN_RowCountChanged(object sender, EventArgs e)
        {
            LbcTongTien.Text = TinhTongTien().ToString();
        }
    }
     

}
