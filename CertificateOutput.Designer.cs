namespace Clinic_Management_System
{
    partial class CertificateOutput
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            lblNo = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(149, 143);
            label3.Name = "label3";
            label3.Size = new Size(309, 31);
            label3.TabIndex = 6;
            label3.Text = "Medical Fitness Certificate";
            // 
            // lblNo
            // 
            lblNo.AutoSize = true;
            lblNo.Location = new Point(41, 65);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(104, 20);
            lblNo.TabIndex = 5;
            lblNo.Text = "Certificate No.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(41, 246);
            label1.Name = "label1";
            label1.Size = new Size(182, 31);
            label1.TabIndex = 4;
            label1.Text = "This is to Certify ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // CertificateOutput
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 696);
            Controls.Add(label3);
            Controls.Add(lblNo);
            Controls.Add(label1);
            Name = "CertificateOutput";
            Text = "CertificateOutput";
            Load += CertificateOutput_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label lblNo;
        private Label label1;
    }
}