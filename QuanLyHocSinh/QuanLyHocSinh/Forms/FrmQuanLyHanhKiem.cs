using System;
using System.Data;
using System.Windows.Forms;
using QuanLyHocSinh.Database; // Gọi class kết nối CSDL

namespace QuanLyHocSinh.Forms
{
    public partial class FrmQuanLyHanhKiem : Form
    {
        public FrmQuanLyHanhKiem()
        {
            InitializeComponent();
        }

        // 1. SỰ KIỆN LOAD FORM
        private void QuanLyHanhKiem_Load(object sender, EventArgs e)
        {
            LoadComboBox(); // Tạo dữ liệu cho các ô chọn
            LoadData();     // Load toàn bộ danh sách lên

            // Cấu hình giao diện
            txtMaHS.ReadOnly = true;  // Không cho sửa Mã HS ở ô cập nhật
            txtTenHS.ReadOnly = true; // Không cho sửa Tên HS

            // Mặc định năm học hiện tại (Hardcode tạm hoặc lấy DateTime.Now.Year)
            txtNamHoc.Text = "2024-2025";
        }

        // 2. HÀM LOAD DỮ LIỆU TỪ SQL
        void LoadData(string query = "")
        {
            try
            {
                if (string.IsNullOrEmpty(query))
                {
                    // JOIN bảng HanhKiem và HocSinh để lấy Tên HS
                    // Cần đảm bảo tên bảng và tên cột khớp với SQL của bạn
                    query = "SELECT hk.MaHS, hs.HoTen, hk.NamHoc, hk.HocKy, hk.XepLoai, hk.NhanXet " +
                            "FROM HanhKiem hk JOIN HocSinh hs ON hk.MaHS = hs.MaHS";
                }

                DataTable dt = DatabaseHelper.GetData(query);
                dgvHanhKiem.DataSource = dt;

                // Đặt tiêu đề cột tiếng Việt
                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvHanhKiem.Columns["MaHS"].HeaderText = "Mã HS";
                    dgvHanhKiem.Columns["HoTen"].HeaderText = "Họ Tên";
                    dgvHanhKiem.Columns["NamHoc"].HeaderText = "Năm Học";
                    dgvHanhKiem.Columns["HocKy"].HeaderText = "Học Kỳ";
                    dgvHanhKiem.Columns["XepLoai"].HeaderText = "Xếp Loại";
                    dgvHanhKiem.Columns["NhanXet"].HeaderText = "Nhận Xét";

                    // Chỉnh độ rộng cột Nhận xét cho thoải mái
                    dgvHanhKiem.Columns["NhanXet"].Width = 200;
                    dgvHanhKiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        // 3. TẠO DỮ LIỆU CHO COMBOBOX
        void LoadComboBox()
        {
            // Combo Học Kỳ cho Lọc
            cboLocHocKy.Items.Clear();
            cboLocHocKy.Items.Add("1");
            cboLocHocKy.Items.Add("2");
            cboLocHocKy.SelectedIndex = 0;

            // Combo Xếp Loại cho phần Cập Nhật
            cboXepLoai.Items.Clear();
            cboXepLoai.Items.Add("Tốt");
            cboXepLoai.Items.Add("Khá");
            cboXepLoai.Items.Add("Trung Bình");
            cboXepLoai.Items.Add("Yếu");
            cboXepLoai.SelectedIndex = 0; // Mặc định chọn Tốt
        }

        // 4. BINDING DỮ LIỆU KHI CLICK VÀO BẢNG
        private void dgvHanhKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHanhKiem.Rows[e.RowIndex];

                txtMaHS.Text = row.Cells["MaHS"].Value?.ToString();
                txtTenHS.Text = row.Cells["HoTen"].Value?.ToString();
                txtNamHoc.Text = row.Cells["NamHoc"].Value?.ToString();

                // Gán giá trị vào ComboBox (Nếu giá trị trong bảng khớp với Items)
                string xepLoai = row.Cells["XepLoai"].Value?.ToString();
                if (cboXepLoai.Items.Contains(xepLoai))
                {
                    cboXepLoai.Text = xepLoai;
                }

                txtNhanXet.Text = row.Cells["NhanXet"].Value?.ToString();
            }
        }

