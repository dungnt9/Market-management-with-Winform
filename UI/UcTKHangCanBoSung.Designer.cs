namespace market_management.UI
{
    partial class UcTKHangCanBoSung
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
            this.GcHangBoSung = new DevExpress.XtraGrid.GridControl();
            this.GvHangBoSung = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TeMucKhoToiThieu = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.GcHangBoSung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvHangBoSung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMucKhoToiThieu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(223, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(413, 37);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "THỐNG KÊ HÀNG CẦN BỔ SUNG";
            // 
            // GcHangBoSung
            // 
            this.GcHangBoSung.Location = new System.Drawing.Point(0, 165);
            this.GcHangBoSung.MainView = this.GvHangBoSung;
            this.GcHangBoSung.Name = "GcHangBoSung";
            this.GcHangBoSung.Size = new System.Drawing.Size(816, 286);
            this.GcHangBoSung.TabIndex = 1;
            this.GcHangBoSung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvHangBoSung});
            // 
            // GvHangBoSung
            // 
            this.GvHangBoSung.GridControl = this.GcHangBoSung;
            this.GvHangBoSung.Name = "GvHangBoSung";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(40, 114);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(118, 17);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mức Kho Tối Thiểu";
            // 
            // TeMucKhoToiThieu
            // 
            this.TeMucKhoToiThieu.Location = new System.Drawing.Point(185, 114);
            this.TeMucKhoToiThieu.Name = "TeMucKhoToiThieu";
            this.TeMucKhoToiThieu.Size = new System.Drawing.Size(100, 20);
            this.TeMucKhoToiThieu.TabIndex = 4;
            this.TeMucKhoToiThieu.TextChanged += new System.EventHandler(this.TeMucKhoToiThieu_TextChanged);
            this.TeMucKhoToiThieu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeMucKhoToiThieu_KeyPress);
            // 
            // UcTKHangCanBoSung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TeMucKhoToiThieu);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.GcHangBoSung);
            this.Controls.Add(this.labelControl1);
            this.Name = "UcTKHangCanBoSung";
            this.Size = new System.Drawing.Size(816, 454);
            ((System.ComponentModel.ISupportInitialize)(this.GcHangBoSung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvHangBoSung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeMucKhoToiThieu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl GcHangBoSung;
        private DevExpress.XtraGrid.Views.Grid.GridView GvHangBoSung;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TeMucKhoToiThieu;
    }
}
