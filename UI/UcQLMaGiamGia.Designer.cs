namespace market_management.UI
{
    partial class UcQLMaGiamGia
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
            this.GcMaGiamGia = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RcMGG = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.BbiThemMoi = new DevExpress.XtraBars.BarButtonItem();
            this.BbiSua = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.BbiLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.RpQLMaGiamGia = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.RpgTacVuMGG = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.CbePhanTram = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LbNgayTao = new DevExpress.XtraEditors.LabelControl();
            this.LbPhanTram = new DevExpress.XtraEditors.LabelControl();
            this.TeTenChuongTrinh = new DevExpress.XtraEditors.TextEdit();
            this.LbTenChuongTrinh = new DevExpress.XtraEditors.LabelControl();
            this.TeMaGiamGia = new DevExpress.XtraEditors.TextEdit();
            this.LbMaGiamGia = new DevExpress.XtraEditors.LabelControl();
            this.DeNgayTao = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.GcMaGiamGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RcMGG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbePhanTram.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeTenChuongTrinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMaGiamGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeNgayTao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeNgayTao.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // GcMaGiamGia
            // 
            this.GcMaGiamGia.Location = new System.Drawing.Point(0, 242);
            this.GcMaGiamGia.MainView = this.gridView;
            this.GcMaGiamGia.MenuManager = this.RcMGG;
            this.GcMaGiamGia.Name = "GcMaGiamGia";
            this.GcMaGiamGia.Size = new System.Drawing.Size(800, 358);
            this.GcMaGiamGia.TabIndex = 2;
            this.GcMaGiamGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.GridControl = this.GcMaGiamGia;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            // 
            // RcMGG
            // 
            this.RcMGG.ExpandCollapseItem.Id = 0;
            this.RcMGG.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.RcMGG.ExpandCollapseItem,
            this.bbiPrintPreview,
            this.bsiRecordsCount,
            this.BbiThemMoi,
            this.BbiSua,
            this.bbiDelete,
            this.BbiLamMoi});
            this.RcMGG.Location = new System.Drawing.Point(0, 0);
            this.RcMGG.MaxItemId = 21;
            this.RcMGG.Name = "RcMGG";
            this.RcMGG.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.RpQLMaGiamGia});
            this.RcMGG.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.RcMGG.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.RcMGG.Size = new System.Drawing.Size(800, 126);
            this.RcMGG.StatusBar = this.ribbonStatusBar;
            this.RcMGG.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Id = 20;
            this.bbiPrintPreview.Name = "bbiPrintPreview";
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            // 
            // BbiThemMoi
            // 
            this.BbiThemMoi.Caption = "Thêm mới";
            this.BbiThemMoi.Id = 16;
            this.BbiThemMoi.ImageOptions.ImageUri.Uri = "New";
            this.BbiThemMoi.Name = "BbiThemMoi";
            // 
            // BbiSua
            // 
            this.BbiSua.Caption = "Sửa";
            this.BbiSua.Id = 17;
            this.BbiSua.ImageOptions.ImageUri.Uri = "Edit";
            this.BbiSua.Name = "BbiSua";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 18;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            // 
            // BbiLamMoi
            // 
            this.BbiLamMoi.Caption = "Làm mới";
            this.BbiLamMoi.Id = 19;
            this.BbiLamMoi.ImageOptions.ImageUri.Uri = "Refresh";
            this.BbiLamMoi.Name = "BbiLamMoi";
            // 
            // RpQLMaGiamGia
            // 
            this.RpQLMaGiamGia.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.RpgTacVuMGG});
            this.RpQLMaGiamGia.MergeOrder = 0;
            this.RpQLMaGiamGia.Name = "RpQLMaGiamGia";
            this.RpQLMaGiamGia.Text = "Mã giảm giá";
            // 
            // RpgTacVuMGG
            // 
            this.RpgTacVuMGG.AllowTextClipping = false;
            this.RpgTacVuMGG.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.RpgTacVuMGG.ItemLinks.Add(this.BbiThemMoi);
            this.RpgTacVuMGG.ItemLinks.Add(this.BbiSua);
            this.RpgTacVuMGG.ItemLinks.Add(this.BbiLamMoi);
            this.RpgTacVuMGG.Name = "RpgTacVuMGG";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 573);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.RcMGG;
            this.ribbonStatusBar.Size = new System.Drawing.Size(800, 27);
            // 
            // CbePhanTram
            // 
            this.CbePhanTram.Location = new System.Drawing.Point(499, 158);
            this.CbePhanTram.Name = "CbePhanTram";
            this.CbePhanTram.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbePhanTram.Properties.Appearance.Options.UseFont = true;
            this.CbePhanTram.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbePhanTram.Size = new System.Drawing.Size(122, 22);
            this.CbePhanTram.TabIndex = 48;
            // 
            // LbNgayTao
            // 
            this.LbNgayTao.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNgayTao.Appearance.Options.UseFont = true;
            this.LbNgayTao.Location = new System.Drawing.Point(414, 215);
            this.LbNgayTao.Name = "LbNgayTao";
            this.LbNgayTao.Size = new System.Drawing.Size(50, 15);
            this.LbNgayTao.TabIndex = 42;
            this.LbNgayTao.Text = "Ngày Tạo";
            // 
            // LbPhanTram
            // 
            this.LbPhanTram.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPhanTram.Appearance.Options.UseFont = true;
            this.LbPhanTram.Location = new System.Drawing.Point(414, 159);
            this.LbPhanTram.Name = "LbPhanTram";
            this.LbPhanTram.Size = new System.Drawing.Size(56, 15);
            this.LbPhanTram.TabIndex = 41;
            this.LbPhanTram.Text = "Phần Trăm";
            // 
            // TeTenChuongTrinh
            // 
            this.TeTenChuongTrinh.Location = new System.Drawing.Point(265, 214);
            this.TeTenChuongTrinh.Name = "TeTenChuongTrinh";
            this.TeTenChuongTrinh.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeTenChuongTrinh.Properties.Appearance.Options.UseFont = true;
            this.TeTenChuongTrinh.Size = new System.Drawing.Size(128, 22);
            this.TeTenChuongTrinh.TabIndex = 40;
            // 
            // LbTenChuongTrinh
            // 
            this.LbTenChuongTrinh.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTenChuongTrinh.Appearance.Options.UseFont = true;
            this.LbTenChuongTrinh.Location = new System.Drawing.Point(158, 215);
            this.LbTenChuongTrinh.Name = "LbTenChuongTrinh";
            this.LbTenChuongTrinh.Size = new System.Drawing.Size(95, 15);
            this.LbTenChuongTrinh.TabIndex = 39;
            this.LbTenChuongTrinh.Text = "Tên Chương Trình";
            // 
            // TeMaGiamGia
            // 
            this.TeMaGiamGia.Location = new System.Drawing.Point(265, 158);
            this.TeMaGiamGia.Name = "TeMaGiamGia";
            this.TeMaGiamGia.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeMaGiamGia.Properties.Appearance.Options.UseFont = true;
            this.TeMaGiamGia.Size = new System.Drawing.Size(128, 22);
            this.TeMaGiamGia.TabIndex = 38;
            // 
            // LbMaGiamGia
            // 
            this.LbMaGiamGia.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMaGiamGia.Appearance.Options.UseFont = true;
            this.LbMaGiamGia.Location = new System.Drawing.Point(158, 159);
            this.LbMaGiamGia.Name = "LbMaGiamGia";
            this.LbMaGiamGia.Size = new System.Drawing.Size(68, 15);
            this.LbMaGiamGia.TabIndex = 37;
            this.LbMaGiamGia.Text = "Mã Giảm Giá";
            // 
            // DeNgayTao
            // 
            this.DeNgayTao.EditValue = null;
            this.DeNgayTao.Location = new System.Drawing.Point(499, 215);
            this.DeNgayTao.MenuManager = this.RcMGG;
            this.DeNgayTao.Name = "DeNgayTao";
            this.DeNgayTao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DeNgayTao.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DeNgayTao.Size = new System.Drawing.Size(122, 20);
            this.DeNgayTao.TabIndex = 51;
            // 
            // UcQLMaGiamGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeNgayTao);
            this.Controls.Add(this.CbePhanTram);
            this.Controls.Add(this.LbNgayTao);
            this.Controls.Add(this.LbPhanTram);
            this.Controls.Add(this.TeTenChuongTrinh);
            this.Controls.Add(this.LbTenChuongTrinh);
            this.Controls.Add(this.TeMaGiamGia);
            this.Controls.Add(this.LbMaGiamGia);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.GcMaGiamGia);
            this.Controls.Add(this.RcMGG);
            this.Name = "UcQLMaGiamGia";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.GcMaGiamGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RcMGG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbePhanTram.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeTenChuongTrinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMaGiamGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeNgayTao.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeNgayTao.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GcMaGiamGia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraBars.Ribbon.RibbonControl RcMGG;
        private DevExpress.XtraBars.Ribbon.RibbonPage RpQLMaGiamGia;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup RpgTacVuMGG;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem BbiThemMoi;
        private DevExpress.XtraBars.BarButtonItem BbiSua;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem BbiLamMoi;
        private DevExpress.XtraEditors.ComboBoxEdit CbePhanTram;
        private DevExpress.XtraEditors.LabelControl LbNgayTao;
        private DevExpress.XtraEditors.LabelControl LbPhanTram;
        private DevExpress.XtraEditors.TextEdit TeTenChuongTrinh;
        private DevExpress.XtraEditors.LabelControl LbTenChuongTrinh;
        private DevExpress.XtraEditors.TextEdit TeMaGiamGia;
        private DevExpress.XtraEditors.LabelControl LbMaGiamGia;
        private DevExpress.XtraEditors.DateEdit DeNgayTao;
    }
}
