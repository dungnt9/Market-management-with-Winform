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
        public int luuNhanVien;
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private const string ConnectionString = @"Data Source= DESKTOP-IAMCQPA\SQLEXPRESS;Initial Catalog=QLST;Integrated Security=True ";


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
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT TAI_KHOAN.MaNV, NHAN_VIEN.TenNV " +
                                    "FROM TAI_KHOAN " +
                                    "INNER JOIN NHAN_VIEN ON TAI_KHOAN.MaNV = NHAN_VIEN.MaNV " +
                                    "WHERE TAI_KHOAN.TenTaiKhoan = @TenTaiKhoan AND TAI_KHOAN.MatKhau = @MatKhau";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                        command.Parameters.AddWithValue("@MatKhau", matKhau);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            // Ensure that the value can be converted to int
                            if (int.TryParse(reader["MaNV"].ToString(), out int maNV))
                            {
                                luuNhanVien = maNV;
                            }
                            else
                            {
                                MessageBox.Show("Lỗi chuyển đổi giá trị mã nhân viên sang kiểu int.", "Lỗi đăng nhập",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi đăng nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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
    }
}
