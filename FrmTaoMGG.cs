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

        string MaGiamGia = GenerateRandomString(8);
        static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            Random random = new Random();
            char[] randomArray = new char[length];

            for (int i = 0; i < length; i++)
            {
                randomArray[i] = chars[random.Next(chars.Length)];
            }
            return new string(randomArray);
        }
        public FrmTaoMGG()
        {
            InitializeComponent();

            CbePhanTram.Properties.Items.Add("1");
            CbePhanTram.Properties.Items.Add("2");
            CbePhanTram.Properties.Items.Add("5");
            CbePhanTram.Properties.Items.Add("10");
            CbePhanTram.Properties.Items.Add("15");
            CbePhanTram.Properties.Items.Add("20");
            CbePhanTram.Properties.Items.Add("25");
            CbePhanTram.Properties.Items.Add("30");
            CbePhanTram.Properties.Items.Add("50");

            CbeDiemTich.Properties.Items.Add("1000");
            CbeDiemTich.Properties.Items.Add("2000");
            CbeDiemTich.Properties.Items.Add("5000");
            CbeDiemTich.Properties.Items.Add("10000");
            CbeDiemTich.Properties.Items.Add("20000");
            CbeDiemTich.Properties.Items.Add("30000");
            CbeDiemTich.Properties.Items.Add("50000");
            CbeDiemTich.Properties.Items.Add("100000");

            CbeNgayLe.Properties.Items.Add("1/1");
            CbeNgayLe.Properties.Items.Add("1/6");
            CbeNgayLe.Properties.Items.Add("1/5");
            CbeNgayLe.Properties.Items.Add("30/4");
            CbeNgayLe.Properties.Items.Add("20/10");
            CbeNgayLe.Properties.Items.Add("20/11");
            CbeNgayLe.Properties.Items.Add("8/3");
            CbeNgayLe.Properties.Items.Add("19/11");


            DeNgayTao.Text = DateTime.Now.ToString().Substring(0, 9);
        }

        private void BtnTao_Click(object sender, EventArgs e)
        {
            if (TeTenChuongTrinh.Text != "")
            {
                int PhanTram = Convert.ToInt32(CbePhanTram.Text);
                string TrangThai = "1";
                string MoTa = "";
                if (RbNgayLe.Checked)
                {
                    MoTa = $"Ngày lễ {CbeNgayLe.Text}";
                }
                else if (RbDiemTich.Checked)
                {
                    MoTa = $"Điểm cần tích: {CbeDiemTich.Text}";
                }
                else if (RbNgauNhien.Checked)
                {
                    MoTa = $"Nhân viên sẽ cung cấp cho khách hàng";

                }
                string s = string.Format("INSERT INTO MA_GIAM_GIA (MaGiamGia, TenChuongTrinh, PhanTram, NgayTao, NgayHetHan, TrangThai, Mota) VALUES" + "('{0}',N'{1}','{2}','{3}','{4}','{5}',N'{6}')", MaGiamGia, TeTenChuongTrinh.Text, PhanTram, DeNgayTao.Text, DeNgayHetHan.Text,TrangThai, MoTa);
                MessageBox.Show("Thêm thành công");
                dataAccess.UpdateData(s);
                if (RbDiemTich.Checked)
                {
                    int DiemTich = Convert.ToInt32(CbeDiemTich.Text);
                    GanMaGiamGia(DiemTich);
                }
                this.Close();
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
            DeNgayHetHan.Text = "";
            CbeDiemTich.Text = "";
            CbeNgayLe.Text = "";
            RbNgayLe.Checked = false;
            RbNgauNhien.Checked = false;
            RbDiemTich.Checked = false;
        }

        public void GanMaGiamGia(int DiemTich)
        {

            string s = string.Format("UPDATE KHACH_HANG \r\nSET MaGiamGia = '{0}'\r\nWHERE Diem >= '{1}'", 1, DiemTich);
            dataAccess.UpdateData(s);
        }
    }
}