using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market_management
{
    public partial class UcTKDoanhThuBanHang : DevExpress.XtraEditors.XtraUserControl
    {
        DataAccess dataAccess = new DataAccess();
        public UcTKDoanhThuBanHang()
        {
            InitializeComponent();

            CbeNam.Properties.Items.Add("2018");
            CbeNam.Properties.Items.Add("2019");
            CbeNam.Properties.Items.Add("2020");
            CbeNam.Properties.Items.Add("2021");
            CbeNam.Properties.Items.Add("2022");
            CbeNam.Properties.Items.Add("2023");
            CbeNam.Properties.Items.Add("2024");

            CcBanHang.DataSource = dataAccess.GetDataTable("SELECT MONTH(ThoiGian) AS 'Tháng', SUM(TongTien) AS 'Tổng tiền bán'\r\nFROM HOA_DON_BAN \r\nGROUP BY ThoiGian;");
            LoadData();
        }

        void LoadData()
        {
            string Nam = CbeNam.Text;
            if(CbeNam.Properties.Items.Contains(Nam))
            {
                GcBanHang.DataSource = dataAccess.GetDataTable("SELECT MONTH(ThoiGian) AS 'Tháng', YEAR(ThoiGian) AS 'Năm'," +
                                                           "SUM(TongTien) AS 'Tổng tiền bán'\r\nFROM HOA_DON_BAN \r\nGROUP BY ThoiGian;");
            }
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.FieldName == "Tháng")
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            if (e.Column.FieldName == "Năm" )
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            if (e.Column.FieldName == "Tổng tiền bán")
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
        }

        private void CbeNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void CbeNam_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
