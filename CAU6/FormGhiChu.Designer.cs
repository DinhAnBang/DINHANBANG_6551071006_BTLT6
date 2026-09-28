using System.Drawing;
using System.Windows.Forms;

namespace CAU6
{
    partial class FormGhiChu
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

            lblTieuDeForm = new Label();
            lblNoiDung = new Label();
            lblMucDo = new Label();

            txtTieuDe = new TextBox();
            txtNoiDung = new TextBox();

            cboMucDoUuTien = new ComboBox();

            btnLuuGhiChu = new Button();

            errorProvider1 = new ErrorProvider(components);

            ((System.ComponentModel.ISupportInitialize)errorProvider1)
                .BeginInit();

            SuspendLayout();

            // lblTieuDeForm
            lblTieuDeForm.AutoSize = true;
            lblTieuDeForm.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);

            lblTieuDeForm.Location = new Point(25, 25);
            lblTieuDeForm.Name = "lblTieuDeForm";
            lblTieuDeForm.Size = new Size(64, 23);
            lblTieuDeForm.TabIndex = 0;
            lblTieuDeForm.Text = "Tiêu đề";

            lblTieuDeForm.MouseDoubleClick +=
                lblTieuDeForm_MouseDoubleClick;

            // txtTieuDe
            txtTieuDe.Location = new Point(105, 22);
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(370, 27);
            txtTieuDe.TabIndex = 0;

            txtTieuDe.TextChanged += DuLieu_TextChanged;
            txtTieuDe.Validating += txtTieuDe_Validating;
            txtTieuDe.Validated += txtTieuDe_Validated;

            // lblNoiDung
            lblNoiDung.AutoSize = true;
            lblNoiDung.Location = new Point(25, 70);
            lblNoiDung.Name = "lblNoiDung";
            lblNoiDung.Size = new Size(72, 20);
            lblNoiDung.TabIndex = 2;
            lblNoiDung.Text = "Nội dung";

            // txtNoiDung
            txtNoiDung.Location = new Point(25, 95);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.ScrollBars = ScrollBars.Vertical;

            txtNoiDung.Size = new Size(450, 230);

            txtNoiDung.TabIndex = 1;

            // Giữ tối đa 500 ký tự kể cả trường hợp dán nội dung
            txtNoiDung.MaxLength = 500;

            txtNoiDung.KeyPress += txtNoiDung_KeyPress;
            txtNoiDung.TextChanged += DuLieu_TextChanged;

            // lblMucDo
            lblMucDo.AutoSize = true;
            lblMucDo.Location = new Point(25, 350);
            lblMucDo.Name = "lblMucDo";
            lblMucDo.Size = new Size(60, 20);
            lblMucDo.TabIndex = 4;
            lblMucDo.Text = "Priority:";

            // cboMucDoUuTien
            cboMucDoUuTien.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cboMucDoUuTien.FormattingEnabled = true;

            cboMucDoUuTien.Items.AddRange(new object[]
            {
                "Thấp",
                "Trung bình",
                "Cao"
            });

            cboMucDoUuTien.Location = new Point(95, 347);
            cboMucDoUuTien.Name = "cboMucDoUuTien";
            cboMucDoUuTien.Size = new Size(150, 28);
            cboMucDoUuTien.TabIndex = 2;

            cboMucDoUuTien.SelectedIndexChanged +=
                cboMucDoUuTien_SelectedIndexChanged;

            // btnLuuGhiChu
            btnLuuGhiChu.BackColor = Color.WhiteSmoke;
            btnLuuGhiChu.Location = new Point(370, 342);
            btnLuuGhiChu.Name = "btnLuuGhiChu";
            btnLuuGhiChu.Size = new Size(105, 38);
            btnLuuGhiChu.TabIndex = 3;
            btnLuuGhiChu.Text = "Lưu";

            btnLuuGhiChu.UseVisualStyleBackColor = false;

            btnLuuGhiChu.Click += btnLuuGhiChu_Click;

            btnLuuGhiChu.MouseEnter +=
                btnLuuGhiChu_MouseEnter;

            btnLuuGhiChu.MouseLeave +=
                btnLuuGhiChu_MouseLeave;

            // errorProvider1
            errorProvider1.BlinkRate = 250;

            errorProvider1.BlinkStyle =
                ErrorBlinkStyle.BlinkIfDifferentError;

            errorProvider1.ContainerControl = this;

            // FormGhiChu
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;

            AutoValidate =
                AutoValidate.EnablePreventFocusChange;

            ClientSize = new Size(510, 410);

            Controls.Add(lblTieuDeForm);
            Controls.Add(txtTieuDe);

            Controls.Add(lblNoiDung);
            Controls.Add(txtNoiDung);

            Controls.Add(lblMucDo);
            Controls.Add(cboMucDoUuTien);

            Controls.Add(btnLuuGhiChu);

            KeyPreview = true;

            MinimizeBox = true;
            MaximizeBox = true;

            Name = "FormGhiChu";
            Text = "Ghi chú mới";

            KeyDown += FormGhiChu_KeyDown;
            FormClosing += FormGhiChu_FormClosing;

            ((System.ComponentModel.ISupportInitialize)errorProvider1)
                .EndInit();

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDeForm;
        private Label lblNoiDung;
        private Label lblMucDo;

        private TextBox txtTieuDe;
        private TextBox txtNoiDung;

        private ComboBox cboMucDoUuTien;

        private Button btnLuuGhiChu;

        private ErrorProvider errorProvider1;
    }
}