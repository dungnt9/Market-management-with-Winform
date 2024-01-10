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
            string queryHangBoSung = $"SELECT * FROM SAN_PHAM WHERE SoLuong < {muctoithieu}"; // Thay TenBang và SoLuong bằng tên thực tế của bảng và cột trong cơ sở dữ liệu của bạn
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
