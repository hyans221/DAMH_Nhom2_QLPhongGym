using Guna.UI2.WinForms;

namespace DAMH_Nhom2_QLPhongGym
{
    partial class frmThemThanhVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTinhTien = new Guna.UI2.WinForms.Guna2Button();
            this.txtThanhTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNhanVien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rdo3Buoi = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdo8Buoi = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdo6Buoi = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdo2Buoi = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdo1Buoi = new Guna.UI2.WinForms.Guna2RadioButton();
            this.txtLoaiHoaDon = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnKiemTraID = new Guna.UI2.WinForms.Guna2Button();
            this.btnXacNhan = new Guna.UI2.WinForms.Guna2Button();
            this.txtIDNhanVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDKhachHang = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2RadioButton6 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2RadioButton7 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2RadioButton8 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2RadioButton9 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2RadioButton10 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdo6Thang = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdo24Thang = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdo12Thang = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdo3Thang = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdo1Thang = new Guna.UI2.WinForms.Guna2RadioButton();
            this.panel1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnTinhTien);
            this.panel1.Controls.Add(this.txtThanhTien);
            this.panel1.Controls.Add(this.txtNhanVien);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.guna2GroupBox2);
            this.panel1.Controls.Add(this.txtLoaiHoaDon);
            this.panel1.Controls.Add(this.btnKiemTraID);
            this.panel1.Controls.Add(this.btnXacNhan);
            this.panel1.Controls.Add(this.txtIDNhanVien);
            this.panel1.Controls.Add(this.txtIDKhachHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 575);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(612, 705);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 26);
            this.label9.TabIndex = 74;
            this.label9.Text = "Thành tiền:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.BorderRadius = 10;
            this.btnTinhTien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTinhTien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTinhTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTinhTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTinhTien.FillColor = System.Drawing.Color.LightSlateGray;
            this.btnTinhTien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTinhTien.ForeColor = System.Drawing.Color.White;
            this.btnTinhTien.Location = new System.Drawing.Point(619, 634);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(180, 58);
            this.btnTinhTien.TabIndex = 70;
            this.btnTinhTien.Text = "Tính tổng tiền";
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BackColor = System.Drawing.Color.White;
            this.txtThanhTien.BorderRadius = 10;
            this.txtThanhTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThanhTien.DefaultText = "";
            this.txtThanhTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtThanhTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtThanhTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThanhTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThanhTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThanhTien.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtThanhTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThanhTien.Location = new System.Drawing.Point(815, 695);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.PasswordChar = '\0';
            this.txtThanhTien.PlaceholderText = "";
            this.txtThanhTien.SelectedText = "";
            this.txtThanhTien.Size = new System.Drawing.Size(322, 51);
            this.txtThanhTien.TabIndex = 73;
            this.txtThanhTien.TextChanged += new System.EventHandler(this.txtThanhTien_TextChanged);
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.AutoSize = true;
            this.txtNhanVien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNhanVien.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNhanVien.Location = new System.Drawing.Point(10, 93);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(211, 22);
            this.txtNhanVien.TabIndex = 68;
            this.txtNhanVien.Text = "ID nhân viên thanh toán:";
            this.txtNhanVien.Click += new System.EventHandler(this.txtNhanVien_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(667, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 22);
            this.label3.TabIndex = 68;
            this.label3.Text = "ID khách hàng:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(10, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 22);
            this.label2.TabIndex = 67;
            this.label2.Text = "Loại thanh toán:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(143, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 66;
            this.label1.Text = "Thẻ tập:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(143, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 22);
            this.label6.TabIndex = 65;
            this.label6.Text = "Thuê huấn luyện viên:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderRadius = 10;
            this.guna2GroupBox2.Controls.Add(this.rdo3Buoi);
            this.guna2GroupBox2.Controls.Add(this.rdo8Buoi);
            this.guna2GroupBox2.Controls.Add(this.rdo6Buoi);
            this.guna2GroupBox2.Controls.Add(this.rdo2Buoi);
            this.guna2GroupBox2.Controls.Add(this.rdo1Buoi);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(126, 436);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(575, 310);
            this.guna2GroupBox2.TabIndex = 54;
            this.guna2GroupBox2.Text = "Các gói tập cùng huấn luyện viên:";
            this.guna2GroupBox2.Click += new System.EventHandler(this.guna2GroupBox2_Click);
            // 
            // rdo3Buoi
            // 
            this.rdo3Buoi.AutoSize = true;
            this.rdo3Buoi.BackColor = System.Drawing.Color.LightSlateGray;
            this.rdo3Buoi.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.rdo3Buoi.CheckedState.BorderThickness = 0;
            this.rdo3Buoi.CheckedState.FillColor = System.Drawing.Color.DimGray;
            this.rdo3Buoi.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdo3Buoi.CheckedState.InnerOffset = -4;
            this.rdo3Buoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.rdo3Buoi.ForeColor = System.Drawing.Color.White;
            this.rdo3Buoi.Location = new System.Drawing.Point(317, 77);
            this.rdo3Buoi.Name = "rdo3Buoi";
            this.rdo3Buoi.Size = new System.Drawing.Size(78, 26);
            this.rdo3Buoi.TabIndex = 0;
            this.rdo3Buoi.Text = "3 buổi";
            this.rdo3Buoi.UncheckedState.BorderColor = System.Drawing.Color.Snow;
            this.rdo3Buoi.UncheckedState.BorderThickness = 2;
            this.rdo3Buoi.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdo3Buoi.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdo3Buoi.UseVisualStyleBackColor = false;
            this.rdo3Buoi.CheckedChanged += new System.EventHandler(this.rdo3Buoi_CheckedChanged);
            // 
            // rdo8Buoi
            // 
            this.rdo8Buoi.AutoSize = true;
            this.rdo8Buoi.BackColor = System.Drawing.Color.LightSlateGray;
            this.rdo8Buoi.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.rdo8Buoi.CheckedState.BorderThickness = 0;
            this.rdo8Buoi.CheckedState.FillColor = System.Drawing.Color.DimGray;
            this.rdo8Buoi.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdo8Buoi.CheckedState.InnerOffset = -4;
            this.rdo8Buoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.rdo8Buoi.ForeColor = System.Drawing.Color.White;
            this.rdo8Buoi.Location = new System.Drawing.Point(168, 142);
            this.rdo8Buoi.Name = "rdo8Buoi";
            this.rdo8Buoi.Size = new System.Drawing.Size(78, 26);
            this.rdo8Buoi.TabIndex = 0;
            this.rdo8Buoi.Text = "8 buổi";
            this.rdo8Buoi.UncheckedState.BorderColor = System.Drawing.Color.Snow;
            this.rdo8Buoi.UncheckedState.BorderThickness = 2;
            this.rdo8Buoi.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdo8Buoi.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdo8Buoi.UseVisualStyleBackColor = false;
            this.rdo8Buoi.CheckedChanged += new System.EventHandler(this.rdo8Buoi_CheckedChanged);
            // 
            // rdo6Buoi
            // 
            this.rdo6Buoi.AutoSize = true;
            this.rdo6Buoi.BackColor = System.Drawing.Color.LightSlateGray;
            this.rdo6Buoi.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.rdo6Buoi.CheckedState.BorderThickness = 0;
            this.rdo6Buoi.CheckedState.FillColor = System.Drawing.Color.DimGray;
            this.rdo6Buoi.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdo6Buoi.CheckedState.InnerOffset = -4;
            this.rdo6Buoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.rdo6Buoi.ForeColor = System.Drawing.Color.White;
            this.rdo6Buoi.Location = new System.Drawing.Point(23, 142);
            this.rdo6Buoi.Name = "rdo6Buoi";
            this.rdo6Buoi.Size = new System.Drawing.Size(78, 26);
            this.rdo6Buoi.TabIndex = 0;
            this.rdo6Buoi.Text = "6 buổi";
            this.rdo6Buoi.UncheckedState.BorderColor = System.Drawing.Color.Snow;
            this.rdo6Buoi.UncheckedState.BorderThickness = 2;
            this.rdo6Buoi.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdo6Buoi.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdo6Buoi.UseVisualStyleBackColor = false;
            this.rdo6Buoi.CheckedChanged += new System.EventHandler(this.rdo6Buoi_CheckedChanged);
            // 
            // rdo2Buoi
            // 
            this.rdo2Buoi.AutoSize = true;
            this.rdo2Buoi.BackColor = System.Drawing.Color.LightSlateGray;
            this.rdo2Buoi.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.rdo2Buoi.CheckedState.BorderThickness = 0;
            this.rdo2Buoi.CheckedState.FillColor = System.Drawing.Color.DimGray;
            this.rdo2Buoi.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdo2Buoi.CheckedState.InnerOffset = -4;
            this.rdo2Buoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.rdo2Buoi.ForeColor = System.Drawing.Color.White;
            this.rdo2Buoi.Location = new System.Drawing.Point(169, 77);
            this.rdo2Buoi.Name = "rdo2Buoi";
            this.rdo2Buoi.Size = new System.Drawing.Size(78, 26);
            this.rdo2Buoi.TabIndex = 0;
            this.rdo2Buoi.Text = "2 buổi";
            this.rdo2Buoi.UncheckedState.BorderColor = System.Drawing.Color.Snow;
            this.rdo2Buoi.UncheckedState.BorderThickness = 2;
            this.rdo2Buoi.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdo2Buoi.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdo2Buoi.UseVisualStyleBackColor = false;
            this.rdo2Buoi.CheckedChanged += new System.EventHandler(this.rdo2Buoi_CheckedChanged);
            // 
            // rdo1Buoi
            // 
            this.rdo1Buoi.AutoSize = true;
            this.rdo1Buoi.BackColor = System.Drawing.Color.LightSlateGray;
            this.rdo1Buoi.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.rdo1Buoi.CheckedState.BorderThickness = 0;
            this.rdo1Buoi.CheckedState.FillColor = System.Drawing.Color.DimGray;
            this.rdo1Buoi.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdo1Buoi.CheckedState.InnerOffset = -4;
            this.rdo1Buoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.rdo1Buoi.ForeColor = System.Drawing.Color.White;
            this.rdo1Buoi.Location = new System.Drawing.Point(27, 77);
            this.rdo1Buoi.Name = "rdo1Buoi";
            this.rdo1Buoi.Size = new System.Drawing.Size(78, 26);
            this.rdo1Buoi.TabIndex = 0;
            this.rdo1Buoi.Text = "1 buổi";
            this.rdo1Buoi.UncheckedState.BorderColor = System.Drawing.Color.Snow;
            this.rdo1Buoi.UncheckedState.BorderThickness = 2;
            this.rdo1Buoi.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdo1Buoi.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdo1Buoi.UseVisualStyleBackColor = false;
            this.rdo1Buoi.CheckedChanged += new System.EventHandler(this.rdo1Buoi_CheckedChanged);
            // 
            // txtLoaiHoaDon
            // 
            this.txtLoaiHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.txtLoaiHoaDon.BorderRadius = 10;
            this.txtLoaiHoaDon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtLoaiHoaDon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtLoaiHoaDon.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoaiHoaDon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoaiHoaDon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLoaiHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtLoaiHoaDon.ItemHeight = 30;
            this.txtLoaiHoaDon.Items.AddRange(new object[] {
            "Thanh toán mới",
            "Gia hạn",
            "Thuê huấn luyện viên"});
            this.txtLoaiHoaDon.Location = new System.Drawing.Point(241, 18);
            this.txtLoaiHoaDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLoaiHoaDon.Name = "txtLoaiHoaDon";
            this.txtLoaiHoaDon.Size = new System.Drawing.Size(364, 36);
            this.txtLoaiHoaDon.StartIndex = 0;
            this.txtLoaiHoaDon.TabIndex = 57;
            this.txtLoaiHoaDon.SelectedIndexChanged += new System.EventHandler(this.txtLoaiHoaDon_SelectedIndexChanged);
            // 
            // btnKiemTraID
            // 
            this.btnKiemTraID.BorderRadius = 10;
            this.btnKiemTraID.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKiemTraID.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKiemTraID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKiemTraID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKiemTraID.FillColor = System.Drawing.Color.LightSlateGray;
            this.btnKiemTraID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKiemTraID.ForeColor = System.Drawing.Color.White;
            this.btnKiemTraID.Location = new System.Drawing.Point(910, 61);
            this.btnKiemTraID.Name = "btnKiemTraID";
            this.btnKiemTraID.Size = new System.Drawing.Size(280, 54);
            this.btnKiemTraID.TabIndex = 56;
            this.btnKiemTraID.Text = "Kiểm tra thông tin";
            this.btnKiemTraID.Click += new System.EventHandler(this.btnKiemTraID_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BorderRadius = 10;
            this.btnXacNhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXacNhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXacNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXacNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXacNhan.FillColor = System.Drawing.Color.LightSlateGray;
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(383, 822);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(180, 58);
            this.btnXacNhan.TabIndex = 54;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtIDNhanVien
            // 
            this.txtIDNhanVien.BorderRadius = 10;
            this.txtIDNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDNhanVien.DefaultText = "";
            this.txtIDNhanVien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDNhanVien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDNhanVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDNhanVien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDNhanVien.Location = new System.Drawing.Point(352, 86);
            this.txtIDNhanVien.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtIDNhanVien.Name = "txtIDNhanVien";
            this.txtIDNhanVien.PasswordChar = '\0';
            this.txtIDNhanVien.PlaceholderText = "";
            this.txtIDNhanVien.SelectedText = "";
            this.txtIDNhanVien.Size = new System.Drawing.Size(253, 39);
            this.txtIDNhanVien.TabIndex = 52;
            this.txtIDNhanVien.TextChanged += new System.EventHandler(this.txtIDNhanVien_TextChanged);
            // 
            // txtIDKhachHang
            // 
            this.txtIDKhachHang.BorderRadius = 10;
            this.txtIDKhachHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDKhachHang.DefaultText = "";
            this.txtIDKhachHang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDKhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDKhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDKhachHang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDKhachHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDKhachHang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDKhachHang.Location = new System.Drawing.Point(880, 8);
            this.txtIDKhachHang.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtIDKhachHang.Name = "txtIDKhachHang";
            this.txtIDKhachHang.PasswordChar = '\0';
            this.txtIDKhachHang.PlaceholderText = "";
            this.txtIDKhachHang.SelectedText = "";
            this.txtIDKhachHang.Size = new System.Drawing.Size(310, 42);
            this.txtIDKhachHang.TabIndex = 52;
            this.txtIDKhachHang.TextChanged += new System.EventHandler(this.txtIDKhachHang_TextChanged);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(0, 0);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(0, 0);
            this.guna2HtmlLabel3.TabIndex = 0;
            this.guna2HtmlLabel3.Text = null;
            this.guna2HtmlLabel3.Click += new System.EventHandler(this.guna2HtmlLabel3_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(0, 0);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(0, 0);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = null;
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // guna2RadioButton6
            // 
            this.guna2RadioButton6.CheckedState.BorderThickness = 0;
            this.guna2RadioButton6.Location = new System.Drawing.Point(0, 0);
            this.guna2RadioButton6.Name = "guna2RadioButton6";
            this.guna2RadioButton6.Size = new System.Drawing.Size(104, 24);
            this.guna2RadioButton6.TabIndex = 0;
            this.guna2RadioButton6.UncheckedState.BorderThickness = 0;
            this.guna2RadioButton6.CheckedChanged += new System.EventHandler(this.guna2RadioButton6_CheckedChanged);
            // 
            // guna2RadioButton7
            // 
            this.guna2RadioButton7.CheckedState.BorderThickness = 0;
            this.guna2RadioButton7.Location = new System.Drawing.Point(0, 0);
            this.guna2RadioButton7.Name = "guna2RadioButton7";
            this.guna2RadioButton7.Size = new System.Drawing.Size(104, 24);
            this.guna2RadioButton7.TabIndex = 0;
            this.guna2RadioButton7.UncheckedState.BorderThickness = 0;
            this.guna2RadioButton7.CheckedChanged += new System.EventHandler(this.guna2RadioButton7_CheckedChanged);
            // 
            // guna2RadioButton8
            // 
            this.guna2RadioButton8.CheckedState.BorderThickness = 0;
            this.guna2RadioButton8.Location = new System.Drawing.Point(0, 0);
            this.guna2RadioButton8.Name = "guna2RadioButton8";
            this.guna2RadioButton8.Size = new System.Drawing.Size(104, 24);
            this.guna2RadioButton8.TabIndex = 0;
            this.guna2RadioButton8.UncheckedState.BorderThickness = 0;
            this.guna2RadioButton8.CheckedChanged += new System.EventHandler(this.guna2RadioButton8_CheckedChanged);
            // 
            // guna2RadioButton9
            // 
            this.guna2RadioButton9.CheckedState.BorderThickness = 0;
            this.guna2RadioButton9.Location = new System.Drawing.Point(0, 0);
            this.guna2RadioButton9.Name = "guna2RadioButton9";
            this.guna2RadioButton9.Size = new System.Drawing.Size(104, 24);
            this.guna2RadioButton9.TabIndex = 0;
            this.guna2RadioButton9.UncheckedState.BorderThickness = 0;
            this.guna2RadioButton9.CheckedChanged += new System.EventHandler(this.guna2RadioButton9_CheckedChanged);
            // 
            // guna2RadioButton10
            // 
            this.guna2RadioButton10.CheckedState.BorderThickness = 0;
            this.guna2RadioButton10.Location = new System.Drawing.Point(0, 0);
            this.guna2RadioButton10.Name = "guna2RadioButton10";
            this.guna2RadioButton10.Size = new System.Drawing.Size(104, 24);
            this.guna2RadioButton10.TabIndex = 0;
            this.guna2RadioButton10.UncheckedState.BorderThickness = 0;
            this.guna2RadioButton10.CheckedChanged += new System.EventHandler(this.guna2RadioButton10_CheckedChanged);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(140, 36);
            this.guna2ComboBox1.TabIndex = 0;
            this.guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // guna2Button3
            // 
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(0, 0);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(180, 45);
            this.guna2Button3.TabIndex = 0;
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(0, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(50, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 32);
            this.label5.TabIndex = 70;
            this.label5.Text = "Royal:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(50, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 32);
            this.label4.TabIndex = 69;
            this.label4.Text = "Classic:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // rdo6Thang
            // 
            this.rdo6Thang.AutoSize = true;
            this.rdo6Thang.BackColor = System.Drawing.Color.LightSlateGray;
            this.rdo6Thang.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.rdo6Thang.CheckedState.BorderThickness = 0;
            this.rdo6Thang.CheckedState.FillColor = System.Drawing.Color.DimGray;
            this.rdo6Thang.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdo6Thang.CheckedState.InnerOffset = -4;
            this.rdo6Thang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.rdo6Thang.ForeColor = System.Drawing.Color.White;
            this.rdo6Thang.Location = new System.Drawing.Point(686, 90);
            this.rdo6Thang.Name = "rdo6Thang";
            this.rdo6Thang.Size = new System.Drawing.Size(233, 36);
            this.rdo6Thang.TabIndex = 0;
            this.rdo6Thang.Text = "Thẻ tập 6 tháng";
            this.rdo6Thang.UncheckedState.BorderColor = System.Drawing.Color.Snow;
            this.rdo6Thang.UncheckedState.BorderThickness = 2;
            this.rdo6Thang.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdo6Thang.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdo6Thang.UseVisualStyleBackColor = false;
            this.rdo6Thang.CheckedChanged += new System.EventHandler(this.rdo6Thang_CheckedChanged);
            // 
            // rdo24Thang
            // 
            this.rdo24Thang.AutoSize = true;
            this.rdo24Thang.BackColor = System.Drawing.Color.LightSlateGray;
            this.rdo24Thang.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.rdo24Thang.CheckedState.BorderThickness = 0;
            this.rdo24Thang.CheckedState.FillColor = System.Drawing.Color.DimGray;
            this.rdo24Thang.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdo24Thang.CheckedState.InnerOffset = -4;
            this.rdo24Thang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.rdo24Thang.ForeColor = System.Drawing.Color.White;
            this.rdo24Thang.Location = new System.Drawing.Point(433, 155);
            this.rdo24Thang.Name = "rdo24Thang";
            this.rdo24Thang.Size = new System.Drawing.Size(248, 36);
            this.rdo24Thang.TabIndex = 0;
            this.rdo24Thang.Text = "Thẻ tập 24 tháng";
            this.rdo24Thang.UncheckedState.BorderColor = System.Drawing.Color.Snow;
            this.rdo24Thang.UncheckedState.BorderThickness = 2;
            this.rdo24Thang.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdo24Thang.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdo24Thang.UseVisualStyleBackColor = false;
            this.rdo24Thang.CheckedChanged += new System.EventHandler(this.rdo24Thang_CheckedChanged);
            // 
            // rdo12Thang
            // 
            this.rdo12Thang.AutoSize = true;
            this.rdo12Thang.BackColor = System.Drawing.Color.LightSlateGray;
            this.rdo12Thang.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.rdo12Thang.CheckedState.BorderThickness = 0;
            this.rdo12Thang.CheckedState.FillColor = System.Drawing.Color.DimGray;
            this.rdo12Thang.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdo12Thang.CheckedState.InnerOffset = -4;
            this.rdo12Thang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.rdo12Thang.ForeColor = System.Drawing.Color.White;
            this.rdo12Thang.Location = new System.Drawing.Point(165, 155);
            this.rdo12Thang.Name = "rdo12Thang";
            this.rdo12Thang.Size = new System.Drawing.Size(248, 36);
            this.rdo12Thang.TabIndex = 0;
            this.rdo12Thang.Text = "Thẻ tập 12 tháng";
            this.rdo12Thang.UncheckedState.BorderColor = System.Drawing.Color.Snow;
            this.rdo12Thang.UncheckedState.BorderThickness = 2;
            this.rdo12Thang.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdo12Thang.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdo12Thang.UseVisualStyleBackColor = false;
            this.rdo12Thang.CheckedChanged += new System.EventHandler(this.rdo12Thang_CheckedChanged);
            // 
            // rdo3Thang
            // 
            this.rdo3Thang.AutoSize = true;
            this.rdo3Thang.BackColor = System.Drawing.Color.LightSlateGray;
            this.rdo3Thang.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.rdo3Thang.CheckedState.BorderThickness = 0;
            this.rdo3Thang.CheckedState.FillColor = System.Drawing.Color.DimGray;
            this.rdo3Thang.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdo3Thang.CheckedState.InnerOffset = -4;
            this.rdo3Thang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.rdo3Thang.ForeColor = System.Drawing.Color.White;
            this.rdo3Thang.Location = new System.Drawing.Point(433, 90);
            this.rdo3Thang.Name = "rdo3Thang";
            this.rdo3Thang.Size = new System.Drawing.Size(233, 36);
            this.rdo3Thang.TabIndex = 0;
            this.rdo3Thang.Text = "Thẻ tập 3 tháng";
            this.rdo3Thang.UncheckedState.BorderColor = System.Drawing.Color.Snow;
            this.rdo3Thang.UncheckedState.BorderThickness = 2;
            this.rdo3Thang.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdo3Thang.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdo3Thang.UseVisualStyleBackColor = false;
            this.rdo3Thang.CheckedChanged += new System.EventHandler(this.rdo3Thang_CheckedChanged);
            // 
            // rdo1Thang
            // 
            this.rdo1Thang.AutoSize = true;
            this.rdo1Thang.BackColor = System.Drawing.Color.LightSlateGray;
            this.rdo1Thang.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.rdo1Thang.CheckedState.BorderThickness = 0;
            this.rdo1Thang.CheckedState.FillColor = System.Drawing.Color.DimGray;
            this.rdo1Thang.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdo1Thang.CheckedState.InnerOffset = -4;
            this.rdo1Thang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.rdo1Thang.ForeColor = System.Drawing.Color.White;
            this.rdo1Thang.Location = new System.Drawing.Point(165, 90);
            this.rdo1Thang.Name = "rdo1Thang";
            this.rdo1Thang.Size = new System.Drawing.Size(233, 36);
            this.rdo1Thang.TabIndex = 0;
            this.rdo1Thang.Text = "Thẻ tập 1 tháng";
            this.rdo1Thang.UncheckedState.BorderColor = System.Drawing.Color.Snow;
            this.rdo1Thang.UncheckedState.BorderThickness = 2;
            this.rdo1Thang.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdo1Thang.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdo1Thang.UseVisualStyleBackColor = false;
            this.rdo1Thang.CheckedChanged += new System.EventHandler(this.rdo1Thang_CheckedChanged);
            // 
            // frmThemThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1157, 575);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmThemThanhVien";
            this.Text = "frmThemThanhVien";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnXacNhan;
        private Guna2HtmlLabel guna2HtmlLabel3;
        private Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2RadioButton rdo6Thang;
        private Guna.UI2.WinForms.Guna2RadioButton rdo24Thang;
        private Guna.UI2.WinForms.Guna2RadioButton rdo12Thang;
        private Guna.UI2.WinForms.Guna2RadioButton rdo3Thang;
        private Guna.UI2.WinForms.Guna2RadioButton rdo1Thang;
        private Guna.UI2.WinForms.Guna2TextBox txtIDKhachHang;
        private Guna.UI2.WinForms.Guna2Button btnKiemTraID;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna2RadioButton guna2RadioButton6;
        private Guna2RadioButton guna2RadioButton7;
        private Guna2RadioButton guna2RadioButton8;
        private Guna.UI2.WinForms.Guna2RadioButton rdo3Buoi;
        private Guna.UI2.WinForms.Guna2RadioButton rdo8Buoi;
        private Guna.UI2.WinForms.Guna2RadioButton rdo6Buoi;
        private Guna.UI2.WinForms.Guna2RadioButton rdo2Buoi;
        private Guna.UI2.WinForms.Guna2RadioButton rdo1Buoi;
        private Guna.UI2.WinForms.Guna2ComboBox txtLoaiHoaDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnTinhTien;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtThanhTien;
        private System.Windows.Forms.Label txtNhanVien;
        private Guna.UI2.WinForms.Guna2TextBox txtIDNhanVien;
        private Guna2RadioButton guna2RadioButton9;
        private Guna2RadioButton guna2RadioButton10;
        private Guna2ComboBox guna2ComboBox1;
        private Guna2Button guna2Button3;
        private Guna2Button guna2Button1;
    }
}