﻿using System;
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
    public partial class frmDatLichTap : Form
    {
        QLPhongGymDataContext data = new QLPhongGymDataContext();
        public frmDatLichTap()
        {
            InitializeComponent();
            btnDatLich.Enabled = false;
            btnTraCuu.Enabled = false;
            loadDiaChi();
            loadTrangThai();
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
            cbxTrangThai.SelectedIndex = 0;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                int maKhach = Int32.Parse(txtMaKhach.Text.Trim());
                var khachHang = data.TheKhachHangs.FirstOrDefault(kh => kh.TheKhachHangID == maKhach);
                if (khachHang != null)
                {
                    txtTenKhach.Text = khachHang.HoTen;
                    txtSoBuoi.Text = khachHang.SoBuoiTapCungPT.ToString();

                    // Chỉ kích hoạt nút nếu số buổi tập lớn hơn 0
                    btnDatLich.Enabled = khachHang.SoBuoiTapCungPT > 0;
                    btnTraCuu.Enabled = khachHang.SoBuoiTapCungPT > 0;

                    if (khachHang.SoBuoiTapCungPT == 0)
                    {
                        MessageBox.Show("Bạn không đủ buổi tập, muốn gia hạn thêm không?");
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng.");
                }
            }
            catch
            {
                MessageBox.Show("Chỉ nhận số");
            }
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            try
            {
                string diaChi = cbxDiaChi.SelectedItem.ToString();
                string trangThai = cbxTrangThai.SelectedItem.ToString();
                DateTime ngayBatDau = DateTimeTU.Value.Date;
                DateTime ngayKetThuc = DateTimeDEN.Value.Date;
                var lichTaps = from lt in data.LichTaps
                               join hlv in data.HuanLuyenViens on lt.HLV_ID equals hlv.HLV_ID
                               join cn in data.ChiTiet_ChiNhanh_LichTaps on lt.LichTapID equals cn.LichTapID
                               where cn.ChiNhanh.TenDiaDiem == diaChi
                               && lt.TrangThai == trangThai
                               && lt.NgayBatDau >= ngayBatDau && lt.NgayBatDau <= ngayKetThuc
                               select new
                               {
                                   lt.LichTapID,
                                   lt.TrangThai,
                                   lt.NgayBatDau,
                                   lt.ThoiGianBatDau,
                                   lt.ThoiGianKetThuc,
                                   HuanLuyenVien = hlv.HoTen
                               };
                if (lichTaps.Any())
                {
                    dgvLichTap.DataSource = lichTaps.ToList();
                    btnDatLich.Enabled = true;
                    if (dgvLichTap.Columns.Contains("LichTapID"))
                    {
                        dgvLichTap.Columns["LichTapID"].Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu.");
                    btnDatLich.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLichTap.SelectedRows.Count > 0)
                {
                    string trangThai = dgvLichTap.SelectedRows[0].Cells["TrangThai"].Value.ToString();
                    if (trangThai != "Trống")
                    {
                        MessageBox.Show("Chỉ có thể đặt lịch với trạng thái 'Trống'.");
                        return;
                    }

                    int lichTapID = Convert.ToInt32(dgvLichTap.SelectedRows[0].Cells["LichTapID"].Value);
                    int theKhachHangID = Int32.Parse(txtMaKhach.Text.Trim());
                    var khachHang = data.TheKhachHangs.FirstOrDefault(kh => kh.TheKhachHangID == theKhachHangID);
                    var lichTap = data.LichTaps.FirstOrDefault(lt => lt.LichTapID == lichTapID);
                    if (khachHang != null && khachHang.SoBuoiTapCungPT > 0)
                    {
                        DangKyLichTap dangKyLichTap = new DangKyLichTap
                        {
                            TheKhachHangID = theKhachHangID,
                            LichTapID = lichTapID
                        };
                        data.DangKyLichTaps.InsertOnSubmit(dangKyLichTap);
                        khachHang.SoBuoiTapCungPT -= 1;
                        lichTap.TrangThai = "Đã đặt";
                        data.SubmitChanges();
                        MessageBox.Show("Đặt lịch thành công.");
                        txtSoBuoi.Text = khachHang.SoBuoiTapCungPT.ToString();
                        if (khachHang.SoBuoiTapCungPT == 0)
                        {
                            MessageBox.Show("Bạn không đủ buổi tập, muốn gia hạn thêm không?");
                            btnDatLich.Enabled = false;
                        }
                        btnTraCuu_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Không đủ buổi tập để đặt lịch.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một lịch tập để đặt.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đặt lịch: " + ex.Message);
            }
        }

    }
}
