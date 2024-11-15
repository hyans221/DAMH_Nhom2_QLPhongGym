﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DAMH_Nhom2_QLPhongGym
{
    public partial class frmThemThanhVien : Form
    {
        // Cung cấp chuỗi kết nối khi khởi tạo QLPhongGymDataContext
        QLPhongGymDataContext ql = new QLPhongGymDataContext();
        
        public frmThemThanhVien()
        {
            InitializeComponent();
        }

    

        private void btnKiemTraID_Click(object sender, EventArgs e)
        {
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
            int idGoiTap = 0;
            int idGoiThuePT = 0;
            decimal tongTien=0;
            // Xác định gói tập dựa trên radio button được chọn
            if (rdo1Thang.Checked)
            {
                idGoiTap = 1;
            }
            else if (rdo3Thang.Checked)
            {
                idGoiTap = 2;
            }
            else if (rdo6Thang.Checked)
            {
                idGoiTap = 3;
            }
            else if (rdo12Thang.Checked)
            {
                idGoiTap = 4;
            }
            else if (rdo24Thang.Checked)
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

            // Lấy thông tin gói tập từ database
            var selectedGoiTap = ql.GoiTaps.FirstOrDefault(gt => gt.GoiTapID == idGoiTap);
            var selectedGoiThuePT = ql.ThuePTs.FirstOrDefault(gt => gt.GoiThuePTID == idGoiThuePT);

            if (selectedGoiTap != null || selectedGoiThuePT != null)
            {
                // Tính tổng tiền của gói tập và gói thuê PT
                decimal tongTienGoiTap = selectedGoiTap?.GiaTien ?? 0; // Nếu `GiaTien` là null, gán `0`
                decimal tongTienGoiThuePT = selectedGoiThuePT?.GiaTien ?? 0; // Tương tự cho gói thuê PT

                tongTien=tongTienGoiTap+tongTienGoiThuePT;

                // Hiển thị tổng tiền trong TextBox với định dạng tiền tệ
                txtThanhTien.Text = tongTien.ToString("") + " đồng"; 
            }
            else
            {
                txtThanhTien.Text = tongTien.ToString("") + " đồng";
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                int idGoiTap = 0;
                int idGoiThuePT = 0;
                decimal tongTien = 0;

                // Xác định gói tập dựa trên radio button được chọn
                if (rdo1Thang.Checked)
                {
                    idGoiTap = 1;
                }
                else if (rdo3Thang.Checked)
                {
                    idGoiTap = 2;
                }
                else if (rdo6Thang.Checked)
                {
                    idGoiTap = 3;
                }
                else if (rdo12Thang.Checked)
                {
                    idGoiTap = 4;
                }
                else if (rdo24Thang.Checked)
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
                    MessageBox.Show("Hóa đơn đã được tạo thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy gói tập hoặc gói thuê PT phù hợp!", "Lỗi");
                    txtThanhTien.Text = tongTien.ToString("N0") + " đồng";
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

    }
}
