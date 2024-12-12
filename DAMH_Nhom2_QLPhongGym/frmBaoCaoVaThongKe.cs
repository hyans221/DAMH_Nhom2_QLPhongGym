using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Rectangle = System.Drawing.Rectangle;


namespace DAMH_Nhom2_QLPhongGym
{
    public partial class frmBaoCaoVaThongKe : Form
    {
        private Dictionary<Control, Rectangle> originalSizes = new Dictionary<Control, Rectangle>();
        private Size originalFormSize;
        public frmBaoCaoVaThongKe()
        {
            InitializeComponent();
            LoadLoaiThanhVienIntoComboBox();
            LoadServicePackages();
            SaveOriginalSizes();
            this.Resize += FrmBaoCaoVaThongKe_Resize;
        }

        private void FrmBaoCaoVaThongKe_Resize(object sender, EventArgs e)
        {
            float xRatio = (float)this.Width / originalFormSize.Width;
            float yRatio = (float)this.Height / originalFormSize.Height;

            foreach (var item in originalSizes)
            {
                Control control = item.Key;
                Rectangle originalRect = item.Value;

                // Tính toán vị trí và kích thước mới
                int newX = (int)(originalRect.X * xRatio);
                int newY = (int)(originalRect.Y * yRatio);
                int newWidth = (int)(originalRect.Width * xRatio);
                int newHeight = (int)(originalRect.Height * yRatio);

                // Áp dụng thay đổi
                control.Location = new Point(newX, newY);
                control.Size = new Size(newWidth, newHeight);
            }
        }

        private void SaveOriginalSizes()
        {
            originalFormSize = this.Size;

            foreach (Control control in this.Controls)
            {
                SaveControlSizes(control);
            }
        }

