using DevExpress.XtraEditors;
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
    public partial class FrmThemNV : DevExpress.XtraEditors.XtraForm
    {
        DataAccess dataAccess = new DataAccess();
        public FrmThemNV()
        {
            InitializeComponent();
            HienThiChucVu();
            HienThiGioiTinh();
        }

        private void BtnXoaThongTin_Click(object sender, EventArgs e)
        {
            TeTenNV.Text = "";
            CbeGioiTinh.Text = "";
            DeNgaySinh.Text = "";
            TeSDT.Text = "";
            TeEmail.Text = "";
            TeDiaChi.Text = "";
            TeCCCD.Text = "";
            CbeChucVu.Text = "";
        }
        private List<string> LayGioiTinh()
        {
            List<string> gioiTinh = new List<string>();
            string query = "SELECT DISTINCT GioiTinh FROM NHAN_VIEN";

            using (SqlCommand cmd = new SqlCommand(query, dataAccess.objConnection))
            {
                dataAccess.objConnection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        gioiTinh.Add(reader["GioiTinh"].ToString());
                    }
                }

                dataAccess.objConnection.Close();

            }
            return gioiTinh;
        }

        private List<string> LayChucVu()
        {
            List<string> chucVu = new List<string>();
            string query = "SELECT MaCV FROM CHUC_VU";

            using (SqlCommand cmd = new SqlCommand(query, dataAccess.objConnection))
            {
                dataAccess.objConnection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        chucVu.Add(reader["MaCV"].ToString());
                    }
                }

                dataAccess.objConnection.Close();

            }
            return chucVu;
        }
        private void HienThiGioiTinh()
        {
            List<string> gioiTinh = LayGioiTinh();
            CbeGioiTinh.Properties.Items.AddRange(gioiTinh);

            CbeGioiTinh.Properties.AutoComplete = true;
            CbeGioiTinh.Properties.CaseSensitiveSearch = false;
        }
        private void HienThiChucVu()
        {
            List<string> chucVu = LayChucVu();
            CbeChucVu.Properties.Items.AddRange(chucVu);

            CbeChucVu.Properties.AutoComplete = true;
            CbeChucVu.Properties.CaseSensitiveSearch = false;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (TeTenNV.Text != "")
            {
                string ngaySinh = DeNgaySinh.Text;
                if (ngaySinh != "")
                {
                    if (CbeGioiTinh.Properties.Items.Contains(CbeGioiTinh.Text) || CbeGioiTinh.Text == "")
                    {
                        string s = string.Format("INSERT INTO NHAN_VIEN (TenNV,GioiTinh, SDT, DiaChi, CanCuoc, NgaySinh, Email , MaChucVu) VALUES" + "(N'{0}',N'{1}','{2}',N'{3}','{4}','{5}', '{6}', '{7}')", TeTenNV.Text, CbeGioiTinh.Text, TeSDT.Text, TeDiaChi.Text, TeCCCD.Text, DeNgaySinh.Text, TeEmail.Text, CbeChucVu.Text);
                        XtraMessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataAccess.UpdateData(s);
                    }
                    else
                    {
                        XtraMessageBox.Show("Giới tính không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (CbeGioiTinh.Properties.Items.Contains(CbeGioiTinh.Text) || CbeGioiTinh.Text == "")
                    {
                        string s = string.Format("INSERT INTO NHAN_VIEN (TenNV,GioiTinh, SDT, DiaChi, CanCuoc, NgaySinh, Email , MaChucVu) VALUES" + "(N'{0}',N'{1}','{2}',N'{3}','{4}','{5}', '{6}', '{7}')", TeTenNV.Text, CbeGioiTinh.Text, TeSDT.Text, TeDiaChi.Text, TeCCCD.Text, DeNgaySinh.Text, TeEmail.Text, CbeChucVu.Text);
                        XtraMessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataAccess.UpdateData(s);
                    }
                    else
                    {
                        XtraMessageBox.Show("Giới tính không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Không được để trống các trường sau \n - Tên Nhân Viên ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TeSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TeCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}