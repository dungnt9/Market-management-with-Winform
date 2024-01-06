namespace market_management
{
    partial class XemChiTietDonNhap
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
            this.DgvSP = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSP)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvSP
            // 
            this.DgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSP.Location = new System.Drawing.Point(67, 216);
            this.DgvSP.Name = "DgvSP";
            this.DgvSP.RowHeadersWidth = 51;
            this.DgvSP.RowTemplate.Height = 24;
            this.DgvSP.Size = new System.Drawing.Size(776, 344);
            this.DgvSP.TabIndex = 0;
            // 
            // XemChiTietDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 711);
            this.Controls.Add(this.DgvSP);
            this.Name = "XemChiTietDonNhap";
            this.Text = "Form Xem chi tiết đơn nhập";
            ((System.ComponentModel.ISupportInitialize)(this.DgvSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvSP;
    }
}