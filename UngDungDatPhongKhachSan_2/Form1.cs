namespace UngDungDatPhongKhachSan_2
{
    public partial class frm_MainScreen : Form
    {
        public frm_MainScreen()
        {
            InitializeComponent();
        }

        private void txt_HoTen_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_HoTen.Text))
            {
                e.Cancel = true;
                txt_HoTen.BackColor = Color.MistyRose;
                errorProvider1.SetError(txt_HoTen, "Ho ten khong duoc de trong");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_HoTen, "");
            }
        }

        private void txt_CCCD_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_CCCD.Text) || txt_CCCD.Text.Trim().Length != 12 || !txt_CCCD.Text.All(char.IsDigit))
            {
                e.Cancel = true;
                txt_CCCD.BackColor = Color.MistyRose;
                errorProvider1.SetError(txt_CCCD, "CCCD phai dung 12 chu so");
            }
            else
            {
                errorProvider1.SetError(txt_CCCD, "");
            }
        }
        private void txt_NgayNhan_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DateTime ngayNhan;
            bool hopLe = DateTime.TryParseExact(txt_NgayNhan.Text, "dd/MM/yyyy",
                                                System.Globalization.CultureInfo.InvariantCulture,
                                                System.Globalization.DateTimeStyles.None,
                                                out ngayNhan);

            if (!hopLe || ngayNhan.Date < DateTime.Now.Date)
            {
                e.Cancel = true;
                txt_NgayNhan.BackColor = Color.MistyRose;
                errorProvider1.SetError(txt_NgayNhan, "Ngày nhận không hợp lệ hoặc nhỏ hơn hôm nay (dd/MM/yyyy)");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_NgayNhan, "");
            }
        }
        private void txt_NgayTra_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DateTime ngayTra;
            DateTime ngayNhan;
            bool isValidNgayTra = DateTime.TryParseExact(txt_NgayTra.Text, "dd/MM/yyyy",
                                                         System.Globalization.CultureInfo.InvariantCulture,
                                                         System.Globalization.DateTimeStyles.None,
                                                         out ngayTra);

            bool hasNgayNhan = DateTime.TryParseExact(txt_NgayNhan.Text, "dd/MM/yyyy",
                                                      System.Globalization.CultureInfo.InvariantCulture,
                                                      System.Globalization.DateTimeStyles.None,
                                                      out ngayNhan);
            if (!isValidNgayTra || (hasNgayNhan && ngayTra <= ngayNhan))
            {
                e.Cancel = true;
                txt_NgayTra.BackColor = Color.MistyRose;
                errorProvider1.SetError(txt_NgayTra, "Ngày trả phải hợp lệ (dd/MM/yyyy) và phải sau Ngày nhận.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_NgayTra, "");
            }
        }

        

        private void txt_SoNguoiLon_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int soNguoiLon;
            bool isNumber = int.TryParse(txt_SoNguoiLon.Text, out soNguoiLon);
            if (string.IsNullOrWhiteSpace(txt_SoNguoiLon.Text) || !isNumber || soNguoiLon < 1 || soNguoiLon > 4)
            {
                e.Cancel = true;
                txt_SoNguoiLon.BackColor = Color.MistyRose;
                errorProvider1.SetError(txt_SoNguoiLon, "So nguoi lon phai la so va nam trong khoang 1-4");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_SoNguoiLon, "");
            }
        }
        private void txt_SoTreEm_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int soTreEm;
            bool isNumber = int.TryParse(txt_SoTreEm.Text, out soTreEm);
            if (string.IsNullOrWhiteSpace(txt_SoTreEm.Text) || !isNumber || soTreEm < 0 || soTreEm > 3)
            {
                e.Cancel = true;
                txt_SoTreEm.BackColor = Color.MistyRose;
                errorProvider1.SetError(txt_SoTreEm, "So tre em phai nam trong khoan 0-3");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_SoTreEm, "");
            }
        }

        private void txt_HoTen_Validated(object sender, EventArgs e)
        {
            txt_HoTen.BackColor = Color.Honeydew;
        }

        private void txt_CCCD_Validated(object sender, EventArgs e)
        {
            txt_CCCD.BackColor = Color.Honeydew;
        }

        private void txt_SoNguoiLon_Validated(object sender, EventArgs e)
        {
            txt_SoNguoiLon.BackColor = Color.Honeydew;
        }

        private void txt_SoTreEm_Validated(object sender, EventArgs e)
        {
            txt_SoTreEm.BackColor = Color.Honeydew;
        }
        private void txt_NgayNhan_Validated(object sender, EventArgs e)
        {
            txt_NgayNhan.BackColor = Color.Honeydew;
        }
        private void txt_NgayTra_Validated(object sender, EventArgs e)
        {
            txt_NgayTra.BackColor = Color.Honeydew;
        }
        private void btn_DatPhong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_NgayNhan.Text) || string.IsNullOrWhiteSpace(txt_NgayTra.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Ngày nhận và Ngày trả!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            try
            {
                DateTime ngayNhan = DateTime.ParseExact(txt_NgayNhan.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                DateTime ngayTra = DateTime.ParseExact(txt_NgayTra.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                int soDem = (ngayTra - ngayNhan).Days;

                string thongBao = $"Khách hàng: {txt_HoTen.Text}\n" +
                                  $"Số đêm: {soDem}\n" +
                                  $"Số người lớn: {txt_SoNguoiLon.Text}, Trẻ em: {txt_SoTreEm.Text}";

                MessageBox.Show(thongBao, "Đặt phòng thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Định dạng ngày không hợp lệ. Vui lòng nhập theo định dạng dd/MM/yyyy.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

