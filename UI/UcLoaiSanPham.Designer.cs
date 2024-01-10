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
            this.BbiLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.RpDanhMucLSP = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.RpgTacVuLSP = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.CbeTenLoaiSP = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LbTenLSP = new DevExpress.XtraEditors.LabelControl();
            this.GcLoaiSP = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LbcMaLoaiSP = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.CmbTrangThai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.RcDanhMucLoaiSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbeTenLoaiSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcLoaiSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RcDanhMucLoaiSP
            // 
            this.RcDanhMucLoaiSP.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 37, 35, 37);
            this.RcDanhMucLoaiSP.ExpandCollapseItem.Id = 0;
            this.RcDanhMucLoaiSP.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.RcDanhMucLoaiSP.ExpandCollapseItem,
            this.BbiThem,
            this.BbiSua,
            this.BbiLamMoi});
            this.RcDanhMucLoaiSP.Location = new System.Drawing.Point(0, 0);
            this.RcDanhMucLoaiSP.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.RcDanhMucLoaiSP.MaxItemId = 20;
            this.RcDanhMucLoaiSP.Name = "RcDanhMucLoaiSP";
            this.RcDanhMucLoaiSP.OptionsMenuMinWidth = 449;
            this.RcDanhMucLoaiSP.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.RpDanhMucLSP});
            this.RcDanhMucLoaiSP.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.RcDanhMucLoaiSP.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.RcDanhMucLoaiSP.Size = new System.Drawing.Size(933, 154);
            this.RcDanhMucLoaiSP.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // BbiThem
            // 
            this.BbiThem.Caption = "Thêm";
            this.BbiThem.Id = 16;
            this.BbiThem.ImageOptions.ImageUri.Uri = "New";
            this.BbiThem.Name = "BbiThem";
            this.BbiThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiThem_ItemClick_1);
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
            this.RpgTacVuLSP.ItemLinks.Add(this.BbiLamMoi);
            this.RpgTacVuLSP.Name = "RpgTacVuLSP";
            // 
            // CbeTenLoaiSP
            // 
            this.CbeTenLoaiSP.Location = new System.Drawing.Point(598, 210);
            this.CbeTenLoaiSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbeTenLoaiSP.MenuManager = this.RcDanhMucLoaiSP;
            this.CbeTenLoaiSP.Name = "CbeTenLoaiSP";
            this.CbeTenLoaiSP.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbeTenLoaiSP.Properties.Appearance.Options.UseFont = true;
            this.CbeTenLoaiSP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbeTenLoaiSP.Properties.Sorted = true;
            this.CbeTenLoaiSP.Size = new System.Drawing.Size(232, 26);
            this.CbeTenLoaiSP.TabIndex = 22;
            // 
            // LbTenLSP
            // 
            this.LbTenLSP.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTenLSP.Appearance.Options.UseFont = true;
            this.LbTenLSP.Location = new System.Drawing.Point(441, 214);
            this.LbTenLSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LbTenLSP.Name = "LbTenLSP";
            this.LbTenLSP.Size = new System.Drawing.Size(120, 20);
            this.LbTenLSP.TabIndex = 20;
            this.LbTenLSP.Text = "Tên loại sản phẩm";
            // 
            // GcLoaiSP
            // 
            this.GcLoaiSP.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GcLoaiSP.Location = new System.Drawing.Point(4, 327);
            this.GcLoaiSP.MainView = this.gridView1;
            this.GcLoaiSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GcLoaiSP.MenuManager = this.RcDanhMucLoaiSP;
            this.GcLoaiSP.Name = "GcLoaiSP";
            this.GcLoaiSP.Size = new System.Drawing.Size(925, 411);
            this.GcLoaiSP.TabIndex = 37;
            this.GcLoaiSP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.GcLoaiSP;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 933;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // LbcMaLoaiSP
            // 
            this.LbcMaLoaiSP.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbcMaLoaiSP.Appearance.Options.UseFont = true;
            this.LbcMaLoaiSP.Location = new System.Drawing.Point(253, 218);
            this.LbcMaLoaiSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LbcMaLoaiSP.Name = "LbcMaLoaiSP";
            this.LbcMaLoaiSP.Size = new System.Drawing.Size(20, 18);
            this.LbcMaLoaiSP.TabIndex = 41;
            this.LbcMaLoaiSP.Text = "Mã";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(105, 218);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(120, 18);
            this.labelControl1.TabIndex = 42;
            this.labelControl1.Text = "Mã loại sản phẩm:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(442, 282);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 18);
            this.labelControl2.TabIndex = 45;
            this.labelControl2.Text = "Trạng thái";
            // 
            // CmbTrangThai
            // 
            this.CmbTrangThai.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTrangThai.FormattingEnabled = true;
            this.CmbTrangThai.Items.AddRange(new object[] {
            "Đang kinh doanh",
            "Không còn kinh doanh"});
            this.CmbTrangThai.Location = new System.Drawing.Point(598, 272);
            this.CmbTrangThai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbTrangThai.Name = "CmbTrangThai";
            this.CmbTrangThai.Size = new System.Drawing.Size(231, 26);
            this.CmbTrangThai.TabIndex = 46;
            // 
            // UcLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CmbTrangThai);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.LbcMaLoaiSP);
            this.Controls.Add(this.GcLoaiSP);
            this.Controls.Add(this.CbeTenLoaiSP);
            this.Controls.Add(this.LbTenLSP);
            this.Controls.Add(this.RcDanhMucLoaiSP);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UcLoaiSanPham";
            this.Size = new System.Drawing.Size(933, 738);
            this.Load += new System.EventHandler(this.UcLoaiSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RcDanhMucLoaiSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbeTenLoaiSP.Properties)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem BbiLamMoi;
        private DevExpress.XtraEditors.ComboBoxEdit CbeTenLoaiSP;
        private DevExpress.XtraEditors.LabelControl LbTenLSP;
        private DevExpress.XtraGrid.GridControl GcLoaiSP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl LbcMaLoaiSP;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox CmbTrangThai;
    }
}
