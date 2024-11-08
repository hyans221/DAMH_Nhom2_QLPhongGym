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
            var khachhang = from kh in qlpg.KhachHangs
                            select kh;
            dgvKhachHang.DataSource = khachhang;
        }
        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            Load_KhachHangs();
        }

        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow != null)
            {
                var select = dgvKhachHang.CurrentRow.DataBoundItem as KhachHang;
                if (select != null)
                {
                    txtMaKH.Text = select.KhachHangID.ToString();
                    txtTenKH.Text = select.HoTen;
                    dtNgaySinh.Value = select.NgaySinh ?? DateTime.Now;
                    txtSDT.Text = select.SoDienThoai;
                    txtDiaChi.Text = select.DiaChi;
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

                // Thêm khách hàng
                KhachHang kh = new KhachHang();
                kh.HoTen = txtTenKH.Text;
                kh.NgaySinh = dtNgaySinh.Value;
                kh.SoDienThoai = txtSDT.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.GioiTinh = rdbNam.Checked ? "Nam" : "Nữ";
                kh.LoaiKhachHangID = 1;
                qlpg.KhachHangs.InsertOnSubmit(kh);

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
                KhachHang kh = qlpg.KhachHangs.Where(t => t.KhachHangID == makh).FirstOrDefault();
                qlpg.KhachHangs.DeleteOnSubmit(kh);

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
                KhachHang kh = qlpg.KhachHangs.Where(t => t.KhachHangID == makh).FirstOrDefault();

                kh.HoTen = txtTenKH.Text;
                kh.NgaySinh = dtNgaySinh.Value;
                kh.SoDienThoai = txtSDT.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.GioiTinh = rdbNam.Checked ? "Nam" : "Nữ";

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
            txtDiaChi.Clear();
            txtSDT.Clear();
            dtNgaySinh.Value = DateTime.Now;
            rdbNam.Checked = true;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string timKiem = txtTimKiem.Text.Trim();

                if (string.IsNullOrEmpty(timKiem))
                {
                    MessageBox.Show("Vui lòng nhập thông tin tìm kiếm.");
                    return; 
                }

                var khachhang = from kh in qlpg.KhachHangs
                                where kh.HoTen.Contains(timKiem)
                                select kh;

                if (!khachhang.Any())
                {
                    int maKH;
                    if (int.TryParse(timKiem, out maKH))
                    {
                        khachhang = from kh in qlpg.KhachHangs
                                    where kh.KhachHangID == maKH
                                    select kh;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng phù hợp.");
                        return; 
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
