using DevExpress.XtraGrid;
using System.Windows.Forms;

namespace market_management
{
    partial class UcTKDoanhThuBanHang
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            this.CcBanHang = new DevExpress.XtraCharts.ChartControl();
            this.LbDoanhThuBanHang = new DevExpress.XtraEditors.LabelControl();
            this.CbeNam = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LbNam = new DevExpress.XtraEditors.LabelControl();
            this.GcBanHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LbBieuDo = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.CcBanHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbeNam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcBanHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CcBanHang
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.CcBanHang.Diagram = xyDiagram1;
            this.CcBanHang.Legend.LegendID = -1;
            this.CcBanHang.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.CcBanHang.Location = new System.Drawing.Point(449, 24);
            this.CcBanHang.Name = "CcBanHang";
            series1.ArgumentDataMember = "Tháng";
            series1.Name = "Series 2";
            series1.SeriesID = 1;
            series1.ValueDataMembersSerializable = "Tổng Tiền Bán";
            this.CcBanHang.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.CcBanHang.Size = new System.Drawing.Size(306, 196);
            this.CcBanHang.TabIndex = 4;
            // 
            // LbDoanhThuBanHang
            // 
            this.LbDoanhThuBanHang.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LbDoanhThuBanHang.Appearance.Options.UseFont = true;
            this.LbDoanhThuBanHang.Location = new System.Drawing.Point(18, 24);
            this.LbDoanhThuBanHang.Name = "LbDoanhThuBanHang";
            this.LbDoanhThuBanHang.Size = new System.Drawing.Size(340, 32);
            this.LbDoanhThuBanHang.TabIndex = 6;
            this.LbDoanhThuBanHang.Text = "Thống Kê Doanh Thu Bán Hàng";
            // 
            // CbeNam
            // 
            this.CbeNam.EditValue = "2024";
            this.CbeNam.Location = new System.Drawing.Point(86, 119);
            this.CbeNam.Name = "CbeNam";
            this.CbeNam.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbeNam.Properties.Appearance.Options.UseFont = true;
            this.CbeNam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbeNam.Size = new System.Drawing.Size(100, 26);
            this.CbeNam.TabIndex = 7;
            this.CbeNam.SelectedIndexChanged += new System.EventHandler(this.CbeNam_SelectedIndexChanged);
            this.CbeNam.SelectedValueChanged += new System.EventHandler(this.CbeNam_SelectedValueChanged);
            // 
            // LbNam
            // 
            this.LbNam.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNam.Appearance.Options.UseFont = true;
            this.LbNam.Location = new System.Drawing.Point(38, 122);
            this.LbNam.Name = "LbNam";
            this.LbNam.Size = new System.Drawing.Size(32, 20);
            this.LbNam.TabIndex = 9;
            this.LbNam.Text = "Năm";
            // 
            // GcBanHang
            // 
            this.GcBanHang.Location = new System.Drawing.Point(0, 261);
            this.GcBanHang.MainView = this.gridView1;
            this.GcBanHang.Name = "GcBanHang";
            this.GcBanHang.Size = new System.Drawing.Size(870, 399);
            this.GcBanHang.TabIndex = 15;
            this.GcBanHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GcBanHang;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // LbBieuDo
            // 
            this.LbBieuDo.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbBieuDo.Appearance.Options.UseFont = true;
            this.LbBieuDo.Location = new System.Drawing.Point(425, 226);
            this.LbBieuDo.Name = "LbBieuDo";
            this.LbBieuDo.Size = new System.Drawing.Size(358, 20);
            this.LbBieuDo.TabIndex = 16;
            this.LbBieuDo.Text = "Biểu đồ thống kê tiền bán hàng từng tháng trong năm";
            // 
            // UcTKDoanhThuBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LbBieuDo);
            this.Controls.Add(this.GcBanHang);
            this.Controls.Add(this.LbNam);
            this.Controls.Add(this.CbeNam);
            this.Controls.Add(this.LbDoanhThuBanHang);
            this.Controls.Add(this.CcBanHang);
            this.Name = "UcTKDoanhThuBanHang";
            this.Size = new System.Drawing.Size(870, 660);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CcBanHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbeNam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcBanHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraCharts.ChartControl CcBanHang;
        private DevExpress.XtraEditors.LabelControl LbDoanhThuBanHang;
        private DevExpress.XtraEditors.ComboBoxEdit CbeNam;
        private DevExpress.XtraEditors.LabelControl LbNam;
        private DevExpress.XtraGrid.GridControl GcBanHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl LbBieuDo;
    }
}
