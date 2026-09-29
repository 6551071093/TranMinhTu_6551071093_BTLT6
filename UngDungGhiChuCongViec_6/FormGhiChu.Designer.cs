namespace UngDungGhiChuCongViec_6
{
    partial class FormGhiChu
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
            components = new System.ComponentModel.Container();
            txt_TieuDe = new TextBox();
            txt_NoiDung = new TextBox();
            lbl_Priority = new Label();
            lbl_TieuDe = new Label();
            lbl_NoiDung = new Label();
            cbo_Priority = new ComboBox();
            btn_Luu = new Button();
            errorProviderChild = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderChild).BeginInit();
            SuspendLayout();
            // 
            // txt_TieuDe
            // 
            txt_TieuDe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_TieuDe.Location = new Point(12, 41);
            txt_TieuDe.Name = "txt_TieuDe";
            txt_TieuDe.Size = new Size(591, 27);
            txt_TieuDe.TabIndex = 0;
            txt_TieuDe.Validating += txt_TieuDe_Validating;
            txt_TieuDe.Validated += txt_TieuDe_Validated;
            // 
            // txt_NoiDung
            // 
            txt_NoiDung.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_NoiDung.Location = new Point(12, 119);
            txt_NoiDung.Multiline = true;
            txt_NoiDung.Name = "txt_NoiDung";
            txt_NoiDung.Size = new Size(591, 235);
            txt_NoiDung.TabIndex = 1;
            txt_NoiDung.KeyPress += txt_NoiDung_KeyPress;
            // 
            // lbl_Priority
            // 
            lbl_Priority.AutoSize = true;
            lbl_Priority.Location = new Point(12, 366);
            lbl_Priority.Name = "lbl_Priority";
            lbl_Priority.Size = new Size(56, 20);
            lbl_Priority.TabIndex = 2;
            lbl_Priority.Text = "Priority";
            // 
            // lbl_TieuDe
            // 
            lbl_TieuDe.AutoSize = true;
            lbl_TieuDe.Location = new Point(12, 9);
            lbl_TieuDe.Name = "lbl_TieuDe";
            lbl_TieuDe.Size = new Size(58, 20);
            lbl_TieuDe.TabIndex = 3;
            lbl_TieuDe.Text = "Tiêu đề";
            lbl_TieuDe.MouseDoubleClick += lbl_TieuDe_MouseDoubleClick;
            // 
            // lbl_NoiDung
            // 
            lbl_NoiDung.AutoSize = true;
            lbl_NoiDung.Location = new Point(12, 96);
            lbl_NoiDung.Name = "lbl_NoiDung";
            lbl_NoiDung.Size = new Size(71, 20);
            lbl_NoiDung.TabIndex = 4;
            lbl_NoiDung.Text = "Nội dung";
            // 
            // cbo_Priority
            // 
            cbo_Priority.FormattingEnabled = true;
            cbo_Priority.Items.AddRange(new object[] { "Cao", "Trung bình", "Thấp" });
            cbo_Priority.Location = new Point(12, 389);
            cbo_Priority.Name = "cbo_Priority";
            cbo_Priority.Size = new Size(195, 28);
            cbo_Priority.TabIndex = 5;
            // 
            // btn_Luu
            // 
            btn_Luu.Location = new Point(487, 389);
            btn_Luu.Name = "btn_Luu";
            btn_Luu.Size = new Size(116, 29);
            btn_Luu.TabIndex = 6;
            btn_Luu.Text = "Lưu";
            btn_Luu.UseVisualStyleBackColor = true;
            btn_Luu.Click += btn_Luu_Click;
            btn_Luu.MouseEnter += btn_Luu_MouseEnter;
            btn_Luu.MouseLeave += btn_Luu_MouseLeave;
            // 
            // errorProviderChild
            // 
            errorProviderChild.ContainerControl = this;
            // 
            // FormGhiChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 450);
            Controls.Add(btn_Luu);
            Controls.Add(cbo_Priority);
            Controls.Add(lbl_NoiDung);
            Controls.Add(lbl_TieuDe);
            Controls.Add(lbl_Priority);
            Controls.Add(txt_NoiDung);
            Controls.Add(txt_TieuDe);
            KeyPreview = true;
            Name = "FormGhiChu";
            Text = "FormGhiChu";
            ((System.ComponentModel.ISupportInitialize)errorProviderChild).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_TieuDe;
        private TextBox txt_NoiDung;
        private Label lbl_Priority;
        private Label lbl_TieuDe;
        private Label lbl_NoiDung;
        private ComboBox cbo_Priority;
        private Button btn_Luu;
        private ErrorProvider errorProviderChild;
    }
}