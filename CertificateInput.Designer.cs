namespace Clinic_Management_System
{
    partial class CertificateInput
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
            dtpResume = new DateTimePicker();
            label6 = new Label();
            lblDiseaseError = new Label();
            lblNameError = new Label();
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
            panel1.Controls.Add(dtpResume);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblDiseaseError);
            panel1.Controls.Add(lblNameError);
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
            // dtpResume
            // 
            dtpResume.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpResume.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpResume.Location = new Point(261, 466);
            dtpResume.Name = "dtpResume";
            dtpResume.Size = new Size(469, 38);
            dtpResume.TabIndex = 51;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(70, 473);
            label6.Name = "label6";
            label6.Size = new Size(165, 31);
            label6.TabIndex = 50;
            label6.Text = "Resume Date :";
            // 
            // lblDiseaseError
            // 
            lblDiseaseError.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDiseaseError.AutoSize = true;
            lblDiseaseError.ForeColor = Color.Red;
            lblDiseaseError.Location = new Point(261, 266);
            lblDiseaseError.Name = "lblDiseaseError";
            lblDiseaseError.Size = new Size(144, 20);
            lblDiseaseError.TabIndex = 49;
            lblDiseaseError.Text = "Please Enter Disease";
            lblDiseaseError.Visible = false;
            // 
            // lblNameError
            // 
            lblNameError.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNameError.AutoSize = true;
            lblNameError.ForeColor = Color.Red;
            lblNameError.Location = new Point(261, 180);
            lblNameError.Name = "lblNameError";
            lblNameError.Size = new Size(133, 20);
            lblNameError.TabIndex = 48;
            lblNameError.Text = "Please Enter Name";
            lblNameError.Visible = false;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom;
            btnClear.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(414, 595);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(146, 62);
            btnClear.TabIndex = 47;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDone
            // 
            btnDone.Anchor = AnchorStyles.Bottom;
            btnDone.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDone.Location = new Point(140, 595);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(146, 62);
            btnDone.TabIndex = 46;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = true;
            btnDone.Click += btnDone_Click;
            // 
            // dtpToDate
            // 
            dtpToDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpToDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpToDate.Location = new Point(259, 398);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(469, 38);
            dtpToDate.TabIndex = 45;
            // 
            // dtpFromDate
            // 
            dtpFromDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpFromDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFromDate.Location = new Point(259, 317);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(469, 38);
            dtpFromDate.TabIndex = 44;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(127, 42);
            label5.Name = "label5";
            label5.Size = new Size(589, 38);
            label5.TabIndex = 43;
            label5.Text = "Enter Details to Generate Fitness Certificate";
            // 
            // txtDisease
            // 
            txtDisease.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDisease.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtDisease.Location = new Point(259, 225);
            txtDisease.Name = "txtDisease";
            txtDisease.Size = new Size(469, 38);
            txtDisease.TabIndex = 42;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(259, 139);
            txtName.Name = "txtName";
            txtName.Size = new Size(469, 38);
            txtName.TabIndex = 41;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(70, 401);
            label4.Name = "label4";
            label4.Size = new Size(107, 31);
            label4.TabIndex = 40;
            label4.Text = "To Date :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(70, 324);
            label3.Name = "label3";
            label3.Size = new Size(144, 31);
            label3.TabIndex = 39;
            label3.Text = "From Date : ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(70, 232);
            label2.Name = "label2";
            label2.Size = new Size(106, 31);
            label2.TabIndex = 38;
            label2.Text = "Disease :";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(70, 146);
            label1.Name = "label1";
            label1.Size = new Size(95, 31);
            label1.TabIndex = 37;
            label1.Text = "Name : ";
            // 
            // CertificateInput
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "CertificateInput";
            Size = new Size(801, 743);
            Load += CertificateInput_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblDiseaseError;
        private Label lblNameError;
        private Button btnClear;
        private Button btnDone;
        private DateTimePicker dtpToDate;
        private DateTimePicker dtpFromDate;
        private Label label5;
        private TextBox txtDisease;
        private TextBox txtName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpResume;
        private Label label6;
    }
}
