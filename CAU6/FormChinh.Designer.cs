using System.Drawing;
using System.Windows.Forms;

namespace CAU6
{
    partial class FormChinh
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            menuStrip1 = new MenuStrip();

            menuTep = new ToolStripMenuItem();
            mnuMoGhiChuMoi = new ToolStripMenuItem();
            mnuSapXepCuaSo = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();

            menuCuaSo = new ToolStripMenuItem();
            mnuXepTang = new ToolStripMenuItem();
            mnuXepNgang = new ToolStripMenuItem();
            mnuXepDoc = new ToolStripMenuItem();

            statusStrip1 = new StatusStrip();
            lblSoGhiChu = new ToolStripStatusLabel();

            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();

            // menuStrip1
            menuStrip1.Items.AddRange(new ToolStripItem[]
            {
                menuTep,
                menuCuaSo
            });

            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1000, 28);
            menuStrip1.TabIndex = 0;

            // menuTep
            menuTep.DropDownItems.AddRange(new ToolStripItem[]
            {
                mnuMoGhiChuMoi,
                mnuSapXepCuaSo,
                new ToolStripSeparator(),
                mnuThoat
            });

            menuTep.Name = "menuTep";
            menuTep.Size = new Size(47, 24);
            menuTep.Text = "Tệp";

            // mnuMoGhiChuMoi
            mnuMoGhiChuMoi.Name = "mnuMoGhiChuMoi";
            mnuMoGhiChuMoi.Size = new Size(210, 26);
            mnuMoGhiChuMoi.Text = "Mở ghi chú mới";
            mnuMoGhiChuMoi.Click += mnuMoGhiChuMoi_Click;

            // mnuSapXepCuaSo
            mnuSapXepCuaSo.Name = "mnuSapXepCuaSo";
            mnuSapXepCuaSo.Size = new Size(210, 26);
            mnuSapXepCuaSo.Text = "Sắp xếp cửa sổ";
            mnuSapXepCuaSo.Click += mnuSapXepCuaSo_Click;

            // mnuThoat
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(210, 26);
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;

            // menuCuaSo
            menuCuaSo.DropDownItems.AddRange(new ToolStripItem[]
            {
                mnuXepTang,
                mnuXepNgang,
                mnuXepDoc
            });

            menuCuaSo.Name = "menuCuaSo";
            menuCuaSo.Size = new Size(70, 24);
            menuCuaSo.Text = "Cửa sổ";

            // mnuXepTang
            mnuXepTang.Name = "mnuXepTang";
            mnuXepTang.Size = new Size(160, 26);
            mnuXepTang.Text = "Xếp tầng";
            mnuXepTang.Click += mnuXepTang_Click;

            // mnuXepNgang
            mnuXepNgang.Name = "mnuXepNgang";
            mnuXepNgang.Size = new Size(160, 26);
            mnuXepNgang.Text = "Xếp ngang";
            mnuXepNgang.Click += mnuXepNgang_Click;

            // mnuXepDoc
            mnuXepDoc.Name = "mnuXepDoc";
            mnuXepDoc.Size = new Size(160, 26);
            mnuXepDoc.Text = "Xếp dọc";
            mnuXepDoc.Click += mnuXepDoc_Click;

            // statusStrip1
            statusStrip1.Items.AddRange(new ToolStripItem[]
            {
                lblSoGhiChu
            });

            statusStrip1.Location = new Point(0, 628);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1000, 22);
            statusStrip1.TabIndex = 1;

            // lblSoGhiChu
            lblSoGhiChu.Name = "lblSoGhiChu";
            lblSoGhiChu.Size = new Size(160, 17);
            lblSoGhiChu.Text = "Số ghi chú đang mở: 0";

            // FormChinh
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(1000, 650);

            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);

            IsMdiContainer = true;

            MainMenuStrip = menuStrip1;

            Name = "FormChinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý ghi chú công việc";

            WindowState = FormWindowState.Maximized;

            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();

            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;

        private ToolStripMenuItem menuTep;
        private ToolStripMenuItem mnuMoGhiChuMoi;
        private ToolStripMenuItem mnuSapXepCuaSo;
        private ToolStripMenuItem mnuThoat;

        private ToolStripMenuItem menuCuaSo;
        private ToolStripMenuItem mnuXepTang;
        private ToolStripMenuItem mnuXepNgang;
        private ToolStripMenuItem mnuXepDoc;

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblSoGhiChu;
    }
}