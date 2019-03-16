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
    public partial class FormTaoTaiKhoan : Form
    {
        /// <summary>
        /// Chuỗi kết nối đến db
        /// </summary>
        public static string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=QL_ThueXe;Integrated Security=True";

        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command;
        SqlDataReader dataReader;

        public FormTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            //Kiểm tra bỏ sót trường nào đó không nhập
            if (checkTextbox())
            {
                MessageBox.Show("Vui lòng kiểm tra lại các trường trên!", "Thông báo");
                return;
            }
            //Kiểm tra nhập lại mật khẩu mới không khớp
            if (!this.txtMatKhau.Text.Equals(this.txtNhapLaiMatKhau.Text))
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp! Vui lòng kiểm tra lại!", "Thông báo");
                return;
            }
            string queryFindSomeUser = "SELECT * FROM USERS WHERE UserName = @userName";
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            command = new SqlCommand(queryFindSomeUser, connection);
            command.Parameters.AddWithValue("@userName", this.txtTenTaiKhoan.Text);
            dataReader = command.ExecuteReader();
            dataReader.Read();
            if (dataReader.HasRows)
            {
                MessageBox.Show("Tài khoản đã tồn tại! Vui lòng chọn một tài khoản khác", "Thông báo");
                dataReader.Close();
                return;
            }
            else
            {
                dataReader.Close();
                //Thực hiện thêm tài khoản vào DB
                string queryAddUser = "INSERT INTO USERS(UserName, Position, Password, Type) VALUES(@username,@position,@passsword,@type)";
                SqlCommand command2;
                try
                {
                    command2 = new SqlCommand(queryAddUser, connection);
                    command2.Parameters.AddWithValue("@username", this.txtTenTaiKhoan.Text);
                    command2.Parameters.AddWithValue("@position", 0);
                    command2.Parameters.AddWithValue("@passsword", this.txtMatKhau.Text);
                    command2.Parameters.AddWithValue("@type", 2);
                    if (command2.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        /// <summary>
        /// Kiểm tra người dùng có bỏ sót ô nào không
        /// </summary>
        /// <returns></returns>
        private bool checkTextbox()
        {
            return string.IsNullOrEmpty(this.txtTenTaiKhoan.Text) ||
                string.IsNullOrEmpty(this.txtMatKhau.Text) ||
                string.IsNullOrEmpty(this.txtNhapLaiMatKhau.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.txtMatKhau.PasswordChar = '*';
                this.txtNhapLaiMatKhau.PasswordChar = '*';
            }
            else
            {
                this.txtMatKhau.PasswordChar = '\0';
                this.txtNhapLaiMatKhau.PasswordChar = '\0';
            }
        }

        /// <summary>
        /// Mở kết nối khi form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                connection.Close();
            }
        }
    }
}
