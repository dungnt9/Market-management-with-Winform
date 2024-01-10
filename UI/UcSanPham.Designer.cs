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
            this.BbiSua = new DevExpress.XtraBars.BarButtonItem();
            this.BbiLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.BbiThem = new DevExpress.XtraBars.BarButtonItem();
            this.RpDanhMucSP = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.RpgTacVuSP = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TeGiaBan = new DevExpress.XtraEditors.TextEdit();
            this.TeSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TeGiaNhap = new DevExpress.XtraEditors.TextEdit();
            this.CbePhanLoai = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LbcMaSP = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.CmbTrangThai = new System.Windows.Forms.ComboBox();
            this.TeTenSP = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.GcSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RcDanhMucSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeGiaBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeGiaNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbePhanLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeTenSP.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GcSP
            // 
            this.GcSP.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GcSP.Location = new System.Drawing.Point(1, 365);
            this.GcSP.MainView = this.gridView;
            this.GcSP.MenuManager = this.RcDanhMucSP;
            this.GcSP.Name = "GcSP";
            this.GcSP.Size = new System.Drawing.Size(933, 361);
            this.GcSP.TabIndex = 2;
            this.GcSP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.GridControl = this.GcSP;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged_1);
            // 
            // RcDanhMucSP
            // 
            this.RcDanhMucSP.ExpandCollapseItem.Id = 0;
            this.RcDanhMucSP.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.RcDanhMucSP.ExpandCollapseItem,
            this.BbiSua,
            this.BbiLamMoi,
            this.BbiThem});
            this.RcDanhMucSP.Location = new System.Drawing.Point(0, 0);
            this.RcDanhMucSP.MaxItemId = 21;
            this.RcDanhMucSP.Name = "RcDanhMucSP";
            this.RcDanhMucSP.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.RpDanhMucSP});
            this.RcDanhMucSP.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.RcDanhMucSP.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.RcDanhMucSP.Size = new System.Drawing.Size(801, 126);
            this.RcDanhMucSP.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // BbiSua
            // 
            this.BbiSua.Caption = "Sửa";
            this.BbiSua.Id = 17;
            this.BbiSua.ImageOptions.ImageUri.Uri = "Edit";
            this.BbiSua.Name = "BbiSua";
            this.BbiSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiSua_ItemClick_1);
            // 
            // BbiLamMoi
            // 
            this.BbiLamMoi.Caption = "Làm mới";
            this.BbiLamMoi.Id = 19;
            this.BbiLamMoi.ImageOptions.ImageUri.Uri = "Refresh";
            this.BbiLamMoi.Name = "BbiLamMoi";
            this.BbiLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiLamMoi_ItemClick_1);
            // 
            // BbiThem
            // 
            this.BbiThem.Caption = "Thêm";
            this.BbiThem.Id = 20;
            this.BbiThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BbiThem.ImageOptions.Image")));
            this.BbiThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BbiThem.ImageOptions.LargeImage")));
            this.BbiThem.Name = "BbiThem";
            this.BbiThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiThem_ItemClick_1);
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
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(484, 220);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 15);
            this.labelControl4.TabIndex = 22;
            this.labelControl4.Text = "Giá bán lẻ";
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
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(484, 185);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 15);
            this.labelControl6.TabIndex = 31;
            this.labelControl6.Text = "Giá nhập";
            // 
            // TeGiaNhap
            // 
            this.TeGiaNhap.Location = new System.Drawing.Point(553, 182);
            this.TeGiaNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TeGiaNhap.MenuManager = this.RcDanhMucSP;
            this.TeGiaNhap.Name = "TeGiaNhap";
            this.TeGiaNhap.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TeGiaNhap.Properties.Appearance.Options.UseFont = true;
            this.TeGiaNhap.Size = new System.Drawing.Size(183, 22);
            this.TeGiaNhap.TabIndex = 32;
            // 
            // CbePhanLoai
            // 
            this.CbePhanLoai.Location = new System.Drawing.Point(185, 214);
            this.CbePhanLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbePhanLoai.MenuManager = this.RcDanhMucSP;
            this.CbePhanLoai.Name = "CbePhanLoai";
            this.CbePhanLoai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbePhanLoai.Properties.Appearance.Options.UseFont = true;
            this.CbePhanLoai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbePhanLoai.Size = new System.Drawing.Size(183, 24);
            this.CbePhanLoai.TabIndex = 39;
            // 
            // LbcMaSP
            // 
            this.LbcMaSP.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbcMaSP.Appearance.Options.UseFont = true;
            this.LbcMaSP.Location = new System.Drawing.Point(216, 188);
            this.LbcMaSP.Name = "LbcMaSP";
            this.LbcMaSP.Size = new System.Drawing.Size(25, 18);
            this.LbcMaSP.TabIndex = 42;
            this.LbcMaSP.Text = "Mã ";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(565, 314);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(67, 18);
            this.labelControl7.TabIndex = 47;
            this.labelControl7.Text = "Trạng thái";
            // 
            // CmbTrangThai
            // 
            this.CmbTrangThai.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTrangThai.FormattingEnabled = true;
            this.CmbTrangThai.Items.AddRange(new object[] {
            "Đang kinh doanh",
            "Không còn kinh doanh"});
            this.CmbTrangThai.Location = new System.Drawing.Point(645, 311);
            this.CmbTrangThai.Name = "CmbTrangThai";
            this.CmbTrangThai.Size = new System.Drawing.Size(213, 26);
            this.CmbTrangThai.TabIndex = 48;
            // 
            // TeTenSP
            // 
            this.TeTenSP.Location = new System.Drawing.Point(216, 222);
            this.TeTenSP.MenuManager = this.RcDanhMucSP;
            this.TeTenSP.Name = "TeTenSP";
            this.TeTenSP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeTenSP.Properties.Appearance.Options.UseFont = true;
            this.TeTenSP.Size = new System.Drawing.Size(213, 24);
            this.TeTenSP.TabIndex = 51;
            // 
            // UcSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TeTenSP);
            this.Controls.Add(this.CmbTrangThai);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.LbcMaSP);
            this.Controls.Add(this.CbePhanLoai);
            this.Controls.Add(this.TeGiaNhap);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.TeSoLuong);
            this.Controls.Add(this.TeGiaBan);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.GcSP);
            this.Controls.Add(this.RcDanhMucSP);
            this.Name = "UcSanPham";
            this.Size = new System.Drawing.Size(801, 616);
            this.Load += new System.EventHandler(this.UcSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GcSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RcDanhMucSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeGiaBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeGiaNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbePhanLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeTenSP.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl GcSP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraBars.Ribbon.RibbonControl RcDanhMucSP;
        private DevExpress.XtraBars.Ribbon.RibbonPage RpDanhMucSP;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup RpgTacVuSP;
        private DevExpress.XtraBars.BarButtonItem BbiSua;
        private DevExpress.XtraBars.BarButtonItem BbiLamMoi;
        private DevExpress.XtraBars.BarButtonItem BbiThem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TeGiaBan;
        private DevExpress.XtraEditors.TextEdit TeSoLuong;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit TeGiaNhap;
        private DevExpress.XtraEditors.ComboBoxEdit CbePhanLoai;
        private DevExpress.XtraEditors.LabelControl LbcMaSP;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.ComboBox CmbTrangThai;
        private DevExpress.XtraEditors.TextEdit TeTenSP;
    }
}
