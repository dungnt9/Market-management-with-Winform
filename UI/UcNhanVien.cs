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

namespace market_management
{
    public partial class UcNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        DataAccess dataAccess = new DataAccess();
        public UcNhanVien()
        {
            InitializeComponent();
            LoadData();

            CbeGioiTinh.Properties.Items.Add("Nam");
            CbeGioiTinh.Properties.Items.Add("Nữ");
            CbeGioiTinh.Properties.Items.Add("Khác");

            //CbeChucVu.DataBindings.Add();
        }

        void LoadData()
        {
            GcDanhMucNV.DataSource = dataAccess.GetDataTable("select * from NHAN_VIEN");
        }

        private void gridControl_Click(object sender, EventArgs e)
        {

        }
    }
}
