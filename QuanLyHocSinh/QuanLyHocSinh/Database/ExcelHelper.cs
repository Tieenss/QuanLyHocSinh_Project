using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel; // Khai báo thư viện Excel

namespace QuanLyHocSinh.Database
{
    public class ExcelHelper
    {
        public static void ExportToExcel(DataGridView dgv, string fileNameDefault)
        {
            // 1. Kiểm tra dữ liệu
            if (dgv.Rows.Count == 0 || dgv.Columns.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo");
                return;
            }

            // 2. Khởi tạo các đối tượng Excel
            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;

            try
            {
                // Tạo một ứng dụng Excel mới (chạy ngầm)
                excelApp = new Excel.Application();
                workbook = excelApp.Workbooks.Add(Type.Missing);
                worksheet = (Excel.Worksheet)workbook.Sheets[1];
                worksheet.Name = "DuLieuXuat"; // Đặt tên sheet

                // --- GHI TIÊU ĐỀ CỘT ---
                int colIndex = 1; // Excel bắt đầu từ cột 1 (không phải 0)

                // Duyệt qua các cột của DataGridView
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    if (dgv.Columns[i].Visible) // Chỉ xuất cột đang hiện
                    {
                        worksheet.Cells[1, colIndex] = dgv.Columns[i].HeaderText;

                        // In đậm và tô màu nền xám cho tiêu đề
                        Excel.Range headerRange = worksheet.Cells[1, colIndex];
                        headerRange.Font.Bold = true;
                        headerRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);

                        colIndex++;
                    }
                }

                // --- GHI DỮ LIỆU DÒNG ---
                for (int i = 0; i < dgv.Rows.Count; i++) // Duyệt dòng
                {
                    colIndex = 1; // Reset lại cột về 1 cho dòng mới
                    for (int j = 0; j < dgv.Columns.Count; j++) // Duyệt cột
                    {
                        if (dgv.Columns[j].Visible && !dgv.Rows[i].IsNewRow)
                        {
                            // Ghi giá trị (Thêm dấu nháy đơn ' để tránh bị lỗi định dạng ngày tháng/số)
                            object value = dgv.Rows[i].Cells[j].Value;
                            worksheet.Cells[i + 2, colIndex] = value != null ? "'" + value.ToString() : "";
                            colIndex++;
                        }
                    }
                }

                // --- KẺ BẢNG VÀ CĂN CHỈNH ---
                Excel.Range usedRange = worksheet.UsedRange;

                // Kẻ khung viền (Borders)
                usedRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                usedRange.Borders.Weight = Excel.XlBorderWeight.xlThin;

                // Tự động giãn cột cho vừa nội dung
                usedRange.Columns.AutoFit();

                // 3. Mở hộp thoại lưu file
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Files (*.xlsx)|*.xlsx"; // Đuôi file Excel chuẩn
                sfd.FileName = fileNameDefault + "_" + DateTime.Now.ToString("ddMMyyyy_HHmm") + ".xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(sfd.FileName);
                    MessageBox.Show("Xuất Excel thành công!\nĐường dẫn: " + sfd.FileName);

                    // Hỏi người dùng có muốn mở file ngay không
                    if (MessageBox.Show("Bạn có muốn mở file vừa xuất không?", "Hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        excelApp.Visible = true; // Hiện Excel lên
                        return; // Thoát hàm để không đóng Excel
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất Excel: " + ex.Message);
            }
            finally
            {
                // Dọn dẹp bộ nhớ nếu không mở Excel
                if (workbook != null) workbook.Close(false);
                if (excelApp != null && !excelApp.Visible) excelApp.Quit();

                releaseObject(worksheet);
                releaseObject(workbook);
                releaseObject(excelApp);
            }
        }

        // Hàm phụ để giải phóng bộ nhớ COM (tránh Excel chạy ngầm mãi không tắt)
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Lỗi dọn dẹp bộ nhớ: " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}