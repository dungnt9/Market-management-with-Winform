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
    public partial class FrmTaoMGG : DevExpress.XtraEditors.XtraForm
    {
        DataAccess dataAccess = new DataAccess();
        public FrmTaoMGG()
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

            DeNgayTao.Text = DateTime.Now.ToString().Substring(0,9); 
        }

        private void BtnTao_Click(object sender, EventArgs e)
        {
            if (TeTenChuongTrinh.Text != "")
            {
                int PhanTram = Convert.ToInt32(CbePhanTram.Text);
                string TrangThai = "1";
                string MoTa = "";
                if (CheNgayLe.Checked)
                {
                    CheNgauNhien.Checked = false;
                    CheDiemTich.Checked = false;
                    MoTa = $"Ngày lễ {CbeNgayLe.Text}";
                }
                else if(CheDiemTich.Checked)
                {
                    CheNgayLe.Checked = false;
                    CheNgauNhien.Checked = false;
                    MoTa = $"Điểm cần tích: {CbeDiemTich.Text}";
                    int DiemTich = Convert.ToInt32(CbeDiemTich.Text);

                }
                else if(CheNgauNhien.Checked)
                {
                    CheNgayLe.Checked = false;
                    CheDiemTich.Checked = false;
                    MoTa = $"Nhân viên sẽ cung cấp cho khách hàng";

                }
                string s = string.Format("INSERT INTO MA_GIAM_GIA (TenChuongTrinh, PhanTram, NgayTao, TrangThai, Mota) VALUES" + "(N'{0}','{1}','{2}','{3}',N'{4}')", TeTenChuongTrinh.Text, PhanTram, DeNgayTao.Text, TrangThai, MoTa);
                MessageBox.Show("Thêm thành công");
                dataAccess.UpdateData(s);
                if (CheDiemTich.Checked)
                {
                    int DiemTich = Convert.ToInt32(CbeDiemTich.Text);
                    GanMaGiamGia(DiemTich);
                }
            }
            else
            {
                MessageBox.Show("Không được để trống các trường sau \n - Tên Chương Trình", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnXoaThongTin_Click(object sender, EventArgs e)
        {
            TeTenChuongTrinh.Text = "";
            CbePhanTram.Text = "";
            DeNgayTao.Text = "";
            CheNgayLe.Checked = false;
            CheNgauNhien.Checked = false;
            CheDiemTich.Checked = false;
            RbConHieuLuc.Checked = false;
        }

        public void GanMaGiamGia(int DiemTich)
        {
            string s = string.Format("UPDATE KHACH_HANG \r\nSET MaGiamGia = '{0}'\r\nWHERE Diem >= '{1}'",1,DiemTich);
            dataAccess.UpdateData(s);
        }
    }
}