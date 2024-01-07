namespace Quản_lý_siêu_thị
{
    partial class UcKhachHang
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GcDanhMucKH = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RcDanhMucKH = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.BbiThemMoi = new DevExpress.XtraBars.BarButtonItem();
            this.BbiSua = new DevExpress.XtraBars.BarButtonItem();
            this.BbiXoa = new DevExpress.XtraBars.BarButtonItem();
            this.BbiLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.RpDanhMucKH = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.RbgTacVuKH = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.TeDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.LbDiaChi = new DevExpress.XtraEditors.LabelControl();
            this.TeSDT = new DevExpress.XtraEditors.TextEdit();
            this.LbSDT = new DevExpress.XtraEditors.LabelControl();
            this.LbGioiTinh = new DevExpress.XtraEditors.LabelControl();
            this.LbMaGiamGia = new DevExpress.XtraEditors.LabelControl();
            this.TeTenKH = new DevExpress.XtraEditors.TextEdit();
            this.LbTenKH = new DevExpress.XtraEditors.LabelControl();
            this.TeMaKH = new DevExpress.XtraEditors.TextEdit();
            this.LbMaKH = new DevExpress.XtraEditors.LabelControl();
            this.CbeMaGiamGia = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CbeGioiTinh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.DeNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.LbNgaySinh = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.GcDanhMucKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RcDanhMucKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbeMaGiamGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbeGioiTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // GcDanhMucKH
            // 
            this.GcDanhMucKH.Location = new System.Drawing.Point(0, 279);
            this.GcDanhMucKH.MainView = this.gridView;
            this.GcDanhMucKH.MenuManager = this.RcDanhMucKH;
            this.GcDanhMucKH.Name = "GcDanhMucKH";
            this.GcDanhMucKH.Size = new System.Drawing.Size(800, 321);
            this.GcDanhMucKH.TabIndex = 2;
            this.GcDanhMucKH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.GridControl = this.GcDanhMucKH;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            // 
            // RcDanhMucKH
            // 
            this.RcDanhMucKH.ExpandCollapseItem.Id = 0;
            this.RcDanhMucKH.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.RcDanhMucKH.ExpandCollapseItem,
            this.bbiPrintPreview,
            this.bsiRecordsCount,
            this.BbiThemMoi,
            this.BbiSua,
            this.BbiXoa,
            this.BbiLamMoi});
            this.RcDanhMucKH.Location = new System.Drawing.Point(0, 0);
            this.RcDanhMucKH.MaxItemId = 21;
            this.RcDanhMucKH.Name = "RcDanhMucKH";
            this.RcDanhMucKH.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.RpDanhMucKH});
            this.RcDanhMucKH.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.RcDanhMucKH.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.RcDanhMucKH.Size = new System.Drawing.Size(800, 126);
            this.RcDanhMucKH.StatusBar = this.ribbonStatusBar;
            this.RcDanhMucKH.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
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
            // 
            // BbiXoa
            // 
            this.BbiXoa.Caption = "Xoá";
            this.BbiXoa.Id = 18;
            this.BbiXoa.ImageOptions.ImageUri.Uri = "Delete";
            this.BbiXoa.Name = "BbiXoa";
            // 
            // BbiLamMoi
            // 
            this.BbiLamMoi.Caption = "Làm mới";
            this.BbiLamMoi.Id = 19;
            this.BbiLamMoi.ImageOptions.ImageUri.Uri = "Refresh";
            this.BbiLamMoi.Name = "BbiLamMoi";
            // 
            // RpDanhMucKH
            // 
            this.RpDanhMucKH.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.RpDanhMucKH.Appearance.Options.UseFont = true;
            this.RpDanhMucKH.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.RbgTacVuKH});
            this.RpDanhMucKH.MergeOrder = 0;
            this.RpDanhMucKH.Name = "RpDanhMucKH";
            this.RpDanhMucKH.Text = "Danh mục khách hàng";
            // 
            // RbgTacVuKH
            // 
            this.RbgTacVuKH.AllowTextClipping = false;
            this.RbgTacVuKH.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.RbgTacVuKH.ItemLinks.Add(this.BbiThemMoi);
            this.RbgTacVuKH.ItemLinks.Add(this.BbiSua);
            this.RbgTacVuKH.ItemLinks.Add(this.BbiXoa);
            this.RbgTacVuKH.ItemLinks.Add(this.BbiLamMoi);
            this.RbgTacVuKH.Name = "RbgTacVuKH";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 573);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.RcDanhMucKH;
            this.ribbonStatusBar.Size = new System.Drawing.Size(800, 27);
            // 
            // TeDiaChi
            // 
            this.TeDiaChi.Location = new System.Drawing.Point(603, 138);
            this.TeDiaChi.Name = "TeDiaChi";
            this.TeDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TeDiaChi.Properties.Appearance.Options.UseFont = true;
            this.TeDiaChi.Size = new System.Drawing.Size(144, 22);
            this.TeDiaChi.TabIndex = 50;
            // 
            // LbDiaChi
            // 
            this.LbDiaChi.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LbDiaChi.Appearance.Options.UseFont = true;
            this.LbDiaChi.Location = new System.Drawing.Point(509, 139);
            this.LbDiaChi.Name = "LbDiaChi";
            this.LbDiaChi.Size = new System.Drawing.Size(36, 15);
            this.LbDiaChi.TabIndex = 49;
            this.LbDiaChi.Text = "Địa chỉ";
            // 
            // TeSDT
            // 
            this.TeSDT.Location = new System.Drawing.Point(361, 192);
            this.TeSDT.Name = "TeSDT";
            this.TeSDT.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TeSDT.Properties.Appearance.Options.UseFont = true;
            this.TeSDT.Size = new System.Drawing.Size(122, 22);
            this.TeSDT.TabIndex = 46;
            // 
            // LbSDT
            // 
            this.LbSDT.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LbSDT.Appearance.Options.UseFont = true;
            this.LbSDT.Location = new System.Drawing.Point(276, 195);
            this.LbSDT.Name = "LbSDT";
            this.LbSDT.Size = new System.Drawing.Size(69, 15);
            this.LbSDT.TabIndex = 45;
            this.LbSDT.Text = "Số điện thoại";
            // 
            // LbGioiTinh
            // 
            this.LbGioiTinh.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LbGioiTinh.Appearance.Options.UseFont = true;
            this.LbGioiTinh.Location = new System.Drawing.Point(276, 139);
            this.LbGioiTinh.Name = "LbGioiTinh";
            this.LbGioiTinh.Size = new System.Drawing.Size(45, 15);
            this.LbGioiTinh.TabIndex = 44;
            this.LbGioiTinh.Text = "Giới tính";
            // 
            // LbMaGiamGia
            // 
            this.LbMaGiamGia.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LbMaGiamGia.Appearance.Options.UseFont = true;
            this.LbMaGiamGia.Location = new System.Drawing.Point(509, 195);
            this.LbMaGiamGia.Name = "LbMaGiamGia";
            this.LbMaGiamGia.Size = new System.Drawing.Size(66, 15);
            this.LbMaGiamGia.TabIndex = 43;
            this.LbMaGiamGia.Text = "Mã giảm giá";
            // 
            // TeTenKH
            // 
            this.TeTenKH.Location = new System.Drawing.Point(123, 194);
            this.TeTenKH.Name = "TeTenKH";
            this.TeTenKH.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TeTenKH.Properties.Appearance.Options.UseFont = true;
            this.TeTenKH.Size = new System.Drawing.Size(128, 22);
            this.TeTenKH.TabIndex = 42;
            // 
            // LbTenKH
            // 
            this.LbTenKH.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LbTenKH.Appearance.Options.UseFont = true;
            this.LbTenKH.Location = new System.Drawing.Point(27, 195);
            this.LbTenKH.Name = "LbTenKH";
            this.LbTenKH.Size = new System.Drawing.Size(87, 15);
            this.LbTenKH.TabIndex = 41;
            this.LbTenKH.Text = "Tên Khách Hàng";
            // 
            // TeMaKH
            // 
            this.TeMaKH.Location = new System.Drawing.Point(123, 138);
            this.TeMaKH.Name = "TeMaKH";
            this.TeMaKH.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TeMaKH.Properties.Appearance.Options.UseFont = true;
            this.TeMaKH.Size = new System.Drawing.Size(128, 22);
            this.TeMaKH.TabIndex = 40;
            // 
            // LbMaKH
            // 
            this.LbMaKH.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LbMaKH.Appearance.Options.UseFont = true;
            this.LbMaKH.Location = new System.Drawing.Point(27, 139);
            this.LbMaKH.Name = "LbMaKH";
            this.LbMaKH.Size = new System.Drawing.Size(85, 15);
            this.LbMaKH.TabIndex = 39;
            this.LbMaKH.Text = "Mã Khách Hàng";
            // 
            // CbeMaGiamGia
            // 
            this.CbeMaGiamGia.Location = new System.Drawing.Point(603, 193);
            this.CbeMaGiamGia.Name = "CbeMaGiamGia";
            this.CbeMaGiamGia.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CbeMaGiamGia.Properties.Appearance.Options.UseFont = true;
            this.CbeMaGiamGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbeMaGiamGia.Size = new System.Drawing.Size(144, 22);
            this.CbeMaGiamGia.TabIndex = 59;
            // 
            // CbeGioiTinh
            // 
            this.CbeGioiTinh.Location = new System.Drawing.Point(361, 138);
            this.CbeGioiTinh.Name = "CbeGioiTinh";
            this.CbeGioiTinh.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CbeGioiTinh.Properties.Appearance.Options.UseFont = true;
            this.CbeGioiTinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbeGioiTinh.Size = new System.Drawing.Size(122, 22);
            this.CbeGioiTinh.TabIndex = 54;
            // 
            // DeNgaySinh
            // 
            this.DeNgaySinh.EditValue = null;
            this.DeNgaySinh.Location = new System.Drawing.Point(123, 241);
            this.DeNgaySinh.Name = "DeNgaySinh";
            this.DeNgaySinh.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeNgaySinh.Properties.Appearance.Options.UseFont = true;
            this.DeNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DeNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DeNgaySinh.Size = new System.Drawing.Size(128, 22);
            this.DeNgaySinh.TabIndex = 63;
            // 
            // LbNgaySinh
            // 
            this.LbNgaySinh.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNgaySinh.Appearance.Options.UseFont = true;
            this.LbNgaySinh.Location = new System.Drawing.Point(27, 242);
            this.LbNgaySinh.Name = "LbNgaySinh";
            this.LbNgaySinh.Size = new System.Drawing.Size(54, 15);
            this.LbNgaySinh.TabIndex = 62;
            this.LbNgaySinh.Text = "Ngày Sinh";
            // 
            // UcKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeNgaySinh);
            this.Controls.Add(this.LbNgaySinh);
            this.Controls.Add(this.CbeMaGiamGia);
            this.Controls.Add(this.CbeGioiTinh);
            this.Controls.Add(this.TeDiaChi);
            this.Controls.Add(this.LbDiaChi);
            this.Controls.Add(this.TeSDT);
            this.Controls.Add(this.LbSDT);
            this.Controls.Add(this.LbGioiTinh);
            this.Controls.Add(this.LbMaGiamGia);
            this.Controls.Add(this.TeTenKH);
            this.Controls.Add(this.LbTenKH);
            this.Controls.Add(this.TeMaKH);
            this.Controls.Add(this.LbMaKH);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.GcDanhMucKH);
            this.Controls.Add(this.RcDanhMucKH);
            this.Name = "UcKhachHang";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.GcDanhMucKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RcDanhMucKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbeMaGiamGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbeGioiTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeNgaySinh.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl GcDanhMucKH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraBars.Ribbon.RibbonControl RcDanhMucKH;
        private DevExpress.XtraBars.Ribbon.RibbonPage RpDanhMucKH;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup RbgTacVuKH;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem BbiThemMoi;
        private DevExpress.XtraBars.BarButtonItem BbiSua;
        private DevExpress.XtraBars.BarButtonItem BbiXoa;
        private DevExpress.XtraBars.BarButtonItem BbiLamMoi;
        private DevExpress.XtraEditors.TextEdit TeDiaChi;
        private DevExpress.XtraEditors.LabelControl LbDiaChi;
        private DevExpress.XtraEditors.TextEdit TeSDT;
        private DevExpress.XtraEditors.LabelControl LbSDT;
        private DevExpress.XtraEditors.LabelControl LbGioiTinh;
        private DevExpress.XtraEditors.LabelControl LbMaGiamGia;
        private DevExpress.XtraEditors.TextEdit TeTenKH;
        private DevExpress.XtraEditors.LabelControl LbTenKH;
        private DevExpress.XtraEditors.TextEdit TeMaKH;
        private DevExpress.XtraEditors.LabelControl LbMaKH;
        private DevExpress.XtraEditors.ComboBoxEdit CbeMaGiamGia;
        private DevExpress.XtraEditors.ComboBoxEdit CbeGioiTinh;
        private DevExpress.XtraEditors.DateEdit DeNgaySinh;
        private DevExpress.XtraEditors.LabelControl LbNgaySinh;
    }
}
