namespace market_management.UI
{
    partial class UcTKSPDaBan
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
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.LbcTenSP = new DevExpress.XtraEditors.LabelControl();
            this.LbcSoSP = new DevExpress.XtraEditors.LabelControl();
            this.GcSanPhamDaBan = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GcTKSP = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.GcSanPhamDaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcTKSP)).BeginInit();
            this.GcTKSP.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(351, 41);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(220, 28);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Sản phẩm bán chạy nhất";
            // 
            // LbcTenSP
            // 
            this.LbcTenSP.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.LbcTenSP.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbcTenSP.Appearance.Options.UseFont = true;
            this.LbcTenSP.Location = new System.Drawing.Point(416, 75);
            this.LbcTenSP.Name = "LbcTenSP";
            this.LbcTenSP.Size = new System.Drawing.Size(83, 33);
            this.LbcTenSP.TabIndex = 7;
            this.LbcTenSP.Text = "Tên SP";
            // 
            // LbcSoSP
            // 
            this.LbcSoSP.Location = new System.Drawing.Point(429, 117);
            this.LbcSoSP.Name = "LbcSoSP";
            this.LbcSoSP.Size = new System.Drawing.Size(70, 16);
            this.LbcSoSP.TabIndex = 6;
            this.LbcSoSP.Text = "Số lượng SP";
            // 
            // GcSanPhamDaBan
            // 
            this.GcSanPhamDaBan.Location = new System.Drawing.Point(5, 149);
            this.GcSanPhamDaBan.MainView = this.gridView2;
            this.GcSanPhamDaBan.Name = "GcSanPhamDaBan";
            this.GcSanPhamDaBan.Size = new System.Drawing.Size(883, 567);
            this.GcSanPhamDaBan.TabIndex = 8;
            this.GcSanPhamDaBan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.GcSanPhamDaBan;
            this.gridView2.Name = "gridView2";
            // 
            // GcTKSP
            // 
            this.GcTKSP.Controls.Add(this.LbcTenSP);
            this.GcTKSP.Controls.Add(this.GcSanPhamDaBan);
            this.GcTKSP.Controls.Add(this.labelControl5);
            this.GcTKSP.Controls.Add(this.LbcSoSP);
            this.GcTKSP.Location = new System.Drawing.Point(22, 16);
            this.GcTKSP.Name = "GcTKSP";
            this.GcTKSP.Size = new System.Drawing.Size(893, 721);
            this.GcTKSP.TabIndex = 10;
            this.GcTKSP.Text = "Thống kê sản phẩm";
            // 
            // UcTKSPDaBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GcTKSP);
            this.Name = "UcTKSPDaBan";
            this.Size = new System.Drawing.Size(934, 758);
            ((System.ComponentModel.ISupportInitialize)(this.GcSanPhamDaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcTKSP)).EndInit();
            this.GcTKSP.ResumeLayout(false);
            this.GcTKSP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl LbcTenSP;
        private DevExpress.XtraEditors.LabelControl LbcSoSP;
        private DevExpress.XtraGrid.GridControl GcSanPhamDaBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GroupControl GcTKSP;
    }
}
