namespace DAMH_Nhom2_QLPhongGym
{
    partial class frmDatLichTap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDatLich = new Guna.UI2.WinForms.Guna2Button();
            this.cbxDiaChi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DateTimeTU = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTraCuu = new Guna.UI2.WinForms.Guna2Button();
            this.cbxTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.txtSoBuoi = new System.Windows.Forms.TextBox();
            this.btnTim = new Guna.UI2.WinForms.Guna2Button();
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.DateTimeDEN = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvLichTap = new Guna.UI2.WinForms.Guna2DataGridView();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybatdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigianbatdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigianketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.huanluyenvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIDNhanVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichTap)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtIDNhanVien);
            this.panel1.Controls.Add(this.btnDatLich);
            this.panel1.Controls.Add(this.cbxDiaChi);
            this.panel1.Controls.Add(this.DateTimeTU);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnTraCuu);
            this.panel1.Controls.Add(this.cbxTrangThai);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtTenKhach);
            this.panel1.Controls.Add(this.txtSoBuoi);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.txtMaKhach);
            this.panel1.Controls.Add(this.DateTimeDEN);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dgvLichTap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 747);
            this.panel1.TabIndex = 1;
            // 
            // btnDatLich
            // 
            this.btnDatLich.BorderRadius = 10;
            this.btnDatLich.FillColor = System.Drawing.Color.LightSlateGray;
            this.btnDatLich.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLich.ForeColor = System.Drawing.Color.White;
            this.btnDatLich.Image = global::DAMH_Nhom2_QLPhongGym.Properties.Resources.iconAdd;
            this.btnDatLich.Location = new System.Drawing.Point(1067, 148);
            this.btnDatLich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDatLich.Name = "btnDatLich";
            this.btnDatLich.Size = new System.Drawing.Size(161, 46);
            this.btnDatLich.TabIndex = 44;
            this.btnDatLich.Text = "Đặt lịch";
            this.btnDatLich.Click += new System.EventHandler(this.btnDatLich_Click_1);
            // 
            // cbxDiaChi
            // 
            this.cbxDiaChi.BackColor = System.Drawing.Color.Transparent;
            this.cbxDiaChi.BorderRadius = 10;
            this.cbxDiaChi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxDiaChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDiaChi.FocusedColor = System.Drawing.Color.Empty;
            this.cbxDiaChi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxDiaChi.FormattingEnabled = true;
            this.cbxDiaChi.ItemHeight = 30;
            this.cbxDiaChi.Location = new System.Drawing.Point(528, 15);
            this.cbxDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxDiaChi.Name = "cbxDiaChi";
            this.cbxDiaChi.Size = new System.Drawing.Size(228, 36);
            this.cbxDiaChi.TabIndex = 43;
            // 
            // DateTimeTU
            // 
            this.DateTimeTU.BorderRadius = 10;
            this.DateTimeTU.Checked = true;
            this.DateTimeTU.FillColor = System.Drawing.Color.WhiteSmoke;
            this.DateTimeTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimeTU.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimeTU.Location = new System.Drawing.Point(136, 15);
            this.DateTimeTU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTimeTU.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimeTU.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimeTU.Name = "DateTimeTU";
            this.DateTimeTU.Size = new System.Drawing.Size(260, 44);
            this.DateTimeTU.TabIndex = 42;
            this.DateTimeTU.Value = new System.DateTime(2024, 10, 29, 9, 28, 33, 345);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(432, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 41;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(929, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Số buổi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(48, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Từ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(868, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 46;
            this.label5.Text = "Họ tên khách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(48, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Lịch tập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(868, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 25);
            this.label8.TabIndex = 57;
            this.label8.Text = "ID:";
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BorderRadius = 10;
            this.btnTraCuu.FillColor = System.Drawing.Color.LightSlateGray;
            this.btnTraCuu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.ForeColor = System.Drawing.Color.White;
            this.btnTraCuu.Image = global::DAMH_Nhom2_QLPhongGym.Properties.Resources.iconNhap;
            this.btnTraCuu.Location = new System.Drawing.Point(616, 145);
            this.btnTraCuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(140, 52);
            this.btnTraCuu.TabIndex = 56;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click_1);
            // 
            // cbxTrangThai
            // 
            this.cbxTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cbxTrangThai.BorderRadius = 10;
            this.cbxTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTrangThai.FocusedColor = System.Drawing.Color.Empty;
            this.cbxTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxTrangThai.FormattingEnabled = true;
            this.cbxTrangThai.ItemHeight = 30;
            this.cbxTrangThai.Location = new System.Drawing.Point(569, 79);
            this.cbxTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxTrangThai.Name = "cbxTrangThai";
            this.cbxTrangThai.Size = new System.Drawing.Size(185, 36);
            this.cbxTrangThai.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(432, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 25);
            this.label7.TabIndex = 54;
            this.label7.Text = "Trạng thái:";
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Enabled = false;
            this.txtTenKhach.Location = new System.Drawing.Point(1040, 66);
            this.txtTenKhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(187, 22);
            this.txtTenKhach.TabIndex = 52;
            // 
            // txtSoBuoi
            // 
            this.txtSoBuoi.Enabled = false;
            this.txtSoBuoi.Location = new System.Drawing.Point(1040, 111);
            this.txtSoBuoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoBuoi.Name = "txtSoBuoi";
            this.txtSoBuoi.Size = new System.Drawing.Size(187, 22);
            this.txtSoBuoi.TabIndex = 51;
            // 
            // btnTim
            // 
            this.btnTim.BorderRadius = 10;
            this.btnTim.FillColor = System.Drawing.Color.LightSlateGray;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Image = global::DAMH_Nhom2_QLPhongGym.Properties.Resources.iconFind2;
            this.btnTim.Location = new System.Drawing.Point(1116, 11);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(119, 46);
            this.btnTim.TabIndex = 50;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.Location = new System.Drawing.Point(923, 21);
            this.txtMaKhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(187, 22);
            this.txtMaKhach.TabIndex = 49;
            // 
            // DateTimeDEN
            // 
            this.DateTimeDEN.BorderRadius = 10;
            this.DateTimeDEN.Checked = true;
            this.DateTimeDEN.FillColor = System.Drawing.Color.WhiteSmoke;
            this.DateTimeDEN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimeDEN.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimeDEN.Location = new System.Drawing.Point(136, 79);
            this.DateTimeDEN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTimeDEN.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimeDEN.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimeDEN.Name = "DateTimeDEN";
            this.DateTimeDEN.Size = new System.Drawing.Size(260, 44);
            this.DateTimeDEN.TabIndex = 48;
            this.DateTimeDEN.Value = new System.DateTime(2024, 10, 29, 9, 28, 33, 345);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(48, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "Đến:";
            // 
            // dgvLichTap
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvLichTap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLichTap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLichTap.ColumnHeadersHeight = 27;
            this.dgvLichTap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvLichTap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trangthai,
            this.ngaybatdau,
            this.thoigianbatdau,
            this.thoigianketthuc,
            this.huanluyenvien});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLichTap.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLichTap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLichTap.Location = new System.Drawing.Point(34, 221);
            this.dgvLichTap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLichTap.Name = "dgvLichTap";
            this.dgvLichTap.RowHeadersVisible = false;
            this.dgvLichTap.RowHeadersWidth = 51;
            this.dgvLichTap.RowTemplate.Height = 24;
            this.dgvLichTap.Size = new System.Drawing.Size(1257, 454);
            this.dgvLichTap.TabIndex = 45;
            this.dgvLichTap.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLichTap.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLichTap.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLichTap.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLichTap.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLichTap.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvLichTap.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLichTap.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvLichTap.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLichTap.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvLichTap.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLichTap.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvLichTap.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvLichTap.ThemeStyle.ReadOnly = false;
            this.dgvLichTap.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLichTap.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLichTap.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvLichTap.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLichTap.ThemeStyle.RowsStyle.Height = 24;
            this.dgvLichTap.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLichTap.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "TrangThai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            this.trangthai.ReadOnly = true;
            // 
            // ngaybatdau
            // 
            this.ngaybatdau.DataPropertyName = "NgayBatDau";
            this.ngaybatdau.HeaderText = "Ngày bắt đầu";
            this.ngaybatdau.MinimumWidth = 6;
            this.ngaybatdau.Name = "ngaybatdau";
            // 
            // thoigianbatdau
            // 
            this.thoigianbatdau.DataPropertyName = "ThoiGianBatDau";
            this.thoigianbatdau.HeaderText = "Thời gian bắt đầu";
            this.thoigianbatdau.MinimumWidth = 6;
            this.thoigianbatdau.Name = "thoigianbatdau";
            this.thoigianbatdau.ReadOnly = true;
            // 
            // thoigianketthuc
            // 
            this.thoigianketthuc.DataPropertyName = "ThoiGianKetThuc";
            this.thoigianketthuc.HeaderText = "Thời gian kết thúc";
            this.thoigianketthuc.MinimumWidth = 6;
            this.thoigianketthuc.Name = "thoigianketthuc";
            this.thoigianketthuc.ReadOnly = true;
            // 
            // huanluyenvien
            // 
            this.huanluyenvien.DataPropertyName = "HuanLuyenVien";
            this.huanluyenvien.HeaderText = "Huấn luyện viên";
            this.huanluyenvien.MinimumWidth = 6;
            this.huanluyenvien.Name = "huanluyenvien";
            this.huanluyenvien.ReadOnly = true;
            // 
            // txtIDNhanVien
            // 
            this.txtIDNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDNhanVien.DefaultText = "";
            this.txtIDNhanVien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDNhanVien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDNhanVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDNhanVien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDNhanVien.Location = new System.Drawing.Point(115, 695);
            this.txtIDNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDNhanVien.Name = "txtIDNhanVien";
            this.txtIDNhanVien.PasswordChar = '\0';
            this.txtIDNhanVien.PlaceholderText = "";
            this.txtIDNhanVien.SelectedText = "";
            this.txtIDNhanVien.Size = new System.Drawing.Size(229, 35);
            this.txtIDNhanVien.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(21, 695);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 59;
            this.label9.Text = "Xin chào:";
            // 
            // frmDatLichTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1344, 747);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1362, 794);
            this.Name = "frmDatLichTap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDatLichTap";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichTap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnDatLich;
        private Guna.UI2.WinForms.Guna2ComboBox cbxDiaChi;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimeTU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btnTraCuu;
        private Guna.UI2.WinForms.Guna2ComboBox cbxTrangThai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.TextBox txtSoBuoi;
        private Guna.UI2.WinForms.Guna2Button btnTim;
        private System.Windows.Forms.TextBox txtMaKhach;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimeDEN;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLichTap;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybatdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigianbatdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigianketthuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn huanluyenvien;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtIDNhanVien;
    }
}