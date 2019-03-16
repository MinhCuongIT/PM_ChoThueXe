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
    public partial class FormXemDanhSachXe : Form
    {
        /// <summary>
        /// Chuỗi kết nối đến db
        /// </summary>
        public static string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=QL_ThueXe;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);


        public FormXemDanhSachXe()
        {
            InitializeComponent();
        }

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
            string query = "SELECT CarId,Brand,Model,ProductYear,Plate,Fuel,GearBox,Price FROM CARS;";
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dgvDanhSachXeTrongHeThong.DataSource = dataSet.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void FormXemDanhSachXe_Load(object sender, EventArgs e)
        {
            makeAconnection();
            fillTheDataGrid();
        }
    }
}
