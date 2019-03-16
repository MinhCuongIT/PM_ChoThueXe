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
    public partial class FormUpdateUser : Form
    {
        /// <summary>
        /// Chuỗi kết nối đến db
        /// </summary>
        public static string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=QL_ThueXe;Integrated Security=True";

        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command;

        public FormUpdateUser()
        {
            InitializeComponent();
        }

        private void btnXoaTruong_Click(object sender, EventArgs e)
        {
            this.txtUsername.Clear();
            this.txtOldPassword.Clear();
            this.txtNewPassword.Clear();
            this.txtRetypePassword.Clear();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            //Kiểm tra các trường có bị bỏ trống hay không?
            if (checkFields())
            {
                MessageBox.Show("Bạn vui lòng kiểm tra lại các trường trên!", "Thông báo");
                return;
            }
            //Kiểm tra sự tồn tại của user cũ
            string findSomeUsers = "SELECT * FROM USERS WHERE UserName = @userName AND Password = @password";
            var command2 = new SqlCommand(findSomeUsers, connection);
            command2.Parameters.AddWithValue("@userName", this.txtUsername.Text);
            command2.Parameters.AddWithValue("@password", this.txtOldPassword.Text);
            SqlDataReader reader = command2.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                reader.Close();
                //Có tài khoản thì mới cập nhật được
                if (this.txtNewPassword.Text.Equals(this.txtRetypePassword.Text))
                {
                    string queryUpdate = "UPDATE USERS SET Password=@pass WHERE UserName=@user";
                    command = new SqlCommand(queryUpdate, connection);
                    try
                    {
                        command.Parameters.AddWithValue("@pass", this.txtNewPassword.Text);
                        command.Parameters.AddWithValue("@user", this.txtUsername.Text);
                        if (command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Có lỗi:\n" + err);
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới không khớp!", "Thông báo");
                    return;
                }
            }
            else
            {
                reader.Close();
                MessageBox.Show("Tài khoản không tồn tại hoặc mật khẩu sai! Vui lòng kiểm tra lại!", "Thông báo");
                return;
            }
            //Cập nhật user
        }

        private bool checkFields()
        {
            return string.IsNullOrEmpty(this.txtUsername.Text) ||
                string.IsNullOrEmpty(this.txtOldPassword.Text) ||
                string.IsNullOrEmpty(this.txtNewPassword.Text) ||
                string.IsNullOrEmpty(this.txtRetypePassword.Text);
        }

        private void chkAnMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkAnMatKhau.Checked)
            {
                this.txtOldPassword.PasswordChar = '*';
                this.txtNewPassword.PasswordChar = '*';
                this.txtRetypePassword.PasswordChar = '*';
            }
            else
            {
                this.txtOldPassword.PasswordChar = '\0';
                this.txtNewPassword.PasswordChar = '\0';
                this.txtRetypePassword.PasswordChar = '\0';
            }
        }

        private void FormUpdateUser_Load(object sender, EventArgs e)
        {
            //Mở kết nối
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