        private void SaveControlSizes(Control control)
        {
            originalSizes[control] = new Rectangle(control.Location, control.Size);

            // Lưu kích thước của các control con
            foreach (Control childControl in control.Controls)
            {
                SaveControlSizes(childControl);
            }
        }
        private void btnGeneratePackageReport_Click(object sender, EventArgs e)
        {
            using (var context = new QLPhongGymDataContext())
            {
                var packageData = context.GoiTaps
                    .Select(g => new
                    {
                        g.GoiTapID,
                        g.ThoiGian,
                        g.GiaTien,
                        g.Mota
                    }).ToList();

                // Hiển thị dữ liệu lên DataGridView
                dgvServicePackageDetails.DataSource = packageData;

                // Cấu hình cho biểu đồ
                chartServicePackages.Series.Clear(); // Xóa các series cũ (nếu có)

                // Tạo Series cho biểu đồ
                var series = new System.Windows.Forms.DataVisualization.Charting.Series
                {
                    Name = "Gói Tập",
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column // Chọn loại biểu đồ cột
                };

                // Thêm dữ liệu vào series
                foreach (var item in packageData)
                {
                    series.Points.AddXY(item.ThoiGian, item.GiaTien); // Trục X là Thời Gian, Y là Giá Tiền
                }

                // Thêm series vào biểu đồ
                chartServicePackages.Series.Add(series);

                // Làm mới biểu đồ
                chartServicePackages.Refresh();
            }
        }
        private void LoadServicePackages()
        {
            using (var context = new QLPhongGymDataContext())
            {
               
                var servicePackages = context.GoiTaps
                    .Select(g => new
                    {
                        g.GoiTapID,
                        g.Mota
                    })
                    .ToList();

                cbRevenueServicePackage.DisplayMember = "Mota"; 
                cbRevenueServicePackage.ValueMember = "GoiTapID"; 
                cbRevenueServicePackage.DataSource = servicePackages;
            }
        }
        private void btnGenerateRevenueReport_Click(object sender, EventArgs e)
        {
            using (var context = new QLPhongGymDataContext())
            {
                DateTime startDate = dtpTimeFrameRevenueStart.Value;
                DateTime endDate = dtpTimeFrameRevenueEnd.Value;
                int? servicePackageId = (int?)cbRevenueServicePackage.SelectedValue;

                var revenueData = context.HoaDons
                    .Where(h => h.NgayThanhToan >= startDate && h.NgayThanhToan <= endDate)
                    .Where(h => servicePackageId == null || h.GoiTapID == servicePackageId)
                    .Select(h => new
                    {
                        h.HoaDonID,
                        h.NgayThanhToan,
                        h.TongTien,
                        PackageDescription = h.GoiTap.Mota 
                    }).ToList();

                dgvRevenueDetails.DataSource = revenueData;


                chartRevenue.Series["Series1"].XValueMember = "NgayThanhToan"; 
                chartRevenue.Series["Series1"].YValueMembers = "TongTien"; 

               
                chartRevenue.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM/yyyy"; 
                chartRevenue.Series["Series1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;

                chartRevenue.DataSource = revenueData;
                chartRevenue.Refresh();
            }
        }

        
        private void LoadLoaiThanhVienIntoComboBox()
        {
            using (var context = new QLPhongGymDataContext())
            {
       
                var loaiThanhVienList = context.TheKhachHangs
                    .Select(c => c.LoaiThanhVien)
                    .Distinct()  
                    .ToList();      
                cbStatus.Items.Clear();         
                cbStatus.Items.Add("Tất cả");
                cbStatus.Items.AddRange(loaiThanhVienList.ToArray());
                cbStatus.SelectedIndex = 0;
            }
        }

        private void btnGenerateCustomerReport_Click(object sender, EventArgs e)
        {
            using (var context = new QLPhongGymDataContext())
            {
                DateTime startDate = dtpTimeFrameStart.Value;
                DateTime endDate = dtpTimeFrameEnd.Value;
                string status = cbStatus.SelectedItem?.ToString();

                var customerData = context.TheKhachHangs
                    .Where(c => c.ThoiGianHieuLuc >= startDate && c.ThoiGianHieuLuc <= endDate)
                    .Where(c => string.IsNullOrEmpty(status) || status == "Tất cả" || c.LoaiThanhVien == status)
                    .Select(c => new
                    {
                        c.TheKhachHangID,
                        c.HoTen,
                        c.GioiTinh,
                        c.SoDienThoai,
                        c.LoaiThanhVien,
                        c.ThoiGianHieuLuc
                    }).ToList();

                dgvCustomerStatistics.DataSource = customerData;

             
                chartCustomerStatistics.Series.Clear(); 

                var series = new System.Windows.Forms.DataVisualization.Charting.Series
                {
                    Name = "Khách Hàng",
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column 
                };

                foreach (var customer in customerData)
                {
                    series.Points.AddXY(customer.HoTen, customer.ThoiGianHieuLuc);  
                }

                chartCustomerStatistics.Series.Add(series);
                chartCustomerStatistics.Refresh();
            }
        }
       
        private void ExportDataToExcel(DataGridView dgv)
        {
            try
            {
                var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add("Report");

                // Khởi tạo vị trí bắt đầu
                int startRow = 1;

                for (int row = 0; row < dgv.Rows.Count; row++)
                {
                    // Duyệt qua từng cột (tiêu đề và dữ liệu) trong dòng hiện tại
                    for (int col = 0; col < dgv.Columns.Count; col++)
                    {
                        // Lấy tiêu đề (header) của cột
                        var headerText = dgv.Columns[col].HeaderText;

                        // Lấy dữ liệu tương ứng từ dòng hiện tại
                        var cellValue = dgv.Rows[row].Cells[col].Value?.ToString() ?? string.Empty;

                        // Thêm tiêu đề vào cột 1
                        worksheet.Cell(startRow + col, 1).Value = headerText;
                        worksheet.Cell(startRow + col, 1).Style.Font.Bold = true;
                        worksheet.Cell(startRow + col, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

                        // Thêm dữ liệu vào cột 2
                        worksheet.Cell(startRow + col, 2).Value = cellValue;
                        worksheet.Cell(startRow + col, 2).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
                    }

                    // Sau khi thêm xong bảng cho dòng hiện tại, cách dòng tiếp theo 2 dòng
                    startRow += dgv.Columns.Count + 2;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    Title = "Save Excel File"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xuất file thất bại!\nLỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ExportDataToPDF(DataGridView dgv)
        {
            try
            {
                // Tạo hộp thoại để lưu file PDF
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.Title = "Save PDF File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Tạo một file stream để ghi dữ liệu vào file PDF
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                    {
                        // Tạo PdfDocument
                        Document document = new Document(PageSize.A4, 50, 50, 25, 25);
                        PdfWriter writer = PdfWriter.GetInstance(document, fs);

                        document.Open();

                        for (int row = 0; row < dgv.Rows.Count; row++)
                        {
                            // Tạo bảng cho dòng hiện tại
                            PdfPTable table = new PdfPTable(2) { WidthPercentage = 100 };

                            // Duyệt qua từng cột trong dòng hiện tại
                            for (int col = 0; col < dgv.Columns.Count; col++)
                            {
                                // Lấy tiêu đề (header) của cột
                                var headerText = dgv.Columns[col].HeaderText;

                                // Lấy dữ liệu tương ứng từ dòng hiện tại
                                var cellValue = dgv.Rows[row].Cells[col].Value?.ToString() ?? string.Empty;

                                // Thêm tiêu đề vào cột 
                                PdfPCell headerCell = new PdfPCell(new Phrase(headerText))
                                {
                                    BackgroundColor = BaseColor.LIGHT_GRAY,
                                    HorizontalAlignment = Element.ALIGN_LEFT,
                                    VerticalAlignment = Element.ALIGN_MIDDLE,
                                    MinimumHeight = 20f
                                };
                                table.AddCell(headerCell);

                                // Thêm dữ liệu vào cột 
                                PdfPCell dataCell = new PdfPCell(new Phrase(cellValue))
                                {
                                    HorizontalAlignment = Element.ALIGN_LEFT,
                                    VerticalAlignment = Element.ALIGN_MIDDLE,
                                    MinimumHeight = 20f
                                };
                                table.AddCell(dataCell);
                            }

                            document.Add(table);

                            // Thêm khoảng cách giữa các bảng (2 dòng)
                            document.Add(new Paragraph("\n"));
                        }

                        document.Close();
                    }
                    MessageBox.Show("Dữ liệu đã được xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xuất file thất bại!\nLỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportRevenueExcel_Click(object sender, EventArgs e)
        {
            ExportDataToExcel(dgvRevenueDetails);
        }

        private void btnExportRevenuePDF_Click(object sender, EventArgs e)
        {
            ExportDataToPDF(dgvRevenueDetails);
        }

        private void btnExportCustomerPDF_Click(object sender, EventArgs e)
        {
            ExportDataToPDF(dgvCustomerStatistics);
        }

        private void btnExportCustomerExcel_Click(object sender, EventArgs e)
        {
            ExportDataToExcel(dgvCustomerStatistics);
        }

        private void btnExportPackagePDF_Click(object sender, EventArgs e)
        {
            ExportDataToPDF(dgvServicePackageDetails);
        }

        private void btnExportPackageExcel_Click(object sender, EventArgs e)
        {
            ExportDataToExcel(dgvServicePackageDetails);
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
