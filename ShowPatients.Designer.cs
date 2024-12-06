namespace Clinic_Management_System
{
    partial class ShowPatients
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnSearch = new Button();
            textBox1 = new TextBox();
            Name = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            city = new DataGridViewTextBoxColumn();
            contact = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1194, 790);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1194, 58);
            panel2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(446, 9);
            label1.Name = "label1";
            label1.Size = new Size(289, 38);
            label1.TabIndex = 0;
            label1.Text = "Patients Information";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, Age, city, contact });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(22, 183);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1117, 528);
            dataGridView1.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(975, 114);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(146, 45);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(22, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(870, 41);
            textBox1.TabIndex = 9;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 8;
            Name.Name = "Name";
            Name.Width = 370;
            // 
            // Age
            // 
            Age.HeaderText = "Age";
            Age.MinimumWidth = 8;
            Age.Name = "Age";
            Age.Width = 200;
            // 
            // city
            // 
            city.HeaderText = "City";
            city.MinimumWidth = 8;
            city.Name = "city";
            city.Width = 150;
            // 
            // contact
            // 
            contact.HeaderText = "Contact";
            contact.MinimumWidth = 8;
            contact.Name = "contact";
            contact.Width = 200;
            // 
            // ShowPatients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ShowPatients";
            Size = new Size(1194, 790);
            Load += ShowPatients_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnSearch;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn city;
        private DataGridViewTextBoxColumn contact;
    }
}
