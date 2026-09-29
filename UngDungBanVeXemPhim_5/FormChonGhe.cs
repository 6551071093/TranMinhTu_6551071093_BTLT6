using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UngDungBanVeXemPhim_5
{
    public partial class FormChonGhe : Form
    {
        public string GheChon { get; private set; }
        public FormChonGhe(string gheHienTai)
        {
            InitializeComponent();
            string[] danhSachGhe = { "A1", "A2", "A3", "A4", "A5",
                                     "B1", "B2", "B3", "B4", "B5",
                                     "C1", "C2", "C3", "C4", "C5" };
            lst_Ghe.Items.AddRange(danhSachGhe);
            if (!string.IsNullOrEmpty(gheHienTai))
            {
                lst_Ghe.SelectedItem = gheHienTai;
            }

        }

        private void lst_Ghe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_Ghe.SelectedItem != null)
            {
                lbl_GheDaChon.Text = "Đang chọn: " + lst_Ghe.SelectedItem.ToString();
            }
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if (lst_Ghe.SelectedItem == null)
            {
                MessageBox.Show("Vui long chon mot ghe truoc khi xac nhan!", "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            GheChon = lst_Ghe.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
        }

        private void btn_BoQua_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
