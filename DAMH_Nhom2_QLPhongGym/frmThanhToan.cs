using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DAMH_Nhom2_QLPhongGym
{
    public partial class frmThanhToan : Form
    {
        // Cung cấp chuỗi kết nối khi khởi tạo QLPhongGymDataContext
        QLPhongGymDataContext ql = new QLPhongGymDataContext();
        
        public frmThanhToan(int nhanVienID)
        {
            InitializeComponent();
            txtIDNhanVien.Text = nhanVienID.ToString();
        }

    

        private void btnKiemTraID_Click(object sender, EventArgs e)
        {
            if (txtIDKhachHang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id khách hàng!");
                return;
            }
            // Lấy giá trị ID khách hàng từ textbox
            int customerId = int.Parse(txtIDKhachHang.Text);

            // Kiểm tra ID khách hàng trong database
            var existingCustomer = ql.TheKhachHangs.FirstOrDefault(kh => kh.TheKhachHangID == customerId);

            if (existingCustomer != null)
            {
                // Nếu tìm thấy khách hàng có ID này, hiển thị thông tin chi tiết
                string customerInfo = $"Họ tên: {existingCustomer.HoTen}\n" +
                                      $"Ngày sinh: {existingCustomer.NgaySinh}\n" +
                                      $"CCCD: {existingCustomer.CCCD}\n" +
                                      $"Giới tính: {existingCustomer.GioiTinh}\n" +
                                      $"Số điện thoại: {existingCustomer.SoDienThoai}\n" +
                                      $"Địa chỉ: {existingCustomer.DiaChi}\n" +
                                      $"Loại thành viên: {existingCustomer.LoaiThanhVien}\n" +
                                      $"Thời gian hiệu lực: {existingCustomer.ThoiGianHieuLuc}\n" +
                                      $"Số buổi tập cùng PT: {existingCustomer.SoBuoiTapCungPT}";

                // Hiển thị thông tin chi tiết trong MessageBox
                MessageBox.Show(customerInfo, "Thông tin khách hàng");
            }
            else
            {
                // Nếu không tìm thấy
                MessageBox.Show("ID khách hàng hợp lệ!");
            }
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
         
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void rdo3Buoi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdo8Buoi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdo6Buoi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdo2Buoi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdo1Buoi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtLoaiHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtIDNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rdo6Thang_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdo24Thang_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdo12Thang_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdo3Thang_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdo1Thang_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                int? idGoiTap = null; // Sử dụng kiểu `int?` để có thể gán `NULL`
                int? idGoiThuePT = null; // Sử dụng kiểu `int?` để có thể gán `NULL`
                decimal tongTien = 0;

                // Xác định gói tập dựa trên radio button được chọn
                if (rdo_1Thang.Checked)
                {
                    idGoiTap = 1;
                }
                else if (rdo_3Thang.Checked)
                {
                    idGoiTap = 2;
                }
                else if (rdo_6Thang.Checked)
                {
                    idGoiTap = 3;
                }
                else if (rdo_12Thang.Checked)
                {
                    idGoiTap = 4;
                }
                else if (rdo_24Thang.Checked)
                {
                    idGoiTap = 5;
                }

                // Xác định gói thuê PT dựa trên radio button được chọn
                if (rdo1Buoi.Checked)
                {
                    idGoiThuePT = 1;
                }
                else if (rdo2Buoi.Checked)
                {
                    idGoiThuePT = 2;
                }
                else if (rdo3Buoi.Checked)
                {
                    idGoiThuePT = 3;
                }
                else if (rdo6Buoi.Checked)
                {
                    idGoiThuePT = 4;
                }
                else if (rdo8Buoi.Checked)
                {
                    idGoiThuePT = 5;
                }

                // Lấy thông tin gói tập và gói thuê PT từ database
                var selectedGoiTap = ql.GoiTaps.FirstOrDefault(gt => gt.GoiTapID == idGoiTap);
                var selectedGoiThuePT = ql.ThuePTs.FirstOrDefault(gt => gt.GoiThuePTID == idGoiThuePT);

                if (selectedGoiTap != null || selectedGoiThuePT != null)
                {
                    // Tính tổng tiền của gói tập và gói thuê PT
                    decimal tongTienGoiTap = selectedGoiTap?.GiaTien ?? 0; // Nếu `GiaTien` là null, gán `0`
                    decimal tongTienGoiThuePT = selectedGoiThuePT?.GiaTien ?? 0; // Tương tự cho gói thuê PT

                    tongTien = tongTienGoiTap + tongTienGoiThuePT;

                    // Tạo một bản ghi hóa đơn mới
                    HoaDon newHoaDon = new HoaDon
                    {
                        TheKhachHangID = int.Parse(txtIDKhachHang.Text),
                        NhanVienID = int.Parse(txtIDNhanVien.Text), // Giả định có một textbox cho ID nhân viên
                        NgayThanhToan = DateTime.Now,
                        LoaiHoaDon = txtLoaiHoaDon.Text,
                        GoiTapID = idGoiTap,
                        GoiThuePTID = idGoiThuePT,
                        TongTien = tongTien
                    };

                    // Thêm hóa đơn vào cơ sở dữ liệu
                    ql.HoaDons.InsertOnSubmit(newHoaDon);
                    ql.SubmitChanges();

                    // Hiển thị thông báo thành công và cập nhật tổng tiền trong textbox
                    txtThanhTien.Text = tongTien.ToString("N0") + " đồng"; // Định dạng tiền tệ
                    MessageBox.Show("Hóa đơn đã được tạo thành công!\n" + "Tong tien:" + txt_ThanhTien.Text, "Thông báo");
                    txt_ThanhTien.Text = "";
                    txtIDKhachHang.Text = "";
                    // Đặt lại các radio button trong group box
                    rdo_1Thang.Checked = false;
                    rdo_3Thang.Checked = false;
                    rdo_6Thang.Checked = false;
                    rdo_12Thang.Checked = false;
                    rdo_24Thang.Checked = false;

                    rdo1Buoi.Checked = false;
                    rdo2Buoi.Checked = false;
                    rdo3Buoi.Checked = false;
                    rdo6Buoi.Checked = false;
                    rdo8Buoi.Checked = false;

                }
                else
                {
                    MessageBox.Show("Không tìm thấy gói tập hoặc gói thuê PT phù hợp!", "Lỗi");
                    txt_ThanhTien.Text = tongTien.ToString("N0") + " đồng";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng cho ID khách hàng và ID nhân viên.", "Lỗi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi");
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            int idGoiTap = 0;
            int idGoiThuePT = 0;
            decimal tongTien = 0;
            // Xác định gói tập dựa trên radio button được chọn
            if (rdo_1Thang.Checked)
            {
                idGoiTap = 5;
            }
            else if (rdo_3Thang.Checked)
            {
                idGoiTap = 1;
            }
            else if (rdo_6Thang.Checked)
            {
                idGoiTap = 2;
            }
            else if (rdo_12Thang.Checked)
            {
                idGoiTap = 3;
            }
            else if (rdo_24Thang.Checked)
            {
                idGoiTap = 4;
            }

            // Xác định gói thuê PT dựa trên radio button được chọn
            if (rdo1Buoi.Checked)
            {
                idGoiThuePT = 5;
            }
            else if (rdo2Buoi.Checked)
            {
                idGoiThuePT = 1;
            }
            else if (rdo3Buoi.Checked)
            {
                idGoiThuePT = 2;
            }
            else if (rdo6Buoi.Checked)
            {
                idGoiThuePT = 3;
            }
            else if (rdo8Buoi.Checked)
            {
                idGoiThuePT = 4;
            }

            // Lấy thông tin gói tập từ database
            var selectedGoiTap = ql.GoiTaps.FirstOrDefault(gt => gt.GoiTapID == idGoiTap);
            var selectedGoiThuePT = ql.ThuePTs.FirstOrDefault(gt => gt.GoiThuePTID == idGoiThuePT);

            if (selectedGoiTap != null || selectedGoiThuePT != null)
            {
                // Tính tổng tiền của gói tập và gói thuê PT
                decimal tongTienGoiTap = selectedGoiTap?.GiaTien ?? 0; // Nếu `GiaTien` là null, gán `0`
                decimal tongTienGoiThuePT = selectedGoiThuePT?.GiaTien ?? 0; // Tương tự cho gói thuê PT

                tongTien = tongTienGoiTap + tongTienGoiThuePT;

                // Hiển thị tổng tiền trong TextBox với định dạng tiền tệ
                txt_ThanhTien.Text = tongTien.ToString("") + " đồng";
            }
            else
            {
                txt_ThanhTien.Text = tongTien.ToString("") + " đồng";
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            txt_ThanhTien.Text = "";
            txtIDKhachHang.Text = "";
            // Đặt lại các radio button trong group box
            rdo_1Thang.Checked = false;
            rdo_3Thang.Checked = false;
            rdo_6Thang.Checked = false;
            rdo_12Thang.Checked = false;
            rdo_24Thang.Checked = false;

            rdo1Buoi.Checked = false;
            rdo2Buoi.Checked = false;
            rdo3Buoi.Checked = false;
            rdo6Buoi.Checked = false;
            rdo8Buoi.Checked = false;
        }

        private void btnThemThanhVien_Click(object sender, EventArgs e)
        {
            // Tạo một instance của form frmQuanLyKhachHang
            frmQuanLyKhachHang formQuanLyKhachHang = new frmQuanLyKhachHang();

            // Hiển thị form frmQuanLyKhachHang dưới dạng không phải cửa sổ chính (con của frmThanhToan)
            formQuanLyKhachHang.TopLevel = false;
            formQuanLyKhachHang.FormBorderStyle = FormBorderStyle.None;
            formQuanLyKhachHang.Dock = DockStyle.Fill;

            // Xóa các control hiện tại và thêm form mới vào container (nếu cần)
            this.Controls.Clear();
            this.Controls.Add(formQuanLyKhachHang);
            formQuanLyKhachHang.Show();
        }
    }
}
