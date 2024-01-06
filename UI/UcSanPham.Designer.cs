namespace market_management.UI
{
    partial class UcSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcSanPham));
            this.GcSP = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RcDanhMucSP = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.BbiSua = new DevExpress.XtraBars.BarButtonItem();
            this.BbiXoa = new DevExpress.XtraBars.BarButtonItem();
            this.BbiLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.RpDanhMucSP = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.RpgTacVuSP = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.CmbMaSP = new System.Windows.Forms.ComboBox();
            this.TeSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.TeGiaBan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TeGiaNhap = new DevExpress.XtraEditors.TextEdit();
            this.CbeTenSP = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CbePhanLoai = new DevExpress.XtraEditors.ComboBoxEdit();
            this.BbiThem = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.GcSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RcDanhMucSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeGiaBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeGiaNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbeTenSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbePhanLoai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GcSP
            // 
            this.GcSP.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GcSP.Location = new System.Drawing.Point(0, 298);
            this.GcSP.MainView = this.gridView;
            this.GcSP.Margin = new System.Windows.Forms.Padding(4);
            this.GcSP.MenuManager = this.RcDanhMucSP;
            this.GcSP.Name = "GcSP";
            this.GcSP.Size = new System.Drawing.Size(933, 428);
            this.GcSP.TabIndex = 2;
            this.GcSP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.DetailHeight = 431;
            this.gridView.GridControl = this.GcSP;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.OptionsEditForm.PopupEditFormWidth = 933;
            this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged_1);
            // 
            // RcDanhMucSP
            // 
            this.RcDanhMucSP.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 37, 35, 37);
            this.RcDanhMucSP.ExpandCollapseItem.Id = 0;
            this.RcDanhMucSP.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.RcDanhMucSP.ExpandCollapseItem,
            this.bsiRecordsCount,
            this.BbiSua,
            this.BbiXoa,
            this.BbiLamMoi,
            this.BbiThem});
            this.RcDanhMucSP.Location = new System.Drawing.Point(0, 0);
            this.RcDanhMucSP.Margin = new System.Windows.Forms.Padding(4);
            this.RcDanhMucSP.MaxItemId = 21;
            this.RcDanhMucSP.Name = "RcDanhMucSP";
            this.RcDanhMucSP.OptionsMenuMinWidth = 385;
            this.RcDanhMucSP.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.RpDanhMucSP});
            this.RcDanhMucSP.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.RcDanhMucSP.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.RcDanhMucSP.Size = new System.Drawing.Size(934, 154);
            this.RcDanhMucSP.StatusBar = this.ribbonStatusBar;
            this.RcDanhMucSP.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            // 
            // BbiSua
            // 
            this.BbiSua.Caption = "Sửa";
            this.BbiSua.Id = 17;
            this.BbiSua.ImageOptions.ImageUri.Uri = "Edit";
            this.BbiSua.Name = "BbiSua";
            this.BbiSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiSua_ItemClick_1);
            // 
            // BbiXoa
            // 
            this.BbiXoa.Caption = "Xóa";
            this.BbiXoa.Id = 18;
            this.BbiXoa.ImageOptions.ImageUri.Uri = "Delete";
            this.BbiXoa.Name = "BbiXoa";
            this.BbiXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiXoa_ItemClick_1);
            // 
            // BbiLamMoi
            // 
            this.BbiLamMoi.Caption = "Làm mới";
            this.BbiLamMoi.Id = 19;
            this.BbiLamMoi.ImageOptions.ImageUri.Uri = "Refresh";
            this.BbiLamMoi.Name = "BbiLamMoi";
            this.BbiLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiLamMoi_ItemClick_1);
            // 
            // RpDanhMucSP
            // 
            this.RpDanhMucSP.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.RpDanhMucSP.Appearance.Options.UseFont = true;
            this.RpDanhMucSP.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.RpgTacVuSP});
            this.RpDanhMucSP.MergeOrder = 0;
            this.RpDanhMucSP.Name = "RpDanhMucSP";
            this.RpDanhMucSP.Text = "Quản lý danh mục sản phẩm";
            // 
            // RpgTacVuSP
            // 
            this.RpgTacVuSP.AllowTextClipping = false;
            this.RpgTacVuSP.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.RpgTacVuSP.ItemLinks.Add(this.BbiThem);
            this.RpgTacVuSP.ItemLinks.Add(this.BbiSua);
            this.RpgTacVuSP.ItemLinks.Add(this.BbiXoa);
            this.RpgTacVuSP.ItemLinks.Add(this.BbiLamMoi);
            this.RpgTacVuSP.Name = "RpgTacVuSP";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 725);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.RcDanhMucSP;
            this.ribbonStatusBar.Size = new System.Drawing.Size(934, 33);
            // 
            // CmbMaSP
            // 
            this.CmbMaSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CmbMaSP.FormattingEnabled = true;
            this.CmbMaSP.Location = new System.Drawing.Point(216, 184);
            this.CmbMaSP.Name = "CmbMaSP";
            this.CmbMaSP.Size = new System.Drawing.Size(213, 28);
            this.CmbMaSP.TabIndex = 27;
            // 
            // TeSoLuong
            // 
            this.TeSoLuong.Location = new System.Drawing.Point(645, 183);
            this.TeSoLuong.MenuManager = this.RcDanhMucSP;
            this.TeSoLuong.Name = "TeSoLuong";
            this.TeSoLuong.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TeSoLuong.Properties.Appearance.Options.UseFont = true;
            this.TeSoLuong.Size = new System.Drawing.Size(213, 26);
            this.TeSoLuong.TabIndex = 25;
            // 
            // TeGiaBan
            // 
            this.TeGiaBan.Location = new System.Drawing.Point(645, 267);
            this.TeGiaBan.MenuManager = this.RcDanhMucSP;
            this.TeGiaBan.Name = "TeGiaBan";
            this.TeGiaBan.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TeGiaBan.Properties.Appearance.Options.UseFont = true;
            this.TeGiaBan.Size = new System.Drawing.Size(213, 26);
            this.TeGiaBan.TabIndex = 24;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(565, 190);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 20);
            this.labelControl5.TabIndex = 23;
            this.labelControl5.Text = "Số lượng";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(565, 271);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 20);
            this.labelControl4.TabIndex = 22;
            this.labelControl4.Text = "Giá bán lẻ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(110, 228);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(91, 20);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Tên sản phẩm";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(110, 268);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 20);
            this.labelControl2.TabIndex = 20;
            this.labelControl2.Text = "Phân loại";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(110, 186);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 20);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Mã sản phẩm";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(565, 228);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 20);
            this.labelControl6.TabIndex = 31;
            this.labelControl6.Text = "Giá nhập";
            // 
            // TeGiaNhap
            // 
            this.TeGiaNhap.Location = new System.Drawing.Point(645, 224);
            this.TeGiaNhap.MenuManager = this.RcDanhMucSP;
            this.TeGiaNhap.Name = "TeGiaNhap";
            this.TeGiaNhap.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TeGiaNhap.Properties.Appearance.Options.UseFont = true;
            this.TeGiaNhap.Size = new System.Drawing.Size(213, 26);
            this.TeGiaNhap.TabIndex = 32;
            // 
            // CbeTenSP
            // 
            this.CbeTenSP.Location = new System.Drawing.Point(216, 223);
            this.CbeTenSP.MenuManager = this.RcDanhMucSP;
            this.CbeTenSP.Name = "CbeTenSP";
            this.CbeTenSP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbeTenSP.Properties.Appearance.Options.UseFont = true;
            this.CbeTenSP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbeTenSP.Size = new System.Drawing.Size(213, 28);
            this.CbeTenSP.TabIndex = 38;
            // 
            // CbePhanLoai
            // 
            this.CbePhanLoai.Location = new System.Drawing.Point(216, 263);
            this.CbePhanLoai.MenuManager = this.RcDanhMucSP;
            this.CbePhanLoai.Name = "CbePhanLoai";
            this.CbePhanLoai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbePhanLoai.Properties.Appearance.Options.UseFont = true;
            this.CbePhanLoai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbePhanLoai.Size = new System.Drawing.Size(213, 28);
            this.CbePhanLoai.TabIndex = 39;
            // 
            // BbiThem
            // 
            this.BbiThem.Caption = "Thêm";
            this.BbiThem.Id = 20;
            this.BbiThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.BbiThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.BbiThem.Name = "BbiThem";
            this.BbiThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiThem_ItemClick_1);
            // 
            // UcSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CbePhanLoai);
            this.Controls.Add(this.CbeTenSP);
            this.Controls.Add(this.TeGiaNhap);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.CmbMaSP);
            this.Controls.Add(this.TeSoLuong);
            this.Controls.Add(this.TeGiaBan);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.GcSP);
            this.Controls.Add(this.RcDanhMucSP);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UcSanPham";
            this.Size = new System.Drawing.Size(934, 758);
            this.Load += new System.EventHandler(this.UcSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GcSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RcDanhMucSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeGiaBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeGiaNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbeTenSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbePhanLoai.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl GcSP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraBars.Ribbon.RibbonControl RcDanhMucSP;
        private DevExpress.XtraBars.Ribbon.RibbonPage RpDanhMucSP;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup RpgTacVuSP;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem BbiSua;
        private DevExpress.XtraBars.BarButtonItem BbiXoa;
        private DevExpress.XtraBars.BarButtonItem BbiLamMoi;
        private System.Windows.Forms.ComboBox CmbMaSP;
        private DevExpress.XtraEditors.TextEdit TeSoLuong;
        private DevExpress.XtraEditors.TextEdit TeGiaBan;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit TeGiaNhap;
        private DevExpress.XtraEditors.ComboBoxEdit CbeTenSP;
        private DevExpress.XtraEditors.ComboBoxEdit CbePhanLoai;
        private DevExpress.XtraBars.BarButtonItem BbiThem;
    }
}
