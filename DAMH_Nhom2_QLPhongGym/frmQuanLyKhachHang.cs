using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAMH_Nhom2_QLPhongGym
{
    public partial class frmQuanLyKhachHang : Form
    {
        QLPhongGymDataContext qlpg = new QLPhongGymDataContext();
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void Load_KhachHangs()
        {
            var khachhang = from kh in qlpg.TheKhachHangs
                            select kh;
            dgvKhachHang.DataSource = khachhang;
        }
        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            Load_KhachHangs();
            cboLoaiThanhVien.Items.Add("Classic"); 
            cboLoaiThanhVien.Items.Add("Royal"); 

            cboLoaiThanhVien.SelectedIndex = 0;
        }

        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow != null)
            {
                var select = dgvKhachHang.CurrentRow.DataBoundItem as TheKhachHang;
                if (select != null)
                {
                    txtMaKH.Text = select.TheKhachHangID.ToString();
                    txtTenKH.Text = select.HoTen;
                    dtNgaySinh.Value = select.NgaySinh ?? DateTime.Now;
                    txtCCCD.Text = select.CCCD;
                    txtSDT.Text = select.SoDienThoai;
                    txtDiaChi.Text = select.DiaChi;
                    cboLoaiThanhVien.SelectedItem = select.LoaiThanhVien;
                    txtSoBuoiTap.Text = select.SoBuoiTapCungPT.ToString();

                    if (select.GioiTinh == "Nam")
                    {
                        rdbNam.Checked = true;
                    }
                    else
                    {
                        rdbNu.Checked = true;
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra họ tên (chỉ chứa chữ cái và khoảng trắng)
                if (string.IsNullOrEmpty(txtTenKH.Text))
                {
                    MessageBox.Show("Vui lòng nhập họ tên khách hàng.");
                    txtTenKH.Focus();
                    txtTenKH.ForeColor = Color.Red;
                    return;
                }
                if (!txtTenKH.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("Họ tên không hợp lệ. Vui lòng chỉ nhập chữ cái và khoảng trắng.");
                    txtTenKH.Focus();
                    txtTenKH.ForeColor = Color.Red;
                    return;

                }
                else { txtTenKH.ForeColor = SystemColors.ControlText; }


                // Kiểm tra số điện thoại (10 số)
                if (string.IsNullOrEmpty(txtSDT.Text))
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại.");
                    txtSDT.Focus();
                    txtSDT.ForeColor = Color.Red;
                    return;
                }
                if (txtSDT.Text.Length != 10 || !txtSDT.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập 10 số.");
                    txtSDT.Focus();
                    txtSDT.ForeColor = Color.Red;
                    return;
                }
                else { txtSDT.ForeColor = SystemColors.ControlText; }



                // Kiểm tra địa chỉ
                if (string.IsNullOrEmpty(txtDiaChi.Text))
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ.");
                    txtDiaChi.Focus();
                    txtDiaChi.ForeColor = Color.Red;
                    return;
                }
                else { txtDiaChi.ForeColor = SystemColors.ControlText; }



                // Kiểm tra CCCD (chỉ chứa số và đủ 12 số)
                if (string.IsNullOrEmpty(txtCCCD.Text) || !txtCCCD.Text.All(char.IsDigit) || txtCCCD.Text.Length != 12)
                {
                    MessageBox.Show("CCCD không hợp lệ. Vui lòng nhập 12 số.");
                    txtCCCD.Focus();
                    txtCCCD.ForeColor = Color.Red;
                    return;
                }

                if (qlpg.TheKhachHangs.Any(t => t.CCCD == txtCCCD.Text))
                {
                    MessageBox.Show("Số CCCD đã tồn tại. Vui lòng nhập số CCCD khác.");
                    txtCCCD.Focus();
                    txtCCCD.ForeColor = Color.Red;
                    return;
                }
                else
                {
                    txtCCCD.ForeColor = SystemColors.ControlText;
                }


                // Kiểm tra ngày sinh (đủ 18 tuổi và không phải ngày hiện tại)
                if (dtNgaySinh.Value.Date >= DateTime.Now.Date || DateTime.Now.Year - dtNgaySinh.Value.Year < 18)
                {
                    MessageBox.Show("Ngày sinh không hợp lệ.");
                    dtNgaySinh.Focus();
                    dtNgaySinh.ForeColor = Color.Red;
                    return;
                }
                else { dtNgaySinh.ForeColor = SystemColors.ControlText; }

                if (string.IsNullOrEmpty(txtSoBuoiTap.Text))
                {
                    MessageBox.Show("Vui lòng nhập số buổi tập.");
                    txtSoBuoiTap.Focus();
                    txtSoBuoiTap.ForeColor = Color.Red;
                    return;
                }

                if (!int.TryParse(txtSoBuoiTap.Text, out int soBuoiTap) || soBuoiTap < 0 || soBuoiTap > 100)
                {
                    MessageBox.Show("Số buổi tập không hợp lệ.");
                    txtSoBuoiTap.Focus();
                    txtSoBuoiTap.ForeColor = Color.Red;
                    return;
                }
                else { txtSoBuoiTap.ForeColor = SystemColors.ControlText; }

                TheKhachHang kh = new TheKhachHang();
                kh.HoTen = txtTenKH.Text;
                kh.NgaySinh = dtNgaySinh.Value;
                kh.CCCD = txtCCCD.Text;
                kh.SoDienThoai = txtSDT.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.LoaiThanhVien = cboLoaiThanhVien.SelectedItem.ToString();
                kh.ThoiGianHieuLuc = DateTime.Now;
                kh.GioiTinh = rdbNam.Checked ? "Nam" : "Nữ";
                kh.SoBuoiTapCungPT = Convert.ToInt32(txtSoBuoiTap.Text);
                qlpg.TheKhachHangs.InsertOnSubmit(kh);

                qlpg.SubmitChanges();

                Load_KhachHangs();
                MessageBox.Show("Đã thêm thành công!!!");
            }
            catch
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int makh = int.Parse(txtMaKH.Text);
                TheKhachHang kh = qlpg.TheKhachHangs.Where(t => t.TheKhachHangID == makh).FirstOrDefault();
                qlpg.TheKhachHangs.DeleteOnSubmit(kh);

                qlpg.SubmitChanges();

                Load_KhachHangs();
                MessageBox.Show("Xoá thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi khi xoá dữ liệu");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaKH.Text) || !int.TryParse(txtMaKH.Text, out int makh))
                {
                    MessageBox.Show("Mã khách hàng không hợp lệ.");
                    return;
                }


                TheKhachHang kh = qlpg.TheKhachHangs.FirstOrDefault(t => t.TheKhachHangID == makh);
                if (kh == null)
                {
                    MessageBox.Show("Không tìm thấy khách hàng có mã này.");
                    return;
                }

                // Kiểm tra họ tên (chỉ chứa chữ cái và khoảng trắng)
                if (string.IsNullOrEmpty(txtTenKH.Text))
                {
                    MessageBox.Show("Vui lòng nhập họ tên khách hàng.");
                    txtTenKH.Focus();
                    txtTenKH.ForeColor = Color.Red;
                    return;
                }
                if (!txtTenKH.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("Họ tên không hợp lệ. Vui lòng chỉ nhập chữ cái và khoảng trắng.");
                    txtTenKH.Focus();
                    txtTenKH.ForeColor = Color.Red;
                    return;
                }
                else { txtTenKH.ForeColor = SystemColors.ControlText; }

                // Kiểm tra số điện thoại (10 số)
                if (string.IsNullOrEmpty(txtSDT.Text))
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại.");
                    txtSDT.Focus();
                    txtSDT.ForeColor = Color.Red;
                    return;
                }
                if (txtSDT.Text.Length != 10 || !txtSDT.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập 10 số.");
                    txtSDT.Focus();
                    txtSDT.ForeColor = Color.Red;
                    return;
                }
                else { txtSDT.ForeColor = SystemColors.ControlText; }

                // Kiểm tra địa chỉ
                if (string.IsNullOrEmpty(txtDiaChi.Text))
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ.");
                    txtDiaChi.Focus();
                    txtDiaChi.ForeColor = Color.Red;
                    return;
                }
                else { txtDiaChi.ForeColor = SystemColors.ControlText; }

                // Kiểm tra CCCD (chỉ chứa số và đủ 12 số)
                if (string.IsNullOrEmpty(txtCCCD.Text) || !txtCCCD.Text.All(char.IsDigit) || txtCCCD.Text.Length != 12)
                {
                    MessageBox.Show("CCCD không hợp lệ. Vui lòng nhập 12 số.");
                    txtCCCD.Focus();
                    txtCCCD.ForeColor = Color.Red;
                    return;
                }


                if (qlpg.TheKhachHangs.Any(t => t.CCCD == txtCCCD.Text && t.TheKhachHangID != makh)) // Kiểm tra trùng CCCD, bỏ qua chính khách hàng đang sửa
                {
                    MessageBox.Show("Số CCCD đã tồn tại. Vui lòng nhập số CCCD khác.");
                    txtCCCD.Focus();
                    txtCCCD.ForeColor = Color.Red;
                    return;

                }
                else
                {
                    txtCCCD.ForeColor = SystemColors.ControlText;
                }

                // Kiểm tra ngày sinh (đủ 18 tuổi và không phải ngày hiện tại)
                if (dtNgaySinh.Value.Date >= DateTime.Now.Date || DateTime.Now.Year - dtNgaySinh.Value.Year < 18)
                {
                    MessageBox.Show("Ngày sinh không hợp lệ.");
                    dtNgaySinh.Focus();
                    dtNgaySinh.ForeColor = Color.Red;
                    return;
                }
                else { dtNgaySinh.ForeColor = SystemColors.ControlText; }



                // Kiểm tra SoBuoiTap (chỉ chứa số, không âm, không quá 100)
                if (string.IsNullOrEmpty(txtSoBuoiTap.Text))
                {
                    MessageBox.Show("Vui lòng nhập số buổi tập.");
                    txtSoBuoiTap.Focus();
                    txtSoBuoiTap.ForeColor = Color.Red;
                    return;
                }

                if (!int.TryParse(txtSoBuoiTap.Text, out int soBuoiTap) || soBuoiTap < 0 || soBuoiTap > 100)
                {
                    MessageBox.Show("Số buổi tập không hợp lệ. Vui lòng nhập số nguyên từ 0 đến 100.");
                    txtSoBuoiTap.Focus();
                    txtSoBuoiTap.ForeColor = Color.Red;
                    return;

                }
                else { txtSoBuoiTap.ForeColor = SystemColors.ControlText; }

                // Cập nhật thông tin khách hàng
                kh.HoTen = txtTenKH.Text;
                kh.NgaySinh = dtNgaySinh.Value;
                kh.CCCD = txtCCCD.Text;
                kh.SoDienThoai = txtSDT.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.LoaiThanhVien = cboLoaiThanhVien.SelectedItem?.ToString() ?? "";
                kh.GioiTinh = rdbNam.Checked ? "Nam" : "Nữ";
                kh.SoBuoiTapCungPT = soBuoiTap;


                qlpg.SubmitChanges();
                Load_KhachHangs();
                MessageBox.Show("Đã cập nhật thông tin thành công!!!");

            }
            catch
            {
                MessageBox.Show("Lỗi khi sửa dữ liệu");
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtCCCD.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            dtNgaySinh.Value = DateTime.Now;
            cboLoaiThanhVien.SelectedIndex = 0;
            txtSoBuoiTap.Clear();
            rdbNam.Checked = true;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string timKiem = txtTimKiem.Text.Trim();

                if (string.IsNullOrEmpty(timKiem))
                {
                    var khang = from kh in qlpg.TheKhachHangs
                                    select kh;
                    dgvKhachHang.DataSource = khang.ToList();
                    return; 
                }

    
                var khachhang = from kh in qlpg.TheKhachHangs
                                where kh.HoTen.Contains(timKiem)
                                select kh;

                if (!khachhang.Any())
                {
            
                    if (int.TryParse(timKiem, out int maKH))
                    {
             
                        khachhang = from kh in qlpg.TheKhachHangs
                                    where kh.TheKhachHangID == maKH
                                    select kh;
                    }
                    else
                    {
             
                        khachhang = from kh in qlpg.TheKhachHangs
                                    where kh.CCCD == timKiem
                                    select kh;
                    }
                }

     
                dgvKhachHang.DataSource = khachhang.ToList();
            }
            catch
            {
                MessageBox.Show("Lỗi khi tìm kiếm.");
            }
        }
    }
}
