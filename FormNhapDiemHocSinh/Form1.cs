using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormNhapDiemHocSinh
{
    public partial class frm_MainScreen : Form
    {
        public frm_MainScreen()
        {
            InitializeComponent();

            DangKyEnterChuyenField();
            DangKyBoiXanhKhiFocus();
        }

        private void DangKyEnterChuyenField()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox txt)
                {
                    txt.KeyPress += Txt_KeyPress;
                }
            }
        }

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; 

                TextBox currentTxt = sender as TextBox;
                if (currentTxt.Name == "txt_Anh")
                {
                    btn_Luu.PerformClick();
                }
                else
                {
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }
            }
        }

        private void DangKyBoiXanhKhiFocus()
        {
            txt_Toan.Enter += Txt_Diem_Enter;
            txt_Van.Enter += Txt_Diem_Enter;
            txt_Anh.Enter += Txt_Diem_Enter;
        }

        private void Txt_Diem_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                txt.SelectAll();
            }
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hopLe = true;
            decimal diemToan;
            if (!decimal.TryParse(txt_Toan.Text, out diemToan) || diemToan < 0 || diemToan > 10)
            {
                errorProvider1.SetError(txt_Toan, "Điểm Toán phải từ 0.0 đến 10.0");
                hopLe = false;
            }
            decimal diemVan;
            if (!decimal.TryParse(txt_Van.Text, out diemVan) || diemVan < 0 || diemVan > 10)
            {
                errorProvider1.SetError(txt_Van, "Điểm Văn phải từ 0.0 đến 10.0");
                hopLe = false;
            }

            decimal diemAnh;
            if (!decimal.TryParse(txt_Anh.Text, out diemAnh) || diemAnh < 0 || diemAnh > 10)
            {
                errorProvider1.SetError(txt_Anh, "Điểm Anh phải từ 0.0 đến 10.0");
                hopLe = false;
            }

            if (string.IsNullOrWhiteSpace(txt_MaHS.Text))
            {
                errorProvider1.SetError(txt_MaHS, "Không để trống Mã HS");
                hopLe = false;
            }
            if (string.IsNullOrWhiteSpace(txt_HoTen.Text))
            {
                errorProvider1.SetError(txt_HoTen, "Không để trống Họ Tên");
                hopLe = false;
            }

            if (hopLe)
            {
                string thongTin = $"{txt_MaHS.Text} | {txt_HoTen.Text} | T:{diemToan} V:{diemVan} A:{diemAnh}";
                lst_DanhSach.Items.Add(thongTin);
                btn_XoaTrang.PerformClick();
            }
        }

        private void btn_XoaTrang_Click(object sender, EventArgs e)
        {
            // Xóa nội dung
            txt_MaHS.Clear();
            txt_HoTen.Clear();
            txt_Toan.Clear();
            txt_Van.Clear();
            txt_Anh.Clear();

            errorProvider1.Clear();

            txt_MaHS.Focus();
        }
    }
}