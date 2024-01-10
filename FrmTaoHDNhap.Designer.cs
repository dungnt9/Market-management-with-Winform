namespace market_management
{
    partial class FrmTaoHDNhap
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
            this.GcSP = new DevExpress.XtraGrid.GridControl();
            this.GvSP_HDN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.LbcTongTien = new DevExpress.XtraEditors.LabelControl();
            this.BtnTaoHD = new System.Windows.Forms.Button();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.LbcTenNV = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.CmbTenNCC = new System.Windows.Forms.ComboBox();
            this.LbcTenNCC = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.CbeTenSP = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TeSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.BtnThemSP = new System.Windows.Forms.Button();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.LbcThoiGian = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LbcMaHDN = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.GcSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvSP_HDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CbeTenSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSoLuong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GcSP
            // 
            this.GcSP.Location = new System.Drawing.Point(0, 180);
            this.GcSP.MainView = this.GvSP_HDN;
            this.GcSP.Name = "GcSP";
            this.GcSP.Size = new System.Drawing.Size(934, 423);
            this.GcSP.TabIndex = 2;
            this.GcSP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvSP_HDN});
            // 
            // GvSP_HDN
            // 
            this.GvSP_HDN.GridControl = this.GcSP;
            this.GvSP_HDN.Name = "GvSP_HDN";
            this.GvSP_HDN.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.GvSP_HDN_RowUpdated);
            this.GvSP_HDN.RowCountChanged += new System.EventHandler(this.GvSP_HDN_RowCountChanged);
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(664, 623);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(54, 16);
            this.labelControl11.TabIndex = 7;
            this.labelControl11.Text = "Tổng tiền";
            // 
            // LbcTongTien
            // 
            this.LbcTongTien.Location = new System.Drawing.Point(735, 623);
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
            this.BtnTaoHD.Click += new System.EventHandler(this.BtnTaoHD_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.LbcTenNV);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.CmbTenNCC);
            this.groupControl1.Controls.Add(this.LbcTenNCC);
            this.groupControl1.Location = new System.Drawing.Point(29, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(386, 134);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Khởi tạo hóa đơn nhập";
            // 
            // LbcTenNV
            // 
            this.LbcTenNV.Location = new System.Drawing.Point(141, 93);
            this.LbcTenNV.Name = "LbcTenNV";
            this.LbcTenNV.Size = new System.Drawing.Size(22, 16);
            this.LbcTenNV.TabIndex = 3;
            this.LbcTenNV.Text = "Tên";
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
            this.CmbTenNCC.Size = new System.Drawing.Size(192, 24);
            this.CmbTenNCC.TabIndex = 1;
            this.CmbTenNCC.SelectedIndexChanged += new System.EventHandler(this.CmbTenNCC_SelectedIndexChanged);
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
            this.groupControl2.Controls.Add(this.CbeTenSP);
            this.groupControl2.Controls.Add(this.TeSoLuong);
            this.groupControl2.Controls.Add(this.BtnThemSP);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Location = new System.Drawing.Point(429, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(461, 134);
            this.groupControl2.TabIndex = 11;
            this.groupControl2.Text = "Thêm sản phẩm vào hóa đơn nhập";
            this.groupControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl2_Paint);
            // 
            // CbeTenSP
            // 
            this.CbeTenSP.Location = new System.Drawing.Point(193, 37);
            this.CbeTenSP.Name = "CbeTenSP";
            this.CbeTenSP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbeTenSP.Size = new System.Drawing.Size(192, 22);
            this.CbeTenSP.TabIndex = 5;
            this.CbeTenSP.SelectedIndexChanged += new System.EventHandler(this.CbeTenSP_SelectedIndexChanged);
            // 
            // TeSoLuong
            // 
            this.TeSoLuong.Location = new System.Drawing.Point(193, 71);
            this.TeSoLuong.Name = "TeSoLuong";
            this.TeSoLuong.Size = new System.Drawing.Size(192, 22);
            this.TeSoLuong.TabIndex = 4;
            this.TeSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeSoLuong_KeyPress);
            // 
            // BtnThemSP
            // 
            this.BtnThemSP.Location = new System.Drawing.Point(193, 103);
            this.BtnThemSP.Name = "BtnThemSP";
            this.BtnThemSP.Size = new System.Drawing.Size(117, 26);
            this.BtnThemSP.TabIndex = 2;
            this.BtnThemSP.Text = "Thêm sản phẩm";
            this.BtnThemSP.UseVisualStyleBackColor = true;
            this.BtnThemSP.Click += new System.EventHandler(this.BtnThemSP_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(73, 77);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(51, 16);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Số lượng";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(73, 43);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(82, 16);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Tên sản phẩm";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(401, 623);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(53, 16);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Thời gian";
            // 
            // LbcThoiGian
            // 
            this.LbcThoiGian.Location = new System.Drawing.Point(490, 623);
            this.LbcThoiGian.Name = "LbcThoiGian";
            this.LbcThoiGian.Size = new System.Drawing.Size(53, 16);
            this.LbcThoiGian.TabIndex = 13;
            this.LbcThoiGian.Text = "Thời gian";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(159, 621);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(99, 16);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Mã hóa đơn nhập";
            // 
            // LbcMaHDN
            // 
            this.LbcMaHDN.Location = new System.Drawing.Point(273, 623);
            this.LbcMaHDN.Name = "LbcMaHDN";
            this.LbcMaHDN.Size = new System.Drawing.Size(17, 16);
            this.LbcMaHDN.TabIndex = 15;
            this.LbcMaHDN.Text = "Mã";
            // 
            // FrmTaoDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 718);
            this.Controls.Add(this.LbcMaHDN);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.LbcThoiGian);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.BtnTaoHD);
            this.Controls.Add(this.LbcTongTien);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.GcSP);
            this.IconOptions.Image = global::market_management.Properties.Resources.bieuTuong;
            this.Name = "FrmTaoDonNhap";
            this.Text = "Form tạo hóa đơn nhập hàng";
            this.Load += new System.EventHandler(this.FrmTaoDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GcSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvSP_HDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CbeTenSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSoLuong.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl GcSP;
        private DevExpress.XtraGrid.Views.Grid.GridView GvSP_HDN;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl LbcTongTien;
        private System.Windows.Forms.Button BtnTaoHD;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl LbcTenNV;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox CmbTenNCC;
        private DevExpress.XtraEditors.LabelControl LbcTenNCC;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit TeSoLuong;
        private System.Windows.Forms.Button BtnThemSP;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl LbcThoiGian;
        private DevExpress.XtraEditors.ComboBoxEdit CbeTenSP;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl LbcMaHDN;
    }
}