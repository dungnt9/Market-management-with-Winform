namespace market_management
{
    partial class FrmXemCT_HDNhap
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
            this.GcChiTiet.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.GcChiTiet.Location = new System.Drawing.Point(-1, 2);
            this.GcChiTiet.MainView = this.gridView1;
            this.GcChiTiet.Margin = new System.Windows.Forms.Padding(2);
            this.GcChiTiet.Name = "GcChiTiet";
            this.GcChiTiet.Size = new System.Drawing.Size(688, 399);
            this.GcChiTiet.TabIndex = 0;
            this.GcChiTiet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.GcChiTiet;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 600;
            // 
            // FrmXemCT_HDNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 401);
            this.Controls.Add(this.GcChiTiet);
            this.IconOptions.Image = global::market_management.Properties.Resources.bieuTuong;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmXemCT_HDNhap";
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