namespace NMCNPM_PMChoThueXe
{
    partial class FormAddUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkAnMatKhau = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.rbQuanLy = new System.Windows.Forms.RadioButton();
            this.rbKhachHang = new System.Windows.Forms.RadioButton();
            this.btnThemTaiKhoan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAnMatKhau);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(373, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(93, 27);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(271, 23);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(93, 63);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(271, 23);
            this.txtPassword.TabIndex = 3;
            // 
            // chkAnMatKhau
            // 
            this.chkAnMatKhau.AutoSize = true;
            this.chkAnMatKhau.Location = new System.Drawing.Point(93, 96);
            this.chkAnMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkAnMatKhau.Name = "chkAnMatKhau";
            this.chkAnMatKhau.Size = new System.Drawing.Size(106, 21);
            this.chkAnMatKhau.TabIndex = 4;
            this.chkAnMatKhau.Text = "Ẩn mật khẩu";
            this.chkAnMatKhau.UseVisualStyleBackColor = true;
            this.chkAnMatKhau.CheckedChanged += new System.EventHandler(this.chkAnMatKhau_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbKhachHang);
            this.groupBox2.Controls.Add(this.rbQuanLy);
            this.groupBox2.Controls.Add(this.rbAdmin);
            this.groupBox2.Location = new System.Drawing.Point(16, 159);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(373, 66);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại tài khoản";
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Checked = true;
            this.rbAdmin.Location = new System.Drawing.Point(12, 23);
            this.rbAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(65, 21);
            this.rbAdmin.TabIndex = 0;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rbQuanLy
            // 
            this.rbQuanLy.AutoSize = true;
            this.rbQuanLy.Location = new System.Drawing.Point(112, 23);
            this.rbQuanLy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbQuanLy.Name = "rbQuanLy";
            this.rbQuanLy.Size = new System.Drawing.Size(71, 21);
            this.rbQuanLy.TabIndex = 1;
            this.rbQuanLy.Text = "Quản lí";
            this.rbQuanLy.UseVisualStyleBackColor = true;
            // 
            // rbKhachHang
            // 
            this.rbKhachHang.AutoSize = true;
            this.rbKhachHang.Location = new System.Drawing.Point(215, 23);
            this.rbKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbKhachHang.Name = "rbKhachHang";
            this.rbKhachHang.Size = new System.Drawing.Size(102, 21);
            this.rbKhachHang.TabIndex = 2;
            this.rbKhachHang.Text = "Khách hàng";
            this.rbKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnThemTaiKhoan
            // 
            this.btnThemTaiKhoan.AutoSize = true;
            this.btnThemTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTaiKhoan.Location = new System.Drawing.Point(80, 256);
            this.btnThemTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemTaiKhoan.Name = "btnThemTaiKhoan";
            this.btnThemTaiKhoan.Size = new System.Drawing.Size(233, 33);
            this.btnThemTaiKhoan.TabIndex = 2;
            this.btnThemTaiKhoan.Text = "Thêm tài khoản";
            this.btnThemTaiKhoan.UseVisualStyleBackColor = true;
            this.btnThemTaiKhoan.Click += new System.EventHandler(this.btnThemTaiKhoan_Click);
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(405, 304);
            this.Controls.Add(this.btnThemTaiKhoan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAddUser";
            this.Text = "Thêm Tài Khoản";
            this.Load += new System.EventHandler(this.FormAddUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAnMatKhau;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbKhachHang;
        private System.Windows.Forms.RadioButton rbQuanLy;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.Button btnThemTaiKhoan;
    }
}