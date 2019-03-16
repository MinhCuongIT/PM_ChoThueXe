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
    public partial class FormUpdateCar : Form
    {
        /// <summary>
        /// Chuỗi kết nối đến db
        /// </summary>
        public static string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=QL_ThueXe;Integrated Security=True";

        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command;

        string carid;

        public FormUpdateCar()
        {
            InitializeComponent();
        }

        private void FormUpdateCar_Load(object sender, EventArgs e)
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
                dgvCapNhatLaiXe.DataSource = dataSet.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
        #endregion

        private void dgvCapNhatLaiXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvCapNhatLaiXe.Rows[e.RowIndex].Selected = true;

            this.carid = dgvCapNhatLaiXe.Rows[e.RowIndex].Cells["CarID"].Value.ToString();
            this.txtBrand.Text = dgvCapNhatLaiXe.Rows[e.RowIndex].Cells["Brand"].Value.ToString();
            this.txtModel.Text = dgvCapNhatLaiXe.Rows[e.RowIndex].Cells["Model"].Value.ToString();
            this.txtProductYear.Text = dgvCapNhatLaiXe.Rows[e.RowIndex].Cells["ProductYear"].Value.ToString();
            this.txtPlate.Text = dgvCapNhatLaiXe.Rows[e.RowIndex].Cells["Plate"].Value.ToString();
            this.txtPrice.Text = dgvCapNhatLaiXe.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            this.cbFuel.Text = dgvCapNhatLaiXe.Rows[e.RowIndex].Cells["Fuel"].Value.ToString();
            this.cbGearBox.Text = dgvCapNhatLaiXe.Rows[e.RowIndex].Cells["GearBox"].Value.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string query = "UPDATE CARS SET Brand=@brand,Model=@model,ProductYear=@pyear,Plate=@plate," +
                            "Price=@price,Fuel=@fuel,GearBox=@gearbox WHERE CarID=@id";

            try
            {
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", carid);
                command.Parameters.AddWithValue("@brand", this.txtBrand.Text);
                command.Parameters.AddWithValue("@model", this.txtModel.Text);
                command.Parameters.AddWithValue("@pyear", this.txtProductYear.Text);
                command.Parameters.AddWithValue("@plate", this.txtPlate.Text);
                command.Parameters.AddWithValue("@price", this.txtPrice.Text);
                command.Parameters.AddWithValue("@fuel", this.cbFuel.Text);
                command.Parameters.AddWithValue("@gearbox", this.cbGearBox.Text);
                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    fillTheDataGrid();
                    resetAll();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void resetAll()
        {
            this.txtBrand.Text = string.Empty;
            this.txtModel.Text = string.Empty;
            this.txtPlate.Text = string.Empty;
            this.txtPrice.Text = string.Empty;
            this.txtProductYear.Text = string.Empty;
            this.cbFuel.Text = string.Empty;
            this.cbGearBox.Text = string.Empty;

        }
    }
}
