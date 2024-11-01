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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void container(object _form)
        {

            if (Panel_container.Controls.Count > 0) Panel_container.Controls.Clear();

            Form frm = _form as Form;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            Panel_container.Controls.Add(frm);
            Panel_container.Tag = frm;
            frm.Show();
        }

        private void btnThanhVien_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quản lý thành viên";
            container(new frmThemThanhVien());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quản lý khách hàng";
            container(new frmQuanLyKhachHang());
        }

        private void btnLichTap_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quản lý lịch tập";
            container(new frmDatLichTap());
        }

        private void btnThietBiDVu_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quản lý thiết bị dịch vụ";
            container(new frmQuanLyThietBi());
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Thanh toán";
            //container(new ());
        }

        private void btnBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Báo cáo và thông kê";
            container(new frmBaoCaoVaThongKe());
        }


    }
}
