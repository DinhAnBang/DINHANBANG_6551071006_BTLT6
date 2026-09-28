using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CAU6
{
    public partial class FormGhiChu : Form
    {
        private bool _daThayDoi = false;
        private bool _choPhepDong = false;

        public FormGhiChu()
        {
            InitializeComponent();

            cboMucDoUuTien.SelectedIndex = 1;

            _daThayDoi = false;
        }

        // Ctrl + S và Escape
        private void FormGhiChu_KeyDown(object sender, KeyEventArgs e)
        {
            // Ctrl + S
            if (e.Control && e.KeyCode == Keys.S)
            {
                e.SuppressKeyPress = true;

                btnLuuGhiChu.PerformClick();
            }

            // Escape
            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;

                if (XacNhanDong())
                {
                    _choPhepDong = true;
                    Close();
                }
            }
        }

        // Kiểm tra trước khi đóng
        private bool XacNhanDong()
        {
            if (!_daThayDoi)
            {
                return true;
            }

            DialogResult ketQua = MessageBox.Show(
                "Nội dung ghi chú đã thay đổi.\nBạn có chắc muốn đóng không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            return ketQua == DialogResult.Yes;
        }

        // Nếu người dùng bấm nút X đóng Form
        private void FormGhiChu_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            if (_choPhepDong)
            {
                return;
            }

            if (!XacNhanDong())
            {
                e.Cancel = true;
            }
        }

        // Giới hạn nội dung tối đa 500 ký tự
        private void txtNoiDung_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (txtNoiDung.Text.Length >= 500
                && !char.IsControl(e.KeyChar)
                && txtNoiDung.SelectionLength == 0)
            {
                e.Handled = true;
            }
        }

        // Double click tiêu đề để phóng to / thu nhỏ
        private void lblTieuDeForm_MouseDoubleClick(
            object sender,
            MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        // Hover chuột vào nút lưu
        private void btnLuuGhiChu_MouseEnter(
            object sender,
            EventArgs e)
        {
            btnLuuGhiChu.BackColor = Color.LightGreen;
        }

        private void btnLuuGhiChu_MouseLeave(
            object sender,
            EventArgs e)
        {
            btnLuuGhiChu.BackColor = Color.WhiteSmoke;
        }

        // Validating tiêu đề
        private void txtTieuDe_Validating(
            object sender,
            CancelEventArgs e)
        {
            string tieuDe = txtTieuDe.Text.Trim();

            if (string.IsNullOrWhiteSpace(tieuDe))
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtTieuDe,
                    "Tiêu đề không được để trống"
                );

                txtTieuDe.BackColor = Color.MistyRose;

                return;
            }

            if (tieuDe.Length > 50)
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtTieuDe,
                    "Tiêu đề không được vượt quá 50 ký tự"
                );

                txtTieuDe.BackColor = Color.MistyRose;

                return;
            }

            e.Cancel = false;
        }

        // Validated tiêu đề
        private void txtTieuDe_Validated(
            object sender,
            EventArgs e)
        {
            errorProvider1.SetError(txtTieuDe, "");

            txtTieuDe.BackColor = Color.White;
        }

        // Nút lưu
        private void btnLuuGhiChu_Click(
            object sender,
            EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            this.Text = txtTieuDe.Text.Trim();

            _daThayDoi = false;

            MessageBox.Show(
                "Đã lưu ghi chú",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // Theo dõi nội dung có thay đổi hay không
        private void DuLieu_TextChanged(object sender, EventArgs e)
        {
            _daThayDoi = true;
        }

        private void cboMucDoUuTien_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            _daThayDoi = true;
        }
    }
}