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
    public partial class UcNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        public UcNhanVien()
        {
            InitializeComponent();

            BindingList<Customer> dataSource = GetDataSource();
            GcDanhMucNV.DataSource = dataSource;
            bsiRecordsCount.Caption = "RECORDS : " + dataSource.Count;
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            GcDanhMucNV.ShowRibbonPrintPreview();
        }
        public BindingList<Customer> GetDataSource()
        {
            BindingList<Customer> result = new BindingList<Customer>();
            result.Add(new Customer());
            return result;
        }
        public class Customer
        {

        }

        private void gridControl_Click(object sender, EventArgs e)
        {

        }
    }
}
