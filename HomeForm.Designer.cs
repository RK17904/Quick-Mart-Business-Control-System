namespace QuickMart_Business_Control_System
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            colorDialog1 = new ColorDialog();
            btnCustomer = new Button();
            btnSalesReport = new Button();
            btnProduct = new Button();
            btnCategory = new Button();
            btnFeedback = new Button();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(289, 25);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.Cornsilk;
            btnCustomer.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomer.Location = new Point(89, 123);
            btnCustomer.Margin = new Padding(3, 2, 3, 2);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(255, 37);
            btnCustomer.TabIndex = 2;
            btnCustomer.Text = "Customer Management";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnSalesReport
            // 
            btnSalesReport.BackColor = Color.Cornsilk;
            btnSalesReport.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalesReport.Location = new Point(89, 192);
            btnSalesReport.Margin = new Padding(3, 2, 3, 2);
            btnSalesReport.Name = "btnSalesReport";
            btnSalesReport.Size = new Size(255, 35);
            btnSalesReport.TabIndex = 3;
            btnSalesReport.Text = "Sales Reports";
            btnSalesReport.UseVisualStyleBackColor = false;
            btnSalesReport.Click += btnSalesReport_Click;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.Cornsilk;
            btnProduct.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProduct.Location = new Point(89, 261);
            btnProduct.Margin = new Padding(3, 2, 3, 2);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(255, 36);
            btnProduct.TabIndex = 4;
            btnProduct.Text = "Product Management";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnCategory
            // 
            btnCategory.BackColor = Color.Cornsilk;
            btnCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategory.Location = new Point(89, 332);
            btnCategory.Margin = new Padding(3, 2, 3, 2);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(255, 34);
            btnCategory.TabIndex = 5;
            btnCategory.Text = "Category Management";
            btnCategory.UseVisualStyleBackColor = false;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnFeedback
            // 
            btnFeedback.BackColor = Color.Cornsilk;
            btnFeedback.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFeedback.Location = new Point(89, 396);
            btnFeedback.Margin = new Padding(3, 2, 3, 2);
            btnFeedback.Name = "btnFeedback";
            btnFeedback.Size = new Size(255, 31);
            btnFeedback.TabIndex = 6;
            btnFeedback.Text = "Feedback";
            btnFeedback.UseVisualStyleBackColor = false;
            btnFeedback.Click += btnFeedback_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources._241f15984b32d681a80bd3e05a3e3466;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(-5, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 499);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Imprint MT Shadow", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(33, 24);
            label2.Name = "label2";
            label2.Size = new Size(326, 105);
            label2.TabIndex = 8;
            label2.Text = "   QuickMart Business \r\n      Control System\r\n\r\n";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CadetBlue;
            panel2.Controls.Add(btnFeedback);
            panel2.Controls.Add(btnSalesReport);
            panel2.Controls.Add(btnCategory);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnProduct);
            panel2.Controls.Add(btnCustomer);
            panel2.Location = new Point(510, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(431, 499);
            panel2.TabIndex = 8;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(942, 500);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HomeForm";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Home";
            Load += HomeForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ColorDialog colorDialog1;
        private Button btnCustomer;
        private Button btnSalesReport;
        private Button btnProduct;
        private Button btnCategory;
        private Button btnFeedback;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
    }
}