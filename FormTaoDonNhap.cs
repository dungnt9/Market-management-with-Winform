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
    public partial class FrmTaoDonNhap : DevExpress.XtraEditors.XtraForm
    {
        public FrmTaoDonNhap()
        {
            InitializeComponent();
        }

        private List<string> LayTenNCC()
        {
            List<string> TenNCC = new List<string>();
            string connectionString = @"Data Source= DESKTOP-IAMCQPA\SQLEXPRESS;Initial Catalog=QLST;Integrated Security=True ";
            string query = "SELECT TenNCC FROM NHA_CUNG_CAP";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TenNCC.Add(reader["TenNCC"].ToString());
                        }
                    }
                }
            }

            return TenNCC;
        }

        private void HienThiTenNCC()
        {
            List<string> TenNCC = LayTenNCC(); 
            foreach (string item in TenNCC)
            {
                CmbTenNCC.Items.Add(item);
            }
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmTaoDonNhap_Load(object sender, EventArgs e)
        {
            HienThiTenNCC();

        }
    }

}
