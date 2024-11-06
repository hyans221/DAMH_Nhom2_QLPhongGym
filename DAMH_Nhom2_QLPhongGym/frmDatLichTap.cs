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
    public partial class frmDatLichTap : Form
    {
        QLPhongGymDataContext data = QLPhongGymDataContext();
        public frmDatLichTap()
        {
            InitializeComponent();
            btnLoc.Enabled = false;
            btnDatLich.Enabled = false;
        }

        public void loadDiaChi()
        {
            try
            {
                // Lấy danh sách tên địa điểm từ bảng ChiNhanh
                var diaChiList = data.ChiNhanhs.Select(cn => cn.TenDiaDiem).ToList();

                // Xóa các mục hiện có trong ComboBox trước khi thêm mới
                cbxDiaChi.Items.Clear();

                // Thêm từng tên địa điểm vào ComboBox
                cbxDiaChi.Items.AddRange(diaChiList.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách địa chỉ: " + ex.Message);
            }
        }
    }
}
