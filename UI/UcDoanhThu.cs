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
    public partial class UcDoanhThu : DevExpress.XtraEditors.XtraUserControl
    {
        DataAccess dataAccess = new DataAccess();
        public UcDoanhThu()
        {
            InitializeComponent();
            LoadData();

            CbeNam.Properties.Items.Add("2018");
            CbeNam.Properties.Items.Add("2019");
            CbeNam.Properties.Items.Add("2020");
            CbeNam.Properties.Items.Add("2021");
            CbeNam.Properties.Items.Add("2022");
            CbeNam.Properties.Items.Add("2023");

            CbeThang.Properties.Items.Add("1");
            CbeThang.Properties.Items.Add("2");
            CbeThang.Properties.Items.Add("3");
            CbeThang.Properties.Items.Add("4");
            CbeThang.Properties.Items.Add("5");
            CbeThang.Properties.Items.Add("6");
            CbeThang.Properties.Items.Add("7");
            CbeThang.Properties.Items.Add("8");
            CbeThang.Properties.Items.Add("9");
            CbeThang.Properties.Items.Add("10");
            CbeThang.Properties.Items.Add("11");
            CbeThang.Properties.Items.Add("12");
        }

        void LoadData()
        {
            GcDoanhThu.DataSource = dataAccess.GetDataTable("");
        }
    }
}
