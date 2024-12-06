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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            leftPanel = new Panel();
            TopPanel = new Panel();
            panelshowmedgrid = new Panel();
            dataGridView1 = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Company = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Expiry_Date = new DataGridViewTextBoxColumn();
            panelshowmedgrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Margin = new Padding(4);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(301, 950);
            leftPanel.TabIndex = 1;
            // 
            // TopPanel
            // 
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(301, 0);
            TopPanel.Margin = new Padding(4);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(937, 112);
            TopPanel.TabIndex = 2;
            // 
            // panelshowmedgrid
            // 
            panelshowmedgrid.Controls.Add(dataGridView1);
            panelshowmedgrid.Location = new Point(308, 119);
            panelshowmedgrid.Name = "panelshowmedgrid";
            panelshowmedgrid.Size = new Size(920, 819);
            panelshowmedgrid.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, Company, Quantity, Expiry_Date });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.AppWorkspace;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Gainsboro;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = Color.Gainsboro;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Info;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(920, 819);
            dataGridView1.TabIndex = 0;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 8;
            Name.Name = "Name";
            Name.Width = 350;
            // 
            // Company
            // 
            Company.HeaderText = "Company";
            Company.MinimumWidth = 8;
            Company.Name = "Company";
            Company.Width = 250;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 8;
            Quantity.Name = "Quantity";
            Quantity.Width = 120;
            // 
            // Expiry_Date
            // 
            Expiry_Date.HeaderText = "Expiry_Date";
            Expiry_Date.MinimumWidth = 8;
            Expiry_Date.Name = "Expiry_Date";
            Expiry_Date.Width = 150;
            // 
            // ShowMedicine
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 950);
            Controls.Add(panelshowmedgrid);
            Controls.Add(TopPanel);
            Controls.Add(leftPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
           // Name = "ShowMedicine";
            Text = "ShowMedicine";
            Load += ShowMedicine_Load;
            panelshowmedgrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel leftPanel;
        private Panel TopPanel;
        private Panel panelshowmedgrid;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Company;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Expiry_Date;
    }
}