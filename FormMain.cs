using DevExpress.XtraBars;
using market_management.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace market_management
{
    public partial class FormMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        UcLoaiSanPham _UcLSP;
        UcSanPham _UcSP;
        //UcTKKhachHang _UcTKKhachHang;
        UcQLNhapHang _UcQLNhapHang;
        UcKhachHang _UcKH;
        UcNhanVien _UcNV;
        UcTKBanHang _UcDT;
        UcQLMaGiamGia _UcMGG;
        DataAccess dataAccess = new DataAccess();

        public FormMain()
        {
            InitializeComponent();

            LoadDataNV();
        }
        public int MaNV { get; set; }

        public void LoadDataNV()
        {
            string query = "SELECT TenNV, ChucVu FROM NHAN_VIEN WHERE NHAN_VIEN.MaNV = @MaNV";
            List<string> ThongTin = new List<string>();

            using (SqlCommand cmd = new SqlCommand(query, dataAccess.objConnection))
            {
                dataAccess.objConnection.Open();

                cmd.Parameters.AddWithValue("@MaNV", MaNV);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ThongTin.Add(reader["TenNV"].ToString());
                        ThongTin.Add(reader["ChucVu"].ToString());
                    }
                    else
                    {
                        MessageBox.Show("No data found.");
                    }
                }
                BsiTenNV.Caption = ThongTin[0];
                BsiChucvu.Caption = ThongTin[1];
                dataAccess.objConnection.Close();
            }
        }



        private void LoaiSP_Click(object sender, EventArgs e)
        {
            if (_UcLSP == null)
            {
                _UcLSP = new UcLoaiSanPham();
                _UcLSP.Dock = DockStyle.Fill;
                PnlMain.Controls.Add(_UcLSP);
                _UcLSP.BringToFront();
            }
            else
            {
                _UcLSP.BringToFront();
            }
        }

        private void SP_Click(object sender, EventArgs e)
        {
            if (_UcSP == null)
            {
                _UcSP = new UcSanPham();
                _UcSP.Dock = DockStyle.Fill;
                PnlMain.Controls.Add(_UcSP);
                _UcSP.BringToFront();
            }
            else
            {
                _UcSP.BringToFront();
            }
        }

        private void KH_Click(object sender, EventArgs e)
        {
            if (_UcKH == null)
            {
                _UcKH = new UcKhachHang();
                _UcKH.Dock = DockStyle.Fill;
                PnlMain.Controls.Add(_UcKH);
                _UcKH.BringToFront();
            }
            else
            {
                _UcKH.BringToFront();
            }
        }
        private void NV_Click(object sender, EventArgs e)
        {
            if (_UcNV == null)
            {
                _UcNV = new UcNhanVien();
                _UcNV.Dock = DockStyle.Fill;
                PnlMain.Controls.Add(_UcNV);
                _UcNV.BringToFront();
            }
            else
            {
                _UcNV.BringToFront();
            }
        }
        /*private void TKKhachHang_Click(object sender, EventArgs e)
        {
            if (_UcTKKhachHang == null)
            {
                _UcTKKhachHang = new UcTKKhachHang();
                _UcTKKhachHang.Dock = DockStyle.Fill;
                PnlMain.Controls.Add(_UcTKKhachHang);
                _UcTKKhachHang.BringToFront();
            }
            else
            {
                _UcTKKhachHang.BringToFront();
            }
        }
        */
        private void TKDoanhThu_Click(object sender, EventArgs e)
        {
            if (_UcDT == null)
            {
                _UcDT = new UcTKBanHang();
                _UcDT.Dock = DockStyle.Fill;
                PnlMain.Controls.Add(_UcDT);
                _UcDT.BringToFront();
            }
            else
            {
                _UcDT.BringToFront();
            }
        }

        private void TKHangTon_Click(object sender, EventArgs e)
        {

        }

        private void QLNhapHang_Click(object sender, EventArgs e)
        {
            if (_UcQLNhapHang == null)
            {
                _UcQLNhapHang = new UcQLNhapHang();
                _UcQLNhapHang.Dock = DockStyle.Fill;
                PnlMain.Controls.Add(_UcQLNhapHang);
                _UcQLNhapHang.BringToFront();
            }
            else
            {
                _UcQLNhapHang.BringToFront();
            }
        }

        private void QLMaGiamGia_Click(object sender, EventArgs e)
        {
            if (_UcMGG == null)
            {
                _UcMGG = new UcQLMaGiamGia();
                _UcMGG.Dock = DockStyle.Fill;
                PnlMain.Controls.Add(_UcMGG);
                _UcMGG.BringToFront();
            }
            else
            {
                _UcMGG.BringToFront();
            }
        }

        private void DangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.ShowDialog();
        }

        private void DangKy_Click(object sender, EventArgs e)
        {
            if (Session.chucVu == "Quản lý")
            {
                DangKy.Visible = true;
            }
            FrmDangKy f = new FrmDangKy();
            f.ShowDialog();
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Session.tenNV = BsiTenNV.Caption;
            Session.chucVu = BsiChucvu.Caption;
            if (Session.chucVu.Substring(0, 7) == "Quản lý")
            {
                NV.Visible = true;
                DangKy.Visible = true;
            }
        }
    }
}
