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
    public partial class FrmThemChucVu : DevExpress.XtraEditors.XtraForm
    {
        DataAccess dataAccess = new DataAccess();
        public FrmThemChucVu()
        {
            InitializeComponent();
        }

        private void BtnThemCV_Click(object sender, EventArgs e)
        {
            string tenCV = TeTenCV.Text;
            string motaCV = TeMoTaCV.Text;
            string cap = CbeCapQuanLy.Text;
            bool capQL;

            if (cap == "Có")
            {
                capQL = true;
            }    
            else
            {
                capQL = false;
            }

            string sqlInsert = $"INSERT INTO CHUC_VU (TenCV, CapQuanLy, MoTa) VALUES (N'{tenCV}', '{capQL}', N'{motaCV}')";
            dataAccess.UpdateData(sqlInsert);
            var result = XtraMessageBox.Show("Thêm Chức Vụ Mới Thành Công");
            if (result == DialogResult.OK)
            {
                this.Close();
            }    
        }
    }
}