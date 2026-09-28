namespace QuanLyDanhBa_4
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
            lst_LienHe = new ListBox();
            txt_Ten = new TextBox();
            txt_SDT = new TextBox();
            lbl_Ten = new Label();
            lbl_SDT = new Label();
            btn_Them = new Button();
            btn_Sua = new Button();
            btn_Xoa = new Button();
            btn_Thoat = new Button();
            SuspendLayout();
            // 
            // lst_LienHe
            // 
            lst_LienHe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lst_LienHe.FormattingEnabled = true;
            lst_LienHe.Location = new Point(12, 12);
            lst_LienHe.Name = "lst_LienHe";
            lst_LienHe.Size = new Size(322, 424);
            lst_LienHe.TabIndex = 0;
            // 
            // txt_Ten
            // 
            txt_Ten.Location = new Point(353, 35);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(290, 27);
            txt_Ten.TabIndex = 1;
            // 
            // txt_SDT
            // 
            txt_SDT.Location = new Point(353, 103);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new Size(290, 27);
            txt_SDT.TabIndex = 2;
            // 
            // lbl_Ten
            // 
            lbl_Ten.AutoSize = true;
            lbl_Ten.Location = new Point(353, 12);
            lbl_Ten.Name = "lbl_Ten";
            lbl_Ten.Size = new Size(35, 20);
            lbl_Ten.TabIndex = 3;
            lbl_Ten.Text = "Tên:";
            // 
            // lbl_SDT
            // 
            lbl_SDT.AutoSize = true;
            lbl_SDT.Location = new Point(353, 80);
            lbl_SDT.Name = "lbl_SDT";
            lbl_SDT.Size = new Size(100, 20);
            lbl_SDT.TabIndex = 4;
            lbl_SDT.Text = "Số điện thoại:";
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(488, 156);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(155, 36);
            btn_Them.TabIndex = 5;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(488, 211);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(155, 36);
            btn_Sua.TabIndex = 6;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(488, 262);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(155, 34);
            btn_Xoa.TabIndex = 7;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(488, 407);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(155, 29);
            btn_Thoat.TabIndex = 8;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // frm_MainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 454);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Sua);
            Controls.Add(btn_Them);
            Controls.Add(lbl_SDT);
            Controls.Add(lbl_Ten);
            Controls.Add(txt_SDT);
            Controls.Add(txt_Ten);
            Controls.Add(lst_LienHe);
            Name = "frm_MainScreen";
            Text = "FormQuanLyDanhBa";
            FormClosing += frm_MainScreen_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lst_LienHe;
        private TextBox txt_Ten;
        private TextBox txt_SDT;
        private Label lbl_Ten;
        private Label lbl_SDT;
        private Button btn_Them;
        private Button btn_Sua;
        private Button btn_Xoa;
        private Button btn_Thoat;
    }
}
