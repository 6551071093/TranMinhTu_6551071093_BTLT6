namespace UngDungGiaoDoAn_1
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }
        private bool KiemTraTinhHopLe()
        {
            bool hope = true;
            if (string.IsNullOrWhiteSpace(txt_HoTen.Text) || txt_HoTen.Text.Trim().Length < 3)
            {
                errorProvider1.SetError(txt_HoTen, "Ho ten khong duoc de trong va co tu 3 ki tu");
                hope = false;
            }
            else
            {
                errorProvider1.SetError(txt_HoTen, "");
            }
            if (string.IsNullOrWhiteSpace(txt_SDT.Text) || txt_SDT.Text.Trim().Length > 10 || !txt_SDT.Text.StartsWith("0"))
            {
                foreach (char c in txt_SDT.Text)
                {
                    if (char.IsDigit(c))
                    {
                        errorProvider1.SetError(txt_SDT, "SDT khong duoc de trong va gioi han 10 so");
                        hope = false;
                    }
                }
                errorProvider1.SetError(txt_SDT, "SDT khong duoc de trong va gioi han 10 so");
                hope = false;
            }
            else
            {
                errorProvider1.SetError(txt_SDT, "");
            }
            int indexAt = txt_Email.Text.IndexOf("@");
            int indexDot = txt_Email.Text.LastIndexOf(".");
            if (string.IsNullOrWhiteSpace(txt_Email.Text) || indexAt == -1 || indexDot < indexAt)
            {
                errorProvider1.SetError(txt_Email, "Email khong duoc de trong va co @, . va . nam sau @");
                hope = false;
            }
            else
            {
                errorProvider1.SetError(txt_Email, "");
            }
            if (string.IsNullOrWhiteSpace(txt_MatKhau.Text) || txt_MatKhau.Text.Trim().Length < 6)
            {
                errorProvider1.SetError(txt_MatKhau, "Mat khau khong duoc de trong va toi thieu 6 ki tu");
                hope = false;
            }
            else
            {
                errorProvider1.SetError(txt_MatKhau, "");
            }
            if (string.IsNullOrWhiteSpace(txt_XacNhanMatKhau.Text) || txt_XacNhanMatKhau.Text != txt_MatKhau.Text)
            {
                errorProvider1.SetError(txt_XacNhanMatKhau, "Ban can nhap dung va giong voi o Mat Khau");
                hope = false;
            }
            else
            {
                errorProvider1.SetError(txt_XacNhanMatKhau, "");
            }
            return hope;
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraTinhHopLe())
            {
                return;
            }
            MessageBox.Show("Dang ky thanh cong!", "Chao mung " + txt_HoTen.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            this.Close();
        }
    }
}
