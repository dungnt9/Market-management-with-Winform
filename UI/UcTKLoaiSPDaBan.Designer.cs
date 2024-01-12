namespace market_management.UI
{
    partial class UcTKLoaiSPDaBan
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
            this.GcTKLoaiSP = new DevExpress.XtraEditors.GroupControl();
            this.LbcSoLoaiSP = new DevExpress.XtraEditors.LabelControl();
            this.GcLoaiSanPhamDaBan = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LbcTenLoaiSP = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.GcTKLoaiSP)).BeginInit();
            this.GcTKLoaiSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GcLoaiSanPhamDaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GcTKLoaiSP
            // 
            this.GcTKLoaiSP.Controls.Add(this.LbcSoLoaiSP);
            this.GcTKLoaiSP.Controls.Add(this.GcLoaiSanPhamDaBan);
            this.GcTKLoaiSP.Controls.Add(this.labelControl2);
            this.GcTKLoaiSP.Controls.Add(this.LbcTenLoaiSP);
            this.GcTKLoaiSP.Location = new System.Drawing.Point(3, 15);
            this.GcTKLoaiSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GcTKLoaiSP.Name = "GcTKLoaiSP";
            this.GcTKLoaiSP.Size = new System.Drawing.Size(864, 643);
            this.GcTKLoaiSP.TabIndex = 10;
            this.GcTKLoaiSP.Text = "Thống kê loại sản phẩm";
            // 
            // LbcSoLoaiSP
            // 
            this.LbcSoLoaiSP.Location = new System.Drawing.Point(26, 120);
            this.LbcSoLoaiSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LbcSoLoaiSP.Name = "LbcSoLoaiSP";
            this.LbcSoLoaiSP.Size = new System.Drawing.Size(76, 13);
            this.LbcSoLoaiSP.TabIndex = 3;
            this.LbcSoLoaiSP.Text = "Số lượng loại SP";
            // 
            // GcLoaiSanPhamDaBan
            // 
            this.GcLoaiSanPhamDaBan.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GcLoaiSanPhamDaBan.Location = new System.Drawing.Point(5, 147);
            this.GcLoaiSanPhamDaBan.MainView = this.gridView1;
            this.GcLoaiSanPhamDaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GcLoaiSanPhamDaBan.Name = "GcLoaiSanPhamDaBan";
            this.GcLoaiSanPhamDaBan.Size = new System.Drawing.Size(854, 492);
            this.GcLoaiSanPhamDaBan.TabIndex = 0;
            this.GcLoaiSanPhamDaBan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.GcLoaiSanPhamDaBan;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 686;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(26, 25);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(207, 21);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Loại sản phẩm bán chạy nhất";
            // 
            // LbcTenLoaiSP
            // 
            this.LbcTenLoaiSP.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.LbcTenLoaiSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbcTenLoaiSP.Appearance.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbcTenLoaiSP.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.LbcTenLoaiSP.Appearance.Options.UseFont = true;
            this.LbcTenLoaiSP.Appearance.Options.UseForeColor = true;
            this.LbcTenLoaiSP.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.LbcTenLoaiSP.LineVisible = true;
            this.LbcTenLoaiSP.Location = new System.Drawing.Point(26, 59);
            this.LbcTenLoaiSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LbcTenLoaiSP.Name = "LbcTenLoaiSP";
            this.LbcTenLoaiSP.Size = new System.Drawing.Size(136, 40);
            this.LbcTenLoaiSP.TabIndex = 4;
            this.LbcTenLoaiSP.Text = "Tên loại SP";
            // 
            // UcTKLoaiSPDaBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GcTKLoaiSP);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UcTKLoaiSPDaBan";
            this.Size = new System.Drawing.Size(870, 660);
            ((System.ComponentModel.ISupportInitialize)(this.GcTKLoaiSP)).EndInit();
            this.GcTKLoaiSP.ResumeLayout(false);
            this.GcTKLoaiSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GcLoaiSanPhamDaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl GcTKLoaiSP;
        private DevExpress.XtraEditors.LabelControl LbcSoLoaiSP;
        private DevExpress.XtraGrid.GridControl GcLoaiSanPhamDaBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl LbcTenLoaiSP;
    }
}