        // 5. NÚT LỌC DANH SÁCH
        private void btnLoc_Click(object sender, EventArgs e)
        {
            string lop = txtLocMaLop.Text.Trim();
            string nam = txtNamHoc.Text.Trim();
            string hk = cboLocHocKy.Text;

            string sql = "SELECT hk.MaHS, hs.HoTen, hk.NamHoc, hk.HocKy, hk.XepLoai, hk.NhanXet " +
                         "FROM HanhKiem hk JOIN HocSinh hs ON hk.MaHS = hs.MaHS " +
                         $"WHERE hk.NamHoc = '{nam}' AND hk.HocKy = '{hk}'";

            if (!string.IsNullOrEmpty(lop))
            {
                sql += $" AND hs.MaLop LIKE '%{lop}%'";
            }

            LoadData(sql);
        }

        // 6. NÚT TÌM KIẾM
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string kw = txtTimKiem.Text.Trim();
            string sql = "SELECT hk.MaHS, hs.HoTen, hk.NamHoc, hk.HocKy, hk.XepLoai, hk.NhanXet " +
                         "FROM HanhKiem hk JOIN HocSinh hs ON hk.MaHS = hs.MaHS " +
                         $"WHERE hk.MaHS LIKE '%{kw}%' OR hs.HoTen LIKE N'%{kw}%'";
            LoadData(sql);
        }

        // 7. NÚT LƯU / CẬP NHẬT
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHS.Text)) return;

            try
            {
                string maHS = txtMaHS.Text;
                string nam = txtNamHoc.Text; // Lấy năm từ ô lọc hoặc ô binding
                // Giả sử ta lấy Học kỳ từ ô Lọc (vì trong form cập nhật không có ô chọn học kỳ)
                string hk = cboLocHocKy.Text;

                string xepLoai = cboXepLoai.Text;
                string nhanXet = txtNhanXet.Text;

                // SQL Update (Lưu ý có chữ N trước chuỗi tiếng Việt)
                string sql = $"UPDATE HanhKiem SET XepLoai=N'{xepLoai}', NhanXet=N'{nhanXet}' " +
                             $"WHERE MaHS='{maHS}' AND NamHoc='{nam}' AND HocKy='{hk}'";

                DatabaseHelper.ExecuteSql(sql);

                MessageBox.Show("Cập nhật hạnh kiểm thành công!");
                LoadData(); // Load lại để thấy thay đổi
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
            }
        }

        // 8. NÚT XÓA (Xóa đánh giá hạnh kiểm, đưa về chưa xếp loại hoặc xóa hẳn dòng)
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHS.Text)) return;

            if (MessageBox.Show("Xóa đánh giá hạnh kiểm của HS này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Ở đây tôi chọn phương án Update về rỗng thay vì Delete hẳn dòng (tùy nghiệp vụ)
                string sql = $"UPDATE HanhKiem SET XepLoai='', NhanXet='' " +
                             $"WHERE MaHS='{txtMaHS.Text}' AND NamHoc='{txtNamHoc.Text}' AND HocKy='{cboLocHocKy.Text}'";

                DatabaseHelper.ExecuteSql(sql);
                LoadData();
            }
        }

        // 9. NÚT LÀM MỚI FORM
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHS.Clear();
            txtTenHS.Clear();
            txtNhanXet.Clear();
            cboXepLoai.SelectedIndex = 0;
            LoadData(); // Load lại bảng gốc
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Chức năng đang phát triển");
            ExcelHelper.ExportToExcel(dgvHanhKiem, "DanhSachHanhKiem");
        }
    }
}