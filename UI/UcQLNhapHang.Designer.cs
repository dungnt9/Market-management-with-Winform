namespace market_management.UI
{
    partial class UcQLNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcQLNhapHang));
            this.GcQLNhapHang = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RcQLNhapHang = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.BbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.BbiSua = new DevExpress.XtraBars.BarButtonItem();
            this.BbiXoa = new DevExpress.XtraBars.BarButtonItem();
            this.BbiLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.BsiXemChiTiet = new DevExpress.XtraBars.BarButtonItem();
            this.RpQLNhapHang = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.RpgTacVuNhapHang = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.LbThoiGian = new DevExpress.XtraEditors.LabelControl();
            this.LbThanhTien = new DevExpress.XtraEditors.LabelControl();
            this.LbMaNCC = new DevExpress.XtraEditors.LabelControl();
            this.LbTenNV = new DevExpress.XtraEditors.LabelControl();
            this.LbMaDonNhap = new DevExpress.XtraEditors.LabelControl();
            this.DeThoiGian = new DevExpress.XtraEditors.DateEdit();
            this.LbcMaDN = new DevExpress.XtraEditors.LabelControl();
            this.LbcSP = new DevExpress.XtraEditors.LabelControl();
            this.CmbTenNV = new System.Windows.Forms.ComboBox();
            this.CmbTenNCC = new System.Windows.Forms.ComboBox();
            this.CmbCacSP = new System.Windows.Forms.ComboBox();
            this.TeTongtien = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.GcQLNhapHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RcQLNhapHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeThoiGian.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeThoiGian.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeTongtien.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GcQLNhapHang
            // 
            this.GcQLNhapHang.Location = new System.Drawing.Point(3, 249);
            this.GcQLNhapHang.MainView = this.gridView;
            this.GcQLNhapHang.MenuManager = this.RcQLNhapHang;
            this.GcQLNhapHang.Name = "GcQLNhapHang";
            this.GcQLNhapHang.Size = new System.Drawing.Size(800, 343);
            this.GcQLNhapHang.TabIndex = 2;
            this.GcQLNhapHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.GridControl = this.GcQLNhapHang;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // RcQLNhapHang
            // 
            this.RcQLNhapHang.ExpandCollapseItem.Id = 0;
            this.RcQLNhapHang.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.RcQLNhapHang.ExpandCollapseItem,
            this.bsiRecordsCount,
            this.BbiNew,
            this.BbiSua,
            this.BbiXoa,
            this.BbiLamMoi,
            this.BsiXemChiTiet});
            this.RcQLNhapHang.Location = new System.Drawing.Point(0, 0);
            this.RcQLNhapHang.MaxItemId = 21;
            this.RcQLNhapHang.Name = "RcQLNhapHang";
            this.RcQLNhapHang.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.RpQLNhapHang});
            this.RcQLNhapHang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.RcQLNhapHang.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.RcQLNhapHang.Size = new System.Drawing.Size(934, 154);
            //this.RcQLNhapHang.StatusBar = this.ribbonStatusBar;
            this.RcQLNhapHang.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            // 
            // BbiNew
            // 
            this.BbiNew.Caption = "Tạo hóa đơn nhập";
            this.BbiNew.Id = 16;
            this.BbiNew.ImageOptions.ImageUri.Uri = "New";
            this.BbiNew.Name = "BbiNew";
            //this.BbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiNew_ItemClick);
            // 
            // BbiSua
            // 
            this.BbiSua.Caption = "Sửa";
            this.BbiSua.Id = 17;
            this.BbiSua.ImageOptions.ImageUri.Uri = "Edit";
            this.BbiSua.Name = "BbiSua";
            //this.BbiSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiSua_ItemClick);
            // 
            // BbiXoa
            // 
            this.BbiXoa.Caption = "Xóa";
            this.BbiXoa.Id = 18;
            this.BbiXoa.ImageOptions.ImageUri.Uri = "Delete";
            this.BbiXoa.Name = "BbiXoa";
            this.BbiXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiXoa_ItemClick);
            // 
            // BbiLamMoi
            // 
            this.BbiLamMoi.Caption = "Làm mới";
            this.BbiLamMoi.Id = 19;
            this.BbiLamMoi.ImageOptions.ImageUri.Uri = "Refresh";
            this.BbiLamMoi.Name = "BbiLamMoi";
            this.BbiLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiLamMoi_ItemClick);
            // 
            // BsiXemChiTiet
            // 
            this.BsiXemChiTiet.Caption = "Xem chi tiết đơn nhập";
            this.BsiXemChiTiet.Id = 20;
            this.BsiXemChiTiet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BsiXemChiTiet.ImageOptions.Image")));
            this.BsiXemChiTiet.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BsiXemChiTiet.ImageOptions.LargeImage")));
            this.BsiXemChiTiet.Name = "BsiXemChiTiet";
            this.BsiXemChiTiet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BsiXemChiTiet_ItemClick);
            // 
            // RpQLNhapHang
            // 
            this.RpQLNhapHang.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.RpQLNhapHang.Appearance.Options.UseFont = true;
            this.RpQLNhapHang.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.RpgTacVuNhapHang,
            this.ribbonPageGroup1});
            this.RpQLNhapHang.MergeOrder = 0;
            this.RpQLNhapHang.Name = "RpQLNhapHang";
            this.RpQLNhapHang.Text = "Quản lý nhập hàng";
            // 
            // RpgTacVuNhapHang
            // 
            this.RpgTacVuNhapHang.AllowTextClipping = false;
            this.RpgTacVuNhapHang.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.RpgTacVuNhapHang.ItemLinks.Add(this.BbiNew);
            this.RpgTacVuNhapHang.ItemLinks.Add(this.BbiSua);
            this.RpgTacVuNhapHang.ItemLinks.Add(this.BbiXoa);
            this.RpgTacVuNhapHang.ItemLinks.Add(this.BbiLamMoi);
            this.RpgTacVuNhapHang.Name = "RpgTacVuNhapHang";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BsiXemChiTiet);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // LbThoiGian
            // 
            this.LbThoiGian.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LbThoiGian.Appearance.Options.UseFont = true;
            this.LbThoiGian.Location = new System.Drawing.Point(63, 259);
            this.LbThoiGian.Name = "LbThoiGian";
            this.LbThoiGian.Size = new System.Drawing.Size(62, 20);
            this.LbThoiGian.TabIndex = 59;
            this.LbThoiGian.Text = "Thời gian";
            // 
            // LbThanhTien
            // 
            this.LbThanhTien.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LbThanhTien.Appearance.Options.UseFont = true;
            this.LbThanhTien.Location = new System.Drawing.Point(63, 216);
            this.LbThanhTien.Name = "LbThanhTien";
            this.LbThanhTien.Size = new System.Drawing.Size(63, 20);
            this.LbThanhTien.TabIndex = 56;
            this.LbThanhTien.Text = "Tổng tiền";
            // 
            // LbMaNCC
            // 
            this.LbMaNCC.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LbMaNCC.Appearance.Options.UseFont = true;
            this.LbMaNCC.Location = new System.Drawing.Point(536, 172);
            this.LbMaNCC.Name = "LbMaNCC";
            this.LbMaNCC.Size = new System.Drawing.Size(115, 20);
            this.LbMaNCC.TabIndex = 54;
            this.LbMaNCC.Text = "Tên nhà cung cấp";
            // 
            // LbTenNV
            // 
            this.LbTenNV.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LbTenNV.Appearance.Options.UseFont = true;
            this.LbTenNV.Location = new System.Drawing.Point(536, 215);
            this.LbTenNV.Name = "LbTenNV";
            this.LbTenNV.Size = new System.Drawing.Size(91, 20);
            this.LbTenNV.TabIndex = 52;
            this.LbTenNV.Text = "Tên nhân viên";
            // 
            // LbMaDonNhap
            // 
            this.LbMaDonNhap.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LbMaDonNhap.Appearance.Options.UseFont = true;
            this.LbMaDonNhap.Location = new System.Drawing.Point(63, 172);
            this.LbMaDonNhap.Name = "LbMaDonNhap";
            this.LbMaDonNhap.Size = new System.Drawing.Size(88, 20);
            this.LbMaDonNhap.TabIndex = 50;
            this.LbMaDonNhap.Text = "Mã đơn nhập";
            // 
            // DeThoiGian
            // 
            this.DeThoiGian.EditValue = null;
            this.DeThoiGian.Location = new System.Drawing.Point(167, 257);
            this.DeThoiGian.Margin = new System.Windows.Forms.Padding(4);
            this.DeThoiGian.Name = "DeThoiGian";
            this.DeThoiGian.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DeThoiGian.Properties.Appearance.Options.UseFont = true;
            this.DeThoiGian.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DeThoiGian.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DeThoiGian.Size = new System.Drawing.Size(211, 26);
            this.DeThoiGian.TabIndex = 68;
            // 
            // LbcMaDN
            // 
            this.LbcMaDN.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbcMaDN.Appearance.Options.UseFont = true;
            this.LbcMaDN.Location = new System.Drawing.Point(143, 142);
            this.LbcMaDN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LbcMaDN.Name = "LbcMaDN";
            this.LbcMaDN.Size = new System.Drawing.Size(15, 14);
            this.LbcMaDN.TabIndex = 71;
            this.LbcMaDN.Text = "Mã";
            // 
            // LbcSP
            // 
            this.LbcSP.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LbcSP.Appearance.Options.UseFont = true;
            this.LbcSP.Location = new System.Drawing.Point(459, 210);
            this.LbcSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LbcSP.Name = "LbcSP";
            this.LbcSP.Size = new System.Drawing.Size(75, 15);
            this.LbcSP.TabIndex = 72;
            this.LbcSP.Text = "Các sản phẩm";
            // 
            // CmbTenNV
            // 
            this.CmbTenNV.FormattingEnabled = true;
            this.CmbTenNV.Location = new System.Drawing.Point(578, 175);
            this.CmbTenNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbTenNV.Name = "CmbTenNV";
            this.CmbTenNV.Size = new System.Drawing.Size(161, 21);
            this.CmbTenNV.TabIndex = 73;
            // 
            // CmbTenNCC
            // 
            this.CmbTenNCC.FormattingEnabled = true;
            this.CmbTenNCC.Location = new System.Drawing.Point(579, 140);
            this.CmbTenNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbTenNCC.Name = "CmbTenNCC";
            this.CmbTenNCC.Size = new System.Drawing.Size(161, 21);
            this.CmbTenNCC.TabIndex = 74;
            // 
            // CmbCacSP
            // 
            this.CmbCacSP.FormattingEnabled = true;
            this.CmbCacSP.Location = new System.Drawing.Point(579, 210);
            this.CmbCacSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbCacSP.Name = "CmbCacSP";
            this.CmbCacSP.Size = new System.Drawing.Size(161, 21);
            this.CmbCacSP.TabIndex = 75;
            // 
            // TeTongtien
            // 
            this.TeTongtien.Location = new System.Drawing.Point(143, 175);
            this.TeTongtien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TeTongtien.MenuManager = this.RcQLNhapHang;
            this.TeTongtien.Name = "TeTongtien";
            this.TeTongtien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeTongtien.Properties.Appearance.Options.UseFont = true;
            this.TeTongtien.Size = new System.Drawing.Size(181, 20);
            this.TeTongtien.TabIndex = 78;
            // 
            this.Size = new System.Drawing.Size(934, 758);
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TeTongtien);
            this.Controls.Add(this.CmbCacSP);
            this.Controls.Add(this.CmbTenNCC);
            this.Controls.Add(this.CmbTenNV);
            this.Controls.Add(this.LbcSP);
            this.Controls.Add(this.LbcMaDN);
            this.Controls.Add(this.DeThoiGian);
            this.Controls.Add(this.LbThoiGian);
            this.Controls.Add(this.LbThanhTien);
            this.Controls.Add(this.LbMaNCC);
            this.Controls.Add(this.LbTenNV);
            this.Controls.Add(this.LbMaDonNhap);
            this.Controls.Add(this.GcQLNhapHang);
            this.Controls.Add(this.RcQLNhapHang);
            this.Name = "UcQLNhapHang";
            this.Size = new System.Drawing.Size(801, 616);
            this.Load += new System.EventHandler(this.UcQLNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GcQLNhapHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RcQLNhapHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeThoiGian.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeThoiGian.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeTongtien.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private DevExpress.XtraGrid.GridControl GcQLNhapHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraBars.Ribbon.RibbonControl RcQLNhapHang;
        private DevExpress.XtraBars.Ribbon.RibbonPage RpQLNhapHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup RpgTacVuNhapHang;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem BbiNew;
        private DevExpress.XtraBars.BarButtonItem BbiSua;
        private DevExpress.XtraBars.BarButtonItem BbiXoa;
        private DevExpress.XtraBars.BarButtonItem BbiLamMoi;
        private DevExpress.XtraEditors.LabelControl LbThoiGian;
        private DevExpress.XtraEditors.LabelControl LbThanhTien;
        private DevExpress.XtraEditors.LabelControl LbMaNCC;
        private DevExpress.XtraEditors.LabelControl LbTenNV;
        private DevExpress.XtraEditors.LabelControl LbMaDonNhap;
        private DevExpress.XtraEditors.DateEdit DeThoiGian;
        private DevExpress.XtraEditors.LabelControl LbcMaDN;
        private DevExpress.XtraEditors.LabelControl LbcSP;
        private System.Windows.Forms.ComboBox CmbTenNV;
        private System.Windows.Forms.ComboBox CmbTenNCC;
        private System.Windows.Forms.ComboBox CmbCacSP;
        private DevExpress.XtraEditors.TextEdit TeTongtien;
        private DevExpress.XtraBars.BarButtonItem BsiXemChiTiet;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}

