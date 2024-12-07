namespace Clinic_Management_System
{
    partial class AddPatients
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
            listBox1 = new ListBox();
            lblall = new Label();
            lblage = new Label();
            lbladd = new Label();
            lblph_no = new Label();
            lblname = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(lblall);
            panel1.Controls.Add(lblage);
            panel1.Controls.Add(lbladd);
            panel1.Controls.Add(lblph_no);
            panel1.Controls.Add(lblname);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(comboBox1);
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
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1375, 954);
            panel1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(768, 221);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(481, 129);
            listBox1.TabIndex = 36;
            listBox1.Visible = false;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lblall
            // 
            lblall.AutoSize = true;
            lblall.ForeColor = Color.Red;
            lblall.Location = new Point(768, 126);
            lblall.Name = "lblall";
            lblall.Size = new Size(234, 25);
            lblall.TabIndex = 35;
            lblall.Text = "*One or more field is empty";
            lblall.Visible = false;
            // 
            // lblage
            // 
            lblage.AutoSize = true;
            lblage.ForeColor = Color.Red;
            lblage.Location = new Point(768, 332);
            lblage.Name = "lblage";
            lblage.Size = new Size(214, 25);
            lblage.TabIndex = 34;
            lblage.Text = "* Please Enter Proper Age";
            lblage.Visible = false;
            // 
            // lbladd
            // 
            lbladd.AutoSize = true;
            lbladd.ForeColor = Color.Red;
            lbladd.Location = new Point(768, 555);
            lbladd.Name = "lbladd";
            lbladd.Size = new Size(264, 25);
            lbladd.TabIndex = 33;
            lbladd.Text = "* Please Enter Address Correctly";
            lbladd.Visible = false;
            // 
            // lblph_no
            // 
            lblph_no.AutoSize = true;
            lblph_no.ForeColor = Color.Red;
            lblph_no.Location = new Point(768, 665);
            lblph_no.Name = "lblph_no";
            lblph_no.Size = new Size(247, 25);
            lblph_no.TabIndex = 32;
            lblph_no.Text = "* Please Enter Proper Number";
            lblph_no.Visible = false;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.ForeColor = Color.Red;
            lblname.Location = new Point(768, 221);
            lblname.Name = "lblname";
            lblname.Size = new Size(229, 25);
            lblname.TabIndex = 31;
            lblname.Text = "* Please Enter Proper Name";
            lblname.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(768, 332);
            label7.Name = "label7";
            label7.Size = new Size(0, 25);
            label7.TabIndex = 30;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "Male", "Female" });
            comboBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(768, 392);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(570, 49);
            comboBox1.TabIndex = 29;
            // 
            // txtaddress
            // 
            txtaddress.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtaddress.Location = new Point(768, 504);
            txtaddress.Margin = new Padding(4);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(570, 47);
            txtaddress.TabIndex = 28;
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtContact.Location = new Point(768, 614);
            txtContact.Margin = new Padding(4);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(570, 47);
            txtContact.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(438, 621);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(269, 40);
            label6.TabIndex = 26;
            label6.Text = "Phone Number: ";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightSteelBlue;
            btnClear.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(808, 790);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(224, 86);
            btnClear.TabIndex = 25;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSteelBlue;
            btnSave.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(409, 790);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(224, 86);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(438, 511);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(161, 40);
            label4.TabIndex = 21;
            label4.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(438, 401);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(161, 40);
            label5.TabIndex = 19;
            label5.Text = "Gender: ";
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtAge.Location = new Point(768, 281);
            txtAge.Margin = new Padding(4);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(570, 47);
            txtAge.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(438, 288);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 40);
            label3.TabIndex = 17;
            label3.Text = "Age: ";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(768, 172);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(570, 47);
            txtName.TabIndex = 16;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Image = Properties.Resources.patient;
            pictureBox1.Location = new Point(30, 221);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(358, 370);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(438, 179);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(269, 40);
            label2.TabIndex = 14;
            label2.Text = "Patient Name: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(589, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(223, 46);
            label1.TabIndex = 13;
            label1.Text = "Add Patients";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddPatients
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "AddPatients";
            Size = new Size(1375, 954);
            Load += AddPatients_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnClear;
        private Button btnSave;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private TextBox txtStock;
        private Label label5;
        private TextBox txtAge;
        private Label label3;
        private TextBox txtName;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private TextBox txtaddress;
        private TextBox txtContact;
        private Label label6;
        private Label lblname;
        private Label label7;
        private Label lblph_no;
        private Label lblage;
        private Label lbladd;
        private Label lblall;
        private ComboBox comboBox1;
        private ListBox listBox1;
    }
}
