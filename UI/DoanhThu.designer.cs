namespace Quản_lý_siêu_thị
{
    partial class DoanhThu
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
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            this.GcDoanhThu = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.LbDoanhThu = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.GcDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GcDoanhThu
            // 
            this.GcDoanhThu.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GcDoanhThu.Location = new System.Drawing.Point(4, 214);
            this.GcDoanhThu.MainView = this.gridView;
            this.GcDoanhThu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GcDoanhThu.Name = "GcDoanhThu";
            this.GcDoanhThu.Size = new System.Drawing.Size(1152, 474);
            this.GcDoanhThu.TabIndex = 3;
            this.GcDoanhThu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.DetailHeight = 431;
            this.gridView.GridControl = this.GcDoanhThu;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.OptionsEditForm.PopupEditFormWidth = 933;
            // 
            // chartControl1
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Legend.LegendID = -1;
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Location = new System.Drawing.Point(755, 30);
            this.chartControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartControl1.Name = "chartControl1";
            series1.Name = "Series 1";
            series1.SeriesID = 0;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(357, 197);
            this.chartControl1.TabIndex = 4;
            // 
            // chartControl2
            // 
            this.chartControl2.Legend.LegendID = -1;
            this.chartControl2.Location = new System.Drawing.Point(320, 30);
            this.chartControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartControl2.Name = "chartControl2";
            series2.Name = "Series 1";
            series2.SeriesID = 0;
            series2.View = pieSeriesView1;
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControl2.Size = new System.Drawing.Size(410, 197);
            this.chartControl2.TabIndex = 5;
            // 
            // LbDoanhThu
            // 
            this.LbDoanhThu.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LbDoanhThu.Appearance.Options.UseFont = true;
            this.LbDoanhThu.Location = new System.Drawing.Point(29, 85);
            this.LbDoanhThu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LbDoanhThu.Name = "LbDoanhThu";
            this.LbDoanhThu.Size = new System.Drawing.Size(281, 41);
            this.LbDoanhThu.TabIndex = 6;
            this.LbDoanhThu.Text = "Thống Kê Doanh Thu";
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LbDoanhThu);
            this.Controls.Add(this.chartControl2);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.GcDoanhThu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DoanhThu";
            this.Size = new System.Drawing.Size(1158, 692);
            ((System.ComponentModel.ISupportInitialize)(this.GcDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GcDoanhThu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private DevExpress.XtraEditors.LabelControl LbDoanhThu;
    }
}
