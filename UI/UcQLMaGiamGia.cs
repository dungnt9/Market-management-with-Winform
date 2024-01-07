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
    public partial class UcQLMaGiamGia : DevExpress.XtraEditors.XtraUserControl
    {
        DataAccess dataAccess = new DataAccess();
        public UcQLMaGiamGia()
        {
            InitializeComponent();
            LoadData();
            
        }
        void LoadData()
        {
            GcMaGiamGia.DataSource = dataAccess.GetDataTable("select MaGiamGia as 'Mã Giảm Giá', " +
                                                                    "TenChuongTrinh as 'Tên Chuong Trinh'," +
                                                                    "PhanTram as 'Phần Trăm'," +
                                                                    "NgayTao as 'Ngày Tạo', " +
                                                                    "TrangThai as 'Trạng Thái'," +
                                                                    "MoTa as 'Mô Tả'" +
                                                                    "from MA_GIAM_GIA");
        }

        private void BbiThemMoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            string s = string.Format("INSERT INTO MA_GIAM_GIA (MaGiamGia,TenChuongTrinh,NgayTao, TrangThai, MoTa, PhanTram) VALUES" + "('{0}',N'{1}','{2}','{3}',N'{4}','{5}')", TeMaGiamGia.Text, TeTenChuongTrinh.Text, DeNgayTao.Text, CbeTrangThai.Text, TeMoTa.Text, CbePhanTram.Text);
            MessageBox.Show("Thêm thành công");
            GcMaGiamGia.DataSource = dataAccess.GetDataTable(s);
            LoadData();
        }
    }
}
