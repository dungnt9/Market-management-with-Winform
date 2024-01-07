namespace market_management
{
    partial class FrmTaoDonNhap
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.LbcTongTien = new DevExpress.XtraEditors.LabelControl();
            this.BtnTaoHD = new System.Windows.Forms.Button();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.CmbTenNCC = new System.Windows.Forms.ComboBox();
            this.LbcTenNCC = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 180);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(934, 423);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(384, 620);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(54, 16);
            this.labelControl11.TabIndex = 7;
            this.labelControl11.Text = "Tổng tiền";
            // 
            // LbcTongTien
            // 
            this.LbcTongTien.Location = new System.Drawing.Point(475, 620);
            this.LbcTongTien.Name = "LbcTongTien";
            this.LbcTongTien.Size = new System.Drawing.Size(54, 16);
            this.LbcTongTien.TabIndex = 8;
            this.LbcTongTien.Text = "Tổng tiền";
            // 
            // BtnTaoHD
            // 
            this.BtnTaoHD.Location = new System.Drawing.Point(415, 654);
            this.BtnTaoHD.Name = "BtnTaoHD";
            this.BtnTaoHD.Size = new System.Drawing.Size(98, 30);
            this.BtnTaoHD.TabIndex = 9;
            this.BtnTaoHD.Text = "Tạo hóa đơn";
            this.BtnTaoHD.UseVisualStyleBackColor = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.CmbTenNCC);
            this.groupControl1.Controls.Add(this.LbcTenNCC);
            this.groupControl1.Location = new System.Drawing.Point(29, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(286, 134);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Khởi tạo hóa đơn nhập";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(141, 93);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(22, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tên";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 93);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tên nhân viên";
            // 
            // CmbTenNCC
            // 
            this.CmbTenNCC.FormattingEnabled = true;
            this.CmbTenNCC.Location = new System.Drawing.Point(141, 43);
            this.CmbTenNCC.Name = "CmbTenNCC";
            this.CmbTenNCC.Size = new System.Drawing.Size(121, 24);
            this.CmbTenNCC.TabIndex = 1;
            // 
            // LbcTenNCC
            // 
            this.LbcTenNCC.Location = new System.Drawing.Point(22, 46);
            this.LbcTenNCC.Name = "LbcTenNCC";
            this.LbcTenNCC.Size = new System.Drawing.Size(102, 16);
            this.LbcTenNCC.TabIndex = 0;
            this.LbcTenNCC.Text = "Tên nhà cung cấp";
            // 
            // groupControl2
            // 
            this.groupControl2.Location = new System.Drawing.Point(354, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(536, 134);
            this.groupControl2.TabIndex = 11;
            this.groupControl2.Text = "Thêm sản phẩm vào hóa đơn nhập";
            this.groupControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl2_Paint);
            // 
            // FrmTaoDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 718);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.BtnTaoHD);
            this.Controls.Add(this.LbcTongTien);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.gridControl1);
            this.IconOptions.Image = global::market_management.Properties.Resources.bieuTuong;
            this.Name = "FrmTaoDonNhap";
            this.Text = "Form tạo hóa đơn nhập hàng";
            this.Load += new System.EventHandler(this.FrmTaoDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl LbcTongTien;
        private System.Windows.Forms.Button BtnTaoHD;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox CmbTenNCC;
        private DevExpress.XtraEditors.LabelControl LbcTenNCC;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}