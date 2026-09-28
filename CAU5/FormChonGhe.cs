using System;
using System.Windows.Forms;

namespace CAU5
{
    public partial class FormChonGhe : Form
    {
        public string GheChon { get; private set; }

        public FormChonGhe(string gheHienTai)
        {
            InitializeComponent();

            GheChon = gheHienTai;

            if (!string.IsNullOrWhiteSpace(gheHienTai))
            {
                int index = lstGhe.Items.IndexOf(gheHienTai);

                if (index >= 0)
                {
                    lstGhe.SelectedIndex = index;
                }
            }
        }

        private void lstGhe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGhe.SelectedItem != null)
            {
                lblGheDaChon.Text =
                    "Đang chọn: " + lstGhe.SelectedItem.ToString();
            }
            else
            {
                lblGheDaChon.Text = "Đang chọn: Chưa chọn";
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (lstGhe.SelectedItem == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn một ghế.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            GheChon = lstGhe.SelectedItem.ToString();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}