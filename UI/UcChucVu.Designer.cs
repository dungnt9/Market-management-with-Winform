namespace market_management.UI
{
    partial class UcChucVu
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
            this.GcChucVu = new DevExpress.XtraGrid.GridControl();
            this.GvChucVu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.BbiThemCV = new DevExpress.XtraBars.BarButtonItem();
            this.BbiSuaCV = new DevExpress.XtraBars.BarButtonItem();
            this.BbiXoaCV = new DevExpress.XtraBars.BarButtonItem();
            this.BbiLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TeTenCV = new DevExpress.XtraEditors.TextEdit();
            this.CbeCapQuanLy = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TeMoTa = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.GcChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeTenCV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbeCapQuanLy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMoTa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GcChucVu
            // 
            this.GcChucVu.Location = new System.Drawing.Point(0, 235);
            this.GcChucVu.MainView = this.GvChucVu;
            this.GcChucVu.MenuManager = this.ribbonControl;
            this.GcChucVu.Name = "GcChucVu";
            this.GcChucVu.Size = new System.Drawing.Size(800, 332);
            this.GcChucVu.TabIndex = 2;
            this.GcChucVu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvChucVu});
            // 
            // GvChucVu
            // 
            this.GvChucVu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.GvChucVu.GridControl = this.GcChucVu;
            this.GvChucVu.Name = "GvChucVu";
            this.GvChucVu.OptionsBehavior.Editable = false;
            this.GvChucVu.OptionsBehavior.ReadOnly = true;
            this.GvChucVu.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GvChucVu_FocusedRowChanged);
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.bbiPrintPreview,
            this.bsiRecordsCount,
            this.BbiThemCV,
            this.BbiSuaCV,
            this.BbiXoaCV,
            this.BbiLamMoi});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 20;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(800, 126);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Print Preview";
            this.bbiPrintPreview.Id = 14;
            this.bbiPrintPreview.ImageOptions.ImageUri.Uri = "Preview";
            this.bbiPrintPreview.Name = "bbiPrintPreview";
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            // 
            // BbiThemCV
            // 
            this.BbiThemCV.Caption = "Thêm";
            this.BbiThemCV.Id = 16;
            this.BbiThemCV.ImageOptions.ImageUri.Uri = "New";
            this.BbiThemCV.Name = "BbiThemCV";
            this.BbiThemCV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiThemCV_ItemClick);
            // 
            // BbiSuaCV
            // 
            this.BbiSuaCV.Caption = "Sửa";
            this.BbiSuaCV.Id = 17;
            this.BbiSuaCV.ImageOptions.ImageUri.Uri = "Edit";
            this.BbiSuaCV.Name = "BbiSuaCV";
            this.BbiSuaCV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiSuaCV_ItemClick);
            // 
            // BbiXoaCV
            // 
            this.BbiXoaCV.Caption = "Xóa";
            this.BbiXoaCV.Id = 18;
            this.BbiXoaCV.ImageOptions.ImageUri.Uri = "Delete";
            this.BbiXoaCV.Name = "BbiXoaCV";
            this.BbiXoaCV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiXoaCV_ItemClick);
            // 
            // BbiLamMoi
            // 
            this.BbiLamMoi.Caption = "Làm Mới";
            this.BbiLamMoi.Id = 19;
            this.BbiLamMoi.ImageOptions.ImageUri.Uri = "Refresh";
            this.BbiLamMoi.Name = "BbiLamMoi";
            this.BbiLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiLamMoi_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản Lý Chức Vụ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.BbiThemCV);
            this.ribbonPageGroup1.ItemLinks.Add(this.BbiSuaCV);
            this.ribbonPageGroup1.ItemLinks.Add(this.BbiXoaCV);
            this.ribbonPageGroup1.ItemLinks.Add(this.BbiLamMoi);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 573);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(800, 27);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(46, 142);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 17);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Tên Chức Vụ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(46, 175);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 17);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Cấp Quản Lý";
            // 
            // TeTenCV
            // 
            this.TeTenCV.Location = new System.Drawing.Point(158, 142);
            this.TeTenCV.MenuManager = this.ribbonControl;
            this.TeTenCV.Name = "TeTenCV";
            this.TeTenCV.Size = new System.Drawing.Size(298, 20);
            this.TeTenCV.TabIndex = 7;
            // 
            // CbeCapQuanLy
            // 
            this.CbeCapQuanLy.Location = new System.Drawing.Point(158, 175);
            this.CbeCapQuanLy.MenuManager = this.ribbonControl;
            this.CbeCapQuanLy.Name = "CbeCapQuanLy";
            this.CbeCapQuanLy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbeCapQuanLy.Properties.Items.AddRange(new object[] {
            "Có",
            "Không"});
            this.CbeCapQuanLy.Size = new System.Drawing.Size(100, 20);
            this.CbeCapQuanLy.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(46, 212);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 17);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Mô Tả";
            // 
            // TeMoTa
            // 
            this.TeMoTa.Location = new System.Drawing.Point(158, 212);
            this.TeMoTa.MenuManager = this.ribbonControl;
            this.TeMoTa.Name = "TeMoTa";
            this.TeMoTa.Size = new System.Drawing.Size(550, 20);
            this.TeMoTa.TabIndex = 12;
            // 
            // UcChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TeMoTa);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.CbeCapQuanLy);
            this.Controls.Add(this.TeTenCV);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.GcChucVu);
            this.Controls.Add(this.ribbonControl);
            this.Name = "UcChucVu";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.GcChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeTenCV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbeCapQuanLy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMoTa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GcChucVu;
        private DevExpress.XtraGrid.Views.Grid.GridView GvChucVu;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem BbiThemCV;
        private DevExpress.XtraBars.BarButtonItem BbiSuaCV;
        private DevExpress.XtraBars.BarButtonItem BbiXoaCV;
        private DevExpress.XtraBars.BarButtonItem BbiLamMoi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TeTenCV;
        private DevExpress.XtraEditors.ComboBoxEdit CbeCapQuanLy;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TeMoTa;
    }
}
