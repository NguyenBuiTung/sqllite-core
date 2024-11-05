using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CometBarCode
{
    public partial class HistoryScan : Form
    {
        public HistoryScan()
        {
            InitializeComponent();
        }
        private void LoadHistory()
        {
            using (var db = new AppDbContext())
            {
                // Lấy khoảng thời gian từ DateTimePicker
                DateTime fromDate = dateTimePickerFrom.Value.Date;
                DateTime toDate = dateTimePickerTo.Value.Date.AddDays(1).AddTicks(-1); // Đến hết ngày được chọn

                // Lấy giá trị tìm kiếm từ TextBox
                string searchCode = textBoxSearch.Text.Trim(); // Lấy mã sản phẩm từ TextBox

                // Truy vấn lịch sử quét dựa trên khoảng thời gian và mã sản phẩm
                var query = db.CodeEntries
                    .Where(entry => entry.ScanTime >= fromDate && entry.ScanTime <= toDate
                                && (string.IsNullOrEmpty(searchCode) || entry.Code.Contains(searchCode))) // Thêm điều kiện tìm kiếm
                    .Select(entry => new
                    {
                        entry.Code,
                        ProductType = entry.ProductType != null ? entry.ProductType : "N/A", // Nếu không có Setting
                        Mãtrạngthái = entry.IsDuplicate ? "Mã trùng lặp" : entry.IsWrongType ? "Sai loại sản phẩm" : "Hợp lệ",
                        entry.ScanTime,
                        Status = entry.IsDuplicate || entry.IsWrongType ? "NG" : "OK" // Thêm cột OK/NG
                    }).ToList();

                // Hiển thị dữ liệu lên DataGridView
                dataGridViewHistory.DataSource = query;
            }
        }


        private void btnViewHistory_Click_1(object sender, EventArgs e)
        {
            // Đảm bảo rằng ngày bắt đầu không lớn hơn ngày kết thúc (cho phép cùng một ngày)
            if (dateTimePickerFrom.Value.Date > dateTimePickerTo.Value.Date)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Không cho phép xuất nếu thời gian không hợp lệ
            }

            LoadHistory();
        }



        private async void btnExcel_Click_1(object sender, EventArgs e)
        {
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save Excel File";
                saveFileDialog.FileName = $"HistoryScan_{dateTimePickerFrom.Value:yyyy-MM-dd}_{dateTimePickerTo.Value:yyyy-MM-dd}.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileInfo = new System.IO.FileInfo(saveFileDialog.FileName);

                    // Hiển thị ProgressBar và thiết lập giá trị ban đầu
                    progressBarExport.Visible = true;
                    progressBarExport.Value = 0;
                    lblProgressPercentage.Visible = true;
                    lblProgressPercentage.Text = "0%";

                    await Task.Run(() =>
                    {
                        using (var package = new OfficeOpenXml.ExcelPackage(fileInfo))
                        {
                            var worksheet = package.Workbook.Worksheets.Add("History Scan");

                            // Thiết lập tiêu đề cột
                            worksheet.Cells[1, 1].Value = "Mã vạch";
                            worksheet.Cells[1, 2].Value = "Thời gian quét";
                            worksheet.Cells[1, 3].Value = "Mã Trạng thái";
                            worksheet.Cells[1, 4].Value = "Trạng thái";
                            worksheet.Cells[1, 5].Value = "Model";

                            int batchSize = 1000;
                            int row = 2;

                            using (var context = new AppDbContext())
                            {
                                DateTime fromDate = dateTimePickerFrom.Value.Date;
                                DateTime toDate = dateTimePickerTo.Value.Date.AddDays(1).AddTicks(-1);

                                var query = context.CodeEntries
                                                    .Where(scan => scan.ScanTime >= fromDate && scan.ScanTime <= toDate);

                                int totalRecords = query.Count();
                                int totalBatches = (int)Math.Ceiling((double)totalRecords / batchSize);
                                int currentBatch = 0;

                                do
                                {
                                    var scans = query.OrderBy(scan => scan.ScanTime)
                                                     .Skip(currentBatch * batchSize)
                                                     .Take(batchSize)
                                                     .ToList();

                                    if (scans.Count == 0)
                                        break;

                                    foreach (var scan in scans)
                                    {
                                        worksheet.Cells[row, 1].Value = scan.Code;
                                        string status = scan.IsDuplicate ? "Mã trùng lặp" : scan.IsWrongType ? "Sai loại sản phẩm" : "Hợp lệ";
                                        string checkstatus = scan.IsDuplicate || scan.IsWrongType ? "NG" : "OK";
                                        worksheet.Cells[row, 4].Value = checkstatus;
                                        //worksheet.Cells[row, 5].Value = scan.Model;
                                        worksheet.Cells[row, 3].Value = status;
                                        worksheet.Cells[row, 2].Value = scan.ScanTime.ToString("yyyy-MM-dd HH:mm:ss");

                                        row++;
                                    }

                                    currentBatch++;

                                    // Cập nhật ProgressBar và % hoàn thành
                                    int progressPercentage = (int)((currentBatch / (double)totalBatches) * 100);

                                    // Thực hiện cập nhật trên UI thread
                                    this.Invoke(new Action(() =>
                                    {
                                        progressBarExport.Value = progressPercentage;
                                        lblProgressPercentage.Text = $"{progressPercentage}%"; // Hiển thị phần trăm hoàn thành
                                    }));

                                } while (currentBatch < totalBatches);
                            }

                            // Tự động điều chỉnh chiều rộng các cột
                            worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                            package.Save();
                        }
                    });

                    // Ẩn ProgressBar và Label khi hoàn tất
                    progressBarExport.Visible = false;
                    lblProgressPercentage.Visible = false;

                    // Hỏi người dùng có muốn mở file sau khi xuất không
                    var result = MessageBox.Show("Bạn có muốn mở file đã lưu không?", "Mở file", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            var processStartInfo = new System.Diagnostics.ProcessStartInfo
                            {
                                FileName = fileInfo.FullName,
                                UseShellExecute = true // Sử dụng ShellExecute để mở file với ứng dụng mặc định
                            };
                            System.Diagnostics.Process.Start(processStartInfo);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Không thể mở file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadHistory();
        }
    }
}
