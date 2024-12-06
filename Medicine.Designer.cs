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
            PanelMedicine = new Panel();
            TopPanel = new Panel();
            leftPanel = new Panel();
            PanelMedicine.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMedicine
            // 
            PanelMedicine.BackColor = Color.Transparent;
            PanelMedicine.Controls.Add(TopPanel);
            PanelMedicine.Controls.Add(leftPanel);
            PanelMedicine.Dock = DockStyle.Fill;
            PanelMedicine.Location = new Point(0, 0);
            PanelMedicine.Name = "PanelMedicine";
            PanelMedicine.Size = new Size(990, 760);
            PanelMedicine.TabIndex = 0;
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
            // Medicine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.med1;
            ClientSize = new Size(990, 760);
            Controls.Add(PanelMedicine);
            Name = "Medicine";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Medicine";
            Load += Medicine_Load;
            PanelMedicine.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMedicine;
        private Panel leftPanel;
        private Panel TopPanel;
    }
}