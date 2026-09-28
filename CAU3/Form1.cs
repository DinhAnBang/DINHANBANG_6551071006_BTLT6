using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CAU3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DangKyEnterChuyenField();
        }

        private void DangKyEnterChuyenField()
        {
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.KeyPress += TextBox_KeyPress;
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if (sender == txtAnh)
                {
                    btnLuu.PerformClick();
                }
                else
                {
                    SelectNextControl(
                        (Control)sender,
                        true,
                        true,
                        true,
                        true
                    );
                }
            }
        }

        private void txtDiem_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.SelectAll();
        }

        private bool KiemTraDiem(
            TextBox txt,
            string tenMon,
            out decimal diem)
        {
            if (!decimal.TryParse(txt.Text.Trim(), out diem))
            {
                errorProvider1.SetError(
                    txt,
                    $"Điểm {tenMon} phải là số"
                );
                return false;
            }

            if (diem < 0 || diem > 10)
            {
                errorProvider1.SetError(
                    txt,
                    $"Điểm {tenMon} phải từ 0 đến 10"
                );
                return false;
            }

            errorProvider1.SetError(txt, "");
            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            bool hopLe = true;

            if (string.IsNullOrWhiteSpace(txtMaHS.Text))
            {
                errorProvider1.SetError(
                    txtMaHS,
                    "Mã học sinh không được để trống"
                );
                hopLe = false;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider1.SetError(
                    txtHoTen,
                    "Họ tên không được để trống"
                );
                hopLe = false;
            }

            decimal diemToan;
            decimal diemVan;
            decimal diemAnh;

            if (!KiemTraDiem(txtToan, "Toán", out diemToan))
                hopLe = false;

            if (!KiemTraDiem(txtVan, "Văn", out diemVan))
                hopLe = false;

            if (!KiemTraDiem(txtAnh, "Anh", out diemAnh))
                hopLe = false;

            if (!hopLe)
                return;

            string dong =
                $"{txtMaHS.Text.Trim()} | " +
                $"{txtHoTen.Text.Trim()} | " +
                $"T:{diemToan} V:{diemVan} A:{diemAnh}";

            lstDanhSach.Items.Add(dong);

            XoaTrang();
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            XoaTrang();
        }

        private void XoaTrang()
        {
            txtMaHS.Clear();
            txtHoTen.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();

            errorProvider1.Clear();

            txtMaHS.Focus();
        }
    }
}