using System;
using System.Windows.Forms;

namespace CAU5
{
    public partial class FormBanVe : Form
    {
        public FormBanVe()
        {
            InitializeComponent();

            if (cboPhim.Items.Count > 0)
                cboPhim.SelectedIndex = 0;

            if (cboSuatChieu.Items.Count > 0)
                cboSuatChieu.SelectedIndex = 0;
        }

        private void btnChonGhe_Click(object sender, EventArgs e)
        {
            string gheHienTai = txtGheDaChon.Text.Trim();

            using (FormChonGhe dlg = new FormChonGhe(gheHienTai))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    txtGheDaChon.Text = dlg.GheChon;
                }
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKhach.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên khách.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtTenKhach.Focus();
                return;
            }

            if (cboPhim.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn phim.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cboPhim.Focus();
                return;
            }

            if (cboSuatChieu.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn suất chiếu.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cboSuatChieu.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGheDaChon.Text))
            {
                MessageBox.Show(
                    "Vui lòng chọn ghế.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                btnChonGhe.Focus();
                return;
            }

            MessageBox.Show(
                "Đặt vé thành công!\n\n" +
                "Tên khách: " + txtTenKhach.Text.Trim() + "\n" +
                "Phim: " + cboPhim.Text + "\n" +
                "Suất chiếu: " + cboSuatChieu.Text + "\n" +
                "Ghế: " + txtGheDaChon.Text + "\n" +
                "Giá vé: 75.000đ/vé",
                "Xác nhận đặt vé",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenKhach.Clear();
            txtGheDaChon.Clear();

            if (cboPhim.Items.Count > 0)
                cboPhim.SelectedIndex = 0;

            if (cboSuatChieu.Items.Count > 0)
                cboSuatChieu.SelectedIndex = 0;

            txtTenKhach.Focus();
        }
    }
}