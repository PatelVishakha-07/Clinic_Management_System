namespace Clinic_Management_System
{
    partial class AddPrescription
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
            dataGridView1 = new DataGridView();
            txtSearch = new TextBox();
            listMedicine = new ListBox();
            txtCharges = new TextBox();
            label11 = new Label();
            lbldisease = new Label();
            txtDisease = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtGender = new TextBox();
            label7 = new Label();
            txtaddress = new TextBox();
            txtContact = new TextBox();
            label6 = new Label();
            btnClear = new Button();
            btnSave = new Button();
            label4 = new Label();
            label5 = new Label();
            txtAge = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(listMedicine);
            panel1.Controls.Add(txtCharges);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(lbldisease);
            panel1.Controls.Add(txtDisease);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtGender);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtaddress);
            panel1.Controls.Add(txtContact);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtAge);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 834);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(653, 378);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(429, 304);
            dataGridView1.TabIndex = 65;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(286, 300);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search....";
            txtSearch.Size = new Size(331, 41);
            txtSearch.TabIndex = 63;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // listMedicine
            // 
            listMedicine.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            listMedicine.FormattingEnabled = true;
            listMedicine.ItemHeight = 35;
            listMedicine.Location = new Point(286, 347);
            listMedicine.Name = "listMedicine";
            listMedicine.Size = new Size(331, 319);
            listMedicine.TabIndex = 62;
            listMedicine.Click += listMedicine_Click;
            listMedicine.SelectedIndexChanged += listMedicine_SelectedIndexChanged;
            // 
            // txtCharges
            // 
            txtCharges.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCharges.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtCharges.Location = new Point(875, 292);
            txtCharges.Name = "txtCharges";
            txtCharges.Size = new Size(207, 41);
            txtCharges.TabIndex = 61;
            txtCharges.TextChanged += txtCharges_TextChanged;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(653, 300);
            label11.Name = "label11";
            label11.Size = new Size(150, 33);
            label11.TabIndex = 60;
            label11.Text = "Charges: ";
            label11.Click += label11_Click;
            // 
            // lbldisease
            // 
            lbldisease.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbldisease.AutoSize = true;
            lbldisease.ForeColor = Color.Red;
            lbldisease.Location = new Point(286, 66);
            lbldisease.Name = "lbldisease";
            lbldisease.Size = new Size(289, 20);
            lbldisease.TabIndex = 57;
            lbldisease.Text = "* Please enter the disease and prescription";
            lbldisease.Visible = false;
            // 
            // txtDisease
            // 
            txtDisease.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDisease.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtDisease.Location = new Point(286, 228);
            txtDisease.Name = "txtDisease";
            txtDisease.Size = new Size(331, 41);
            txtDisease.TabIndex = 54;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(22, 300);
            label8.Name = "label8";
            label8.Size = new Size(180, 33);
            label8.TabIndex = 52;
            label8.Text = "Medicines :";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(22, 234);
            label9.Name = "label9";
            label9.Size = new Size(135, 33);
            label9.TabIndex = 51;
            label9.Text = "Disease:";
            // 
            // txtGender
            // 
            txtGender.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGender.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtGender.Location = new Point(875, 164);
            txtGender.Name = "txtGender";
            txtGender.ReadOnly = true;
            txtGender.Size = new Size(207, 41);
            txtGender.TabIndex = 50;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(902, 207);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 49;
            // 
            // txtaddress
            // 
            txtaddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtaddress.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtaddress.Location = new Point(286, 166);
            txtaddress.Name = "txtaddress";
            txtaddress.ReadOnly = true;
            txtaddress.Size = new Size(331, 41);
            txtaddress.TabIndex = 47;
            // 
            // txtContact
            // 
            txtContact.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtContact.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtContact.Location = new Point(875, 226);
            txtContact.Name = "txtContact";
            txtContact.ReadOnly = true;
            txtContact.Size = new Size(207, 41);
            txtContact.TabIndex = 46;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(644, 226);
            label6.Name = "label6";
            label6.Size = new Size(225, 33);
            label6.TabIndex = 45;
            label6.Text = "Phone Number: ";
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom;
            btnClear.BackColor = Color.LightSteelBlue;
            btnClear.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(23, 539);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(179, 69);
            btnClear.TabIndex = 44;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.BackColor = Color.LightSteelBlue;
            btnSave.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(23, 445);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(179, 69);
            btnSave.TabIndex = 43;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 172);
            label4.Name = "label4";
            label4.Size = new Size(135, 33);
            label4.TabIndex = 42;
            label4.Text = "Address:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(644, 164);
            label5.Name = "label5";
            label5.Size = new Size(135, 33);
            label5.TabIndex = 41;
            label5.Text = "Gender: ";
            // 
            // txtAge
            // 
            txtAge.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAge.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtAge.Location = new Point(875, 97);
            txtAge.Name = "txtAge";
            txtAge.ReadOnly = true;
            txtAge.Size = new Size(207, 41);
            txtAge.TabIndex = 40;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(653, 97);
            label3.Name = "label3";
            label3.Size = new Size(90, 33);
            label3.TabIndex = 39;
            label3.Text = "Age: ";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(286, 100);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(331, 41);
            txtName.TabIndex = 38;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 105);
            label2.Name = "label2";
            label2.Size = new Size(225, 33);
            label2.TabIndex = 37;
            label2.Text = "Patient Name: ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(400, 13);
            label1.Name = "label1";
            label1.Size = new Size(188, 41);
            label1.TabIndex = 0;
            label1.Text = "Prescription";
            // 
            // AddPrescription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(panel1);
            Name = "AddPrescription";
            Size = new Size(1100, 834);
            Load += AddPrescription_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label7;
        private TextBox txtaddress;
        private TextBox txtContact;
        private Label label6;
        private Button btnClear;
        private Button btnSave;
        private Label label4;
        private Label label5;
        private TextBox txtAge;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private TextBox txtGender;
        private TextBox txtDisease;
        private Label label8;
        private Label label9;
        private Label lbldisease;
        private TextBox txtCharges;
        private Label label11;
        private ListBox listMedicine;
        private TextBox txtSearch;
        private DataGridView dataGridView1;
    }
}
