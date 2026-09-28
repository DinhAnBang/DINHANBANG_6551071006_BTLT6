using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace CAU2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Họ tên
        private void txtHoTen_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống");
                txtHoTen.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
                txtHoTen.BackColor = Color.Honeydew;
            }
        }

        // CCCD
        private void txtCCCD_Validating(object sender, CancelEventArgs e)
        {
            string cccd = txtCCCD.Text.Trim();

            if (cccd.Length != 12 || !cccd.All(char.IsDigit))
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtCCCD,
                    "CCCD phải gồm đúng 12 chữ số"
                );
                txtCCCD.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtCCCD, "");
                txtCCCD.BackColor = Color.Honeydew;
            }
        }

        // Ngày nhận phòng
        private void txtNgayNhan_Validating(object sender, CancelEventArgs e)
        {
            DateTime ngayNhan;

            if (!DateTime.TryParseExact(
                    txtNgayNhan.Text.Trim(),
                    "dd/MM/yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out ngayNhan))
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtNgayNhan,
                    "Ngày nhận phải đúng định dạng dd/MM/yyyy"
                );
                txtNgayNhan.BackColor = Color.MistyRose;
            }
            else if (ngayNhan.Date < DateTime.Today)
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtNgayNhan,
                    "Ngày nhận phải từ hôm nay trở đi"
                );
                txtNgayNhan.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtNgayNhan, "");
                txtNgayNhan.BackColor = Color.Honeydew;
            }
        }

        // Ngày trả phòng
        private void txtNgayTra_Validating(object sender, CancelEventArgs e)
        {
            DateTime ngayNhan;
            DateTime ngayTra;

            if (!DateTime.TryParseExact(
                    txtNgayTra.Text.Trim(),
                    "dd/MM/yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out ngayTra))
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtNgayTra,
                    "Ngày trả phải đúng định dạng dd/MM/yyyy"
                );
                txtNgayTra.BackColor = Color.MistyRose;
                return;
            }

            if (!DateTime.TryParseExact(
                    txtNgayNhan.Text.Trim(),
                    "dd/MM/yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out ngayNhan))
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtNgayTra,
                    "Ngày nhận phòng chưa hợp lệ"
                );
                txtNgayTra.BackColor = Color.MistyRose;
                return;
            }

            if (ngayTra.Date <= ngayNhan.Date)
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtNgayTra,
                    "Ngày trả phải sau ngày nhận"
                );
                txtNgayTra.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtNgayTra, "");
                txtNgayTra.BackColor = Color.Honeydew;
            }
        }

        // Số người lớn
        private void txtSoNguoiLon_Validating(object sender, CancelEventArgs e)
        {
            int soNguoiLon;

            if (!int.TryParse(txtSoNguoiLon.Text.Trim(), out soNguoiLon)
                || soNguoiLon < 1
                || soNguoiLon > 4)
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtSoNguoiLon,
                    "Số người lớn phải từ 1 đến 4"
                );
                txtSoNguoiLon.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtSoNguoiLon, "");
                txtSoNguoiLon.BackColor = Color.Honeydew;
            }
        }

        // Số trẻ em
        private void txtSoTreEm_Validating(object sender, CancelEventArgs e)
        {
            int soTreEm;

            if (!int.TryParse(txtSoTreEm.Text.Trim(), out soTreEm)
                || soTreEm < 0
                || soTreEm > 3)
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtSoTreEm,
                    "Số trẻ em phải từ 0 đến 3"
                );
                txtSoTreEm.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtSoTreEm, "");
                txtSoTreEm.BackColor = Color.Honeydew;
            }
        }

        // Validated dùng chung cho các TextBox
        private void TextBox_Validated(object sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                txt.BackColor = Color.Honeydew;
                errorProvider1.SetError(txt, "");
            }
        }

        // Nút đặt phòng
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            DateTime ngayNhan = DateTime.ParseExact(
                txtNgayNhan.Text.Trim(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture
            );

            DateTime ngayTra = DateTime.ParseExact(
                txtNgayTra.Text.Trim(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture
            );

            int soNguoiLon = int.Parse(txtSoNguoiLon.Text.Trim());
            int soTreEm = int.Parse(txtSoTreEm.Text.Trim());

            int soDem = (ngayTra - ngayNhan).Days;

            MessageBox.Show(
                "Đặt phòng thành công!\n\n" +
                "Khách hàng: " + txtHoTen.Text.Trim() + "\n" +
                "Số đêm: " + soDem + "\n" +
                "Số người lớn: " + soNguoiLon + "\n" +
                "Số trẻ em: " + soTreEm,
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}