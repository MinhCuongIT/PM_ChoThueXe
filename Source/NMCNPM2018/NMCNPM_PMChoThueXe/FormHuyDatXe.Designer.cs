namespace NMCNPM_PMChoThueXe
{
    partial class FormHuyDatXe
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
            this.dgvXoaDatXe = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXoaDatXe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvXoaDatXe);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 406);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiển thị danh sách đã thuê";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(655, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click chọn dòng muốn xóa";
            // 
            // dgvXoaDatXe
            // 
            this.dgvXoaDatXe.AllowUserToAddRows = false;
            this.dgvXoaDatXe.AllowUserToDeleteRows = false;
            this.dgvXoaDatXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXoaDatXe.Location = new System.Drawing.Point(6, 19);
            this.dgvXoaDatXe.Name = "dgvXoaDatXe";
            this.dgvXoaDatXe.RowHeadersVisible = false;
            this.dgvXoaDatXe.Size = new System.Drawing.Size(770, 381);
            this.dgvXoaDatXe.TabIndex = 0;
            this.dgvXoaDatXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXoaDatXe_CellClick);
            // 
            // FormHuyDatXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormHuyDatXe";
            this.Text = "Hủy đặt xe";
            this.Load += new System.EventHandler(this.FormHuyDatXe_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXoaDatXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvXoaDatXe;
        private System.Windows.Forms.Label label1;
    }
}