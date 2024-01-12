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

namespace market_management
{
    public partial class FrmThemLoaiSP : DevExpress.XtraEditors.XtraForm
    {
        DataAccess dataAccess = new DataAccess();

        public FrmThemLoaiSP()
        {
            InitializeComponent();
        }
        private bool IsTenLoaiSPExists(string tenLoaiSP)
        {
            DataTable dataTable = dataAccess.GetDataTable($"SELECT TenLoaiSP FROM LOAI_SAN_PHAM WHERE TenLoaiSP = N'{tenLoaiSP}'");
            return dataTable.Rows.Count > 0;
        }

        private void BtnThemLoaiSP_Click(object sender, EventArgs e)
        {
            var tenLoaiSP = TeTenLoaiSP.Text;
            var trangThai = CmbTrangThai.Text;
            var isExist = IsTenLoaiSPExists(tenLoaiSP);

            if (isExist)
            {
                XtraMessageBox.Show($"Loại sản phẩm này đã tồn tại!", "Thông báo");
                return;
            }

            if (string.IsNullOrEmpty(tenLoaiSP) || string.IsNullOrEmpty(trangThai))
            {
                XtraMessageBox.Show("Nhập đầy đủ thông tin loại sản phẩm", "Thông báo");
                return;
            }

            var sqlInsert = $"INSERT INTO LOAI_SAN_PHAM (TenLoaiSP, TrangThai)\r\n" +
                $"VALUES (N'{tenLoaiSP}', ";

            if (trangThai == "Đang kinh doanh")
            {
                sqlInsert += "1";
            }
            else if (trangThai == "Không còn kinh doanh")
            {
                sqlInsert += "0";
            }
            else
            {
                sqlInsert += "NULL";
            }

            sqlInsert += ")";
            try
            {
                dataAccess.UpdateData(sqlInsert);

                var result = XtraMessageBox.Show("Thêm loại sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    this.Close(); 
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Lỗi thêm loại sản phẩm: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}