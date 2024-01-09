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
    public partial class FrmThemMGG : DevExpress.XtraEditors.XtraForm
    {
        DataAccess dataAccess = new DataAccess();
        public FrmThemMGG()
        {
            InitializeComponent();

            CbePhanTram.Properties.Items.Add("5");
            CbePhanTram.Properties.Items.Add("10");
            CbePhanTram.Properties.Items.Add("15");
            CbePhanTram.Properties.Items.Add("20");
            CbePhanTram.Properties.Items.Add("25");
            CbePhanTram.Properties.Items.Add("30");
            CbePhanTram.Properties.Items.Add("40");
            CbePhanTram.Properties.Items.Add("50");
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            int TrangThai = 1;
            if (RbConHieuLuc.Checked)
            {
                TrangThai = 1;
            }
            if (RbHetHan.Checked)
            {
                TrangThai = 0;
            }
            if (TeTenChuongTrinh.Text != "")
            {
                string s = string.Format("INSERT INTO MA_GIAM_GIA (TenChuongTrinh,NgayTao, TrangThai, MoTa, PhanTram) VALUES" + "(N'{0}','{1}','{2}',N'{3}','{4}')", TeTenChuongTrinh.Text, DeNgayTao.Text, TrangThai, TeMoTa.Text, CbePhanTram.Text);
                MessageBox.Show("Thêm thành công");
                dataAccess.UpdateData(s);
            }
        }

        private void BtnXoaDangKy_Click(object sender, EventArgs e)
        {
            TeMaGiamGia.Text = "";
            TeTenChuongTrinh.Text = "";
            CbePhanTram.Text = "";
            DeNgayTao.Text = "";
            TeMoTa.Text = "";
            RbConHieuLuc.Checked = false;
            RbHetHan.Checked = false;
        }
    }
}