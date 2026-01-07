namespace QuanLyHocSinh.Forms
{
    partial class FrmQuanLyHanhKiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpLoc = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLocHocKy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocMaLop = new System.Windows.Forms.TextBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvHanhKiem = new System.Windows.Forms.DataGridView();
            this.grpCapNhat = new System.Windows.Forms.GroupBox();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtNhanXet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboXepLoai = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenHS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpLoc.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanhKiem)).BeginInit();
            this.grpCapNhat.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(300, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ HẠNH KIỂM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpLoc
            // 
            this.grpLoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLoc.Controls.Add(this.label4);
            this.grpLoc.Controls.Add(this.cboLocHocKy);
            this.grpLoc.Controls.Add(this.label3);
            this.grpLoc.Controls.Add(this.txtNamHoc);
            this.grpLoc.Controls.Add(this.label2);
            this.grpLoc.Controls.Add(this.txtLocMaLop);
            this.grpLoc.Controls.Add(this.btnLoc);
            this.grpLoc.Location = new System.Drawing.Point(12, 60);
            this.grpLoc.Name = "grpLoc";
            this.grpLoc.Size = new System.Drawing.Size(860, 65);
            this.grpLoc.TabIndex = 1;
            this.grpLoc.TabStop = false;
            this.grpLoc.Text = "Lọc theo lớp (Mặc định)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Học kỳ:";
            // 
            // cboLocHocKy
            // 
            this.cboLocHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocHocKy.FormattingEnabled = true;
            this.cboLocHocKy.Location = new System.Drawing.Point(590, 25);
            this.cboLocHocKy.Name = "cboLocHocKy";
            this.cboLocHocKy.Size = new System.Drawing.Size(80, 21);
            this.cboLocHocKy.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Năm học:";
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Location = new System.Drawing.Point(409, 26);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(100, 20);
            this.txtNamHoc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã lớp:";
            // 
            // txtLocMaLop
            // 
            this.txtLocMaLop.Location = new System.Drawing.Point(193, 26);
            this.txtLocMaLop.Name = "txtLocMaLop";
            this.txtLocMaLop.Size = new System.Drawing.Size(120, 20);
            this.txtLocMaLop.TabIndex = 1;
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(700, 24);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(100, 23);
            this.btnLoc.TabIndex = 0;
            this.btnLoc.Text = "Lọc Danh Sách";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTimKiem.Controls.Add(this.btnTimKiem);
            this.grpTimKiem.Controls.Add(this.label5);
            this.grpTimKiem.Controls.Add(this.txtTimKiem);
            this.grpTimKiem.Location = new System.Drawing.Point(12, 135);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(860, 60);
            this.grpTimKiem.TabIndex = 2;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm kiếm nhanh";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Location = new System.Drawing.Point(700, 22);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 23);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nhập tên hoặc Mã HS:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Location = new System.Drawing.Point(264, 24);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(420, 20);
            this.txtTimKiem.TabIndex = 2;
            // 
            // dgvHanhKiem
            // 
            this.dgvHanhKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHanhKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHanhKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHanhKiem.Location = new System.Drawing.Point(12, 205);
            this.dgvHanhKiem.Name = "dgvHanhKiem";
            this.dgvHanhKiem.Size = new System.Drawing.Size(860, 230);
            this.dgvHanhKiem.TabIndex = 3;
            this.dgvHanhKiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHanhKiem_CellClick);
            // 
            // grpCapNhat
            // 
            this.grpCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCapNhat.Controls.Add(this.btnXuatExcel);
            this.grpCapNhat.Controls.Add(this.btnLamMoi);
            this.grpCapNhat.Controls.Add(this.btnXoa);
            this.grpCapNhat.Controls.Add(this.btnLuu);
            this.grpCapNhat.Controls.Add(this.txtNhanXet);
            this.grpCapNhat.Controls.Add(this.label9);
            this.grpCapNhat.Controls.Add(this.cboXepLoai);
            this.grpCapNhat.Controls.Add(this.label8);
            this.grpCapNhat.Controls.Add(this.txtTenHS);
            this.grpCapNhat.Controls.Add(this.label7);
            this.grpCapNhat.Controls.Add(this.txtMaHS);
            this.grpCapNhat.Controls.Add(this.label6);
            this.grpCapNhat.Location = new System.Drawing.Point(12, 445);
            this.grpCapNhat.Name = "grpCapNhat";
            this.grpCapNhat.Size = new System.Drawing.Size(860, 140);
            this.grpCapNhat.TabIndex = 4;
            this.grpCapNhat.TabStop = false;
            this.grpCapNhat.Text = "Cập nhật Hạnh Kiểm";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuatExcel.ForeColor = System.Drawing.Color.Red;
            this.btnXuatExcel.Location = new System.Drawing.Point(264, 100);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(100, 23);
            this.btnXuatExcel.TabIndex = 11;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.Location = new System.Drawing.Point(620, 100);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 23);
            this.btnLamMoi.TabIndex = 10;
            this.btnLamMoi.Text = "Làm Mới Form";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Location = new System.Drawing.Point(510, 100);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 23);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Location = new System.Drawing.Point(395, 100);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 23);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu / Cập Nhật";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtNhanXet
            // 
            this.txtNhanXet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNhanXet.Location = new System.Drawing.Point(520, 25);
            this.txtNhanXet.Multiline = true;
            this.txtNhanXet.Name = "txtNhanXet";
            this.txtNhanXet.Size = new System.Drawing.Size(320, 56);
            this.txtNhanXet.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(450, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Nhận xét:";
            // 
            // cboXepLoai
            // 
            this.cboXepLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboXepLoai.FormattingEnabled = true;
            this.cboXepLoai.Location = new System.Drawing.Point(320, 60);
            this.cboXepLoai.Name = "cboXepLoai";
            this.cboXepLoai.Size = new System.Drawing.Size(100, 21);
            this.cboXepLoai.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Xếp loại:";
            // 
            // txtTenHS
            // 
            this.txtTenHS.Location = new System.Drawing.Point(520, 60); // Vi tri ao de giu code
            this.txtTenHS.Name = "txtTenHS";
            this.txtTenHS.Size = new System.Drawing.Size(10, 20);
            this.txtTenHS.Visible = false; // An di vi trong thiet ke anh Java k thay o nhap ten o duoi
            // Trong anh Java chi hien Ten o tren Grid, duoi Update chi nhap Xep Loai/Nhan Xet
            // Tuy nhien code logic co dung txtTenHS, nen toi van de day nhung an no di hoac hien thi len
            // UPDATE: Theo anh Java, co 2 cot MaHS va TenHS ben canh nhau. Toi se chinh lai
            // 
            // Chinh lai vi tri txtTenHS
            // 
            this.txtTenHS.Visible = true;
            this.txtTenHS.Location = new System.Drawing.Point(520, 0); // Reset location
            // 
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(450, 60); // Code sinh ra o duoi
            this.label7.Visible = false;
            // 
            // Re-layout Update Groupbox manually based on standard
            // 
            this.txtTenHS.Location = new System.Drawing.Point(320, 25);
            this.txtTenHS.Size = new System.Drawing.Size(120, 20);

            this.label7.Location = new System.Drawing.Point(260, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tên HS:";
            this.label7.Visible = true;

            // 
            // txtMaHS
            // 
            this.txtMaHS.Location = new System.Drawing.Point(130, 25);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(100, 20);
            this.txtMaHS.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã HS:";
            // 
            // QuanLyHanhKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 600);
            this.Controls.Add(this.grpCapNhat);
            this.Controls.Add(this.dgvHanhKiem);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.grpLoc);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyHanhKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Hạnh Kiểm";
            this.Load += new System.EventHandler(this.QuanLyHanhKiem_Load);
            this.grpLoc.ResumeLayout(false);
            this.grpLoc.PerformLayout();
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanhKiem)).EndInit();
            this.grpCapNhat.ResumeLayout(false);
            this.grpCapNhat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpLoc;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.TextBox txtLocMaLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboLocHocKy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvHanhKiem;
        private System.Windows.Forms.GroupBox grpCapNhat;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenHS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboXepLoai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNhanXet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXuatExcel;
    }
}