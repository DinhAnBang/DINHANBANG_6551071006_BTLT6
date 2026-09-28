using System.Drawing;
using System.Windows.Forms;

namespace CAU3
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

            lblMaHS = new Label();
            lblHoTen = new Label();
            lblToan = new Label();
            lblVan = new Label();
            lblAnh = new Label();

            txtMaHS = new TextBox();
            txtHoTen = new TextBox();
            txtToan = new TextBox();
            txtVan = new TextBox();
            txtAnh = new TextBox();

            btnLuu = new Button();
            btnXoaTrang = new Button();

            lstDanhSach = new ListBox();

            errorProvider1 = new ErrorProvider(components);

            ((System.ComponentModel.ISupportInitialize)errorProvider1)
                .BeginInit();

            SuspendLayout();

            // lblMaHS
            lblMaHS.AutoSize = true;
            lblMaHS.Location = new Point(25, 25);
            lblMaHS.Name = "lblMaHS";
            lblMaHS.Size = new Size(82, 20);
            lblMaHS.TabIndex = 10;
            lblMaHS.TabStop = false;
            lblMaHS.Text = "Mã HS";

            // txtMaHS
            txtMaHS.Location = new Point(25, 50);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(100, 27);
            txtMaHS.TabIndex = 0;

            // lblHoTen
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(145, 25);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(61, 20);
            lblHoTen.TabIndex = 11;
            lblHoTen.TabStop = false;
            lblHoTen.Text = "Họ tên";

            // txtHoTen
            txtHoTen.Location = new Point(145, 50);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(160, 27);
            txtHoTen.TabIndex = 1;

            // lblToan
            lblToan.AutoSize = true;
            lblToan.Location = new Point(325, 25);
            lblToan.Name = "lblToan";
            lblToan.Size = new Size(79, 20);
            lblToan.TabIndex = 12;
            lblToan.TabStop = false;
            lblToan.Text = "Điểm Toán";

            // txtToan
            txtToan.Location = new Point(325, 50);
            txtToan.Name = "txtToan";
            txtToan.Size = new Size(90, 27);
            txtToan.TabIndex = 2;
            txtToan.Enter += txtDiem_Enter;

            // lblVan
            lblVan.AutoSize = true;
            lblVan.Location = new Point(435, 25);
            lblVan.Name = "lblVan";
            lblVan.Size = new Size(73, 20);
            lblVan.TabIndex = 13;
            lblVan.TabStop = false;
            lblVan.Text = "Điểm Văn";

            // txtVan
            txtVan.Location = new Point(435, 50);
            txtVan.Name = "txtVan";
            txtVan.Size = new Size(90, 27);
            txtVan.TabIndex = 3;
            txtVan.Enter += txtDiem_Enter;

            // lblAnh
            lblAnh.AutoSize = true;
            lblAnh.Location = new Point(545, 25);
            lblAnh.Name = "lblAnh";
            lblAnh.Size = new Size(77, 20);
            lblAnh.TabIndex = 14;
            lblAnh.TabStop = false;
            lblAnh.Text = "Điểm Anh";

            // txtAnh
            txtAnh.Location = new Point(545, 50);
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(90, 27);
            txtAnh.TabIndex = 4;
            txtAnh.Enter += txtDiem_Enter;

            // btnLuu
            btnLuu.BackColor = Color.MediumSeaGreen;
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(25, 95);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(100, 38);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;

            // btnXoaTrang
            btnXoaTrang.Location = new Point(145, 95);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(100, 38);
            btnXoaTrang.TabIndex = 6;
            btnXoaTrang.Text = "Xóa Trắng";
            btnXoaTrang.UseVisualStyleBackColor = true;
            btnXoaTrang.Click += btnXoaTrang_Click;

            // lstDanhSach
            lstDanhSach.FormattingEnabled = true;
            lstDanhSach.ItemHeight = 20;
            lstDanhSach.Location = new Point(25, 150);
            lstDanhSach.Name = "lstDanhSach";
            lstDanhSach.Size = new Size(610, 204);
            lstDanhSach.TabIndex = 7;
            lstDanhSach.TabStop = false;

            // errorProvider1
            errorProvider1.BlinkRate = 250;
            errorProvider1.BlinkStyle =
                ErrorBlinkStyle.BlinkIfDifferentError;
            errorProvider1.ContainerControl = this;

            // Form1
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(670, 390);

            Controls.Add(lblMaHS);
            Controls.Add(txtMaHS);

            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);

            Controls.Add(lblToan);
            Controls.Add(txtToan);

            Controls.Add(lblVan);
            Controls.Add(txtVan);

            Controls.Add(lblAnh);
            Controls.Add(txtAnh);

            Controls.Add(btnLuu);
            Controls.Add(btnXoaTrang);

            Controls.Add(lstDanhSach);

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhập điểm học sinh";

            ((System.ComponentModel.ISupportInitialize)errorProvider1)
                .EndInit();

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaHS;
        private Label lblHoTen;
        private Label lblToan;
        private Label lblVan;
        private Label lblAnh;

        private TextBox txtMaHS;
        private TextBox txtHoTen;
        private TextBox txtToan;
        private TextBox txtVan;
        private TextBox txtAnh;

        private Button btnLuu;
        private Button btnXoaTrang;

        private ListBox lstDanhSach;

        private ErrorProvider errorProvider1;
    }
}