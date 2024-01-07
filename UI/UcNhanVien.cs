using DevExpress.DataAccess.Native.EntityFramework;
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

namespace Quản_lý_siêu_thị
{
    public partial class UcNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        public UcNhanVien()
        {
            InitializeComponent();

            CbeGioiTinh.Properties.Items.Add("Nam");
            CbeGioiTinh.Properties.Items.Add("Nữ");
            CbeGioiTinh.Properties.Items.Add("Khác");

            //CbeChucVu.DataBindings.Add(new Binding("Value", dataAccess,"NHAN_VIEN.ChucVu"));
            CbeChucVu.Properties.Items.Add("Quản lý");
            CbeChucVu.Properties.Items.Add("Nhân Viên");
        }
        public class Customer
        {

        void LoadData()
        {
            GcDanhMucNV.DataSource = dataAccess.GetDataTable("select MaNV as 'Mã Nhân VIên', " +
                                                                    "TenNV as 'Tên Nhân Viên',   " +
                                                                    "NgaySinh as 'Ngày Sinh'," +
                                                                    "GioiTinh as 'Giới Tính', " +
                                                                    "CanCuoc as 'Căn cước'," +
                                                                    "SDT as 'Số Điện Thoại'," +
                                                                    "Email as Email," +
                                                                    "DiaChi as 'Địa Chỉ', " +
                                                                    "ChucVu as 'Chức Vụ'" +
                                                                    "from NHAN_VIEN");
        }

        private void UcNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void BbiThemMoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            string s = string.Format("INSERT INTO NHAN_VIEN (MaNV,TenNV,GioiTinh, SDT, DiaChi, CanCuoc, NgaySinh, Email ,ChucVu) VALUES" + "('{0}',N'{1}',N'{2}','{3}',N'{4}','{5}','{6}', '{7}', N'{8}')", TeMaNV.Text, TeTenNV.Text, CbeGioiTinh.Text, TeSDT.Text, TeDiaChi.Text, TeCCCD.Text, DeNgaySinh.Text, TeEmail.Text, CbeChucVu.Text);
            MessageBox.Show("Thêm thành công");
            GcDanhMucNV.DataSource = dataAccess.GetDataTable(s);
            LoadData();
        }
    }
}
