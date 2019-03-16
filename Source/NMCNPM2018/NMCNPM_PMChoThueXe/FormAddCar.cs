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
    public partial class FormAddCar : Form
    {
        /// <summary>
        /// Chuỗi kết nối đến db
        /// </summary>
        public static string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=QL_ThueXe;Integrated Security=True";

        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command;

        public FormAddCar()
        {
            InitializeComponent();
        }


        #region Events
        /// <summary>
        /// Thêm xe vào db
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThemXeMoi_Click(object sender, EventArgs e)
        {
            string queryAdd = "INSERT INTO CARS VALUES(@BRAND,@MODEL,@P_YEAR,@PLATE,@FUEL,@GEARBOX,@PRICE);";
            if (!(controlFields() == 7))
                return;

            try
            {
                command = new SqlCommand(queryAdd, connection);
                command.Parameters.AddWithValue("@BRAND", this.txtBrand.Text);
                command.Parameters.AddWithValue("@MODEL", this.txtModel.Text);
                command.Parameters.AddWithValue("@P_YEAR", this.txtProductYear.Text);
                command.Parameters.AddWithValue("@PLATE", this.txtPlate.Text);
                command.Parameters.AddWithValue("@FUEL", this.cbFuel.Text);
                command.Parameters.AddWithValue("@GEARBOX", this.cbGearBox.Text);
                command.Parameters.AddWithValue("@PRICE", this.txtPrice.Text);

                if (command.ExecuteNonQuery() > 0)
                {
                    //Thêm xe thành công
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Thêm xe lỗi
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        /// <summary>
        /// Xóa trống các trường
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoaCacTruongThemXeMoi_Click(object sender, EventArgs e)
        {
            foreach (Control item in gbThemXeMoi.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text != "")
                        item.Text = "";
                }
                else if (item is ComboBox)
                {
                    if (item.Text != "")
                        item.Text = "";
                }
            }
            errThemXe.Clear();
        }

        private void txtBrand_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtModel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtProductYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPlate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void FormAddCar_Load(object sender, EventArgs e)
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
        #endregion

        #region Methods
        public int controlFields()
        {
            int count = 7;
            errThemXe.Clear();

            foreach (Control item in gbThemXeMoi.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == "")
                    {
                        errThemXe.SetError(item, "Trường không được trống");
                        count--;
                    }
                }
                else if (item is ComboBox)
                {
                    if (item.Text == "")
                    {
                        errThemXe.SetError(item, "Trường không được trống");
                        count--;
                    }
                }
            }
            return count;
        }
        #endregion
    }

}
