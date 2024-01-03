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
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.BbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.BbiSua = new DevExpress.XtraBars.BarButtonItem();
            this.BbiXoa = new DevExpress.XtraBars.BarButtonItem();
            this.BbiLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.CmbSDTNCC = new System.Windows.Forms.ComboBox();
            this.CmbTenNCC = new System.Windows.Forms.ComboBox();
            this.CmbMaNCC = new System.Windows.Forms.ComboBox();
            this.CmbTenNV = new System.Windows.Forms.ComboBox();
            this.CmbMaNV = new System.Windows.Forms.ComboBox();
            this.DtpThoiGianNhap = new System.Windows.Forms.DateTimePicker();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.TeThanhTien = new DevExpress.XtraEditors.TextEdit();
            this.TeMaDonNhap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.GcQLNhapHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeThanhTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMaDonNhap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GcQLNhapHang
            // 
            this.GcQLNhapHang.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GcQLNhapHang.Location = new System.Drawing.Point(0, 306);
            this.GcQLNhapHang.MainView = this.gridView;
            this.GcQLNhapHang.Margin = new System.Windows.Forms.Padding(4);
            this.GcQLNhapHang.MenuManager = this.ribbonControl;
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
            // ribbonControl
            // 
            this.ribbonControl.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 37, 35, 37);
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.bsiRecordsCount,
            this.BbiNew,
            this.BbiSua,
            this.BbiXoa,
            this.BbiLamMoi});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl.MaxItemId = 20;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.OptionsMenuMinWidth = 385;
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(934, 153);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
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
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản lý nhập hàng";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.BbiNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.BbiSua);
            this.ribbonPageGroup1.ItemLinks.Add(this.BbiXoa);
            this.ribbonPageGroup1.ItemLinks.Add(this.BbiLamMoi);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 725);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(934, 33);
            // 
            // CmbSDTNCC
            // 
            this.CmbSDTNCC.FormattingEnabled = true;
            this.CmbSDTNCC.Location = new System.Drawing.Point(440, 261);
            this.CmbSDTNCC.Name = "CmbSDTNCC";
            this.CmbSDTNCC.Size = new System.Drawing.Size(152, 24);
            this.CmbSDTNCC.TabIndex = 65;
            // 
            // CmbTenNCC
            // 
            this.CmbTenNCC.FormattingEnabled = true;
            this.CmbTenNCC.Location = new System.Drawing.Point(440, 222);
            this.CmbTenNCC.Name = "CmbTenNCC";
            this.CmbTenNCC.Size = new System.Drawing.Size(152, 24);
            this.CmbTenNCC.TabIndex = 64;
            // 
            // CmbMaNCC
            // 
            this.CmbMaNCC.FormattingEnabled = true;
            this.CmbMaNCC.Location = new System.Drawing.Point(440, 178);
            this.CmbMaNCC.Name = "CmbMaNCC";
            this.CmbMaNCC.Size = new System.Drawing.Size(152, 24);
            this.CmbMaNCC.TabIndex = 63;
            // 
            // CmbTenNV
            // 
            this.CmbTenNV.FormattingEnabled = true;
            this.CmbTenNV.Location = new System.Drawing.Point(746, 222);
            this.CmbTenNV.Name = "CmbTenNV";
            this.CmbTenNV.Size = new System.Drawing.Size(145, 24);
            this.CmbTenNV.TabIndex = 62;
            // 
            // CmbMaNV
            // 
            this.CmbMaNV.FormattingEnabled = true;
            this.CmbMaNV.Location = new System.Drawing.Point(746, 178);
            this.CmbMaNV.Name = "CmbMaNV";
            this.CmbMaNV.Size = new System.Drawing.Size(145, 24);
            this.CmbMaNV.TabIndex = 61;
            // 
            // DtpThoiGianNhap
            // 
            this.DtpThoiGianNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpThoiGianNhap.Location = new System.Drawing.Point(117, 263);
            this.DtpThoiGianNhap.Name = "DtpThoiGianNhap";
            this.DtpThoiGianNhap.Size = new System.Drawing.Size(158, 23);
            this.DtpThoiGianNhap.TabIndex = 60;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(37, 268);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(53, 16);
            this.labelControl7.TabIndex = 59;
            this.labelControl7.Text = "Thời gian";
            // 
            // TeThanhTien
            // 
            this.TeThanhTien.Location = new System.Drawing.Point(117, 219);
            this.TeThanhTien.MenuManager = this.ribbonControl;
            this.TeThanhTien.Name = "TeThanhTien";
            this.TeThanhTien.Size = new System.Drawing.Size(158, 22);
            this.TeThanhTien.TabIndex = 58;
            // 
            // TeMaDonNhap
            // 
            this.TeMaDonNhap.Location = new System.Drawing.Point(117, 178);
            this.TeMaDonNhap.MenuManager = this.ribbonControl;
            this.TeMaDonNhap.Name = "TeMaDonNhap";
            this.TeMaDonNhap.Size = new System.Drawing.Size(158, 22);
            this.TeMaDonNhap.TabIndex = 57;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(37, 225);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(61, 16);
            this.labelControl9.TabIndex = 56;
            this.labelControl9.Text = "Thành tiền";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(328, 268);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(75, 16);
            this.labelControl6.TabIndex = 55;
            this.labelControl6.Text = "Số điện thoại";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(328, 225);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(102, 16);
            this.labelControl5.TabIndex = 54;
            this.labelControl5.Text = "Tên nhà cung cấp";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(328, 181);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(97, 16);
            this.labelControl4.TabIndex = 53;
            this.labelControl4.Text = "Mã nhà cung cấp";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(655, 228);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(81, 16);
            this.labelControl3.TabIndex = 52;
            this.labelControl3.Text = "Tên nhân viên";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(655, 184);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 16);
            this.labelControl2.TabIndex = 51;
            this.labelControl2.Text = "Mã nhân viên";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(37, 181);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 16);
            this.labelControl1.TabIndex = 50;
            this.labelControl1.Text = "Mã đơn nhập";
            // 
            // UcQLNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CmbSDTNCC);
            this.Controls.Add(this.CmbTenNCC);
            this.Controls.Add(this.CmbMaNCC);
            this.Controls.Add(this.CmbTenNV);
            this.Controls.Add(this.CmbMaNV);
            this.Controls.Add(this.DtpThoiGianNhap);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.TeThanhTien);
            this.Controls.Add(this.TeMaDonNhap);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.GcQLNhapHang);
            this.Controls.Add(this.ribbonControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UcQLNhapHang";
            this.Size = new System.Drawing.Size(934, 758);
            ((System.ComponentModel.ISupportInitialize)(this.GcQLNhapHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeThanhTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMaDonNhap.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl GcQLNhapHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
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
        private System.Windows.Forms.DateTimePicker DtpThoiGianNhap;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit TeThanhTien;
        private DevExpress.XtraEditors.TextEdit TeMaDonNhap;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
