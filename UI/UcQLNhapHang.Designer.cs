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
            this.BbiXoa = new DevExpress.XtraBars.BarButtonItem();
            this.BbiLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.BsiXemChiTiet = new DevExpress.XtraBars.BarButtonItem();
            this.RpQLNhapHang = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.RpgTacVuNhapHang = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.LbcMaDN = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.GcQLNhapHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RcQLNhapHang)).BeginInit();
            this.SuspendLayout();
            // 
            // GcQLNhapHang
            // 
            this.GcQLNhapHang.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.GcQLNhapHang.Location = new System.Drawing.Point(0, 223);
            this.GcQLNhapHang.MainView = this.gridView;
            this.GcQLNhapHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GcQLNhapHang.MenuManager = this.RcQLNhapHang;
            this.GcQLNhapHang.Name = "GcQLNhapHang";
            this.GcQLNhapHang.Size = new System.Drawing.Size(934, 535);
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
            this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // RcQLNhapHang
            // 
            this.RcQLNhapHang.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 37, 35, 37);
            this.RcQLNhapHang.ExpandCollapseItem.Id = 0;
            this.RcQLNhapHang.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.RcQLNhapHang.ExpandCollapseItem,
            this.bsiRecordsCount,
            this.BbiNew,
            this.BbiXoa,
            this.BbiLamMoi,
            this.BsiXemChiTiet});
            this.RcQLNhapHang.Location = new System.Drawing.Point(0, 0);
            this.RcQLNhapHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RcQLNhapHang.MaxItemId = 21;
            this.RcQLNhapHang.Name = "RcQLNhapHang";
            this.RcQLNhapHang.OptionsMenuMinWidth = 385;
            this.RcQLNhapHang.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.RpQLNhapHang});
            this.RcQLNhapHang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.RcQLNhapHang.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.RcQLNhapHang.Size = new System.Drawing.Size(934, 154);
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
            this.RpgTacVuNhapHang.ItemLinks.Add(this.BbiXoa);
            this.RpgTacVuNhapHang.ItemLinks.Add(this.BbiLamMoi);
            this.RpgTacVuNhapHang.Name = "RpgTacVuNhapHang";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BsiXemChiTiet);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // LbcMaDN
            // 
            this.LbcMaDN.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbcMaDN.Appearance.Options.UseFont = true;
            this.LbcMaDN.Location = new System.Drawing.Point(508, 181);
            this.LbcMaDN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LbcMaDN.Name = "LbcMaDN";
            this.LbcMaDN.Size = new System.Drawing.Size(22, 21);
            this.LbcMaDN.TabIndex = 81;
            this.LbcMaDN.Text = "Mã";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(369, 181);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 21);
            this.labelControl1.TabIndex = 82;
            this.labelControl1.Text = "Mã đơn nhập:";
            // 
            // UcQLNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.LbcMaDN);
            this.Controls.Add(this.GcQLNhapHang);
            this.Controls.Add(this.RcQLNhapHang);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UcQLNhapHang";
            this.Size = new System.Drawing.Size(934, 758);
            this.Load += new System.EventHandler(this.UcQLNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GcQLNhapHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RcQLNhapHang)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem BbiXoa;
        private DevExpress.XtraBars.BarButtonItem BbiLamMoi;
        private DevExpress.XtraBars.BarButtonItem BsiXemChiTiet;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.LabelControl LbcMaDN;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}

