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
    public partial class FormHienThiDatXe : Form
    {
        /// <summary>
        /// Chuỗi kết nối đến db
        /// </summary>
        public static string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=QL_ThueXe;Integrated Security=True";

        SqlConnection connection = new SqlConnection(connectionString);
        SqlDataAdapter dataAdapter;
        string querySearch = string.Empty;

        /// <summary>
        /// Hàm dựng mặc định
        /// </summary>
        public FormHienThiDatXe()
        {
            InitializeComponent();
        }

        #region Events
        /// <summary>
        /// Xử lí tìm kiếm khi người dùng nhập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
                searchDataGrid(querySearch);
            else
                fillTheDataGrid();
        }
        /// <summary>
        /// Thực hiện tìm kiếm xe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            fillTheDataGrid();
            this.chkName.Checked = false;
            this.chkCMND.Checked = false;
            this.chkBrand.Checked = false;
            this.chkModel.Checked = false;
        }

        /// <summary>
        /// Hiển thị thông tin lên grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormHienThiDatXe_Load(object sender, EventArgs e)
        {
            makeAconnection();
            fillTheDataGrid();
        }
        /// <summary>
        /// Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkName_CheckedChanged(object sender, EventArgs e)
        {
            setEnableTextbox();
            setQuery("Name");
            this.chkBrand.Checked = false;
            this.chkCMND.Checked = false;
            this.chkModel.Checked = false;
        }
        /// <summary>
        /// CMND
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkCMND_CheckedChanged(object sender, EventArgs e)
        {
            setEnableTextbox();
            setQuery("CMND");
            this.chkName.Checked = false;
            this.chkBrand.Checked = false;
            this.chkModel.Checked = false;
        }
        /// <summary>
        /// Brand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkBrand_CheckedChanged(object sender, EventArgs e)
        {
            setEnableTextbox();
            setQuery("Brand");
            this.chkName.Checked = false;
            this.chkCMND.Checked = false;
            this.chkModel.Checked = false;
        }
        /// <summary>
        /// Model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkModel_CheckedChanged(object sender, EventArgs e)
        {
            setEnableTextbox();
            setQuery("Model");
            this.chkCMND.Checked = false;
            this.chkBrand.Checked = false;
            this.chkName.Checked = false;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Khởi tạp kết nối
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
        /// Hiển thị thông tin lên grid
        /// </summary>
        private void fillTheDataGrid()
        {
            string query = "SELECT C.Name,C.CMND,K.Brand,K.Model,K.Price,R.RentDate,R.ReturnDate " +
                            "FROM CUSTOMERS C INNER JOIN RENT R ON C.CustomerId = R.CustomerId INNER JOIN CARS K ON " +
                            "K.CarId = R.CarId";
            try
            {
                dataAdapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                this.dgvHienThiThongTinDatXe.DataSource = dataSet.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        /// <summary>
        /// Thiết lập query
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        private string setQuery(string tableName)
        {
            querySearch = "SELECT C.Name,C.CMND,K.Brand,K.Model,K.Price,R.RentDate,R.ReturnDate " +
                            "FROM CUSTOMERS C INNER JOIN RENT R ON C.CustomerId = R.CustomerId INNER JOIN CARS K ON " +
                            "K.CarId = R.CarId WHERE " + tableName + " LIKE '";

            return querySearch;
        }
        /// <summary>
        /// Tìm kiếm
        /// </summary>
        /// <param name="queryStatement"></param>
        private void searchDataGrid(string queryStatement)
        {
            queryStatement = queryStatement + this.txtTimKiem.Text + "%';";
            try
            {
                dataAdapter = new SqlDataAdapter(queryStatement, connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                this.dgvHienThiThongTinDatXe.DataSource = dataSet.Tables[0];
                queryStatement = querySearch;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        void setEnableTextbox()
        {
            if (this.chkName.Checked || this.chkCMND.Checked|| this.chkModel.Checked || this.chkBrand.Checked)
            {
                this.txtTimKiem.Enabled = true;
            }
            else
            {
                this.txtTimKiem.Enabled = false;
            }
        }

        #endregion

        
    }
}
