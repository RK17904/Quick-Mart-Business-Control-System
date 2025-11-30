namespace QuickMart_Business_Control_System
{
    partial class SalesReportForm
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
            dateTimeFrom = new DateTimePicker();
            dateTimeTo = new DateTimePicker();
            dateFrom = new Label();
            dateTo = new Label();
            btnApplyFilter = new Button();
            panelSummary = new Panel();
            lblTopProduct = new Label();
            lblAverageSale = new Label();
            lblTotalRevenue = new Label();
            lblTotalSales = new Label();
            btnRefresh = new Button();
            btnExport = new Button();
            dataGridViewSales = new DataGridView();
            btnBack = new Button();
            panelSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).BeginInit();
            SuspendLayout();
            // 
            // dateTimeFrom
            // 
            dateTimeFrom.Location = new Point(105, 30);
            dateTimeFrom.Margin = new Padding(4);
            dateTimeFrom.Name = "dateTimeFrom";
            dateTimeFrom.Size = new Size(333, 31);
            dateTimeFrom.TabIndex = 0;
            dateTimeFrom.Value = new DateTime(2025, 6, 3, 0, 0, 0, 0);
            dateTimeFrom.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dateTimeTo
            // 
            dateTimeTo.Location = new Point(509, 31);
            dateTimeTo.Margin = new Padding(4);
            dateTimeTo.Name = "dateTimeTo";
            dateTimeTo.Size = new Size(342, 31);
            dateTimeTo.TabIndex = 1;
            // 
            // dateFrom
            // 
            dateFrom.AutoSize = true;
            dateFrom.Location = new Point(26, 36);
            dateFrom.Margin = new Padding(4, 0, 4, 0);
            dateFrom.Name = "dateFrom";
            dateFrom.Size = new Size(60, 25);
            dateFrom.TabIndex = 2;
            dateFrom.Text = "From:";
            // 
            // dateTo
            // 
            dateTo.AutoSize = true;
            dateTo.Location = new Point(464, 35);
            dateTo.Margin = new Padding(4, 0, 4, 0);
            dateTo.Name = "dateTo";
            dateTo.Size = new Size(37, 25);
            dateTo.TabIndex = 3;
            dateTo.Text = "To:";
            // 
            // btnApplyFilter
            // 
            btnApplyFilter.BackColor = Color.SlateGray;
            btnApplyFilter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApplyFilter.ForeColor = SystemColors.ActiveCaptionText;
            btnApplyFilter.Location = new Point(929, 13);
            btnApplyFilter.Margin = new Padding(4);
            btnApplyFilter.Name = "btnApplyFilter";
            btnApplyFilter.Size = new Size(129, 71);
            btnApplyFilter.TabIndex = 4;
            btnApplyFilter.Text = "Apply\r\nFilter";
            btnApplyFilter.UseVisualStyleBackColor = false;
            btnApplyFilter.Click += btnApplyFilter_Click;
            // 
            // panelSummary
            // 
            panelSummary.BackColor = Color.Transparent;
            panelSummary.BackgroundImage = Properties.Resources.images__1_;
            panelSummary.BackgroundImageLayout = ImageLayout.Stretch;
            panelSummary.Controls.Add(lblTopProduct);
            panelSummary.Controls.Add(lblAverageSale);
            panelSummary.Controls.Add(lblTotalRevenue);
            panelSummary.Controls.Add(lblTotalSales);
            panelSummary.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelSummary.Location = new Point(105, 91);
            panelSummary.Name = "panelSummary";
            panelSummary.Size = new Size(816, 238);
            panelSummary.TabIndex = 5;
            // 
            // lblTopProduct
            // 
            lblTopProduct.AutoSize = true;
            lblTopProduct.ForeColor = SystemColors.ButtonHighlight;
            lblTopProduct.Location = new Point(545, 127);
            lblTopProduct.Name = "lblTopProduct";
            lblTopProduct.Size = new Size(175, 76);
            lblTopProduct.TabIndex = 3;
            lblTopProduct.Text = "    Biscuits\r\nTop Product";
            // 
            // lblAverageSale
            // 
            lblAverageSale.AutoSize = true;
            lblAverageSale.ForeColor = SystemColors.ButtonHighlight;
            lblAverageSale.Location = new Point(85, 127);
            lblAverageSale.Name = "lblAverageSale";
            lblAverageSale.Size = new Size(198, 76);
            lblAverageSale.TabIndex = 2;
            lblAverageSale.Text = "     $230.07\r\nAverage Sales";
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.ForeColor = SystemColors.ButtonHighlight;
            lblTotalRevenue.Location = new Point(517, 17);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(216, 76);
            lblTotalRevenue.TabIndex = 1;
            lblTotalRevenue.Text = "   $53 000.50\r\n  Total Revenue";
            // 
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalSales.ForeColor = SystemColors.ButtonHighlight;
            lblTotalSales.Location = new Point(110, 17);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(155, 76);
            lblTotalSales.TabIndex = 0;
            lblTotalSales.Text = "     156\r\nTotal Sales";
            lblTotalSales.Click += lblTotalSales_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.DarkSeaGreen;
            btnRefresh.ForeColor = SystemColors.ActiveCaptionText;
            btnRefresh.Location = new Point(133, 347);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(97, 39);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.DarkSeaGreen;
            btnExport.ForeColor = SystemColors.ActiveCaptionText;
            btnExport.Location = new Point(764, 347);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(114, 39);
            btnExport.TabIndex = 7;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // dataGridViewSales
            // 
            dataGridViewSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSales.Location = new Point(105, 407);
            dataGridViewSales.Name = "dataGridViewSales";
            dataGridViewSales.RowHeadersWidth = 51;
            dataGridViewSales.Size = new Size(816, 297);
            dataGridViewSales.TabIndex = 8;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DarkSeaGreen;
            btnBack.ForeColor = SystemColors.ActiveCaptionText;
            btnBack.Location = new Point(959, 631);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(114, 39);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // SalesReportForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2025_07_05_at_17_181;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1092, 727);
            Controls.Add(btnBack);
            Controls.Add(dataGridViewSales);
            Controls.Add(btnExport);
            Controls.Add(btnRefresh);
            Controls.Add(panelSummary);
            Controls.Add(btnApplyFilter);
            Controls.Add(dateTo);
            Controls.Add(dateFrom);
            Controls.Add(dateTimeTo);
            Controls.Add(dateTimeFrom);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(4);
            Name = "SalesReportForm";
            Text = "SalesReportForm";
            Load += SalesReportForm_Load;
            panelSummary.ResumeLayout(false);
            panelSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimeFrom;
        private DateTimePicker dateTimeTo;
        private Label dateFrom;
        private Label dateTo;
        private Button btnApplyFilter;
        private Panel panelSummary;
        private Label lblTotalRevenue;
        private Label lblTotalSales;
        private Label lblTopProduct;
        private Label lblAverageSale;
        private Button btnRefresh;
        private Button btnExport;
        private DataGridView dataGridViewSales;
        private Button btnBack;
    }
}