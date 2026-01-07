using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyHocSinh.Database; // Gọi thư mục Database

namespace QuanLyHocSinh.Forms
{
    public partial class FrmQuanLyDiem : Form
    {
        public FrmQuanLyDiem()
        {
            InitializeComponent();
        }

        // 1. KHI FORM VỪA MỞ LÊN
        private void FrmQuanLyDiem_Load(object sender, EventArgs e)
        {
            // 1. Load dữ liệu cho ComboBox trước
            LoadComboBox();

            // 2. Thiết lập mặc định (Ví dụ: Chọn môn Toán, Học kỳ 1)
            cbMon.SelectedIndex = 0; // Chọn item đầu tiên (TOAN)
            cbHocKy.SelectedIndex = 0; // Chọn item đầu tiên (Học kỳ 1)

            // 3. Gọi hàm Lọc ngay lập tức thay vì LoadData() suông
            // Điều này giúp bảng chỉ hiện đúng môn Toán, không bị lặp tên HS
            btnSort_Click(sender, e);

            // 4. Cấu hình giao diện bảng cho gọn
            txtMaHS.ReadOnly = true;
            txtHoTen.ReadOnly = true;
        }

        // Hàm tải dữ liệu lên bảng (DataGridView)
        void LoadData(string query = "")
        {
            // Nếu không có yêu cầu lọc riêng, lấy tất cả
            if (string.IsNullOrEmpty(query))
            {
                // JOIN bảng Diem và HocSinh để lấy Họ Tên
                query = "SELECT d.MaHS, hs.HoTen, d.MaMH, d.HocKy, d.NamHoc, d.DiemMieng, d.Diem15p, d.Diem1Tiet, d.DiemThi, d.DiemTB " +
                        "FROM Diem d JOIN HocSinh hs ON d.MaHS = hs.MaHS";
            }

            DataTable dt = DatabaseHelper.GetData(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                dgvDiem.DataSource = dt;

                // Đặt tên cột tiếng Việt cho đẹp
                dgvDiem.Columns["MaHS"].HeaderText = "Mã HS";
                dgvDiem.Columns["HoTen"].HeaderText = "Họ Tên";
                dgvDiem.Columns["MaMH"].HeaderText = "Môn Học";
                dgvDiem.Columns["HocKy"].HeaderText = "Học Kỳ";
                dgvDiem.Columns["NamHoc"].HeaderText = "Năm Học";
                dgvDiem.Columns["DiemMieng"].HeaderText = "Điểm Miệng";
                dgvDiem.Columns["Diem15p"].HeaderText = "15 Phút"; // Lưu ý: 15p thường
                dgvDiem.Columns["Diem1Tiet"].HeaderText = "1 Tiết";
                dgvDiem.Columns["DiemThi"].HeaderText = "Điểm Thi";
                dgvDiem.Columns["DiemTB"].HeaderText = "Trung Bình";
            }
            else
            {
                dgvDiem.DataSource = null; // Reset bảng nếu không có dữ liệu
            }
            // ... (Phần trên giữ nguyên)
            if (dt != null && dt.Rows.Count > 0)
            {
                dgvDiem.DataSource = dt;

                // Đặt tên cột tiếng Việt
                dgvDiem.Columns["MaHS"].HeaderText = "Mã HS";
                dgvDiem.Columns["HoTen"].HeaderText = "Họ và Tên";
                // ... các cột điểm ...

                // --- THÊM ĐOẠN NÀY ĐỂ ẨN CỘT THỪA ---
                //dgvDiem.Columns["MaMH"].Visible = true; // Ẩn cột Mã môn (vì đã chọn trên combobox rồi)
                //dgvDiem.Columns["NamHoc"].Visible = false; // Ẩn năm học cho gọn

                // Chỉnh lại chiều rộng cột cho đẹp
                dgvDiem.Columns["HoTen"].Width = 150; // Cột tên rộng ra chút
                dgvDiem.Columns["MaHS"].Width = 80;
            }
            // ...
        }

        // Hàm tạo dữ liệu cho ComboBox
        void LoadComboBox()
        {
            cbMon.Items.Clear();
            cbMon.Items.Add("TOAN");
            cbMon.Items.Add("VAN");
            cbMon.Items.Add("ANH");
            cbMon.Items.Add("LY");
            cbMon.Items.Add("HOA");
            cbMon.SelectedIndex = 0;

            cbHocKy.Items.Clear();
            cbHocKy.Items.Add("1");
            cbHocKy.Items.Add("2");
            cbHocKy.SelectedIndex = 0;
        }

        // 2. SỰ KIỆN CLICK VÀO BẢNG -> HIỆN DỮ LIỆU LÊN TRÊN
        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDiem.Rows[e.RowIndex];

                // Đổ dữ liệu vào các ô TextBox
                txtMaHS.Text = row.Cells["MaHS"].Value?.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();

