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
            lbldisease = new Label();
            pictureBox1 = new PictureBox();
            txtDisease = new TextBox();
            txtPres = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(lbldisease);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtDisease);
            panel1.Controls.Add(txtPres);
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
            panel1.Size = new Size(1100, 763);
            panel1.TabIndex = 0;
            // 
            // lbldisease
            // 
            lbldisease.AutoSize = true;
            lbldisease.ForeColor = Color.Red;
            lbldisease.Location = new Point(579, 86);
            lbldisease.Name = "lbldisease";
            lbldisease.Size = new Size(289, 20);
            lbldisease.TabIndex = 57;
            lbldisease.Text = "* Please enter the disease and prescription";
            lbldisease.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.prescription;
            pictureBox1.Location = new Point(32, 184);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 330);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 55;
            pictureBox1.TabStop = false;
            // 
            // txtDisease
            // 
            txtDisease.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtDisease.Location = new Point(579, 437);
            txtDisease.Name = "txtDisease";
            txtDisease.Size = new Size(457, 41);
            txtDisease.TabIndex = 54;
            // 
            // txtPres
            // 
            txtPres.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtPres.Location = new Point(579, 504);
            txtPres.Multiline = true;
            txtPres.Name = "txtPres";
            txtPres.Size = new Size(457, 76);
            txtPres.TabIndex = 53;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(315, 510);
            label8.Name = "label8";
            label8.Size = new Size(225, 33);
            label8.TabIndex = 52;
            label8.Text = "Prescription: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(315, 443);
            label9.Name = "label9";
            label9.Size = new Size(135, 33);
            label9.TabIndex = 51;
            label9.Text = "Disease:";
            // 
            // txtGender
            // 
            txtGender.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtGender.Location = new Point(579, 248);
            txtGender.Name = "txtGender";
            txtGender.ReadOnly = true;
            txtGender.Size = new Size(457, 41);
            txtGender.TabIndex = 50;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(579, 291);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 49;
            // 
            // txtaddress
            // 
            txtaddress.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtaddress.Location = new Point(579, 307);
            txtaddress.Name = "txtaddress";
            txtaddress.ReadOnly = true;
            txtaddress.Size = new Size(457, 41);
            txtaddress.TabIndex = 47;
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtContact.Location = new Point(579, 374);
            txtContact.Name = "txtContact";
            txtContact.ReadOnly = true;
            txtContact.Size = new Size(457, 41);
            txtContact.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(315, 380);
            label6.Name = "label6";
            label6.Size = new Size(225, 33);
            label6.TabIndex = 45;
            label6.Text = "Phone Number: ";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightSteelBlue;
            btnClear.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(611, 607);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(179, 69);
            btnClear.TabIndex = 44;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSteelBlue;
            btnSave.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(315, 607);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(179, 69);
            btnSave.TabIndex = 43;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(315, 313);
            label4.Name = "label4";
            label4.Size = new Size(135, 33);
            label4.TabIndex = 42;
            label4.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(315, 248);
            label5.Name = "label5";
            label5.Size = new Size(135, 33);
            label5.TabIndex = 41;
            label5.Text = "Gender: ";
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtAge.Location = new Point(579, 179);
            txtAge.Name = "txtAge";
            txtAge.ReadOnly = true;
            txtAge.Size = new Size(457, 41);
            txtAge.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(315, 184);
            label3.Name = "label3";
            label3.Size = new Size(90, 33);
            label3.TabIndex = 39;
            label3.Text = "Age: ";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(579, 120);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(457, 41);
            txtName.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(315, 125);
            label2.Name = "label2";
            label2.Size = new Size(225, 33);
            label2.TabIndex = 37;
            label2.Text = "Patient Name: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(426, 23);
            label1.Name = "label1";
            label1.Size = new Size(188, 41);
            label1.TabIndex = 0;
            label1.Text = "Prescription";
            // 
            // AddPrescription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AddPrescription";
            Size = new Size(1100, 763);
            Load += AddPrescription_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private TextBox txtPres;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox1;
        private Label lbldisease;
    }
}
