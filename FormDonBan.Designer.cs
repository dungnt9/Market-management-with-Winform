namespace market_management
{
    partial class FormDonBan
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.CbeSDT = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TeDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.CbeGioiTinh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.DeNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.TeTenKH = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.GcSP_HDB = new DevExpress.XtraGrid.GridControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.TeSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.CbeTenSP = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.LbTenNV = new DevExpress.XtraEditors.LabelControl();
            this.LbThoiGian = new DevExpress.XtraEditors.LabelControl();
            this.LbTongTien = new DevExpress.XtraEditors.LabelControl();
            this.BtnTaoHoaDon = new System.Windows.Forms.Button();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LbMaHDB = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CbeSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbeGioiTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcSP_HDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbeTenSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.CbeSDT);
            this.groupControl1.Controls.Add(this.TeDiaChi);
            this.groupControl1.Controls.Add(this.CbeGioiTinh);
            this.groupControl1.Controls.Add(this.DeNgaySinh);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.TeTenKH);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Location = new System.Drawing.Point(57, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(602, 164);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông Tin Khách Hàng";
            // 
            // CbeSDT
            // 
            this.CbeSDT.Location = new System.Drawing.Point(425, 35);
            this.CbeSDT.Name = "CbeSDT";
            this.CbeSDT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbeSDT.Size = new System.Drawing.Size(100, 20);
            this.CbeSDT.TabIndex = 10;
            this.CbeSDT.EditValueChanged += new System.EventHandler(this.CbeSDT_EditValueChanged);
            // 
            // TeDiaChi
            // 
            this.TeDiaChi.Location = new System.Drawing.Point(425, 71);
            this.TeDiaChi.Name = "TeDiaChi";
            this.TeDiaChi.Size = new System.Drawing.Size(100, 20);
            this.TeDiaChi.TabIndex = 9;
            // 
            // CbeGioiTinh
            // 
            this.CbeGioiTinh.Location = new System.Drawing.Point(109, 122);
            this.CbeGioiTinh.Name = "CbeGioiTinh";
            this.CbeGioiTinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbeGioiTinh.Properties.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.CbeGioiTinh.Size = new System.Drawing.Size(100, 20);
            this.CbeGioiTinh.TabIndex = 8;
            // 
            // DeNgaySinh
            // 
            this.DeNgaySinh.EditValue = null;
            this.DeNgaySinh.Location = new System.Drawing.Point(109, 76);
            this.DeNgaySinh.Name = "DeNgaySinh";
            this.DeNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DeNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DeNgaySinh.Size = new System.Drawing.Size(100, 20);
            this.DeNgaySinh.TabIndex = 7;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(23, 122);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(40, 13);
            this.labelControl10.TabIndex = 6;
            this.labelControl10.Text = "Giới Tính";
            // 
            // TeTenKH
            // 
            this.TeTenKH.Location = new System.Drawing.Point(109, 27);
            this.TeTenKH.Name = "TeTenKH";
            this.TeTenKH.Size = new System.Drawing.Size(100, 20);
            this.TeTenKH.TabIndex = 4;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(23, 79);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 13);
            this.labelControl6.TabIndex = 3;
            this.labelControl6.Text = "Ngày Sinh";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(339, 79);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(34, 13);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Địa Chỉ";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(339, 35);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Số Điện Thoại";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(23, 27);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(78, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Tên Khách Hàng";
            // 
            // GcSP_HDB
            // 
            this.GcSP_HDB.Location = new System.Drawing.Point(3, 317);
            this.GcSP_HDB.MainView = this.gridView1;
            this.GcSP_HDB.Name = "GcSP_HDB";
            this.GcSP_HDB.Size = new System.Drawing.Size(759, 200);
            this.GcSP_HDB.TabIndex = 1;
            this.GcSP_HDB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnThemSP);
            this.groupControl2.Controls.Add(this.TeSoLuong);
            this.groupControl2.Controls.Add(this.CbeTenSP);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Location = new System.Drawing.Point(57, 195);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(602, 116);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Sản Phẩm";
            // 
            // btnThemSP
            // 
            this.btnThemSP.Location = new System.Drawing.Point(467, 88);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(108, 23);
            this.btnThemSP.TabIndex = 4;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // TeSoLuong
            // 
            this.TeSoLuong.Location = new System.Drawing.Point(109, 68);
            this.TeSoLuong.Name = "TeSoLuong";
            this.TeSoLuong.Size = new System.Drawing.Size(100, 20);
            this.TeSoLuong.TabIndex = 3;
            // 
            // CbeTenSP
            // 
            this.CbeTenSP.Location = new System.Drawing.Point(109, 34);
            this.CbeTenSP.Name = "CbeTenSP";
            this.CbeTenSP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbeTenSP.Size = new System.Drawing.Size(466, 20);
            this.CbeTenSP.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Số Lượng";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên Sản Phẩm";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(36, 540);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(69, 13);
            this.labelControl7.TabIndex = 3;
            this.labelControl7.Text = "Tên Nhân Viên";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(279, 540);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(44, 13);
            this.labelControl8.TabIndex = 4;
            this.labelControl8.Text = "Thời Gian";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(585, 538);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(47, 13);
            this.labelControl9.TabIndex = 5;
            this.labelControl9.Text = "Tổng Tiền";
            // 
            // LbTenNV
            // 
            this.LbTenNV.Location = new System.Drawing.Point(121, 538);
            this.LbTenNV.Name = "LbTenNV";
            this.LbTenNV.Size = new System.Drawing.Size(30, 13);
            this.LbTenNV.TabIndex = 7;
            this.LbTenNV.Text = "00000";
            // 
            // LbThoiGian
            // 
            this.LbThoiGian.Location = new System.Drawing.Point(344, 540);
            this.LbThoiGian.Name = "LbThoiGian";
            this.LbThoiGian.Size = new System.Drawing.Size(36, 13);
            this.LbThoiGian.TabIndex = 8;
            this.LbThoiGian.Text = "000000";
            // 
            // LbTongTien
            // 
            this.LbTongTien.Location = new System.Drawing.Point(638, 538);
            this.LbTongTien.Name = "LbTongTien";
            this.LbTongTien.Size = new System.Drawing.Size(30, 13);
            this.LbTongTien.TabIndex = 9;
            this.LbTongTien.Text = "00000";
            // 
            // BtnTaoHoaDon
            // 
            this.BtnTaoHoaDon.Location = new System.Drawing.Point(311, 589);
            this.BtnTaoHoaDon.Name = "BtnTaoHoaDon";
            this.BtnTaoHoaDon.Size = new System.Drawing.Size(133, 23);
            this.BtnTaoHoaDon.TabIndex = 10;
            this.BtnTaoHoaDon.Text = "Tạo Hóa Đơn";
            this.BtnTaoHoaDon.UseVisualStyleBackColor = true;
            this.BtnTaoHoaDon.Click += new System.EventHandler(this.BtnTaoHoaDon_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GcSP_HDB;
            this.gridView1.Name = "gridView1";
            // 
            // LbMaHDB
            // 
            this.LbMaHDB.Location = new System.Drawing.Point(128, 594);
            this.LbMaHDB.Name = "LbMaHDB";
            this.LbMaHDB.Size = new System.Drawing.Size(30, 13);
            this.LbMaHDB.TabIndex = 12;
            this.LbMaHDB.Text = "00000";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(36, 594);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(80, 13);
            this.labelControl12.TabIndex = 11;
            this.labelControl12.Text = "Mã Hóa Đơn Bán";
            // 
            // FormDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 643);
            this.Controls.Add(this.LbMaHDB);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.BtnTaoHoaDon);
            this.Controls.Add(this.LbTongTien);
            this.Controls.Add(this.LbThoiGian);
            this.Controls.Add(this.LbTenNV);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.GcSP_HDB);
            this.Controls.Add(this.groupControl1);
            this.Name = "FormDonBan";
            this.Text = "FormDonBan";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CbeSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbeGioiTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcSP_HDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbeTenSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl GcSP_HDB;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TeTenKH;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TeSoLuong;
        private DevExpress.XtraEditors.ComboBoxEdit CbeTenSP;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.ComboBoxEdit CbeGioiTinh;
        private DevExpress.XtraEditors.DateEdit DeNgaySinh;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit TeDiaChi;
        private DevExpress.XtraEditors.LabelControl LbTenNV;
        private DevExpress.XtraEditors.LabelControl LbThoiGian;
        private DevExpress.XtraEditors.LabelControl LbTongTien;
        private System.Windows.Forms.Button BtnTaoHoaDon;
        private System.Windows.Forms.Button btnThemSP;
        private DevExpress.XtraEditors.ComboBoxEdit CbeSDT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl LbMaHDB;
        private DevExpress.XtraEditors.LabelControl labelControl12;
    }
}