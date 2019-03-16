namespace NMCNPM_PMChoThueXe
{
    partial class FormDeleteCar
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
            this.dgvXoaXe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXoaXe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvXoaXe
            // 
            this.dgvXoaXe.AllowUserToAddRows = false;
            this.dgvXoaXe.AllowUserToDeleteRows = false;
            this.dgvXoaXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXoaXe.Location = new System.Drawing.Point(12, 12);
            this.dgvXoaXe.Name = "dgvXoaXe";
            this.dgvXoaXe.Size = new System.Drawing.Size(589, 371);
            this.dgvXoaXe.TabIndex = 0;
            this.dgvXoaXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXoaXe_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click chọn vào dòng muốn xóa";
            // 
            // FormDeleteCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(613, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvXoaXe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormDeleteCar";
            this.Text = "Xóa xe";
            this.Load += new System.EventHandler(this.FormDeleteCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXoaXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvXoaXe;
        private System.Windows.Forms.Label label1;
    }
}