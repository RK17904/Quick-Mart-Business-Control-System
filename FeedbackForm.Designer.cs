namespace QuickMart_Business_Control_System
{
    partial class FeedbackForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridViewFeedback = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFeedback).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            button1.Location = new Point(275, 124);
            button1.Name = "button1";
            button1.Size = new Size(124, 43);
            button1.TabIndex = 0;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSeaGreen;
            button2.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            button2.Location = new Point(474, 124);
            button2.Name = "button2";
            button2.Size = new Size(116, 43);
            button2.TabIndex = 1;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSeaGreen;
            button3.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            button3.Location = new Point(677, 128);
            button3.Name = "button3";
            button3.Size = new Size(108, 39);
            button3.TabIndex = 2;
            button3.Text = "Export";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridViewFeedback
            // 
            dataGridViewFeedback.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFeedback.Location = new Point(167, 183);
            dataGridViewFeedback.Name = "dataGridViewFeedback";
            dataGridViewFeedback.RowHeadersWidth = 51;
            dataGridViewFeedback.Size = new Size(743, 359);
            dataGridViewFeedback.TabIndex = 3;
            // 
            // FeedbackForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2025_07_05_at_17_151;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1068, 634);
            Controls.Add(dataGridViewFeedback);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FeedbackForm";
            Text = "Feedback";
            Load += FeedbackForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewFeedback).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridViewFeedback;
    }
}