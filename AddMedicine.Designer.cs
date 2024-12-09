namespace Clinic_Management_System
{
    partial class AddMedicine
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
            lblStock = new Label();
            lblName = new Label();
            lblCmp = new Label();
            btnClear = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            txtStock = new TextBox();
            label5 = new Label();
            txtCmp = new TextBox();
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
            panel1.BackColor = SystemColors.ControlDark;
            panel1.BackgroundImage = Properties.Resources.med1;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lblStock);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(lblCmp);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtStock);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtCmp);
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
            panel1.Paint += panel1_Paint;
            // 
            // lblStock
            // 
            lblStock.Anchor = AnchorStyles.Top;
            lblStock.AutoSize = true;
            lblStock.ForeColor = Color.Red;
            lblStock.Location = new Point(620, 360);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(236, 20);
            lblStock.TabIndex = 17;
            lblStock.Text = "* Medicine Stock cannot be empty";
            lblStock.Visible = false;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top;
            lblName.AutoSize = true;
            lblName.ForeColor = Color.Red;
            lblName.Location = new Point(620, 184);
            lblName.Name = "lblName";
            lblName.Size = new Size(240, 20);
            lblName.TabIndex = 16;
            lblName.Text = "* Medicine Name cannot be empty";
            lblName.Visible = false;
            // 
            // lblCmp
            // 
            lblCmp.Anchor = AnchorStyles.Top;
            lblCmp.AutoSize = true;
            lblCmp.ForeColor = Color.Red;
            lblCmp.Location = new Point(620, 271);
            lblCmp.Name = "lblCmp";
            lblCmp.Size = new Size(244, 20);
            lblCmp.TabIndex = 15;
            lblCmp.Text = "* Company Name Cannot be Empty";
            lblCmp.Visible = false;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom;
            btnClear.BackColor = Color.Coral;
            btnClear.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.DarkBlue;
            btnClear.Location = new Point(550, 535);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(179, 69);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom;
            btnCancel.BackColor = Color.Coral;
            btnCancel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.DarkBlue;
            btnCancel.Location = new Point(813, 535);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(179, 69);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.BackColor = Color.Coral;
            btnSave.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.DarkBlue;
            btnSave.Location = new Point(260, 535);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(179, 69);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top;
            dateTimePicker1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(620, 405);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(457, 41);
            dateTimePicker1.TabIndex = 9;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(356, 413);
            label4.Name = "label4";
            label4.Size = new Size(210, 33);
            label4.TabIndex = 8;
            label4.Text = "Expiry Date: ";
            // 
            // txtStock
            // 
            txtStock.Anchor = AnchorStyles.Top;
            txtStock.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtStock.Location = new Point(620, 316);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(457, 41);
            txtStock.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(356, 326);
            label5.Name = "label5";
            label5.Size = new Size(255, 33);
            label5.TabIndex = 6;
            label5.Text = "Medicine Stock: ";
            // 
            // txtCmp
            // 
            txtCmp.Anchor = AnchorStyles.Top;
            txtCmp.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtCmp.Location = new Point(620, 227);
            txtCmp.Name = "txtCmp";
            txtCmp.Size = new Size(457, 41);
            txtCmp.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(356, 237);
            label3.Name = "label3";
            label3.Size = new Size(225, 33);
            label3.TabIndex = 4;
            label3.Text = "Company Name: ";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top;
            txtName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(620, 140);
            txtName.Name = "txtName";
            txtName.Size = new Size(457, 41);
            txtName.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.Image = Properties.Resources.medicine__1_;
            pictureBox1.Location = new Point(18, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 296);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(356, 150);
            label2.Name = "label2";
            label2.Size = new Size(240, 33);
            label2.TabIndex = 1;
            label2.Text = "Medicine Name: ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(430, 17);
            label1.Name = "label1";
            label1.Size = new Size(207, 40);
            label1.TabIndex = 0;
            label1.Text = "Add Medicine";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddMedicine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AddMedicine";
            Size = new Size(1100, 763);
            Load += AddMedicine_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private TextBox txtStock;
        private Label label5;
        private TextBox txtCmp;
        private Label label3;
        private TextBox txtName;
        private PictureBox pictureBox1;
        private Label label2;
        private Button btnClear;
        private Button btnCancel;
        private Button btnSave;
        private Label lblCmp;
        private Label lblName;
        private Label lblStock;
    }
}
