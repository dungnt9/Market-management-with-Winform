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
        DataAccess dataAccess = new DataAccess();
        public FrmDangKy()
        {
            InitializeComponent();
        }
        // Xoá hết thông tin trong các trường đăng ký
        private void BtnXoaDangKy_Click(object sender, EventArgs e)
        {
            TeMaNV.Text = "";
            TeTenTaiKhoan.Text = "";
            TeMatKhau.Text = "";
            TeNhapLai.Text = "";
        }
        //Nút hiện mật khẩu
        private void PbHien1_Click(object sender, EventArgs e)
        {
            if (TeMatKhau.Properties.PasswordChar == (char)0)
            {
                PbAn1.BringToFront();
                TeMatKhau.Properties.PasswordChar = '*';
            }
        }
        //Nút ẩn mật khẩu
        private void PbAn1_Click(object sender, EventArgs e)
        {
            if (TeMatKhau.Properties.PasswordChar == '*')
            {
                PbHien1.BringToFront();
                TeMatKhau.Properties.PasswordChar = (char)0;
            }
        }
        //Nút hiện mật khẩu
        private void PbHien2_Click(object sender, EventArgs e)
        {
            if (TeNhapLai.Properties.PasswordChar == (char)0)
            {
                PbAn2.BringToFront();
                TeNhapLai.Properties.PasswordChar = '*';
            }
        }
        //Nút ẩn mật khẩu
        private void PbAn2_Click(object sender, EventArgs e)
        {
            if (TeNhapLai.Properties.PasswordChar == '*')
            {
                PbHien2.BringToFront();
                TeNhapLai.Properties.PasswordChar = (char)0;
            }
        }
        //Kiểm tra mật khẩu và mật khẩu nhập lại có trùng nhau không và đưa ra thông báo
        private void TeNhapLai_EditValueChanged(object sender, EventArgs e)
        {
            if (TeNhapLai.Text != TeMatKhau.Text & TeMatKhau.Text != "")
            {
                LbThongBao.Text = "Mật khẩu không khớp";
            }
            else
            {
                LbThongBao.Text = "";
            }
        }
        //Kiểm tra mật khẩu và mật khẩu nhập lại có trùng nhau không và đưa ra thông báo
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
        //Cài đặt nút quay lại trang chủ
        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain f = new FormMain();
            f.ShowDialog();
        }
        //Cài đặt nút đăng ký
        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            if(TeMaNV.Text != "" & TeTenTaiKhoan.Text != "" & TeMatKhau.Text != "" & LbThongBao.Text == "")
            {
                string s = string.Format("INSERT INTO TaiKhoan (MaNV, TenTaiKhoan ,MatKhau) VALUES" + "(N'{0}',N'{1}','{2}',N'{3}')", TeMaNV.Text, TeTenTaiKhoan.Text, TeMatKhau.Text);
                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                dataAccess.UpdateData(s);
            }
            else
            {
                MessageBox.Show("Không được để trống các trường sau \n - Mã Nhân Viên\n - Tên Khách Hàng \n - Mật Khẩu\n - Nhập Lại Mật Khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}