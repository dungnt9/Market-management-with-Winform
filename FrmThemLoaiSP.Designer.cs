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
            ((System.ComponentModel.ISupportInitialize)(this.TeTenLoaiSP.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbTrangThai
            // 
            this.CmbTrangThai.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTrangThai.FormattingEnabled = true;
            this.CmbTrangThai.Items.AddRange(new object[] {
            "Đang kinh doanh",
            "Không còn kinh doanh"});
            this.CmbTrangThai.Location = new System.Drawing.Point(206, 105);
            this.CmbTrangThai.Name = "CmbTrangThai";
            this.CmbTrangThai.Size = new System.Drawing.Size(199, 26);
            this.CmbTrangThai.TabIndex = 50;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(72, 113);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 18);
            this.labelControl2.TabIndex = 49;
            this.labelControl2.Text = "Trạng thái";
            // 
            // LbTenLSP
            // 
            this.LbTenLSP.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTenLSP.Appearance.Options.UseFont = true;
            this.LbTenLSP.Location = new System.Drawing.Point(71, 58);
            this.LbTenLSP.Name = "LbTenLSP";
            this.LbTenLSP.Size = new System.Drawing.Size(120, 20);
            this.LbTenLSP.TabIndex = 47;
            this.LbTenLSP.Text = "Tên loại sản phẩm";
            // 
            // BtnThemLoaiSP
            // 
            this.BtnThemLoaiSP.Location = new System.Drawing.Point(167, 172);
            this.BtnThemLoaiSP.Name = "BtnThemLoaiSP";
            this.BtnThemLoaiSP.Size = new System.Drawing.Size(138, 31);
            this.BtnThemLoaiSP.TabIndex = 51;
            this.BtnThemLoaiSP.Text = "Thêm loại sản phẩm";
            this.BtnThemLoaiSP.UseVisualStyleBackColor = true;
            this.BtnThemLoaiSP.Click += new System.EventHandler(this.BtnThemLoaiSP_Click);
            // 
            // TeTenLoaiSP
            // 
            this.TeTenLoaiSP.Location = new System.Drawing.Point(206, 58);
            this.TeTenLoaiSP.Name = "TeTenLoaiSP";
            this.TeTenLoaiSP.Size = new System.Drawing.Size(199, 22);
            this.TeTenLoaiSP.TabIndex = 52;
            // 
            // FrmThemLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 259);
            this.Controls.Add(this.TeTenLoaiSP);
            this.Controls.Add(this.BtnThemLoaiSP);
            this.Controls.Add(this.CmbTrangThai);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.LbTenLSP);
            this.MaximizeBox = false;
            this.Name = "FrmThemLoaiSP";
            this.Text = "Form Thêm loại sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.TeTenLoaiSP.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbTrangThai;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl LbTenLSP;
        private System.Windows.Forms.Button BtnThemLoaiSP;
        private DevExpress.XtraEditors.TextEdit TeTenLoaiSP;
    }
}