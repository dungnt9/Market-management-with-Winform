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
    public partial class FrmXemCT_HDNhap : DevExpress.XtraEditors.XtraForm
    {
        DataAccess dataAccess = new DataAccess();
        public FrmXemCT_HDNhap(string MaHDN, string tongTien, string thoigian)
        {
            InitializeComponent();
            HienThiThongTinHoaDon(MaHDN, tongTien, thoigian);
            HienThiSanPham(MaHDN);
        }

        private void HienThiThongTinHoaDon(string MaHDN, string tongTien, string thoigian)
        {
            HienThiThongTinNCC(MaHDN);

            LbTongTien.Text = tongTien;
            LbThoiGian.Text = thoigian;
            LbTenNV.Text = Session.tenNV;

            HienThiSanPham(MaHDN);
        }

        private void HienThiThongTinNCC(string maHDN)
        {
            string query = $"select TenNCC, SDT, DiaChi from NHA_CUNG_CAP join HOA_DON_NHAP " +
                $"on NHA_CUNG_CAP.MaNCC = HOA_DON_NHAP.MaNCC where MaHDN = '{maHDN}'";
            DataTable thongtinNCC = dataAccess.GetDataTable(query);

            if (thongtinNCC.Rows.Count == 0)
            {
                return;
            }

            LbTenNCC.Text = thongtinNCC.Rows[0]["TenNCC"].ToString();
            LbSDT.Text = thongtinNCC.Rows[0]["SDT"].ToString();
            LbDiaChi.Text = thongtinNCC.Rows[0]["DiaChi"].ToString();
        }

        private void HienThiSanPham(string MaHDN)
        {
            GcChiTiet.DataSource = dataAccess.GetDataTable($"SELECT SP.MaSP AS 'Mã sản phẩm', " +
                $"SP.TenSP AS 'Tên sản phẩm', SP.GiaNhap AS 'Giá Nhập', CTHDN.SoLuong AS 'Số Lượng' " +
                $"FROM SAN_PHAM AS SP JOIN CT_HOA_DON_NHAP AS CTHDN ON SP.MaSP = CTHDN.MaSP " +
                $"JOIN HOA_DON_NHAP HDN ON HDN.MaHDN = CTHDN.MaHDN WHERE HDN.MaHDN = '{MaHDN}'; ");
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
                            document.Add(new Paragraph("HOA DON NHAP HANG").SetBold().SetFontSize(14));

                            document.Add(new Paragraph($"Ho va ten nha cung cap: {LbTenNCC.Text}"));
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
    }
}