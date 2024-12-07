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
            panel1 = new Panel();
            label1 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dataGridView1 = new DataGridView();
            Medicine_Name = new DataGridViewTextBoxColumn();
            Company_Name = new DataGridViewTextBoxColumn();
            Medicine_Stock = new DataGridViewTextBoxColumn();
            Expiry_Date = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.BackgroundImage = Properties.Resources.med1;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 807);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(333, 19);
            label1.Name = "label1";
            label1.Size = new Size(370, 46);
            label1.TabIndex = 3;
            label1.Text = "Medicine Information";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(814, 105);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(148, 41);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(25, 105);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(719, 41);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.SandyBrown;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 45;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Medicine_Name, Company_Name, Medicine_Stock, Expiry_Date });
            dataGridView1.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(25, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(937, 535);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Medicine_Name
            // 
            Medicine_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Medicine_Name.HeaderText = "Medicine Name";
            Medicine_Name.MinimumWidth = 6;
            Medicine_Name.Name = "Medicine_Name";
            Medicine_Name.ReadOnly = true;
            // 
            // Company_Name
            // 
            Company_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Company_Name.HeaderText = "Company Name";
            Company_Name.MinimumWidth = 6;
            Company_Name.Name = "Company_Name";
            Company_Name.ReadOnly = true;
            // 
            // Medicine_Stock
            // 
            Medicine_Stock.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Medicine_Stock.HeaderText = "Medicine Stock";
            Medicine_Stock.MinimumWidth = 6;
            Medicine_Stock.Name = "Medicine_Stock";
            Medicine_Stock.ReadOnly = true;
            // 
            // Expiry_Date
            // 
            Expiry_Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Expiry_Date.HeaderText = "Expiry Date";
            Expiry_Date.MinimumWidth = 6;
            Expiry_Date.Name = "Expiry_Date";
            Expiry_Date.ReadOnly = true;
            Expiry_Date.Width = 165;
            // 
            // ShowMedicine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ShowMedicine";
            Size = new Size(1008, 807);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtSearch;
        private Label label1;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Medicine_Name;
        private DataGridViewTextBoxColumn Company_Name;
        private DataGridViewTextBoxColumn Medicine_Stock;
        private DataGridViewTextBoxColumn Expiry_Date;
    }
}
