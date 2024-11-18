using System;
using System.Linq;
using System.Windows.Forms;

namespace DAMH_Nhom2_QLPhongGym
{
    public partial class frmLogin : Form
    {
        QLPhongGymDataContext qlpg = new QLPhongGymDataContext();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = CheckLogin(username, password);
            if (user != null)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmHome mainForm = new frmHome(username, user.Quyen); 
                mainForm.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private TaiKhoan CheckLogin(string username, string password)
        {

            var user = qlpg.TaiKhoans.SingleOrDefault(u => u.TenDN == username && u.MatKhau == password);
            return user;
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !chkHienMatKhau.Checked;
        }

        private void lblQuenMK_Click(object sender, EventArgs e)
        {
            //frmQuenMatKhau frmForgotPassword = new frmQuenMatKhau();
            //frmForgotPassword.Show();
        }

    }
}