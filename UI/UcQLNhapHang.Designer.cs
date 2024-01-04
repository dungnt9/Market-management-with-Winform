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
            this.GcQLNhapHang = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RcQLNhapHang = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.BbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.BbiSua = new DevExpress.XtraBars.BarButtonItem();
            this.BbiXoa = new DevExpress.XtraBars.BarButtonItem();
            this.BbiLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.RpQLNhapHang = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.RpgTacVuNhapHang = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.CmbSDTNCC = new System.Windows.Forms.ComboBox();
            this.CmbTenNCC = new System.Windows.Forms.ComboBox();
            this.CmbMaNCC = new System.Windows.Forms.ComboBox();
            this.CmbTenNV = new System.Windows.Forms.ComboBox();
            this.CmbMaNV = new System.Windows.Forms.ComboBox();
            this.LbThoiGian = new DevExpress.XtraEditors.LabelControl();
            this.TeThanhTien = new DevExpress.XtraEditors.TextEdit();
            this.TeMaDonNhap = new DevExpress.XtraEditors.TextEdit();
            this.LbThanhTien = new DevExpress.XtraEditors.LabelControl();
            this.LbSDT = new DevExpress.XtraEditors.LabelControl();
            this.LbMaNCC = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.LbTenNV = new DevExpress.XtraEditors.LabelControl();
            this.LbMaNV = new DevExpress.XtraEditors.LabelControl();
            this.LbMaDonNhap = new DevExpress.XtraEditors.LabelControl();
            this.DeNgaySinh = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.GcQLNhapHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RcQLNhapHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeThanhTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMaDonNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // GcQLNhapHang
            // 
            this.GcQLNhapHang.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GcQLNhapHang.Location = new System.Drawing.Point(4, 306);
            this.GcQLNhapHang.MainView = this.gridView;
            this.GcQLNhapHang.Margin = new System.Windows.Forms.Padding(4);
            this.GcQLNhapHang.MenuManager = this.RcQLNhapHang;
            this.GcQLNhapHang.Name = "GcQLNhapHang";
            this.GcQLNhapHang.Size = new System.Drawing.Size(933, 422);
            this.GcQLNhapHang.TabIndex = 2;
            this.GcQLNhapHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.DetailHeight = 431;
            this.gridView.GridControl = this.GcQLNhapHang;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.OptionsEditForm.PopupEditFormWidth = 933;
            // 
            // RcQLNhapHang
            // 
            this.RcQLNhapHang.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 37, 35, 37);
            this.RcQLNhapHang.ExpandCollapseItem.Id = 0;
            this.RcQLNhapHang.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.RcQLNhapHang.ExpandCollapseItem,
            this.bsiRecordsCount,
            this.BbiNew,
            this.BbiSua,
            this.BbiXoa,
            this.BbiLamMoi});
            this.RcQLNhapHang.Location = new System.Drawing.Point(0, 0);
            this.RcQLNhapHang.Margin = new System.Windows.Forms.Padding(4);
            this.RcQLNhapHang.MaxItemId = 20;
            this.RcQLNhapHang.Name = "RcQLNhapHang";
            this.RcQLNhapHang.OptionsMenuMinWidth = 385;
            this.RcQLNhapHang.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.RpQLNhapHang});
            this.RcQLNhapHang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.RcQLNhapHang.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.RcQLNhapHang.Size = new System.Drawing.Size(934, 154);
            this.RcQLNhapHang.StatusBar = this.ribbonStatusBar;
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
            this.BbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiNew_ItemClick);
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
            this.BbiXoa.Caption = "Xóa";
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
            // RpQLNhapHang
            // 
            this.RpQLNhapHang.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.RpQLNhapHang.Appearance.Options.UseFont = true;
            this.RpQLNhapHang.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.RpgTacVuNhapHang});
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
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 725);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.RcQLNhapHang;
            this.ribbonStatusBar.Size = new System.Drawing.Size(934, 33);
            // 
            // CmbSDTNCC
            // 
            this.CmbSDTNCC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CmbSDTNCC.FormattingEnabled = true;
            this.CmbSDTNCC.Location = new System.Drawing.Point(456, 261);
            this.CmbSDTNCC.Name = "CmbSDTNCC";
            this.CmbSDTNCC.Size = new System.Drawing.Size(152, 28);
            this.CmbSDTNCC.TabIndex = 65;
            // 
            // CmbTenNCC
            // 
            this.CmbTenNCC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CmbTenNCC.FormattingEnabled = true;
            this.CmbTenNCC.Location = new System.Drawing.Point(456, 222);
            this.CmbTenNCC.Name = "CmbTenNCC";
            this.CmbTenNCC.Size = new System.Drawing.Size(152, 28);
            this.CmbTenNCC.TabIndex = 64;
            // 
            // CmbMaNCC
            // 
            this.CmbMaNCC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CmbMaNCC.FormattingEnabled = true;
            this.CmbMaNCC.Location = new System.Drawing.Point(456, 178);
            this.CmbMaNCC.Name = "CmbMaNCC";
            this.CmbMaNCC.Size = new System.Drawing.Size(152, 28);
            this.CmbMaNCC.TabIndex = 63;
            // 
            // CmbTenNV
            // 
            this.CmbTenNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CmbTenNV.FormattingEnabled = true;
            this.CmbTenNV.Location = new System.Drawing.Point(754, 222);
            this.CmbTenNV.Name = "CmbTenNV";
            this.CmbTenNV.Size = new System.Drawing.Size(145, 28);
            this.CmbTenNV.TabIndex = 62;
            // 
            // CmbMaNV
            // 
            this.CmbMaNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CmbMaNV.FormattingEnabled = true;
            this.CmbMaNV.Location = new System.Drawing.Point(754, 178);
            this.CmbMaNV.Name = "CmbMaNV";
            this.CmbMaNV.Size = new System.Drawing.Size(145, 28);
            this.CmbMaNV.TabIndex = 61;
            // 
            // LbThoiGian
            // 
            this.LbThoiGian.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LbThoiGian.Appearance.Options.UseFont = true;
            this.LbThoiGian.Location = new System.Drawing.Point(30, 268);
            this.LbThoiGian.Name = "LbThoiGian";
            this.LbThoiGian.Size = new System.Drawing.Size(62, 20);
            this.LbThoiGian.TabIndex = 59;
            this.LbThoiGian.Text = "Thời gian";
            // 
            // TeThanhTien
            // 
            this.TeThanhTien.Location = new System.Drawing.Point(134, 219);
            this.TeThanhTien.MenuManager = this.RcQLNhapHang;
            this.TeThanhTien.Name = "TeThanhTien";
            this.TeThanhTien.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TeThanhTien.Properties.Appearance.Options.UseFont = true;
            this.TeThanhTien.Size = new System.Drawing.Size(158, 26);
            this.TeThanhTien.TabIndex = 58;
            // 
            // TeMaDonNhap
            // 
            this.TeMaDonNhap.Location = new System.Drawing.Point(134, 178);
            this.TeMaDonNhap.MenuManager = this.RcQLNhapHang;
            this.TeMaDonNhap.Name = "TeMaDonNhap";
            this.TeMaDonNhap.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TeMaDonNhap.Properties.Appearance.Options.UseFont = true;
            this.TeMaDonNhap.Size = new System.Drawing.Size(158, 26);
            this.TeMaDonNhap.TabIndex = 57;
            // 
            // LbThanhTien
            // 
            this.LbThanhTien.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LbThanhTien.Appearance.Options.UseFont = true;
            this.LbThanhTien.Location = new System.Drawing.Point(30, 225);
            this.LbThanhTien.Name = "LbThanhTien";
            this.LbThanhTien.Size = new System.Drawing.Size(63, 20);
            this.LbThanhTien.TabIndex = 56;
            this.LbThanhTien.Text = "Tổng tiền";
            // 
            // LbSDT
            // 
            this.LbSDT.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LbSDT.Appearance.Options.UseFont = true;
            this.LbSDT.Location = new System.Drawing.Point(332, 268);
            this.LbSDT.Name = "LbSDT";
            this.LbSDT.Size = new System.Drawing.Size(88, 20);
            this.LbSDT.TabIndex = 55;
            this.LbSDT.Text = "Số điện thoại";
            // 
            // LbMaNCC
            // 
            this.LbMaNCC.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LbMaNCC.Appearance.Options.UseFont = true;
            this.LbMaNCC.Location = new System.Drawing.Point(332, 225);
            this.LbMaNCC.Name = "LbMaNCC";
            this.LbMaNCC.Size = new System.Drawing.Size(115, 20);
            this.LbMaNCC.TabIndex = 54;
            this.LbMaNCC.Text = "Tên nhà cung cấp";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(332, 181);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(113, 20);
            this.labelControl4.TabIndex = 53;
            this.labelControl4.Text = "Mã nhà cung cấp";
            // 
            // LbTenNV
            // 
            this.LbTenNV.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LbTenNV.Appearance.Options.UseFont = true;
            this.LbTenNV.Location = new System.Drawing.Point(655, 228);
            this.LbTenNV.Name = "LbTenNV";
            this.LbTenNV.Size = new System.Drawing.Size(91, 20);
            this.LbTenNV.TabIndex = 52;
            this.LbTenNV.Text = "Tên nhân viên";
            // 
            // LbMaNV
            // 
            this.LbMaNV.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LbMaNV.Appearance.Options.UseFont = true;
            this.LbMaNV.Location = new System.Drawing.Point(655, 184);
            this.LbMaNV.Name = "LbMaNV";
            this.LbMaNV.Size = new System.Drawing.Size(88, 20);
            this.LbMaNV.TabIndex = 51;
            this.LbMaNV.Text = "Mã nhân viên";
            // 
            // LbMaDonNhap
            // 
            this.LbMaDonNhap.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LbMaDonNhap.Appearance.Options.UseFont = true;
            this.LbMaDonNhap.Location = new System.Drawing.Point(30, 181);
            this.LbMaDonNhap.Name = "LbMaDonNhap";
            this.LbMaDonNhap.Size = new System.Drawing.Size(88, 20);
            this.LbMaDonNhap.TabIndex = 50;
            this.LbMaDonNhap.Text = "Mã đơn nhập";
            // 
            // DeNgaySinh
            // 
            this.DeNgaySinh.EditValue = null;
            this.DeNgaySinh.Location = new System.Drawing.Point(134, 266);
            this.DeNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.DeNgaySinh.Name = "DeNgaySinh";
            this.DeNgaySinh.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DeNgaySinh.Properties.Appearance.Options.UseFont = true;
            this.DeNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DeNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DeNgaySinh.Size = new System.Drawing.Size(158, 26);
            this.DeNgaySinh.TabIndex = 68;
            // 
            // UcQLNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeNgaySinh);
            this.Controls.Add(this.CmbSDTNCC);
            this.Controls.Add(this.CmbTenNCC);
            this.Controls.Add(this.CmbMaNCC);
            this.Controls.Add(this.CmbTenNV);
            this.Controls.Add(this.CmbMaNV);
            this.Controls.Add(this.LbThoiGian);
            this.Controls.Add(this.TeThanhTien);
            this.Controls.Add(this.TeMaDonNhap);
            this.Controls.Add(this.LbThanhTien);
            this.Controls.Add(this.LbSDT);
            this.Controls.Add(this.LbMaNCC);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.LbTenNV);
            this.Controls.Add(this.LbMaNV);
            this.Controls.Add(this.LbMaDonNhap);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.GcQLNhapHang);
            this.Controls.Add(this.RcQLNhapHang);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UcQLNhapHang";
            this.Size = new System.Drawing.Size(934, 758);
            ((System.ComponentModel.ISupportInitialize)(this.GcQLNhapHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RcQLNhapHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeThanhTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMaDonNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeNgaySinh.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl GcQLNhapHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraBars.Ribbon.RibbonControl RcQLNhapHang;
        private DevExpress.XtraBars.Ribbon.RibbonPage RpQLNhapHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup RpgTacVuNhapHang;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem BbiNew;
        private DevExpress.XtraBars.BarButtonItem BbiSua;
        private DevExpress.XtraBars.BarButtonItem BbiXoa;
        private DevExpress.XtraBars.BarButtonItem BbiLamMoi;
        private System.Windows.Forms.ComboBox CmbSDTNCC;
        private System.Windows.Forms.ComboBox CmbTenNCC;
        private System.Windows.Forms.ComboBox CmbMaNCC;
        private System.Windows.Forms.ComboBox CmbTenNV;
        private System.Windows.Forms.ComboBox CmbMaNV;
        private DevExpress.XtraEditors.LabelControl LbThoiGian;
        private DevExpress.XtraEditors.TextEdit TeThanhTien;
        private DevExpress.XtraEditors.TextEdit TeMaDonNhap;
        private DevExpress.XtraEditors.LabelControl LbThanhTien;
        private DevExpress.XtraEditors.LabelControl LbSDT;
        private DevExpress.XtraEditors.LabelControl LbMaNCC;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl LbTenNV;
        private DevExpress.XtraEditors.LabelControl LbMaNV;
        private DevExpress.XtraEditors.LabelControl LbMaDonNhap;
        private DevExpress.XtraEditors.DateEdit DeNgaySinh;
    }
}
