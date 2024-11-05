using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;
using ZXing.Common;
using ZXing.Rendering; // Đảm bảo bạn có dòng này để sử dụng BitmapRenderer
using System.Drawing;
using QRCoder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Sockets;
namespace CometBarCode
{
    public partial class Main : Form
    {
        private Account _loggedInAccount;
        public Main(Account loggedInAccount)
        {
            InitializeComponent();
            DeleteOldRecords();
            LoadProductType();
            SetupListView();
            _loggedInAccount = loggedInAccount;
        }
        private void DeleteOldRecords()
        {
            using (var db = new AppDbContext())
            {
                // Lấy ngày hiện tại và tính ngày 6 tháng trước
                DateTime sixMonthsAgo = DateTime.Now.AddMonths(-6);
                //MessageBox.Show(sixMonthsAgo.ToString());
                // Lọc các bản ghi có ScanTime cũ hơn 6 tháng
                var oldEntries = db.CodeEntries.Where(entry => entry.ScanTime < sixMonthsAgo).ToList();
                if (oldEntries.Count > 0)
                {
                    // Xóa các bản ghi
                    db.CodeEntries.RemoveRange(oldEntries);
                    db.SaveChanges();
                    MessageBox.Show($"{oldEntries.Count} bản ghi cũ đã bị xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtProductType_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự có phải là chữ cái và có là chữ in hoa hay không
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // Không cho phép nhập ký tự không phải chữ cái
            }

            // Kiểm tra độ dài, không cho nhập thêm khi đã đủ 4 ký tự
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Chặn các ký tự vượt quá độ dài 4
            }
        }
        private void txtProductType_TextChanged_1(object sender, EventArgs e)
        {
            // Chuyển tất cả các ký tự trong TextBox thành chữ in hoa
            txtProductType.Text = txtProductType.Text.ToUpper();

            // Đặt con trỏ lại cuối TextBox (sau khi thay đổi chữ in hoa)
            txtProductType.SelectionStart = txtProductType.Text.Length;
        }
        private void LoadProductType()
        {
            using (var db = new AppDbContext())
            {
                // Lấy cấu hình hiện tại từ cơ sở dữ liệu
                var settings = db.Settings.FirstOrDefault();

                if (settings != null)
                {
                    // Gán giá trị ProductType vào TextBox
                    txtProductType.Text = settings.ProductType;
                }
                else
                {
                    // Nếu chưa có cấu hình, để TextBox rỗng
                    txtProductType.Text = string.Empty;
                }
            }
        }

        private void SetProductType(string productType)
        {
            using (var db = new AppDbContext())
            {
                // Lấy cấu hình hiện tại hoặc tạo mới nếu chưa có
                var settings = db.Settings.FirstOrDefault();
                if (settings == null)
                {
                    settings = new Setting();
                    db.Settings.Add(settings);
                }

                // Cập nhật loại sản phẩm và thời gian cập nhật
                settings.ProductType = productType;
                settings.LastUpdated = DateTime.Now;
                db.SaveChanges();
            }

            MessageBox.Show("Cài đặt loại sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSettingQr_Click(object sender, EventArgs e)
        {
            // Lấy mã loại sản phẩm từ TextBox
            string productType = txtProductType.Text.Trim();

            // Kiểm tra mã sản phẩm có hợp lệ không (cần đủ 4 ký tự)
            //if (productType.Length != 4)
            //{
            //    MessageBox.Show("Mã sản phẩm phải có đúng 4 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            // Gọi hàm để cài đặt loại sản phẩm
            SetProductType(productType);
        }
        private void btnResetQr_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                // Lấy cấu hình hiện tại từ cơ sở dữ liệu
                var settings = db.Settings.FirstOrDefault();

                if (settings != null)
                {
                    // Đặt lại ProductType về giá trị mặc định (ví dụ: rỗng)
                    settings.ProductType = string.Empty;
                    settings.LastUpdated = DateTime.Now;

                    // Lưu thay đổi vào cơ sở dữ liệu
                    db.SaveChanges();
                }

                // Đặt lại TextBox về giá trị rỗng
                txtProductType.Text = string.Empty;

                // Thông báo đã reset thành công
                MessageBox.Show("Đã đặt lại loại sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private string GetBarcodeFromScanner()
        {
            return "ABC284320234322";
        }
        //private string GetBarcodeFromScanner()
        //{
        //    string ipAddress = "192.168.1.520";  // Địa chỉ IP của đầu đọc DataMan 280
        //    int port = 23;                      // Cổng TCP (DataMan thường sử dụng cổng 23 hoặc 8000)

        //    try
        //    {
        //        using (TcpClient client = new TcpClient(ipAddress, port))
        //        using (NetworkStream stream = client.GetStream())
        //        {
        //            // Gửi lệnh để yêu cầu đầu đọc quét mã vạch (tùy thuộc vào giao thức đầu đọc hỗ trợ)
        //            string command = "TRIGGER";  // Giả sử đầu đọc sử dụng lệnh "TRIGGER" để quét mã
        //            byte[] data = Encoding.ASCII.GetBytes(command + "\r\n");

        //            // Gửi lệnh tới đầu đọc
        //            stream.Write(data, 0, data.Length);

        //            // Đọc dữ liệu trả về từ đầu đọc
        //            byte[] buffer = new byte[256];
        //            int bytesRead = stream.Read(buffer, 0, buffer.Length);

        //            // Chuyển đổi dữ liệu từ byte thành chuỗi
        //            string barcode = Encoding.ASCII.GetString(buffer, 0, bytesRead);

        //            // Loại bỏ ký tự xuống dòng hoặc khoảng trắng không mong muốn
        //            barcode = barcode.Trim();

        //            return "ABCD284320234333";  // Trả về mã vạch thực từ đầu đọc
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // Xử lý ngoại lệ (lỗi kết nối, lỗi đầu đọc)
        //        Console.WriteLine("Lỗi khi kết nối với đầu đọc: " + ex.Message);
        //        return null;
        //    }
        //}
        //private void TriggerWarning()
        //{
        //    try
        //    {
        //        // Tạo đối tượng PLC S7-1200 (loại CPU S71200, kết nối qua Ethernet)
        //        Plc plc = new Plc(CpuType.S71200, "192.168.0.1", 0, 1); // Địa chỉ IP của PLC và rack/slot (0/1 mặc định cho S7-1200)

        //        // Kết nối với PLC
        //        plc.Open();

        //        if (plc.IsConnected)
        //        {
        //            // Bật đèn đỏ và còi báo động bằng cách ghi vào vùng nhớ Q (địa chỉ của output)
        //            plc.Write("Q0.0", true);  // Ví dụ: Địa chỉ Q0.0 cho đèn đỏ
        //            plc.Write("Q0.1", true);  // Ví dụ: Địa chỉ Q0.1 cho còi báo động

        //            // Để đèn và còi bật trong 5 giây
        //            Task.Delay(5000).Wait();

        //            // Tắt đèn đỏ và còi báo động
        //            plc.Write("Q0.0", false);  // Tắt đèn đỏ
        //            plc.Write("Q0.1", false);  // Tắt còi báo động
        //        }
        //        else
        //        {
        //            MessageBox.Show("Không thể kết nối với PLC.");
        //        }

        //        // Ngắt kết nối với PLC
        //        plc.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi điều khiển PLC: " + ex.Message);
        //    }
        //}

        //private void TriggerWarning()
        //{
        //    // Giả sử bạn sử dụng thư viện Digital IO để điều khiển đèn
        //    var ioController = new IOController();

        //    // Bật đèn đỏ và còi báo động qua cổng I/O tương ứng
        //    ioController.SetPinHigh(1); // Cổng I/O 1 điều khiển đèn đỏ
        //    ioController.SetPinHigh(2); // Cổng I/O 2 điều khiển còi

        //    // Chờ một khoảng thời gian để cảnh báo
        //    Task.Delay(5000).Wait(); // Cảnh báo trong 5 giây

        //    // Tắt đèn và còi sau cảnh báo
        //    ioController.SetPinLow(1); // Tắt đèn đỏ
        //    ioController.SetPinLow(2); // Tắt còi báo động
        //}


        private void SetupListView()
        {
            listViewQRcode.View = View.Details;
            listViewQRcode.FullRowSelect = true;

            // Thêm các cột vào ListView
            listViewQRcode.Columns.Add("Code", 230); // Cột hiển thị mã barcode
            listViewQRcode.Columns.Add("Status", 100);
            listViewQRcode.Columns.Add("Thời gian", 150);

        }
        private void AddBarcodeToListView(string barcode, string status, string time)
        {
            // Tạo một item mới cho ListView
            var listViewItem = new ListViewItem(barcode);
            listViewItem.SubItems.Add(status); // Thêm trạng thái vào cột thứ 2
            listViewItem.SubItems.Add(time);

            // Thêm item vào vị trí đầu tiên của ListView
            listViewQRcode.Items.Insert(0, listViewItem);
        }
        private int totalDuplicate = 0;
        private int totalWrongType = 0;
        private int totalOK = 0;
        private void btnScan_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                string scannedCode = GetBarcodeFromScanner();
                btnQrcode.Text = scannedCode;

                // Lấy loại sản phẩm từ cơ sở dữ liệu
                var settings = db.Settings.FirstOrDefault();
                if (settings == null)
                {
                    MessageBox.Show("Chưa cài đặt loại sản phẩm.");
                    return;
                }

                // Kiểm tra nếu mã thiếu ký tự
                if (scannedCode.Length < 8)
                {
                    MessageBox.Show("Mã không hợp lệ, thiếu ký tự.");
                    return;
                }

                // Lấy 4 ký tự đầu để kiểm tra loại sản phẩm
                var productType = scannedCode.Substring(0, 4);
                var isWrongType = productType != settings.ProductType;

                // Kiểm tra trùng mã (4 ký tự cuối)
                var codeEnd = scannedCode.Substring(scannedCode.Length - 4);
                var isDuplicate = db.CodeEntries.Any(c => c.Code.EndsWith(codeEnd));

                // Lưu kết quả vào database, liên kết với Setting thông qua SettingId
                var entry = new CodeEntry
                {
                    Code = scannedCode,
                    ScanTime = DateTime.Now,
                    IsDuplicate = isDuplicate,
                    IsWrongType = isWrongType,
                    ProductType = settings.ProductType
                };
                db.CodeEntries.Add(entry);
                db.SaveChanges();

                // Kết nối với hệ thống cảnh báo (giả lập)
                // if (isDuplicate || isWrongType)
                // {
                //     TriggerWarning();
                // }

                // Xác định chuỗi trạng thái để hiển thị
                string statusMessage;
                string status;
                if (isDuplicate)
                {
                    statusMessage = "Mã trùng lặp";
                    status = "NG";
                    totalDuplicate++;
                }
                else if (isWrongType)
                {
                    statusMessage = "Sai loại sản phẩm";
                    status = "NG";
                    totalWrongType++;
                }
                else
                {
                    status = "OK";
                    statusMessage = "OK";
                    totalOK++;
                }

                // Hiển thị kết quả kiểm tra và tạo mã vạch với trạng thái chi tiết
                GenerateQRCode(scannedCode, statusMessage, status);
                AddBarcodeToListView(scannedCode, statusMessage, DateTime.Now.ToString());
                UpdateStatusLabels();
            }
        }


        private void UpdateStatusLabels()
        {
            // Giả sử bạn có các label lbTotalOK và lbTotalNG để hiển thị số lượng
            btnDuplicate.Text = $"{totalDuplicate}";
            btnWrongType.Text = $"{totalWrongType}";
            btnOK.Text = $"{totalOK}";
            btnTotall.Text = $"{totalOK + totalDuplicate + totalWrongType}";
        }

        public void GenerateQRCode(string text, string statusMessage,string status)
        {
            // Tạo nội dung cho mã QR, bao gồm cả trạng thái chi tiết
            string qrContent = $"{text}-{statusMessage}";

            // Sử dụng thư viện QRCoder để tạo mã QR
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrContent, QRCodeGenerator.ECCLevel.Q);
                using (QRCode qrCode = new QRCode(qrCodeData))
                {
                    using (Bitmap qrCodeImage = qrCode.GetGraphic(20))
                    {
                        // Tạo một Bitmap để vẽ cả QR và trạng thái
                        int width = qrCodeImage.Width;
                        int height = qrCodeImage.Height + 80; // Thêm 40 pixel cho phần hiển thị trạng thái
                        Bitmap combinedImage = new Bitmap(width, height);

                        // Vẽ mã QR và trạng thái lên hình ảnh
                        using (Graphics g = Graphics.FromImage(combinedImage))
                        {
                            // Vẽ mã QR lên
                            g.DrawImage(qrCodeImage, new Point(0, 0));

                            // Tạo font và brush để vẽ trạng thái
                            Font statusFont = new Font("Times New Roman", 32, FontStyle.Bold);
                            lblResultVisionCheck.Text = status;
                            // Thay đổi màu của Label dựa trên trạng thái
                            if (status == "OK")
                            {
                                lblResultVisionCheck.ForeColor = Color.Green;
                            }
                            else if (status == "NG")
                            {
                                lblResultVisionCheck.ForeColor = Color.Red;
                            }
                            else
                            {
                                lblResultVisionCheck.ForeColor = Color.Black; // Màu mặc định
                            }
                            //// Đo kích thước của chữ trạng thái
                            //SizeF stringSize = g.MeasureString(statusMessage, statusFont);

                            //// Tính toán vị trí x để căn giữa trạng thái theo chiều ngang
                            //float xPosition = (width - stringSize.Width) / 2;
                            //float yPosition = qrCodeImage.Height + 10; // Vị trí y dưới mã QR

                            //// Vẽ trạng thái dưới mã QR và căn giữa theo chiều ngang
                            //g.DrawString(statusMessage, statusFont, statusBrush, new PointF(xPosition, yPosition));`  
                        }

                        // Hiển thị hình ảnh đã kết hợp lên PictureBox
                        pictureBoxBarcode.Image?.Dispose(); // Giải phóng hình ảnh cũ
                        pictureBoxBarcode.Image = new Bitmap(combinedImage);

                        // Tùy chọn: Lưu hình ảnh thành file
                        // combinedImage.Save($"qrcode_{statusMessage}.png");
                    }
                }
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void History_Click(object sender, EventArgs e)
        {

            HistoryScan historyForm = new HistoryScan();
            historyForm.ShowDialog();
        }

        private void User_Click(object sender, EventArgs e)
        {
            AccountForm accountForm = new AccountForm(_loggedInAccount);
            accountForm.ShowDialog();
        }
    }
}
