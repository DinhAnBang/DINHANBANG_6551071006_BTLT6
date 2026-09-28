using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CAU4
{
    public partial class Form1 : Form
    {
        private int _indexDangSua = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();

            if (string.IsNullOrWhiteSpace(ten))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên liên hệ.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtTen.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(sdt))
            {
                MessageBox.Show(
                    "Vui lòng nhập số điện thoại.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtSDT.Focus();
                return;
            }

            string lienHe = ten + " - " + sdt;

            // Đang sửa liên hệ
            if (_indexDangSua >= 0)
            {
                lstLienHe.Items[_indexDangSua] = lienHe;
                _indexDangSua = -1;

                MessageBox.Show(
                    "Cập nhật thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                // Thêm liên hệ mới
                lstLienHe.Items.Add(lienHe);

                MessageBox.Show(
                    "Thêm thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            XoaTrang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn một liên hệ để sửa.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            _indexDangSua = lstLienHe.SelectedIndex;

            string lienHe = lstLienHe.SelectedItem.ToString();

            int viTri = lienHe.LastIndexOf(" - ");

            if (viTri >= 0)
            {
                txtTen.Text = lienHe.Substring(0, viTri);
                txtSDT.Text = lienHe.Substring(viTri + 3);
            }

            txtTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn một liên hệ để xóa",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            string lienHe = lstLienHe.SelectedItem.ToString();

            int viTri = lienHe.LastIndexOf(" - ");

            string ten = lienHe;

            if (viTri >= 0)
            {
                ten = lienHe.Substring(0, viTri);
            }

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc muốn xóa liên hệ " + ten +
                "?\nThao tác này không thể hoàn tác!",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua == DialogResult.Yes)
            {
                int indexBiXoa = lstLienHe.SelectedIndex;

                lstLienHe.Items.RemoveAt(indexBiXoa);

                // Nếu đang sửa chính liên hệ vừa xóa
                if (_indexDangSua == indexBiXoa)
                {
                    _indexDangSua = -1;
                    XoaTrang();
                }
                else if (_indexDangSua > indexBiXoa)
                {
                    _indexDangSua--;
                }

                MessageBox.Show(
                    "Xóa thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool coDuLieuChuaLuu =
                !string.IsNullOrWhiteSpace(txtTen.Text) ||
                !string.IsNullOrWhiteSpace(txtSDT.Text);

            if (!coDuLieuChuaLuu)
            {
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Bạn có dữ liệu chưa được lưu. Bạn muốn thoát không?",
                "Cảnh báo",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning
            );

            if (ketQua == DialogResult.Yes)
            {
                // Yes: thoát và bỏ dữ liệu chưa lưu
                e.Cancel = false;
            }
            else if (ketQua == DialogResult.No)
            {
                // No: xóa dữ liệu rồi thoát
                txtTen.Clear();
                txtSDT.Clear();
                _indexDangSua = -1;

                e.Cancel = false;
            }
            else
            {
                // Cancel: không cho đóng form
                e.Cancel = true;
            }
        }

        private void XoaTrang()
        {
            txtTen.Clear();
            txtSDT.Clear();

            lstLienHe.ClearSelected();

            txtTen.Focus();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}