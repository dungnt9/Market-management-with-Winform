using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market_management
{
    public partial class FrmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        DataAccess dataAccess = new DataAccess();
        public int luuNhanVien;
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void SbtnDangNhap_Click(object sender, EventArgs e)
        {
            string tenTaiKhoan = TeTenDangNhap.Text;
            string matKhau = TbMatKhau.Text;

            if (string.IsNullOrWhiteSpace(tenTaiKhoan) || string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi đăng nhập",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string query = "SELECT TAI_KHOAN.MaNV, NHAN_VIEN.TenNV " +
                                    "FROM TAI_KHOAN " +
                                    "INNER JOIN NHAN_VIEN ON TAI_KHOAN.MaNV = NHAN_VIEN.MaNV " +
                                    "WHERE TAI_KHOAN.TenTaiKhoan = @TenTaiKhoan AND TAI_KHOAN.MatKhau = @MatKhau";

                using (SqlCommand command = new SqlCommand(query, dataAccess.objConnection))
                {
                    dataAccess.objConnection.Open();
                    command.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                    command.Parameters.AddWithValue("@MatKhau", matKhau);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Ensure that the value can be converted to int
                        if (int.TryParse(reader["MaNV"].ToString(), out int maNV))
                        {
                            luuNhanVien = maNV;

                            // Open FormMain when credentials are correct
                            OpenFormMain();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi chuyển đổi giá trị mã nhân viên sang kiểu int.", "Lỗi đăng nhập",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng kiểm tra và thử lại.", "Lỗi đăng nhập",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi đăng nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void OpenFormMain()
        {
            // Open FormMain
            FormMain frmMain = new FormMain();
            frmMain.MaNV = luuNhanVien;
            frmMain.LoadNhanVienData();
            frmMain.Show();
            this.Hide();
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }
        private void TeMatKhau_EditValueChanged(object sender, EventArgs e)
        {

        }
        private void TeTenDangNhap_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void eye_Click(object sender, EventArgs e)
        {
            if (TbMatKhau.PasswordChar == '*')
            {
                hide.BringToFront();
                TbMatKhau.PasswordChar = '\0';

            }
        }
        private void hide_Click(object sender, EventArgs e)
        {
            if (TbMatKhau.PasswordChar == '\0')
            {
                eye.BringToFront();
                TbMatKhau.PasswordChar = '*';
            }
        }

        private void SbtnDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SbtnDangNhap.PerformClick();
            }
        }
    }
}
