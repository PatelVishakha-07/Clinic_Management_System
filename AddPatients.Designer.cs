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
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 763);
            panel1.TabIndex = 0;
            // 
            // lblall
            // 
            lblall.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblall.AutoSize = true;
            lblall.ForeColor = Color.Red;
            lblall.Location = new Point(614, 101);
            lblall.Margin = new Padding(2, 0, 2, 0);
            lblall.Name = "lblall";
            lblall.Size = new Size(193, 20);
            lblall.TabIndex = 35;
            lblall.Text = "*One or more field is empty";
            lblall.Visible = false;
            // 
            // lblage
            // 
            lblage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblage.AutoSize = true;
            lblage.ForeColor = Color.Red;
            lblage.Location = new Point(614, 266);
            lblage.Margin = new Padding(2, 0, 2, 0);
            lblage.Name = "lblage";
            lblage.Size = new Size(178, 20);
            lblage.TabIndex = 34;
            lblage.Text = "* Please Enter Proper Age";
            lblage.Visible = false;
            // 
            // lbladd
            // 
            lbladd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbladd.AutoSize = true;
            lbladd.ForeColor = Color.Red;
            lbladd.Location = new Point(614, 444);
            lbladd.Margin = new Padding(2, 0, 2, 0);
            lbladd.Name = "lbladd";
            lbladd.Size = new Size(219, 20);
            lbladd.TabIndex = 33;
            lbladd.Text = "* Please Enter Address Correctly";
            lbladd.Visible = false;
            // 
            // lblph_no
            // 
            lblph_no.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblph_no.AutoSize = true;
            lblph_no.ForeColor = Color.Red;
            lblph_no.Location = new Point(614, 532);
            lblph_no.Margin = new Padding(2, 0, 2, 0);
            lblph_no.Name = "lblph_no";
            lblph_no.Size = new Size(205, 20);
            lblph_no.TabIndex = 32;
            lblph_no.Text = "* Please Enter Proper Number";
            lblph_no.Visible = false;
            // 
            // lblname
            // 
            lblname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblname.AutoSize = true;
            lblname.ForeColor = Color.Red;
            lblname.Location = new Point(614, 177);
            lblname.Margin = new Padding(2, 0, 2, 0);
            lblname.Name = "lblname";
            lblname.Size = new Size(191, 20);
            lblname.TabIndex = 31;
            lblname.Text = "* Please Enter Proper Name";
            lblname.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(614, 266);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 30;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "Male", "Female" });
            comboBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(614, 314);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(457, 43);
            comboBox1.TabIndex = 29;
            // 
            // txtaddress
            // 
            txtaddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtaddress.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtaddress.Location = new Point(614, 403);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(457, 41);
            txtaddress.TabIndex = 28;
            // 
            // txtContact
            // 
            txtContact.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtContact.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtContact.Location = new Point(614, 491);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(457, 41);
            txtContact.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(350, 499);
            label6.Name = "label6";
            label6.Size = new Size(225, 33);
            label6.TabIndex = 26;
            label6.Text = "Phone Number: ";
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom;
            btnClear.BackColor = Color.LightSteelBlue;
            btnClear.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(613, 603);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(179, 69);
            btnClear.TabIndex = 25;
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
            btnSave.Location = new Point(350, 603);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(179, 69);
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
            label4.Location = new Point(350, 409);
            label4.Name = "label4";
            label4.Size = new Size(135, 33);
            label4.TabIndex = 21;
            label4.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(350, 321);
            label5.Name = "label5";
            label5.Size = new Size(135, 33);
            label5.TabIndex = 19;
            label5.Text = "Gender: ";
            // 
            // txtAge
            // 
            txtAge.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAge.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtAge.Location = new Point(614, 225);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(457, 41);
            txtAge.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(350, 230);
            label3.Name = "label3";
            label3.Size = new Size(90, 33);
            label3.TabIndex = 17;
            label3.Text = "Age: ";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(614, 138);
            txtName.Name = "txtName";
            txtName.Size = new Size(457, 41);
            txtName.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Image = Properties.Resources.patient;
            pictureBox1.Location = new Point(24, 177);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 296);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(350, 143);
            label2.Name = "label2";
            label2.Size = new Size(225, 33);
            label2.TabIndex = 14;
            label2.Text = "Patient Name: ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(471, 38);
            label1.Name = "label1";
            label1.Size = new Size(191, 40);
            label1.TabIndex = 13;
            label1.Text = "Add Patients";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddPatients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(panel1);
            Name = "AddPatients";
            Size = new Size(1100, 763);
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
    }
}
