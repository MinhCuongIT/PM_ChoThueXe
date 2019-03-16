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
    public partial class FormDatXe : Form
    {
        /// <summary>
        /// Chuỗi kết nối đến db
        /// </summary>
        public static string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=QL_ThueXe;Integrated Security=True";

        SqlConnection connection = new SqlConnection(connectionString);
        SqlDataAdapter dataAdapter;
        SqlDataReader dataReader;

        /// <summary>
        /// Đánh dấu người dùng đã chọn xe hay chưa
        /// </summary>
        bool selectedCar = false;

        string CarID = string.Empty;
        string CustID = string.Empty;


        public FormDatXe()
        {
            InitializeComponent();
        }

        private void dgvDatXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvDatXe.Rows[e.RowIndex].Selected = true;
            selectedCar = true;
            CarID = this.dgvDatXe.Rows[e.RowIndex].Cells["CarID"].Value.ToString();
            //điền thông tin vào các textbox
            this.txtBrand.Text = this.dgvDatXe.Rows[e.RowIndex].Cells["Brand"].Value.ToString();
            this.txtModel.Text = this.dgvDatXe.Rows[e.RowIndex].Cells["Model"].Value.ToString();
            this.txtProductYear.Text = this.dgvDatXe.Rows[e.RowIndex].Cells["ProductYear"].Value.ToString();
            this.txtPlate.Text = this.dgvDatXe.Rows[e.RowIndex].Cells["Plate"].Value.ToString();
            this.txtFuel.Text = this.dgvDatXe.Rows[e.RowIndex].Cells["Fuel"].Value.ToString();
            this.txtBearBox.Text = this.dgvDatXe.Rows[e.RowIndex].Cells["GearBox"].Value.ToString();
            this.txtPrice.Text = this.dgvDatXe.Rows[e.RowIndex].Cells["Price"].Value.ToString();
        }

        private void FormDatXe_Load(object sender, EventArgs e)
        {
            makeAconnection();
            fillTheDataGrid();
        }

        /// <summary>
        /// Xóa trống các trường
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoaTrong_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa các trường không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            this.txtTenKhachHang.Text = string.Empty;
            this.txtCMND.Text = string.Empty;
            this.txtDiaChi.Text = string.Empty;
            this.txtSDT.Text = string.Empty;
            dtpNgayThue.Value = DateTime.Now;
            dtpNgayTra.Value = DateTime.Now;
        }
        /// <summary>
        /// Đặt xe ngay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDatNgay_Click(object sender, EventArgs e)
        {
            //Kiểm tra điều kiện
            if (!selectedCar)
            {
                MessageBox.Show("Bạn chưa chọn xe. Vui lòng chọn xe", "Thông báo");
                return;
            }
            if (checkAllTextbox())
            {
                MessageBox.Show("Bạn vui lòng kiểm tra lại các trường trên", "Thông báo");
                return;
            }
            //Thêm thông tin vào DB
            insertCustomer();
            insertRent();
        }



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
        /// Hiển thị thông tin lên Grid
        /// </summary>
        private void fillTheDataGrid()
        {
            string query = "SELECT * FROM CARS;";
            try
            {
                dataAdapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                this.dgvDatXe.DataSource = dataSet.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
        /// <summary>
        /// Thêm khách hàng
        /// </summary>
        private void insertCustomer()
        {
            string insertQuery = "INSERT INTO CUSTOMERS(Name,CMND,Addr,PhoneNumber) VALUES(@name,@cmnd,@addr,@phone)";
            try
            {
                SqlCommand scom2 = new SqlCommand(insertQuery, connection);
                scom2.Parameters.AddWithValue("@name", this.txtTenKhachHang.Text);
                scom2.Parameters.AddWithValue("@cmnd", this.txtCMND.Text);
                scom2.Parameters.AddWithValue("@addr", this.txtDiaChi.Text);
                scom2.Parameters.AddWithValue("@phone", this.txtSDT.Text);
                if (scom2.ExecuteNonQuery() > 0)
                {
                    string queryGetCustId = "SELECT CustomerID FROM CUSTOMERS WHERE CMND = @Cmnd";

                    try
                    {
                        SqlCommand command = new SqlCommand(queryGetCustId, connection);
                        command.Parameters.AddWithValue("@Cmnd", this.txtCMND.Text);
                        this.CustID = command.ExecuteScalar().ToString();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Có lỗi:\n" + error.Message);
            }

        }
        /// <summary>
        /// thêm thông tin thuê xe
        /// </summary>
        private void insertRent()
        {
            string insertQuery = "INSERT INTO RENT(CustomerID, CarID, RentDate, ReturnDate) VALUES(@custID, @carID, @rentDate, @returnDate)";
            try
            {
                SqlCommand scom1 = new SqlCommand(insertQuery, connection);
                scom1.Parameters.AddWithValue("@custID", this.CustID);
                scom1.Parameters.AddWithValue("@carID", this.CarID);
                scom1.Parameters.AddWithValue("@rentDate", this.dtpNgayThue.Value);
                scom1.Parameters.AddWithValue("@returnDate", this.dtpNgayTra.Value);
                if (scom1.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Đặt xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đặt xe thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
        /// <summary>
        /// Kiểm tra các textbox
        /// </summary>
        /// <returns></returns>
        private bool checkAllTextbox()
        {
            return string.IsNullOrEmpty(this.txtTenKhachHang.Text) ||
                string.IsNullOrEmpty(this.txtCMND.Text) ||
                string.IsNullOrEmpty(this.txtDiaChi.Text) ||
                string.IsNullOrEmpty(this.txtSDT.Text);
        }
        #endregion
    }
}
