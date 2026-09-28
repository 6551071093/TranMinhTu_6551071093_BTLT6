namespace UngDungDatPhongKhachSan_2
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
            lbl_HoTen = new Label();
            lbl_CCCD = new Label();
            lbl_NgayNhan = new Label();
            lbl_NgayTra = new Label();
            lbl_SoNguoiLon = new Label();
            label6 = new Label();
            txt_HoTen = new TextBox();
            txt_CCCD = new TextBox();
            txt_NgayNhan = new TextBox();
            txt_NgayTra = new TextBox();
            txt_SoNguoiLon = new TextBox();
            txt_SoTreEm = new TextBox();
            btn_DatPhong = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lbl_HoTen
            // 
            lbl_HoTen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_HoTen.AutoSize = true;
            lbl_HoTen.Location = new Point(168, 31);
            lbl_HoTen.Name = "lbl_HoTen";
            lbl_HoTen.Size = new Size(57, 20);
            lbl_HoTen.TabIndex = 0;
            lbl_HoTen.Text = "Họ tên:";
            // 
            // lbl_CCCD
            // 
            lbl_CCCD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_CCCD.AutoSize = true;
            lbl_CCCD.Location = new Point(165, 84);
            lbl_CCCD.Name = "lbl_CCCD";
            lbl_CCCD.Size = new Size(50, 20);
            lbl_CCCD.TabIndex = 1;
            lbl_CCCD.Text = "CCCD:";
            // 
            // lbl_NgayNhan
            // 
            lbl_NgayNhan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_NgayNhan.AutoSize = true;
            lbl_NgayNhan.Location = new Point(168, 137);
            lbl_NgayNhan.Name = "lbl_NgayNhan";
            lbl_NgayNhan.Size = new Size(83, 20);
            lbl_NgayNhan.TabIndex = 2;
            lbl_NgayNhan.Text = "Ngày nhận:";
            // 
            // lbl_NgayTra
            // 
            lbl_NgayTra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_NgayTra.AutoSize = true;
            lbl_NgayTra.Location = new Point(168, 200);
            lbl_NgayTra.Name = "lbl_NgayTra";
            lbl_NgayTra.Size = new Size(69, 20);
            lbl_NgayTra.TabIndex = 3;
            lbl_NgayTra.Text = "Ngày trả:";
            // 
            // lbl_SoNguoiLon
            // 
            lbl_SoNguoiLon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_SoNguoiLon.AutoSize = true;
            lbl_SoNguoiLon.Location = new Point(168, 253);
            lbl_SoNguoiLon.Name = "lbl_SoNguoiLon";
            lbl_SoNguoiLon.Size = new Size(97, 20);
            lbl_SoNguoiLon.TabIndex = 4;
            lbl_SoNguoiLon.Text = "Số người lớn:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(168, 306);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 5;
            label6.Text = "Số trẻ em:";
            // 
            // txt_HoTen
            // 
            txt_HoTen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_HoTen.Location = new Point(168, 54);
            txt_HoTen.Name = "txt_HoTen";
            txt_HoTen.Size = new Size(321, 27);
            txt_HoTen.TabIndex = 6;
            txt_HoTen.Validating += txt_HoTen_Validating;
            txt_HoTen.Validated += txt_HoTen_Validated;
            // 
            // txt_CCCD
            // 
            txt_CCCD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_CCCD.Location = new Point(168, 107);
            txt_CCCD.Name = "txt_CCCD";
            txt_CCCD.Size = new Size(321, 27);
            txt_CCCD.TabIndex = 7;
            txt_CCCD.Validating += txt_CCCD_Validating;
            txt_CCCD.Validated += txt_CCCD_Validated;
            // 
            // txt_NgayNhan
            // 
            txt_NgayNhan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_NgayNhan.Location = new Point(168, 170);
            txt_NgayNhan.Name = "txt_NgayNhan";
            txt_NgayNhan.Size = new Size(321, 27);
            txt_NgayNhan.TabIndex = 8;
            txt_NgayNhan.Validating += txt_NgayNhan_Validating;
            txt_NgayNhan.Validated += txt_NgayNhan_Validated;
            // 
            // txt_NgayTra
            // 
            txt_NgayTra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_NgayTra.BackColor = SystemColors.Window;
            txt_NgayTra.Location = new Point(168, 223);
            txt_NgayTra.Name = "txt_NgayTra";
            txt_NgayTra.Size = new Size(321, 27);
            txt_NgayTra.TabIndex = 9;
            txt_NgayTra.Validating += txt_NgayTra_Validating;
            txt_NgayTra.Validated += txt_NgayTra_Validated;
            // 
            // txt_SoNguoiLon
            // 
            txt_SoNguoiLon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_SoNguoiLon.Location = new Point(168, 276);
            txt_SoNguoiLon.Name = "txt_SoNguoiLon";
            txt_SoNguoiLon.Size = new Size(321, 27);
            txt_SoNguoiLon.TabIndex = 10;
            txt_SoNguoiLon.Validating += txt_SoNguoiLon_Validating;
            txt_SoNguoiLon.Validated += txt_SoNguoiLon_Validated;
            // 
            // txt_SoTreEm
            // 
            txt_SoTreEm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_SoTreEm.Location = new Point(168, 329);
            txt_SoTreEm.Name = "txt_SoTreEm";
            txt_SoTreEm.Size = new Size(321, 27);
            txt_SoTreEm.TabIndex = 11;
            txt_SoTreEm.Validating += txt_SoTreEm_Validating;
            txt_SoTreEm.Validated += txt_SoTreEm_Validated;
            // 
            // btn_DatPhong
            // 
            btn_DatPhong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_DatPhong.BackColor = Color.DodgerBlue;
            btn_DatPhong.ForeColor = SystemColors.Window;
            btn_DatPhong.Location = new Point(168, 362);
            btn_DatPhong.Name = "btn_DatPhong";
            btn_DatPhong.Size = new Size(321, 52);
            btn_DatPhong.TabIndex = 12;
            btn_DatPhong.Text = "Đặt Phòng";
            btn_DatPhong.UseVisualStyleBackColor = false;
            btn_DatPhong.Click += btn_DatPhong_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frm_MainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(672, 461);
            Controls.Add(btn_DatPhong);
            Controls.Add(txt_SoTreEm);
            Controls.Add(txt_SoNguoiLon);
            Controls.Add(txt_NgayTra);
            Controls.Add(txt_NgayNhan);
            Controls.Add(txt_CCCD);
            Controls.Add(txt_HoTen);
            Controls.Add(label6);
            Controls.Add(lbl_SoNguoiLon);
            Controls.Add(lbl_NgayTra);
            Controls.Add(lbl_NgayNhan);
            Controls.Add(lbl_CCCD);
            Controls.Add(lbl_HoTen);
            Name = "frm_MainScreen";
            Text = "FormDatPhong";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_HoTen;
        private Label lbl_CCCD;
        private Label lbl_NgayNhan;
        private Label lbl_NgayTra;
        private Label lbl_SoNguoiLon;
        private Label label6;
        private TextBox txt_HoTen;
        private TextBox txt_CCCD;
        private TextBox txt_NgayNhan;
        private TextBox txt_NgayTra;
        private TextBox txt_SoNguoiLon;
        private TextBox txt_SoTreEm;
        private Button btn_DatPhong;
        private ErrorProvider errorProvider1;
    }
}
