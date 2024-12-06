namespace Clinic_Management_System
{
    partial class Medicine
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
            MedicinePanel = new Panel();
            TopPanel = new Panel();
            leftPanel = new Panel();
            panel1 = new Panel();
            MedicinePanel.SuspendLayout();
            SuspendLayout();
            // 
            // MedicinePanel
            // 
            MedicinePanel.BackColor = Color.Transparent;
            MedicinePanel.Controls.Add(panel1);
            MedicinePanel.Controls.Add(TopPanel);
            MedicinePanel.Controls.Add(leftPanel);
            MedicinePanel.Dock = DockStyle.Fill;
            MedicinePanel.Location = new Point(0, 0);
            MedicinePanel.Name = "MedicinePanel";
            MedicinePanel.Size = new Size(990, 760);
            MedicinePanel.TabIndex = 0;
            MedicinePanel.Paint += panel1_Paint;
            // 
            // TopPanel
            // 
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(241, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(749, 90);
            TopPanel.TabIndex = 1;
            // 
            // leftPanel
            // 
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(241, 760);
            leftPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(241, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(749, 670);
            panel1.TabIndex = 2;
            // 
            // Medicine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(990, 760);
            Controls.Add(MedicinePanel);
            Name = "Medicine";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Medicine";
            Load += Medicine_Load;
            MedicinePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel MedicinePanel;
        private Panel leftPanel;
        private Panel TopPanel;
        private Panel panel1;
    }
}