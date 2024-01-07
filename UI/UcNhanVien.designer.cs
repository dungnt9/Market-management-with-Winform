namespace Quản_lý_siêu_thị
{
    partial class UcNhanVien
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
            this.GcDanhMucNV = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RcDanhMucNV = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.BbiThemMoi = new DevExpress.XtraBars.BarButtonItem();
            this.BbiSua = new DevExpress.XtraBars.BarButtonItem();
            this.BbiXoa = new DevExpress.XtraBars.BarButtonItem();
            this.BbiLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.RpDanhMucNV = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.RpgTacVu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.DeNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.CbeChucVu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CbeGioiTinh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LbChucVu = new DevExpress.XtraEditors.LabelControl();
            this.TeCCCD = new DevExpress.XtraEditors.TextEdit();
            this.LbCCCD = new DevExpress.XtraEditors.LabelControl();
            this.TeDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.LbDiaChi = new DevExpress.XtraEditors.LabelControl();
            this.TeEmail = new DevExpress.XtraEditors.TextEdit();
            this.LbEmail = new DevExpress.XtraEditors.LabelControl();
            this.TeSDT = new DevExpress.XtraEditors.TextEdit();
            this.LbSDT = new DevExpress.XtraEditors.LabelControl();
            this.LbGioiTInh = new DevExpress.XtraEditors.LabelControl();
            this.LbNgaySinh = new DevExpress.XtraEditors.LabelControl();
            this.TeTenNV = new DevExpress.XtraEditors.TextEdit();
            this.LbTenNV = new DevExpress.XtraEditors.LabelControl();
            this.TeMaNV = new DevExpress.XtraEditors.TextEdit();
            this.LbMaNV = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.GcDanhMucNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RcDanhMucNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbeChucVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbeGioiTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeCCCD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeTenNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMaNV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GcDanhMucNV
            // 
            this.GcDanhMucNV.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GcDanhMucNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GcDanhMucNV.Location = new System.Drawing.Point(0, 356);
            this.GcDanhMucNV.MainView = this.gridView;
            this.GcDanhMucNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GcDanhMucNV.MenuManager = this.RcDanhMucNV;
            this.GcDanhMucNV.Name = "GcDanhMucNV";
            this.GcDanhMucNV.Size = new System.Drawing.Size(933, 383);
            this.GcDanhMucNV.TabIndex = 2;
            this.GcDanhMucNV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.DetailHeight = 431;
            this.gridView.GridControl = this.GcDanhMucNV;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.OptionsEditForm.PopupEditFormWidth = 933;
            // 
            // RcDanhMucNV
            // 
            this.RcDanhMucNV.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 37, 35, 37);
            this.RcDanhMucNV.ExpandCollapseItem.Id = 0;
            this.RcDanhMucNV.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.RcDanhMucNV.ExpandCollapseItem,
            this.bbiPrintPreview,
            this.bsiRecordsCount,
            this.BbiThemMoi,
            this.BbiSua,
            this.BbiXoa,
            this.BbiLamMoi});
            this.RcDanhMucNV.Location = new System.Drawing.Point(0, 0);
            this.RcDanhMucNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RcDanhMucNV.MaxItemId = 20;
            this.RcDanhMucNV.Name = "RcDanhMucNV";
            this.RcDanhMucNV.OptionsMenuMinWidth = 385;
            this.RcDanhMucNV.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.RpDanhMucNV});
            this.RcDanhMucNV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.RcDanhMucNV.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.RcDanhMucNV.Size = new System.Drawing.Size(933, 154);
            this.RcDanhMucNV.StatusBar = this.ribbonStatusBar;
            this.RcDanhMucNV.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Tìm kiếm";
            this.bbiPrintPreview.Id = 14;
            this.bbiPrintPreview.ImageOptions.ImageUri.Uri = "Preview";
            this.bbiPrintPreview.Name = "bbiPrintPreview";
            this.bbiPrintPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrintPreview_ItemClick);
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
            // RpDanhMucNV
            // 
            this.RpDanhMucNV.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.RpDanhMucNV.Appearance.Options.UseFont = true;
            this.RpDanhMucNV.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.RpgTacVu});
            this.RpDanhMucNV.MergeOrder = 0;
            this.RpDanhMucNV.Name = "RpDanhMucNV";
            this.RpDanhMucNV.Text = "Danh mục nhân viên";
            // 
            // RpgTacVu
            // 
            this.RpgTacVu.AllowTextClipping = false;
            this.RpgTacVu.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.RpgTacVu.ItemLinks.Add(this.BbiThemMoi);
            this.RpgTacVu.ItemLinks.Add(this.BbiSua);
            this.RpgTacVu.ItemLinks.Add(this.BbiXoa);
            this.RpgTacVu.ItemLinks.Add(this.BbiLamMoi);
            this.RpgTacVu.Name = "RpgTacVu";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 705);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.RcDanhMucNV;
            this.ribbonStatusBar.Size = new System.Drawing.Size(933, 33);
            // 
            // DeNgaySinh
            // 
            this.DeNgaySinh.EditValue = null;
            this.DeNgaySinh.Location = new System.Drawing.Point(128, 321);
            this.DeNgaySinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeNgaySinh.Name = "DeNgaySinh";
            this.DeNgaySinh.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeNgaySinh.Properties.Appearance.Options.UseFont = true;
            this.DeNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DeNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DeNgaySinh.Size = new System.Drawing.Size(149, 26);
            this.DeNgaySinh.TabIndex = 38;
            // 
            // CbeChucVu
            // 
            this.CbeChucVu.Location = new System.Drawing.Point(718, 321);
            this.CbeChucVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbeChucVu.Name = "CbeChucVu";
            this.CbeChucVu.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbeChucVu.Properties.Appearance.Options.UseFont = true;
            this.CbeChucVu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbeChucVu.Size = new System.Drawing.Size(168, 26);
            this.CbeChucVu.TabIndex = 37;
            // 
            // CbeGioiTinh
            // 
            this.CbeGioiTinh.Location = new System.Drawing.Point(406, 176);
            this.CbeGioiTinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbeGioiTinh.Name = "CbeGioiTinh";
            this.CbeGioiTinh.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbeGioiTinh.Properties.Appearance.Options.UseFont = true;
            this.CbeGioiTinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbeGioiTinh.Size = new System.Drawing.Size(142, 26);
            this.CbeGioiTinh.TabIndex = 36;
            // 
            // LbChucVu
            // 
            this.LbChucVu.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbChucVu.Appearance.Options.UseFont = true;
            this.LbChucVu.Location = new System.Drawing.Point(579, 322);
            this.LbChucVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LbChucVu.Name = "LbChucVu";
            this.LbChucVu.Size = new System.Drawing.Size(54, 20);
            this.LbChucVu.TabIndex = 35;
            this.LbChucVu.Text = "Chức Vụ";
            // 
            // TeCCCD
            // 
            this.TeCCCD.Location = new System.Drawing.Point(718, 242);
            this.TeCCCD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TeCCCD.Name = "TeCCCD";
            this.TeCCCD.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeCCCD.Properties.Appearance.Options.UseFont = true;
            this.TeCCCD.Size = new System.Drawing.Size(168, 26);
            this.TeCCCD.TabIndex = 34;
            // 
            // LbCCCD
            // 
            this.LbCCCD.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCCCD.Appearance.Options.UseFont = true;
            this.LbCCCD.Location = new System.Drawing.Point(579, 246);
            this.LbCCCD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LbCCCD.Name = "LbCCCD";
            this.LbCCCD.Size = new System.Drawing.Size(127, 20);
            this.LbCCCD.TabIndex = 33;
            this.LbCCCD.Text = "Căn cước công dân";
            // 
            // TeDiaChi
            // 
            this.TeDiaChi.Location = new System.Drawing.Point(718, 174);
            this.TeDiaChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TeDiaChi.Name = "TeDiaChi";
            this.TeDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeDiaChi.Properties.Appearance.Options.UseFont = true;
            this.TeDiaChi.Size = new System.Drawing.Size(168, 26);
            this.TeDiaChi.TabIndex = 32;
            // 
            // LbDiaChi
            // 
            this.LbDiaChi.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDiaChi.Appearance.Options.UseFont = true;
            this.LbDiaChi.Location = new System.Drawing.Point(579, 177);
            this.LbDiaChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LbDiaChi.Name = "LbDiaChi";
            this.LbDiaChi.Size = new System.Drawing.Size(46, 20);
            this.LbDiaChi.TabIndex = 31;
            this.LbDiaChi.Text = "Địa chỉ";
            // 
            // TeEmail
            // 
            this.TeEmail.Location = new System.Drawing.Point(406, 319);
            this.TeEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TeEmail.Name = "TeEmail";
            this.TeEmail.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeEmail.Properties.Appearance.Options.UseFont = true;
            this.TeEmail.Size = new System.Drawing.Size(142, 26);
            this.TeEmail.TabIndex = 30;
            // 
            // LbEmail
            // 
            this.LbEmail.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEmail.Appearance.Options.UseFont = true;
            this.LbEmail.Location = new System.Drawing.Point(307, 322);
            this.LbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(37, 20);
            this.LbEmail.TabIndex = 29;
            this.LbEmail.Text = "Email";
            // 
            // TeSDT
            // 
            this.TeSDT.Location = new System.Drawing.Point(406, 242);
            this.TeSDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TeSDT.Name = "TeSDT";
            this.TeSDT.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeSDT.Properties.Appearance.Options.UseFont = true;
            this.TeSDT.Size = new System.Drawing.Size(142, 26);
            this.TeSDT.TabIndex = 28;
            // 
            // LbSDT
            // 
            this.LbSDT.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSDT.Appearance.Options.UseFont = true;
            this.LbSDT.Location = new System.Drawing.Point(307, 246);
            this.LbSDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LbSDT.Name = "LbSDT";
            this.LbSDT.Size = new System.Drawing.Size(88, 20);
            this.LbSDT.TabIndex = 27;
            this.LbSDT.Text = "Số điện thoại";
            // 
            // LbGioiTInh
            // 
            this.LbGioiTInh.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbGioiTInh.Appearance.Options.UseFont = true;
            this.LbGioiTInh.Location = new System.Drawing.Point(307, 177);
            this.LbGioiTInh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LbGioiTInh.Name = "LbGioiTInh";
            this.LbGioiTInh.Size = new System.Drawing.Size(56, 20);
            this.LbGioiTInh.TabIndex = 26;
            this.LbGioiTInh.Text = "Giới tính";
            // 
            // LbNgaySinh
            // 
            this.LbNgaySinh.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNgaySinh.Appearance.Options.UseFont = true;
            this.LbNgaySinh.Location = new System.Drawing.Point(16, 322);
            this.LbNgaySinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LbNgaySinh.Name = "LbNgaySinh";
            this.LbNgaySinh.Size = new System.Drawing.Size(67, 20);
            this.LbNgaySinh.TabIndex = 25;
            this.LbNgaySinh.Text = "Ngày Sinh";
            // 
            // TeTenNV
            // 
            this.TeTenNV.Location = new System.Drawing.Point(128, 245);
            this.TeTenNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TeTenNV.Name = "TeTenNV";
            this.TeTenNV.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeTenNV.Properties.Appearance.Options.UseFont = true;
            this.TeTenNV.Size = new System.Drawing.Size(149, 26);
            this.TeTenNV.TabIndex = 24;
            // 
            // LbTenNV
            // 
            this.LbTenNV.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTenNV.Appearance.Options.UseFont = true;
            this.LbTenNV.Location = new System.Drawing.Point(16, 246);
            this.LbTenNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LbTenNV.Name = "LbTenNV";
            this.LbTenNV.Size = new System.Drawing.Size(96, 20);
            this.LbTenNV.TabIndex = 23;
            this.LbTenNV.Text = "Tên Nhân Viên";
            // 
            // TeMaNV
            // 
            this.TeMaNV.Location = new System.Drawing.Point(128, 176);
            this.TeMaNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TeMaNV.Name = "TeMaNV";
            this.TeMaNV.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeMaNV.Properties.Appearance.Options.UseFont = true;
            this.TeMaNV.Size = new System.Drawing.Size(149, 26);
            this.TeMaNV.TabIndex = 22;
            // 
            // LbMaNV
            // 
            this.LbMaNV.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMaNV.Appearance.Options.UseFont = true;
            this.LbMaNV.Location = new System.Drawing.Point(16, 177);
            this.LbMaNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LbMaNV.Name = "LbMaNV";
            this.LbMaNV.Size = new System.Drawing.Size(93, 20);
            this.LbMaNV.TabIndex = 21;
            this.LbMaNV.Text = "Mã Nhân Viên";
            // 
            // UcNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeNgaySinh);
            this.Controls.Add(this.CbeChucVu);
            this.Controls.Add(this.CbeGioiTinh);
            this.Controls.Add(this.LbChucVu);
            this.Controls.Add(this.TeCCCD);
            this.Controls.Add(this.LbCCCD);
            this.Controls.Add(this.TeDiaChi);
            this.Controls.Add(this.LbDiaChi);
            this.Controls.Add(this.TeEmail);
            this.Controls.Add(this.LbEmail);
            this.Controls.Add(this.TeSDT);
            this.Controls.Add(this.LbSDT);
            this.Controls.Add(this.LbGioiTInh);
            this.Controls.Add(this.LbNgaySinh);
            this.Controls.Add(this.TeTenNV);
            this.Controls.Add(this.LbTenNV);
            this.Controls.Add(this.TeMaNV);
            this.Controls.Add(this.LbMaNV);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.GcDanhMucNV);
            this.Controls.Add(this.RcDanhMucNV);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UcNhanVien";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.UcNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GcDanhMucNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RcDanhMucNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbeChucVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbeGioiTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeCCCD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeTenNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMaNV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl GcDanhMucNV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraBars.Ribbon.RibbonControl RcDanhMucNV;
        private DevExpress.XtraBars.Ribbon.RibbonPage RpDanhMucNV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup RpgTacVu;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem BbiThemMoi;
        private DevExpress.XtraBars.BarButtonItem BbiSua;
        private DevExpress.XtraBars.BarButtonItem BbiXoa;
        private DevExpress.XtraBars.BarButtonItem BbiLamMoi;
        private DevExpress.XtraEditors.DateEdit DeNgaySinh;
        private DevExpress.XtraEditors.ComboBoxEdit CbeChucVu;
        private DevExpress.XtraEditors.ComboBoxEdit CbeGioiTinh;
        private DevExpress.XtraEditors.LabelControl LbChucVu;
        private DevExpress.XtraEditors.TextEdit TeCCCD;
        private DevExpress.XtraEditors.LabelControl LbCCCD;
        private DevExpress.XtraEditors.TextEdit TeDiaChi;
        private DevExpress.XtraEditors.LabelControl LbDiaChi;
        private DevExpress.XtraEditors.TextEdit TeEmail;
        private DevExpress.XtraEditors.LabelControl LbEmail;
        private DevExpress.XtraEditors.TextEdit TeSDT;
        private DevExpress.XtraEditors.LabelControl LbSDT;
        private DevExpress.XtraEditors.LabelControl LbGioiTInh;
        private DevExpress.XtraEditors.LabelControl LbNgaySinh;
        private DevExpress.XtraEditors.TextEdit TeTenNV;
        private DevExpress.XtraEditors.LabelControl LbTenNV;
        private DevExpress.XtraEditors.TextEdit TeMaNV;
        private DevExpress.XtraEditors.LabelControl LbMaNV;
    }
}
