using DevExpress.XtraBars;
using market_management.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace market_management
{
    public partial class FormMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {


        UcLoaiSanPham _UcLoaiSanPham;
        UcSanPham _UcSanPham;
        UcTKKhachHang _UcTKKhachHang;
        UcQLNhapHang _UcQLNhapHang;

        public FormMain()
        {
            InitializeComponent();
        }


        private void LoaiSP_Click(object sender, EventArgs e)
        {
            if (_UcLoaiSanPham == null)
            {
                _UcLoaiSanPham = new UcLoaiSanPham();
                _UcLoaiSanPham.Dock = DockStyle.Fill;
                PnlMain.Controls.Add(_UcLoaiSanPham);
                _UcLoaiSanPham.BringToFront();
            }
            else
            {
                _UcLoaiSanPham.BringToFront();
            }
        }

        private void SP_Click(object sender, EventArgs e)
        {
            if (_UcSanPham == null)
            {
                _UcSanPham = new UcSanPham();
                _UcSanPham.Dock = DockStyle.Fill;
                PnlMain.Controls.Add(_UcSanPham);
                _UcSanPham.BringToFront();
            }
            else
            {
                _UcSanPham.BringToFront();
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

        }
    }
}
