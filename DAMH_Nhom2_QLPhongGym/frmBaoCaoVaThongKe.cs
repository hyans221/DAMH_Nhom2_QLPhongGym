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

namespace DAMH_Nhom2_QLPhongGym
{
    public partial class frmBaoCaoVaThongKe : Form
    {
        public frmBaoCaoVaThongKe()
        {
            InitializeComponent();
            LoadLoaiThanhVienIntoComboBox();
            LoadServicePackages();
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
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Report");

            // Thêm tiêu đề cột vào worksheet
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                worksheet.Cell(1, i + 1).Value = dgv.Columns[i].HeaderText;
            }

            // Thêm dữ liệu từ DataGridView vào worksheet
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    worksheet.Cell(i + 2, j + 1).Value = dgv.Rows[i].Cells[j].Value?.ToString() ?? string.Empty;
                }
            }

            // Lưu file Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Save Excel File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName);
            }
        }
        private void ExportDataToPDF(DataGridView dgv)
        {
            // Tạo hộp thoại để lưu file PDF
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Save PDF File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Tạo một file stream để ghi dữ liệu vào file PDF
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                    {
                        // Tạo PdfDocument
                        Document document = new Document();
                        PdfWriter writer = PdfWriter.GetInstance(document, fs);

                        // Mở document để thêm nội dung
                        document.Open();

                        // Tạo bảng với số cột tương ứng với số cột trong DataGridView
                        PdfPTable table = new PdfPTable(dgv.Columns.Count);

                        // Thêm tiêu đề cột vào table PDF
                        foreach (DataGridViewColumn column in dgv.Columns)
                        {
                            table.AddCell(new Phrase(column.HeaderText));
                        }

                        // Thêm các dòng dữ liệu vào table PDF
                        foreach (DataGridViewRow row in dgv.Rows)
                        {
                            // Kiểm tra xem dòng có dữ liệu không
                            if (!row.IsNewRow)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    table.AddCell(new Phrase(cell.Value?.ToString() ?? string.Empty));
                                }
                            }
                        }

                        // Thêm bảng vào document
                        document.Add(table);

                        // Đóng document để lưu vào file PDF
                        document.Close();
                    }

                    MessageBox.Show("Dữ liệu đã được xuất thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi xuất PDF: {ex.Message}");
                }
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
    }
}
