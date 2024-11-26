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
    public partial class frmQuanLyThietBi : Form
    {
        QLPhongGymDataContext data = new QLPhongGymDataContext();
        public frmQuanLyThietBi()
        {
            InitializeComponent();
            loadThietBi();
            LoadComboBox();
        }
        public void loadThietBi()
        {
            dgvThietBi.CellClick += dgvThietBi_CellClick;
            dgvThietBi.ClearSelection();

            if (guna2ComboBox3.Text == "Tất cả")
                { guna2ComboBox3.Text = null; }
            try
            {
                var thietBiList = data.ThietBis
                .Where(tb => tb.TenThietBi.Contains(guna2TextBox4.Text) && (string.IsNullOrEmpty(guna2ComboBox3.Text) || tb.TrangThai == guna2ComboBox3.Text) )
                .Select(tb => new
                {
                    tb.ThietBiID,
                    tb.TenThietBi,
                    tb.TrangThai,
                    tb.MoTa,
                    tb.NgayNhap,
                    tb.GiaNhap,
                }).ToList();
                dgvThietBi.DataSource = thietBiList;
                if (guna2ComboBox3.Text == null)
                    guna2ComboBox3.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách thiết bị: " + ex.Message);
            }
        }
        bool isEditing = false;
        private void guna2Button1_Click(object sender, EventArgs e)
        {


            if (guna2TextBox1.Text == "" || guna2TextBox2.Text == "" || guna2TextBox3.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (isEditing == true)
            {
                // Lấy ID của thiết bị từ hàng được chọn
                int thietBiID = Convert.ToInt32(dgvThietBi.CurrentRow.Cells[0].Value);

                try
                {
                    // Tìm thiết bị trong cơ sở dữ liệu
                    ThietBi thietBi = data.ThietBis.SingleOrDefault(tb => tb.ThietBiID == thietBiID);
                    if (thietBi != null)
                    {
                        // Cập nhật thông tin thiết bị
                        thietBi.TenThietBi = guna2TextBox1.Text;
                        thietBi.TrangThai = guna2ComboBox1.Text;
                        thietBi.MoTa = guna2TextBox3.Text;
                        thietBi.GiaNhap = Convert.ToDecimal(guna2TextBox2.Text);
                        thietBi.NgayNhap = DateTime.Now; // Hoặc lấy từ một DateTimePicker nếu cần

                        // Lưu thay đổi vào cơ sở dữ liệu
                        data.SubmitChanges();

                        // Cập nhật DataGridView
                        loadThietBi();

                        MessageBox.Show("Cập nhật thiết bị thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thiết bị để cập nhật.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật thiết bị: " + ex.Message);
                }
            }
            else
            {
                try
                {

                    string deviceName = guna2TextBox1.Text;
                    string price = guna2TextBox2.Text;
                    string status = guna2ComboBox1.Text;
                    string description = guna2TextBox3.Text;
                    ThietBi advice = new ThietBi();
                    advice.TenThietBi = deviceName;
                    advice.TrangThai = status;
                    advice.MoTa = description;
                    advice.GiaNhap = Convert.ToDecimal(price);
                    advice.NgayNhap = DateTime.Now;
                    data.ThietBis.InsertOnSubmit(advice);
                    data.SubmitChanges();
                    MessageBox.Show("Thêm thiết bị thành công!");
                    loadThietBi(); // Refresh the device list
                    guna2TextBox1.Text = "";
                    guna2TextBox2.Text = "";
                    guna2TextBox3.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm thiết bị: " + ex.Message);
                }
            }
           


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text = "";
            guna2TextBox2.Text = "";
            guna2TextBox3.Text = "";
            isEditing = false;
        }
        private void dgvThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có phải là hàng hợp lệ không
            if (e.RowIndex >= 0)
            {
                isEditing = true;
                DataGridViewRow row = dgvThietBi.Rows[e.RowIndex];
                // Lấy dữ liệu từ hàng được chọn và hiển thị lên các TextBox
                guna2TextBox1.Text = row.Cells[1].Value.ToString();
                guna2TextBox2.Text = row.Cells[5].Value.ToString();
                guna2TextBox3.Text = row.Cells[3].Value.ToString();
            }
        }
        private void LoadComboBox()
        {
            guna2ComboBox1.Items.Add("Sử dụng");
            guna2ComboBox1.Items.Add("Bảo trì");
            guna2ComboBox1.SelectedIndex = 0;
            guna2ComboBox3.Items.Add("Tất cả");
            guna2ComboBox3.Items.Add("Sử dụng");
            guna2ComboBox3.Items.Add("Bảo trì");
            guna2ComboBox3.SelectedIndex = 0;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            loadThietBi();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (dgvThietBi.CurrentRow != null)
            {
                int thietBiID = Convert.ToInt32(dgvThietBi.CurrentRow.Cells[0].Value);

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thiết bị này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Tìm thiết bị trong cơ sở dữ liệu
                        ThietBi thietBi = data.ThietBis.SingleOrDefault(tb => tb.ThietBiID == thietBiID);
                        if (thietBi != null)
                        {
                            data.LichSuBaoTris.DeleteAllOnSubmit(data.LichSuBaoTris.Where(lsb => lsb.ThietBiID == thietBiID));
                            // Xóa thiết bị khỏi cơ sở dữ liệu
                            data.ThietBis.DeleteOnSubmit(thietBi);
                            data.SubmitChanges();

                            // Cập nhật DataGridView
                            loadThietBi();

                            MessageBox.Show("Xóa thiết bị thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thiết bị để xóa.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa thiết bị: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thiết bị để xóa.");
            }
        }
    }
}
