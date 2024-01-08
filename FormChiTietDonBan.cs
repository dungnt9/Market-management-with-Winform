using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Import.OpenXml;
using market_management.UI;
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
    public partial class FormChiTietDonBan : DevExpress.XtraEditors.XtraForm
    {
        DataAccess dataAccess = new DataAccess();
        public FormChiTietDonBan(string MaHDB)
        {
            InitializeComponent();
            HienThiThongTinHoaDon(MaHDB);
            HienThiSanPham(MaHDB);
        }

        private void HienThiThongTinHoaDon(string MaHDB)
        {
            string customerNameToCheck = MaHDB;

            // Tạo câu truy vấn SQL để lấy thông tin của khách hàng
            string query = "SELECT * FROM KHACH_HANG WHERE TenKH = @CustomerName"; // Thay TenBang và TenKhachHang bằng tên bảng và tên cột trong cơ sở dữ liệu của bạn

            // Tạo tham số
            SqlParameter parameter = new SqlParameter("@CustomerName", SqlDbType.NVarChar);
            parameter.Value = customerNameToCheck;

            // Lấy dữ liệu từ cơ sở dữ liệu
            DataTable customerData = dataAccess.GetDataTable(query);

            LbTenKH.Text = Convert.ToString(customerData.Rows[0]["MaKhachHang"]);
            LbSDT.Text = Convert.ToString(customerData.Rows[0]["SoDienThoai"]);
            LbDiaChi.Text = Convert.ToString(customerData.Rows[0]["DiaChi"]);
            

        }

        private void HienThiSanPham(string MaHDB)
        {
            GcSP_HDB.DataSource = dataAccess.GetDataTable("SELECT \r\n" +
                "    HDB.MaHDB AS 'Mã hóa đơn bán',\r\n" +
                "    KH.TenKH AS 'Tên Khách Hàng',\r\n" +
                "    KH.SDT AS 'Số điện thoại Khách Hàng',\r\n" +
                "    HDB.TongTien AS 'Tổng tiền',\r\n" +
                "    HDB.ThoiGian AS 'Thời gian',\r\n" +
                "    NV.TenNV AS 'Tên nhân viên'\r\n" +
                "FROM \r\n" +
                "    HOA_DON_BAN HDB\r\n" +
                "    JOIN KHACH_HANG KH ON HDB.MaKH = KH.MaKH\r\n" +
                "    JOIN NHAN_VIEN NV ON HDB.MaNV = NV.MaNV;");
        }
    }
}