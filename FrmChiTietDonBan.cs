using DevExpress.CodeParser;
using DevExpress.DataAccess.Sql;
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
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using static DevExpress.Utils.Drawing.Helpers.NativeMethods;
using System.IO;

namespace market_management
{
    public partial class FrmChiTietDonBan : DevExpress.XtraEditors.XtraForm
    {
        DataAccess dataAccess = new DataAccess();
        public FrmChiTietDonBan(string MaHDB, string tongTien, string thoigian)
        {
            InitializeComponent();
            HienThiThongTinHoaDon(MaHDB, tongTien, thoigian);
            HienThiSanPham(MaHDB);
        }

        private void HienThiThongTinHoaDon(string MaHDB, string tongTien, string thoigian)
        {
            HienThiThongTinKH(MaHDB);

            LbTongTien.Text = tongTien;
            LbThoiGian.Text = thoigian;
            LbTenNV.Text = Session.tenNV;

            HienThiSanPham(MaHDB);
        }

        private void HienThiThongTinKH(string maHDB)
        {
            string query = $"select TenKH, SDT, GioiTinh, DiaChi, NgaySinh from KHACH_HANG join HOA_DON_BAN on KHACH_HANG.MaKH = HOA_DON_BAN.MaKH where MaHDB = '{maHDB}'";
            DataTable thongtinKH = dataAccess.GetDataTable(query);

            if(thongtinKH.Rows.Count == 0)
            {
                return;
            }    

            LbTenKH.Text = thongtinKH.Rows[0]["TenKH"].ToString();
            LbSDT.Text = thongtinKH.Rows[0]["SDT"].ToString();
            LbDiaChi.Text = thongtinKH.Rows[0]["DiaChi"].ToString();
        }    

        private void HienThiSanPham(string MaHDB)
        {
            GcSP_HDB.DataSource = dataAccess.GetDataTable($"SELECT SP.MaSP AS 'Mã sản phẩm', SP.TenSP AS 'Tên sản phẩm', SP.GiaBanLe AS 'Giá Bán Lẻ', CTHDB.SoLuong AS 'Số Lượng' FROM SAN_PHAM AS SP JOIN CT_HOA_DON_BAN AS CTHDB ON SP.MaSP = CTHDB.MaSP JOIN HOA_DON_BAN HDB ON HDB.MaHDB = CTHDB.MaHDB WHERE HDB.MaHDB = '{MaHDB}'; ");
        }

        private void BtnInHoaDon_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            saveFileDialog.DefaultExt = "pdf";
            saveFileDialog.AddExtension = true;
            saveFileDialog.Title = "Chọn nơi lưu file PDF";

            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string duong_dan = saveFileDialog.FileName;

                InHoaDonPDF(duong_dan);
            }
        }

        private void InHoaDonPDF(string duong_dan)
        {
            using (FileStream fs = new FileStream(duong_dan, FileMode.Create))
            {
                using (PdfWriter writer = new PdfWriter(fs))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        using (Document document = new Document(pdf))
                        {

                            document.Add(new Paragraph("HOA DON BAN HANG").SetBold().SetFontSize(14));

                            document.Add(new Paragraph($"Ho va ten khach hang: {LbTenKH.Text}"));
                            document.Add(new Paragraph($"So dien thoai: {LbSDT.Text}"));
                            document.Add(new Paragraph($"Dia chi: {LbDiaChi.Text}"));
                            document.Add(new Paragraph($"Tong tien: {LbTongTien.Text} VND"));
                            document.Add(new Paragraph($"Thoi gian: {LbThoiGian.Text}"));

                            document.Add(new Paragraph($"Nhan vien: {LbTenNV.Text}"));
                        }
                    }
                }
            }

            MessageBox.Show($"Hóa Đơn Bán đã được lưu tại {duong_dan}", "Hóa Đơn Bán Đã Tạo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmChiTietDonBan_Load(object sender, EventArgs e)
        {

        }
    }
}