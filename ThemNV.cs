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
            TeMaNV.Text = "";
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
            List<string> GioiTinh = new List<string>();
            string query = "SELECT DISTINCT GioiTinh FROM NHAN_VIEN";

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

        private List<string> LayChucVu()
        {
            List<string> ChucVu = new List<string>();
            string query = "SELECT DISTINCT ChucVu FROM NHAN_VIEN";

            using (SqlCommand cmd = new SqlCommand(query, dataAccess.objConnection))
            {
                dataAccess.objConnection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ChucVu.Add(reader["ChucVu"].ToString());
                    }
                }

                dataAccess.objConnection.Close();

            }
            return ChucVu;
        }
        private void HienThiGioiTinh()
        {
            List<string> GioiTinh = LayGioiTinh();
            CbeGioiTinh.Properties.Items.AddRange(GioiTinh);

            CbeGioiTinh.Properties.AutoComplete = true;
            CbeGioiTinh.Properties.CaseSensitiveSearch = false;
        }
        private void HienThiChucVu()
        {
            List<string> ChucVu = LayChucVu();
            CbeChucVu.Properties.Items.AddRange(ChucVu);

            CbeChucVu.Properties.AutoComplete = true;
            CbeChucVu.Properties.CaseSensitiveSearch = false;
        }
    }
}