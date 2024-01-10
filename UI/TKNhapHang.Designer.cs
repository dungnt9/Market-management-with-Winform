﻿namespace market_management.UI
{
    partial class TKNhapHang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            this.LbBieuDo = new DevExpress.XtraEditors.LabelControl();
            this.GcNhapHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LbNam = new DevExpress.XtraEditors.LabelControl();
            this.CbeNam = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LbDoanhThu = new DevExpress.XtraEditors.LabelControl();
            this.CcBanHang = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.GcNhapHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbeNam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CcBanHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            this.SuspendLayout();
            // 
            // LbBieuDo
            // 
            this.LbBieuDo.Location = new System.Drawing.Point(473, 223);
            this.LbBieuDo.Name = "LbBieuDo";
            this.LbBieuDo.Size = new System.Drawing.Size(264, 13);
            this.LbBieuDo.TabIndex = 22;
            this.LbBieuDo.Text = "Biểu đồ thống kê tiền nhập hàng từng tháng trong năm";
            // 
            // GcNhapHang
            // 
            this.GcNhapHang.Location = new System.Drawing.Point(0, 251);
            this.GcNhapHang.MainView = this.gridView1;
            this.GcNhapHang.Name = "GcNhapHang";
            this.GcNhapHang.Size = new System.Drawing.Size(800, 336);
            this.GcNhapHang.TabIndex = 21;
            this.GcNhapHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GcNhapHang;
            this.gridView1.Name = "gridView1";
            // 
            // LbNam
            // 
            this.LbNam.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LbNam.Appearance.Options.UseFont = true;
            this.LbNam.Location = new System.Drawing.Point(38, 112);
            this.LbNam.Name = "LbNam";
            this.LbNam.Size = new System.Drawing.Size(28, 17);
            this.LbNam.TabIndex = 20;
            this.LbNam.Text = "Năm";
            // 
            // CbeNam
            // 
            this.CbeNam.EditValue = "2024";
            this.CbeNam.Location = new System.Drawing.Point(86, 109);
            this.CbeNam.Name = "CbeNam";
            this.CbeNam.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbeNam.Properties.Appearance.Options.UseFont = true;
            this.CbeNam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbeNam.Size = new System.Drawing.Size(100, 24);
            this.CbeNam.TabIndex = 19;
            // 
            // LbDoanhThu
            // 
            this.LbDoanhThu.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LbDoanhThu.Appearance.Options.UseFont = true;
            this.LbDoanhThu.Location = new System.Drawing.Point(18, 14);
            this.LbDoanhThu.Name = "LbDoanhThu";
            this.LbDoanhThu.Size = new System.Drawing.Size(232, 32);
            this.LbDoanhThu.TabIndex = 18;
            this.LbDoanhThu.Text = "Thống Kê Nhập Hàng";
            // 
            // CcBanHang
            // 
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.CcBanHang.Diagram = xyDiagram2;
            this.CcBanHang.Legend.LegendID = -1;
            this.CcBanHang.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.CcBanHang.Location = new System.Drawing.Point(449, 14);
            this.CcBanHang.Name = "CcBanHang";
            series2.ArgumentDataMember = "Tháng";
            series2.Name = "Series 2";
            series2.SeriesID = 1;
            series2.ValueDataMembersSerializable = "Tổng Tiền Bán";
            this.CcBanHang.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.CcBanHang.Size = new System.Drawing.Size(306, 196);
            this.CcBanHang.TabIndex = 17;
            // 
            // TKNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LbBieuDo);
            this.Controls.Add(this.GcNhapHang);
            this.Controls.Add(this.LbNam);
            this.Controls.Add(this.CbeNam);
            this.Controls.Add(this.LbDoanhThu);
            this.Controls.Add(this.CcBanHang);
            this.Name = "TKNhapHang";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.GcNhapHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbeNam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CcBanHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LbBieuDo;
        private DevExpress.XtraGrid.GridControl GcNhapHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl LbNam;
        private DevExpress.XtraEditors.ComboBoxEdit CbeNam;
        private DevExpress.XtraEditors.LabelControl LbDoanhThu;
        private DevExpress.XtraCharts.ChartControl CcBanHang;
    }
}