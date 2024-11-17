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
        }
        public void loadThietBi()
        {
            try
            {
                var thietBiList = data.ThietBis.Select(tb => new
                {
                    tb.ThietBiID,
                    tb.TenThietBi,
                    tb.TrangThai,
                    tb.MoTa,
                    tb.NgayNhap,
                    tb.GiaNhap,
                }).ToList();
                dgvThietBi.DataSource = thietBiList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách thiết bị: " + ex.Message);
            }
        }
    }
}
