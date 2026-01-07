namespace QuanLyHocSinh.Forms
{
    partial class FrmQuanLyDiem
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
            this.sortClass = new System.Windows.Forms.GroupBox();
            this.txtMalop = new System.Windows.Forms.TextBox();
            this.cbMon = new System.Windows.Forms.ComboBox();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.hocky = new System.Windows.Forms.Label();
            this.mon = new System.Windows.Forms.Label();
            this.malop = new System.Windows.Forms.Label();
            this.speedSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExportDiem = new System.Windows.Forms.Button();
            this.btnXoaDiem = new System.Windows.Forms.Button();
            this.txtDiemThi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt15phut = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt1Tiet = new System.Windows.Forms.TextBox();
            this.lb1Tiet = new System.Windows.Forms.Label();
            this.txtDiemMieng = new System.Windows.Forms.TextBox();
            this.lbDiemMieng = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditDiem = new System.Windows.Forms.Button();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.sortClass.SuspendLayout();
            this.speedSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(286, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ ĐIỂM HỌC SINH";
            // 
            // sortClass
            // 
            this.sortClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sortClass.Controls.Add(this.txtMalop);
            this.sortClass.Controls.Add(this.cbMon);
            this.sortClass.Controls.Add(this.cbHocKy);
            this.sortClass.Controls.Add(this.btnSort);
            this.sortClass.Controls.Add(this.hocky);
            this.sortClass.Controls.Add(this.mon);
            this.sortClass.Controls.Add(this.malop);
            this.sortClass.Location = new System.Drawing.Point(26, 63);
            this.sortClass.Name = "sortClass";
            this.sortClass.Size = new System.Drawing.Size(869, 67);
            this.sortClass.TabIndex = 1;
            this.sortClass.TabStop = false;
            this.sortClass.Text = "Lọc theo lớp (Mặc định)";
            // 
            // txtMalop
            // 
            this.txtMalop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMalop.Location = new System.Drawing.Point(216, 29);
            this.txtMalop.Name = "txtMalop";
            this.txtMalop.Size = new System.Drawing.Size(161, 20);
            this.txtMalop.TabIndex = 7;
            // 
            // cbMon
            // 
            this.cbMon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMon.FormattingEnabled = true;
            this.cbMon.Location = new System.Drawing.Point(448, 29);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(109, 21);
            this.cbMon.TabIndex = 8;
            // 
            // cbHocKy
            // 
            this.cbHocKy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(643, 29);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(109, 21);
            this.cbHocKy.TabIndex = 7;
            // 
            // btnSort
            // 
            this.btnSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSort.Location = new System.Drawing.Point(775, 27);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 6;
            this.btnSort.Text = "Lọc";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // hocky
            // 
            this.hocky.AutoSize = true;
            this.hocky.Location = new System.Drawing.Point(589, 32);
            this.hocky.Name = "hocky";
            this.hocky.Size = new System.Drawing.Size(48, 13);
            this.hocky.TabIndex = 5;
            this.hocky.Text = "Học Kỳ: ";
            // 
            // mon
            // 
            this.mon.AutoSize = true;
            this.mon.Location = new System.Drawing.Point(408, 32);
            this.mon.Name = "mon";
            this.mon.Size = new System.Drawing.Size(34, 13);
            this.mon.TabIndex = 4;
            this.mon.Text = "Môn: ";
            // 
            // malop
            // 
            this.malop.AutoSize = true;
            this.malop.Location = new System.Drawing.Point(165, 32);
            this.malop.Name = "malop";
            this.malop.Size = new System.Drawing.Size(45, 13);
            this.malop.TabIndex = 3;
            this.malop.Text = "Mã lớp: ";
            // 
            // speedSearch
            // 
            this.speedSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.speedSearch.Controls.Add(this.btnSearch);
            this.speedSearch.Controls.Add(this.txtSearch);
            this.speedSearch.Controls.Add(this.label7);
            this.speedSearch.Location = new System.Drawing.Point(26, 146);
            this.speedSearch.Name = "speedSearch";
            this.speedSearch.Size = new System.Drawing.Size(869, 59);
            this.speedSearch.TabIndex = 6;
            this.speedSearch.TabStop = false;
            this.speedSearch.Text = "Tìm kiếm nhanh";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(741, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(301, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(434, 20);
            this.txtSearch.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nhập tên hoặc Mã SV: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnExportDiem);
            this.groupBox1.Controls.Add(this.btnXoaDiem);
            this.groupBox1.Controls.Add(this.txtDiemThi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt15phut);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt1Tiet);
            this.groupBox1.Controls.Add(this.lb1Tiet);
            this.groupBox1.Controls.Add(this.txtDiemMieng);
            this.groupBox1.Controls.Add(this.lbDiemMieng);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnEditDiem);
            this.groupBox1.Controls.Add(this.txtMaHS);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 455);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 131);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cập nhật điểm";
            // 
            // btnExportDiem
            // 
            this.btnExportDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportDiem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnExportDiem.ForeColor = System.Drawing.Color.Red;
            this.btnExportDiem.Location = new System.Drawing.Point(729, 91);
            this.btnExportDiem.Name = "btnExportDiem";
            this.btnExportDiem.Size = new System.Drawing.Size(105, 23);
            this.btnExportDiem.TabIndex = 19;
            this.btnExportDiem.Text = "Xuất bảng điểm";
            this.btnExportDiem.UseVisualStyleBackColor = false;
            this.btnExportDiem.Click += new System.EventHandler(this.btnExportDiem_Click);
            // 
            // btnXoaDiem
            // 
            this.btnXoaDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaDiem.Location = new System.Drawing.Point(729, 48);
            this.btnXoaDiem.Name = "btnXoaDiem";
            this.btnXoaDiem.Size = new System.Drawing.Size(105, 23);
            this.btnXoaDiem.TabIndex = 18;
            this.btnXoaDiem.Text = "Xóa";
            this.btnXoaDiem.UseVisualStyleBackColor = true;
            this.btnXoaDiem.Click += new System.EventHandler(this.btnXoaDiem_Click);
            // 
            // txtDiemThi
            // 
            this.txtDiemThi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiemThi.Location = new System.Drawing.Point(532, 59);
            this.txtDiemThi.Name = "txtDiemThi";
            this.txtDiemThi.Size = new System.Drawing.Size(132, 20);
            this.txtDiemThi.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Điểm Thi:";
            // 
            // txt15phut
            // 
            this.txt15phut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt15phut.Location = new System.Drawing.Point(532, 22);
            this.txt15phut.Name = "txt15phut";
            this.txt15phut.Size = new System.Drawing.Size(132, 20);
            this.txt15phut.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(456, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Điểm 15 phút";
            // 
            // txt1Tiet
            // 
            this.txt1Tiet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt1Tiet.Location = new System.Drawing.Point(310, 59);
            this.txt1Tiet.Name = "txt1Tiet";
            this.txt1Tiet.Size = new System.Drawing.Size(132, 20);
            this.txt1Tiet.TabIndex = 13;
            // 
            // lb1Tiet
            // 
            this.lb1Tiet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb1Tiet.AutoSize = true;
            this.lb1Tiet.Location = new System.Drawing.Point(241, 62);
            this.lb1Tiet.Name = "lb1Tiet";
            this.lb1Tiet.Size = new System.Drawing.Size(60, 13);
            this.lb1Tiet.TabIndex = 12;
            this.lb1Tiet.Text = "Điểm 1 tiết:";
            // 
            // txtDiemMieng
            // 
            this.txtDiemMieng.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiemMieng.Location = new System.Drawing.Point(310, 24);
            this.txtDiemMieng.Name = "txtDiemMieng";
            this.txtDiemMieng.Size = new System.Drawing.Size(132, 20);
            this.txtDiemMieng.TabIndex = 11;
            // 
            // lbDiemMieng
            // 
            this.lbDiemMieng.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDiemMieng.AutoSize = true;
            this.lbDiemMieng.Location = new System.Drawing.Point(241, 27);
            this.lbDiemMieng.Name = "lbDiemMieng";
            this.lbDiemMieng.Size = new System.Drawing.Size(65, 13);
            this.lbDiemMieng.TabIndex = 10;
            this.lbDiemMieng.Text = "Điểm miệng:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtHoTen.Location = new System.Drawing.Point(78, 59);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(132, 20);
            this.txtHoTen.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Họ Tên";
            // 
            // btnEditDiem
            // 
            this.btnEditDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditDiem.Location = new System.Drawing.Point(729, 19);
            this.btnEditDiem.Name = "btnEditDiem";
            this.btnEditDiem.Size = new System.Drawing.Size(105, 23);
            this.btnEditDiem.TabIndex = 7;
            this.btnEditDiem.Text = "Sửa";
            this.btnEditDiem.UseVisualStyleBackColor = true;
            this.btnEditDiem.Click += new System.EventHandler(this.btnEditDiem_Click);
            // 
            // txtMaHS
            // 
            this.txtMaHS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaHS.Location = new System.Drawing.Point(78, 24);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.ReadOnly = true;
            this.txtMaHS.Size = new System.Drawing.Size(132, 20);
            this.txtMaHS.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã HS:";
            // 
            // dgvDiem
            // 
            this.dgvDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Location = new System.Drawing.Point(26, 211);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.Size = new System.Drawing.Size(869, 238);
            this.dgvDiem.TabIndex = 18;
            this.dgvDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiem_CellClick);
            this.dgvDiem.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDiem_RowPostPaint);
            // 
            // FrmQuanLyDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 598);
            this.Controls.Add(this.dgvDiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.speedSearch);
            this.Controls.Add(this.sortClass);
            this.Controls.Add(this.label1);
            this.Name = "FrmQuanLyDiem";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmQuanLyDiem_Load);
            this.sortClass.ResumeLayout(false);
            this.sortClass.PerformLayout();
            this.speedSearch.ResumeLayout(false);
            this.speedSearch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox sortClass;
        private System.Windows.Forms.Label hocky;
        private System.Windows.Forms.Label mon;
        private System.Windows.Forms.Label malop;
        private System.Windows.Forms.GroupBox speedSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMon;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtMalop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditDiem;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiemThi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt15phut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt1Tiet;
        private System.Windows.Forms.Label lb1Tiet;
        private System.Windows.Forms.TextBox txtDiemMieng;
        private System.Windows.Forms.Label lbDiemMieng;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.Button btnExportDiem;
        private System.Windows.Forms.Button btnXoaDiem;
    }
}