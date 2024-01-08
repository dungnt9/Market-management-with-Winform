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
        UcTKKhachHang _UcTKKhachHang;
        UcQLNhapHang _UcQLNhapHang;
        UcKhachHang _UcKH;
        UcNhanVien _UcNV;
        UcNhaCungCap _UcNhaCungCap;
        UcDoanhThu _UcDT;
        UcQLBanHang _UcQLBanHang;
        UcTKHangTonKho _UcTKHangTonKho;

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
        private void TKKhachHang_Click(object sender, EventArgs e)
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

        private void TKDoanhThu_Click(object sender, EventArgs e)
        {
            if (_UcDT == null)
            {
                _UcDT = new UcDoanhThu();
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

        }

        private void DangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.ShowDialog();

        }

        private void DangKy_Click(object sender, EventArgs e)
        {
            FrmDangKy frmDangKy = new FrmDangKy();
            frmDangKy.ShowDialog();
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
    }
}
