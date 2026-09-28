using System.Drawing;
using System.Windows.Forms;

namespace CAU5
{
    partial class FormBanVe
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
            lblTenKhach = new Label();
            lblPhim = new Label();
            lblSuatChieu = new Label();
            lblGheDaChon = new Label();

            txtTenKhach = new TextBox();
            txtGheDaChon = new TextBox();

            cboPhim = new ComboBox();
            cboSuatChieu = new ComboBox();

            btnChonGhe = new Button();
            btnDatVe = new Button();
            btnHuy = new Button();

            SuspendLayout();

            // lblTenKhach
            lblTenKhach.AutoSize = true;
            lblTenKhach.Location = new Point(35, 30);
            lblTenKhach.Name = "lblTenKhach";
            lblTenKhach.Size = new Size(79, 20);
            lblTenKhach.TabIndex = 10;
            lblTenKhach.Text = "Tên khách:";

            // txtTenKhach
            txtTenKhach.Location = new Point(35, 55);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(330, 27);
            txtTenKhach.TabIndex = 0;

            // lblPhim
            lblPhim.AutoSize = true;
            lblPhim.Location = new Point(35, 100);
            lblPhim.Name = "lblPhim";
            lblPhim.Size = new Size(43, 20);
            lblPhim.TabIndex = 11;
            lblPhim.Text = "Phim:";

            // cboPhim
            cboPhim.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhim.FormattingEnabled = true;

            // Theo dữ liệu nhìn thấy trong ảnh minh họa
            cboPhim.Items.AddRange(new object[]
            {
                "Chiến binh cuối cùng"
            });

            cboPhim.Location = new Point(35, 125);
            cboPhim.Name = "cboPhim";
            cboPhim.Size = new Size(330, 28);
            cboPhim.TabIndex = 1;

            // lblSuatChieu
            lblSuatChieu.AutoSize = true;
            lblSuatChieu.Location = new Point(35, 170);
            lblSuatChieu.Name = "lblSuatChieu";
            lblSuatChieu.Size = new Size(80, 20);
            lblSuatChieu.TabIndex = 12;
            lblSuatChieu.Text = "Suất chiếu:";

            // cboSuatChieu
            cboSuatChieu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSuatChieu.FormattingEnabled = true;

            // Theo ảnh minh họa
            cboSuatChieu.Items.AddRange(new object[]
            {
                "19:00"
            });

            cboSuatChieu.Location = new Point(35, 195);
            cboSuatChieu.Name = "cboSuatChieu";
            cboSuatChieu.Size = new Size(330, 28);
            cboSuatChieu.TabIndex = 2;

            // lblGheDaChon
            lblGheDaChon.AutoSize = true;
            lblGheDaChon.Location = new Point(35, 240);
            lblGheDaChon.Name = "lblGheDaChon";
            lblGheDaChon.Size = new Size(87, 20);
            lblGheDaChon.TabIndex = 13;
            lblGheDaChon.Text = "Ghế đã chọn:";

            // txtGheDaChon
            txtGheDaChon.Location = new Point(35, 265);
            txtGheDaChon.Name = "txtGheDaChon";
            txtGheDaChon.ReadOnly = true;
            txtGheDaChon.Size = new Size(330, 27);
            txtGheDaChon.TabIndex = 3;

            // btnChonGhe
            btnChonGhe.Location = new Point(35, 325);
            btnChonGhe.Name = "btnChonGhe";
            btnChonGhe.Size = new Size(105, 40);
            btnChonGhe.TabIndex = 4;
            btnChonGhe.Text = "Chọn ghế";
            btnChonGhe.UseVisualStyleBackColor = true;
            btnChonGhe.Click += btnChonGhe_Click;

            // btnDatVe
            btnDatVe.Location = new Point(150, 325);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(105, 40);
            btnDatVe.TabIndex = 5;
            btnDatVe.Text = "Đặt vé";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnDatVe_Click;

            // btnHuy
            btnHuy.Location = new Point(265, 325);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(100, 40);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;

            // FormBanVe
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(405, 405);

            Controls.Add(lblTenKhach);
            Controls.Add(txtTenKhach);

            Controls.Add(lblPhim);
            Controls.Add(cboPhim);

            Controls.Add(lblSuatChieu);
            Controls.Add(cboSuatChieu);

            Controls.Add(lblGheDaChon);
            Controls.Add(txtGheDaChon);

            Controls.Add(btnChonGhe);
            Controls.Add(btnDatVe);
            Controls.Add(btnHuy);

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            Name = "FormBanVe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bán vé xem phim";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTenKhach;
        private Label lblPhim;
        private Label lblSuatChieu;
        private Label lblGheDaChon;

        private TextBox txtTenKhach;
        private TextBox txtGheDaChon;

        private ComboBox cboPhim;
        private ComboBox cboSuatChieu;

        private Button btnChonGhe;
        private Button btnDatVe;
        private Button btnHuy;
    }
}