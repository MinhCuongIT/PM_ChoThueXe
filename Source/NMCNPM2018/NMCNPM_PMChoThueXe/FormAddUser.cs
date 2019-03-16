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
    public partial class FormAddUser : Form
    {
        /// <summary>
        /// Chuỗi kết nối đến db
        /// </summary>
        public static string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=QL_ThueXe;Integrated Security=True";

        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command;
        SqlDataReader dataReader;

        public FormAddUser()
        {
            InitializeComponent();
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            if (!checkTextBox())
            {
                string queryFindSomeUser = "SELECT * FROM USERS WHERE UserName = @userName";
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                command = new SqlCommand(queryFindSomeUser, connection);
                command.Parameters.AddWithValue("@userName", this.txtUsername.Text);
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
                        command2.Parameters.AddWithValue("@username", this.txtUsername.Text);
                        command2.Parameters.AddWithValue("@position", 0);
                        command2.Parameters.AddWithValue("@passsword", this.txtPassword.Text);
                        command2.Parameters.AddWithValue("@type", getAcountType());
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
            else
            {
                MessageBox.Show("Bạn vui lòng kiểm tra các trường bên trên!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void chkAnMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkAnMatKhau.Checked)
            {
                this.txtPassword.PasswordChar = '*';
            }
            else
            {
                this.txtPassword.PasswordChar = '\0';
            }
        }

        private int getAcountType()
        {
            if (this.rbAdmin.Checked)
            {
                return 0;
            }
            if (this.rbQuanLy.Checked)
            {
                return 1;
            }
            return 2;
        }

        private bool checkTextBox()
        {
            return string.IsNullOrEmpty(this.txtUsername.Text) ||
                string.IsNullOrEmpty(this.txtPassword.Text);
        }

        private void FormAddUser_Load(object sender, EventArgs e)
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
