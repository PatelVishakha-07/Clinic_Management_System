namespace Clinic_Management_System
{
    partial class PatientDetails
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
            btnprint = new Button();
            button1 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(btnprint);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 763);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // btnprint
            // 
            btnprint.Location = new Point(940, 198);
            btnprint.Margin = new Padding(2);
            btnprint.Name = "btnprint";
            btnprint.Size = new Size(108, 54);
            btnprint.TabIndex = 3;
            btnprint.Text = "Print";
            btnprint.UseVisualStyleBackColor = true;
            btnprint.Click += btnprint_Click;
            // 
            // button1
            // 
            button1.Location = new Point(940, 102);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(108, 54);
            button1.TabIndex = 2;
            button1.Text = "Add Prescription";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(488, 28);
            label1.Name = "label1";
            label1.Size = new Size(115, 41);
            label1.TabIndex = 1;
            label1.Text = "Details";
            // 
            // PatientDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(panel1);
            Name = "PatientDetails";
            Size = new Size(1100, 763);
            Load += PatientDetails_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Button btnprint;
    }
}
