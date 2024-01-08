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
    public partial class FormNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        DataAccess dataAccess = new DataAccess();
        public FormNhaCungCap()
        {
            InitializeComponent();
        }

        private void BtnThemNCC_Click(object sender, EventArgs e)
        {
            string tenNCC = TeTenNCC.Text;
            string diachiNCC = TeDiaChi_NCC.Text;
            string sdtNCC = TeSDT_NCC.Text;

            string sqlInsert = $"INSERT INTO NHA_CUNG_CAP (TenNCC, DiaChi, SDT) VALUES (N'{tenNCC}', N'{diachiNCC}', '{sdtNCC}')";

            dataAccess.UpdateData(sqlInsert);
            XtraMessageBox.Show("Thêm nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}