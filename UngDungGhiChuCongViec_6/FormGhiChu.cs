using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UngDungGhiChuCongViec_6
{
    public partial class FormGhiChu : Form
    {
        private bool isModified = false;
        public FormGhiChu()
        {
            InitializeComponent();
            txt_NoiDung.TextChanged += (s, e) => isModified = true;
            txt_TieuDe.TextChanged += (s, e) => isModified = true;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.Control && e.KeyCode == Keys.S)
            {
                e.Handled = true; 
                btn_Luu.PerformClick(); 
            }
            else if (e.KeyCode == Keys.Escape)
            {
                if (isModified)
                {
                    DialogResult result = MessageBox.Show("Nội dung chưa được lưu. Bạn có chắc chắn muốn đóng?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else
                {
                    this.Close(); 
                }
            }
        }


        private void txt_NoiDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_NoiDung.Text.Length >= 500 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void lbl_TieuDe_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btn_Luu_MouseEnter(object sender, EventArgs e)
        {
            btn_Luu.BackColor = Color.LightGreen;
        }

        private void btn_Luu_MouseLeave(object sender, EventArgs e)
        {
            btn_Luu.BackColor = SystemColors.Control; 
        }
        private void txt_TieuDe_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TieuDe.Text) || txt_TieuDe.Text.Trim().Length > 50)
            {
                e.Cancel = true; 
                txt_TieuDe.BackColor = Color.MistyRose;
                errorProviderChild.SetError(txt_TieuDe, "Tiêu đề không được trống và tối đa 50 ký tự");
            }
            else
            {
                e.Cancel = false;
                errorProviderChild.SetError(txt_TieuDe, "");
            }
        }

        private void txt_TieuDe_Validated(object sender, EventArgs e)
        {
            txt_TieuDe.BackColor = Color.White;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.Text = txt_TieuDe.Text.Trim(); 
                isModified = false;
                MessageBox.Show("Đã lưu ghi chú thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
