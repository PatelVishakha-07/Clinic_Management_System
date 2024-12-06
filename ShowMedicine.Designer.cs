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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dataGridView1 = new DataGridView();
            medNameColumn = new DataGridViewTextBoxColumn();
            cmpColumn = new DataGridViewTextBoxColumn();
            stockColumn = new DataGridViewTextBoxColumn();
            dateColumn = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1050, 778);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(374, 48);
            label1.Name = "label1";
            label1.Size = new Size(271, 35);
            label1.TabIndex = 7;
            label1.Text = "Medicine Information";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(192, 192, 255);
            btnSearch.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.ControlText;
            btnSearch.Location = new Point(866, 151);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 41);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(64, 151);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(774, 41);
            txtSearch.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { medNameColumn, cmpColumn, stockColumn, dateColumn });
            dataGridView1.Location = new Point(64, 251);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(922, 479);
            dataGridView1.TabIndex = 4;
            // 
            // medNameColumn
            // 
            medNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            medNameColumn.DefaultCellStyle = dataGridViewCellStyle1;
            medNameColumn.HeaderText = "Medicine Name";
            medNameColumn.MinimumWidth = 6;
            medNameColumn.Name = "medNameColumn";
            medNameColumn.ReadOnly = true;
            // 
            // cmpColumn
            // 
            cmpColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cmpColumn.DefaultCellStyle = dataGridViewCellStyle2;
            cmpColumn.HeaderText = "Company Name";
            cmpColumn.MinimumWidth = 6;
            cmpColumn.Name = "cmpColumn";
            cmpColumn.ReadOnly = true;
            // 
            // stockColumn
            // 
            stockColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            stockColumn.DefaultCellStyle = dataGridViewCellStyle3;
            stockColumn.HeaderText = "Medicine Stock";
            stockColumn.MinimumWidth = 6;
            stockColumn.Name = "stockColumn";
            stockColumn.ReadOnly = true;
            // 
            // dateColumn
            // 
            dateColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dateColumn.DefaultCellStyle = dataGridViewCellStyle4;
            dateColumn.HeaderText = "Expiry Date";
            dateColumn.MinimumWidth = 6;
            dateColumn.Name = "dateColumn";
            dateColumn.ReadOnly = true;
            // 
            // ShowMedicine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.med1;
            Controls.Add(panel1);
            Name = "ShowMedicine";
            Size = new Size(1050, 778);
            Load += ShowMedicine_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn medNameColumn;
        private DataGridViewTextBoxColumn cmpColumn;
        private DataGridViewTextBoxColumn stockColumn;
        private DataGridViewTextBoxColumn dateColumn;
    }
}
