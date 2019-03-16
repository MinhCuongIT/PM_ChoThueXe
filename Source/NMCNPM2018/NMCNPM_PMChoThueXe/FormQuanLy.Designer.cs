namespace NMCNPM_PMChoThueXe
{
    partial class FormQuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLy));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLíXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuXemDanhSachXe = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuThemXe = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCapNhatXe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuXoaXe = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCapNhatKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThemKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíĐặtXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDatThueXe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHienThiDanhSach = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHuyDatXe = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThemTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCapNhatTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuXoaTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongTinDoAn = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ltLogout = new System.Windows.Forms.LinkLabel();
            this.lbSetings = new System.Windows.Forms.LinkLabel();
            this.lbXinChao = new System.Windows.Forms.Label();
            this.pbUserLQ = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserLQ)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíXeToolStripMenuItem,
            this.quảnLýKháchHàngToolStripMenuItem,
            this.quảnLíĐặtXeToolStripMenuItem,
            this.quảnLíTàiKhoảnToolStripMenuItem,
            this.menuThongTinDoAn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLíXeToolStripMenuItem
            // 
            this.quảnLíXeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuXemDanhSachXe,
            this.MenuThemXe,
            this.MenuCapNhatXe,
            this.menuXoaXe});
            this.quảnLíXeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLíXeToolStripMenuItem.Name = "quảnLíXeToolStripMenuItem";
            this.quảnLíXeToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.quảnLíXeToolStripMenuItem.Text = "Quản lí xe";
            // 
            // menuXemDanhSachXe
            // 
            this.menuXemDanhSachXe.Name = "menuXemDanhSachXe";
            this.menuXemDanhSachXe.Size = new System.Drawing.Size(197, 24);
            this.menuXemDanhSachXe.Text = "Xem danh sách xe";
            this.menuXemDanhSachXe.Click += new System.EventHandler(this.menuXemDanhSachXe_Click);
            // 
            // MenuThemXe
            // 
            this.MenuThemXe.Name = "MenuThemXe";
            this.MenuThemXe.Size = new System.Drawing.Size(197, 24);
            this.MenuThemXe.Text = "Thêm xe";
            this.MenuThemXe.Click += new System.EventHandler(this.MenuThemXe_Click);
            // 
            // MenuCapNhatXe
            // 
            this.MenuCapNhatXe.Name = "MenuCapNhatXe";
            this.MenuCapNhatXe.Size = new System.Drawing.Size(197, 24);
            this.MenuCapNhatXe.Text = "Cập nhật xe";
            this.MenuCapNhatXe.Click += new System.EventHandler(this.MenuCapNhatXe_Click);
            // 
            // menuXoaXe
            // 
            this.menuXoaXe.Name = "menuXoaXe";
            this.menuXoaXe.Size = new System.Drawing.Size(197, 24);
            this.menuXoaXe.Text = "Xóa xe";
            this.menuXoaXe.Click += new System.EventHandler(this.menuXoaXe_Click);
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            this.quảnLýKháchHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCapNhatKhachHang,
            this.menuThemKhachHang});
            this.quảnLýKháchHàngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            // 
            // menuCapNhatKhachHang
            // 
            this.menuCapNhatKhachHang.Name = "menuCapNhatKhachHang";
            this.menuCapNhatKhachHang.Size = new System.Drawing.Size(216, 24);
            this.menuCapNhatKhachHang.Text = "Cập nhật khách hàng";
            this.menuCapNhatKhachHang.Click += new System.EventHandler(this.menuCapNhatKhachHang_Click);
            // 
            // menuThemKhachHang
            // 
            this.menuThemKhachHang.Name = "menuThemKhachHang";
            this.menuThemKhachHang.Size = new System.Drawing.Size(216, 24);
            this.menuThemKhachHang.Text = "Thêm khách hàng";
            this.menuThemKhachHang.Click += new System.EventHandler(this.menuThemKhachHang_Click);
            // 
            // quảnLíĐặtXeToolStripMenuItem
            // 
            this.quảnLíĐặtXeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDatThueXe,
            this.menuHienThiDanhSach,
            this.menuHuyDatXe});
            this.quảnLíĐặtXeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLíĐặtXeToolStripMenuItem.Name = "quảnLíĐặtXeToolStripMenuItem";
            this.quảnLíĐặtXeToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.quảnLíĐặtXeToolStripMenuItem.Text = "Quản lí đặt xe";
            // 
            // menuDatThueXe
            // 
            this.menuDatThueXe.Name = "menuDatThueXe";
            this.menuDatThueXe.Size = new System.Drawing.Size(200, 24);
            this.menuDatThueXe.Text = "Đặt thuê xe";
            this.menuDatThueXe.Click += new System.EventHandler(this.menuDatThueXe_Click);
            // 
            // menuHienThiDanhSach
            // 
            this.menuHienThiDanhSach.Name = "menuHienThiDanhSach";
            this.menuHienThiDanhSach.Size = new System.Drawing.Size(200, 24);
            this.menuHienThiDanhSach.Text = "Hiện thị danh sách";
            this.menuHienThiDanhSach.Click += new System.EventHandler(this.menuHienThiDanhSach_Click);
            // 
            // menuHuyDatXe
            // 
            this.menuHuyDatXe.Name = "menuHuyDatXe";
            this.menuHuyDatXe.Size = new System.Drawing.Size(200, 24);
            this.menuHuyDatXe.Text = "Hủy đặt xe";
            this.menuHuyDatXe.Click += new System.EventHandler(this.menuHuyDatXe_Click);
            // 
            // quảnLíTàiKhoảnToolStripMenuItem
            // 
            this.quảnLíTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuThemTaiKhoan,
            this.menuCapNhatTaiKhoan,
            this.menuXoaTaiKhoan});
            this.quảnLíTàiKhoảnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLíTàiKhoảnToolStripMenuItem.Name = "quảnLíTàiKhoảnToolStripMenuItem";
            this.quảnLíTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.quảnLíTàiKhoảnToolStripMenuItem.Text = "Quản lí tài khoản";
            // 
            // menuThemTaiKhoan
            // 
            this.menuThemTaiKhoan.Name = "menuThemTaiKhoan";
            this.menuThemTaiKhoan.Size = new System.Drawing.Size(202, 24);
            this.menuThemTaiKhoan.Text = "Thêm tài khoản";
            this.menuThemTaiKhoan.Click += new System.EventHandler(this.menuThemTaiKhoan_Click);
            // 
            // menuCapNhatTaiKhoan
            // 
            this.menuCapNhatTaiKhoan.Name = "menuCapNhatTaiKhoan";
            this.menuCapNhatTaiKhoan.Size = new System.Drawing.Size(202, 24);
            this.menuCapNhatTaiKhoan.Text = "Cập nhật tài khoản";
            this.menuCapNhatTaiKhoan.Click += new System.EventHandler(this.menuCapNhatTaiKhoan_Click);
            // 
            // menuXoaTaiKhoan
            // 
            this.menuXoaTaiKhoan.Name = "menuXoaTaiKhoan";
            this.menuXoaTaiKhoan.Size = new System.Drawing.Size(202, 24);
            this.menuXoaTaiKhoan.Text = "Xóa tài khoản";
            this.menuXoaTaiKhoan.Click += new System.EventHandler(this.menuXoaTaiKhoan_Click);
            // 
            // menuThongTinDoAn
            // 
            this.menuThongTinDoAn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuThongTinDoAn.Name = "menuThongTinDoAn";
            this.menuThongTinDoAn.Size = new System.Drawing.Size(126, 24);
            this.menuThongTinDoAn.Text = "Thông tin đồ án";
            this.menuThongTinDoAn.Click += new System.EventHandler(this.menuThongTinDoAn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ THUÊ XE";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.DarkRed;
            this.lbTime.Location = new System.Drawing.Point(254, 152);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(81, 37);
            this.lbTime.TabIndex = 2;
            this.lbTime.Text = "time";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.DarkRed;
            this.lbDate.Location = new System.Drawing.Point(131, 92);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(88, 37);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(98, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.ltLogout);
            this.panel1.Controls.Add(this.lbSetings);
            this.panel1.Controls.Add(this.lbXinChao);
            this.panel1.Controls.Add(this.pbUserLQ);
            this.panel1.Location = new System.Drawing.Point(608, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 157);
            this.panel1.TabIndex = 5;
            // 
            // ltLogout
            // 
            this.ltLogout.AutoSize = true;
            this.ltLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltLogout.Location = new System.Drawing.Point(110, 126);
            this.ltLogout.Name = "ltLogout";
            this.ltLogout.Size = new System.Drawing.Size(63, 15);
            this.ltLogout.TabIndex = 3;
            this.ltLogout.TabStop = true;
            this.ltLogout.Text = "Đăng xuất";
            this.ltLogout.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ltLogout_MouseClick);
            // 
            // lbSetings
            // 
            this.lbSetings.AutoSize = true;
            this.lbSetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSetings.Location = new System.Drawing.Point(7, 126);
            this.lbSetings.Name = "lbSetings";
            this.lbSetings.Size = new System.Drawing.Size(48, 15);
            this.lbSetings.TabIndex = 2;
            this.lbSetings.TabStop = true;
            this.lbSetings.Text = "Setings";
            this.lbSetings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbSetings_MouseClick);
            // 
            // lbXinChao
            // 
            this.lbXinChao.AutoSize = true;
            this.lbXinChao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXinChao.Location = new System.Drawing.Point(7, 7);
            this.lbXinChao.Name = "lbXinChao";
            this.lbXinChao.Size = new System.Drawing.Size(151, 17);
            this.lbXinChao.TabIndex = 1;
            this.lbXinChao.Text = "Xin chào username!";
            // 
            // pbUserLQ
            // 
            this.pbUserLQ.Location = new System.Drawing.Point(47, 27);
            this.pbUserLQ.Name = "pbUserLQ";
            this.pbUserLQ.Size = new System.Drawing.Size(84, 81);
            this.pbUserLQ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserLQ.TabIndex = 0;
            this.pbUserLQ.TabStop = false;
            // 
            // FormQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormQuanLy";
            this.Text = "Quản lý xe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLy_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmQuanLy_FormClosed);
            this.Load += new System.EventHandler(this.frmQuanLy_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserLQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLíXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíĐặtXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuThongTinDoAn;
        private System.Windows.Forms.ToolStripMenuItem menuXemDanhSachXe;
        private System.Windows.Forms.ToolStripMenuItem MenuThemXe;
        private System.Windows.Forms.ToolStripMenuItem MenuCapNhatXe;
        private System.Windows.Forms.ToolStripMenuItem menuXoaXe;
        private System.Windows.Forms.ToolStripMenuItem menuCapNhatKhachHang;
        private System.Windows.Forms.ToolStripMenuItem menuDatThueXe;
        private System.Windows.Forms.ToolStripMenuItem menuHienThiDanhSach;
        private System.Windows.Forms.ToolStripMenuItem menuHuyDatXe;
        private System.Windows.Forms.ToolStripMenuItem menuThemTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem menuCapNhatTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem menuXoaTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbUserLQ;
        private System.Windows.Forms.LinkLabel ltLogout;
        private System.Windows.Forms.LinkLabel lbSetings;
        private System.Windows.Forms.Label lbXinChao;
        private System.Windows.Forms.ToolStripMenuItem menuThemKhachHang;
    }
}