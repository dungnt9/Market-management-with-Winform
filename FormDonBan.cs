using DevExpress.DataAccess.Native.Data;
using DevExpress.Xpo.DB.Helpers;
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

namespace market_management
{
    public partial class FormDonBan : Form
    {
        DataAccess dataAccess = new DataAccess();
        System.Data.DataTable dataTable;

        public FormDonBan()
        {
            InitializeComponent();
            HienThiTenSP();
            HienThiSoDienThoai();

            string maHDB = GenerateRandomString(8);

            dataTable = new System.Data.DataTable();
            // ... Khởi tạo cấu trúc của DataTable, ví dụ: 
            dataTable.Columns.Add("Mã Sản Phẩm", typeof(int));
            dataTable.Columns.Add("Tên Sản Phẩm", typeof(string));
            dataTable.Columns.Add("Số Lượng", typeof(int));
            dataTable.Columns.Add("Giá Bán Lẻ", typeof(decimal));

            GcSP_HDB.DataSource = dataTable;

            DateTime currentTime = DateTime.Now;
            LbThoiGian.Text = currentTime.ToShortDateString();

            
        }

        private bool KiemTraKhachHangCu()
        {
            string sdtCheck = CbeSDT.Text;

            // Tạo câu truy vấn SQL để kiểm tra sự tồn tại của tên khách hàng
            string query = $"SELECT COUNT(*) FROM KHACH_HANG WHERE SDT = '{sdtCheck}'"; // Thay TenBang và TenKhachHang bằng tên bảng và tên cột trong cơ sở dữ liệu của bạn

           

            // Kiểm tra sự tồn tại của tên khách hàng
            int count = Convert.ToInt32(dataAccess.GetScalar(query));

            if (count > 0)
            {
                MessageBox.Show("Tên khách hàng đã tồn tại trong cơ sở dữ liệu.");
                return true;
            }
            else
            {
                MessageBox.Show("Tên khách hàng không tồn tại trong cơ sở dữ liệu.");
                return false;
            }
        }

        private void CapNhatKhachHangMoi()
        {
            return;
        }

        private void LayThongTinKhachHangCu(string sdt)
        {
            string sdtKH = sdt;

            // Tạo câu truy vấn SQL để lấy thông tin của khách hàng
            string query = $"SELECT * FROM KHACH_HANG WHERE SDT = '{sdt}'"; // Thay TenBang và TenKhachHang bằng tên bảng và tên cột trong cơ sở dữ liệu của bạn

            // Lấy dữ liệu từ cơ sở dữ liệu
            System.Data.DataTable customerData = dataAccess.GetDataTable(query);

            TeTenKH.Text = Convert.ToString(customerData.Rows[0]["TenKH"]);
            TeDiaChi.Text = Convert.ToString(customerData.Rows[0]["DiaChi"]);
            DeNgaySinh.Text = Convert.ToString(customerData.Rows[0]["NgaySinh"]);
            CbeGioiTinh.Text = Convert.ToString(customerData.Rows[0]["GioiTinh"]);

        }

        private void XuLyKhachHang()
        {
            string sdt = CbeSDT.Text;
            bool is_KHcu = KiemTraKhachHangCu();
            if(is_KHcu == true)
            {
                LayThongTinKhachHangCu(sdt);
            }    
            else
            {
                return;
            }    
            
        }

        private void BtnTaoHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void LuuHoaDon()
        {
            string maHDB = "";
            dataAccess.UpdateData($"INSERT INTO HOA_DON_BAN (MaHDB, MaKH, MaNV, TongTien, ThoiGian) VALUES ()");
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            string tenSP = CbeTenSP.Text;

            // Tạo câu truy vấn SQL để lấy thông tin của khách hàng
            string query = $"SELECT MaSP AS 'Mã Sản Phẩm', TenSP AS 'Tên Sản Phẩm', GiaBanLe AS 'Giá Bán Lẻ', SoLuong AS 'Số Lượng' FROM SAN_PHAM WHERE TenSP = '{tenSP}'"; // Thay TenBang và TenKhachHang bằng tên bảng và tên cột trong cơ sở dữ liệu của bạn

            // Lấy dữ liệu từ cơ sở dữ liệu
            System.Data.DataTable sanpham = dataAccess.GetDataTable(query);

            if (sanpham.Rows.Count > 0)
            {
                // Thêm dòng vào DataTable
                DataRow newRow = dataTable.NewRow();
                newRow["Mã Sản Phẩm"] = sanpham.Rows[0]["Mã Sản Phẩm"];
                newRow["Tên Sản Phẩm"] = sanpham.Rows[0]["Tên Sản Phẩm"];
                newRow["Giá Bán Lẻ"] = sanpham.Rows[0]["Giá Bán Lẻ"];
                newRow["Số Lượng"] = TeSoLuong.Text;

                dataTable.Rows.Add(newRow);
            }

            LbTongTien.Text = TinhTongTien().ToString();
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

        private double TinhTongTien()
        {
            double totalIncome = 0;

            // Duyệt qua tất cả các dòng trong DataTable và tính tổng thu nhập
            foreach (DataRow row in dataTable.Rows)
            {
                if (row["Giá Bán Lẻ"] != DBNull.Value)
                {
                    totalIncome += Convert.ToDouble(row["Giá Bán Lẻ"]) * Convert.ToDouble(row["Số Lượng"]);
                }
            }

            return totalIncome;
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

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            LbTongTien.Text = TinhTongTien().ToString();
        }

        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            LbTongTien.Text = TinhTongTien().ToString();
        }

        private void CbeSDT_EditValueChanged(object sender, EventArgs e)
        {
            XuLyKhachHang();
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


    }
}
