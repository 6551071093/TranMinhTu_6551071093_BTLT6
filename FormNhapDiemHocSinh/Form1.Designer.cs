namespace FormNhapDiemHocSinh
{
    partial class frm_MainScreen
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
            txt_MaHS = new TextBox();
            txt_HoTen = new TextBox();
            txt_Toan = new TextBox();
            txt_Van = new TextBox();
            txt_Anh = new TextBox();
            btn_Luu = new Button();
            btn_XoaTrang = new Button();
            lbl_MaHS = new Label();
            lbl_HoTen = new Label();
            lbl_Toan = new Label();
            lbl_Van = new Label();
            lbl_Anh = new Label();
            lst_DanhSach = new ListBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txt_MaHS
            // 
            txt_MaHS.Location = new Point(12, 32);
            txt_MaHS.Name = "txt_MaHS";
            txt_MaHS.Size = new Size(78, 27);
            txt_MaHS.TabIndex = 0;
            // 
            // txt_HoTen
            // 
            txt_HoTen.Location = new Point(127, 32);
            txt_HoTen.Name = "txt_HoTen";
            txt_HoTen.Size = new Size(113, 27);
            txt_HoTen.TabIndex = 1;
            // 
            // txt_Toan
            // 
            txt_Toan.Location = new Point(285, 32);
            txt_Toan.Name = "txt_Toan";
            txt_Toan.Size = new Size(76, 27);
            txt_Toan.TabIndex = 2;
            // 
            // txt_Van
            // 
            txt_Van.Location = new Point(414, 32);
            txt_Van.Name = "txt_Van";
            txt_Van.Size = new Size(76, 27);
            txt_Van.TabIndex = 3;
            // 
            // txt_Anh
            // 
            txt_Anh.Location = new Point(528, 32);
            txt_Anh.Name = "txt_Anh";
            txt_Anh.Size = new Size(76, 27);
            txt_Anh.TabIndex = 4;
            // 
            // btn_Luu
            // 
            btn_Luu.BackColor = Color.LimeGreen;
            btn_Luu.Location = new Point(12, 75);
            btn_Luu.Name = "btn_Luu";
            btn_Luu.Size = new Size(94, 43);
            btn_Luu.TabIndex = 5;
            btn_Luu.Text = "Lưu";
            btn_Luu.UseVisualStyleBackColor = false;
            btn_Luu.Click += btn_Luu_Click;
            // 
            // btn_XoaTrang
            // 
            btn_XoaTrang.BackColor = SystemColors.ControlDark;
            btn_XoaTrang.Location = new Point(112, 75);
            btn_XoaTrang.Name = "btn_XoaTrang";
            btn_XoaTrang.Size = new Size(112, 43);
            btn_XoaTrang.TabIndex = 6;
            btn_XoaTrang.Text = "Xóa trắng";
            btn_XoaTrang.UseVisualStyleBackColor = false;
            btn_XoaTrang.Click += btn_XoaTrang_Click;
            // 
            // lbl_MaHS
            // 
            lbl_MaHS.AutoSize = true;
            lbl_MaHS.Location = new Point(12, 9);
            lbl_MaHS.Name = "lbl_MaHS";
            lbl_MaHS.Size = new Size(56, 20);
            lbl_MaHS.TabIndex = 7;
            lbl_MaHS.Text = "Mã HS:";
            // 
            // lbl_HoTen
            // 
            lbl_HoTen.AutoSize = true;
            lbl_HoTen.Location = new Point(127, 9);
            lbl_HoTen.Name = "lbl_HoTen";
            lbl_HoTen.Size = new Size(54, 20);
            lbl_HoTen.TabIndex = 8;
            lbl_HoTen.Text = "Họ tên";
            // 
            // lbl_Toan
            // 
            lbl_Toan.AutoSize = true;
            lbl_Toan.Location = new Point(285, 9);
            lbl_Toan.Name = "lbl_Toan";
            lbl_Toan.Size = new Size(82, 20);
            lbl_Toan.TabIndex = 9;
            lbl_Toan.Text = "Điểm toán:";
            // 
            // lbl_Van
            // 
            lbl_Van.AutoSize = true;
            lbl_Van.Location = new Point(414, 9);
            lbl_Van.Name = "lbl_Van";
            lbl_Van.Size = new Size(75, 20);
            lbl_Van.TabIndex = 10;
            lbl_Van.Text = "Điểm văn:";
            // 
            // lbl_Anh
            // 
            lbl_Anh.AutoSize = true;
            lbl_Anh.Location = new Point(528, 9);
            lbl_Anh.Name = "lbl_Anh";
            lbl_Anh.Size = new Size(76, 20);
            lbl_Anh.TabIndex = 11;
            lbl_Anh.Text = "Điểm anh:";
            // 
            // lst_DanhSach
            // 
            lst_DanhSach.FormattingEnabled = true;
            lst_DanhSach.Location = new Point(12, 135);
            lst_DanhSach.Name = "lst_DanhSach";
            lst_DanhSach.Size = new Size(625, 304);
            lst_DanhSach.TabIndex = 12;
            lst_DanhSach.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frm_MainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 450);
            Controls.Add(lst_DanhSach);
            Controls.Add(lbl_Anh);
            Controls.Add(lbl_Van);
            Controls.Add(lbl_Toan);
            Controls.Add(lbl_HoTen);
            Controls.Add(lbl_MaHS);
            Controls.Add(btn_XoaTrang);
            Controls.Add(btn_Luu);
            Controls.Add(txt_Anh);
            Controls.Add(txt_Van);
            Controls.Add(txt_Toan);
            Controls.Add(txt_HoTen);
            Controls.Add(txt_MaHS);
            Name = "frm_MainScreen";
            Text = "FormNhapDiem";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_MaHS;
        private TextBox txt_HoTen;
        private TextBox txt_Toan;
        private TextBox txt_Van;
        private TextBox txt_Anh;
        private Button btn_Luu;
        private Button btn_XoaTrang;
        private Label lbl_MaHS;
        private Label lbl_HoTen;
        private Label lbl_Toan;
        private Label lbl_Van;
        private Label lbl_Anh;
        private ListBox lst_DanhSach;
        private ErrorProvider errorProvider1;
    }
}
