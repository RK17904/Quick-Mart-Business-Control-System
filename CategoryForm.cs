using System.Data;
using System.Data.SqlClient;


namespace QuickMart_Business_Control_System
{
    public partial class CategoryForm : Form
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=QuickMart_Business_System;Integrated Security=True;";

        public CategoryForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            // Initialization code if needed
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Category", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView_category.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtID.Clear();
            txtName.Clear();
            txtDescription.Clear();
        }

        private void dataGridView_category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_category.Rows[e.RowIndex];
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value?.ToString() ?? string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalesReportForm sales = new SalesReportForm();
            sales.Show();
            this.Hide();
        }

        private void btnSeller_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void btnCategory_Click_1(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            FeedbackForm feedback = new FeedbackForm();
            feedback.Show();
            this.Hide();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = "INSERT INTO Category (ID, Name, Description) VALUES (@ID, @Name, @Description)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID", txtID.Text);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadData();
                    ClearFields();
                    MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = "UPDATE Category SET Name=@Name, Description=@Description WHERE ID=@ID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID", txtID.Text);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadData();
                    ClearFields();
                    MessageBox.Show("Category updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this category?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string sql = "DELETE FROM Category WHERE ID=@ID";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@ID", txtID.Text);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        LoadData();
                        ClearFields();
                        MessageBox.Show("Category deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}