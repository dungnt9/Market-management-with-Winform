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
    public partial class FrmDangKy : DevExpress.XtraEditors.XtraForm
    {
        public FrmDangKy()
        {
            InitializeComponent();
        }

        private void BtnXoaDangKy_Click(object sender, EventArgs e)
        {
            TeMaNV.Text = "";
            TeTenTaiKhoan.Text = "";
            TeSDT.Text = "";
            TeMatKhau.Text = "";
            TeNhapLai.Text = "";
            TeEmail.Text = "";
        }

        private void TeNhapLai_EditValueChanged(object sender, EventArgs e)
        {
            if(TeNhapLai.Text != TeMatKhau.Text & TeMatKhau.Text != "")
            {
                LbThongBao.Text = "Mật khẩu không khớp";
            }
            else
            {
                LbThongBao.Text = "";
            }
        }

        private void PbHien1_Click(object sender, EventArgs e)
        {
            if (TeMatKhau.Properties.PasswordChar == (char)0)
            {
                PbAn1.BringToFront();
                TeMatKhau.Properties.PasswordChar = '*';
            }
        }

        private void PbAn1_Click(object sender, EventArgs e)
        {
            if (TeMatKhau.Properties.PasswordChar == '*')
            {
                PbHien1.BringToFront();
                TeMatKhau.Properties.PasswordChar = (char)0;
            }
        }

        private void PbHien2_Click(object sender, EventArgs e)
        {
            if (TeNhapLai.Properties.PasswordChar == (char)0)
            {
                PbAn2.BringToFront();
                TeNhapLai.Properties.PasswordChar = '*';
            }
        }

        private void PbAn2_Click(object sender, EventArgs e)
        {
            if (TeNhapLai.Properties.PasswordChar == '*')
            {
                PbHien2.BringToFront();
                TeNhapLai.Properties.PasswordChar = (char)0;
            }
        }

        private void TeMatKhau_EditValueChanged(object sender, EventArgs e)
        {
            if (TeNhapLai.Text != TeMatKhau.Text & TeNhapLai.Text != "")
            {
                LbThongBao.Text = "Mật khẩu không khớp";
            }
            else
            {
                LbThongBao.Text = "";
            }
        }
    }
}