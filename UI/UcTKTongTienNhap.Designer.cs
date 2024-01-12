namespace market_management.UI
{
    partial class UcTKTongTienNhap
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
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            this.SuspendLayout();
            // 
            // LbBieuDo
            // 
            this.LbBieuDo.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbBieuDo.Appearance.Options.UseFont = true;
            this.LbBieuDo.Location = new System.Drawing.Point(490, 266);
            this.LbBieuDo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LbBieuDo.Name = "LbBieuDo";
            this.LbBieuDo.Size = new System.Drawing.Size(467, 25);
            this.LbBieuDo.TabIndex = 22;
            this.LbBieuDo.Text = "Biểu đồ thống kê tiền nhập hàng từng tháng trong năm";
            // 
            // GcNhapHang
            // 
            this.GcNhapHang.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GcNhapHang.Location = new System.Drawing.Point(4, 322);
            this.GcNhapHang.MainView = this.gridView1;
            this.GcNhapHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GcNhapHang.Name = "GcNhapHang";
            this.GcNhapHang.Size = new System.Drawing.Size(1008, 486);
            this.GcNhapHang.TabIndex = 21;
            this.GcNhapHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.GcNhapHang;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 933;
            // 
            // LbNam
            // 
            this.LbNam.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNam.Appearance.Options.UseFont = true;
            this.LbNam.Location = new System.Drawing.Point(44, 138);
            this.LbNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LbNam.Name = "LbNam";
            this.LbNam.Size = new System.Drawing.Size(40, 25);
            this.LbNam.TabIndex = 20;
            this.LbNam.Text = "Năm";
            // 
            // CbeNam
            // 
            this.CbeNam.EditValue = "2024";
            this.CbeNam.Location = new System.Drawing.Point(100, 134);
            this.CbeNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbeNam.Name = "CbeNam";
            this.CbeNam.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbeNam.Properties.Appearance.Options.UseFont = true;
            this.CbeNam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbeNam.Size = new System.Drawing.Size(117, 32);
            this.CbeNam.TabIndex = 19;
            this.CbeNam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbeNam_KeyPress);
            // 
            // LbDoanhThu
            // 
            this.LbDoanhThu.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LbDoanhThu.Appearance.Options.UseFont = true;
            this.LbDoanhThu.Location = new System.Drawing.Point(21, 39);
            this.LbDoanhThu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LbDoanhThu.Name = "LbDoanhThu";
            this.LbDoanhThu.Size = new System.Drawing.Size(427, 41);
            this.LbDoanhThu.TabIndex = 18;
            this.LbDoanhThu.Text = "Thống Kê Tổng Tiền Nhập Hàng";
            // 
            // CcBanHang
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.CcBanHang.Diagram = xyDiagram1;
            this.CcBanHang.Legend.LegendID = -1;
            this.CcBanHang.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.CcBanHang.Location = new System.Drawing.Point(524, 17);
            this.CcBanHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CcBanHang.Name = "CcBanHang";
            series1.ArgumentDataMember = "Tháng";
            series1.Name = "Series 2";
            series1.SeriesID = 1;
            series1.ValueDataMembersSerializable = "Tổng Tiền Bán";
            this.CcBanHang.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.CcBanHang.Size = new System.Drawing.Size(357, 241);
            this.CcBanHang.TabIndex = 17;
            // 
            // UcTKTongTienNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LbBieuDo);
            this.Controls.Add(this.GcNhapHang);
            this.Controls.Add(this.LbNam);
            this.Controls.Add(this.CbeNam);
            this.Controls.Add(this.LbDoanhThu);
            this.Controls.Add(this.CcBanHang);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UcTKTongTienNhap";
            this.Size = new System.Drawing.Size(1015, 812);
            ((System.ComponentModel.ISupportInitialize)(this.GcNhapHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbeNam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
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
