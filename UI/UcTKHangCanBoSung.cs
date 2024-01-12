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

namespace market_management.UI
{
    public partial class UcTKHangCanBoSung : DevExpress.XtraEditors.XtraUserControl
    {
        DataAccess dataAccess = new DataAccess();
        int muctoithieu;
        public UcTKHangCanBoSung()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            string queryHangBoSung = $"SELECT SP.MaSP AS 'Mã Sản Phẩm', SP.TenSP AS 'Tên Sản Phẩm', LSP.TenLoaiSp AS 'Loại Sản Phẩm', SP.SoLuong AS 'Số Lượng', SP.HanSuDung AS 'Hạn Sử Dụng', SP.TrangThai AS 'Trạng Thái'  FROM SAN_PHAM SP JOIN LOAI_SAN_PHAM LSP ON SP.MaLoaiSP = LSP.MaLoaiSP WHERE SP.SoLuong < {muctoithieu};";
            DataTable dataTableHangBoSung = dataAccess.GetDataTable(queryHangBoSung);

            GcHangBoSung.DataSource = dataTableHangBoSung;
        }

        private void TeMucKhoToiThieu_TextChanged(object sender, EventArgs e)
        {
            if(TeMucKhoToiThieu.Text == "")
            {
                return;
            }    
            muctoithieu = Convert.ToInt32(TeMucKhoToiThieu.Text);
            LoadData();
        }

        private void TeMucKhoToiThieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }  
}
