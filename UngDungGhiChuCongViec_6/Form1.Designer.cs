namespace UngDungGhiChuCongViec_6
{
    partial class frm_FormChinh
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
            mnuSp_MainScreen = new MenuStrip();
            mnuSp_Tep = new ToolStripMenuItem();
            mnuSpIt_MoGhiChuMoi = new ToolStripMenuItem();
            mnuSpIt_SapXepCuaSo = new ToolStripMenuItem();
            mnuSpIt_Thoat = new ToolStripMenuItem();
            mnuSp_CuaSo = new ToolStripMenuItem();
            mnuSpIt_XepTang = new ToolStripMenuItem();
            mnuSpIt_XepNgang = new ToolStripMenuItem();
            mnuSpIt_XepDoc = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lbl_TrangThai = new ToolStripStatusLabel();
            errorProvider1 = new ErrorProvider(components);
            mnuSp_MainScreen.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // mnuSp_MainScreen
            // 
            mnuSp_MainScreen.ImageScalingSize = new Size(20, 20);
            mnuSp_MainScreen.Items.AddRange(new ToolStripItem[] { mnuSp_Tep, mnuSp_CuaSo });
            mnuSp_MainScreen.Location = new Point(0, 0);
            mnuSp_MainScreen.Name = "mnuSp_MainScreen";
            mnuSp_MainScreen.Size = new Size(626, 28);
            mnuSp_MainScreen.TabIndex = 1;
            mnuSp_MainScreen.Text = "menuStrip1";
            // 
            // mnuSp_Tep
            // 
            mnuSp_Tep.DropDownItems.AddRange(new ToolStripItem[] { mnuSpIt_MoGhiChuMoi, mnuSpIt_SapXepCuaSo, mnuSpIt_Thoat });
            mnuSp_Tep.Name = "mnuSp_Tep";
            mnuSp_Tep.Size = new Size(48, 24);
            mnuSp_Tep.Text = "Tệp";
            // 
            // mnuSpIt_MoGhiChuMoi
            // 
            mnuSpIt_MoGhiChuMoi.Name = "mnuSpIt_MoGhiChuMoi";
            mnuSpIt_MoGhiChuMoi.Size = new Size(224, 26);
            mnuSpIt_MoGhiChuMoi.Text = "Mở Ghi Chú Mới";
            mnuSpIt_MoGhiChuMoi.Click += mnuSpIt_MoGhiChuMoi_Click;
            // 
            // mnuSpIt_SapXepCuaSo
            // 
            mnuSpIt_SapXepCuaSo.Name = "mnuSpIt_SapXepCuaSo";
            mnuSpIt_SapXepCuaSo.Size = new Size(224, 26);
            mnuSpIt_SapXepCuaSo.Text = "Sắp xếp ghi chú";
            // 
            // mnuSpIt_Thoat
            // 
            mnuSpIt_Thoat.Name = "mnuSpIt_Thoat";
            mnuSpIt_Thoat.Size = new Size(224, 26);
            mnuSpIt_Thoat.Text = "Thoát";
            mnuSpIt_Thoat.Click += mnuSpIt_Thoat_Click;
            // 
            // mnuSp_CuaSo
            // 
            mnuSp_CuaSo.DropDownItems.AddRange(new ToolStripItem[] { mnuSpIt_XepTang, mnuSpIt_XepNgang, mnuSpIt_XepDoc });
            mnuSp_CuaSo.Name = "mnuSp_CuaSo";
            mnuSp_CuaSo.Size = new Size(68, 24);
            mnuSp_CuaSo.Text = "Cửa sổ";
            // 
            // mnuSpIt_XepTang
            // 
            mnuSpIt_XepTang.Name = "mnuSpIt_XepTang";
            mnuSpIt_XepTang.Size = new Size(164, 26);
            mnuSpIt_XepTang.Text = "Xếp tầng";
            mnuSpIt_XepTang.Click += mnuSpIt_XepTang_Click;
            // 
            // mnuSpIt_XepNgang
            // 
            mnuSpIt_XepNgang.Name = "mnuSpIt_XepNgang";
            mnuSpIt_XepNgang.Size = new Size(164, 26);
            mnuSpIt_XepNgang.Text = "Xếp ngang";
            mnuSpIt_XepNgang.Click += mnuSpIt_XepNgang_Click;
            // 
            // mnuSpIt_XepDoc
            // 
            mnuSpIt_XepDoc.Name = "mnuSpIt_XepDoc";
            mnuSpIt_XepDoc.Size = new Size(164, 26);
            mnuSpIt_XepDoc.Text = "Xếp dọc";
            mnuSpIt_XepDoc.Click += mnuSpIt_XepDoc_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbl_TrangThai });
            statusStrip1.Location = new Point(0, 379);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(626, 24);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lbl_TrangThai
            // 
            lbl_TrangThai.Name = "lbl_TrangThai";
            lbl_TrangThai.Size = new Size(0, 18);
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frm_FormChinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 403);
            Controls.Add(statusStrip1);
            Controls.Add(mnuSp_MainScreen);
            IsMdiContainer = true;
            MainMenuStrip = mnuSp_MainScreen;
            Name = "frm_FormChinh";
            Text = "FormChinh";
            mnuSp_MainScreen.ResumeLayout(false);
            mnuSp_MainScreen.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuSp_MainScreen;
        private ToolStripMenuItem mnuSp_Tep;
        private ToolStripMenuItem mnuSpIt_MoGhiChuMoi;
        private ToolStripMenuItem mnuSpIt_SapXepCuaSo;
        private ToolStripMenuItem mnuSpIt_Thoat;
        private ToolStripMenuItem mnuSp_CuaSo;
        private ToolStripMenuItem mnuSpIt_XepTang;
        private ToolStripMenuItem mnuSpIt_XepNgang;
        private ToolStripMenuItem mnuSpIt_XepDoc;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lbl_TrangThai;
        private ErrorProvider errorProvider1;
    }
}
