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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            SalesReportForm sales = new SalesReportForm();
            sales.Show();
            this.Hide();
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Hide();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            FeedbackForm feedback = new FeedbackForm();
            feedback.Show();
            this.Hide();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
