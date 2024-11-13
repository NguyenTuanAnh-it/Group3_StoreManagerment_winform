namespace BLT_Nhom3
{
    partial class FrmChiTietHDN
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lv_chitietHdn = new System.Windows.Forms.ListView();
            this.btn_export = new System.Windows.Forms.Button();
            this.lb_tongTien = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 32);
            this.label2.TabIndex = 29;
            this.label2.Text = "CHI TIẾT HÓA ĐƠN NHẬP HÀNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tổng tiền:";
            // 
            // lv_chitietHdn
            // 
            this.lv_chitietHdn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lv_chitietHdn.HideSelection = false;
            this.lv_chitietHdn.Location = new System.Drawing.Point(96, 94);
            this.lv_chitietHdn.Name = "lv_chitietHdn";
            this.lv_chitietHdn.Size = new System.Drawing.Size(730, 260);
            this.lv_chitietHdn.TabIndex = 31;
            this.lv_chitietHdn.UseCompatibleStateImageBehavior = false;
            this.lv_chitietHdn.View = System.Windows.Forms.View.Details;
            // 
            // btn_export
            // 
            this.btn_export.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.Location = new System.Drawing.Point(717, 373);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(109, 33);
            this.btn_export.TabIndex = 32;
            this.btn_export.Text = "In";
            this.btn_export.UseVisualStyleBackColor = true;
            // 
            // lb_tongTien
            // 
            this.lb_tongTien.AutoSize = true;
            this.lb_tongTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tongTien.Location = new System.Drawing.Point(194, 374);
            this.lb_tongTien.Name = "lb_tongTien";
            this.lb_tongTien.Size = new System.Drawing.Size(50, 22);
            this.lb_tongTien.TabIndex = 33;
            this.lb_tongTien.Text = "label";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Hóa Đơn";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Mặt Hàng";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày Bán";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số Lượng";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Đơn giá";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Thành Tiền";
            // 
            // FrmChiTietHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 450);
            this.Controls.Add(this.lb_tongTien);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.lv_chitietHdn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FrmChiTietHDN";
            this.Text = "FrmChiTietHDN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_chitietHdn;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Label lb_tongTien;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}