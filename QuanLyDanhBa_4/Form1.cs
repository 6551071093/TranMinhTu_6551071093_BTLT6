namespace QuanLyDanhBa_4
{
    public partial class frm_MainScreen : Form
    {
        private int _indexDangSua = -1;
        public frm_MainScreen()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_Ten.Text))
                {
                    MessageBox.Show("Ban chua nhap ten danh ba!", "Thong bao!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Ten.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txt_SDT.Text))
                {
                    MessageBox.Show("Ban chua nhap so dien thoai!", "Thong bao!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_SDT.Focus();
                    return;
                }
                string thongTin = $"{txt_Ten.Text.Trim()} - {txt_SDT.Text.Trim()} ";
                if (_indexDangSua >= 0)
                {
                    lst_LienHe.Items[_indexDangSua] = thongTin;
                    _indexDangSua = -1;
                    MessageBox.Show("Cap nhat thanh cong!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lst_LienHe.Items.Add(thongTin);
                    MessageBox.Show("Them thanh cong!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txt_Ten.Clear();
                txt_SDT.Clear();
                txt_Ten.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message, "Thong bao!");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (lst_LienHe.SelectedIndex < 0)
            {
                return;
            }
            _indexDangSua = lst_LienHe.SelectedIndex;
            string[] parts = lst_LienHe.SelectedItems.ToString().Split('-');
            if (parts.Length == 2)
            {
                txt_Ten.Text = parts[0].Trim();
                txt_SDT.Text = parts[1].Trim();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (lst_LienHe.SelectedIndex < 0)
            {
                MessageBox.Show("Vui long chon 1 lien he de xoa!", "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string tenLienHe = lst_LienHe.SelectedItem.ToString().Split('-')[0].Trim();
            DialogResult result = MessageBox.Show(
                $"Ban co chac muon xoa lien he {tenLienHe} ? Thao tac khong the hoan tac!",
                "Canh bao",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question
             );
            if (result == DialogResult.Yes)
            {
                lst_LienHe.Items.RemoveAt(lst_LienHe.SelectedIndex);
                MessageBox.Show("Xoa thanh cong!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (_indexDangSua >= 0)
                {
                    _indexDangSua = -1;
                    txt_Ten.Clear();
                    txt_SDT.Clear();
                }
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txt_Ten.Text) || !string.IsNullOrWhiteSpace(txt_SDT.Text))
            {
                DialogResult ketQua = MessageBox.Show(
                    "Ban co du lieu chua duoc luu. Ban co muon thoat khong ?",
                    "Canh bao",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning
                );
                if( ketQua == DialogResult.Yes)
                {

                }
                else if( ketQua == DialogResult.No)
                {
                    txt_Ten.Clear();
                    txt_SDT.Clear();
                }
                else if(ketQua == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
