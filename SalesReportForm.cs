using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickMart_Business_Control_System
{
    public partial class SalesReportForm : Form
    {
        public SalesReportForm()
        {
            InitializeComponent();
        }

        private void UpdateSummary(DataTable dt)
        {
            int totalSales = dt.Rows.Count;
            decimal totalRevenue = dt.AsEnumerable().Sum(row => row.Field<decimal>("Total"));
            decimal averageSale = (totalSales > 0) ? totalRevenue / totalSales : 0;

            string topProduct = totalSales > 0 ? dt.AsEnumerable().GroupBy(row => row.Field<string>("Product")).OrderByDescending(g => g.Sum(r => r.Field<decimal>("Total"))).First().Key :
"N/A";

            lblTotalSales.Text = totalSales.ToString();
            lblTotalRevenue.Text = "$" + totalRevenue.ToString("N2");
            lblAverageSale.Text = "$" + averageSale.ToString("N2");
            lblTopProduct.Text = topProduct;
        }



        private void SalesReportForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Sale ID");
            dt.Columns.Add("Product");
            dt.Columns.Add("Customer");
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("Unit Price", typeof(decimal));
            dt.Columns.Add("Total", typeof(decimal));
            dt.Columns.Add("Date", typeof(DateTime));

            dt.Rows.Add(1001, "Gaming Laptop", "John Smith", 2, 1299.99m, 2599.98m, new DateTime(2024, 1, 5));
            dt.Rows.Add(1002, "Cotton T-Shirt", "Jane Doe", 5, 19.99m, 99.95m, new DateTime(2024, 2, 12));
            dt.Rows.Add(1003, "Programming Book", "Mike Johnson", 3, 49.99m, 149.97m, new DateTime(2024, 3, 3));
            dt.Rows.Add(1004, "Wireless Headphones", "Emily Davis", 1, 199.99m, 199.99m, new DateTime(2024, 4, 15));
            dt.Rows.Add(1005, "Bluetooth Speaker", "David Lee", 2, 89.99m, 179.98m, new DateTime(2024, 5, 8));
            dt.Rows.Add(1006, "Smartphone", "Sophia Wilson", 1, 899.99m, 899.99m, new DateTime(2024, 6, 27));
            dt.Rows.Add(1007, "Office Chair", "Liam Martin", 1, 149.99m, 149.99m, new DateTime(2024, 7, 19));
            dt.Rows.Add(1008, "LED Monitor", "Olivia Brown", 2, 249.99m, 499.98m, new DateTime(2024, 8, 23));
            dt.Rows.Add(1009, "External Hard Drive", "Noah Clark", 3, 79.99m, 239.97m, new DateTime(2024, 9, 11));
            dt.Rows.Add(1010, "Fitness Tracker", "Ava Lewis", 2, 59.99m, 119.98m, new DateTime(2024, 10, 3));
            dt.Rows.Add(1011, "Digital Camera", "Mason Walker", 1, 499.99m, 499.99m, new DateTime(2024, 11, 20));
            dt.Rows.Add(1012, "Microwave Oven", "Isabella Hall", 1, 149.99m, 149.99m, new DateTime(2024, 12, 7));
            dt.Rows.Add(1013, "Vacuum Cleaner", "Ethan Young", 2, 99.99m, 199.98m, new DateTime(2024, 3, 9));
            dt.Rows.Add(1014, "Smartwatch", "Mia Allen", 3, 199.99m, 599.97m, new DateTime(2024, 5, 29));
            dt.Rows.Add(1015, "Printer", "Logan King", 1, 129.99m, 129.99m, new DateTime(2024, 6, 1));
            dt.Rows.Add(1016, "Gaming Keyboard", "Charlotte Wright", 2, 89.99m, 179.98m, new DateTime(2024, 9, 4));
            dt.Rows.Add(1017, "USB Flash Drive", "Lucas Scott", 5, 14.99m, 74.95m, new DateTime(2024, 10, 14));
            dt.Rows.Add(1018, "Air Fryer", "Amelia Green", 1, 129.99m, 129.99m, new DateTime(2024, 11, 27));
            dt.Rows.Add(1019, "Graphic Tablet", "James Adams", 1, 199.99m, 199.99m, new DateTime(2024, 2, 19));
            dt.Rows.Add(1020, "Laptop Cooling Pad", "Harper Nelson", 2, 29.99m, 59.98m, new DateTime(2024, 12, 30));
            dataGridViewSales.DataSource = dt;

            UpdateSummary(dt);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {


            DateTime from = dateTimeFrom.Value.Date;
            DateTime to = dateTimeTo.Value.Date;

            DataTable dt = (DataTable)dataGridViewSales.DataSource;

            DataView dv = dt.DefaultView;
            dv.RowFilter = $"Date >= #{from:MM/dd/yyyy}# AND Date <= #{to:MM/dd/yyyy}#";

            dataGridViewSales.DataSource = dv.ToTable();
            UpdateSummary(dv.ToTable());
        }


        private void lblTotalSales_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "CSV file (*.csv)|*.csv",
                FileName = "SalesReport.csv"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < dataGridViewSales.Columns.Count; i++)
                    sb.Append(dataGridViewSales.Columns[i].HeaderText + ",");

                sb.AppendLine();

                foreach (DataGridViewRow row in dataGridViewSales.Rows)
                {
                    for (int i = 0; i < dataGridViewSales.Columns.Count; i++)
                        sb.Append(row.Cells[i].Value + ",");

                    sb.AppendLine();
                }

                File.WriteAllText(sfd.FileName, sb.ToString());
                MessageBox.Show("Exported successfully!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SalesReportForm_Load(null, null);
        }
    }
}

