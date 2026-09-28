namespace CAU1
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

            lblTieuDe = new Label();
            lblMoTa = new Label();

            lblHoTen = new Label();
            lblSDT = new Label();
            lblEmail = new Label();
            lblMatKhau = new Label();
            lblXacNhanMK = new Label();

            txtHoTen = new TextBox();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            txtMatKhau = new TextBox();
            txtXacNhanMK = new TextBox();

            btnDangKy = new Button();
            btnHuy = new Button();

            errorProvider1 = new ErrorProvider(components);

            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();

            SuspendLayout();

            // lblTieuDe
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTieuDe.Location = new Point(35, 25);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(260, 37);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "Đăng ký tài khoản mới";

            // lblMoTa
            lblMoTa.AutoSize = true;
            lblMoTa.Font = new Font("Segoe UI", 10F);
            lblMoTa.Location = new Point(38, 70);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(219, 23);
            lblMoTa.TabIndex = 1;
            lblMoTa.Text = "Vui lòng nhập đầy đủ thông tin";

            // lblHoTen
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(95, 125);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(61, 20);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ tên";

            // txtHoTen
            txtHoTen.Location = new Point(210, 120);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(260, 27);
            txtHoTen.TabIndex = 0;

            // lblSDT
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(55, 170);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(101, 20);
            lblSDT.TabIndex = 4;
            lblSDT.Text = "Số điện thoại";

            // txtSDT
            txtSDT.Location = new Point(210, 165);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(260, 27);
            txtSDT.TabIndex = 1;

            // lblEmail
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(108, 215);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";

            // txtEmail
            txtEmail.Location = new Point(210, 210);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(260, 27);
            txtEmail.TabIndex = 2;

            // lblMatKhau
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new Point(84, 260);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(72, 20);
            lblMatKhau.TabIndex = 8;
            lblMatKhau.Text = "Mật khẩu";

            // txtMatKhau
            txtMatKhau.Location = new Point(210, 255);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(260, 27);
            txtMatKhau.TabIndex = 3;

            // lblXacNhanMK
            lblXacNhanMK.AutoSize = true;
            lblXacNhanMK.Location = new Point(20, 305);
            lblXacNhanMK.Name = "lblXacNhanMK";
            lblXacNhanMK.Size = new Size(136, 20);
            lblXacNhanMK.TabIndex = 10;
            lblXacNhanMK.Text = "Xác nhận mật khẩu";

            // txtXacNhanMK
            txtXacNhanMK.Location = new Point(210, 300);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.PasswordChar = '*';
            txtXacNhanMK.Size = new Size(260, 27);
            txtXacNhanMK.TabIndex = 4;

            // btnDangKy
            btnDangKy.BackColor = Color.DodgerBlue;
            btnDangKy.ForeColor = Color.White;
            btnDangKy.Location = new Point(210, 355);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(120, 40);
            btnDangKy.TabIndex = 5;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;

            // btnHuy
            btnHuy.CausesValidation = false;
            btnHuy.Location = new Point(350, 355);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(120, 40);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;

            // errorProvider1
            errorProvider1.BlinkRate = 250;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
            errorProvider1.ContainerControl = this;

            // Form1
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 430);

            Controls.Add(lblTieuDe);
            Controls.Add(lblMoTa);

            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);

            Controls.Add(lblSDT);
            Controls.Add(txtSDT);

            Controls.Add(lblEmail);
            Controls.Add(txtEmail);

            Controls.Add(lblMatKhau);
            Controls.Add(txtMatKhau);

            Controls.Add(lblXacNhanMK);
            Controls.Add(txtXacNhanMK);

            Controls.Add(btnDangKy);
            Controls.Add(btnHuy);

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký tài khoản";

            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label lblMoTa;

        private Label lblHoTen;
        private Label lblSDT;
        private Label lblEmail;
        private Label lblMatKhau;
        private Label lblXacNhanMK;

        private TextBox txtHoTen;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private TextBox txtMatKhau;
        private TextBox txtXacNhanMK;

        private Button btnDangKy;
        private Button btnHuy;

        private ErrorProvider errorProvider1;
    }
}