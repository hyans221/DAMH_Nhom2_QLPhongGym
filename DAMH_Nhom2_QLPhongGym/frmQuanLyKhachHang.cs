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
                if (string.IsNullOrEmpty(txtTenKH.Text))
                {
                    MessageBox.Show("Vui lòng nhập họ tên khách hàng.");
                    return;
                }

                if (string.IsNullOrEmpty(txtSDT.Text))
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại.");
                    return;
                }

                if (string.IsNullOrEmpty(txtDiaChi.Text))
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ.");
                    return;
                }

                if (txtSDT.Text.Length != 11)
                {
                    MessageBox.Show("Số điện thoại phải đủ 11 số.");
                    return;
                }

                if (!txtSDT.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập chỉ số.");
                    return;
                }

                // Kiểm tra trùng CCCD
                if (qlpg.TheKhachHangs.Any(t => t.CCCD == txtCCCD.Text))
                {
                    MessageBox.Show("Số CCCD đã tồn tại. Vui lòng nhập số CCCD khác.");
                    return;
                }

                // Thêm khách hàng
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
                int makh = int.Parse(txtMaKH.Text);
                TheKhachHang kh = qlpg.TheKhachHangs.Where(t => t.TheKhachHangID == makh).FirstOrDefault();

                kh.HoTen = txtTenKH.Text;
                kh.NgaySinh = dtNgaySinh.Value;
                kh.CCCD = txtCCCD.Text;
                kh.SoDienThoai = txtSDT.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.LoaiThanhVien = cboLoaiThanhVien.SelectedItem.ToString();
                kh.GioiTinh = rdbNam.Checked ? "Nam" : "Nữ";
                kh.SoBuoiTapCungPT = Convert.ToInt32(txtSoBuoiTap.Text);

                qlpg.SubmitChanges();
                Load_KhachHangs();
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
