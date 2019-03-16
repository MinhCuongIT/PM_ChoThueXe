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
    public partial class FormDangNhap : Form
    {
        public static string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=QL_ThueXe;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        string queryLogin;
        SqlCommand command;

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Tên tài khoản và mật khẩu không được rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            queryLogin = "SELECT * FROM USERS WHERE UserName=@username AND Password=@pass";
            command = new SqlCommand(queryLogin, connection);
            command.Parameters.AddWithValue("@username", txtTenTaiKhoan.Text);
            command.Parameters.AddWithValue("@pass", txtMatKhau.Text);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {

                if (!reader["Type"].ToString().Equals("2")) //Admin và quản lý
                {
                    reader.Close();
                    updateState();
                    FormQuanLy formQuayLy = new FormQuanLy(this);
                    formQuayLy.Show();
                    this.Hide();
                }
                else
                {
                    //Trường hợp khách hàng <> không phải admin và quản lý
                    reader.Close();
                    updateState();
                    FormDatXe formDatXe = new FormDatXe();
                    formDatXe.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không đúng. Vui lòng kiếm tra lại!", "Thông báo");
                reader.Close();
                return;
            }

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
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

        
        private void updateState()
        {
            //Xac dinh ai dang su dung he thong
            //Nhung nguoi dang su dung he thong thi position = 1
            string usersQuery = "UPDATE USERS SET Position=1 WHERE UserName=@name;";
            SqlCommand commandToUpdate = new SqlCommand(usersQuery, connection);
            commandToUpdate.Parameters.AddWithValue("@name", txtTenTaiKhoan.Text);

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                commandToUpdate.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                connection.Close();
            }

        }

        private void chkHienMatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMatkhau.Checked)
                txtMatKhau.PasswordChar = '•';
            else
                txtMatKhau.PasswordChar = '\0';
        }

        private void txtTenTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(null, null);
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(null, null);
            }
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            //Mặc định tạo tài khoản là chỉ có khách hàng, Quản lí và admin không được tạo tại đây
            FormTaoTaiKhoan formTaoTaiKhoan = new FormTaoTaiKhoan();
            formTaoTaiKhoan.ShowDialog();
        }
    }
}
