namespace NMCNPM_PMChoThueXe
{
    partial class FormSetings
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
            this.gbDoiMatKhau = new System.Windows.Forms.GroupBox();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhapMatKhauCu = new System.Windows.Forms.TextBox();
            this.txtNhapMatKhauMoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhapLaiMatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAnMatKhauSetings = new System.Windows.Forms.CheckBox();
            this.gbDoiMatKhau.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDoiMatKhau
            // 
            this.gbDoiMatKhau.Controls.Add(this.txtNhapLaiMatKhau);
            this.gbDoiMatKhau.Controls.Add(this.label3);
            this.gbDoiMatKhau.Controls.Add(this.txtNhapMatKhauMoi);
            this.gbDoiMatKhau.Controls.Add(this.label2);
            this.gbDoiMatKhau.Controls.Add(this.txtNhapMatKhauCu);
            this.gbDoiMatKhau.Controls.Add(this.label1);
            this.gbDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDoiMatKhau.Location = new System.Drawing.Point(13, 13);
            this.gbDoiMatKhau.Name = "gbDoiMatKhau";
            this.gbDoiMatKhau.Size = new System.Drawing.Size(333, 119);
            this.gbDoiMatKhau.TabIndex = 0;
            this.gbDoiMatKhau.TabStop = false;
            this.gbDoiMatKhau.Text = "Thay đổi mật khẩu";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.AutoSize = true;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.Location = new System.Drawing.Point(245, 138);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(101, 35);
            this.btnDoiMatKhau.TabIndex = 1;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mật khẩu cũ:";
            // 
            // txtNhapMatKhauCu
            // 
            this.txtNhapMatKhauCu.Location = new System.Drawing.Point(139, 19);
            this.txtNhapMatKhauCu.Name = "txtNhapMatKhauCu";
            this.txtNhapMatKhauCu.Size = new System.Drawing.Size(188, 23);
            this.txtNhapMatKhauCu.TabIndex = 1;
            // 
            // txtNhapMatKhauMoi
            // 
            this.txtNhapMatKhauMoi.Location = new System.Drawing.Point(139, 48);
            this.txtNhapMatKhauMoi.Name = "txtNhapMatKhauMoi";
            this.txtNhapMatKhauMoi.Size = new System.Drawing.Size(188, 23);
            this.txtNhapMatKhauMoi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập mật khẩu mới:";
            // 
            // txtNhapLaiMatKhau
            // 
            this.txtNhapLaiMatKhau.Location = new System.Drawing.Point(139, 77);
            this.txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            this.txtNhapLaiMatKhau.Size = new System.Drawing.Size(188, 23);
            this.txtNhapLaiMatKhau.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhập lại:";
            // 
            // cbAnMatKhauSetings
            // 
            this.cbAnMatKhauSetings.AutoSize = true;
            this.cbAnMatKhauSetings.Location = new System.Drawing.Point(13, 139);
            this.cbAnMatKhauSetings.Name = "cbAnMatKhauSetings";
            this.cbAnMatKhauSetings.Size = new System.Drawing.Size(86, 17);
            this.cbAnMatKhauSetings.TabIndex = 2;
            this.cbAnMatKhauSetings.Text = "Ẩn mật khẩu";
            this.cbAnMatKhauSetings.UseVisualStyleBackColor = true;
            this.cbAnMatKhauSetings.CheckedChanged += new System.EventHandler(this.cbAnMatKhauSetings_CheckedChanged);
            // 
            // FormSetings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(358, 185);
            this.Controls.Add(this.cbAnMatKhauSetings);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.gbDoiMatKhau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormSetings";
            this.Text = "Setings";
            this.Load += new System.EventHandler(this.FormSetings_Load);
            this.gbDoiMatKhau.ResumeLayout(false);
            this.gbDoiMatKhau.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDoiMatKhau;
        private System.Windows.Forms.TextBox txtNhapLaiMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNhapMatKhauMoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhapMatKhauCu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.CheckBox cbAnMatKhauSetings;
    }
}