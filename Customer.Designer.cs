namespace QuickMart_Business_Control_System
{
    partial class Customer
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
            panel1 = new Panel();
            button5 = new Button();
            button6 = new Button();
            btnBack = new Button();
            btnSeller = new Button();
            btnCategory = new Button();
            btnSelling = new Button();
            panel2 = new Panel();
            btnSearch = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            datagridviewCustomer = new DataGridView();
            btnLoad = new Button();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridviewCustomer).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnSeller);
            panel1.Controls.Add(btnCategory);
            panel1.Controls.Add(btnSelling);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 524);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = Color.LightSteelBlue;
            button5.Font = new Font("Verdana", 12F, FontStyle.Bold);
            button5.Location = new Point(30, 256);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(149, 31);
            button5.TabIndex = 12;
            button5.Text = "SalesReport";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // button6
            // 
            button6.BackColor = Color.Moccasin;
            button6.Font = new Font("Verdana", 12F, FontStyle.Bold);
            button6.Location = new Point(30, 208);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(149, 28);
            button6.TabIndex = 11;
            button6.Text = "Feedback";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Tan;
            btnBack.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnBack.Location = new Point(30, 433);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(149, 35);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSeller
            // 
            btnSeller.BackColor = Color.Linen;
            btnSeller.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnSeller.Location = new Point(30, 56);
            btnSeller.Margin = new Padding(3, 2, 3, 2);
            btnSeller.Name = "btnSeller";
            btnSeller.Size = new Size(149, 28);
            btnSeller.TabIndex = 7;
            btnSeller.Text = "Home";
            btnSeller.UseVisualStyleBackColor = false;
            // 
            // btnCategory
            // 
            btnCategory.BackColor = Color.DarkKhaki;
            btnCategory.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnCategory.Location = new Point(30, 104);
            btnCategory.Margin = new Padding(3, 2, 3, 2);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(149, 32);
            btnCategory.TabIndex = 8;
            btnCategory.Text = "Category";
            btnCategory.UseVisualStyleBackColor = false;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnSelling
            // 
            btnSelling.BackColor = Color.AliceBlue;
            btnSelling.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnSelling.Location = new Point(30, 154);
            btnSelling.Margin = new Padding(3, 2, 3, 2);
            btnSelling.Name = "btnSelling";
            btnSelling.Size = new Size(149, 29);
            btnSelling.TabIndex = 9;
            btnSelling.Text = "Customer";
            btnSelling.UseVisualStyleBackColor = false;
            btnSelling.Click += btnSelling_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AntiqueWhite;
            panel2.BackgroundImage = Properties.Resources.WhatsApp_Image_2025_07_05_at_17_18_47_9085a7e0;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(datagridviewCustomer);
            panel2.Controls.Add(btnLoad);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(txtId);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(210, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(710, 524);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkSeaGreen;
            btnSearch.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            btnSearch.Location = new Point(485, 250);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(88, 26);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkSeaGreen;
            btnDelete.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            btnDelete.Location = new Point(359, 250);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 26);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkSeaGreen;
            btnUpdate.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            btnUpdate.Location = new Point(231, 250);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(88, 26);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkSeaGreen;
            btnAdd.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            btnAdd.Location = new Point(109, 250);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 26);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // datagridviewCustomer
            // 
            datagridviewCustomer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datagridviewCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridviewCustomer.Location = new Point(61, 299);
            datagridviewCustomer.Margin = new Padding(3, 2, 3, 2);
            datagridviewCustomer.Name = "datagridviewCustomer";
            datagridviewCustomer.RowHeadersWidth = 51;
            datagridviewCustomer.Size = new Size(578, 197);
            datagridviewCustomer.TabIndex = 4;
            datagridviewCustomer.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.PaleGoldenrod;
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoad.Location = new Point(293, 208);
            btnLoad.Margin = new Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(90, 28);
            btnLoad.TabIndex = 13;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += button5_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(293, 119);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(271, 23);
            txtEmail.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(293, 153);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(271, 23);
            txtPhone.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Location = new Point(293, 88);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(271, 23);
            txtName.TabIndex = 8;
            // 
            // txtId
            // 
            txtId.Location = new Point(293, 56);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(271, 23);
            txtId.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label5.Location = new Point(187, 154);
            label5.Name = "label5";
            label5.Size = new Size(70, 18);
            label5.TabIndex = 4;
            label5.Text = "Phone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label4.Location = new Point(194, 119);
            label4.Name = "label4";
            label4.Size = new Size(60, 18);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.Location = new Point(151, 89);
            label3.Name = "label3";
            label3.Size = new Size(99, 18);
            label3.TabIndex = 2;
            label3.Text = "Full Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.Location = new Point(134, 58);
            label2.Name = "label2";
            label2.Size = new Size(125, 18);
            label2.TabIndex = 1;
            label2.Text = "Customer ID:";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(194, 7);
            label1.Name = "label1";
            label1.Size = new Size(346, 38);
            label1.TabIndex = 0;
            label1.Text = "MANAGE CUSTOMER";
            label1.Click += label1_Click;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 524);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Customer";
            Text = "Customer";
            Load += Customer_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datagridviewCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtName;
        private TextBox txtId;
        private Button btnLoad;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView datagridviewCustomer;
        private Button button5;
        private Button button6;
        private Button btnBack;
        private Button btnSeller;
        private Button btnCategory;
        private Button btnSelling;
    }
}