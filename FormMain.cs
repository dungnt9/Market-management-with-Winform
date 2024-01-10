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
        DataAccess dataAccess = new DataAccess();

        UcLoaiSanPham _UcLSP; 
        UcSanPham _UcSP;
        UcQLNhapHang _UcQLNhapHang;
        UcKhachHang _UcKH;
        UcNhanVien _UcNV;
        UcNhaCungCap _UcNhaCungCap;
        UcQLBanHang _UcQLBanHang;
        UcTKHangTonKho _UcTKHangTonKho;
        UcTKLoaiSPDaBan _UcTKLoaiSPDaBan;
        UcTKSPDaBan _UcTKSPDaBan;
        UcQLMaGiamGia _UcMGG;
        UcTKDoanhThuBanHang _UcTKDoanhThuBanHang;
        UcTKTongTienNhap _UcTKTongTienNhap;
        UcChucVu _UcChucVu;
        public FormMain()
        {
            InitializeComponent();
        }
        public int MaNV { get; set; }


        public void LoadNhanVienData()
        {
            string query = "SELECT TenNV, ChucVu FROM NHAN_VIEN WHERE NHAN_VIEN.MaNV = @MaNV";

            using (SqlCommand cmd = new SqlCommand(query, dataAccess.objConnection))
            {
                dataAccess.objConnection.Open();

                cmd.Parameters.AddWithValue("@MaNV", MaNV);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        BsiTenNV.Caption = reader["TenNV"].ToString();
                        Session.tenNV = BsiTenNV.Caption;
                        BsiChucvu.Caption = reader["ChucVu"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No data found.");
                    }
                }
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
        

        private void TKHangTon_Click(object sender, EventArgs e)
        {
            if (_UcTKHangTonKho == null)
            {
                _UcTKHangTonKho = new UcTKHangTonKho();
                _UcTKHangTonKho.Dock = DockStyle.Fill;
                PnlMain.Controls.Add(_UcTKHangTonKho);
                _UcTKHangTonKho.BringToFront();
            }
            else
            {
                _UcTKHangTonKho.BringToFront();
            }
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
        
        
        private void QLBanHang_Click(object sender, EventArgs e)
        {
            if (_UcQLBanHang == null)
            {
                _UcQLBanHang = new UcQLBanHang();
                _UcQLBanHang.Dock = DockStyle.Fill;
                PnlMain.Controls.Add(_UcQLBanHang);
                _UcQLBanHang.BringToFront();
            }
            else
            {
                _UcQLBanHang.BringToFront();
            }
        }

        private void NCC_Click(object sender, EventArgs e)
        {
            if (_UcNhaCungCap == null)
            {
                _UcNhaCungCap = new UcNhaCungCap();
                _UcNhaCungCap.Dock = DockStyle.Fill;
                PnlMain.Controls.Add(_UcNhaCungCap);
                _UcNhaCungCap.BringToFront();
            }
            else
            {
                _UcNhaCungCap.BringToFront();
            }
        }

        

        private void TKLoaiSPDaBan_Click(object sender, EventArgs e)
        {
            if (_UcTKLoaiSPDaBan == null)
            {
                _UcTKLoaiSPDaBan = new UcTKLoaiSPDaBan();
                _UcTKLoaiSPDaBan.Dock = DockStyle.Fill;
                PnlMain.Controls.Add(_UcTKLoaiSPDaBan);
                _UcTKLoaiSPDaBan.BringToFront();
            }
            else
            {
                _UcTKLoaiSPDaBan.BringToFront();
            }
        }

        private void TKSPDaBan_Click(object sender, EventArgs e)
        {
            if (_UcTKSPDaBan == null)
            {
                _UcTKSPDaBan = new UcTKSPDaBan();
                _UcTKSPDaBan.Dock = DockStyle.Fill;
                PnlMain.Controls.Add(_UcTKSPDaBan);
                _UcTKSPDaBan.BringToFront();
            }
            else
            {
                _UcTKSPDaBan.BringToFront();
            }
        }

        private void DangKy_Click(object sender, EventArgs e)
        {
            if (Session.chucVu == true)
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
            //Session.chucVu = BsiChucvu.Caption;
            //if (Session.chucVu.Substring(0, 7) == "Quản lý")
            //{
            //    NV.Visible = true;
            //    DangKy.Visible = true;
            //}
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {

        }

        private void KH_Click_1(object sender, EventArgs e)
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

        private void NCC_Click_1(object sender, EventArgs e)
        {
            if (_UcNhaCungCap == null)
            {
                _UcNhaCungCap = new UcNhaCungCap();
                _UcNhaCungCap.Dock = DockStyle.Fill;
                PnlMain.Controls.Add(_UcNhaCungCap);
                _UcNhaCungCap.BringToFront();
            }
            else
            {
                _UcKH.BringToFront();
            }
        }

        private void LoaiSP_Click_1(object sender, EventArgs e)
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

        private void NV_Click_1(object sender, EventArgs e)
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

        private void TKDoanhThuBanHang_Click(object sender, EventArgs e)
        {
            if (_UcTKDoanhThuBanHang == null)
            {
                _UcTKDoanhThuBanHang = new UcTKDoanhThuBanHang();
                _UcTKDoanhThuBanHang.Dock = DockStyle.Fill;
                PnlMain.Controls.Add(_UcTKDoanhThuBanHang);
                _UcTKDoanhThuBanHang.BringToFront();
            }
            else
            {
                _UcTKDoanhThuBanHang.BringToFront();
            }
        }

        private void TKTongTienNhap_Click(object sender, EventArgs e)
        {
            
            if (_UcTKTongTienNhap == null)
            {
                _UcTKTongTienNhap = new UcTKTongTienNhap();
                _UcTKTongTienNhap.Dock = DockStyle.Fill;
                PnlMain.Controls.Add(_UcTKTongTienNhap);
                _UcTKTongTienNhap.BringToFront();
            }
            else
            {
                _UcTKTongTienNhap.BringToFront();
            }
        }

        private void ChucVu_Click_1(object sender, EventArgs e)
        {
            if (_UcChucVu == null)
            {
                _UcChucVu = new UcChucVu();
                _UcChucVu.Dock = DockStyle.Fill;
                PnlMain.Controls.Add(_UcChucVu);
                _UcChucVu.BringToFront();
            }
            else
            {
                _UcChucVu.BringToFront();
            }
        }
    }
}
