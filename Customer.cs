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
using Microsoft.Reporting.WinForms;

namespace QuickMart_Business_Control_System
{
    public partial class Customer : Form
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=QuickMart_Business_System;Integrated Security=True;";
        public Customer()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Customer", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    datagridviewCustomer.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearFields()
        {
            txtId.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = datagridviewCustomer.Rows[e.RowIndex];
                txtId.Text = row.Cells["Customer ID"].Value.ToString();
                txtName.Text = row.Cells["Customer Name"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtPhone.Text = row.Cells["Phone Number"].Value.ToString();
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = "INSERT INTO Customer ([Customer ID], [Customer Name], [Email], [Phone Number]) VALUES (@CustomerID, @CustomerName, @Email, @PhoneNumber)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@CustomerID", txtId.Text);
                    cmd.Parameters.AddWithValue("@CustomerName", txtName.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadData();
                    ClearFields();
                    MessageBox.Show("Customer added successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding customer: " + ex.Message);
            }



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = "UPDATE Customer SET [Customer Name]=@CustomerName, [Email]=@Email, [Phone Number]=@PhoneNumber WHERE [Customer ID]=@CustomerID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@CustomerID", txtId.Text);
                    cmd.Parameters.AddWithValue("@CustomerName", txtName.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadData();
                    ClearFields();
                    MessageBox.Show("Customer updated successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating customer: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this customer?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string sql = "DELETE FROM Customer WHERE [Customer ID]=@CustomerID";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@CustomerID", txtId.Text);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        LoadData();
                        ClearFields();
                        MessageBox.Show("Customer deleted successfully!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting customer: " + ex.Message);
                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = "SELECT * FROM Customer WHERE [Customer ID]=@CustomerID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@CustomerID", txtId.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    datagridviewCustomer.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching customer: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }

        private void btnSelling_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FeedbackForm feedback = new FeedbackForm();
            feedback.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            SalesReportForm sales = new SalesReportForm();
            sales.Show();
            this.Hide();
        }
    }
}
