using System.Drawing;
using System.Windows.Forms;

namespace CAU2
{
    partial class Form1
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

            lblHoTen = new Label();
            lblCCCD = new Label();
            lblNgayNhan = new Label();
            lblNgayTra = new Label();
            lblSoNguoiLon = new Label();
            lblSoTreEm = new Label();

            txtHoTen = new TextBox();
            txtCCCD = new TextBox();
            txtNgayNhan = new TextBox();
            txtNgayTra = new TextBox();
            txtSoNguoiLon = new TextBox();
            txtSoTreEm = new TextBox();

            btnDatPhong = new Button();

            errorProvider1 = new ErrorProvider(components);

            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();

            SuspendLayout();

            // lblHoTen
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(45, 35);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(61, 20);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ tên";

            // txtHoTen
            txtHoTen.Location = new Point(45, 58);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(330, 27);
            txtHoTen.TabIndex = 0;
            txtHoTen.Validating += txtHoTen_Validating;
            txtHoTen.Validated += TextBox_Validated;

            // lblCCCD
            lblCCCD.AutoSize = true;
            lblCCCD.Location = new Point(45, 100);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(66, 20);
            lblCCCD.TabIndex = 2;
            lblCCCD.Text = "Số CCCD";

            // txtCCCD
            txtCCCD.Location = new Point(45, 123);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(330, 27);
            txtCCCD.TabIndex = 1;
            txtCCCD.Validating += txtCCCD_Validating;
            txtCCCD.Validated += TextBox_Validated;

            // lblNgayNhan
            lblNgayNhan.AutoSize = true;
            lblNgayNhan.Location = new Point(45, 165);
            lblNgayNhan.Name = "lblNgayNhan";
            lblNgayNhan.Size = new Size(124, 20);
            lblNgayNhan.TabIndex = 4;
            lblNgayNhan.Text = "Ngày nhận phòng";

            // txtNgayNhan
            txtNgayNhan.Location = new Point(45, 188);
            txtNgayNhan.Name = "txtNgayNhan";
            txtNgayNhan.PlaceholderText = "dd/MM/yyyy";
            txtNgayNhan.Size = new Size(330, 27);
            txtNgayNhan.TabIndex = 2;
            txtNgayNhan.Validating += txtNgayNhan_Validating;
            txtNgayNhan.Validated += TextBox_Validated;

            // lblNgayTra
            lblNgayTra.AutoSize = true;
            lblNgayTra.Location = new Point(45, 230);
            lblNgayTra.Name = "lblNgayTra";
            lblNgayTra.Size = new Size(113, 20);
            lblNgayTra.TabIndex = 6;
            lblNgayTra.Text = "Ngày trả phòng";

            // txtNgayTra
            txtNgayTra.Location = new Point(45, 253);
            txtNgayTra.Name = "txtNgayTra";
            txtNgayTra.PlaceholderText = "dd/MM/yyyy";
            txtNgayTra.Size = new Size(330, 27);
            txtNgayTra.TabIndex = 3;
            txtNgayTra.Validating += txtNgayTra_Validating;
            txtNgayTra.Validated += TextBox_Validated;

            // lblSoNguoiLon
            lblSoNguoiLon.AutoSize = true;
            lblSoNguoiLon.Location = new Point(45, 295);
            lblSoNguoiLon.Name = "lblSoNguoiLon";
            lblSoNguoiLon.Size = new Size(94, 20);
            lblSoNguoiLon.TabIndex = 8;
            lblSoNguoiLon.Text = "Số người lớn";

            // txtSoNguoiLon
            txtSoNguoiLon.Location = new Point(45, 318);
            txtSoNguoiLon.Name = "txtSoNguoiLon";
            txtSoNguoiLon.Size = new Size(330, 27);
            txtSoNguoiLon.TabIndex = 4;
            txtSoNguoiLon.Validating += txtSoNguoiLon_Validating;
            txtSoNguoiLon.Validated += TextBox_Validated;

            // lblSoTreEm
            lblSoTreEm.AutoSize = true;
            lblSoTreEm.Location = new Point(45, 360);
            lblSoTreEm.Name = "lblSoTreEm";
            lblSoTreEm.Size = new Size(72, 20);
            lblSoTreEm.TabIndex = 10;
            lblSoTreEm.Text = "Số trẻ em";

            // txtSoTreEm
            txtSoTreEm.Location = new Point(45, 383);
            txtSoTreEm.Name = "txtSoTreEm";
            txtSoTreEm.Size = new Size(330, 27);
            txtSoTreEm.TabIndex = 5;
            txtSoTreEm.Validating += txtSoTreEm_Validating;
            txtSoTreEm.Validated += TextBox_Validated;

            // btnDatPhong
            btnDatPhong.BackColor = Color.DodgerBlue;
            btnDatPhong.ForeColor = Color.White;
            btnDatPhong.Location = new Point(45, 435);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new Size(330, 42);
            btnDatPhong.TabIndex = 6;
            btnDatPhong.Text = "Đặt Phòng";
            btnDatPhong.UseVisualStyleBackColor = false;
            btnDatPhong.Click += btnDatPhong_Click;

            // errorProvider1
            errorProvider1.BlinkRate = 250;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
            errorProvider1.ContainerControl = this;

            // Form1
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;

            BackColor = Color.Honeydew;
            ClientSize = new Size(430, 520);

            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);

            Controls.Add(lblCCCD);
            Controls.Add(txtCCCD);

            Controls.Add(lblNgayNhan);
            Controls.Add(txtNgayNhan);

            Controls.Add(lblNgayTra);
            Controls.Add(txtNgayTra);

            Controls.Add(lblSoNguoiLon);
            Controls.Add(txtSoNguoiLon);

            Controls.Add(lblSoTreEm);
            Controls.Add(txtSoTreEm);

            Controls.Add(btnDatPhong);

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đặt phòng khách sạn";

            AutoValidate = AutoValidate.EnablePreventFocusChange;

            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoTen;
        private Label lblCCCD;
        private Label lblNgayNhan;
        private Label lblNgayTra;
        private Label lblSoNguoiLon;
        private Label lblSoTreEm;

        private TextBox txtHoTen;
        private TextBox txtCCCD;
        private TextBox txtNgayNhan;
        private TextBox txtNgayTra;
        private TextBox txtSoNguoiLon;
        private TextBox txtSoTreEm;

        private Button btnDatPhong;

        private ErrorProvider errorProvider1;
    }
}