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
            this.TeMoTa = new DevExpress.XtraEditors.TextEdit();
            this.LbMoTa = new DevExpress.XtraEditors.LabelControl();
            this.LbTrangThai = new DevExpress.XtraEditors.LabelControl();
            this.RbConHieuLuc = new System.Windows.Forms.RadioButton();
            this.RbHetHan = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.GcMaGiamGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RcMGG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbePhanTram.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeTenChuongTrinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMaGiamGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeNgayTao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeNgayTao.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMoTa.Properties)).BeginInit();
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
            this.BbiThemMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiThemMoi_ItemClick);
            // 
            // BbiSua
            // 
            this.BbiSua.Caption = "Sửa";
            this.BbiSua.Id = 17;
            this.BbiSua.ImageOptions.ImageUri.Uri = "Edit";
            this.BbiSua.Name = "BbiSua";
            this.BbiSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiSua_ItemClick);
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
            this.BbiLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiLamMoi_ItemClick);
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
            this.CbePhanTram.Location = new System.Drawing.Point(382, 152);
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
            this.LbNgayTao.Location = new System.Drawing.Point(297, 209);
            this.LbNgayTao.Name = "LbNgayTao";
            this.LbNgayTao.Size = new System.Drawing.Size(50, 15);
            this.LbNgayTao.TabIndex = 42;
            this.LbNgayTao.Text = "Ngày Tạo";
            // 
            // LbPhanTram
            // 
            this.LbPhanTram.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPhanTram.Appearance.Options.UseFont = true;
            this.LbPhanTram.Location = new System.Drawing.Point(297, 153);
            this.LbPhanTram.Name = "LbPhanTram";
            this.LbPhanTram.Size = new System.Drawing.Size(56, 15);
            this.LbPhanTram.TabIndex = 41;
            this.LbPhanTram.Text = "Phần Trăm";
            // 
            // TeTenChuongTrinh
            // 
            this.TeTenChuongTrinh.Location = new System.Drawing.Point(148, 208);
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
            this.LbTenChuongTrinh.Location = new System.Drawing.Point(41, 209);
            this.LbTenChuongTrinh.Name = "LbTenChuongTrinh";
            this.LbTenChuongTrinh.Size = new System.Drawing.Size(95, 15);
            this.LbTenChuongTrinh.TabIndex = 39;
            this.LbTenChuongTrinh.Text = "Tên Chương Trình";
            // 
            // TeMaGiamGia
            // 
            this.TeMaGiamGia.Location = new System.Drawing.Point(148, 152);
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
            this.LbMaGiamGia.Location = new System.Drawing.Point(41, 153);
            this.LbMaGiamGia.Name = "LbMaGiamGia";
            this.LbMaGiamGia.Size = new System.Drawing.Size(68, 15);
            this.LbMaGiamGia.TabIndex = 37;
            this.LbMaGiamGia.Text = "Mã Giảm Giá";
            // 
            // DeNgayTao
            // 
            this.DeNgayTao.EditValue = null;
            this.DeNgayTao.Location = new System.Drawing.Point(382, 209);
            this.DeNgayTao.MenuManager = this.RcMGG;
            this.DeNgayTao.Name = "DeNgayTao";
            this.DeNgayTao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DeNgayTao.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DeNgayTao.Size = new System.Drawing.Size(122, 20);
            this.DeNgayTao.TabIndex = 51;
            // 
            // TeMoTa
            // 
            this.TeMoTa.Location = new System.Drawing.Point(608, 208);
            this.TeMoTa.Name = "TeMoTa";
            this.TeMoTa.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeMoTa.Properties.Appearance.Options.UseFont = true;
            this.TeMoTa.Size = new System.Drawing.Size(164, 22);
            this.TeMoTa.TabIndex = 57;
            // 
            // LbMoTa
            // 
            this.LbMoTa.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMoTa.Appearance.Options.UseFont = true;
            this.LbMoTa.Location = new System.Drawing.Point(537, 209);
            this.LbMoTa.Name = "LbMoTa";
            this.LbMoTa.Size = new System.Drawing.Size(33, 15);
            this.LbMoTa.TabIndex = 56;
            this.LbMoTa.Text = "Mô Tả";
            // 
            // LbTrangThai
            // 
            this.LbTrangThai.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTrangThai.Appearance.Options.UseFont = true;
            this.LbTrangThai.Location = new System.Drawing.Point(537, 153);
            this.LbTrangThai.Name = "LbTrangThai";
            this.LbTrangThai.Size = new System.Drawing.Size(54, 15);
            this.LbTrangThai.TabIndex = 54;
            this.LbTrangThai.Text = "Trạng Thái";
            // 
            // RbConHieuLuc
            // 
            this.RbConHieuLuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbConHieuLuc.Location = new System.Drawing.Point(608, 150);
            this.RbConHieuLuc.Name = "RbConHieuLuc";
            this.RbConHieuLuc.Size = new System.Drawing.Size(101, 22);
            this.RbConHieuLuc.TabIndex = 61;
            this.RbConHieuLuc.TabStop = true;
            this.RbConHieuLuc.Text = "Còn hiệu lực";
            this.RbConHieuLuc.UseVisualStyleBackColor = true;
            // 
            // RbHetHan
            // 
            this.RbHetHan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbHetHan.Location = new System.Drawing.Point(703, 151);
            this.RbHetHan.Name = "RbHetHan";
            this.RbHetHan.Size = new System.Drawing.Size(83, 20);
            this.RbHetHan.TabIndex = 62;
            this.RbHetHan.TabStop = true;
            this.RbHetHan.Text = "Hết hạn";
            this.RbHetHan.UseVisualStyleBackColor = true;
            // 
            // UcQLMaGiamGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RbHetHan);
            this.Controls.Add(this.RbConHieuLuc);
            this.Controls.Add(this.TeMoTa);
            this.Controls.Add(this.LbMoTa);
            this.Controls.Add(this.LbTrangThai);
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
            ((System.ComponentModel.ISupportInitialize)(this.TeMoTa.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit TeMoTa;
        private DevExpress.XtraEditors.LabelControl LbMoTa;
        private DevExpress.XtraEditors.LabelControl LbTrangThai;
        private System.Windows.Forms.RadioButton RbConHieuLuc;
        private System.Windows.Forms.RadioButton RbHetHan;
    }
}
