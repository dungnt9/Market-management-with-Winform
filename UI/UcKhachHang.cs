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
    public partial class UcKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        DataAccess dataAccess = new DataAccess();

        public UcKhachHang()
        {
            InitializeComponent();
            LoadData();

            CbeGioiTinh.Properties.Items.Add("Nam");
            CbeGioiTinh.Properties.Items.Add("Nữ");
            CbeGioiTinh.Properties.Items.Add("Khác");
        }

        void LoadData()
        {
            GcDanhMucKH.DataSource = dataAccess.GetDataTable("select MaKH as 'Mã Khách Hàng', " +
                                                                    "TenKH as 'Tên Khách Hàng',   " +
                                                                    "NgaySinh as 'Ngày Sinh'," +
                                                                    "GioiTinh as 'Giới Tính', " +
                                                                    "SDT as 'Số Điện Thoại'," +
                                                                    "DiaChi as 'Địa Chỉ', " +
                                                                    "MaGiamGia as 'Mã Giảm Giá'" +
                                                                    "from KHACH_HANG");
        }

        private void BbiThemMoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            string s = string.Format("INSERT INTO KHACH_HANG (MaKH,TenKH,GioiTinh,SDT,DiaChi,MaGiamGia, NgaySinh) VALUES" + "('{0}',N'{1}',N'{2}','{3}',N'{4}','{5}','{6}')", TeMaKH.Text, TeTenKH.Text, CbeGioiTinh.Text, TeSDT.Text, TeDiaChi.Text, CbeMaGiamGia.Text, DeNgaySinh.Text);
            MessageBox.Show("Thêm thành công");
            GcDanhMucKH.DataSource = dataAccess.GetDataTable(s);
            LoadData();
        }
    }
}