                // Chọn lại Môn và Học kỳ tương ứng trên ComboBox
                cbMon.Text = row.Cells["MaMH"].Value?.ToString();
                cbHocKy.Text = row.Cells["HocKy"].Value?.ToString();

                // Đổ điểm
                txtDiemMieng.Text = row.Cells["DiemMieng"].Value?.ToString();
                txt15phut.Text = row.Cells["Diem15p"].Value?.ToString();
                txt1Tiet.Text = row.Cells["Diem1Tiet"].Value?.ToString();
                txtDiemThi.Text = row.Cells["DiemThi"].Value?.ToString();
            }
        }

        // 3. NÚT LỌC (SORT)
        private void btnSort_Click(object sender, EventArgs e)
        {
            if (cbMon.SelectedItem == null || cbHocKy.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng đợi dữ liệu tải xong hoặc kiểm tra kết nối!");
                return;
            }
            string maLop = txtMalop.Text.Trim();
            string mon = cbMon.Text;
            string hk = cbHocKy.Text;

            string sql = $"SELECT d.MaHS, hs.HoTen, d.MaMH, d.HocKy, d.NamHoc, d.DiemMieng, d.Diem15p, d.Diem1Tiet, d.DiemThi, d.DiemTB " +
                         $"FROM Diem d JOIN HocSinh hs ON d.MaHS = hs.MaHS " +
                         $"WHERE d.MaMH = '{mon}' AND d.HocKy = '{hk}'";

            if (!string.IsNullOrEmpty(maLop))
            {
                sql += $" AND hs.MaLop LIKE '%{maLop}%'";
            }

            LoadData(sql);
        }

        // 4. NÚT TÌM KIẾM (SEARCH)
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            string sql = $"SELECT d.MaHS, hs.HoTen, d.MaMH, d.HocKy, d.NamHoc, d.DiemMieng, d.Diem15p, d.Diem1Tiet, d.DiemThi, d.DiemTB " +
                         $"FROM Diem d JOIN HocSinh hs ON d.MaHS = hs.MaHS " +
                         $"WHERE d.MaHS LIKE '%{keyword}%' OR hs.HoTen LIKE N'%{keyword}%'";
            LoadData(sql);
        }

        // 5. NÚT SỬA (CẬP NHẬT)
        private void btnEditDiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHS.Text)) return;

            try
            {
                // Lấy dữ liệu từ form
                string maHS = txtMaHS.Text;
                string maMH = cbMon.Text; // Lấy môn đang chọn
                string hk = cbHocKy.Text;

                // Chuyển đổi điểm (Nếu để trống thì tính là 0)
                float dm = string.IsNullOrEmpty(txtDiemMieng.Text) ? 0 : float.Parse(txtDiemMieng.Text);
                float d15 = string.IsNullOrEmpty(txt15phut.Text) ? 0 : float.Parse(txt15phut.Text);
                float d1t = string.IsNullOrEmpty(txt1Tiet.Text) ? 0 : float.Parse(txt1Tiet.Text);
                float dthi = string.IsNullOrEmpty(txtDiemThi.Text) ? 0 : float.Parse(txtDiemThi.Text);

                // Tự động tính điểm TB
                float dtb = (float)Math.Round((dm + d15 + d1t * 2 + dthi * 3) / 7, 2);

                // Câu lệnh UPDATE
                string sql = $"UPDATE Diem SET DiemMieng={dm}, Diem15p={d15}, Diem1Tiet={d1t}, DiemThi={dthi}, DiemTB={dtb} " +
                             $"WHERE MaHS='{maHS}' AND MaMH='{maMH}' AND HocKy='{hk}'";

                DatabaseHelper.ExecuteSql(sql);

                MessageBox.Show("Cập nhật thành công!");
                LoadData(); // Load lại bảng để thấy kết quả
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhập liệu (Vui lòng nhập số): " + ex.Message);
            }
        }

        // 6. NÚT XÓA
        private void btnXoaDiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHS.Text)) return;

            if (MessageBox.Show("Bạn có chắc muốn xóa điểm môn " + cbMon.Text + " này?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = $"DELETE FROM Diem WHERE MaHS='{txtMaHS.Text}' AND MaMH='{cbMon.Text}' AND HocKy='{cbHocKy.Text}'";
                DatabaseHelper.ExecuteSql(sql);
                LoadData();
                MessageBox.Show("Đã xóa!");
            }
        }

        // Thêm đoạn này vào cuối class FrmQuanLyDiem để hết lỗi biên dịch
        private void btnExportDiem_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Chức năng đang phát triển");
            ExcelHelper.ExportToExcel(dgvDiem, "BangDiemHocSinh");
        }

        // Sự kiện này giúp tự động đánh số 1, 2, 3... ở đầu dòng
        private void dgvDiem_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvDiem.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }


}