using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
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
    public partial class UcTKHangTonKho : DevExpress.XtraEditors.XtraUserControl
    {
        DataAccess dataAccess = new DataAccess();
        int mucAnToan = -1;
        string latest = DateTime.Now.ToShortDateString();
        public UcTKHangTonKho()
        {
            InitializeComponent();

            GvHangTon.OptionsBehavior.Editable = false;

            ThongKe();
        }
        private void ThongKe()
        {
            UpdateTotalQuantity();
            //LoadData();
        }

        private void UpdateTotalQuantity()
        {
            try
            {
                string queryQuantity = "SELECT SUM(SoLuong) AS TongSoLuong FROM SAN_PHAM";
                object resultQuantity = dataAccess.GetScalar(queryQuantity);

                if (resultQuantity != null && resultQuantity != DBNull.Value)
                {
                    LbTongSoHang.Text = resultQuantity.ToString();
                }
                else
                {
                    MessageBox.Show("Lỗi.");
                }

                string queryTotal = "SELECT SUM(CAST(GiaBanLe AS bigint) * CAST(SoLuong AS bigint)) AS TongGiaTri FROM SAN_PHAM"; 
                object resultTotal = dataAccess.GetScalar(queryTotal);

                if (resultTotal != null && resultTotal != DBNull.Value)
                {
                    LbTongGiaTriKho.Text = resultTotal.ToString();
                }
                else
                {
                    MessageBox.Show("Lỗi.");
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
        private void LoadData()
        {
            try
            {
                if (mucAnToan == -1)
                {
                    return;
                }    
                string queryHangTon = $"SELECT * FROM SAN_PHAM WHERE SoLuong > {mucAnToan}";

                DataTable dataTableHangTon = dataAccess.GetDataTable(queryHangTon);

                GcHangTon.DataSource = dataTableHangTon;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void TeMucAnToan_TextChanged(object sender, EventArgs e)
        {
            if (TeMucAnToan.Text == "")
            {
                return;
            }    
            mucAnToan = Convert.ToInt32(TeMucAnToan.Text);
            LoadData();
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
