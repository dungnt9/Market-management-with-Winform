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
    public partial class FormCapNhatTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        DataAccess dataAccess = new DataAccess();
        public FormCapNhatTaiKhoan()
        {
            InitializeComponent();
        }

        private bool KiemTraMatKhau(string MatKhauMoi, string NhapLaiMatKhau)
        {
            if(MatKhauMoi == NhapLaiMatKhau)
            {
                return true;
            }    
            else
            {
                return false;
            }    
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            string MaNV = LbTenNhanVien.Text;
            string TenDangNhapMoi = TeTenDangNhap.Text;
            string MatKhauMoi = TeMatKhau.Text;
            string NhapLaiMatKhauMoi = TeNhapLaiMatKhau.Text;

            if(KiemTraMatKhau(MatKhauMoi, NhapLaiMatKhauMoi) == false)
            {
                MessageBox.Show("Mật khẩu và nhập lại mật khẩu không khớp. Vui lòng thử lại.");
                return;
            }

            dataAccess.UpdateData(string.Format("update TAI_KHOAN set TenDangNhap = N'{1}', MatKhau = N'{2}' where MaNV = '{0}'", MaNV, TenDangNhapMoi, MatKhauMoi));
        }
    }
}