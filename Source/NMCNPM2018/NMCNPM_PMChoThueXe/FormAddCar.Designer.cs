namespace NMCNPM_PMChoThueXe
{
    partial class FormAddCar
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
            this.components = new System.ComponentModel.Container();
            this.btnXoaCacTruongThemXeMoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThemXeMoi = new System.Windows.Forms.Button();
            this.cbFuel = new System.Windows.Forms.ComboBox();
            this.cbGearBox = new System.Windows.Forms.ComboBox();
            this.errThemXe = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbThemXeMoi = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errThemXe)).BeginInit();
            this.gbThemXeMoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoaCacTruongThemXeMoi
            // 
            this.btnXoaCacTruongThemXeMoi.AutoSize = true;
            this.btnXoaCacTruongThemXeMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCacTruongThemXeMoi.Location = new System.Drawing.Point(12, 345);
            this.btnXoaCacTruongThemXeMoi.Name = "btnXoaCacTruongThemXeMoi";
            this.btnXoaCacTruongThemXeMoi.Size = new System.Drawing.Size(149, 34);
            this.btnXoaCacTruongThemXeMoi.TabIndex = 8;
            this.btnXoaCacTruongThemXeMoi.Text = "Xóa các trường";
            this.btnXoaCacTruongThemXeMoi.UseVisualStyleBackColor = true;
            this.btnXoaCacTruongThemXeMoi.Click += new System.EventHandler(this.btnXoaCacTruongThemXeMoi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Thêm xe mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brand:";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(117, 86);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(198, 23);
            this.txtBrand.TabIndex = 0;
            this.txtBrand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBrand_KeyPress);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(117, 115);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(198, 23);
            this.txtModel.TabIndex = 1;
            this.txtModel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModel_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Model:";
            // 
            // txtProductYear
            // 
            this.txtProductYear.Location = new System.Drawing.Point(117, 144);
            this.txtProductYear.Name = "txtProductYear";
            this.txtProductYear.Size = new System.Drawing.Size(198, 23);
            this.txtProductYear.TabIndex = 2;
            this.txtProductYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductYear_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Product Year:";
            // 
            // txtPlate
            // 
            this.txtPlate.Location = new System.Drawing.Point(117, 173);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(198, 23);
            this.txtPlate.TabIndex = 3;
            this.txtPlate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlate_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Plate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fuel:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Gear Box:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(117, 262);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(198, 23);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Price:";
            // 
            // btnThemXeMoi
            // 
            this.btnThemXeMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemXeMoi.Location = new System.Drawing.Point(240, 345);
            this.btnThemXeMoi.Name = "btnThemXeMoi";
            this.btnThemXeMoi.Size = new System.Drawing.Size(100, 34);
            this.btnThemXeMoi.TabIndex = 7;
            this.btnThemXeMoi.Text = "Thêm";
            this.btnThemXeMoi.UseVisualStyleBackColor = true;
            this.btnThemXeMoi.Click += new System.EventHandler(this.btnThemXeMoi_Click);
            // 
            // cbFuel
            // 
            this.cbFuel.FormattingEnabled = true;
            this.cbFuel.Items.AddRange(new object[] {
            "Xăng",
            "Dầu",
            "Điện",
            "Khí Gas"});
            this.cbFuel.Location = new System.Drawing.Point(117, 202);
            this.cbFuel.Name = "cbFuel";
            this.cbFuel.Size = new System.Drawing.Size(198, 24);
            this.cbFuel.TabIndex = 4;
            // 
            // cbGearBox
            // 
            this.cbGearBox.FormattingEnabled = true;
            this.cbGearBox.Items.AddRange(new object[] {
            "Số Sàn",
            "Số Tự Động",
            "Số Kết Hợp"});
            this.cbGearBox.Location = new System.Drawing.Point(117, 232);
            this.cbGearBox.Name = "cbGearBox";
            this.cbGearBox.Size = new System.Drawing.Size(198, 24);
            this.cbGearBox.TabIndex = 5;
            // 
            // errThemXe
            // 
            this.errThemXe.ContainerControl = this;
            // 
            // gbThemXeMoi
            // 
            this.gbThemXeMoi.Controls.Add(this.label1);
            this.gbThemXeMoi.Controls.Add(this.cbGearBox);
            this.gbThemXeMoi.Controls.Add(this.txtBrand);
            this.gbThemXeMoi.Controls.Add(this.cbFuel);
            this.gbThemXeMoi.Controls.Add(this.label4);
            this.gbThemXeMoi.Controls.Add(this.txtProductYear);
            this.gbThemXeMoi.Controls.Add(this.txtPrice);
            this.gbThemXeMoi.Controls.Add(this.txtModel);
            this.gbThemXeMoi.Controls.Add(this.label8);
            this.gbThemXeMoi.Controls.Add(this.label5);
            this.gbThemXeMoi.Controls.Add(this.label3);
            this.gbThemXeMoi.Controls.Add(this.label7);
            this.gbThemXeMoi.Controls.Add(this.txtPlate);
            this.gbThemXeMoi.Controls.Add(this.label2);
            this.gbThemXeMoi.Controls.Add(this.label6);
            this.gbThemXeMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThemXeMoi.Location = new System.Drawing.Point(13, 12);
            this.gbThemXeMoi.Name = "gbThemXeMoi";
            this.gbThemXeMoi.Size = new System.Drawing.Size(347, 309);
            this.gbThemXeMoi.TabIndex = 17;
            this.gbThemXeMoi.TabStop = false;
            this.gbThemXeMoi.Text = "Thêm một xe mới";
            // 
            // FormAddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(372, 401);
            this.Controls.Add(this.gbThemXeMoi);
            this.Controls.Add(this.btnXoaCacTruongThemXeMoi);
            this.Controls.Add(this.btnThemXeMoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormAddCar";
            this.Text = "Thêm xe";
            this.Load += new System.EventHandler(this.FormAddCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errThemXe)).EndInit();
            this.gbThemXeMoi.ResumeLayout(false);
            this.gbThemXeMoi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemXeMoi;
        private System.Windows.Forms.Button btnXoaCacTruongThemXeMoi;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGearBox;
        private System.Windows.Forms.ComboBox cbFuel;
        private System.Windows.Forms.ErrorProvider errThemXe;
        private System.Windows.Forms.GroupBox gbThemXeMoi;
    }
}