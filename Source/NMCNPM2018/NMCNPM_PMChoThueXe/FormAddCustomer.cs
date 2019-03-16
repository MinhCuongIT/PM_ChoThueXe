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
    public partial class FormAddCustomer : Form
    {
        /// <summary>
        /// Chuỗi kết nối đến db
        /// </summary>
        public static string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=QL_ThueXe;Integrated Security=True";

        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command;

        public FormAddCustomer()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (!checkNullOrEmpty())
            {
                string queryAdd = "INSERT INTO CUSTOMERS VALUES(@Name,@CMND,@Adrr,@PhoneNumber);";
                try
                {
                    command = new SqlCommand(queryAdd, connection);
                    command.Parameters.AddWithValue("@Name", this.txtHoTen.Text);
                    command.Parameters.AddWithValue("@CMND", this.txtCMND.Text);
                    command.Parameters.AddWithValue("@Adrr", this.txtDiaChi.Text);
                    command.Parameters.AddWithValue("@PhoneNumber", this.txtSDT.Text);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        //Thêm thành công
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txtHoTen.Text = string.Empty;
                        this.txtCMND.Text = string.Empty;
                        this.txtDiaChi.Text = string.Empty;
                        this.txtSDT.Text = string.Empty;
                    }
                    else
                    {
                        //Thêm lỗi
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Có lỗi\n" + err.Message, "Thông báo");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại các trường trên");
            }
        }

        private bool checkNullOrEmpty()
        {
            return (string.IsNullOrEmpty(this.txtHoTen.Text) ||
                string.IsNullOrEmpty(this.txtCMND.Text) ||
                string.IsNullOrEmpty(this.txtDiaChi.Text) ||
                string.IsNullOrEmpty(this.txtSDT.Text));
        }

        private void btnXoaCacTruongAddCustomer_Click(object sender, EventArgs e)
        {
            this.txtHoTen.Text = string.Empty;
            this.txtCMND.Text = string.Empty;
            this.txtDiaChi.Text = string.Empty;
            this.txtSDT.Text = string.Empty;
        }

        private void FormAddCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
