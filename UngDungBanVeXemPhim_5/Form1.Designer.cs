namespace UngDungBanVeXemPhim_5
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
            cbo_Phim = new ComboBox();
            cbo_SuatChieu = new ComboBox();
            txt_GheDaChon = new TextBox();
            lbl_TenKhach = new Label();
            imageList1 = new ImageList(components);
            lbl_Phim = new Label();
            lbl_SuatChieu = new Label();
            lbl_GheDaChon = new Label();
            btn_ChonGhe = new Button();
            btn_DatVe = new Button();
            btn_Huy = new Button();
            txt_TenKhach = new TextBox();
            SuspendLayout();
            // 
            // cbo_Phim
            // 
            cbo_Phim.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbo_Phim.FormattingEnabled = true;
            cbo_Phim.Items.AddRange(new object[] { "Avenger: End game", "Bố già", "Your name", "Spiderman: No Way Home" });
            cbo_Phim.Location = new Point(40, 129);
            cbo_Phim.Name = "cbo_Phim";
            cbo_Phim.Size = new Size(258, 28);
            cbo_Phim.TabIndex = 1;
            // 
            // cbo_SuatChieu
            // 
            cbo_SuatChieu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbo_SuatChieu.FormattingEnabled = true;
            cbo_SuatChieu.Items.AddRange(new object[] { "09:00", "14:00", "20:00", "23:30" });
            cbo_SuatChieu.Location = new Point(40, 203);
            cbo_SuatChieu.Name = "cbo_SuatChieu";
            cbo_SuatChieu.Size = new Size(258, 28);
            cbo_SuatChieu.TabIndex = 2;
            // 
            // txt_GheDaChon
            // 
            txt_GheDaChon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_GheDaChon.Location = new Point(40, 284);
            txt_GheDaChon.Name = "txt_GheDaChon";
            txt_GheDaChon.ReadOnly = true;
            txt_GheDaChon.Size = new Size(258, 27);
            txt_GheDaChon.TabIndex = 3;
            // 
            // lbl_TenKhach
            // 
            lbl_TenKhach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_TenKhach.AutoSize = true;
            lbl_TenKhach.Location = new Point(40, 29);
            lbl_TenKhach.Name = "lbl_TenKhach";
            lbl_TenKhach.Size = new Size(74, 20);
            lbl_TenKhach.TabIndex = 4;
            lbl_TenKhach.Text = "Tên khách";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // lbl_Phim
            // 
            lbl_Phim.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_Phim.AutoSize = true;
            lbl_Phim.Location = new Point(40, 106);
            lbl_Phim.Name = "lbl_Phim";
            lbl_Phim.Size = new Size(42, 20);
            lbl_Phim.TabIndex = 5;
            lbl_Phim.Text = "Phim";
            // 
            // lbl_SuatChieu
            // 
            lbl_SuatChieu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_SuatChieu.AutoSize = true;
            lbl_SuatChieu.Location = new Point(40, 180);
            lbl_SuatChieu.Name = "lbl_SuatChieu";
            lbl_SuatChieu.Size = new Size(77, 20);
            lbl_SuatChieu.TabIndex = 6;
            lbl_SuatChieu.Text = "Suất chiếu";
            // 
            // lbl_GheDaChon
            // 
            lbl_GheDaChon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_GheDaChon.AutoSize = true;
            lbl_GheDaChon.Location = new Point(40, 261);
            lbl_GheDaChon.Name = "lbl_GheDaChon";
            lbl_GheDaChon.Size = new Size(92, 20);
            lbl_GheDaChon.TabIndex = 7;
            lbl_GheDaChon.Text = "Ghế đã chọn";
            // 
            // btn_ChonGhe
            // 
            btn_ChonGhe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_ChonGhe.Location = new Point(97, 374);
            btn_ChonGhe.Name = "btn_ChonGhe";
            btn_ChonGhe.Size = new Size(113, 34);
            btn_ChonGhe.TabIndex = 8;
            btn_ChonGhe.Text = "Chọn ghế";
            btn_ChonGhe.UseVisualStyleBackColor = true;
            btn_ChonGhe.Click += btn_ChonGhe_Click;
            // 
            // btn_DatVe
            // 
            btn_DatVe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_DatVe.Location = new Point(243, 374);
            btn_DatVe.Name = "btn_DatVe";
            btn_DatVe.Size = new Size(113, 34);
            btn_DatVe.TabIndex = 9;
            btn_DatVe.Text = "Đặt vé";
            btn_DatVe.UseVisualStyleBackColor = true;
            btn_DatVe.Click += btn_DatVe_Click;
            // 
            // btn_Huy
            // 
            btn_Huy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_Huy.Location = new Point(391, 374);
            btn_Huy.Name = "btn_Huy";
            btn_Huy.Size = new Size(113, 34);
            btn_Huy.TabIndex = 10;
            btn_Huy.Text = "Hủy";
            btn_Huy.UseVisualStyleBackColor = true;
            btn_Huy.Click += btn_Huy_Click;
            // 
            // txt_TenKhach
            // 
            txt_TenKhach.Location = new Point(40, 52);
            txt_TenKhach.Name = "txt_TenKhach";
            txt_TenKhach.Size = new Size(258, 27);
            txt_TenKhach.TabIndex = 11;
            // 
            // frm_MainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 441);
            Controls.Add(txt_TenKhach);
            Controls.Add(btn_Huy);
            Controls.Add(btn_DatVe);
            Controls.Add(btn_ChonGhe);
            Controls.Add(lbl_GheDaChon);
            Controls.Add(lbl_SuatChieu);
            Controls.Add(lbl_Phim);
            Controls.Add(lbl_TenKhach);
            Controls.Add(txt_GheDaChon);
            Controls.Add(cbo_SuatChieu);
            Controls.Add(cbo_Phim);
            IsMdiContainer = true;
            Name = "frm_MainScreen";
            Text = "Bán vé xem phim";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbo_Phim;
        private ComboBox cbo_SuatChieu;
        private TextBox txt_GheDaChon;
        private Label lbl_TenKhach;
        private ImageList imageList1;
        private Label lbl_Phim;
        private Label lbl_SuatChieu;
        private Label lbl_GheDaChon;
        private Button btn_ChonGhe;
        private Button btn_DatVe;
        private Button btn_Huy;
        private TextBox txt_TenKhach;
    }
}
