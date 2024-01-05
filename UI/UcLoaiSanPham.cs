using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
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
using DevExpress.XtraExport.Helpers;

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

        private bool IsMaLoaiSPExists(string maLoaiSP)
        {
            // Thực hiện truy vấn để lấy danh sách các MaLoaiSP từ bảng LOAI_SAN_PHAM
            DataTable dataTable = dataAccess.GetDataTable($"SELECT MaLoaiSP FROM LOAI_SAN_PHAM WHERE MaLoaiSP = '{maLoaiSP}'");

            // Kiểm tra sự tồn tại của maLoaiSP trong danh sách
            return dataTable.Rows.Count > 0;
        }
        private void BbiThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var maLoaiSP = CbeMaLoaiSP.Text;
            var tenLoaiSP = CbeTenLoaiSP.Text;

            if (string.IsNullOrEmpty(maLoaiSP))
            {
                XtraMessageBox.Show("Bạn phải nhập mã loại sản phẩm", "Thông báo");
                CbeMaLoaiSP.Focus();
                return;
            }

            var isExist = IsMaLoaiSPExists(maLoaiSP);

            if (isExist)
            {
                XtraMessageBox.Show($"Mã loại sản phẩm {maLoaiSP} đã tồn tại!", "Thông báo");
                CbeMaLoaiSP.Focus();
                CbeMaLoaiSP.SelectAll();
                return;
            }

            if (string.IsNullOrEmpty(tenLoaiSP))
            {
                XtraMessageBox.Show("Nhập tên loại sản phẩm", "Thông báo");
                return;
            }

            // Thực hiện thêm loại sản phẩm vào cơ sở dữ liệu
            var sqlInsert = $"INSERT INTO LOAI_SAN_PHAM (MaLoaiSP, TenLoaiSP) VALUES ('{maLoaiSP}', N'{tenLoaiSP}')";

            DataAccess dataAccess = new DataAccess();
            try
            {
                dataAccess.UpdateData(sqlInsert);

                XtraMessageBox.Show("Thêm loại sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sau khi thêm thành công, bạn có thể làm sạch các trường nhập liệu hoặc load lại dữ liệu
                CbeMaLoaiSP.Text = "";
                CbeTenLoaiSP.Text = "";
                LoadData(); // Gọi lại phương thức để cập nhật GridView
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Lỗi thêm loại sản phẩm: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
            var maLoaiSP = gridView1.GetRowCellValue(e.FocusedRowHandle, "Mã loại sản phẩm").ToString();
            var tenLoaiSP = gridView1.GetRowCellValue(e.FocusedRowHandle, "Tên loại sản phẩm").ToString();
            CbeMaLoaiSP.Text = maLoaiSP;
            CbeTenLoaiSP.Text = tenLoaiSP;
            
        }
        
        

        
        private void BbiSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            var maLoaiSP = CbeMaLoaiSP.Text;
            var tenLoaiSP = CbeTenLoaiSP.Text;

            if (string.IsNullOrEmpty(maLoaiSP) || string.IsNullOrEmpty(tenLoaiSP))
            {
                XtraMessageBox.Show("Vui lòng chọn loại sản phẩm cần cập nhật và nhập thông tin mới", "Thông báo");
                return;
            }

            var sqlUpdate = $"UPDATE LOAI_SAN_PHAM SET TenLoaiSP = N'{tenLoaiSP}' WHERE MaLoaiSP = '{maLoaiSP}'";

            DataAccess dataAccess = new DataAccess();
            try
            {
                dataAccess.UpdateData(sqlUpdate);
                XtraMessageBox.Show("Cập nhật loại sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Gọi lại phương thức để cập nhật GridView
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Lỗi cập nhật loại sản phẩm: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BbiXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            var maLoaiSP = CbeMaLoaiSP.Text;

            if (string.IsNullOrEmpty(maLoaiSP))
            {
                XtraMessageBox.Show("Vui lòng chọn loại sản phẩm cần xóa", "Thông báo");
                return;
            }

            var confirmationResult = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa loại sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                var sqlDelete = $"DELETE FROM LOAI_SAN_PHAM WHERE MaLoaiSP = '{maLoaiSP}'";

                DataAccess dataAccess = new DataAccess();
                try
                {
                    dataAccess.UpdateData(sqlDelete);
                    XtraMessageBox.Show("Xóa loại sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Gọi lại phương thức để cập nhật GridView
                    
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"Lỗi xóa loại sản phẩm: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BbiLamMoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
            CbeMaLoaiSP.Text = "";
            CbeTenLoaiSP.Text = "";
        }

















        private void bsiRecordsCount_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        private void UcLoaiSanPham_Load(object sender, EventArgs e)
        {

        }

        
    }
}
