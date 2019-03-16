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
    public partial class FormUpdateCustomer : Form
    {
        /// <summary>
        /// Chuỗi kết nối đến db
        /// </summary>
        public static string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=QL_ThueXe;Integrated Security=True";

        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command;
        string customerID;

        public FormUpdateCustomer()
        {
            InitializeComponent();
        }

        private void FormUpdateCustomer_Load(object sender, EventArgs e)
        {
            makeAconnection();
            fillTheDataGrid();
        }
        #region Methods
        private void makeAconnection()
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

        private void fillTheDataGrid()
        {
            string query = "SELECT CustomerId,Name,CMND,Addr,PhoneNumber FROM CUSTOMERS";
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                this.dgvUpdateCustomers.DataSource = dataSet.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
        #endregion

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (!checkNullOrEmpty())
            {
                string query = "UPDATE CUSTOMERS SET Name=@name,CMND=@cmnd,Addr=@addr,PhoneNumber=@phone " +
                                    "WHERE CustomerID=@custId";

                try
                {
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@custId", this.customerID);
                    command.Parameters.AddWithValue("@name", this.txtHoTen.Text);
                    command.Parameters.AddWithValue("@cmnd", this.txtCMND.Text);
                    command.Parameters.AddWithValue("@addr", this.txtDiaChi.Text);
                    command.Parameters.AddWithValue("@phone", this.txtSDT.Text);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        fillTheDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại!");
                    }

                }
                catch (Exception error)
                {
                    MessageBox.Show("Có lỗi!\n"+error.Message, "Thông báo");
                } 
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại các trường trên!");
            }
        }

        private bool checkNullOrEmpty()
        {
            return (string.IsNullOrEmpty(this.txtHoTen.Text) ||
                string.IsNullOrEmpty(this.txtCMND.Text) ||
                string.IsNullOrEmpty(this.txtDiaChi.Text) ||
                string.IsNullOrEmpty(this.txtSDT.Text));
        }

        private void dgvUpdateCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvUpdateCustomers.Rows[e.RowIndex].Selected = true;

            this.customerID = this.dgvUpdateCustomers.Rows[e.RowIndex].Cells["CustomerID"].Value.ToString();
            this.txtHoTen.Text = this.dgvUpdateCustomers.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            this.txtCMND.Text = this.dgvUpdateCustomers.Rows[e.RowIndex].Cells["CMND"].Value.ToString();
            this.txtDiaChi.Text = this.dgvUpdateCustomers.Rows[e.RowIndex].Cells["Addr"].Value.ToString();
            this.txtSDT.Text = this.dgvUpdateCustomers.Rows[e.RowIndex].Cells["PhoneNumber"].Value.ToString();

        }
    }
}
