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

            CbePhanTram.Properties.Items.Add("5");
            CbePhanTram.Properties.Items.Add("10");
            CbePhanTram.Properties.Items.Add("15");
            CbePhanTram.Properties.Items.Add("20");
            CbePhanTram.Properties.Items.Add("25");
            CbePhanTram.Properties.Items.Add("30");
            CbePhanTram.Properties.Items.Add("40");
            CbePhanTram.Properties.Items.Add("50");

        }
        //Lất data từ CSDL
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
            int TrangThai = 1;
            if (RbConHieuLuc.Checked)
            {
                TrangThai = 1;
            }
            if (RbHetHan.Checked)
            {
                TrangThai = 0;
            }
            if(TeTenChuongTrinh.Text != "")
            {
                string s = string.Format("INSERT INTO MA_GIAM_GIA (TenChuongTrinh,NgayTao, TrangThai, MoTa, PhanTram) VALUES" + "(N'{0}','{1}','{2}',N'{3}','{4}')", TeTenChuongTrinh.Text, DeNgayTao.Text, TrangThai, TeMoTa.Text, CbePhanTram.Text);
                MessageBox.Show("Thêm thành công");
                GcMaGiamGia.DataSource = dataAccess.GetDataTable(s);
                LoadData();
            }
        }

        private void BbiSua_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void BbiLamMoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
        }
    }
}
