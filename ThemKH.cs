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
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (TeTenKH.Text != "")
            {
                string s = string.Format("INSERT INTO KHACH_HANG (TenKH,GioiTinh,SDT,DiaChi,MaGiamGia, NgaySinh) VALUES" + "(N'{0}',N'{1}','{2}',N'{3}','{4}','{5}')", TeTenKH.Text, CbeGioiTinh.Text, TeSDT.Text, TeDiaChi.Text, CbeMaGiamGia.Text, DeNgaySinh.Text);
                MessageBox.Show("Thêm thành công");
                dataAccess.UpdateData(s);
            }
            else
            {
                MessageBox.Show("Không được để trống các trường sau \n - Tên Khách Hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<string> LayGioiTinh()
        {
            List<string> GioiTinh = new List<string>();
            string query = "SELECT DISTINCT GioiTinh FROM KHACH_HANG";

            using (SqlCommand cmd = new SqlCommand(query, dataAccess.objConnection))
            {
                dataAccess.objConnection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        GioiTinh.Add(reader["GioiTinh"].ToString());
                    }
                }

                dataAccess.objConnection.Close();

            }
            return GioiTinh;
        }

        private List<string> LayMaGiamGia()
        {
            List<string> MaGiamGia = new List<string>();
            string query = "SELECT MaGiamGia FROM MA_GIAM_GIA";

            using (SqlCommand cmd = new SqlCommand(query, dataAccess.objConnection))
            {
                dataAccess.objConnection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MaGiamGia.Add(reader["MaGiamGia"].ToString());
                    }
                }

                dataAccess.objConnection.Close();

            }
            return MaGiamGia;
        }
        private void HienThiGioiTinh()
        {
            List<string> GioiTinh = LayGioiTinh();
            CbeGioiTinh.Properties.Items.AddRange(GioiTinh);

            CbeGioiTinh.Properties.AutoComplete = true;
            CbeGioiTinh.Properties.CaseSensitiveSearch = false;
        }
        private void HienThiMaGiamGia()
        {
            List<string> MaGiamGia = LayMaGiamGia();
            CbeMaGiamGia.Properties.Items.AddRange(MaGiamGia);

            CbeMaGiamGia.Properties.AutoComplete = true;
            CbeMaGiamGia.Properties.CaseSensitiveSearch = false;
        }

        private void BtnXoaThongTin_Click(object sender, EventArgs e)
        {
            TeMaKH.Text = "";
            TeTenKH.Text = "";
            CbeGioiTinh.Text = "";
            DeNgaySinh.Text = "";
            TeSDT.Text = "";
            CbeMaGiamGia.Text = "";
            TeDiaChi.Text = "";
        }
    }
}