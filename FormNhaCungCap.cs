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
    public partial class FormNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        DataAccess dataAccess = new DataAccess();
        public FormNhaCungCap()
        {
            InitializeComponent();

            HienThiTenLoaiSP();
        }

        private void BtnThemNCC_Click(object sender, EventArgs e)
        {
            string tenNCC = TeTenNCC.Text;
            string diachiNCC = TeDiaChi_NCC.Text;
            string sdtNCC = TeSDT_NCC.Text;
            int maLoaiSP = LayMaLoaiSP();


            string sqlInsert = $"INSERT INTO NHA_CUNG_CAP (TenNCC, DiaChi, SDT, MaLoaiSP) VALUES (N'{tenNCC}', N'{diachiNCC}', '{sdtNCC}', {maLoaiSP})";

            dataAccess.UpdateData(sqlInsert);
            XtraMessageBox.Show("Thêm nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private List<string> LayTenLoaiSP()
        {
            List<string> TenLoaiSP = new List<string>();
            string query = "SELECT TenLoaiSP FROM LOAI_SAN_PHAM";

            using (SqlCommand cmd = new SqlCommand(query, dataAccess.objConnection))
            {
                dataAccess.objConnection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TenLoaiSP.Add(reader["TenLoaiSP"].ToString());
                    }
                }
            }
            return TenLoaiSP;
        }

        private void HienThiTenLoaiSP()
        {
            List<string> TenLoaiSP = LayTenLoaiSP();
            CbeLoaiSP.Properties.Items.AddRange(TenLoaiSP);

            CbeLoaiSP.Properties.AutoComplete = true;
            CbeLoaiSP.Properties.CaseSensitiveSearch = false;
        }

        private int LayMaLoaiSP()
        {
            string tenLSP = CbeLoaiSP.Text;
            string query = $"SELECT MaLoaiSP FROM LOAI_SAN_PHAM WHERE TenLoaiSP = '{tenLSP}'";

            DataTable dataTable = dataAccess.GetDataTable(query);
            int maLoaiSP = Convert.ToInt32(dataTable.Rows[0]["MaLoaiSP"]);

            return maLoaiSP;
        }
    }
}