using DevExpress.DataAccess.Native.Data;
using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
using static DevExpress.Xpo.Helpers.AssociatedCollectionCriteriaHelper;

namespace market_management
{
    public partial class FrmTaoHDBan : DevExpress.XtraEditors.XtraForm
    {
        DataAccess dataAccess = new DataAccess();
        System.Data.DataTable dataTable;

        string maHDB = GenerateRandomString(8);
        string current_time = DateTime.Now.ToShortDateString();

        int maKH = -1;
        int phantramGiamGia = 0;
        int tongtien = 0;
        int thanhtien = 0;
        

        public FrmTaoHDBan()
        {
            InitializeComponent();

            HienThiTenSP();
            HienThiSoDienThoai();

            dataTable = new System.Data.DataTable();
            dataTable.Columns.Add("Mã Sản Phẩm", typeof(int));
            dataTable.Columns.Add("Tên Sản Phẩm", typeof(string));
            dataTable.Columns.Add("Số Lượng", typeof(int));
            dataTable.Columns.Add("Giá Bán Lẻ", typeof(decimal));

            GcSP_HDB.DataSource = dataTable;
            GvSP_HDB.Columns["Mã Sản Phẩm"].OptionsColumn.ReadOnly = true;
            GvSP_HDB.Columns["Tên Sản Phẩm"].OptionsColumn.ReadOnly = true;
            GvSP_HDB.Columns["Giá Bán Lẻ"].OptionsColumn.ReadOnly = true;


            LbThoiGian.Text = current_time;
            LbMaHDB.Text = maHDB;
            LbTenNV.Text = "";
        }

        private bool KiemTraKhachHang()
        {
            string sdtCheck = CbeSDT.Text;

            string query = $"SELECT COUNT(*) FROM KHACH_HANG WHERE SDT = '{sdtCheck}'";

            int count = Convert.ToInt32(dataAccess.GetScalar(query));

            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void LayThongTinKhachHang(string sdt)
        {

            string query = $"SELECT * FROM KHACH_HANG WHERE SDT = '{sdt}'";

            System.Data.DataTable customerData = dataAccess.GetDataTable(query);

            TeTenKH.Text = Convert.ToString(customerData.Rows[0]["TenKH"]);
            string maGiamGia = Convert.ToString(customerData.Rows[0]["MaGiamGia"]);

            phantramGiamGia = LayMaGiamGia(maGiamGia);
            LbDuocGiam.Text = phantramGiamGia.ToString() + '%';

            maKH = Convert.ToInt32(customerData.Rows[0]["MaKH"]);

        }

        private int LayMaGiamGia(string maGiamGia)
        {
            if(maGiamGia == null)
            {
                return 0;
            }    
            string query = $"SELECT * FROM MA_GIAM_GIA WHERE MaGiamGia = '{maGiamGia}'";
            System.Data.DataTable dataTable = dataAccess.GetDataTable(query);

            int phantram = Convert.ToInt32(dataTable.Rows[0]["PhanTram"]);

            return phantram;
        }

        private void XuLyKhachHang()
        {
            string SDT = CbeSDT.Text;
            bool khachhang = KiemTraKhachHang();
            if(khachhang == true)
            {
                LayThongTinKhachHang(SDT);
            }
            else
            {
                maKH = -1;
            }    
            
        }

        private void BtnTaoHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                CapNhatSanPham();
                CapNhatTichDiem();
                LuuHoaDon();
                LuuCTHoaDon();

                var result = XtraMessageBox.Show("Thêm hóa đơn bán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Lỗi Thêm hóa đơn bán: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CapNhatTichDiem()
        {
            if(maKH == -1)
            {
                return;
            }
            int diem = Convert.ToInt32(thanhtien / 1000);
            string query = $"UPDATE KHACH_HANG SET TichDiem = {diem} WHERE MaKH = {maKH}";

            dataAccess.UpdateData(query);

        }

        private void LuuHoaDon()
        {
            int maNV = Session.luuMaNV;
            int tongtien = Convert.ToInt32(LbTongTien.Text);
            string thoigian = LbThoiGian.Text;
            if (maKH == -1)
            {
                dataAccess.UpdateData($"INSERT INTO HOA_DON_BAN (MaHDB, MaNV, TongTien, ThoiGian) VALUES ('{maHDB}', {maNV}, {tongtien}, '{thoigian}')");
            }    
            else
            {
                dataAccess.UpdateData($"INSERT INTO HOA_DON_BAN (MaHDB, MaKH, MaNV, TongTien, ThoiGian) VALUES ('{maHDB}', {maKH}, {maNV}, {tongtien}, '{thoigian}')");
            }    
        }

        private void LuuCTHoaDon()
        {
            foreach (DataRow row in dataTable.Rows)
            {
                int maSP = Convert.ToInt32(row["Mã Sản Phẩm"]);
                int soluong = Convert.ToInt32(row["Số Lượng"]);
                dataAccess.UpdateData($"INSERT INTO CT_HOA_DON_BAN (MaHDB, MaSP, SoLuong) VALUES ('{maHDB}', {maSP}, {soluong})");
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            string tenSP = CbeTenSP.Text;

            string query = $"SELECT MaSP AS 'Mã Sản Phẩm', TenSP AS 'Tên Sản Phẩm', GiaBanLe AS 'Giá Bán Lẻ', SoLuong AS 'Số Lượng' FROM SAN_PHAM WHERE TenSP = '{tenSP}'"; // Thay TenBang và TenKhachHang bằng tên bảng và tên cột trong cơ sở dữ liệu của bạn

            System.Data.DataTable sanpham = dataAccess.GetDataTable(query);

            int soluongKho = Convert.ToInt32(sanpham.Rows[0]["Số Lượng"]);

            if (sanpham.Rows.Count > 0)
            {
                DataRow newRow = dataTable.NewRow();
                newRow["Mã Sản Phẩm"] = sanpham.Rows[0]["Mã Sản Phẩm"];
                newRow["Tên Sản Phẩm"] = sanpham.Rows[0]["Tên Sản Phẩm"];
                newRow["Giá Bán Lẻ"] = sanpham.Rows[0]["Giá Bán Lẻ"];
                newRow["Số Lượng"] = TeSoLuong.Text;

                if (Convert.ToInt32(TeSoLuong.Text) > soluongKho)
                {
                    MessageBox.Show("Không đủ hàng");
                    return;
                }

                dataTable.Rows.Add(newRow);
            }   

            //LbTongTien.Text = TinhTongTien().ToString();
        }

        private List<string> LayTenSP()
        {
            List<string> TenSP = new List<string>();
            string query = "SELECT TenSP FROM SAN_PHAM";

            using (SqlCommand cmd = new SqlCommand(query, dataAccess.objConnection))
            {
                dataAccess.objConnection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TenSP.Add(reader["TenSP"].ToString());
                    }
                }

                dataAccess.objConnection.Close();

            }
            return TenSP;
        }

        private void HienThiTenSP()
        {
            List<string> TenLoaiSP = LayTenSP();
            CbeTenSP.Properties.Items.AddRange(TenLoaiSP);

            CbeTenSP.Properties.AutoComplete = true;
            CbeTenSP.Properties.CaseSensitiveSearch = false;
        }

        private List<string> LaySDT()
        {
            List<string> SDT = new List<string>();
            string query = "SELECT SDT FROM KHACH_HANG";

            using (SqlCommand cmd = new SqlCommand(query, dataAccess.objConnection))
            {
                dataAccess.objConnection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SDT.Add(reader["SDT"].ToString());
                    }
                }

                dataAccess.objConnection.Close();
            }
            return SDT;
        }

