using System;
using System.Data;
using System.Windows.Forms;
using QuanLyHocSinh.Database;

namespace QuanLyHocSinh.Forms
{
    public partial class FrmLichThi : Form
    {
        public FrmLichThi()
        {
            InitializeComponent();
        }

        private void FrmLichThi_Load(object sender, EventArgs e)
        {
            LoadData();

            // Load Combo Kỳ Thi mẫu
            cboKyThi.Items.Add("Giữa Kỳ 1");
            cboKyThi.Items.Add("Cuối Kỳ 1");
            cboKyThi.Items.Add("Giữa Kỳ 2");
            cboKyThi.Items.Add("Cuối Kỳ 2");
            cboKyThi.SelectedIndex = 0;

            txtMaLT.ReadOnly = true; // Mã LT không cho sửa (tự tăng)
        }

        // 1. Hàm Load dữ liệu
        void LoadData(string query = "")
        {
            if (string.IsNullOrEmpty(query))
            {
                query = "SELECT * FROM LichThi";
            }

            DataTable dt = DatabaseHelper.GetData(query);
            dgvLichThi.DataSource = dt;
        }

        // 2. Click vào bảng -> Đổ dữ liệu xuống TextBox
        private void dgvLichThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLichThi.Rows[e.RowIndex];
                txtMaLT.Text = row.Cells["MaLT"].Value.ToString();
                txtMaMon.Text = row.Cells["MaMon"].Value.ToString();
                cboKyThi.Text = row.Cells["KyThi"].Value.ToString();

                // Xử lý Ngày thi
                if (DateTime.TryParse(row.Cells["NgayThi"].Value.ToString(), out DateTime date))
                {
                    dtpNgayThi.Value = date;
                }

                txtGioBatDau.Text = row.Cells["GioBatDau"].Value.ToString();
                txtGioKetThuc.Text = row.Cells["GioKetThuc"].Value.ToString();
                txtMaPhong.Text = row.Cells["MaPhong"].Value.ToString();
            }
        }

        // 3. Nút Thêm Mới
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("INSERT INTO LichThi (KyThi, MaMon, NgayThi, GioBatDau, GioKetThuc, MaPhong) " +
                                           "VALUES (N'{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                                           cboKyThi.Text, txtMaMon.Text, dtpNgayThi.Value.ToString("yyyy-MM-dd"),
                                           txtGioBatDau.Text, txtGioKetThuc.Text, txtMaPhong.Text);

                DatabaseHelper.ExecuteSql(sql);
                LoadData();
                MessageBox.Show("Thêm lịch thi thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
        }

        // 4. Nút Cập Nhật
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLT.Text)) return;

            try
            {
                string sql = string.Format("UPDATE LichThi SET KyThi=N'{0}', MaMon='{1}', NgayThi='{2}', " +
                                           "GioBatDau='{3}', GioKetThuc='{4}', MaPhong='{5}' WHERE MaLT='{6}'",
                                           cboKyThi.Text, txtMaMon.Text, dtpNgayThi.Value.ToString("yyyy-MM-dd"),
                                           txtGioBatDau.Text, txtGioKetThuc.Text, txtMaPhong.Text, txtMaLT.Text);

                DatabaseHelper.ExecuteSql(sql);
                LoadData();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
            }
        }

        // 5. Nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLT.Text)) return;

            if (MessageBox.Show("Bạn muốn xóa lịch thi này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "DELETE FROM LichThi WHERE MaLT='" + txtMaLT.Text + "'";
                DatabaseHelper.ExecuteSql(sql);
                LoadData();
            }
        }

        // 6. Nút Làm Mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLT.Clear();
            txtMaMon.Clear();
            txtGioBatDau.Clear();
            txtGioKetThuc.Clear();
            txtMaPhong.Clear();
            LoadData();
        }

        // 7. Tìm kiếm
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string kw = txtTimKiem.Text;
            string sql = "SELECT * FROM LichThi WHERE MaMon LIKE '%" + kw + "%' OR KyThi LIKE N'%" + kw + "%'";
            LoadData(sql);
        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Chức năng đang phát triển");
            ExcelHelper.ExportToExcel(dgvLichThi, "LichThi");
        }
    }
}