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
    public partial class FormSetings : Form
    {
        FormQuanLy fql;

        public static string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=QL_ThueXe;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command;
        SqlDataReader dataReader;

        public FormSetings(FormQuanLy f)
        {
            this.fql = f;
            InitializeComponent();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string queryControlPass = "SELECT Password FROM USERS WHERE UserName=@name AND Password=@pass;";
            string queryChangePass = "UPDATE USERS SET Password=@Newpass WHERE UserName=@name AND Password=@Oldpass;";

            if (!IsNull())
            {
                if (IsSameNewPass())
                {
                    try
                    {
                        if (connection.State == ConnectionState.Closed)
                            connection.Open();
                        command = new SqlCommand(queryControlPass, connection);
                        command.Parameters.AddWithValue("@name", this.fql.name);
                        command.Parameters.AddWithValue("@pass", this.txtNhapMatKhauCu.Text);
                        dataReader = command.ExecuteReader();
                        dataReader.Read();
                        if (dataReader.HasRows)
                        {
                            try
                            {
                                dataReader.Close();
                                command = new SqlCommand(queryChangePass, connection);
                                command.Parameters.AddWithValue("@Newpass", this.txtNhapMatKhauMoi.Text);
                                command.Parameters.AddWithValue("@name", this.fql.name);
                                command.Parameters.AddWithValue("@Oldpass", this.txtNhapMatKhauCu.Text);
                                if (command.ExecuteNonQuery() > 0)
                                {
                                    MessageBox.Show("Mật khẩu đã được thay đổi thành công!");
                                    this.Close();
                                }
                                else
                                    MessageBox.Show("Đổi mật khẩu thất bại!");
                            }
                            catch (Exception error)
                            {
                                MessageBox.Show(error.Message);
                                connection.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu cũ không đúng!\nVui lòng kiểm tra lại!");
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                    finally
                    {
                        dataReader.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu không khớp! Vui lòng kiểm tra lại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại các trường!", "Thông báo");
            }
        }

        /// <summary>
        /// Nhập lại mật khẩu phải khớp
        /// </summary>
        /// <returns></returns>
        private bool IsSameNewPass()
        {
            return this.txtNhapMatKhauMoi.Text.Equals(this.txtNhapLaiMatKhau.Text);
        }
        /// <summary>
        /// Người dùng không bỏ trống trường nào
        /// </summary>
        /// <returns></returns>
        private bool IsNull()
        {
            return String.IsNullOrEmpty(this.txtNhapMatKhauCu.Text) ||
                   String.IsNullOrEmpty(this.txtNhapMatKhauMoi.Text) ||
                   String.IsNullOrEmpty(this.txtNhapLaiMatKhau.Text);
        }
        /// <summary>
        /// Ẩn hiện mật khẩu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbAnMatKhauSetings_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAnMatKhauSetings.Checked)
            {
                txtNhapMatKhauCu.PasswordChar = '*';
                txtNhapMatKhauMoi.PasswordChar = '*';
                txtNhapLaiMatKhau.PasswordChar = '*';
            }
            else
            {
                txtNhapMatKhauCu.PasswordChar = '\0';
                txtNhapMatKhauMoi.PasswordChar = '\0';
                txtNhapLaiMatKhau.PasswordChar = '\0';
            }
        }
        /// <summary>
        /// Mở kết nối
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSetings_Load(object sender, EventArgs e)
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
