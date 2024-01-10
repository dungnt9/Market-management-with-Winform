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
            this.BbiTaoMoi = new DevExpress.XtraBars.BarButtonItem();
            this.BbiSua = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.BbiLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.RpQLMaGiamGia = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.RpgTacVuMGG = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
            this.DeNgayHetHan = new DevExpress.XtraEditors.DateEdit();
            this.LbNgayHetHan = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.GcMaGiamGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RcMGG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbePhanTram.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeTenChuongTrinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMaGiamGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeNgayTao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeNgayTao.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMoTa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeNgayHetHan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeNgayHetHan.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // GcMaGiamGia
            // 
            this.GcMaGiamGia.Location = new System.Drawing.Point(0, 281);
            this.GcMaGiamGia.MainView = this.gridView;
            this.GcMaGiamGia.MenuManager = this.RcMGG;
            this.GcMaGiamGia.Name = "GcMaGiamGia";
            this.GcMaGiamGia.Size = new System.Drawing.Size(870, 379);
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
            this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // RcMGG
            // 
            this.RcMGG.ExpandCollapseItem.Id = 0;
            this.RcMGG.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.RcMGG.ExpandCollapseItem,
            this.bbiPrintPreview,
            this.BbiTaoMoi,
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
            this.RcMGG.Size = new System.Drawing.Size(870, 126);
            this.RcMGG.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Id = 20;
            this.bbiPrintPreview.Name = "bbiPrintPreview";
            // 
            // BbiTaoMoi
            // 
            this.BbiTaoMoi.Caption = "Tạo mới";
            this.BbiTaoMoi.Id = 16;
            this.BbiTaoMoi.ImageOptions.ImageUri.Uri = "New";
            this.BbiTaoMoi.Name = "BbiTaoMoi";
            this.BbiTaoMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiTaoMoi_ItemClick);
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
            this.RpgTacVuMGG.ItemLinks.Add(this.BbiTaoMoi);
            this.RpgTacVuMGG.ItemLinks.Add(this.BbiSua);
            this.RpgTacVuMGG.ItemLinks.Add(this.BbiLamMoi);
            this.RpgTacVuMGG.Name = "RpgTacVuMGG";
            // 
            // CbePhanTram
            // 
            this.CbePhanTram.Location = new System.Drawing.Point(153, 250);
            this.CbePhanTram.Name = "CbePhanTram";
            this.CbePhanTram.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbePhanTram.Properties.Appearance.Options.UseFont = true;
            this.CbePhanTram.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbePhanTram.Size = new System.Drawing.Size(122, 26);
            this.CbePhanTram.TabIndex = 40;
            // 
            // LbNgayTao
            // 
            this.LbNgayTao.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNgayTao.Appearance.Options.UseFont = true;
            this.LbNgayTao.Location = new System.Drawing.Point(322, 206);
            this.LbNgayTao.Name = "LbNgayTao";
            this.LbNgayTao.Size = new System.Drawing.Size(64, 20);
            this.LbNgayTao.TabIndex = 42;
            this.LbNgayTao.Text = "Ngày Tạo";
            // 
            // LbPhanTram
            // 
            this.LbPhanTram.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPhanTram.Appearance.Options.UseFont = true;
            this.LbPhanTram.Location = new System.Drawing.Point(30, 253);
            this.LbPhanTram.Name = "LbPhanTram";
            this.LbPhanTram.Size = new System.Drawing.Size(69, 20);
            this.LbPhanTram.TabIndex = 41;
            this.LbPhanTram.Text = "Phần Trăm";
            // 
            // TeTenChuongTrinh
            // 
            this.TeTenChuongTrinh.Location = new System.Drawing.Point(153, 203);
            this.TeTenChuongTrinh.Name = "TeTenChuongTrinh";
            this.TeTenChuongTrinh.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeTenChuongTrinh.Properties.Appearance.Options.UseFont = true;
            this.TeTenChuongTrinh.Size = new System.Drawing.Size(128, 26);
            this.TeTenChuongTrinh.TabIndex = 39;
            // 
            // LbTenChuongTrinh
            // 
            this.LbTenChuongTrinh.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTenChuongTrinh.Appearance.Options.UseFont = true;
            this.LbTenChuongTrinh.Location = new System.Drawing.Point(30, 206);
            this.LbTenChuongTrinh.Name = "LbTenChuongTrinh";
            this.LbTenChuongTrinh.Size = new System.Drawing.Size(117, 20);
            this.LbTenChuongTrinh.TabIndex = 39;
            this.LbTenChuongTrinh.Text = "Tên Chương Trình";
            // 
            // TeMaGiamGia
            // 
            this.TeMaGiamGia.Location = new System.Drawing.Point(153, 150);
            this.TeMaGiamGia.Name = "TeMaGiamGia";
            this.TeMaGiamGia.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeMaGiamGia.Properties.Appearance.Options.UseFont = true;
            this.TeMaGiamGia.Size = new System.Drawing.Size(128, 26);
            this.TeMaGiamGia.TabIndex = 38;
            // 
            // LbMaGiamGia
            // 
            this.LbMaGiamGia.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMaGiamGia.Appearance.Options.UseFont = true;
            this.LbMaGiamGia.Location = new System.Drawing.Point(30, 150);
            this.LbMaGiamGia.Name = "LbMaGiamGia";
            this.LbMaGiamGia.Size = new System.Drawing.Size(86, 20);
            this.LbMaGiamGia.TabIndex = 37;
            this.LbMaGiamGia.Text = "Mã Giảm Giá";
            // 
            // DeNgayTao
            // 
            this.DeNgayTao.EditValue = null;
            this.DeNgayTao.Location = new System.Drawing.Point(422, 203);
            this.DeNgayTao.MenuManager = this.RcMGG;
            this.DeNgayTao.Name = "DeNgayTao";
            this.DeNgayTao.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeNgayTao.Properties.Appearance.Options.UseFont = true;
            this.DeNgayTao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DeNgayTao.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DeNgayTao.Size = new System.Drawing.Size(122, 26);
            this.DeNgayTao.TabIndex = 41;
            // 
            // TeMoTa
            // 
            this.TeMoTa.Location = new System.Drawing.Point(661, 206);
            this.TeMoTa.Name = "TeMoTa";
            this.TeMoTa.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeMoTa.Properties.Appearance.Options.UseFont = true;
            this.TeMoTa.Size = new System.Drawing.Size(164, 26);
            this.TeMoTa.TabIndex = 44;
            // 
            // LbMoTa
            // 
            this.LbMoTa.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMoTa.Appearance.Options.UseFont = true;
            this.LbMoTa.Location = new System.Drawing.Point(586, 206);
            this.LbMoTa.Name = "LbMoTa";
            this.LbMoTa.Size = new System.Drawing.Size(42, 20);
            this.LbMoTa.TabIndex = 56;
            this.LbMoTa.Text = "Mô Tả";
            // 
            // LbTrangThai
            // 
            this.LbTrangThai.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTrangThai.Appearance.Options.UseFont = true;
            this.LbTrangThai.Location = new System.Drawing.Point(586, 154);
            this.LbTrangThai.Name = "LbTrangThai";
            this.LbTrangThai.Size = new System.Drawing.Size(69, 20);
            this.LbTrangThai.TabIndex = 54;
            this.LbTrangThai.Text = "Trạng Thái";
            // 
            // RbConHieuLuc
            // 
            this.RbConHieuLuc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbConHieuLuc.Location = new System.Drawing.Point(661, 153);
            this.RbConHieuLuc.Name = "RbConHieuLuc";
            this.RbConHieuLuc.Size = new System.Drawing.Size(101, 22);
            this.RbConHieuLuc.TabIndex = 42;
            this.RbConHieuLuc.TabStop = true;
            this.RbConHieuLuc.Text = "Còn hiệu lực";
            this.RbConHieuLuc.UseVisualStyleBackColor = true;
            // 
            // RbHetHan
            // 
            this.RbHetHan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbHetHan.Location = new System.Drawing.Point(756, 154);
            this.RbHetHan.Name = "RbHetHan";
            this.RbHetHan.Size = new System.Drawing.Size(83, 20);
            this.RbHetHan.TabIndex = 43;
            this.RbHetHan.TabStop = true;
            this.RbHetHan.Text = "Hết hạn";
            this.RbHetHan.UseVisualStyleBackColor = true;
            // 
            // DeNgayHetHan
            // 
            this.DeNgayHetHan.EditValue = null;
            this.DeNgayHetHan.Location = new System.Drawing.Point(422, 148);
            this.DeNgayHetHan.MenuManager = this.RcMGG;
            this.DeNgayHetHan.Name = "DeNgayHetHan";
            this.DeNgayHetHan.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeNgayHetHan.Properties.Appearance.Options.UseFont = true;
            this.DeNgayHetHan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DeNgayHetHan.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DeNgayHetHan.Size = new System.Drawing.Size(122, 26);
            this.DeNgayHetHan.TabIndex = 58;
            // 
            // LbNgayHetHan
            // 
            this.LbNgayHetHan.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNgayHetHan.Appearance.Options.UseFont = true;
            this.LbNgayHetHan.Location = new System.Drawing.Point(322, 150);
            this.LbNgayHetHan.Name = "LbNgayHetHan";
            this.LbNgayHetHan.Size = new System.Drawing.Size(94, 20);
            this.LbNgayHetHan.TabIndex = 59;
            this.LbNgayHetHan.Text = "Ngày Hết Hạn";
            // 
            // UcQLMaGiamGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeNgayHetHan);
            this.Controls.Add(this.LbNgayHetHan);
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
            this.Controls.Add(this.GcMaGiamGia);
            this.Controls.Add(this.RcMGG);
            this.Name = "UcQLMaGiamGia";
            this.Size = new System.Drawing.Size(870, 660);
            ((System.ComponentModel.ISupportInitialize)(this.GcMaGiamGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RcMGG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbePhanTram.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeTenChuongTrinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMaGiamGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeNgayTao.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeNgayTao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMoTa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeNgayHetHan.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeNgayHetHan.Properties)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem BbiTaoMoi;
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
        private DevExpress.XtraEditors.DateEdit DeNgayHetHan;
        private DevExpress.XtraEditors.LabelControl LbNgayHetHan;
    }
}
