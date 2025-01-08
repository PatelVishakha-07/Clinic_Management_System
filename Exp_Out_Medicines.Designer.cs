namespace Clinic_Management_System
{
    partial class Exp_Out_Medicines
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
            panel1 = new Panel();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            medicine_name = new DataGridViewTextBoxColumn();
            company_name = new DataGridViewTextBoxColumn();
            medicine_type = new DataGridViewTextBoxColumn();
            medicine_stock = new DataGridViewTextBoxColumn();
            expiry_date = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 763);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(916, 134);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(151, 41);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(40, 134);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(815, 41);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(402, 20);
            label1.Name = "label1";
            label1.Size = new Size(277, 41);
            label1.TabIndex = 1;
            label1.Text = "Expired Medicines";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Info;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { medicine_name, company_name, medicine_type, medicine_stock, expiry_date });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Info;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(40, 255);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1027, 484);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // medicine_name
            // 
            medicine_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            medicine_name.HeaderText = "Medicine Name";
            medicine_name.MinimumWidth = 6;
            medicine_name.Name = "medicine_name";
            // 
            // company_name
            // 
            company_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            company_name.HeaderText = "Company Name";
            company_name.MinimumWidth = 6;
            company_name.Name = "company_name";
            // 
            // medicine_type
            // 
            medicine_type.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            medicine_type.HeaderText = "Medicine Type";
            medicine_type.MinimumWidth = 6;
            medicine_type.Name = "medicine_type";
            // 
            // medicine_stock
            // 
            medicine_stock.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            medicine_stock.HeaderText = "Medicine Stock";
            medicine_stock.MinimumWidth = 6;
            medicine_stock.Name = "medicine_stock";
            // 
            // expiry_date
            // 
            expiry_date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            expiry_date.HeaderText = "Expiry Date";
            expiry_date.MinimumWidth = 6;
            expiry_date.Name = "expiry_date";
            // 
            // Exp_Out_Medicines
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Exp_Out_Medicines";
            Size = new Size(1100, 763);
            Load += Exp_Out_Medicines_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label1;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridViewTextBoxColumn medicine_name;
        private DataGridViewTextBoxColumn company_name;
        private DataGridViewTextBoxColumn medicine_type;
        private DataGridViewTextBoxColumn medicine_stock;
        private DataGridViewTextBoxColumn expiry_date;
    }
}
