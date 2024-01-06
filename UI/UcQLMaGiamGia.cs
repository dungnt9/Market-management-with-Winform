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
        public UcQLMaGiamGia()
        {
            InitializeComponent();

            BindingList<Customer> dataSource = GetDataSource();
            GcMaGiamGia.DataSource = dataSource;
            bsiRecordsCount.Caption = "RECORDS : " + dataSource.Count;
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
    }
}
