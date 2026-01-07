namespace QuanLyHocSinh.Forms
{
    partial class FrmLichThi
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.btnXemTatCa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLichThi = new System.Windows.Forms.DataGridView();
            this.grpChiTiet = new System.Windows.Forms.GroupBox();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtGioKetThuc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpNgayThi = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cboKyThi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGioBatDau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaLT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichThi)).BeginInit();
            this.grpChiTiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(280, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ LỊCH THI";
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTimKiem.Controls.Add(this.btnXemTatCa);
            this.grpTimKiem.Controls.Add(this.btnTimKiem);
            this.grpTimKiem.Controls.Add(this.txtTimKiem);
            this.grpTimKiem.Controls.Add(this.label2);
            this.grpTimKiem.Location = new System.Drawing.Point(12, 70);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(860, 60);
            this.grpTimKiem.TabIndex = 1;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm kiếm";
            // 
            // btnXemTatCa
            // 
            this.btnXemTatCa.Location = new System.Drawing.Point(620, 23);
            this.btnXemTatCa.Name = "btnXemTatCa";
            this.btnXemTatCa.Size = new System.Drawing.Size(100, 23);
            this.btnXemTatCa.TabIndex = 3;
            this.btnXemTatCa.Text = "Xem Tất Cả";
            this.btnXemTatCa.UseVisualStyleBackColor = true;
            this.btnXemTatCa.Click += new System.EventHandler(this.btnXemTatCa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(510, 23);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 23);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(200, 25);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(300, 20);
            this.txtTimKiem.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập Môn hoặc Kỳ thi:";
            // 
            // dgvLichThi
            // 
            this.dgvLichThi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLichThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichThi.Location = new System.Drawing.Point(12, 140);
            this.dgvLichThi.Name = "dgvLichThi";
            this.dgvLichThi.Size = new System.Drawing.Size(860, 250);
            this.dgvLichThi.TabIndex = 2;
            this.dgvLichThi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichThi_CellClick);
            // 
            // grpChiTiet
            // 
            this.grpChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpChiTiet.Controls.Add(this.btnXuatExcel);
            this.grpChiTiet.Controls.Add(this.btnLamMoi);
            this.grpChiTiet.Controls.Add(this.btnXoa);
            this.grpChiTiet.Controls.Add(this.btnCapNhat);
            this.grpChiTiet.Controls.Add(this.btnThem);
            this.grpChiTiet.Controls.Add(this.txtGioKetThuc);
            this.grpChiTiet.Controls.Add(this.label9);
            this.grpChiTiet.Controls.Add(this.dtpNgayThi);
            this.grpChiTiet.Controls.Add(this.label8);
            this.grpChiTiet.Controls.Add(this.cboKyThi);
            this.grpChiTiet.Controls.Add(this.label7);
            this.grpChiTiet.Controls.Add(this.txtMaPhong);
            this.grpChiTiet.Controls.Add(this.label6);
            this.grpChiTiet.Controls.Add(this.txtGioBatDau);
            this.grpChiTiet.Controls.Add(this.label5);
            this.grpChiTiet.Controls.Add(this.txtMaMon);
            this.grpChiTiet.Controls.Add(this.label4);
            this.grpChiTiet.Controls.Add(this.txtMaLT);
            this.grpChiTiet.Controls.Add(this.label3);
            this.grpChiTiet.Location = new System.Drawing.Point(12, 400);
            this.grpChiTiet.Name = "grpChiTiet";
            this.grpChiTiet.Size = new System.Drawing.Size(860, 150);
            this.grpChiTiet.TabIndex = 3;
            this.grpChiTiet.TabStop = false;
            this.grpChiTiet.Text = "Thông tin chi tiết";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuatExcel.ForeColor = System.Drawing.Color.Red;
            this.btnXuatExcel.Location = new System.Drawing.Point(740, 110);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(100, 23);
            this.btnXuatExcel.TabIndex = 18;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.Location = new System.Drawing.Point(630, 110);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 23);
            this.btnLamMoi.TabIndex = 17;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Location = new System.Drawing.Point(520, 110);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 23);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhat.Location = new System.Drawing.Point(410, 110);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 23);
            this.btnCapNhat.TabIndex = 15;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Location = new System.Drawing.Point(300, 110);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 23);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtGioKetThuc
            // 
            this.txtGioKetThuc.Location = new System.Drawing.Point(580, 80);
            this.txtGioKetThuc.Name = "txtGioKetThuc";
            this.txtGioKetThuc.Size = new System.Drawing.Size(200, 20);
            this.txtGioKetThuc.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(470, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Giờ Kết Thúc (HH:mm):";
            // 
            // dtpNgayThi
            // 
            this.dtpNgayThi.CustomFormat = "dd-MM-yyyy";
            this.dtpNgayThi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayThi.Location = new System.Drawing.Point(580, 50);
            this.dtpNgayThi.Name = "dtpNgayThi";
            this.dtpNgayThi.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayThi.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(470, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ngày Thi:";
            // 
            // cboKyThi
            // 
            this.cboKyThi.FormattingEnabled = true;
            this.cboKyThi.Location = new System.Drawing.Point(580, 20);
            this.cboKyThi.Name = "cboKyThi";
            this.cboKyThi.Size = new System.Drawing.Size(200, 21);
            this.cboKyThi.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(470, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Kỳ Thi:";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(130, 110);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(150, 20);
            this.txtMaPhong.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã Phòng (FK):";
            // 
            // txtGioBatDau
            // 
            this.txtGioBatDau.Location = new System.Drawing.Point(130, 80);
            this.txtGioBatDau.Name = "txtGioBatDau";
            this.txtGioBatDau.Size = new System.Drawing.Size(150, 20);
            this.txtGioBatDau.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giờ Bắt Đầu (HH:mm):";
            // 
            // txtMaMon
            // 
            this.txtMaMon.Location = new System.Drawing.Point(130, 50);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(150, 20);
            this.txtMaMon.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã Môn (FK):";
            // 
            // txtMaLT
            // 
            this.txtMaLT.Location = new System.Drawing.Point(130, 20);
            this.txtMaLT.Name = "txtMaLT";
            this.txtMaLT.Size = new System.Drawing.Size(150, 20);
            this.txtMaLT.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã LT:";
            // 
            // FrmLichThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.grpChiTiet);
            this.Controls.Add(this.dgvLichThi);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.label1);
            this.Name = "FrmLichThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Lịch Thi";
            this.Load += new System.EventHandler(this.FrmLichThi_Load);
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichThi)).EndInit();
            this.grpChiTiet.ResumeLayout(false);
            this.grpChiTiet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.Button btnXemTatCa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLichThi;
        private System.Windows.Forms.GroupBox grpChiTiet;
        private System.Windows.Forms.TextBox txtGioKetThuc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpNgayThi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboKyThi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGioBatDau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaLT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
    }
}