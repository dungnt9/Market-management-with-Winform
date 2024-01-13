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
    public partial class FrmThemKH : DevExpress.XtraEditors.XtraForm
    {
        DataAccess dataAccess = new DataAccess();
        public FrmThemKH()
        {
            InitializeComponent();

            HienThiGioiTinh();
            HienThiMaGiamGia();
            CbeMaGiamGia.Text = "zB8NKYT0";
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (TeTenKH.Text != "")
            {
                string ngaySinh = DeNgaySinh.Text;
                if(ngaySinh != "")
                {
                    if (CbeGioiTinh.Properties.Items.Contains(CbeGioiTinh.Text) || CbeGioiTinh.Text == "")
                    {
                        string s = string.Format("INSERT INTO KHACH_HANG (TenKH,GioiTinh,SDT,DiaChi,MaGiamGia, NgaySinh, TichDiem) VALUES" + "(N'{0}',N'{1}','{2}',N'{3}','{4}','{5}', 0)", TeTenKH.Text, CbeGioiTinh.Text, TeSDT.Text, TeDiaChi.Text, CbeMaGiamGia.Text, DeNgaySinh.Text);
                        MessageBox.Show("Thêm thành công");
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
                        string s = string.Format("INSERT INTO KHACH_HANG (TenKH,GioiTinh,SDT,DiaChi,MaGiamGia, NgaySinh, TichDiem) VALUES" + "(N'{0}',N'{1}','{2}',N'{3}','{4}',NULL, 0)", TeTenKH.Text, CbeGioiTinh.Text, TeSDT.Text, TeDiaChi.Text, CbeMaGiamGia.Text);
                        MessageBox.Show("Thêm thành công");
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
                MessageBox.Show("Không được để trống các trường sau \n - Tên Khách Hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<string> LayGioiTinh()
        {
            List<string> gioiTinh = new List<string>();
            string query = "SELECT DISTINCT GioiTinh FROM KHACH_HANG";

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

        private List<string> LayMaGiamGia()
        {
            List<string> maGiamGia = new List<string>();
            string query = "SELECT MaGiamGia FROM MA_GIAM_GIA";

            using (SqlCommand cmd = new SqlCommand(query, dataAccess.objConnection))
            {
                dataAccess.objConnection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        maGiamGia.Add(reader["MaGiamGia"].ToString());
                    }
                }

                dataAccess.objConnection.Close();

            }
            return maGiamGia;
        }
        private void HienThiGioiTinh()
        {
            List<string> gioiTinh = LayGioiTinh();
            CbeGioiTinh.Properties.Items.AddRange(gioiTinh);

            CbeGioiTinh.Properties.AutoComplete = true;
            CbeGioiTinh.Properties.CaseSensitiveSearch = false;
        }
        private void HienThiMaGiamGia()
        {
            List<string> maGiamGia = LayMaGiamGia();
            CbeMaGiamGia.Properties.Items.AddRange(maGiamGia);

            CbeMaGiamGia.Properties.AutoComplete = true;
            CbeMaGiamGia.Properties.CaseSensitiveSearch = false;
        }

        private void BtnXoaThongTin_Click(object sender, EventArgs e)
        {
            TeTenKH.Text = "";
            CbeGioiTinh.Text = "";
            DeNgaySinh.Text = "";
            TeSDT.Text = "";
            CbeMaGiamGia.Text = "";
            TeDiaChi.Text = "";
        }

        private void TeSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}