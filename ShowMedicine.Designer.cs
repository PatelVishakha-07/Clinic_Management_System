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
            medicinegrid = new DataGridView();
            label1 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            Medicine_Name = new DataGridViewTextBoxColumn();
            Company_Name = new DataGridViewTextBoxColumn();
            Medicine_Stock = new DataGridViewTextBoxColumn();
            Expiry_Date = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)medicinegrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.BackgroundImage = Properties.Resources.med1;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(medicinegrid);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Cursor = Cursors.IBeam;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 763);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // medicinegrid
            // 
            medicinegrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Info;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            medicinegrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            medicinegrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            medicinegrid.Columns.AddRange(new DataGridViewColumn[] { Medicine_Name, Company_Name, Medicine_Stock, Expiry_Date });
            medicinegrid.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Info;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            medicinegrid.DefaultCellStyle = dataGridViewCellStyle2;
            medicinegrid.GridColor = SystemColors.Info;
            medicinegrid.Location = new Point(25, 178);
            medicinegrid.Name = "medicinegrid";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            medicinegrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            medicinegrid.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Info;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            medicinegrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            medicinegrid.RowTemplate.Height = 29;
            medicinegrid.Size = new Size(1028, 516);
            medicinegrid.TabIndex = 4;
            medicinegrid.CellContentClick += medicinegrid_CellContentClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(371, 19);
            label1.Name = "label1";
            label1.Size = new Size(370, 46);
            label1.TabIndex = 3;
            label1.Text = "Medicine Information";
            label1.Click += label1_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(905, 105);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(148, 41);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(25, 105);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(822, 41);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += textBox1_TextChanged;
            // 
            // Medicine_Name
            // 
            Medicine_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Medicine_Name.HeaderText = "Medicine Name";
            Medicine_Name.MinimumWidth = 8;
            Medicine_Name.Name = "Medicine_Name";
            // 
            // Company_Name
            // 
            Company_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Company_Name.HeaderText = "Company Name";
            Company_Name.MinimumWidth = 8;
            Company_Name.Name = "Company_Name";
            // 
            // Medicine_Stock
            // 
            Medicine_Stock.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Medicine_Stock.HeaderText = "Medicine Stock";
            Medicine_Stock.MinimumWidth = 8;
            Medicine_Stock.Name = "Medicine_Stock";
            Medicine_Stock.Width = 139;
            // 
            // Expiry_Date
            // 
            Expiry_Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Expiry_Date.HeaderText = "Expiry Date";
            Expiry_Date.MinimumWidth = 8;
            Expiry_Date.Name = "Expiry_Date";
            // 
            // ShowMedicine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ShowMedicine";
            Size = new Size(1100, 763);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)medicinegrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtSearch;
        private Label label1;
        private Button btnSearch;
        private DataGridView medicinegrid;
        private DataGridViewTextBoxColumn Medicine_Name;
        private DataGridViewTextBoxColumn Company_Name;
        private DataGridViewTextBoxColumn Medicine_Stock;
        private DataGridViewTextBoxColumn Expiry_Date;
    }
}
