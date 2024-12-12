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
        private string username;
        private string role;
        private int idNhanVien;
        public frmHome(string username, string role,int id)
        {
            InitializeComponent();
            this.username = username;
            this.role = role;
            this.idNhanVien = id;
            lblUsername.Text = $"{role}";
            ConfigureUIBasedOnRole();
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
            lblTitle.Text = "Quản lý thanh toán";
            container(new frmThanhToan(idNhanVien));
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quản lý thông tin khách hàng";
            container(new frmQuanLyKhachHang());
        }

        private void btnLichTap_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quản lý đặt lịch tập";
            container(new frmDatLichTap(idNhanVien));
        }

        private void btnThietBiDVu_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quản lý thiết bị dịch vụ";
            container(new frmQuanLyThietBi());
        }

        private void btnBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Báo cáo và thông kê";
            container(new frmBaoCaoVaThongKe());
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin dangNhap = new frmLogin();
            dangNhap.Show();
        }

        private void ConfigureUIBasedOnRole()
        {
            if (role == "User")
            {
                btnThietBiDVu.Enabled = false;
                btnBaoCaoThongKe.Enabled = false;
            }
        }
    }
}
