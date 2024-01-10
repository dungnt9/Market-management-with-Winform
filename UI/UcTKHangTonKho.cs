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
                // Tạo câu truy vấn SQL để lấy tổng số lượng hàng đang có
                string queryQuantity = "SELECT SUM(SoLuong) AS TongSoLuong FROM SAN_PHAM"; // Thay TenBang bằng tên thực tế của bảng trong cơ sở dữ liệu của bạn

                // Lấy dữ liệu từ cơ sở dữ liệu
                object resultQuantity = dataAccess.GetScalar(queryQuantity);

                if (resultQuantity != null && resultQuantity != DBNull.Value)
                {
                    // Hiển thị tổng số lượng trong một Label hoặc TextBox (đặt tên là labelTotalQuantity)
                    LbTongSoHang.Text = resultQuantity.ToString();
                }
                else
                {
                    // Nếu không có dữ liệu, hiển thị thông báo
                    MessageBox.Show("Không có dữ liệu.");
                }

                string queryTotal = "SELECT SUM(GiaBanLe * SoLuong) AS TongGiaTri FROM SAN_PHAM"; // Thay TenBang, GiaBan, SoLuong bằng tên thực tế của bảng và các cột trong cơ sở dữ liệu của bạn

                object resultTotal = dataAccess.GetScalar(queryTotal);

                if (resultTotal != null && resultTotal != DBNull.Value)
                {
                    // Hiển thị tổng số lượng trong một Label hoặc TextBox (đặt tên là labelTotalQuantity)
                    LbTongGiaTriKho.Text = resultTotal.ToString();
                }
                else
                {
                    // Nếu không có dữ liệu, hiển thị thông báo
                    MessageBox.Show("Không có dữ liệu.");
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

                // Hiển thị kết quả trong GridControl (đặt tên là gridControl)
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
