namespace market_management
{
    partial class FrmThemLoaiSP
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
            this.CmbTrangThai = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LbTenLSP = new DevExpress.XtraEditors.LabelControl();
            this.BtnThemLoaiSP = new System.Windows.Forms.Button();
            this.TeTenLoaiSP = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.TeTenLoaiSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmbTrangThai
            // 
            this.CmbTrangThai.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTrangThai.FormattingEnabled = true;
            this.CmbTrangThai.Items.AddRange(new object[] {
            "Đang kinh doanh",
            "Không còn kinh doanh"});
            this.CmbTrangThai.Location = new System.Drawing.Point(176, 86);
            this.CmbTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbTrangThai.Name = "CmbTrangThai";
            this.CmbTrangThai.Size = new System.Drawing.Size(194, 28);
            this.CmbTrangThai.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(36, 94);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 20);
            this.labelControl2.TabIndex = 49;
            this.labelControl2.Text = "Trạng thái";
            // 
            // LbTenLSP
            // 
            this.LbTenLSP.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTenLSP.Appearance.Options.UseFont = true;
            this.LbTenLSP.Location = new System.Drawing.Point(35, 49);
            this.LbTenLSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LbTenLSP.Name = "LbTenLSP";
            this.LbTenLSP.Size = new System.Drawing.Size(120, 20);
            this.LbTenLSP.TabIndex = 47;
            this.LbTenLSP.Text = "Tên loại sản phẩm";
            // 
            // BtnThemLoaiSP
            // 
            this.BtnThemLoaiSP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThemLoaiSP.Location = new System.Drawing.Point(108, 139);
            this.BtnThemLoaiSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnThemLoaiSP.Name = "BtnThemLoaiSP";
            this.BtnThemLoaiSP.Size = new System.Drawing.Size(170, 28);
            this.BtnThemLoaiSP.TabIndex = 3;
            this.BtnThemLoaiSP.Text = "Thêm loại sản phẩm";
            this.BtnThemLoaiSP.UseVisualStyleBackColor = true;
            this.BtnThemLoaiSP.Click += new System.EventHandler(this.BtnThemLoaiSP_Click);
            // 
            // TeTenLoaiSP
            // 
            this.TeTenLoaiSP.Location = new System.Drawing.Point(176, 46);
            this.TeTenLoaiSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TeTenLoaiSP.Name = "TeTenLoaiSP";
            this.TeTenLoaiSP.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeTenLoaiSP.Properties.Appearance.Options.UseFont = true;
            this.TeTenLoaiSP.Size = new System.Drawing.Size(194, 26);
            this.TeTenLoaiSP.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TeTenLoaiSP);
            this.groupControl1.Controls.Add(this.LbTenLSP);
            this.groupControl1.Controls.Add(this.BtnThemLoaiSP);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.CmbTrangThai);
            this.groupControl1.Location = new System.Drawing.Point(23, 23);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(390, 183);
            this.groupControl1.TabIndex = 53;
            this.groupControl1.Text = "Thêm loại sản phẩm";
            // 
            // FrmThemLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 233);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = global::market_management.Properties.Resources.bieuTuong;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmThemLoaiSP";
            this.Text = "Form Thêm loại sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.TeTenLoaiSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbTrangThai;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl LbTenLSP;
        private System.Windows.Forms.Button BtnThemLoaiSP;
        private DevExpress.XtraEditors.TextEdit TeTenLoaiSP;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}