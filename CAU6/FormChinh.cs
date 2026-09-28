using System;
using System.Windows.Forms;

namespace CAU6
{
    public partial class FormChinh : Form
    {
        private int _sttGhiChu = 1;

        public FormChinh()
        {
            InitializeComponent();
            CapNhatSoGhiChu();
        }

        private void mnuMoGhiChuMoi_Click(object sender, EventArgs e)
        {
            FormGhiChu ghiChu = new FormGhiChu();

            ghiChu.Text = "Ghi chú " + _sttGhiChu;
            _sttGhiChu++;

            ghiChu.MdiParent = this;

            ghiChu.FormClosed += GhiChu_FormClosed;

            ghiChu.Show();

            CapNhatSoGhiChu();
        }

        private void GhiChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            CapNhatSoGhiChu();
        }

        private void CapNhatSoGhiChu()
        {
            lblSoGhiChu.Text =
                "Số ghi chú đang mở: " + this.MdiChildren.Length;
        }

        private void mnuSapXepCuaSo_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuXepTang_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuXepNgang_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuXepDoc_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}