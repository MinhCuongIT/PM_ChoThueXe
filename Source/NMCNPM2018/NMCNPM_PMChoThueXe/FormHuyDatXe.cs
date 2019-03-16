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
    public partial class FormHuyDatXe : Form
    {
        /// <summary>
        /// Chuỗi kết nối đến db
        /// </summary>
        public static string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=QL_ThueXe;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        SqlDataAdapter dataAdapter;
        SqlCommand command;
        string deletedRent = string.Empty;
        string rentID = string.Empty;

        public FormHuyDatXe()
        {
            InitializeComponent();
        }

        #region Evetns
        private void FormHuyDatXe_Load(object sender, EventArgs e)
        {
            makeAconnection();
            fillTheDataGrid();
        }
        private void dgvXoaDatXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvXoaDatXe.Rows[e.RowIndex].Selected = true;
            this.rentID = this.dgvXoaDatXe.Rows[e.RowIndex].Cells["RentID"].Value.ToString();
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn hủy đặt xe này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                return;
            }
            string queryDelete = "DELETE FROM RENT WHERE RentID=@RentID;";

            try
            {
                command = new SqlCommand(queryDelete, connection);
                command.Parameters.AddWithValue("@RentID", this.rentID);

                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Hủy đặt xe thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillTheDataGrid();
                }
                else
                {
                    MessageBox.Show("Hủy đặt xe thất bại!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
        #endregion

        #region Methods
        /// <summary>
        /// Tạo kết nối
        /// </summary>
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

        /// <summary>
        /// Điền dữ liệu vào DataGridView
        /// </summary>
        private void fillTheDataGrid()
        {
            string query = "SELECT R.RentID,C.Name,C.CMND,K.Brand,K.Model,K.Price,RentDate,R.ReturnDate " +
                            "FROM CUSTOMERS C INNER JOIN RENT R ON C.CustomerID = R.CustomerID INNER JOIN CARS K ON " +
                            "K.CarID = R.CarID";
            try
            {
                dataAdapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                this.dgvXoaDatXe.DataSource = dataSet.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
        #endregion


    }
}
