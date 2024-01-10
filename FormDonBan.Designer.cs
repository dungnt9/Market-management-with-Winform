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
            this.TeTenKH = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.GcSP_HDB = new DevExpress.XtraGrid.GridControl();
            this.GvSP_HDB = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.LbMaHDB = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.LbDuocGiam = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.LbThanhTien = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CbeSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcSP_HDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvSP_HDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbeTenSP.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.CbeSDT);
            this.groupControl1.Controls.Add(this.TeTenKH);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Location = new System.Drawing.Point(98, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(602, 111);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông Tin Khách Hàng";
            // 
            // CbeSDT
            // 
            this.CbeSDT.Location = new System.Drawing.Point(444, 49);
            this.CbeSDT.Name = "CbeSDT";
            this.CbeSDT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbeSDT.Size = new System.Drawing.Size(100, 20);
            this.CbeSDT.TabIndex = 10;
            this.CbeSDT.Leave += new System.EventHandler(this.CbeSDT_Leave);
            // 
            // TeTenKH
            // 
            this.TeTenKH.Location = new System.Drawing.Point(145, 49);
            this.TeTenKH.Name = "TeTenKH";
            this.TeTenKH.Size = new System.Drawing.Size(121, 20);
            this.TeTenKH.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(325, 49);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(87, 17);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Số Điện Thoại";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(23, 49);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(101, 17);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Tên Khách Hàng";
            // 
            // GcSP_HDB
            // 
            this.GcSP_HDB.Location = new System.Drawing.Point(-7, 305);
            this.GcSP_HDB.MainView = this.GvSP_HDB;
            this.GcSP_HDB.Name = "GcSP_HDB";
            this.GcSP_HDB.Size = new System.Drawing.Size(813, 200);
            this.GcSP_HDB.TabIndex = 1;
            this.GcSP_HDB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvSP_HDB});
            // 
            // GvSP_HDB
            // 
            this.GvSP_HDB.GridControl = this.GcSP_HDB;
            this.GvSP_HDB.Name = "GvSP_HDB";
            this.GvSP_HDB.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.GvSP_HDB_RowUpdated);
            this.GvSP_HDB.RowCountChanged += new System.EventHandler(this.GvSP_HDB_RowCountChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnThemSP);
            this.groupControl2.Controls.Add(this.TeSoLuong);
            this.groupControl2.Controls.Add(this.CbeTenSP);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Location = new System.Drawing.Point(98, 150);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(602, 136);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Chọn Sản Phẩm";
            // 
            // btnThemSP
            // 
            this.btnThemSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSP.Location = new System.Drawing.Point(444, 94);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(109, 23);
            this.btnThemSP.TabIndex = 4;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // TeSoLuong
            // 
            this.TeSoLuong.Location = new System.Drawing.Point(132, 68);
            this.TeSoLuong.Name = "TeSoLuong";
            this.TeSoLuong.Size = new System.Drawing.Size(100, 20);
            this.TeSoLuong.TabIndex = 3;
            this.TeSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeSoLuong_KeyPress);
            // 
            // CbeTenSP
            // 
            this.CbeTenSP.Location = new System.Drawing.Point(132, 37);
            this.CbeTenSP.Name = "CbeTenSP";
            this.CbeTenSP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbeTenSP.Size = new System.Drawing.Size(450, 20);
            this.CbeTenSP.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(23, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Số Lượng";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(23, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên Sản Phẩm";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(24, 585);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(92, 17);
            this.labelControl7.TabIndex = 3;
            this.labelControl7.Text = "Tên Nhân Viên";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(24, 639);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(60, 17);
            this.labelControl8.TabIndex = 4;
            this.labelControl8.Text = "Thời Gian";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(588, 533);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(63, 17);
            this.labelControl9.TabIndex = 5;
            this.labelControl9.Text = "Tổng Tiền";
            // 
            // LbTenNV
            // 
            this.LbTenNV.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTenNV.Appearance.Options.UseFont = true;
            this.LbTenNV.Location = new System.Drawing.Point(145, 585);
            this.LbTenNV.Name = "LbTenNV";
            this.LbTenNV.Size = new System.Drawing.Size(35, 17);
            this.LbTenNV.TabIndex = 7;
            this.LbTenNV.Text = "00000";
            // 
            // LbThoiGian
            // 
            this.LbThoiGian.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbThoiGian.Appearance.Options.UseFont = true;
            this.LbThoiGian.Location = new System.Drawing.Point(145, 639);
            this.LbThoiGian.Name = "LbThoiGian";
            this.LbThoiGian.Size = new System.Drawing.Size(35, 17);
            this.LbThoiGian.TabIndex = 8;
            this.LbThoiGian.Text = "00000";
            // 
            // LbTongTien
            // 
            this.LbTongTien.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTongTien.Appearance.Options.UseFont = true;
            this.LbTongTien.Location = new System.Drawing.Point(684, 533);
            this.LbTongTien.Name = "LbTongTien";
            this.LbTongTien.Size = new System.Drawing.Size(35, 17);
            this.LbTongTien.TabIndex = 9;
            this.LbTongTien.Text = "00000";
            // 
            // BtnTaoHoaDon
            // 
            this.BtnTaoHoaDon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTaoHoaDon.Location = new System.Drawing.Point(340, 682);
            this.BtnTaoHoaDon.Name = "BtnTaoHoaDon";
            this.BtnTaoHoaDon.Size = new System.Drawing.Size(133, 44);
            this.BtnTaoHoaDon.TabIndex = 10;
            this.BtnTaoHoaDon.Text = "Tạo Hóa Đơn";
            this.BtnTaoHoaDon.UseVisualStyleBackColor = true;
            this.BtnTaoHoaDon.Click += new System.EventHandler(this.BtnTaoHoaDon_Click);
            // 
            // LbMaHDB
            // 
            this.LbMaHDB.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMaHDB.Appearance.Options.UseFont = true;
            this.LbMaHDB.Location = new System.Drawing.Point(145, 533);
            this.LbMaHDB.Name = "LbMaHDB";
            this.LbMaHDB.Size = new System.Drawing.Size(35, 17);
            this.LbMaHDB.TabIndex = 12;
            this.LbMaHDB.Text = "00000";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(24, 533);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(105, 17);
            this.labelControl12.TabIndex = 11;
            this.labelControl12.Text = "Mã Hóa Đơn Bán";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(588, 572);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(69, 17);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Được Giảm";
            // 
            // LbDuocGiam
            // 
            this.LbDuocGiam.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDuocGiam.Appearance.Options.UseFont = true;
            this.LbDuocGiam.Location = new System.Drawing.Point(684, 572);
            this.LbDuocGiam.Name = "LbDuocGiam";
            this.LbDuocGiam.Size = new System.Drawing.Size(35, 17);
            this.LbDuocGiam.TabIndex = 14;
            this.LbDuocGiam.Text = "00000";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(588, 609);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(70, 17);
            this.labelControl10.TabIndex = 15;
            this.labelControl10.Text = "Thành Tiền";
            // 
            // LbThanhTien
            // 
            this.LbThanhTien.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbThanhTien.Appearance.Options.UseFont = true;
            this.LbThanhTien.Location = new System.Drawing.Point(684, 609);
            this.LbThanhTien.Name = "LbThanhTien";
            this.LbThanhTien.Size = new System.Drawing.Size(35, 17);
            this.LbThanhTien.TabIndex = 16;
            this.LbThanhTien.Text = "00000";
            // 
            // FormDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 738);
            this.Controls.Add(this.LbThanhTien);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.LbDuocGiam);
            this.Controls.Add(this.labelControl5);
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
            ((System.ComponentModel.ISupportInitialize)(this.TeTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcSP_HDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvSP_HDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbeTenSP.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TeSoLuong;
        private DevExpress.XtraEditors.ComboBoxEdit CbeTenSP;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl LbTenNV;
        private DevExpress.XtraEditors.LabelControl LbThoiGian;
        private DevExpress.XtraEditors.LabelControl LbTongTien;
        private System.Windows.Forms.Button BtnTaoHoaDon;
        private System.Windows.Forms.Button btnThemSP;
        private DevExpress.XtraEditors.ComboBoxEdit CbeSDT;
        private DevExpress.XtraGrid.Views.Grid.GridView GvSP_HDB;
        private DevExpress.XtraEditors.LabelControl LbMaHDB;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl LbDuocGiam;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl LbThanhTien;
    }
}