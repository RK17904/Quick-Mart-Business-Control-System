namespace QuickMart_Business_Control_System
{
    partial class CategoryForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtDescription = new TextBox();
            dataGridView_category = new DataGridView();
            panel1 = new Panel();
            panel3 = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnBack = new Button();
            btnSeller = new Button();
            btnCategory = new Button();
            btnSelling = new Button();
            panel2 = new Panel();
            buttonUpdate = new Button();
            buttonAdd = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_category).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(175, 27);
            label2.Name = "label2";
            label2.Size = new Size(564, 45);
            label2.TabIndex = 6;
            label2.Text = " CATEGORY MANAGEMENT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            label3.Location = new Point(93, 150);
            label3.Name = "label3";
            label3.Size = new Size(48, 22);
            label3.TabIndex = 7;
            label3.Text = "ID :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            label4.Location = new Point(60, 193);
            label4.Name = "label4";
            label4.Size = new Size(81, 22);
            label4.TabIndex = 8;
            label4.Text = "Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            label1.Location = new Point(9, 247);
            label1.Name = "label1";
            label1.Size = new Size(139, 22);
            label1.TabIndex = 9;
            label1.Text = "Description :";
            // 
            // txtID
            // 
            txtID.Location = new Point(162, 143);
            txtID.Name = "txtID";
            txtID.Size = new Size(170, 29);
            txtID.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(162, 193);
            txtName.Name = "txtName";
            txtName.Size = new Size(170, 29);
            txtName.TabIndex = 11;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(162, 247);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(170, 29);
            txtDescription.TabIndex = 12;
            // 
            // dataGridView_category
            // 
            dataGridView_category.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_category.BackgroundColor = SystemColors.ButtonShadow;
            dataGridView_category.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_category.Location = new Point(352, 119);
            dataGridView_category.Name = "dataGridView_category";
            dataGridView_category.RowHeadersWidth = 51;
            dataGridView_category.Size = new Size(507, 315);
            dataGridView_category.TabIndex = 21;
            dataGridView_category.CellContentClick += dataGridView_category_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(235, 549);
            panel1.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(btnBack);
            panel3.Controls.Add(btnSeller);
            panel3.Controls.Add(btnCategory);
            panel3.Controls.Add(btnSelling);
            panel3.Location = new Point(-3, -60);
            panel3.Name = "panel3";
            panel3.Size = new Size(241, 669);
            panel3.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSteelBlue;
            button2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            button2.Location = new Point(27, 323);
            button2.Name = "button2";
            button2.Size = new Size(170, 42);
            button2.TabIndex = 6;
            button2.Text = "SalesReport";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Moccasin;
            button1.Font = new Font("Verdana", 12F, FontStyle.Bold);
            button1.Location = new Point(27, 264);
            button1.Name = "button1";
            button1.Size = new Size(170, 38);
            button1.TabIndex = 5;
            button1.Text = "Feedback";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Tan;
            btnBack.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnBack.Location = new Point(27, 534);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(170, 47);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // btnSeller
            // 
            btnSeller.BackColor = Color.Linen;
            btnSeller.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnSeller.Location = new Point(27, 87);
            btnSeller.Name = "btnSeller";
            btnSeller.Size = new Size(170, 34);
            btnSeller.TabIndex = 1;
            btnSeller.Text = "Home";
            btnSeller.UseVisualStyleBackColor = false;
            btnSeller.Click += btnSeller_Click;
            // 
            // btnCategory
            // 
            btnCategory.BackColor = Color.DarkKhaki;
            btnCategory.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnCategory.Location = new Point(27, 141);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(170, 35);
            btnCategory.TabIndex = 2;
            btnCategory.Text = "Category";
            btnCategory.UseVisualStyleBackColor = false;
            btnCategory.Click += btnCategory_Click_1;
            // 
            // btnSelling
            // 
            btnSelling.BackColor = Color.AliceBlue;
            btnSelling.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnSelling.Location = new Point(27, 203);
            btnSelling.Name = "btnSelling";
            btnSelling.Size = new Size(170, 37);
            btnSelling.TabIndex = 3;
            btnSelling.Text = "Customer";
            btnSelling.UseVisualStyleBackColor = false;
            btnSelling.Click += btnSelling_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.WhatsApp_Image_2025_07_05_at_17_183;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(buttonDelete);
            panel2.Controls.Add(buttonUpdate);
            panel2.Controls.Add(buttonAdd);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtID);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(txtDescription);
            panel2.Controls.Add(dataGridView_category);
            panel2.Controls.Add(label2);
            panel2.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            panel2.Location = new Point(236, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(905, 549);
            panel2.TabIndex = 23;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(494, 485);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 23;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += button3_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(319, 485);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 22;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(666, 485);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 24;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 552);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CategoryForm";
            Text = "CategoryForm";
            Load += CategoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_category).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtDescription;
        private DataGridView dataGridView_category;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button2;
        private Button button1;
        private Button btnBack;
        private Button btnSeller;
        private Button btnCategory;
        private Button btnSelling;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
    }
}