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
    public partial class FormDeleteCar : Form
    {
        /// <summary>
        /// Chuỗi kết nối đến db
        /// </summary>
        public static string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=QL_ThueXe;Integrated Security=True";

        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command;


        public FormDeleteCar()
        {
            InitializeComponent();
        }

        private void FormDeleteCar_Load(object sender, EventArgs e)
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
            string query = "SELECT CarID,Brand,Model,ProductYear,Plate,Fuel,GearBox,Price FROM CARS;";
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                this.dgvXoaXe.DataSource = dataSet.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
        #endregion

        private void dgvXoaXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvXoaXe.Rows[e.RowIndex].Selected = true;
            DialogResult dialogResult = MessageBox.Show("Bạn có thực sự muốn xóa xe này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string queryDelete = "DELETE FROM CARS WHERE CarID=@carid;";
                try
                {
                    command = new SqlCommand(queryDelete, connection);
                    command.Parameters.AddWithValue("@carid", this.dgvXoaXe.Rows[e.RowIndex].Cells["CarID"].Value.ToString());

                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Xóa xe thành công!");
                        fillTheDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Xóa xe thất bại!");
                    }

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
    }
}