        private void HienThiSoDienThoai()
        {
            List<string> SoDienThoai = LaySDT();
            CbeSDT.Properties.Items.AddRange(SoDienThoai);

            CbeSDT.Properties.AutoComplete = true;
            CbeSDT.Properties.CaseSensitiveSearch = false;
        }

        private int TinhTongTien()
        {
            int tongtien = 0;

            // Duyệt qua tất cả các dòng trong DataTable và tính tổng thu nhập
            foreach (DataRow row in dataTable.Rows)
            {
                if (row["Giá Bán Lẻ"] != DBNull.Value)
                {
                    tongtien += Convert.ToInt32(row["Giá Bán Lẻ"]) * Convert.ToInt32(row["Số Lượng"]);
                }
            }

            return tongtien;
        }

        private void CapNhatSanPham()
        {
            foreach (DataRow row in dataTable.Rows)
            {
                int maSP = Convert.ToInt32(row["Mã Sản Phẩm"]);
                int soluongBan = Convert.ToInt32(row["Số Lượng"]); 
                dataAccess.UpdateData(string.Format($"UPDATE SAN_PHAM SET SoLuong = SoLuong - {soluongBan} where MaSP = {maSP}"));
            }
        }

        private void GvSP_HDB_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            tongtien = TinhTongTien();
            thanhtien = tongtien - (tongtien * phantramGiamGia) / 100;
            LbTongTien.Text = tongtien.ToString();
            LbThanhTien.Text = thanhtien.ToString();
        }

        private void GvSP_HDB_RowCountChanged(object sender, EventArgs e)
        {
            tongtien = TinhTongTien();
            thanhtien = tongtien - (tongtien * phantramGiamGia) / 100;
            LbTongTien.Text = tongtien.ToString();
            LbThanhTien.Text = thanhtien.ToString();
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
        

        private void CbeSDT_Leave(object sender, EventArgs e)
        {
            XuLyKhachHang();
        }

        private void TeSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
