namespace market_management
{
    partial class XemChiTietDonNhap
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
            this.GcChiTiet = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.GcChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GcChiTiet
            // 
            this.GcChiTiet.Location = new System.Drawing.Point(1, 2);
            this.GcChiTiet.MainView = this.gridView1;
            this.GcChiTiet.Name = "GcChiTiet";
            this.GcChiTiet.Size = new System.Drawing.Size(915, 707);
            this.GcChiTiet.TabIndex = 0;
            this.GcChiTiet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GcChiTiet;
            this.gridView1.Name = "gridView1";
            // 
            // XemChiTietDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 711);
            this.Controls.Add(this.GcChiTiet);
            this.Name = "XemChiTietDonNhap";
            this.Text = "Form Xem chi tiết đơn nhập";
            ((System.ComponentModel.ISupportInitialize)(this.GcChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GcChiTiet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}