namespace market_management
{
    partial class FormNhaCungCap
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
            this.GrcThemNCC = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TeTenNCC = new DevExpress.XtraEditors.TextEdit();
            this.TeSDT_NCC = new DevExpress.XtraEditors.TextEdit();
            this.TeDiaChi_NCC = new DevExpress.XtraEditors.TextEdit();
            this.BtnThemNCC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrcThemNCC)).BeginInit();
            this.GrcThemNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeTenNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSDT_NCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeDiaChi_NCC.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GrcThemNCC
            // 
            this.GrcThemNCC.Controls.Add(this.TeDiaChi_NCC);
            this.GrcThemNCC.Controls.Add(this.TeSDT_NCC);
            this.GrcThemNCC.Controls.Add(this.TeTenNCC);
            this.GrcThemNCC.Controls.Add(this.labelControl3);
            this.GrcThemNCC.Controls.Add(this.labelControl2);
            this.GrcThemNCC.Controls.Add(this.labelControl1);
            this.GrcThemNCC.Location = new System.Drawing.Point(167, 45);
            this.GrcThemNCC.Name = "GrcThemNCC";
            this.GrcThemNCC.Size = new System.Drawing.Size(412, 257);
            this.GrcThemNCC.TabIndex = 0;
            this.GrcThemNCC.Text = "Thông Tin Nhà Cung Cấp";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên Nhà Cung Cấp";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 117);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Số Điện Thoại";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 194);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Địa Chỉ";
            // 
            // TeTenNCC
            // 
            this.TeTenNCC.Location = new System.Drawing.Point(163, 48);
            this.TeTenNCC.Name = "TeTenNCC";
            this.TeTenNCC.Size = new System.Drawing.Size(100, 20);
            this.TeTenNCC.TabIndex = 3;
            // 
            // TeSDT_NCC
            // 
            this.TeSDT_NCC.Location = new System.Drawing.Point(163, 109);
            this.TeSDT_NCC.Name = "TeSDT_NCC";
            this.TeSDT_NCC.Size = new System.Drawing.Size(100, 20);
            this.TeSDT_NCC.TabIndex = 4;
            // 
            // TeDiaChi_NCC
            // 
            this.TeDiaChi_NCC.Location = new System.Drawing.Point(163, 186);
            this.TeDiaChi_NCC.Name = "TeDiaChi_NCC";
            this.TeDiaChi_NCC.Size = new System.Drawing.Size(100, 20);
            this.TeDiaChi_NCC.TabIndex = 5;
            // 
            // BtnThemNCC
            // 
            this.BtnThemNCC.Location = new System.Drawing.Point(330, 336);
            this.BtnThemNCC.Name = "BtnThemNCC";
            this.BtnThemNCC.Size = new System.Drawing.Size(75, 23);
            this.BtnThemNCC.TabIndex = 1;
            this.BtnThemNCC.Text = "Thêm";
            this.BtnThemNCC.UseVisualStyleBackColor = true;
            this.BtnThemNCC.Click += new System.EventHandler(this.BtnThemNCC_Click);
            // 
            // FormNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 400);
            this.Controls.Add(this.BtnThemNCC);
            this.Controls.Add(this.GrcThemNCC);
            this.Name = "FormNhaCungCap";
            this.Text = "FormNhaCungCap";
            ((System.ComponentModel.ISupportInitialize)(this.GrcThemNCC)).EndInit();
            this.GrcThemNCC.ResumeLayout(false);
            this.GrcThemNCC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeTenNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSDT_NCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeDiaChi_NCC.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl GrcThemNCC;
        private DevExpress.XtraEditors.TextEdit TeDiaChi_NCC;
        private DevExpress.XtraEditors.TextEdit TeSDT_NCC;
        private DevExpress.XtraEditors.TextEdit TeTenNCC;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button BtnThemNCC;
    }
}