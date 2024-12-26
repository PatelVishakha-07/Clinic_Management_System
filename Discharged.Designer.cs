namespace Clinic_Management_System
{
    partial class Discharged
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
            label1 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Patient_id = new DataGridViewTextBoxColumn();
            ipd_id = new DataGridViewTextBoxColumn();
            Contact_No = new DataGridViewTextBoxColumn();
            Bed_Number = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(289, 36);
            label1.Name = "label1";
            label1.Size = new Size(462, 41);
            label1.TabIndex = 4;
            label1.Text = "Discharged Patient Information";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(125, 145);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(748, 41);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(919, 145);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(124, 41);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, Patient_id, ipd_id, Contact_No, Bed_Number });
            dataGridView1.Location = new Point(125, 238);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(757, 457);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Name
            // 
            Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            // 
            // Patient_id
            // 
            Patient_id.HeaderText = "Patient_id";
            Patient_id.MinimumWidth = 6;
            Patient_id.Name = "Patient_id";
            Patient_id.Visible = false;
            Patient_id.Width = 125;
            // 
            // ipd_id
            // 
            ipd_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ipd_id.HeaderText = "ipd_id";
            ipd_id.MinimumWidth = 6;
            ipd_id.Name = "ipd_id";
            ipd_id.Visible = false;
            // 
            // Contact_No
            // 
            Contact_No.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Contact_No.HeaderText = "Contact_No";
            Contact_No.MinimumWidth = 6;
            Contact_No.Name = "Contact_No";
            // 
            // Bed_Number
            // 
            Bed_Number.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Bed_Number.HeaderText = "Bed Number";
            Bed_Number.MinimumWidth = 6;
            Bed_Number.Name = "Bed_Number";
            // 
            // Discharged
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            Controls.Add(dataGridView1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            //Name = "Discharged";
            Size = new Size(1079, 763);
            Load += Discharged_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Patient_id;
        private DataGridViewTextBoxColumn ipd_id;
        private DataGridViewTextBoxColumn Contact_No;
        private DataGridViewTextBoxColumn Bed_Number;
    }
}
