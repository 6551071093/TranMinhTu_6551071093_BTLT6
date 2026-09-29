namespace UngDungBanVeXemPhim_5
{
    partial class FormChonGhe
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
            lst_Ghe = new ListBox();
            lbl_GheDaChon = new Label();
            btn_XacNhan = new Button();
            btn_BoQua = new Button();
            SuspendLayout();
            // 
            // lst_Ghe
            // 
            lst_Ghe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lst_Ghe.FormattingEnabled = true;
            lst_Ghe.Location = new Point(12, 12);
            lst_Ghe.Name = "lst_Ghe";
            lst_Ghe.Size = new Size(364, 184);
            lst_Ghe.TabIndex = 0;
            lst_Ghe.SelectedIndexChanged += lst_Ghe_SelectedIndexChanged;
            // 
            // lbl_GheDaChon
            // 
            lbl_GheDaChon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_GheDaChon.AutoSize = true;
            lbl_GheDaChon.Location = new Point(12, 223);
            lbl_GheDaChon.Name = "lbl_GheDaChon";
            lbl_GheDaChon.Size = new Size(0, 20);
            lbl_GheDaChon.TabIndex = 1;
            // 
            // btn_XacNhan
            // 
            btn_XacNhan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_XacNhan.Location = new Point(124, 263);
            btn_XacNhan.Name = "btn_XacNhan";
            btn_XacNhan.Size = new Size(117, 40);
            btn_XacNhan.TabIndex = 2;
            btn_XacNhan.Text = "Xác nhận";
            btn_XacNhan.UseVisualStyleBackColor = true;
            btn_XacNhan.Click += btn_XacNhan_Click;
            // 
            // btn_BoQua
            // 
            btn_BoQua.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_BoQua.Location = new Point(261, 263);
            btn_BoQua.Name = "btn_BoQua";
            btn_BoQua.Size = new Size(115, 40);
            btn_BoQua.TabIndex = 3;
            btn_BoQua.Text = "Bỏ Qua";
            btn_BoQua.UseVisualStyleBackColor = true;
            btn_BoQua.Click += btn_BoQua_Click;
            // 
            // FormChonGhe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 315);
            Controls.Add(btn_BoQua);
            Controls.Add(btn_XacNhan);
            Controls.Add(lbl_GheDaChon);
            Controls.Add(lst_Ghe);
            Name = "FormChonGhe";
            Text = "FormChonGhe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lst_Ghe;
        private Label lbl_GheDaChon;
        private Button btn_XacNhan;
        private Button btn_BoQua;
    }
}