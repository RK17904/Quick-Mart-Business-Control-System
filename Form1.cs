using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QuickMart_Business_Control_System
{
    public partial class Form1 : Form
    {
        private readonly string connStr = "Server=localhost\\SQLEXPRESS;Database=QuickMart_Business_System;Trusted_Connection=True;";
        private ReportViewer reportViewer;

        public Form1()
        {
            InitializeComponent();
        }

        private List<ProductSales> GetProductSales()
        {
            var list = new List<ProductSales>();
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT ID, Name, Price, Quantity, Category FROM Product";
                using (var cmd = new SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new ProductSales
                        {
                            ID = reader.GetString(0),
                            Name = reader.GetString(1),
                            Price = reader.GetDecimal(2),
                            Quantity = Convert.ToInt32(reader.GetValue(3)),
                            Category = reader.GetString(4)
                        });
                    }
                }
            }
            return list;
        }

        private List<CustomerFeedback> GetCustomerFeedback()
        {
            var list = new List<CustomerFeedback>();
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                // Use alias to ensure field names are CLS-compliant (no spaces)
                string query = "SELECT [Customer Name] AS CustomerName, Email, Message, Rating FROM Feedback";
                using (var cmd = new SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new CustomerFeedback
                        {
                            CustomerName = reader.GetString(0),
                            Email = reader.GetString(1),
                            Message = reader.GetString(2),
                            Rating = Convert.ToInt32(reader.GetValue(3))
                        });
                    }
                }
            }
            return list;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reportViewer = new ReportViewer
            {
                Dock = DockStyle.Fill,
                ProcessingMode = ProcessingMode.Local
            };

            this.Controls.Add(reportViewer);

            reportViewer.LocalReport.ReportPath = "C:\\COSC_31112_Project\\QuickMart Business Control System\\Report2.rdlc";

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", GetProductSales()));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", GetCustomerFeedback()));

            reportViewer.RefreshReport();
        }
    }

    public class ProductSales
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
    }

    public class CustomerFeedback
    {
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public int Rating { get; set; }
    }
}
