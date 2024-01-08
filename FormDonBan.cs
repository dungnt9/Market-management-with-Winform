using DevExpress.Xpo.DB.Helpers;
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
        DataTable sanphamDataTable;

        public FormDonBan()
        {
            InitializeComponent();
            sanphamDataTable = new DataTable();
        }

        private bool KiemTraKhachHangCu()
        {
            string customerNameToCheck = TeTenKH.Text;

            // Tạo câu truy vấn SQL để kiểm tra sự tồn tại của tên khách hàng
            string query = "SELECT COUNT(*) FROM TenBang WHERE TenKhachHang = @CustomerName"; // Thay TenBang và TenKhachHang bằng tên bảng và tên cột trong cơ sở dữ liệu của bạn

            // Tạo tham số
            SqlParameter parameter = new SqlParameter("@CustomerName", SqlDbType.NVarChar);
            parameter.Value = customerNameToCheck;

            // Kiểm tra sự tồn tại của tên khách hàng
            int count = Convert.ToInt32(dataAccess.GetScalar(query, parameter));

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

        private void LayThongTinKhachHangCu(string TenKH)
        {
            string customerNameToCheck = TenKH;

            // Tạo câu truy vấn SQL để lấy thông tin của khách hàng
            string query = "SELECT * FROM KHACH_HANG WHERE TenKH = @CustomerName"; // Thay TenBang và TenKhachHang bằng tên bảng và tên cột trong cơ sở dữ liệu của bạn

            // Tạo tham số
            SqlParameter parameter = new SqlParameter("@CustomerName", SqlDbType.NVarChar);
            parameter.Value = customerNameToCheck;

            // Lấy dữ liệu từ cơ sở dữ liệu
            DataTable customerData = dataAccess.GetDataTable(query);

            TeTenKH.Text = Convert.ToString(customerData.Rows[0]["MaKhachHang"]);
            TeSDT.Text = Convert.ToString(customerData.Rows[0]["SoDienThoai"]);
            TeDiaChi.Text = Convert.ToString(customerData.Rows[0]["DiaChi"]);
            DeNgaySinh.DateTime = Convert.ToDateTime(customerData.Rows[0]["NgaySinh"]);
            CbeGioiTinh.Text = Convert.ToString(customerData.Rows[0]["GioiTinh"]);

        }

        private void XuLyKhachHang()
        {
            string tenKH = TeTenKH.Text;
            bool is_KHcu = KiemTraKhachHangCu();
            if(is_KHcu == true)
            {
                LayThongTinKhachHangCu(tenKH);
            }    
            else
            {
                return;
            }    
            
        }

        private void BtnTaoHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            string tenSP = CbeTenSP.Text;

            // Tạo câu truy vấn SQL để lấy thông tin của khách hàng
            string query = "SELECT * FROM KHACH_HANG WHERE TenKH = @TenSP"; // Thay TenBang và TenKhachHang bằng tên bảng và tên cột trong cơ sở dữ liệu của bạn

            // Tạo tham số
            SqlParameter parameter = new SqlParameter("@TenSP", SqlDbType.NVarChar);
            parameter.Value = tenSP;

            // Lấy dữ liệu từ cơ sở dữ liệu
            DataTable sanpham = dataAccess.GetDataTable(query);

            if (sanpham.Rows.Count > 0)
            {
                // Thêm dòng vào DataTable
                DataRow newRow = sanpham.NewRow();
                newRow["MaSP"] = sanpham.Rows[0]["MaSP"];
                newRow["Tên Sản Phẩm"] = sanpham.Rows[0]["TenSP"];
                newRow["DiaChi"] = sanpham.Rows[0]["DiaChi"];
                newRow["SoDienThoai"] = sanpham.Rows[0]["SoDienThoai"];
                newRow["NgaySinh"] = sanpham.Rows[0]["NgaySinh"];
                newRow["TrangThai"] = sanpham.Rows[0]["TrangThai"];
                newRow["Số Lượng"] = TeSoLuong.Text;

                sanphamDataTable.Rows.Add(newRow);
            }
        }

        private double TinhTongTien()
        {
            double totalIncome = 0;

            // Duyệt qua tất cả các dòng trong DataTable và tính tổng thu nhập
            foreach (DataRow row in sanphamDataTable.Rows)
            {
                if (row["GiaBan"] != DBNull.Value)
                {
                    totalIncome += Convert.ToDouble(row["GiaBan"]) * Convert.ToDouble(row["SoLuong"]);
                }
            }

            return totalIncome;
        }

        private void CapNhatSanPham()
        {
            dataAccess.UpdateData(string.Format("update TAI_KHOAN set TenDangNhap = N'{1}', MatKhau = N'{2}' where MaNV = '{0}'"));
        }
    }
}
