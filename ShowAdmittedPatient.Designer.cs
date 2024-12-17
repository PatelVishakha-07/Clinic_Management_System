namespace Clinic_Management_System
{
    partial class ShowAdmittedPatient
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
            panel1 = new Panel();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dataGridView1 = new DataGridView();
            Bed_Number = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            ipd_id = new DataGridViewTextBoxColumn();
            Contact_No = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 763);
            panel1.TabIndex = 0;
          //  panel1.Paint += panel1_Paint;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(930, 157);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(124, 41);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(54, 157);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(769, 41);
            txtSearch.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Bed_Number, Name, ipd_id, Contact_No });
            dataGridView1.Location = new Point(155, 263);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(778, 457);
            dataGridView1.TabIndex = 5;
            //dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Bed_Number
            // 
            Bed_Number.HeaderText = "Bed_Number";
            Bed_Number.MinimumWidth = 6;
            Bed_Number.Name = "Bed_Number";
            Bed_Number.Width = 125;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.Width = 300;
            // 
            // ipd_id
            // 
            ipd_id.HeaderText = "ipd_id";
            ipd_id.MinimumWidth = 6;
            ipd_id.Name = "ipd_id";
            ipd_id.Visible = false;
            ipd_id.Width = 125;
            // 
            // Contact_No
            // 
            Contact_No.HeaderText = "Contact_No";
            Contact_No.MinimumWidth = 6;
            Contact_No.Name = "Contact_No";
            Contact_No.Width = 300;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(298, 28);
            label1.Name = "label1";
            label1.Size = new Size(439, 41);
            label1.TabIndex = 3;
            label1.Text = "Admitted Patient Information";
            // 
            // ShowAdmittedPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
          //  Name = "ShowAdmittedPatient";
            Size = new Size(1100, 763);
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
        private DataGridViewTextBoxColumn Bed_Number;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn ipd_id;
        private DataGridViewTextBoxColumn Contact_No;
    }
}
