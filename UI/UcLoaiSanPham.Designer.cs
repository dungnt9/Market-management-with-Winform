namespace market_management.UI
{
    partial class UcLoaiSanPham
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
            this.RcDanhMucLoaiSP = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BbiThem = new DevExpress.XtraBars.BarButtonItem();
            this.BbiSua = new DevExpress.XtraBars.BarButtonItem();
            this.BbiXoa = new DevExpress.XtraBars.BarButtonItem();
            this.BbiLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.RpDanhMucLSP = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.RpgTacVuLSP = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.CbeTenLoaiSP = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CbeMaLoaiSP = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LbTenLSP = new DevExpress.XtraEditors.LabelControl();
            this.LbMaLSP = new DevExpress.XtraEditors.LabelControl();
            this.GcLoaiSP = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.RcDanhMucLoaiSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbeTenLoaiSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbeMaLoaiSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcLoaiSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RcDanhMucLoaiSP
            // 
            this.RcDanhMucLoaiSP.ExpandCollapseItem.Id = 0;
            this.RcDanhMucLoaiSP.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.RcDanhMucLoaiSP.ExpandCollapseItem,
            this.BbiThem,
            this.BbiSua,
            this.BbiXoa,
            this.BbiLamMoi});
            this.RcDanhMucLoaiSP.Location = new System.Drawing.Point(0, 0);
            this.RcDanhMucLoaiSP.MaxItemId = 20;
            this.RcDanhMucLoaiSP.Name = "RcDanhMucLoaiSP";
            this.RcDanhMucLoaiSP.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.RpDanhMucLSP});
            this.RcDanhMucLoaiSP.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.RcDanhMucLoaiSP.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.RcDanhMucLoaiSP.Size = new System.Drawing.Size(801, 126);
            this.RcDanhMucLoaiSP.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // BbiThem
            // 
            this.BbiThem.Caption = "Thêm";
            this.BbiThem.Id = 16;
            this.BbiThem.ImageOptions.ImageUri.Uri = "New";
            this.BbiThem.Name = "BbiThem";
            this.BbiThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiThem_ItemClick);
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
            // RpDanhMucLSP
            // 
            this.RpDanhMucLSP.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.RpDanhMucLSP.Appearance.Options.UseFont = true;
            this.RpDanhMucLSP.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.RpgTacVuLSP});
            this.RpDanhMucLSP.MergeOrder = 0;
            this.RpDanhMucLSP.Name = "RpDanhMucLSP";
            this.RpDanhMucLSP.Text = "Quản lý danh mục loại sản phẩm";
            // 
            // RpgTacVuLSP
            // 
            this.RpgTacVuLSP.AllowTextClipping = false;
            this.RpgTacVuLSP.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.RpgTacVuLSP.ItemLinks.Add(this.BbiThem);
            this.RpgTacVuLSP.ItemLinks.Add(this.BbiSua);
            this.RpgTacVuLSP.ItemLinks.Add(this.BbiXoa);
            this.RpgTacVuLSP.ItemLinks.Add(this.BbiLamMoi);
            this.RpgTacVuLSP.Name = "RpgTacVuLSP";
            // 
            // CbeTenLoaiSP
            // 
            this.CbeTenLoaiSP.Location = new System.Drawing.Point(560, 141);
            this.CbeTenLoaiSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbeTenLoaiSP.MenuManager = this.RcDanhMucLoaiSP;
            this.CbeTenLoaiSP.Name = "CbeTenLoaiSP";
            this.CbeTenLoaiSP.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbeTenLoaiSP.Properties.Appearance.Options.UseFont = true;
            this.CbeTenLoaiSP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbeTenLoaiSP.Properties.Sorted = true;
            this.CbeTenLoaiSP.Size = new System.Drawing.Size(171, 22);
            this.CbeTenLoaiSP.TabIndex = 22;
            // 
            // CbeMaLoaiSP
            // 
            this.CbeMaLoaiSP.Location = new System.Drawing.Point(190, 141);
            this.CbeMaLoaiSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbeMaLoaiSP.MenuManager = this.RcDanhMucLoaiSP;
            this.CbeMaLoaiSP.Name = "CbeMaLoaiSP";
            this.CbeMaLoaiSP.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbeMaLoaiSP.Properties.Appearance.Options.UseFont = true;
            this.CbeMaLoaiSP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbeMaLoaiSP.Properties.Sorted = true;
            this.CbeMaLoaiSP.Size = new System.Drawing.Size(171, 22);
            this.CbeMaLoaiSP.TabIndex = 21;
            this.CbeMaLoaiSP.SelectedIndexChanged += new System.EventHandler(this.CbeMaLoaiSP_SelectedIndexChanged);
            // 
            // LbTenLSP
            // 
            this.LbTenLSP.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTenLSP.Appearance.Options.UseFont = true;
            this.LbTenLSP.Location = new System.Drawing.Point(444, 143);
            this.LbTenLSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LbTenLSP.Name = "LbTenLSP";
            this.LbTenLSP.Size = new System.Drawing.Size(95, 15);
            this.LbTenLSP.TabIndex = 20;
            this.LbTenLSP.Text = "Tên loại sản phẩm";
            // 
            // LbMaLSP
            // 
            this.LbMaLSP.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMaLSP.Appearance.Options.UseFont = true;
            this.LbMaLSP.Location = new System.Drawing.Point(76, 141);
            this.LbMaLSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LbMaLSP.Name = "LbMaLSP";
            this.LbMaLSP.Size = new System.Drawing.Size(94, 15);
            this.LbMaLSP.TabIndex = 19;
            this.LbMaLSP.Text = "Mã loại sản phẩm";
            // 
            // GcLoaiSP
            // 
            this.GcLoaiSP.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GcLoaiSP.Location = new System.Drawing.Point(0, 176);
            this.GcLoaiSP.MainView = this.gridView1;
            this.GcLoaiSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GcLoaiSP.MenuManager = this.RcDanhMucLoaiSP;
            this.GcLoaiSP.Name = "GcLoaiSP";
            this.GcLoaiSP.Size = new System.Drawing.Size(801, 440);
            this.GcLoaiSP.TabIndex = 37;
            this.GcLoaiSP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.GcLoaiSP;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 686;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // UcLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GcLoaiSP);
            this.Controls.Add(this.CbeTenLoaiSP);
            this.Controls.Add(this.CbeMaLoaiSP);
            this.Controls.Add(this.LbTenLSP);
            this.Controls.Add(this.LbMaLSP);
            this.Controls.Add(this.RcDanhMucLoaiSP);
            this.Name = "UcLoaiSanPham";
            this.Size = new System.Drawing.Size(801, 616);
            this.Load += new System.EventHandler(this.UcLoaiSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RcDanhMucLoaiSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbeTenLoaiSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbeMaLoaiSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcLoaiSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl RcDanhMucLoaiSP;
        private DevExpress.XtraBars.Ribbon.RibbonPage RpDanhMucLSP;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup RpgTacVuLSP;
        private DevExpress.XtraBars.BarButtonItem BbiThem;
        private DevExpress.XtraBars.BarButtonItem BbiSua;
        private DevExpress.XtraBars.BarButtonItem BbiXoa;
        private DevExpress.XtraBars.BarButtonItem BbiLamMoi;
        private DevExpress.XtraEditors.ComboBoxEdit CbeTenLoaiSP;
        private DevExpress.XtraEditors.ComboBoxEdit CbeMaLoaiSP;
        private DevExpress.XtraEditors.LabelControl LbTenLSP;
        private DevExpress.XtraEditors.LabelControl LbMaLSP;
        private DevExpress.XtraGrid.GridControl GcLoaiSP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
