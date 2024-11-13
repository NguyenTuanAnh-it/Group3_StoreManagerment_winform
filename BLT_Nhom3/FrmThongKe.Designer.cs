namespace BLT_Nhom3
{
    partial class FrmThongKe
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_lc = new System.Windows.Forms.ComboBox();
            this.dtp_truoc = new System.Windows.Forms.DateTimePicker();
            this.dtp_sau = new System.Windows.Forms.DateTimePicker();
            this.lv_tkeHdb = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.txt_timKiem = new System.Windows.Forms.TextBox();
            this.btn_timKiem = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_tongTien = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(751, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lựa chọn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(384, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Từ ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "THỐNG KÊ";
            // 
            // cbb_lc
            // 
            this.cbb_lc.FormattingEnabled = true;
            this.cbb_lc.Items.AddRange(new object[] {
            "Hóa Đơn Bán",
            "Hóa Đơn Nhập",
            "Hàng Hóa"});
            this.cbb_lc.Location = new System.Drawing.Point(125, 131);
            this.cbb_lc.Name = "cbb_lc";
            this.cbb_lc.Size = new System.Drawing.Size(160, 24);
            this.cbb_lc.TabIndex = 4;
            // 
            // dtp_truoc
            // 
            this.dtp_truoc.Location = new System.Drawing.Point(465, 131);
            this.dtp_truoc.Name = "dtp_truoc";
            this.dtp_truoc.Size = new System.Drawing.Size(200, 22);
            this.dtp_truoc.TabIndex = 5;
            // 
            // dtp_sau
            // 
            this.dtp_sau.Location = new System.Drawing.Point(840, 133);
            this.dtp_sau.Name = "dtp_sau";
            this.dtp_sau.Size = new System.Drawing.Size(200, 22);
            this.dtp_sau.TabIndex = 6;
            // 
            // lv_tkeHdb
            // 
            this.lv_tkeHdb.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lv_tkeHdb.HideSelection = false;
            this.lv_tkeHdb.Location = new System.Drawing.Point(40, 177);
            this.lv_tkeHdb.Name = "lv_tkeHdb";
            this.lv_tkeHdb.Size = new System.Drawing.Size(1000, 268);
            this.lv_tkeHdb.TabIndex = 7;
            this.lv_tkeHdb.UseCompatibleStateImageBehavior = false;
            this.lv_tkeHdb.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã hóa đơn";
            this.columnHeader1.Width = 113;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên nhân viên";
            this.columnHeader2.Width = 106;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên khách";
            this.columnHeader3.Width = 115;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Địa chỉ";
            this.columnHeader4.Width = 116;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày bán";
            this.columnHeader5.Width = 109;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên mặt hàng";
            this.columnHeader6.Width = 110;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Số lượng";
            this.columnHeader7.Width = 72;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Đơn giá";
            this.columnHeader8.Width = 107;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Thành tiền";
            this.columnHeader9.Width = 117;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nhập thông tin hóa đơn:";
            // 
            // txt_timKiem
            // 
            this.txt_timKiem.Location = new System.Drawing.Point(328, 455);
            this.txt_timKiem.Multiline = true;
            this.txt_timKiem.Name = "txt_timKiem";
            this.txt_timKiem.Size = new System.Drawing.Size(373, 31);
            this.txt_timKiem.TabIndex = 9;
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timKiem.Location = new System.Drawing.Point(745, 455);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.Size = new System.Drawing.Size(109, 31);
            this.btn_timKiem.TabIndex = 10;
            this.btn_timKiem.Text = "Tìm kiếm";
            this.btn_timKiem.UseVisualStyleBackColor = true;
            // 
            // btn_export
            // 
            this.btn_export.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.Location = new System.Drawing.Point(40, 495);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(106, 31);
            this.btn_export.TabIndex = 11;
            this.btn_export.Text = "In";
            this.btn_export.UseVisualStyleBackColor = true;
            // 
            // btn_load
            // 
            this.btn_load.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(167, 495);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(106, 31);
            this.btn_load.TabIndex = 12;
            this.btn_load.Text = "Làm mới";
            this.btn_load.UseVisualStyleBackColor = true;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(295, 495);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(106, 31);
            this.btn_thoat.TabIndex = 13;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(764, 504);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tổng tiền:";
            // 
            // lb_tongTien
            // 
            this.lb_tongTien.AutoSize = true;
            this.lb_tongTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tongTien.Location = new System.Drawing.Point(860, 504);
            this.lb_tongTien.Name = "lb_tongTien";
            this.lb_tongTien.Size = new System.Drawing.Size(50, 22);
            this.lb_tongTien.TabIndex = 15;
            this.lb_tongTien.Text = "label";
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 538);
            this.Controls.Add(this.lb_tongTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_timKiem);
            this.Controls.Add(this.txt_timKiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lv_tkeHdb);
            this.Controls.Add(this.dtp_sau);
            this.Controls.Add(this.dtp_truoc);
            this.Controls.Add(this.cbb_lc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmThongKe";
            this.Text = "FrmThongKe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_lc;
        private System.Windows.Forms.DateTimePicker dtp_truoc;
        private System.Windows.Forms.DateTimePicker dtp_sau;
        private System.Windows.Forms.ListView lv_tkeHdb;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_timKiem;
        private System.Windows.Forms.Button btn_timKiem;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_tongTien;
    }
}