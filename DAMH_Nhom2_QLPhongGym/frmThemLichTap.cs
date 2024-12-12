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
    public partial class frmThemLichTap : Form
    {
        QLPhongGymDataContext data = new QLPhongGymDataContext();
        public frmThemLichTap()
        {
            InitializeComponent();
            LoadLichTap();
            loadDiaChi();
            loadTrangThai();
            loadPT();

            DateTime now = DateTime.Now;
            DateTimeTU.Value = now;
            DateTimeDEN.Value = now;
            DateTimeTU.ValueChanged += DateTimeTU_ValueChanged;
            DateTimeDEN.ValueChanged += DateTimeDEN_ValueChanged;

            time1.Format = DateTimePickerFormat.Custom;
            time1.CustomFormat = "HH:mm";
            time1.ShowUpDown = true;
            time1.ValueChanged += Time1_ValueChanged;

            time2.Format = DateTimePickerFormat.Custom;
            time2.CustomFormat = "HH:mm";
            time2.ShowUpDown = true;
            time2.ValueChanged += Time2_ValueChanged;
        }

        private void Time1_ValueChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem time1 có sau time2 không
            if (time1.Value > time2.Value)
            {
                MessageBox.Show("Thời gian bắt đầu phải trước thời gian kết thúc. Vui lòng chọn lại.", "Lỗi thời gian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                time1.Value = time2.Value.AddMinutes(-1); // Đặt lại time1 để nhỏ hơn time2
            }
        }

        private void Time2_ValueChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem time2 có sau time1 không
            if (time2.Value < time1.Value)
            {
                MessageBox.Show("Thời gian kết thúc phải sau thời gian bắt đầu. Vui lòng chọn lại.", "Lỗi thời gian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                time2.Value = time1.Value.AddMinutes(1); // Đặt lại time2 để lớn hơn time1
            }
        }

        private void OnTimeChanged(object sender, string timeName)
        {
            DateTime selectedTime = ((DateTimePicker)sender).Value;
            MessageBox.Show($"Bạn đã chọn {timeName}: " + selectedTime.ToString("HH:mm"));
        }

        private void CheckTimeValidity()
        {
            if (DateTimeDEN.Value.Date < DateTimeTU.Value.Date)
            {
                MessageBox.Show("Thời gian 'Đến' không được trước thời gian 'Từ'. Vui lòng chọn lại.", "Lỗi thời gian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DateTimeDEN.Value = DateTimeTU.Value;
            }
        }

        private void DateTimeTU_ValueChanged(object sender, EventArgs e)
        {
            CheckTimeValidity();
        }

        private void DateTimeDEN_ValueChanged(object sender, EventArgs e)
        {
            CheckTimeValidity();
        }

        public void loadDiaChi()
        {
            try
            {
                var diaChiList = data.ChiNhanhs.Select(cn => cn.TenDiaDiem).ToList();
                cbxDiaChi.Items.Clear();
                cbxDiaChi.Items.AddRange(diaChiList.ToArray());
                if (diaChiList.Count > 0)
                {
                    cbxDiaChi.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách địa chỉ: " + ex.Message);
            }
        }
        private void loadTrangThai()
        {
            cbxTrangThai.Items.Clear();
            cbxTrangThai.Items.Add("Đã đặt");
            cbxTrangThai.Items.Add("Trống");
            cbxTrangThai.SelectedIndex = 1;
        }

        public void loadPT()
        {
            try
            {
                var PT = data.HuanLuyenViens.Select(cn => cn.HoTen).ToList();
                cbxPT.Items.Clear();
                cbxPT.Items.AddRange(PT.ToArray());
                if (PT.Count > 0)
                {
                    cbxPT.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách PT: " + ex.Message);
            }
        }

        private void ConfigureDataGridView()
        {
            dgvLichTap.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dgvLichTap.Columns["NgayBatDau"].HeaderText = "Ngày Bắt Đầu";
            dgvLichTap.Columns["ThoiGianBatDau"].HeaderText = "Thời Gian Bắt Đầu";
            dgvLichTap.Columns["ThoiGianKetThuc"].HeaderText = "Thời Gian Kết Thúc";
            dgvLichTap.Columns["HuanLuyenVien"].HeaderText = "Huấn Luyện Viên";
            dgvLichTap.Columns["KhachHang"].HeaderText = "Khách Hàng";
        }

        private void LoadLichTap()
        {
            try
            {
                var query = from lt in data.LichTaps
                            join dk in data.DangKyLichTaps on lt.LichTapID equals dk.LichTapID into gj
                            from subdk in gj.DefaultIfEmpty()
                            join kh in data.TheKhachHangs on subdk.TheKhachHangID equals kh.TheKhachHangID into gkh
                            from subkh in gkh.DefaultIfEmpty()
                            select new
                            {
                                TrangThai = lt.TrangThai,
                                NgayBatDau = lt.NgayBatDau,
                                ThoiGianBatDau = lt.ThoiGianBatDau,
                                ThoiGianKetThuc = lt.ThoiGianKetThuc,
                                HuanLuyenVien = lt.HuanLuyenVien.HoTen,
                                KhachHang = subkh != null ? subkh.HoTen : "Chưa có"
                            };

                dgvLichTap.DataSource = query.ToList();
                ConfigureDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu lịch tập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            try
            {
                var query = from lt in data.LichTaps
                            join dk in data.DangKyLichTaps on lt.LichTapID equals dk.LichTapID into gj
                            from subdk in gj.DefaultIfEmpty()
                            join kh in data.TheKhachHangs on subdk.TheKhachHangID equals kh.TheKhachHangID into gkh
                            from subkh in gkh.DefaultIfEmpty()
                            select new
                            {
                                TrangThai = lt.TrangThai,
                                NgayBatDau = lt.NgayBatDau,
                                ThoiGianBatDau = lt.ThoiGianBatDau,
                                ThoiGianKetThuc = lt.ThoiGianKetThuc,
                                HuanLuyenVien = lt.HuanLuyenVien.HoTen,
                                KhachHang = subkh != null ? subkh.HoTen : "Chưa có"
                            };

                if (cbxDiaChi.SelectedItem != null)
                {
                    var diaChi = cbxDiaChi.SelectedItem.ToString();
                    query = query.Where(x => x.TrangThai == diaChi);
                }

                if (cbxTrangThai.SelectedItem != null)
                {
                    var trangThai = cbxTrangThai.SelectedItem.ToString();
                    query = query.Where(x => x.TrangThai == trangThai);
                }

                if (cbxPT.SelectedItem != null)
                {
                    var huanLuyenVien = cbxPT.SelectedItem.ToString();
                    query = query.Where(x => x.HuanLuyenVien == huanLuyenVien);
                }

                if (DateTimeTU.Value != null && DateTimeDEN.Value != null)
                {
                    query = query.Where(x => x.NgayBatDau >= DateTimeTU.Value.Date && x.NgayBatDau <= DateTimeDEN.Value.Date);
                }

                dgvLichTap.DataSource = query.ToList();
                ConfigureDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tra cứu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ngayBatDau = DateTimeTU.Value.Date;

                TimeSpan thoiGianBatDau = time1.Value.TimeOfDay;
                TimeSpan thoiGianKetThuc = time2.Value.TimeOfDay;

                LichTap newLichTap = new LichTap
                {
                    HLV_ID = data.HuanLuyenViens.FirstOrDefault(p => p.HoTen == cbxPT.SelectedItem.ToString()).HLV_ID,
                    ThoiGianBatDau = thoiGianBatDau,
                    ThoiGianKetThuc = thoiGianKetThuc,
                    NgayBatDau = ngayBatDau,
                    TrangThai = cbxTrangThai.SelectedItem.ToString()
                };

                data.LichTaps.InsertOnSubmit(newLichTap);
                data.SubmitChanges();

                int lichTapID = newLichTap.LichTapID;

                if (cbxDiaChi.SelectedItem != null)
                {
                    var chiNhanhID = data.ChiNhanhs.FirstOrDefault(c => c.TenDiaDiem == cbxDiaChi.SelectedItem.ToString()).ChiNhanhID;
                    ChiTiet_ChiNhanh_LichTap newCT = new ChiTiet_ChiNhanh_LichTap
                    {
                        ChiNhanhID = chiNhanhID,
                        LichTapID = lichTapID
                    };
                    data.ChiTiet_ChiNhanh_LichTaps.InsertOnSubmit(newCT);
                    data.SubmitChanges();
                }

                MessageBox.Show("Thêm lịch tập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadLichTap();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm lịch tập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmThemLichTap_Load(object sender, EventArgs e)
        {

        }
    }
}
