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
    public partial class UcTKTongTienNhap : DevExpress.XtraEditors.XtraUserControl
    {
        DataAccess dataAccess = new DataAccess();

        public UcTKTongTienNhap()
        {
            InitializeComponent();
        
            CbeNam.Properties.Items.Add("2018");
            CbeNam.Properties.Items.Add("2019");
            CbeNam.Properties.Items.Add("2020");
            CbeNam.Properties.Items.Add("2021");
            CbeNam.Properties.Items.Add("2022");
            CbeNam.Properties.Items.Add("2023");
            CbeNam.Properties.Items.Add("2024");

            LoadData();
        }

        void LoadData()
        {
            string nam = CbeNam.Text;
            if (CbeNam.Properties.Items.Contains(nam))
            {
                string s = string.Format("SELECT MONTH(ThoiGian) AS 'Tháng', YEAR(ThoiGian) AS 'Năm'," +
                                        "SUM(TongTien) AS 'Tổng tiền nhập'\r\nFROM HOA_DON_NHAP \r\n WHERE YEAR(ThoiGian) = {0}\r\nGROUP BY ThoiGian;",nam);
                string s1 = string.Format("SELECT MONTH(ThoiGian) AS 'Tháng', SUM(TongTien) AS 'Tổng tiền nhập'" +
                                            "\r\nFROM HOA_DON_NHAP \r\n WHERE YEAR(ThoiGian) = {0}\r\nGROUP BY ThoiGian;", nam);
                CcBanHang.DataSource = dataAccess.GetDataTable(s1);
                GcNhapHang.DataSource = dataAccess.GetDataTable(s);
            }
            else
            {
                XtraMessageBox.Show("Không tồn tại năm vừa nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.FieldName == "Tháng")
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            if (e.Column.FieldName == "Năm")
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            if (e.Column.FieldName == "Tổng tiền nhập")
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
        }

        private void CbeNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if(e.KeyChar == (char)Keys.Enter)
            {
                LoadData();
            }
        }
    }
}
