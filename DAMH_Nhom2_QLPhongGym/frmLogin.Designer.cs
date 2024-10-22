using System.Drawing;
using System.Windows.Forms;

namespace DAMH_Nhom2_QLPhongGym
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblQuenMK = new System.Windows.Forms.LinkLabel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblDangNhap = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(114, 315);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(205, 40);
            this.btnDangNhap.TabIndex = 14;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(-4, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(62, 463);
            this.panel2.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.lblQuenMK);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.btnDangNhap);
            this.panel1.Controls.Add(this.lblDangNhap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(611, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 461);
            this.panel1.TabIndex = 15;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(114, 204);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(205, 29);
            this.txtUsername.TabIndex = 17;
            // 
            // lblQuenMK
            // 
            this.lblQuenMK.AutoSize = true;
            this.lblQuenMK.LinkColor = System.Drawing.Color.White;
            this.lblQuenMK.Location = new System.Drawing.Point(239, 380);
            this.lblQuenMK.Name = "lblQuenMK";
            this.lblQuenMK.Size = new System.Drawing.Size(80, 13);
            this.lblQuenMK.TabIndex = 16;
            this.lblQuenMK.TabStop = true;
            this.lblQuenMK.Text = "Quên mật khẩu";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(114, 244);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(205, 29);
            this.txtPass.TabIndex = 15;
            // 
            // lblDangNhap
            // 
            this.lblDangNhap.AutoSize = true;
            this.lblDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangNhap.ForeColor = System.Drawing.Color.White;
            this.lblDangNhap.Location = new System.Drawing.Point(62, 113);
            this.lblDangNhap.Name = "lblDangNhap";
            this.lblDangNhap.Size = new System.Drawing.Size(310, 55);
            this.lblDangNhap.TabIndex = 0;
            this.lblDangNhap.Text = "ĐĂNG NHẬP";
            this.lblDangNhap.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Location = new System.Drawing.Point(301, 398);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 34);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Location = new System.Drawing.Point(69, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(609, 582);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 461);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnDangNhap;
        private BindingSource bindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel2;
        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Label lblDangNhap;
        private TextBox txtPass;
        private LinkLabel lblQuenMK;
        private TextBox txtUsername;
        private Button btnBack;
        private PictureBox pictureBox1;
    }

}