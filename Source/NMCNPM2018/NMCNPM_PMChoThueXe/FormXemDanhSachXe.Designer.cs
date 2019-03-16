namespace NMCNPM_PMChoThueXe
{
    partial class FormXemDanhSachXe
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
            this.dgvDanhSachXeTrongHeThong = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachXeTrongHeThong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSachXeTrongHeThong);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(704, 428);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiển thị thông tin danh sách xe trong hệ thống";
            // 
            // dgvDanhSachXeTrongHeThong
            // 
            this.dgvDanhSachXeTrongHeThong.AllowUserToAddRows = false;
            this.dgvDanhSachXeTrongHeThong.AllowUserToDeleteRows = false;
            this.dgvDanhSachXeTrongHeThong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachXeTrongHeThong.EnableHeadersVisualStyles = false;
            this.dgvDanhSachXeTrongHeThong.Location = new System.Drawing.Point(0, 17);
            this.dgvDanhSachXeTrongHeThong.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDanhSachXeTrongHeThong.Name = "dgvDanhSachXeTrongHeThong";
            this.dgvDanhSachXeTrongHeThong.RowTemplate.Height = 24;
            this.dgvDanhSachXeTrongHeThong.Size = new System.Drawing.Size(700, 407);
            this.dgvDanhSachXeTrongHeThong.TabIndex = 0;
            // 
            // FormXemDanhSachXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormXemDanhSachXe";
            this.Text = "FormXemDanhSachXe";
            this.Load += new System.EventHandler(this.FormXemDanhSachXe_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachXeTrongHeThong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDanhSachXeTrongHeThong;
    }
}