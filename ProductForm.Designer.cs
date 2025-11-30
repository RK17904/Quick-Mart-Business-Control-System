namespace QuickMart_Business_Control_System
{
    partial class ProductForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnBack = new Button();
            btnSeller = new Button();
            btnCategory = new Button();
            btnSelling = new Button();
            panel2 = new Panel();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnLoad = new Button();
            TextBox_category = new TextBox();
            TextBox_qty = new TextBox();
            TextBox_price = new TextBox();
            TextBox_name = new TextBox();
            TextBox_id = new TextBox();
            dataGridView_product = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_product).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnSeller);
            panel1.Controls.Add(btnCategory);
            panel1.Controls.Add(btnSelling);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(241, 669);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSteelBlue;
            button2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            button2.Location = new Point(27, 339);
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
            button1.Location = new Point(27, 274);
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
            btnBack.Location = new Point(27, 574);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(170, 47);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSeller
            // 
            btnSeller.BackColor = Color.Linen;
            btnSeller.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnSeller.Location = new Point(27, 72);
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
            btnCategory.Location = new Point(27, 136);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(170, 35);
            btnCategory.TabIndex = 2;
            btnCategory.Text = "Category";
            btnCategory.UseVisualStyleBackColor = false;
            btnCategory.Click += btnCategory_Click;
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
            panel2.BackgroundImage = Properties.Resources.WhatsApp_Image_2025_07_05_at_17_182;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnLoad);
            panel2.Controls.Add(TextBox_category);
            panel2.Controls.Add(TextBox_qty);
            panel2.Controls.Add(TextBox_price);
            panel2.Controls.Add(TextBox_name);
            panel2.Controls.Add(TextBox_id);
            panel2.Controls.Add(dataGridView_product);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label2);
            panel2.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
            panel2.ForeColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(240, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(933, 669);
            panel2.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkSeaGreen;
            btnDelete.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.Location = new Point(728, 580);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(101, 39);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkSeaGreen;
            btnUpdate.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.ActiveCaptionText;
            btnUpdate.Location = new Point(542, 581);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(127, 39);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkSeaGreen;
            btnAdd.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.ActiveCaptionText;
            btnAdd.Location = new Point(374, 581);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 39);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.DarkSeaGreen;
            btnLoad.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnLoad.ForeColor = SystemColors.ActiveCaptionText;
            btnLoad.Location = new Point(212, 580);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(110, 41);
            btnLoad.TabIndex = 16;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // TextBox_category
            // 
            TextBox_category.Cursor = Cursors.IBeam;
            TextBox_category.ForeColor = SystemColors.WindowText;
            TextBox_category.Location = new Point(145, 336);
            TextBox_category.Name = "TextBox_category";
            TextBox_category.Size = new Size(177, 35);
            TextBox_category.TabIndex = 15;
            // 
            // TextBox_qty
            // 
            TextBox_qty.Location = new Point(145, 281);
            TextBox_qty.Name = "TextBox_qty";
            TextBox_qty.Size = new Size(177, 35);
            TextBox_qty.TabIndex = 11;
            // 
            // TextBox_price
            // 
            TextBox_price.Location = new Point(145, 228);
            TextBox_price.Name = "TextBox_price";
            TextBox_price.Size = new Size(177, 35);
            TextBox_price.TabIndex = 10;
            // 
            // TextBox_name
            // 
            TextBox_name.Location = new Point(145, 184);
            TextBox_name.Name = "TextBox_name";
            TextBox_name.Size = new Size(177, 35);
            TextBox_name.TabIndex = 9;
            // 
            // TextBox_id
            // 
            TextBox_id.Cursor = Cursors.IBeam;
            TextBox_id.ForeColor = SystemColors.WindowText;
            TextBox_id.Location = new Point(145, 136);
            TextBox_id.Name = "TextBox_id";
            TextBox_id.Size = new Size(177, 35);
            TextBox_id.TabIndex = 8;
            // 
            // dataGridView_product
            // 
            dataGridView_product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_product.BackgroundColor = SystemColors.ButtonShadow;
            dataGridView_product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_product.Location = new Point(344, 108);
            dataGridView_product.Name = "dataGridView_product";
            dataGridView_product.RowHeadersWidth = 51;
            dataGridView_product.Size = new Size(550, 443);
            dataGridView_product.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
            label3.Location = new Point(36, 143);
            label3.Name = "label3";
            label3.Size = new Size(61, 28);
            label3.TabIndex = 2;
            label3.Text = "ID :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
            label4.Location = new Point(16, 191);
            label4.Name = "label4";
            label4.Size = new Size(102, 28);
            label4.TabIndex = 3;
            label4.Text = "Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
            label5.Location = new Point(16, 235);
            label5.Name = "label5";
            label5.Size = new Size(94, 28);
            label5.TabIndex = 4;
            label5.Text = "Price :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
            label6.Location = new Point(3, 284);
            label6.Name = "label6";
            label6.Size = new Size(139, 28);
            label6.TabIndex = 5;
            label6.Text = "Quantity :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
            label7.Location = new Point(3, 339);
            label7.Name = "label7";
            label7.Size = new Size(144, 28);
            label7.TabIndex = 6;
            label7.Text = "Category :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(206, 15);
            label2.Name = "label2";
            label2.Size = new Size(528, 45);
            label2.TabIndex = 0;
            label2.Text = "PRODUCT MANAGEMENT";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1171, 667);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ProductForm";
            Text = "ProductForm";
            Load += ProductForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_product).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSeller;
        private Button btnCategory;
        private Button btnSelling;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView_product;
        private TextBox TextBox_id;
        private TextBox TextBox_qty;
        private TextBox TextBox_price;
        private TextBox TextBox_name;
        private TextBox TextBox_category;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnLoad;
        private Button btnBack;
        private Button button2;
        private Button button1;
    }
}
