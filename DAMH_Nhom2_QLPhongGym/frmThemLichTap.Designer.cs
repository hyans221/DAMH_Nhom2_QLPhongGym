namespace DAMH_Nhom2_QLPhongGym
{
    partial class frmThemLichTap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxDiaChi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DateTimeTU = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DateTimeDEN = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvLichTap = new Guna.UI2.WinForms.Guna2DataGridView();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybatdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigianbatdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigianketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.huanluyenvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.cbxPT = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTraCuu = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.time1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.time2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichTap)).BeginInit();
            this.guna2ShadowPanel2.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(340, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 26);
            this.label4.TabIndex = 42;
            this.label4.Text = "THÊM LỊCH TẬP";
            // 
            // cbxDiaChi
            // 
            this.cbxDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxDiaChi.BackColor = System.Drawing.Color.Transparent;
            this.cbxDiaChi.BorderRadius = 10;
            this.cbxDiaChi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxDiaChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDiaChi.FocusedColor = System.Drawing.Color.Empty;
            this.cbxDiaChi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxDiaChi.FormattingEnabled = true;
            this.cbxDiaChi.ItemHeight = 30;
            this.cbxDiaChi.Location = new System.Drawing.Point(117, 89);
            this.cbxDiaChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxDiaChi.Name = "cbxDiaChi";
            this.cbxDiaChi.Size = new System.Drawing.Size(181, 36);
            this.cbxDiaChi.TabIndex = 60;
            // 
            // DateTimeTU
            // 
            this.DateTimeTU.BorderRadius = 10;
            this.DateTimeTU.Checked = true;
            this.DateTimeTU.FillColor = System.Drawing.Color.White;
            this.DateTimeTU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimeTU.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimeTU.Location = new System.Drawing.Point(89, 113);
            this.DateTimeTU.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DateTimeTU.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimeTU.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimeTU.Name = "DateTimeTU";
            this.DateTimeTU.Size = new System.Drawing.Size(245, 36);
            this.DateTimeTU.TabIndex = 59;
            this.DateTimeTU.Value = new System.DateTime(2024, 10, 29, 9, 28, 33, 345);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(14, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 58;
            this.label1.Text = "Chi nhánh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 22);
            this.label2.TabIndex = 57;
            this.label2.Text = "Từ:";
            // 
            // cbxTrangThai
            // 
            this.cbxTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cbxTrangThai.BorderRadius = 10;
            this.cbxTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTrangThai.FocusedColor = System.Drawing.Color.Empty;
            this.cbxTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxTrangThai.FormattingEnabled = true;
            this.cbxTrangThai.ItemHeight = 30;
            this.cbxTrangThai.Location = new System.Drawing.Point(117, 147);
            this.cbxTrangThai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxTrangThai.Name = "cbxTrangThai";
            this.cbxTrangThai.Size = new System.Drawing.Size(181, 36);
            this.cbxTrangThai.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(14, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 22);
            this.label7.TabIndex = 64;
            this.label7.Text = "Trạng thái:";
            // 
            // DateTimeDEN
            // 
            this.DateTimeDEN.BorderRadius = 10;
            this.DateTimeDEN.Checked = true;
            this.DateTimeDEN.FillColor = System.Drawing.Color.White;
            this.DateTimeDEN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimeDEN.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimeDEN.Location = new System.Drawing.Point(89, 165);
            this.DateTimeDEN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DateTimeDEN.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimeDEN.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimeDEN.Name = "DateTimeDEN";
            this.DateTimeDEN.Size = new System.Drawing.Size(245, 36);
            this.DateTimeDEN.TabIndex = 63;
            this.DateTimeDEN.Value = new System.DateTime(2024, 10, 29, 9, 28, 33, 345);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 22);
            this.label6.TabIndex = 62;
            this.label6.Text = "Đến:";
            // 
            // dgvLichTap
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgvLichTap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvLichTap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLichTap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvLichTap.ColumnHeadersHeight = 27;
            this.dgvLichTap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvLichTap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trangthai,
            this.ngaybatdau,
            this.thoigianbatdau,
            this.thoigianketthuc,
            this.huanluyenvien});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLichTap.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvLichTap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLichTap.Location = new System.Drawing.Point(9, 270);
            this.dgvLichTap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvLichTap.Name = "dgvLichTap";
            this.dgvLichTap.RowHeadersVisible = false;
            this.dgvLichTap.RowHeadersWidth = 51;
            this.dgvLichTap.RowTemplate.Height = 24;
            this.dgvLichTap.Size = new System.Drawing.Size(878, 315);
            this.dgvLichTap.TabIndex = 61;
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
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BorderRadius = 10;
            this.btnThem.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = global::DAMH_Nhom2_QLPhongGym.Properties.Resources.iconNhap2;
            this.btnThem.Location = new System.Drawing.Point(333, 113);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(105, 49);
            this.btnThem.TabIndex = 66;
            this.btnThem.Text = "THÊM";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbxPT
            // 
            this.cbxPT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPT.BackColor = System.Drawing.Color.Transparent;
            this.cbxPT.BorderRadius = 10;
            this.cbxPT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxPT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPT.FocusedColor = System.Drawing.Color.Empty;
            this.cbxPT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxPT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxPT.FormattingEnabled = true;
            this.cbxPT.ItemHeight = 30;
            this.cbxPT.Location = new System.Drawing.Point(163, 31);
            this.cbxPT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxPT.Name = "cbxPT";
            this.cbxPT.Size = new System.Drawing.Size(135, 36);
            this.cbxPT.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(14, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 22);
            this.label3.TabIndex = 68;
            this.label3.Text = "Huấn luyện viên:";
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuu.BorderRadius = 10;
            this.btnTraCuu.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnTraCuu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.ForeColor = System.Drawing.Color.Black;
            this.btnTraCuu.Image = global::DAMH_Nhom2_QLPhongGym.Properties.Resources.iconFix;
            this.btnTraCuu.Location = new System.Drawing.Point(333, 41);
            this.btnTraCuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(105, 49);
            this.btnTraCuu.TabIndex = 69;
            this.btnTraCuu.Text = "Tra cứu:";
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 22);
            this.label5.TabIndex = 72;
            this.label5.Text = "Thời gian bắt đầu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(16, 71);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 22);
            this.label8.TabIndex = 73;
            this.label8.Text = "Thời gian kết thúc:";
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.time2);
            this.guna2ShadowPanel2.Controls.Add(this.label8);
            this.guna2ShadowPanel2.Controls.Add(this.time1);
            this.guna2ShadowPanel2.Controls.Add(this.label5);
            this.guna2ShadowPanel2.Controls.Add(this.label6);
            this.guna2ShadowPanel2.Controls.Add(this.DateTimeDEN);
            this.guna2ShadowPanel2.Controls.Add(this.label2);
            this.guna2ShadowPanel2.Controls.Add(this.DateTimeTU);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.LightSlateGray;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(9, 51);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.Radius = 10;
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(415, 212);
            this.guna2ShadowPanel2.TabIndex = 74;
            // 
            // time1
            // 
            this.time1.BorderRadius = 10;
            this.time1.Checked = true;
            this.time1.FillColor = System.Drawing.Color.White;
            this.time1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.time1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.time1.Location = new System.Drawing.Point(190, 17);
            this.time1.Margin = new System.Windows.Forms.Padding(2);
            this.time1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.time1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(204, 36);
            this.time1.TabIndex = 60;
            this.time1.Value = new System.DateTime(2024, 10, 29, 9, 28, 33, 345);
            // 
            // time2
            // 
            this.time2.BorderRadius = 10;
            this.time2.Checked = true;
            this.time2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.time2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.time2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.time2.Location = new System.Drawing.Point(190, 64);
            this.time2.Margin = new System.Windows.Forms.Padding(2);
            this.time2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.time2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(204, 36);
            this.time2.TabIndex = 61;
            this.time2.Value = new System.DateTime(2024, 10, 29, 9, 28, 33, 345);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.btnTraCuu);
            this.guna2ShadowPanel1.Controls.Add(this.cbxPT);
            this.guna2ShadowPanel1.Controls.Add(this.cbxTrangThai);
            this.guna2ShadowPanel1.Controls.Add(this.label3);
            this.guna2ShadowPanel1.Controls.Add(this.label7);
            this.guna2ShadowPanel1.Controls.Add(this.btnThem);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.cbxDiaChi);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.LightSlateGray;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(430, 51);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(457, 212);
            this.guna2ShadowPanel1.TabIndex = 75;
            // 
            // frmThemLichTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(896, 592);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.guna2ShadowPanel2);
            this.Controls.Add(this.dgvLichTap);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmThemLichTap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemLichTap";
            this.Load += new System.EventHandler(this.frmThemLichTap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichTap)).EndInit();
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbxDiaChi;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimeTU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2ComboBox cbxTrangThai;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimeDEN;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLichTap;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybatdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigianbatdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigianketthuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn huanluyenvien;
        private Guna.UI2.WinForms.Guna2ComboBox cbxPT;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnTraCuu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2DateTimePicker time2;
        private Guna.UI2.WinForms.Guna2DateTimePicker time1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
    }
}