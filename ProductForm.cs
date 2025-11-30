using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuickMart_Business_Control_System
{
    public partial class ProductForm : Form
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=QuickMart_Business_System;Integrated Security=True;";

        public ProductForm()
        {
            InitializeComponent();
            LoadData(); // Load data when form starts
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            // Form load logic if needed
        }

        public void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Product", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView_product.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            TextBox_id.Clear();
            TextBox_name.Clear();
            TextBox_price.Clear();
            TextBox_qty.Clear();
            TextBox_category.Clear();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = "INSERT INTO Product (ID, Name, Price, Quantity, Category) VALUES (@ID, @Name, @Price, @Quantity, @Category)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID", TextBox_id.Text);
                    cmd.Parameters.AddWithValue("@Name", TextBox_name.Text);
                    cmd.Parameters.AddWithValue("@Price", decimal.Parse(TextBox_price.Text));
                    cmd.Parameters.AddWithValue("@Quantity", int.Parse(TextBox_qty.Text));
                    cmd.Parameters.AddWithValue("@Category", TextBox_category.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadData();
                    ClearFields();
                    MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = "UPDATE Product SET Name=@Name, Price=@Price, Quantity=@Quantity, Category=@Category WHERE ID=@ID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID", TextBox_id.Text);
                    cmd.Parameters.AddWithValue("@Name", TextBox_name.Text);
                    cmd.Parameters.AddWithValue("@Price", decimal.Parse(TextBox_price.Text));
                    cmd.Parameters.AddWithValue("@Quantity", int.Parse(TextBox_qty.Text));
                    cmd.Parameters.AddWithValue("@Category", TextBox_category.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadData();
                    ClearFields();
                    MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string sql = "DELETE FROM Product WHERE ID=@ID";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@ID", TextBox_id.Text);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        LoadData();
                        ClearFields();
                        MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_product.Rows[e.RowIndex];
                TextBox_id.Text = row.Cells["ID"].Value.ToString();
                TextBox_name.Text = row.Cells["Name"].Value.ToString();
                TextBox_price.Text = row.Cells["Price"].Value.ToString();
                TextBox_qty.Text = row.Cells["Quantity"].Value.ToString();
                TextBox_category.Text = row.Cells["Category"].Value.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void btnSeller_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void btnSelling_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FeedbackForm feedback = new FeedbackForm();
            feedback.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalesReportForm sales = new SalesReportForm();
            sales.Show();
            this.Hide();
        }
    }
}