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
using static DevExpress.Xpo.Helpers.AssociatedCollectionCriteriaHelper;

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

            if(maLoaiSP == -1)
            {
                return;
            }    


            string sqlInsert = $"INSERT INTO NHA_CUNG_CAP (TenNCC, DiaChi, SDT, MaLoaiSP) VALUES (N'{tenNCC}', N'{diachiNCC}', '{sdtNCC}', {maLoaiSP})";

            dataAccess.UpdateData(sqlInsert);
            var result = XtraMessageBox.Show("Thêm nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Close(); // Tắt Form hiện tại
            }
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
            string query = $"SELECT MaLoaiSP FROM LOAI_SAN_PHAM WHERE TenLoaiSP = N'{tenLSP}'";

            DataTable dataTable = dataAccess.GetDataTable(query);

            if (dataTable.Rows.Count == 0)
            {
                XtraMessageBox.Show("Loại Sản Phẩm Chưa Được Kinh Doanh");
                return -1;
            }    
             
            int maLoaiSP = Convert.ToInt32(dataTable.Rows[0]["MaLoaiSP"]);

            return maLoaiSP;
        }

        private void TeSDT_NCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}