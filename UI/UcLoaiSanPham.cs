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
    public partial class UcLoaiSanPham : DevExpress.XtraEditors.XtraUserControl
    {
        DataAccess dataAccess = new DataAccess();
        public UcLoaiSanPham()
        {
            InitializeComponent();
            /*
            BindingList<Customer> dataSource = GetDataSource();
            GcSLoaiSP.DataSource = dataSource;
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
        private void UcLoaiSanPham_Load(object sender, EventArgs e)
        {

        }
        
        void LoadData()
        {
            GcLoaiSP.DataSource = dataAccess.GetDataTable("SELECT \r\n\tMaLoaiSP as 'Mã loại sản phẩm', \r\n\tTenLoaiSP as 'Tên loại sản phẩm'\r\nfrom LOAI_SAN_PHAM");
        }

        /*
        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                DataGridViewRow _dr = dgvKhachHang.SelectedRows[0];

                string _MaKhachHang = _dr.Cells["MaKhachHang"].Value.ToString();
                string _TenKhachHang = _dr.Cells["TenKhachHang"].Value.ToString();

                txtMaKhachHang.Text = _MaKhachHang;
                txtTenKhachHang.Text = _TenKhachHang;
            }
        }
        */






        /*
        private void dgvKhachHang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow _dr = dgvKhachHang.SelectedRows[0];

            string _MaKhachHang = _dr.Cells["MaKhachHang"].Value.ToString();
            string _TenKhachHang = _dr.Cells["TenKhachHang"].Value.ToString();

            txtMaKhachHang.Text = _MaKhachHang;
            txtTenKhachHang.Text = _TenKhachHang;
        }

        private void btnXem_Click_1(object sender, EventArgs e)
        {
            string s = string.Format("select * from KHACH_HANG where " +
                "MaKhachHang like '%{0}%' and TenKhachHang like '%{1}%'", txtMaKhachHang.Text, txtTenKhachHang.Text);
            dgvKhachHang.DataSource = dataAccess.GetDataTable(s);
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string s = string.Format("INSERT INTO KHACH_HANG VALUES" + "('{0}',N'{1}','{2}',N'{3}','{4}','{5}')",
                txtMaKhachHang.Text, txtTenKhachHang.Text, dtNgaySinh.Text, cmbGioiTinh.Text, txtSDT.Text, txtEmail.Text);

            dataAccess.UpdateData(s);
            LoadData();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            string s = string.Format("UPDATE KHACH_HANG SET" + "TenKhachHang = N'{0}' WHERE MaKhachHang = '{1}'",
                txtTenKhachHang.Text, txtMaKhachHang.Text);

            dataAccess.UpdateData(s);
            LoadData();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DialogResult _result = MessageBox.Show("Xác nhận xóa?", "Cảnh báo!",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (_result == DialogResult.Yes)
            {
                DataGridViewRow _dr = dgvKhachHang.SelectedRows[0];
                string _MaKhachHang = _dr.Cells["MaKhachHang"].Value.ToString();
                MessageBox.Show(_MaKhachHang);

                dataAccess.UpdateData(string.Format("delete from KHACH_HANG where MaKhachHang ='{0}'", _MaKhachHang));
                LoadData();
            }
        }
        */

















    }
}
