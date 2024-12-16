namespace Clinic_Management_System
{
    partial class InHouse_Patient
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
            btnClear = new Button();
            btnAdmit = new Button();
            txtBed = new TextBox();
            txtRoom = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            txtDiagnosis = new TextBox();
            txtAddress = new TextBox();
            txtGender = new TextBox();
            txtContact = new TextBox();
            txtAge = new TextBox();
            name = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnAdmit);
            panel1.Controls.Add(txtBed);
            panel1.Controls.Add(txtRoom);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(txtDiagnosis);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtGender);
            panel1.Controls.Add(txtContact);
            panel1.Controls.Add(txtAge);
            panel1.Controls.Add(name);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1178, 871);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClear.BackColor = Color.SandyBrown;
            btnClear.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = SystemColors.InactiveCaptionText;
            btnClear.Location = new Point(121, 797);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(127, 62);
            btnClear.TabIndex = 21;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdmit
            // 
            btnAdmit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdmit.BackColor = Color.SandyBrown;
            btnAdmit.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdmit.ForeColor = SystemColors.InactiveCaptionText;
            btnAdmit.Location = new Point(121, 717);
            btnAdmit.Name = "btnAdmit";
            btnAdmit.Size = new Size(127, 62);
            btnAdmit.TabIndex = 20;
            btnAdmit.Text = "Admit";
            btnAdmit.UseVisualStyleBackColor = false;
            btnAdmit.Click += btnAdmit_Click;
            // 
            // txtBed
            // 
            txtBed.Anchor = AnchorStyles.Top;
            txtBed.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtBed.Location = new Point(648, 738);
            txtBed.Name = "txtBed";
            txtBed.Size = new Size(484, 41);
            txtBed.TabIndex = 19;
            txtBed.TextChanged += txtBed_TextChanged;
            // 
            // txtRoom
            // 
            txtRoom.Anchor = AnchorStyles.Top;
            txtRoom.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtRoom.Location = new Point(648, 657);
            txtRoom.Name = "txtRoom";
            txtRoom.Size = new Size(484, 41);
            txtRoom.TabIndex = 18;
            txtRoom.TextChanged += txtRoom_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top;
            dateTimePicker1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(648, 579);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(484, 41);
            dateTimePicker1.TabIndex = 17;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Anchor = AnchorStyles.Top;
            txtDiagnosis.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiagnosis.Location = new Point(648, 512);
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.Size = new Size(484, 41);
            txtDiagnosis.TabIndex = 16;
            txtDiagnosis.TextChanged += txtDiagnosis_TextChanged;
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top;
            txtAddress.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(648, 437);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(484, 41);
            txtAddress.TabIndex = 15;
            txtAddress.TextChanged += txtAddress_TextChanged;
            // 
            // txtGender
            // 
            txtGender.Anchor = AnchorStyles.Top;
            txtGender.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtGender.Location = new Point(648, 366);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(484, 41);
            txtGender.TabIndex = 14;
            txtGender.TextChanged += txtGender_TextChanged;
            // 
            // txtContact
            // 
            txtContact.Anchor = AnchorStyles.Top;
            txtContact.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtContact.Location = new Point(648, 292);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(484, 41);
            txtContact.TabIndex = 13;
            txtContact.TextChanged += txtContact_TextChanged;
            // 
            // txtAge
            // 
            txtAge.Anchor = AnchorStyles.Top;
            txtAge.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtAge.Location = new Point(648, 222);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(484, 41);
            txtAge.TabIndex = 12;
            txtAge.TextChanged += txtAge_TextChanged;
            // 
            // name
            // 
            name.Anchor = AnchorStyles.Top;
            name.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(648, 149);
            name.Name = "name";
            name.Size = new Size(484, 41);
            name.TabIndex = 11;
            name.TextChanged += name_TextChanged;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(385, 741);
            label10.Name = "label10";
            label10.Size = new Size(180, 35);
            label10.TabIndex = 10;
            label10.Text = "Bed Number: ";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(385, 663);
            label9.Name = "label9";
            label9.Size = new Size(203, 35);
            label9.TabIndex = 9;
            label9.Text = "Room Number: ";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(385, 585);
            label8.Name = "label8";
            label8.Size = new Size(213, 35);
            label8.TabIndex = 8;
            label8.Text = "Admission Date: ";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(385, 372);
            label7.Name = "label7";
            label7.Size = new Size(116, 35);
            label7.TabIndex = 7;
            label7.Text = "Gender: ";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(385, 515);
            label6.Name = "label6";
            label6.Size = new Size(141, 35);
            label6.TabIndex = 6;
            label6.Text = "Diagnosis: ";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(385, 443);
            label5.Name = "label5";
            label5.Size = new Size(123, 35);
            label5.TabIndex = 5;
            label5.Text = "Address: ";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(385, 298);
            label4.Name = "label4";
            label4.Size = new Size(226, 35);
            label4.TabIndex = 4;
            label4.Text = "Contact Number: ";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(385, 225);
            label3.Name = "label3";
            label3.Size = new Size(76, 35);
            label3.TabIndex = 3;
            label3.Text = "Age: ";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.add;
            pictureBox1.Location = new Point(34, 155);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(319, 543);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(385, 155);
            label2.Name = "label2";
            label2.Size = new Size(189, 35);
            label2.TabIndex = 1;
            label2.Text = "Patient Name: ";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(417, 30);
            label1.Name = "label1";
            label1.Size = new Size(214, 41);
            label1.TabIndex = 0;
            label1.Text = "Admit Patient";
            // 
            // InHouse_Patient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "InHouse_Patient";
            Size = new Size(1178, 871);
            Load += InHouse_Patient_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label9;
        private Label label8;
        private TextBox name;
        private Label label10;
        private TextBox txtAge;
        private TextBox txtContact;
        private TextBox txtGender;
        private TextBox txtAddress;
        private TextBox txtDiagnosis;
        private DateTimePicker dateTimePicker1;
        private TextBox txtRoom;
        private TextBox txtBed;
        private Button btnAdmit;
        private Button btnClear;
    }
}
