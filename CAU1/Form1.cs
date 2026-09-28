using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CAU1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool KiemTraHopLe()
        {
            bool hopLe = true;

            // 1. Kiểm tra họ tên
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider1.SetError(
                    txtHoTen,
                    "Họ tên không được để trống"
                );
                hopLe = false;
            }
            else if (txtHoTen.Text.Trim().Length < 3)
            {
                errorProvider1.SetError(
                    txtHoTen,
                    "Họ tên phải có ít nhất 3 ký tự"
                );
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
            }

            // 2. Kiểm tra số điện thoại
            string sdt = txtSDT.Text.Trim();

            if (string.IsNullOrWhiteSpace(sdt))
            {
                errorProvider1.SetError(
                    txtSDT,
                    "Số điện thoại không được để trống"
                );
                hopLe = false;
            }
            else if (sdt.Length != 10 ||
                     !sdt.StartsWith("0") ||
                     !sdt.All(char.IsDigit))
            {
                errorProvider1.SetError(
                    txtSDT,
                    "Số điện thoại phải có đúng 10 chữ số và bắt đầu bằng 0"
                );
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtSDT, "");
            }

            // 3. Kiểm tra email
            string email = txtEmail.Text.Trim();

            string mauEmail =
                @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";

            if (string.IsNullOrWhiteSpace(email))
            {
                errorProvider1.SetError(
                    txtEmail,
                    "Email không được để trống"
                );
                hopLe = false;
            }
            else if (!Regex.IsMatch(email, mauEmail))
            {
                errorProvider1.SetError(
                    txtEmail,
                    "Email không đúng định dạng"
                );
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }

            // 4. Kiểm tra mật khẩu
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                errorProvider1.SetError(
                    txtMatKhau,
                    "Mật khẩu không được để trống"
                );
                hopLe = false;
            }
            else if (txtMatKhau.Text.Length < 6)
            {
                errorProvider1.SetError(
                    txtMatKhau,
                    "Mật khẩu phải có ít nhất 6 ký tự"
                );
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtMatKhau, "");
            }

            // 5. Kiểm tra xác nhận mật khẩu
            if (string.IsNullOrEmpty(txtXacNhanMK.Text))
            {
                errorProvider1.SetError(
                    txtXacNhanMK,
                    "Vui lòng xác nhận mật khẩu"
                );
                hopLe = false;
            }
            else if (txtXacNhanMK.Text != txtMatKhau.Text)
            {
                errorProvider1.SetError(
                    txtXacNhanMK,
                    "Mật khẩu xác nhận không khớp"
                );
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtXacNhanMK, "");
            }

            return hopLe;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe())
            {
                return;
            }

            MessageBox.Show(
                "Đăng ký thành công! Chào mừng " + txtHoTen.Text.Trim(),
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            this.Close();
        }
    }
}