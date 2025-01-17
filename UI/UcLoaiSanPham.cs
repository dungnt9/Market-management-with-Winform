﻿using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraExport.Helpers;
using System.Data.SqlClient;

namespace market_management.UI
{
    public partial class UcLoaiSanPham : DevExpress.XtraEditors.XtraUserControl
    {
        public UcLoaiSanPham()
        {
            InitializeComponent();
            LoadData();
            HienThiTenLoaiSP();
            CbeTenLoaiSP.Text = "";
            LbcMaLoaiSP.Text = "";
            CmbTrangThai.Text = "";
        }
        DataAccess dataAccess = new DataAccess();
        void LoadData()
        {
            string stringQuery = "SELECT " +
                "MaLoaiSP as 'Mã loại sản phẩm'," +
                "TenLoaiSP as 'Tên loại sản phẩm'," +
                "CASE " +
                "   WHEN TrangThai = 1 THEN 'Đang kinh doanh'" +
                "   WHEN TrangThai = 0 THEN 'Không còn kinh doanh'" +
                "   ELSE 'NULL'" +
                "END AS 'Trạng thái'" +
                " FROM LOAI_SAN_PHAM;";
            GcLoaiSP.DataSource = dataAccess.GetDataTable(stringQuery);
            DataTable dataTable = dataAccess.GetDataTable(stringQuery);
        }
        private void BbiThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmThemLoaiSP frmThemLoaiSP = new FrmThemLoaiSP();
            frmThemLoaiSP.ShowDialog();
        }

        public void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var maLoaiSP = gridView1.GetRowCellValue(e.FocusedRowHandle, "Mã loại sản phẩm").ToString();
            var tenLoaiSP = gridView1.GetRowCellValue(e.FocusedRowHandle, "Tên loại sản phẩm").ToString();
            var trangThai = gridView1.GetRowCellValue(e.FocusedRowHandle, "Trạng thái").ToString();

            CbeTenLoaiSP.Text = tenLoaiSP;
            LbcMaLoaiSP.Text = maLoaiSP;
            CmbTrangThai.Text = trangThai;
        }

        private void BbiSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            var tenLoaiSP = CbeTenLoaiSP.Text;
            var maLoaiSP = LbcMaLoaiSP.Text;
            var trangThai = CmbTrangThai.Text;

            if (string.IsNullOrEmpty(tenLoaiSP) || string.IsNullOrEmpty(trangThai))
            {
                XtraMessageBox.Show("Vui lòng chọn loại sản phẩm cần cập nhật và nhập thông tin mới", "Thông báo");
                return;
            }

            var sqlUpdate = $"UPDATE LOAI_SAN_PHAM\r\n" +
                 $"SET TenLoaiSP = N'{tenLoaiSP}', " +
                 $"TrangThai = ";

            if (trangThai == "Đang kinh doanh")
            {
                sqlUpdate += "1";
            }
            else if (trangThai == "Không còn kinh doanh")
            {
                sqlUpdate += "0";
            }
            else
            {
                sqlUpdate += "NULL"; 
            }

            sqlUpdate += $"\r\nWHERE MaLoaiSP = '{maLoaiSP}'";


            try
            {
                dataAccess.UpdateData(sqlUpdate);
                XtraMessageBox.Show("Cập nhật loại sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Lỗi cập nhật loại sản phẩm: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BbiLamMoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
            CbeTenLoaiSP.Text = "";
            LbcMaLoaiSP.Text = "";
            CmbTrangThai.Text = "";
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
                dataAccess.objConnection.Close();
            }
            return TenLoaiSP;
        }

        private void HienThiTenLoaiSP()
        {
            List<string> TenLoaiSP = LayTenLoaiSP();
            CbeTenLoaiSP.Properties.Items.AddRange(TenLoaiSP);

            CbeTenLoaiSP.Properties.AutoComplete = true;
            CbeTenLoaiSP.Properties.CaseSensitiveSearch = false;
        }

        private void UcLoaiSanPham_Load(object sender, EventArgs e)
        {
            
        }

        private void bsiRecordsCount_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void CbeMaLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BbiThem_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            FrmThemLoaiSP frmThemLoaiSP = new FrmThemLoaiSP();
            frmThemLoaiSP.ShowDialog();
        }

        private void BbiSua_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            var tenLoaiSP = CbeTenLoaiSP.Text;
            var maLoaiSP = LbcMaLoaiSP.Text;
            var trangThai = CmbTrangThai.Text;

            if (string.IsNullOrEmpty(tenLoaiSP) || string.IsNullOrEmpty(trangThai))
            {
                XtraMessageBox.Show("Vui lòng chọn loại sản phẩm cần cập nhật và nhập thông tin mới", "Thông báo");
                return;
            }

            var sqlUpdate = $"UPDATE LOAI_SAN_PHAM\r\n" +
                 $"SET TenLoaiSP = N'{tenLoaiSP}', " +
                 $"TrangThai = ";

            if (trangThai == "Đang kinh doanh")
            {
                sqlUpdate += "1";
            }
            else if (trangThai == "Không còn kinh doanh")
            {
                sqlUpdate += "0";
            }
            else
            {
                sqlUpdate += "NULL";
            }

            sqlUpdate += $"\r\nWHERE MaLoaiSP = '{maLoaiSP}'";


            try
            {
                dataAccess.UpdateData(sqlUpdate);
                XtraMessageBox.Show("Cập nhật loại sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                CbeTenLoaiSP.Text = "";
                LbcMaLoaiSP.Text = "";
                CmbTrangThai.Text = "";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Lỗi cập nhật loại sản phẩm: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
