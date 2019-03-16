namespace NMCNPM_PMChoThueXe
{
    partial class FormHienThiDatXe
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvHienThiThongTinDatXe = new System.Windows.Forms.DataGridView();
            this.chkName = new System.Windows.Forms.CheckBox();
            this.chkCMND = new System.Windows.Forms.CheckBox();
            this.chkBrand = new System.Windows.Forms.CheckBox();
            this.chkModel = new System.Windows.Forms.CheckBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThiThongTinDatXe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHienThiThongTinDatXe);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 349);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách thông tin đặt xe";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Controls.Add(this.chkModel);
            this.groupBox2.Controls.Add(this.chkBrand);
            this.groupBox2.Controls.Add(this.chkCMND);
            this.groupBox2.Controls.Add(this.chkName);
            this.groupBox2.Location = new System.Drawing.Point(12, 367);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 71);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bộ lọc";
            // 
            // dgvHienThiThongTinDatXe
            // 
            this.dgvHienThiThongTinDatXe.AllowUserToAddRows = false;
            this.dgvHienThiThongTinDatXe.AllowUserToDeleteRows = false;
            this.dgvHienThiThongTinDatXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThiThongTinDatXe.Location = new System.Drawing.Point(6, 19);
            this.dgvHienThiThongTinDatXe.Name = "dgvHienThiThongTinDatXe";
            this.dgvHienThiThongTinDatXe.RowHeadersVisible = false;
            this.dgvHienThiThongTinDatXe.Size = new System.Drawing.Size(764, 324);
            this.dgvHienThiThongTinDatXe.TabIndex = 0;
            // 
            // chkName
            // 
            this.chkName.AutoSize = true;
            this.chkName.Location = new System.Drawing.Point(6, 31);
            this.chkName.Name = "chkName";
            this.chkName.Size = new System.Drawing.Size(45, 17);
            this.chkName.TabIndex = 0;
            this.chkName.Text = "Tên";
            this.chkName.UseVisualStyleBackColor = true;
            this.chkName.CheckedChanged += new System.EventHandler(this.chkName_CheckedChanged);
            // 
            // chkCMND
            // 
            this.chkCMND.AutoSize = true;
            this.chkCMND.Location = new System.Drawing.Point(74, 31);
            this.chkCMND.Name = "chkCMND";
            this.chkCMND.Size = new System.Drawing.Size(58, 17);
            this.chkCMND.TabIndex = 1;
            this.chkCMND.Text = "CMND";
            this.chkCMND.UseVisualStyleBackColor = true;
            this.chkCMND.CheckedChanged += new System.EventHandler(this.chkCMND_CheckedChanged);
            // 
            // chkBrand
            // 
            this.chkBrand.AutoSize = true;
            this.chkBrand.Location = new System.Drawing.Point(162, 31);
            this.chkBrand.Name = "chkBrand";
            this.chkBrand.Size = new System.Drawing.Size(86, 17);
            this.chkBrand.TabIndex = 2;
            this.chkBrand.Text = "Thương hiệu";
            this.chkBrand.UseVisualStyleBackColor = true;
            this.chkBrand.CheckedChanged += new System.EventHandler(this.chkBrand_CheckedChanged);
            // 
            // chkModel
            // 
            this.chkModel.AutoSize = true;
            this.chkModel.Location = new System.Drawing.Point(270, 31);
            this.chkModel.Name = "chkModel";
            this.chkModel.Size = new System.Drawing.Size(55, 17);
            this.chkModel.TabIndex = 3;
            this.chkModel.Text = "Model";
            this.chkModel.UseVisualStyleBackColor = true;
            this.chkModel.CheckedChanged += new System.EventHandler(this.chkModel_CheckedChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Enabled = false;
            this.txtTimKiem.Location = new System.Drawing.Point(344, 29);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(275, 20);
            this.txtTimKiem.TabIndex = 4;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(647, 19);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(88, 39);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // FormHienThiDatXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormHienThiDatXe";
            this.Text = "Hiển thị thông tin đặt xe";
            this.Load += new System.EventHandler(this.FormHienThiDatXe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThiThongTinDatXe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHienThiThongTinDatXe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.CheckBox chkModel;
        private System.Windows.Forms.CheckBox chkBrand;
        private System.Windows.Forms.CheckBox chkCMND;
        private System.Windows.Forms.CheckBox chkName;
    }
}