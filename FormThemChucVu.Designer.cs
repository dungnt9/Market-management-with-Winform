namespace market_management
{
    partial class FormThemChucVu
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
            this.CbeCapQuanLy = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TeMoTaCV = new DevExpress.XtraEditors.TextEdit();
            this.TeTenCV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BtnThemCV = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CbeCapQuanLy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMoTaCV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeTenCV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.CbeCapQuanLy);
            this.groupControl1.Controls.Add(this.TeMoTaCV);
            this.groupControl1.Controls.Add(this.TeTenCV);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(109, 34);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(589, 237);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Chức Vụ Mới";
            // 
            // CbeCapQuanLy
            // 
            this.CbeCapQuanLy.Location = new System.Drawing.Point(180, 107);
            this.CbeCapQuanLy.Name = "CbeCapQuanLy";
            this.CbeCapQuanLy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbeCapQuanLy.Properties.Items.AddRange(new object[] {
            "Có",
            "Không"});
            this.CbeCapQuanLy.Size = new System.Drawing.Size(100, 20);
            this.CbeCapQuanLy.TabIndex = 5;
            // 
            // TeMoTaCV
            // 
            this.TeMoTaCV.Location = new System.Drawing.Point(180, 162);
            this.TeMoTaCV.Name = "TeMoTaCV";
            this.TeMoTaCV.Size = new System.Drawing.Size(377, 20);
            this.TeMoTaCV.TabIndex = 4;
            // 
            // TeTenCV
            // 
            this.TeTenCV.Location = new System.Drawing.Point(180, 51);
            this.TeTenCV.Name = "TeTenCV";
            this.TeTenCV.Size = new System.Drawing.Size(210, 20);
            this.TeTenCV.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(36, 170);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(91, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Mô Tả Chức Vụ Mới";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(36, 115);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Cấp Quản Lý";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(36, 59);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên Chức Vụ Mới";
            // 
            // BtnThemCV
            // 
            this.BtnThemCV.Location = new System.Drawing.Point(350, 307);
            this.BtnThemCV.Name = "BtnThemCV";
            this.BtnThemCV.Size = new System.Drawing.Size(120, 57);
            this.BtnThemCV.TabIndex = 1;
            this.BtnThemCV.Text = "Thêm";
            this.BtnThemCV.Click += new System.EventHandler(this.BtnThemCV_Click);
            // 
            // FormThemChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 419);
            this.Controls.Add(this.BtnThemCV);
            this.Controls.Add(this.groupControl1);
            this.Name = "FormThemChucVu";
            this.Text = "FormThemChucVu";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CbeCapQuanLy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMoTaCV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeTenCV.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ComboBoxEdit CbeCapQuanLy;
        private DevExpress.XtraEditors.TextEdit TeMoTaCV;
        private DevExpress.XtraEditors.TextEdit TeTenCV;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton BtnThemCV;
    }
}