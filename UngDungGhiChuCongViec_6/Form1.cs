namespace UngDungGhiChuCongViec_6
{
    public partial class frm_FormChinh : Form
    {
        public frm_FormChinh()
        {
            InitializeComponent();
        }

        public void CapNhatSoGhiChu()
        {
            lbl_TrangThai.Text = $"Ghi chú đang mở: {this.MdiChildren.Length}";
        }

        private void mnuSpIt_MoGhiChuMoi_Click(object sender, EventArgs e)
        {
            FormGhiChu frm = new FormGhiChu();
            frm.MdiParent = this;
            frm.FormClosed += (s, args) => CapNhatSoGhiChu();
            frm.Show();
            CapNhatSoGhiChu();
        }

        private void mnuSpIt_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
        private void mnuSpIt_XepTang_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade); 
        }

        private void mnuSpIt_XepNgang_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal); 
        }

        private void mnuSpIt_XepDoc_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
