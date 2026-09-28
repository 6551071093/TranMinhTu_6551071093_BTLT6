namespace UngDungGiaoDoAn_1
{
    partial class frm_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbl_HoTen = new Label();
            txt_HoTen = new TextBox();
            txt_SDT = new TextBox();
            txt_Email = new TextBox();
            txt_MatKhau = new TextBox();
            txt_XacNhanMatKhau = new TextBox();
            lbl_SDT = new Label();
            lbl_Email = new Label();
            lbl_MatKhau = new Label();
            lbl_XacNhanMK = new Label();
            errorProvider1 = new ErrorProvider(components);
            btn_DangKy = new Button();
            btn_Huy = new Button();
            lbl_DangKy = new Label();
            lbl_GhiChu = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lbl_HoTen
            // 
            lbl_HoTen.AutoSize = true;
            lbl_HoTen.Location = new Point(139, 159);
            lbl_HoTen.Name = "lbl_HoTen";
            lbl_HoTen.Size = new Size(59, 20);
            lbl_HoTen.TabIndex = 0;
            lbl_HoTen.Text = "Họ Tên:";
            // 
            // txt_HoTen
            // 
            txt_HoTen.Location = new Point(250, 156);
            txt_HoTen.Name = "txt_HoTen";
            txt_HoTen.Size = new Size(194, 27);
            txt_HoTen.TabIndex = 1;
            // 
            // txt_SDT
            // 
            txt_SDT.Location = new Point(250, 207);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new Size(194, 27);
            txt_SDT.TabIndex = 2;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(250, 251);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(194, 27);
            txt_Email.TabIndex = 3;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Location = new Point(250, 297);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.PasswordChar = '*';
            txt_MatKhau.Size = new Size(194, 27);
            txt_MatKhau.TabIndex = 4;
            // 
            // txt_XacNhanMatKhau
            // 
            txt_XacNhanMatKhau.Location = new Point(250, 344);
            txt_XacNhanMatKhau.Name = "txt_XacNhanMatKhau";
            txt_XacNhanMatKhau.Size = new Size(194, 27);
            txt_XacNhanMatKhau.TabIndex = 5;
            // 
            // lbl_SDT
            // 
            lbl_SDT.AutoSize = true;
            lbl_SDT.Location = new Point(150, 214);
            lbl_SDT.Name = "lbl_SDT";
            lbl_SDT.Size = new Size(38, 20);
            lbl_SDT.TabIndex = 6;
            lbl_SDT.Text = "SDT:";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new Point(139, 258);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(49, 20);
            lbl_Email.TabIndex = 7;
            lbl_Email.Text = "Email:";
            // 
            // lbl_MatKhau
            // 
            lbl_MatKhau.AutoSize = true;
            lbl_MatKhau.Location = new Point(113, 304);
            lbl_MatKhau.Name = "lbl_MatKhau";
            lbl_MatKhau.Size = new Size(75, 20);
            lbl_MatKhau.TabIndex = 8;
            lbl_MatKhau.Text = "Mật Khẩu:";
            // 
            // lbl_XacNhanMK
            // 
            lbl_XacNhanMK.AutoSize = true;
            lbl_XacNhanMK.Location = new Point(46, 351);
            lbl_XacNhanMK.Name = "lbl_XacNhanMK";
            lbl_XacNhanMK.Size = new Size(142, 20);
            lbl_XacNhanMK.TabIndex = 9;
            lbl_XacNhanMK.Text = "Xác Nhận Mật Khẩu:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btn_DangKy
            // 
            btn_DangKy.BackColor = Color.DodgerBlue;
            btn_DangKy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_DangKy.ForeColor = SystemColors.ControlLightLight;
            btn_DangKy.Location = new Point(223, 399);
            btn_DangKy.Name = "btn_DangKy";
            btn_DangKy.Size = new Size(94, 29);
            btn_DangKy.TabIndex = 10;
            btn_DangKy.Text = "Đăng Ký";
            btn_DangKy.UseVisualStyleBackColor = false;
            btn_DangKy.Click += btn_DangKy_Click;
            // 
            // btn_Huy
            // 
            btn_Huy.BackColor = SystemColors.ControlDark;
            btn_Huy.CausesValidation = false;
            btn_Huy.Location = new Point(350, 399);
            btn_Huy.Name = "btn_Huy";
            btn_Huy.Size = new Size(94, 29);
            btn_Huy.TabIndex = 11;
            btn_Huy.Text = "Hủy";
            btn_Huy.UseVisualStyleBackColor = false;
            btn_Huy.Click += btn_Huy_Click;
            // 
            // lbl_DangKy
            // 
            lbl_DangKy.AutoSize = true;
            lbl_DangKy.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lbl_DangKy.Location = new Point(33, 27);
            lbl_DangKy.Name = "lbl_DangKy";
            lbl_DangKy.Size = new Size(327, 40);
            lbl_DangKy.TabIndex = 12;
            lbl_DangKy.Text = "Đăng ký tài khoản mới";
            // 
            // lbl_GhiChu
            // 
            lbl_GhiChu.AutoSize = true;
            lbl_GhiChu.Location = new Point(33, 79);
            lbl_GhiChu.Name = "lbl_GhiChu";
            lbl_GhiChu.Size = new Size(214, 20);
            lbl_GhiChu.TabIndex = 13;
            lbl_GhiChu.Text = "Vui lòng nhập đầy đủ thông tin";
            // 
            // frm_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 461);
            Controls.Add(lbl_GhiChu);
            Controls.Add(lbl_DangKy);
            Controls.Add(btn_Huy);
            Controls.Add(btn_DangKy);
            Controls.Add(lbl_XacNhanMK);
            Controls.Add(lbl_MatKhau);
            Controls.Add(lbl_Email);
            Controls.Add(lbl_SDT);
            Controls.Add(txt_XacNhanMatKhau);
            Controls.Add(txt_MatKhau);
            Controls.Add(txt_Email);
            Controls.Add(txt_SDT);
            Controls.Add(txt_HoTen);
            Controls.Add(lbl_HoTen);
            Name = "frm_Login";
            Text = "FormDangKy";
            Load += frm_Login_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_HoTen;
        private TextBox txt_HoTen;
        private TextBox txt_SDT;
        private TextBox txt_Email;
        private TextBox txt_MatKhau;
        private TextBox txt_XacNhanMatKhau;
        private Label lbl_SDT;
        private Label lbl_Email;
        private Label lbl_MatKhau;
        private Label lbl_XacNhanMK;
        private ErrorProvider errorProvider1;
        private Button btn_Huy;
        private Button btn_DangKy;
        private Label lbl_GhiChu;
        private Label lbl_DangKy;
    }
}
