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
    public partial class FormDeleteUser : Form
    {
        /// <summary>
        /// Chuỗi kết nối đến db
        /// </summary>
        public static string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=QL_ThueXe;Integrated Security=True";

        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command;

        public FormDeleteUser()
        {
            InitializeComponent();
        }

        private void dgvDeleteUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvDeleteUser.Rows[e.RowIndex].Selected = true;
            var result = MessageBox.Show("Bạn có chắc chắn không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            string queryDelete = "DELETE FROM USERS WHERE UserName = @userName";
            command = new SqlCommand(queryDelete, connection);
            command.Parameters.AddWithValue("@userName", this.dgvDeleteUser.Rows[e.RowIndex].Cells["UserName"].Value.ToString());
            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillTheDataGrid();
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormDeleteUser_Load(object sender, EventArgs e)
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
            string query = "SELECT * FROM USERS;";
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                this.dgvDeleteUser.DataSource = dataSet.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        #endregion
    }
}
