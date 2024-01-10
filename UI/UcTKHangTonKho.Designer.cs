namespace market_management.UI
{
    partial class UcTKHangTonKho
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.LbTongGiaTriKho = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.LbTongSoHang = new DevExpress.XtraEditors.LabelControl();
            this.GcHangTon = new DevExpress.XtraGrid.GridControl();
            this.GvHangTon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TeMucAnToan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.LbCapNhatGanNhat = new DevExpress.XtraEditors.LabelControl();
            this.BtnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GcHangTon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvHangTon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMucAnToan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(214, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(353, 37);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "THỐNG KÊ HÀNG TỒN KHO";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(48, 79);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(159, 30);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Tổng giá trị kho";
            // 
            // LbTongGiaTriKho
            // 
            this.LbTongGiaTriKho.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTongGiaTriKho.Appearance.Options.UseFont = true;
            this.LbTongGiaTriKho.Location = new System.Drawing.Point(80, 131);
            this.LbTongGiaTriKho.Name = "LbTongGiaTriKho";
            this.LbTongGiaTriKho.Size = new System.Drawing.Size(94, 20);
            this.LbTongGiaTriKho.TabIndex = 4;
            this.LbTongGiaTriKho.Text = "labelControl4";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(270, 79);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(240, 30);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Tổng số hàng trong kho";
            // 
            // LbTongSoHang
            // 
            this.LbTongSoHang.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTongSoHang.Appearance.Options.UseFont = true;
            this.LbTongSoHang.Location = new System.Drawing.Point(342, 131);
            this.LbTongSoHang.Name = "LbTongSoHang";
            this.LbTongSoHang.Size = new System.Drawing.Size(94, 20);
            this.LbTongSoHang.TabIndex = 6;
            this.LbTongSoHang.Text = "labelControl6";
            // 
            // GcHangTon
            // 
            this.GcHangTon.Location = new System.Drawing.Point(0, 217);
            this.GcHangTon.MainView = this.GvHangTon;
            this.GcHangTon.Name = "GcHangTon";
            this.GcHangTon.Size = new System.Drawing.Size(763, 256);
            this.GcHangTon.TabIndex = 10;
            this.GcHangTon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvHangTon});
            // 
            // GvHangTon
            // 
            this.GvHangTon.GridControl = this.GcHangTon;
            this.GvHangTon.Name = "GvHangTon";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(48, 176);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Mức Kho An Toàn";
            // 
            // TeMucAnToan
            // 
            this.TeMucAnToan.Location = new System.Drawing.Point(143, 176);
            this.TeMucAnToan.Name = "TeMucAnToan";
            this.TeMucAnToan.Size = new System.Drawing.Size(100, 20);
            this.TeMucAnToan.TabIndex = 12;
            this.TeMucAnToan.TextChanged += new System.EventHandler(this.TeMucAnToan_TextChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(618, 92);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(93, 13);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Cập Nhật Gần Nhất";
            // 
            // LbCapNhatGanNhat
            // 
            this.LbCapNhatGanNhat.Location = new System.Drawing.Point(618, 131);
            this.LbCapNhatGanNhat.Name = "LbCapNhatGanNhat";
            this.LbCapNhatGanNhat.Size = new System.Drawing.Size(63, 13);
            this.LbCapNhatGanNhat.TabIndex = 14;
            this.LbCapNhatGanNhat.Text = "labelControl6";
            // 
            // BtnLamMoi
            // 
            this.BtnLamMoi.Location = new System.Drawing.Point(654, 188);
            this.BtnLamMoi.Name = "BtnLamMoi";
            this.BtnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.BtnLamMoi.TabIndex = 15;
            this.BtnLamMoi.Text = "Cập Nhật";
            this.BtnLamMoi.Click += new System.EventHandler(this.BtnLamMoi_Click);
            // 
            // UcTKHangTonKho
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnLamMoi);
            this.Controls.Add(this.LbCapNhatGanNhat);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.TeMucAnToan);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.GcHangTon);
            this.Controls.Add(this.LbTongSoHang);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.LbTongGiaTriKho);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Name = "UcTKHangTonKho";
            this.Size = new System.Drawing.Size(763, 498);
            ((System.ComponentModel.ISupportInitialize)(this.GcHangTon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvHangTon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMucAnToan.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl LbTongGiaTriKho;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl LbTongSoHang;
        private DevExpress.XtraGrid.GridControl GcHangTon;
        private DevExpress.XtraGrid.Views.Grid.GridView GvHangTon;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TeMucAnToan;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl LbCapNhatGanNhat;
        private DevExpress.XtraEditors.SimpleButton BtnLamMoi;
    }
}
