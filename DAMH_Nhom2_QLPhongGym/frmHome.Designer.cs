using System.Drawing;
using System.Windows.Forms;

namespace DAMH_Nhom2_QLPhongGym
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserNamePanel = new System.Windows.Forms.Panel();
            this.btnhome = new Guna.UI2.WinForms.Guna2Button();
            this.usr_type = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnBaoCaoThongKe = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnVaiTro = new System.Windows.Forms.Button();
            this.btnThietBiDVu = new System.Windows.Forms.Button();
            this.btnLichTap = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnThanhVien = new System.Windows.Forms.Button();
            this.Panel_container = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.UserNamePanel.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.UserNamePanel);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1184, 62);
            this.panel2.TabIndex = 0;
            // 
            // UserNamePanel
            // 
            this.UserNamePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserNamePanel.BackColor = System.Drawing.Color.SlateGray;
            this.UserNamePanel.Controls.Add(this.btnhome);
            this.UserNamePanel.Controls.Add(this.usr_type);
            this.UserNamePanel.Controls.Add(this.lblUsername);
            this.UserNamePanel.Location = new System.Drawing.Point(842, 0);
            this.UserNamePanel.Name = "UserNamePanel";
            this.UserNamePanel.Size = new System.Drawing.Size(239, 71);
            this.UserNamePanel.TabIndex = 9;
            // 
            // btnhome
            // 
            this.btnhome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnhome.FillColor = System.Drawing.Color.Empty;
            this.btnhome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnhome.ForeColor = System.Drawing.Color.White;
            this.btnhome.ImageSize = new System.Drawing.Size(40, 40);
            this.btnhome.Location = new System.Drawing.Point(176, 0);
            this.btnhome.Name = "btnhome";
            this.btnhome.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.btnhome.Size = new System.Drawing.Size(64, 69);
            this.btnhome.TabIndex = 4;
            // 
            // usr_type
            // 
            this.usr_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usr_type.AutoSize = true;
            this.usr_type.ForeColor = System.Drawing.Color.White;
            this.usr_type.Location = new System.Drawing.Point(70, 39);
            this.usr_type.Name = "usr_type";
            this.usr_type.Size = new System.Drawing.Size(13, 13);
            this.usr_type.TabIndex = 2;
            this.usr_type.Text = "..";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(65, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Padding = new System.Windows.Forms.Padding(0, 13, 0, 0);
            this.lblUsername.Size = new System.Drawing.Size(28, 43);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "...";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(9, 17, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(240, 56);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "TRANG CHỦ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SlateGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1063, -7);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(9, 26, 9, 0);
            this.label1.Size = new System.Drawing.Size(48, 76);
            this.label1.TabIndex = 7;
            this.label1.Text = "...\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelMenu.Controls.Add(this.btnBaoCaoThongKe);
            this.panelMenu.Controls.Add(this.btnThanhToan);
            this.panelMenu.Controls.Add(this.btnVaiTro);
            this.panelMenu.Controls.Add(this.btnThietBiDVu);
            this.panelMenu.Controls.Add(this.btnLichTap);
            this.panelMenu.Controls.Add(this.btnKhachHang);
            this.panelMenu.Controls.Add(this.btnThanhVien);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 62);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(217, 587);
            this.panelMenu.TabIndex = 1;
            // 
            // btnBaoCaoThongKe
            // 
            this.btnBaoCaoThongKe.BackColor = System.Drawing.Color.SlateGray;
            this.btnBaoCaoThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaoCaoThongKe.FlatAppearance.BorderSize = 0;
            this.btnBaoCaoThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCaoThongKe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnBaoCaoThongKe.ForeColor = System.Drawing.Color.Snow;
            this.btnBaoCaoThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCaoThongKe.Location = new System.Drawing.Point(0, 305);
            this.btnBaoCaoThongKe.Name = "btnBaoCaoThongKe";
            this.btnBaoCaoThongKe.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnBaoCaoThongKe.Size = new System.Drawing.Size(217, 61);
            this.btnBaoCaoThongKe.TabIndex = 17;
            this.btnBaoCaoThongKe.Text = "Báo cáo và thống kê";
            this.btnBaoCaoThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCaoThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaoCaoThongKe.UseVisualStyleBackColor = false;
            this.btnBaoCaoThongKe.Click += new System.EventHandler(this.btnBaoCaoThongKe_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.SlateGray;
            this.btnThanhToan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.ForeColor = System.Drawing.Color.Snow;
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(0, 244);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnThanhToan.Size = new System.Drawing.Size(217, 61);
            this.btnThanhToan.TabIndex = 16;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnVaiTro
            // 
            this.btnVaiTro.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnVaiTro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnVaiTro.FlatAppearance.BorderSize = 0;
            this.btnVaiTro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaiTro.Font = new System.Drawing.Font("Ebrima", 12.25F);
            this.btnVaiTro.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVaiTro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVaiTro.Location = new System.Drawing.Point(0, 526);
            this.btnVaiTro.Name = "btnVaiTro";
            this.btnVaiTro.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnVaiTro.Size = new System.Drawing.Size(217, 61);
            this.btnVaiTro.TabIndex = 13;
            this.btnVaiTro.Text = ".";
            this.btnVaiTro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVaiTro.UseVisualStyleBackColor = false;
            // 
            // btnThietBiDVu
            // 
            this.btnThietBiDVu.BackColor = System.Drawing.Color.SlateGray;
            this.btnThietBiDVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThietBiDVu.FlatAppearance.BorderSize = 0;
            this.btnThietBiDVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThietBiDVu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnThietBiDVu.ForeColor = System.Drawing.Color.Snow;
            this.btnThietBiDVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThietBiDVu.Location = new System.Drawing.Point(0, 183);
            this.btnThietBiDVu.Name = "btnThietBiDVu";
            this.btnThietBiDVu.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnThietBiDVu.Size = new System.Drawing.Size(217, 61);
            this.btnThietBiDVu.TabIndex = 11;
            this.btnThietBiDVu.Text = "Quản lý thiết bị";
            this.btnThietBiDVu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThietBiDVu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThietBiDVu.UseVisualStyleBackColor = false;
            this.btnThietBiDVu.Click += new System.EventHandler(this.btnThietBiDVu_Click);
            // 
            // btnLichTap
            // 
            this.btnLichTap.BackColor = System.Drawing.Color.SlateGray;
            this.btnLichTap.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLichTap.FlatAppearance.BorderSize = 0;
            this.btnLichTap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichTap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnLichTap.ForeColor = System.Drawing.Color.Snow;
            this.btnLichTap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichTap.Location = new System.Drawing.Point(0, 122);
            this.btnLichTap.Name = "btnLichTap";
            this.btnLichTap.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLichTap.Size = new System.Drawing.Size(217, 61);
            this.btnLichTap.TabIndex = 10;
            this.btnLichTap.Text = "Quản lý lịch tập";
            this.btnLichTap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichTap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLichTap.UseVisualStyleBackColor = false;
            this.btnLichTap.Click += new System.EventHandler(this.btnLichTap_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.SlateGray;
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnKhachHang.ForeColor = System.Drawing.Color.Snow;
            this.btnKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 61);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnKhachHang.Size = new System.Drawing.Size(217, 61);
            this.btnKhachHang.TabIndex = 9;
            this.btnKhachHang.Text = "Quản lý khách hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnThanhVien
            // 
            this.btnThanhVien.BackColor = System.Drawing.Color.SlateGray;
            this.btnThanhVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThanhVien.FlatAppearance.BorderSize = 0;
            this.btnThanhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhVien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnThanhVien.ForeColor = System.Drawing.Color.Snow;
            this.btnThanhVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhVien.Location = new System.Drawing.Point(0, 0);
            this.btnThanhVien.Name = "btnThanhVien";
            this.btnThanhVien.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnThanhVien.Size = new System.Drawing.Size(217, 61);
            this.btnThanhVien.TabIndex = 8;
            this.btnThanhVien.Text = "Quản lý thành viên";
            this.btnThanhVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThanhVien.UseVisualStyleBackColor = false;
            this.btnThanhVien.Click += new System.EventHandler(this.btnThanhVien_Click);
            // 
            // Panel_container
            // 
            this.Panel_container.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_container.Location = new System.Drawing.Point(217, 62);
            this.Panel_container.Name = "Panel_container";
            this.Panel_container.Size = new System.Drawing.Size(967, 587);
            this.Panel_container.TabIndex = 2;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 649);
            this.Controls.Add(this.Panel_container);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel2);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "+";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.UserNamePanel.ResumeLayout(false);
            this.UserNamePanel.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Panel panelMenu;
        private Button btnThietBiDVu;
        private Button btnLichTap;
        private Button btnKhachHang;
        private Button btnThanhVien;
        private Label label1;
        private Label lblTitle;
        private Panel Panel_container;
        private Panel UserNamePanel;
        private Label lblUsername;
        private Label usr_type;
        private Guna.UI2.WinForms.Guna2Button btnhome;
        private Button btnVaiTro;
        private Button btnBaoCaoThongKe;
        private Button btnThanhToan;
    }
}
