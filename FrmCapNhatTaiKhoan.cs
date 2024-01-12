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
    public partial class FrmCapNhatTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        DataAccess dataAccess = new DataAccess();
        public FrmCapNhatTaiKhoan()
        {
            InitializeComponent();
        }
        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            int MaNV = Session.luuMaNV;
            string TenDangNhapMoi = TeTenDangNhap.Text;
            string MatKhauMoi = TeMatKhau.Text;

            dataAccess.UpdateData($"UPDATE TAI_KHOAN SET TenDangNhap = N'{TenDangNhapMoi}', MatKhau = N'{MatKhauMoi}' where MaNV = {MaNV}");
        }

        private void TeNhapLaiMatKhau_Validating(object sender, CancelEventArgs e)
        {
            string MatKhauMoi = TeMatKhau.Text;
            string NhapLaiMatKhauMoi = TeNhapLaiMatKhau.Text;

            if (MatKhauMoi != NhapLaiMatKhauMoi)
            {
                MessageBox.Show("Nhập Lại Mật Khẩu Không Chính Xác");
                //e.Cancel = true;
            }    
        }
    }
}