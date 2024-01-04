using DevExpress.XtraBars;
using DevExpress.XtraEditors;
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

namespace market_management.UI
{
    public partial class UcQLNhapHang : DevExpress.XtraEditors.XtraUserControl
    {
        DataAccess dataAccess = new DataAccess();

        public UcQLNhapHang()
        {
            InitializeComponent();
            /*
            BindingList<Customer> dataSource = GetDataSource();
            GcQLNhapHang.DataSource = dataSource;
            bsiRecordsCount.Caption = "RECORDS : " + dataSource.Count;
            */
            LoadData();
        }
        /*
        public BindingList<Customer> GetDataSource()
        {
            BindingList<Customer> result = new BindingList<Customer>();
            result.Add(new Customer()
            {
                ID = 1,
                Name = "ACME",
                Address = "2525 E El Segundo Blvd",
                City = "El Segundo",
                State = "CA",
                ZipCode = "90245",
                Phone = "(310) 536-0611"
            });
            result.Add(new Customer()
            {
                ID = 2,
                Name = "Electronics Depot",
                Address = "2455 Paces Ferry Road NW",
                City = "Atlanta",
                State = "GA",
                ZipCode = "30339",
                Phone = "(800) 595-3232"
            });
            return result;
        }
        public class Customer
        {
            [Key, Display(AutoGenerateField = false)]
            public int ID { get; set; }
            [Required]
            public string Name { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            [Display(Name = "Zip Code")]
            public string ZipCode { get; set; }
            public string Phone { get; set; }
        }
        */
        private void BbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmDonNhap frmDonNhap = new FrmDonNhap();
            frmDonNhap.ShowDialog();
        }
        void LoadData()
        {
            GcQLNhapHang.DataSource = dataAccess.GetDataTable("SELECT \r\n    HDN.MaHDN AS 'Mã đơn nhập',\r\n    HDN.TongTien AS 'Tổng tiền',\r\n    HDN.ThoiGian AS 'Thời gian',\r\n    HDN.MaNCC AS 'Mã nhà cung cấp',\r\n    NCC.TenNCC AS 'Tên nhà cung cấp',\r\n    NCC.SDT AS 'Số điện thoại NCC',\r\n    HDN.MaNV AS 'Mã nhân viên',\r\n    NV.TenNV AS 'Tên nhân viên'\r\nFROM \r\n    HOA_DON_NHAP HDN\r\n    JOIN NHA_CUNG_CAP NCC ON HDN.MaNCC = NCC.MaNCC\r\n    JOIN NHAN_VIEN NV ON HDN.MaNV = NV.MaNV;");
        }



    }
}
