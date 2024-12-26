namespace Clinic_Management_System
{
    partial class OutputCertificate
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
            label1 = new Label();
            lblNo = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblNo);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 743);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(85, 242);
            label1.Name = "label1";
            label1.Size = new Size(182, 31);
            label1.TabIndex = 1;
            label1.Text = "This is to Certify ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNo
            // 
            lblNo.AutoSize = true;
            lblNo.Location = new Point(85, 61);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(104, 20);
            lblNo.TabIndex = 2;
            lblNo.Text = "Certificate No.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(193, 139);
            label3.Name = "label3";
            label3.Size = new Size(309, 31);
            label3.TabIndex = 3;
            label3.Text = "Medical Fitness Certificate";
            // 
            // OutputCertificate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "OutputCertificate";
            Size = new Size(801, 743);
            Load += OutputCertificate_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label lblNo;
    }
}
