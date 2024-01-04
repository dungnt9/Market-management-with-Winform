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
    public partial class UcSanPham : DevExpress.XtraEditors.XtraUserControl
    {
        DataAccess dataAccess = new DataAccess();
        public UcSanPham()
        {
            InitializeComponent();
            /*
            BindingList<Customer> dataSource = GetDataSource();
            GcSanPham.DataSource = dataSource;
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
        void LoadData()
        {
            GcSP.DataSource = dataAccess.GetDataTable("SELECT \r\n    SP.MaSP AS 'Mã sản phẩm',\r\n    SP.TenSP AS 'Tên sản phẩm',\r\n    LSP.TenLoaiSP AS 'Phân loại',\r\n    SP.SoLuong AS 'Số lượng',\r\n    SP.GiaNhap AS 'Giá nhập',\r\n    SP.GiaBanLe AS 'Giá bán lẻ'\r\nFROM \r\n    SAN_PHAM SP\r\nJOIN \r\n    LOAI_SAN_PHAM LSP ON SP.MaLoaiSP = LSP.MaLoaiSP;");
        }
    }
}
