namespace Clinic_Management_System
{
    partial class InputCertificate
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
            btnDone = new Button();
            dtpToDate = new DateTimePicker();
            dtpFromDate = new DateTimePicker();
            label5 = new Label();
            txtDisease = new TextBox();
            txtName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnDone);
            panel1.Controls.Add(dtpToDate);
            panel1.Controls.Add(dtpFromDate);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtDisease);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 743);
            panel1.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(399, 539);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(146, 62);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDone
            // 
            btnDone.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDone.Location = new Point(125, 539);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(146, 62);
            btnDone.TabIndex = 9;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = true;
            btnDone.Click += btnDone_Click;
            // 
            // dtpToDate
            // 
            dtpToDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpToDate.Location = new Point(245, 415);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(469, 38);
            dtpToDate.TabIndex = 8;
            // 
            // dtpFromDate
            // 
            dtpFromDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFromDate.Location = new Point(245, 334);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(469, 38);
            dtpFromDate.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(125, 26);
            label5.Name = "label5";
            label5.Size = new Size(589, 38);
            label5.TabIndex = 6;
            label5.Text = "Enter Details to Generate Fitness Certificate";
            // 
            // txtDisease
            // 
            txtDisease.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtDisease.Location = new Point(245, 242);
            txtDisease.Name = "txtDisease";
            txtDisease.Size = new Size(469, 38);
            txtDisease.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(245, 156);
            txtName.Name = "txtName";
            txtName.Size = new Size(469, 38);
            txtName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(56, 418);
            label4.Name = "label4";
            label4.Size = new Size(107, 31);
            label4.TabIndex = 3;
            label4.Text = "To Date :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(56, 341);
            label3.Name = "label3";
            label3.Size = new Size(144, 31);
            label3.TabIndex = 2;
            label3.Text = "From Date : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(56, 249);
            label2.Name = "label2";
            label2.Size = new Size(106, 31);
            label2.TabIndex = 1;
            label2.Text = "Disease :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(56, 163);
            label1.Name = "label1";
            label1.Size = new Size(95, 31);
            label1.TabIndex = 0;
            label1.Text = "Name : ";
            // 
            // InputCertificate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "InputCertificate";
            Size = new Size(801, 743);
            Load += InputCertificate_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private TextBox txtDisease;
        private TextBox txtName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnClear;
        private Button btnDone;
        private DateTimePicker dtpToDate;
        private DateTimePicker dtpFromDate;
    }
}
