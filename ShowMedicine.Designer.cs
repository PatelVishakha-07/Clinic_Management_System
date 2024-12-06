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
            leftPanel = new Panel();
            TopPanel = new Panel();
            dataGridView1 = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Company = new DataGridViewTextBoxColumn();
            Quanity = new DataGridViewTextBoxColumn();
            Expiry = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Margin = new Padding(4);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(275, 950);
            leftPanel.TabIndex = 1;
            // 
            // TopPanel
            // 
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(275, 0);
            TopPanel.Margin = new Padding(4);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(963, 112);
            TopPanel.TabIndex = 2;
            TopPanel.Paint += TopPanel_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, Company, Quanity, Expiry });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Dock = DockStyle.Right;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(282, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(956, 838);
            dataGridView1.TabIndex = 3;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 8;
            Name.Name = "Name";
            Name.Width = 370;
            // 
            // Company
            // 
            Company.HeaderText = "Company";
            Company.MinimumWidth = 8;
            Company.Name = "Company";
            Company.Width = 200;
            // 
            // Quanity
            // 
            Quanity.HeaderText = "Quantity";
            Quanity.MinimumWidth = 8;
            Quanity.Name = "Quanity";
            Quanity.Width = 150;
            // 
            // Expiry
            // 
            Expiry.HeaderText = "Expiry";
            Expiry.MinimumWidth = 8;
            Expiry.Name = "Expiry";
            Expiry.Width = 200;
            // 
            // ShowMedicine
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 950);
            Controls.Add(dataGridView1);
            Controls.Add(TopPanel);
            Controls.Add(leftPanel);
            Name = "ShowMedicine";
            Text = "ShowMedicine";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel leftPanel;
        private Panel TopPanel;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Company;
        private DataGridViewTextBoxColumn Quanity;
        private DataGridViewTextBoxColumn Expiry;
    }
}