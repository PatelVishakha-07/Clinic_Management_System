namespace Clinic_Management_System
{
    partial class ShowMedicine
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            Expiry = new DataGridViewTextBoxColumn();
            Quanity = new DataGridViewTextBoxColumn();
            Company = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            btnSearch = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1176, 58);
            panel1.TabIndex = 4;
            // 
            // Expiry
            // 
            Expiry.HeaderText = "Expiry";
            Expiry.MinimumWidth = 8;
            Expiry.Name = "Expiry";
            Expiry.Width = 200;
            // 
            // Quanity
            // 
            Quanity.HeaderText = "Quantity";
            Quanity.MinimumWidth = 8;
            Quanity.Name = "Quanity";
            Quanity.Width = 150;
            // 
            // Company
            // 
            Company.HeaderText = "Company";
            Company.MinimumWidth = 8;
            Company.Name = "Company";
            Company.Width = 200;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 8;
            Name.Name = "Name";
            Name.Width = 370;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, Company, Quanity, Expiry });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(28, 204);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1117, 528);
            dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(446, 9);
            label1.Name = "label1";
            label1.Size = new Size(304, 38);
            label1.TabIndex = 0;
            label1.Text = "Medicine Information";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(28, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(870, 41);
            textBox1.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(952, 118);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(146, 45);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // ShowMedicine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1176, 743);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ShowMedicine";
            Text = "ShowMedicine";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private DataGridViewTextBoxColumn Expiry;
        private DataGridViewTextBoxColumn Quanity;
        private DataGridViewTextBoxColumn Company;
        private DataGridViewTextBoxColumn Name;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button btnSearch;
    }
}