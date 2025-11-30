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

namespace QuickMart_Business_Control_System
{
    public partial class FeedbackForm : Form
    {

        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=QuickMart_Business_System;Integrated Security=True;";

        public FeedbackForm()
        {
            InitializeComponent();
            LoadFeedback();
        }
        private void LoadFeedback()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Feedback", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewFeedback.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading feedback: " + ex.Message);
            }
        }
        private void FeedbackForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadFeedback();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewFeedback.SelectedRows.Count > 0)
            {
                int feedbackID = Convert.ToInt32(dataGridViewFeedback.SelectedRows[0].Cells["FeedbackID"].Value);
                if (MessageBox.Show("Delete this feedback?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            string sql = "DELETE FROM Feedback WHERE FeedbackID = @FeedbackID";
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@FeedbackID", feedbackID);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            LoadFeedback();
                            MessageBox.Show("Feedback deleted.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a feedback row to delete.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridViewFeedback.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "CSV file (*.csv)|*.csv",
                    FileName = "FeedbackExport.csv"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder sb = new StringBuilder();

                        // Header
                        for (int i = 0; i < dataGridViewFeedback.Columns.Count; i++)
                        {
                            sb.Append("\"" + dataGridViewFeedback.Columns[i].HeaderText + "\"");
                            if (i < dataGridViewFeedback.Columns.Count - 1) sb.Append(",");
                        }
                        sb.AppendLine();

                        // Data rows
                        foreach (DataGridViewRow row in dataGridViewFeedback.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                for (int i = 0; i < dataGridViewFeedback.Columns.Count; i++)
                                {
                                    var value = row.Cells[i].Value?.ToString()?.Replace("\"", "\"\"") ?? "";
                                    sb.Append($"\"{value}\"");
                                    if (i < dataGridViewFeedback.Columns.Count - 1) sb.Append(",");
                                }
                                sb.AppendLine();
                            }
                        }

                        File.WriteAllText(sfd.FileName, sb.ToString());
                        MessageBox.Show("Export successful!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Export failed: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No data to export.");
            }
        }
    }
}

