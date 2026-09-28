using System.Drawing;
using System.Windows.Forms;

namespace CAU5
{
    partial class FormChonGhe
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
            lstGhe = new ListBox();
            lblGheDaChon = new Label();

            btnXacNhan = new Button();
            btnBoQua = new Button();

            SuspendLayout();

            // lstGhe
            lstGhe.FormattingEnabled = true;
            lstGhe.ItemHeight = 20;

            lstGhe.Items.AddRange(new object[]
            {
                "A1", "A2", "A3", "A4", "A5",
                "B1", "B2", "B3", "B4", "B5",
                "C1", "C2", "C3", "C4", "C5"
            });

            lstGhe.Location = new Point(25, 25);
            lstGhe.Name = "lstGhe";
            lstGhe.Size = new Size(250, 164);
            lstGhe.TabIndex = 0;
            lstGhe.SelectedIndexChanged +=
                lstGhe_SelectedIndexChanged;

            // lblGheDaChon
            lblGheDaChon.AutoSize = true;
            lblGheDaChon.Location = new Point(25, 210);
            lblGheDaChon.Name = "lblGheDaChon";
            lblGheDaChon.Size = new Size(151, 20);
            lblGheDaChon.TabIndex = 1;
            lblGheDaChon.Text = "Đang chọn: Chưa chọn";

            // btnXacNhan
            btnXacNhan.Location = new Point(55, 255);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(100, 38);
            btnXacNhan.TabIndex = 2;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;

            // btnBoQua
            btnBoQua.Location = new Point(170, 255);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(100, 38);
            btnBoQua.TabIndex = 3;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;

            // FormChonGhe
            AcceptButton = btnXacNhan;
            CancelButton = btnBoQua;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(310, 325);

            Controls.Add(lstGhe);
            Controls.Add(lblGheDaChon);
            Controls.Add(btnXacNhan);
            Controls.Add(btnBoQua);

            FormBorderStyle = FormBorderStyle.FixedDialog;

            MaximizeBox = false;
            MinimizeBox = false;

            Name = "FormChonGhe";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chọn ghế";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstGhe;

        private Label lblGheDaChon;

        private Button btnXacNhan;
        private Button btnBoQua;
    }
}