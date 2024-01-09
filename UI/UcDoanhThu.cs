using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market_management
{
    public partial class UcDoanhThu : DevExpress.XtraEditors.XtraUserControl
    {
        DataAccess dataAccess = new DataAccess();
        public UcDoanhThu()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            GcDoanhThu.DataSource = dataAccess.GetDataTable("select MaKH as 'Mã Khách Hàng', " +
                                                                    "TenKH as 'Tên Khách Hàng',   " +
                                                                    "NgaySinh as 'Ngày Sinh'," +
                                                                    "GioiTinh as 'Giới Tính', " +
                                                                    "SDT as 'Số Điện Thoại'," +
                                                                    "DiaChi as 'Địa Chỉ', " +
                                                                    "MaGiamGia as 'Mã Giảm Giá'" +
                                                                    "from KHACH_HANG");
        }
    }
}
