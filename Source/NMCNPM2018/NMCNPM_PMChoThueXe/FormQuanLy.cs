using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMCNPM_PMChoThueXe
{
    public partial class FormQuanLy : Form
    {
        /// <summary>
        /// Đối tượng lưu giữ giá trị màn hình cha
        /// </summary>
        FormDangNhap manHinhDangNhap;

        /// <summary>
        /// Chuỗi kết nối đến db
        /// </summary>
        public static string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=QL_ThueXe;Integrated Security=True";

        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command;
        SqlDataReader dataReader;
        string queryLogin;
        string queryFindActiveUser;

        /// <summary>
        /// Tên người đăng nhập
        /// </summary>
        public string name;
        /// <summary>
        /// Biến lưu kiểu tài khoản
        /// </summary>
        private int Itype = -1;

        public FormQuanLy(FormDangNhap m)
        {
            manHinhDangNhap = m;
            InitializeComponent();
        }

        #region Menu
        private void menuXemDanhSachXe_Click(object sender, EventArgs e)
        {
            FormXemDanhSachXe form = new FormXemDanhSachXe();
            form.ShowDialog();
        }

        private void MenuThemXe_Click(object sender, EventArgs e)
        {
            FormAddCar addCar = new FormAddCar();
            addCar.ShowDialog();
        }

        private void MenuCapNhatXe_Click(object sender, EventArgs e)
        {
            FormUpdateCar updateCar = new FormUpdateCar();
            updateCar.ShowDialog();
        }

        private void menuXoaXe_Click(object sender, EventArgs e)
        {
            FormDeleteCar deleteCar = new FormDeleteCar();
            deleteCar.ShowDialog();
        }

        private void menuCapNhatKhachHang_Click(object sender, EventArgs e)
        {
            FormUpdateCustomer updateCustomer = new FormUpdateCustomer();
            updateCustomer.ShowDialog();
        }

        private void menuThemKhachHang_Click(object sender, EventArgs e)
        {
            FormAddCustomer addCustomer = new FormAddCustomer();
            addCustomer.ShowDialog();
        }

        private void menuDatThueXe_Click(object sender, EventArgs e)
        {
            FormDatXe datXe = new FormDatXe();
            datXe.ShowDialog();
        }

        private void menuHienThiDanhSach_Click(object sender, EventArgs e)
        {
            FormHienThiDatXe hienThiDatXe = new FormHienThiDatXe();
            hienThiDatXe.ShowDialog();
        }

        private void menuHuyDatXe_Click(object sender, EventArgs e)
        {
            FormHuyDatXe formHuyDatXe = new FormHuyDatXe();
            formHuyDatXe.ShowDialog();
        }

        private void menuThemTaiKhoan_Click(object sender, EventArgs e)
        {
            FormAddUser formAddUser = new FormAddUser();
            formAddUser.ShowDialog();
        }

        private void menuCapNhatTaiKhoan_Click(object sender, EventArgs e)
        {
            FormUpdateUser formUpdateUser = new FormUpdateUser();
            formUpdateUser.ShowDialog();
        }

        private void menuXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            FormDeleteUser formDeleteUser = new FormDeleteUser();
            formDeleteUser.ShowDialog();
        }

        private void menuThongTinDoAn_Click(object sender, EventArgs e)
        {
            FormThongTin thongTin = new FormThongTin();
            thongTin.ShowDialog();
        }

        #endregion

        #region Events
        /// <summary>
        /// Xử lí trước khi đóng form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmQuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Chuyen trang thai thanh offline khi nguoi dung thoat
            queryLogin = "UPDATE USERS SET Position=0 WHERE Position=1;";

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                command = new SqlCommand(queryLogin, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                connection.Close();
            }
            finally
            {
                connection.Close();
                command.Cancel();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string s = DateTime.Now.DayOfWeek.ToString().ToUpper();
            lbDate.Text = s + ", " + Convert.ToString(DateTime.Now.Date).Substring(0, 10);
            lbTime.Text = Convert.ToString(DateTime.Now.TimeOfDay).Substring(0, 8);
        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            timer1_Tick(null, null);
            setUserLabel();
            //Nếu người đăng nhập không phải admin thì không được thêm xóa sửa tài khoản
            if (this.Itype != 0)
            {
                this.menuThemTaiKhoan.Enabled = false;
                this.menuCapNhatTaiKhoan.Enabled = false;
                this.menuXoaTaiKhoan.Enabled = false;
            }

        }

        private void frmQuanLy_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.manHinhDangNhap.Show();
        }

        /// <summary>
        /// Xử lí đăng xuất
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ltLogout_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn đăng xuất không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
        /// <summary>
        /// Cài đặt cho tài khoản
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbSetings_MouseClick(object sender, MouseEventArgs e)
        {
            FormSetings setings = new FormSetings(this);
            setings.ShowDialog();
        }
        #endregion

        #region Methods
        /// <summary>
        /// set hình user và lời chào
        /// </summary>
        public void setUserLabel()
        {
            //chọn ra người đang online
            queryFindActiveUser = "SELECT UserName, Type FROM USERS WHERE Position=1";

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                command = new SqlCommand(queryFindActiveUser, connection);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                if (dataReader.HasRows)
                {
                    name = dataReader["UserName"].ToString();
                    Itype = int.Parse(dataReader["Type"].ToString());
                    this.lbXinChao.Text = "Xin chào " + name + "!";
                    //Trường hợp admin đăng nhập!
                    if (dataReader["Type"].ToString().Equals("0"))
                    {
                        this.pbUserLQ.Image = Properties.Resources.admin;
                    }
                    else
                    {
                        //Trường hợp quản lý
                        if (dataReader["Type"].ToString().Equals("1"))
                        {
                            this.pbUserLQ.Image = Properties.Resources.manager;
                        }
                        else
                        {
                            this.pbUserLQ.Image = Properties.Resources.customer;
                        }
                    }
                    dataReader.Close();
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                connection.Close();
            }
            finally
            {
                connection.Close();
                command.Cancel();
            }
        }




        #endregion


    }
}
