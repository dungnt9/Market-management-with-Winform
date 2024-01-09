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

        string maHDB = GenerateRandomString(8);
        string current_time = DateTime.Now.ToShortDateString();

        int maKH = -1;
        

        public FormDonBan()
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

        private bool KiemTraKhachHangThanhVien()
        {
            string sdtCheck = CbeSDT.Text;

            string query = $"SELECT COUNT(*) FROM KHACH_HANG WHERE SDT = '{sdtCheck}'";

            int count = Convert.ToInt32(dataAccess.GetScalar(query));

            if (count > 0)
            {
                //MessageBox.Show("Khách hàng thành viên");
                return true;
            }
            else
            {
                //MessageBox.Show("Tên khách hàng không tồn tại trong cơ sở dữ liệu.");
                return false;
            }
        }

        private void LayThongTinKhachHangThanhVien(string sdt)
        {

            string query = $"SELECT * FROM KHACH_HANG WHERE SDT = '{sdt}'";

            System.Data.DataTable customerData = dataAccess.GetDataTable(query);

            TeTenKH.Text = Convert.ToString(customerData.Rows[0]["TenKH"]);
            //TeDiaChi.Text = Convert.ToString(customerData.Rows[0]["DiaChi"]);
            //DeNgaySinh.Text = Convert.ToString(customerData.Rows[0]["NgaySinh"]);
            //CbeGioiTinh.Text = Convert.ToString(customerData.Rows[0]["GioiTinh"]);

            maKH = Convert.ToInt32(customerData.Rows[0]["MaKH"]);

        }

        private void XuLyKhachHang()
        {
            string SDT = CbeSDT.Text;
            bool thanhvien = KiemTraKhachHangThanhVien();
            if(thanhvien == true)
            {
                LayThongTinKhachHangThanhVien(SDT);
            }       
        }

        private void BtnTaoHoaDon_Click(object sender, EventArgs e)
        {
            CapNhatSanPham();
            //CapNhatKhachHang();
            LuuHoaDon();
            LuuCTHoaDon();
        }

        /*private void CapNhatKhachHang()
        {
            string tenKH = TeTenKH.Text;
            string sdt = CbeSDT.Text;
            string query = $"INSERT INTO KHACH_HANG (TenKH, SDT) VALUES ('{tenKH}', '{sdt}')";

            dataAccess.UpdateData(query);
        }*/

        private void LuuHoaDon()
        {
            string maNV = "";
            int tongtien = Convert.ToInt32(LbTongTien.Text);
            DateTime thoigian = Convert.ToDateTime(LbThoiGian.Text);
            dataAccess.UpdateData($"INSERT INTO HOA_DON_BAN (MaHDB, MaKH, MaNV, TongTien, ThoiGian) VALUES ('{maHDB}', {maKH}, '{maNV}', {tongtien}, {thoigian})");
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

        private void GvSP_HDB_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            LbTongTien.Text = TinhTongTien().ToString();
        }

        private void GvSP_HDB_RowCountChanged(object sender, EventArgs e)
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

        private void BtnThemThanhVien_Click(object sender, EventArgs e)
        {

        }

        private void TeSoLuong_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(TeSoLuong.Text, out _))
            {
                MessageBox.Show("Vui lòng chỉ nhập số.");
                e.Cancel = true; // Ngăn chặn mất focus nếu giá trị không hợp lệ
            }

        }
    }
}
