﻿namespace Clinic_Management_System
{
    partial class UpdateMedicine
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
            lblSell = new Label();
            txtSell = new TextBox();
            label10 = new Label();
            lblPurchase = new Label();
            txtPurchase = new TextBox();
            label8 = new Label();
            comboType = new ComboBox();
            label6 = new Label();
            lblStock = new Label();
            lblName = new Label();
            lblCmp = new Label();
            btnReset = new Button();
            btnCancel = new Button();
            btnUpdate = new Button();
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
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lblSell);
            panel1.Controls.Add(txtSell);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(lblPurchase);
            panel1.Controls.Add(txtPurchase);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(comboType);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblStock);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(lblCmp);
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnUpdate);
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
            panel1.Size = new Size(1100, 852);
            panel1.TabIndex = 1;
            // 
            // lblSell
            // 
            lblSell.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSell.AutoSize = true;
            lblSell.ForeColor = Color.Red;
            lblSell.Location = new Point(620, 712);
            lblSell.Name = "lblSell";
            lblSell.Size = new Size(195, 20);
            lblSell.TabIndex = 31;
            lblSell.Text = "* Sell Price cannot be empty";
            lblSell.Visible = false;
            // 
            // txtSell
            // 
            txtSell.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSell.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtSell.Location = new Point(620, 668);
            txtSell.Name = "txtSell";
            txtSell.Size = new Size(457, 41);
            txtSell.TabIndex = 30;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(356, 678);
            label10.Name = "label10";
            label10.Size = new Size(195, 33);
            label10.TabIndex = 29;
            label10.Text = "Sell Price: ";
            // 
            // lblPurchase
            // 
            lblPurchase.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPurchase.AutoSize = true;
            lblPurchase.ForeColor = Color.Red;
            lblPurchase.Location = new Point(620, 615);
            lblPurchase.Name = "lblPurchase";
            lblPurchase.Size = new Size(229, 20);
            lblPurchase.TabIndex = 28;
            lblPurchase.Text = "* Purchase Price cannot be empty";
            lblPurchase.Visible = false;
            // 
            // txtPurchase
            // 
            txtPurchase.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPurchase.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtPurchase.Location = new Point(620, 571);
            txtPurchase.Name = "txtPurchase";
            txtPurchase.Size = new Size(457, 41);
            txtPurchase.TabIndex = 27;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(356, 581);
            label8.Name = "label8";
            label8.Size = new Size(255, 33);
            label8.TabIndex = 26;
            label8.Text = "Purchase Price: ";
            // 
            // comboType
            // 
            comboType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboType.FlatStyle = FlatStyle.Popup;
            comboType.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            comboType.FormattingEnabled = true;
            comboType.Items.AddRange(new object[] { "Strips", "Injection", "Syrup", "Drops", "Cream", "Bandage", "Oil", "Shampoo", "Card", "Soap", "Dry Syrup", "Lotion", "Gel", "Sachet", "Ointment", "Mask", "Other" });
            comboType.Location = new Point(620, 489);
            comboType.Name = "comboType";
            comboType.Size = new Size(457, 43);
            comboType.TabIndex = 22;
            comboType.Text = "Strips";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(356, 499);
            label6.Name = "label6";
            label6.Size = new Size(240, 33);
            label6.TabIndex = 21;
            label6.Text = "Medicine Type: ";
            // 
            // lblStock
            // 
            lblStock.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblStock.AutoSize = true;
            lblStock.ForeColor = Color.Red;
            lblStock.Location = new Point(620, 360);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(236, 20);
            lblStock.TabIndex = 20;
            lblStock.Text = "* Medicine Stock cannot be empty";
            lblStock.Visible = false;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.ForeColor = Color.Red;
            lblName.Location = new Point(620, 184);
            lblName.Name = "lblName";
            lblName.Size = new Size(240, 20);
            lblName.TabIndex = 19;
            lblName.Text = "* Medicine Name cannot be empty";
            lblName.Visible = false;
            // 
            // lblCmp
            // 
            lblCmp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCmp.AutoSize = true;
            lblCmp.ForeColor = Color.Red;
            lblCmp.Location = new Point(620, 271);
            lblCmp.Name = "lblCmp";
            lblCmp.Size = new Size(244, 20);
            lblCmp.TabIndex = 18;
            lblCmp.Text = "* Company Name Cannot be Empty";
            lblCmp.Visible = false;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Bottom;
            btnReset.BackColor = Color.Coral;
            btnReset.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.ForeColor = Color.DarkBlue;
            btnReset.Location = new Point(445, 762);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(179, 69);
            btnReset.TabIndex = 12;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom;
            btnCancel.BackColor = Color.Coral;
            btnCancel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.DarkBlue;
            btnCancel.Location = new Point(708, 762);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(179, 69);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom;
            btnUpdate.BackColor = Color.Coral;
            btnUpdate.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.DarkBlue;
            btnUpdate.Location = new Point(155, 762);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(179, 69);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(620, 405);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(457, 41);
            dateTimePicker1.TabIndex = 9;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            txtStock.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStock.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtStock.Location = new Point(620, 316);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(457, 41);
            txtStock.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            txtCmp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCmp.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtCmp.Location = new Point(620, 227);
            txtCmp.Name = "txtCmp";
            txtCmp.Size = new Size(457, 41);
            txtCmp.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(620, 140);
            txtName.Name = "txtName";
            txtName.Size = new Size(457, 41);
            txtName.TabIndex = 3;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // pictureBox1
            // 
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
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            label1.Size = new Size(251, 40);
            label1.TabIndex = 0;
            label1.Text = "Update Medicine";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UpdateMedicine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UpdateMedicine";
            Size = new Size(1100, 852);
            Load += UpdateMedicine_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnReset;
        private Button btnCancel;
        private Button btnUpdate;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private TextBox txtStock;
        private Label label5;
        private TextBox txtCmp;
        private Label label3;
        private TextBox txtName;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label lblStock;
        private Label lblName;
        private Label lblCmp;
        private ComboBox comboType;
        private Label label6;
        private Label lblSell;
        private TextBox txtSell;
        private Label label10;
        private Label lblPurchase;
        private TextBox txtPurchase;
        private Label label8;
    }
}
