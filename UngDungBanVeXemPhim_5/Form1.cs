namespace UngDungBanVeXemPhim_5
{
    public partial class frm_MainScreen : Form
    {
        public frm_MainScreen()
        {
            InitializeComponent();
        }

        private void btn_ChonGhe_Click(object sender, EventArgs e)
        {
            using (FormChonGhe dlg = new FormChonGhe(txt_GheDaChon.Text))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txt_GheDaChon.Text = dlg.GheChon;
                }
            }
        }

        private void btn_DatVe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TenKhach.Text) || cbo_Phim.SelectedItem == null || cbo_SuatChieu.SelectedItem == null || string.IsNullOrWhiteSpace(txt_GheDaChon.Text))
            {
                MessageBox.Show("Vui long nhap va chon day du thong tin (Ten, Phim, Suat, Ghe)", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string tenKhach = txt_TenKhach.Text.Trim();
            string phim = cbo_Phim.SelectedItem.ToString();
            string suat = cbo_SuatChieu.SelectedItem.ToString();
            string ghe = txt_GheDaChon.Text;
            int giaVe = 75000;
            string thongBao = $"Xac nhan ve thanh cong!\n\n" +
                              $" Khach hang: {tenKhach}\n" +
                              $" Phim: {phim}" +
                              $" Suat chieu: {suat}" +
                              $" Ghe: {ghe}" +
                              $" Tong tien: {giaVe:N0} dong";
            MessageBox.Show(thongBao, "Thong bao dat ve", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btn_Huy.PerformClick();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            txt_TenKhach.Clear();
            cbo_Phim.SelectedIndex = -1;
            cbo_SuatChieu.SelectedIndex = -1;
            txt_GheDaChon.Clear();
        }
    }
}
