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
            DevExpress.XtraCharts.XYDiagram xyDiagram3 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            this.CcBanHang = new DevExpress.XtraCharts.ChartControl();
            this.LbDoanhThuBanHang = new DevExpress.XtraEditors.LabelControl();
            this.CbeNam = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LbNam = new DevExpress.XtraEditors.LabelControl();
            this.GcBanHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LbBieuDo = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.CcBanHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbeNam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcBanHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CcBanHang
            // 
            xyDiagram3.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram3.AxisY.VisibleInPanesSerializable = "-1";
            this.CcBanHang.Diagram = xyDiagram3;
            this.CcBanHang.Legend.LegendID = -1;
            this.CcBanHang.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.CcBanHang.Location = new System.Drawing.Point(524, 30);
            this.CcBanHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CcBanHang.Name = "CcBanHang";
            series3.ArgumentDataMember = "Tháng";
            series3.Name = "Series 2";
            series3.SeriesID = 1;
            series3.ValueDataMembersSerializable = "Tổng Tiền Bán";
            this.CcBanHang.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3};
            this.CcBanHang.Size = new System.Drawing.Size(357, 241);
            this.CcBanHang.TabIndex = 4;
            // 
            // LbDoanhThuBanHang
            // 
            this.LbDoanhThuBanHang.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LbDoanhThuBanHang.Appearance.Options.UseFont = true;
            this.LbDoanhThuBanHang.Location = new System.Drawing.Point(21, 30);
            this.LbDoanhThuBanHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LbDoanhThuBanHang.Name = "LbDoanhThuBanHang";
            this.LbDoanhThuBanHang.Size = new System.Drawing.Size(417, 41);
            this.LbDoanhThuBanHang.TabIndex = 6;
            this.LbDoanhThuBanHang.Text = "Thống Kê Doanh Thu Bán Hàng";
            // 
            // CbeNam
            // 
            this.CbeNam.EditValue = "2024";
            this.CbeNam.Location = new System.Drawing.Point(100, 146);
            this.CbeNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbeNam.Name = "CbeNam";
            this.CbeNam.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbeNam.Properties.Appearance.Options.UseFont = true;
            this.CbeNam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbeNam.Size = new System.Drawing.Size(117, 32);
            this.CbeNam.TabIndex = 7;
            this.CbeNam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbeNam_KeyPress);
            // 
            // LbNam
            // 
            this.LbNam.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNam.Appearance.Options.UseFont = true;
            this.LbNam.Location = new System.Drawing.Point(44, 150);
            this.LbNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LbNam.Name = "LbNam";
            this.LbNam.Size = new System.Drawing.Size(40, 25);
            this.LbNam.TabIndex = 9;
            this.LbNam.Text = "Năm";
            // 
            // GcBanHang
            // 
            this.GcBanHang.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GcBanHang.Location = new System.Drawing.Point(0, 321);
            this.GcBanHang.MainView = this.gridView1;
            this.GcBanHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GcBanHang.Name = "GcBanHang";
            this.GcBanHang.Size = new System.Drawing.Size(1015, 491);
            this.GcBanHang.TabIndex = 15;
            this.GcBanHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.GcBanHang;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 933;
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // LbBieuDo
            // 
            this.LbBieuDo.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbBieuDo.Appearance.Options.UseFont = true;
            this.LbBieuDo.Location = new System.Drawing.Point(496, 278);
            this.LbBieuDo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LbBieuDo.Name = "LbBieuDo";
            this.LbBieuDo.Size = new System.Drawing.Size(456, 25);
            this.LbBieuDo.TabIndex = 16;
            this.LbBieuDo.Text = "Biểu đồ thống kê tiền bán hàng từng tháng trong năm";
            // 
            // UcTKDoanhThuBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LbBieuDo);
            this.Controls.Add(this.GcBanHang);
            this.Controls.Add(this.LbNam);
            this.Controls.Add(this.CbeNam);
            this.Controls.Add(this.LbDoanhThuBanHang);
            this.Controls.Add(this.CcBanHang);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UcTKDoanhThuBanHang";
            this.Size = new System.Drawing.Size(1015, 812);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
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
