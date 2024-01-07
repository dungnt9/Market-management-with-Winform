namespace market_management
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
            this.BbiThemMoi = new DevExpress.XtraBars.BarButtonItem();
            this.BbiSua = new DevExpress.XtraBars.BarButtonItem();
            this.BbiXoa = new DevExpress.XtraBars.BarButtonItem();
            this.BbiLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.RpDanhMucNV = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.RpgTacVu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
            this.GcDanhMucNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GcDanhMucNV.Location = new System.Drawing.Point(0, 281);
            this.GcDanhMucNV.MainView = this.gridView;
            this.GcDanhMucNV.MenuManager = this.RcDanhMucNV;
            this.GcDanhMucNV.Name = "GcDanhMucNV";
            this.GcDanhMucNV.Size = new System.Drawing.Size(800, 311);
            this.GcDanhMucNV.TabIndex = 2;
            this.GcDanhMucNV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.GridControl = this.GcDanhMucNV;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            // 
            // RcDanhMucNV
            // 
            this.RcDanhMucNV.ExpandCollapseItem.Id = 0;
            this.RcDanhMucNV.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.RcDanhMucNV.ExpandCollapseItem,
            this.bbiPrintPreview,
            this.BbiThemMoi,
            this.BbiSua,
            this.BbiXoa,
            this.BbiLamMoi});
            this.RcDanhMucNV.Location = new System.Drawing.Point(0, 0);
            this.RcDanhMucNV.MaxItemId = 21;
            this.RcDanhMucNV.Name = "RcDanhMucNV";
            this.RcDanhMucNV.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.RpDanhMucNV});
            this.RcDanhMucNV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.RcDanhMucNV.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.RcDanhMucNV.Size = new System.Drawing.Size(802, 126);
            this.RcDanhMucNV.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Id = 20;
            this.bbiPrintPreview.Name = "bbiPrintPreview";
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
            // BbiXoa
            // 
            this.BbiXoa.Caption = "Xoá";
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
            // DeNgaySinh
            // 
            this.DeNgaySinh.EditValue = null;
            this.DeNgaySinh.Location = new System.Drawing.Point(110, 251);
            this.DeNgaySinh.Name = "DeNgaySinh";
            this.DeNgaySinh.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeNgaySinh.Properties.Appearance.Options.UseFont = true;
            this.DeNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DeNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DeNgaySinh.Size = new System.Drawing.Size(128, 22);
            this.DeNgaySinh.TabIndex = 38;
            // 
            // CbeChucVu
            // 
            this.CbeChucVu.Location = new System.Drawing.Point(615, 251);
            this.CbeChucVu.Name = "CbeChucVu";
            this.CbeChucVu.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbeChucVu.Properties.Appearance.Options.UseFont = true;
            this.CbeChucVu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbeChucVu.Size = new System.Drawing.Size(144, 22);
            this.CbeChucVu.TabIndex = 37;
            // 
            // CbeGioiTinh
            // 
            this.CbeGioiTinh.Location = new System.Drawing.Point(348, 143);
            this.CbeGioiTinh.Name = "CbeGioiTinh";
            this.CbeGioiTinh.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbeGioiTinh.Properties.Appearance.Options.UseFont = true;
            this.CbeGioiTinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbeGioiTinh.Size = new System.Drawing.Size(122, 22);
            this.CbeGioiTinh.TabIndex = 36;
            // 
            // LbChucVu
            // 
            this.LbChucVu.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbChucVu.Appearance.Options.UseFont = true;
            this.LbChucVu.Location = new System.Drawing.Point(496, 252);
            this.LbChucVu.Name = "LbChucVu";
            this.LbChucVu.Size = new System.Drawing.Size(45, 15);
            this.LbChucVu.TabIndex = 35;
            this.LbChucVu.Text = "Chức Vụ";
            // 
            // TeCCCD
            // 
            this.TeCCCD.Location = new System.Drawing.Point(615, 197);
            this.TeCCCD.Name = "TeCCCD";
            this.TeCCCD.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeCCCD.Properties.Appearance.Options.UseFont = true;
            this.TeCCCD.Size = new System.Drawing.Size(144, 22);
            this.TeCCCD.TabIndex = 34;
            // 
            // LbCCCD
            // 
            this.LbCCCD.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCCCD.Appearance.Options.UseFont = true;
            this.LbCCCD.Location = new System.Drawing.Point(496, 200);
            this.LbCCCD.Name = "LbCCCD";
            this.LbCCCD.Size = new System.Drawing.Size(103, 15);
            this.LbCCCD.TabIndex = 33;
            this.LbCCCD.Text = "Căn cước công dân";
            // 
            // TeDiaChi
            // 
            this.TeDiaChi.Location = new System.Drawing.Point(615, 141);
            this.TeDiaChi.Name = "TeDiaChi";
            this.TeDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeDiaChi.Properties.Appearance.Options.UseFont = true;
            this.TeDiaChi.Size = new System.Drawing.Size(144, 22);
            this.TeDiaChi.TabIndex = 32;
            // 
            // LbDiaChi
            // 
            this.LbDiaChi.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDiaChi.Appearance.Options.UseFont = true;
            this.LbDiaChi.Location = new System.Drawing.Point(496, 144);
            this.LbDiaChi.Name = "LbDiaChi";
            this.LbDiaChi.Size = new System.Drawing.Size(36, 15);
            this.LbDiaChi.TabIndex = 31;
            this.LbDiaChi.Text = "Địa chỉ";
            // 
            // TeEmail
            // 
            this.TeEmail.Location = new System.Drawing.Point(348, 249);
            this.TeEmail.Name = "TeEmail";
            this.TeEmail.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeEmail.Properties.Appearance.Options.UseFont = true;
            this.TeEmail.Size = new System.Drawing.Size(122, 22);
            this.TeEmail.TabIndex = 30;
            // 
            // LbEmail
            // 
            this.LbEmail.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEmail.Appearance.Options.UseFont = true;
            this.LbEmail.Location = new System.Drawing.Point(263, 252);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(29, 15);
            this.LbEmail.TabIndex = 29;
            this.LbEmail.Text = "Email";
            // 
            // TeSDT
            // 
            this.TeSDT.Location = new System.Drawing.Point(348, 197);
            this.TeSDT.Name = "TeSDT";
            this.TeSDT.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeSDT.Properties.Appearance.Options.UseFont = true;
            this.TeSDT.Size = new System.Drawing.Size(122, 22);
            this.TeSDT.TabIndex = 28;
            // 
            // LbSDT
            // 
            this.LbSDT.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSDT.Appearance.Options.UseFont = true;
            this.LbSDT.Location = new System.Drawing.Point(263, 200);
            this.LbSDT.Name = "LbSDT";
            this.LbSDT.Size = new System.Drawing.Size(69, 15);
            this.LbSDT.TabIndex = 27;
            this.LbSDT.Text = "Số điện thoại";
            // 
            // LbGioiTInh
            // 
            this.LbGioiTInh.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbGioiTInh.Appearance.Options.UseFont = true;
            this.LbGioiTInh.Location = new System.Drawing.Point(263, 144);
            this.LbGioiTInh.Name = "LbGioiTInh";
            this.LbGioiTInh.Size = new System.Drawing.Size(45, 15);
            this.LbGioiTInh.TabIndex = 26;
            this.LbGioiTInh.Text = "Giới tính";
            // 
            // LbNgaySinh
            // 
            this.LbNgaySinh.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNgaySinh.Appearance.Options.UseFont = true;
            this.LbNgaySinh.Location = new System.Drawing.Point(14, 252);
            this.LbNgaySinh.Name = "LbNgaySinh";
            this.LbNgaySinh.Size = new System.Drawing.Size(54, 15);
            this.LbNgaySinh.TabIndex = 25;
            this.LbNgaySinh.Text = "Ngày Sinh";
            // 
            // TeTenNV
            // 
            this.TeTenNV.Location = new System.Drawing.Point(110, 199);
            this.TeTenNV.Name = "TeTenNV";
            this.TeTenNV.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TeTenNV.Properties.Appearance.Options.UseFont = true;
            this.TeTenNV.Size = new System.Drawing.Size(128, 22);
            this.TeTenNV.TabIndex = 24;
            // 
            // LbTenNV
            // 
            this.LbTenNV.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTenNV.Appearance.Options.UseFont = true;
            this.LbTenNV.Location = new System.Drawing.Point(14, 200);
            this.LbTenNV.Name = "LbTenNV";
            this.LbTenNV.Size = new System.Drawing.Size(77, 15);
            this.LbTenNV.TabIndex = 23;
            this.LbTenNV.Text = "Tên Nhân Viên";
            // 
            // TeMaNV
            // 
            this.TeMaNV.Location = new System.Drawing.Point(110, 143);
            this.TeMaNV.Name = "TeMaNV";
            this.TeMaNV.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeMaNV.Properties.Appearance.Options.UseFont = true;
            this.TeMaNV.Size = new System.Drawing.Size(128, 22);
            this.TeMaNV.TabIndex = 22;
            // 
            // LbMaNV
            // 
            this.LbMaNV.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMaNV.Appearance.Options.UseFont = true;
            this.LbMaNV.Location = new System.Drawing.Point(14, 144);
            this.LbMaNV.Name = "LbMaNV";
            this.LbMaNV.Size = new System.Drawing.Size(75, 15);
            this.LbMaNV.TabIndex = 21;
            this.LbMaNV.Text = "Mã Nhân Viên";
            // 
            // UcNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.Controls.Add(this.GcDanhMucNV);
            this.Controls.Add(this.RcDanhMucNV);
            this.Name = "UcNhanVien";
            this.Size = new System.Drawing.Size(802, 608);
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
