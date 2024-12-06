namespace Clinic_Management_System
{
    partial class Patients
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
            PatientsPanel = new Panel();
            PanelTop = new Panel();
            PanelLeft = new Panel();
            panel1 = new Panel();
            PatientsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // PatientsPanel
            // 
            PatientsPanel.Controls.Add(panel1);
            PatientsPanel.Controls.Add(PanelTop);
            PatientsPanel.Controls.Add(PanelLeft);
            PatientsPanel.Dock = DockStyle.Fill;
            PatientsPanel.Location = new Point(0, 0);
            PatientsPanel.Name = "PatientsPanel";
            PatientsPanel.Size = new Size(990, 760);
            PatientsPanel.TabIndex = 0;
            // 
            // PanelTop
            // 
            PanelTop.Dock = DockStyle.Top;
            PanelTop.Location = new Point(247, 0);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(743, 62);
            PanelTop.TabIndex = 1;
            // 
            // PanelLeft
            // 
            PanelLeft.Dock = DockStyle.Left;
            PanelLeft.Location = new Point(0, 0);
            PanelLeft.Name = "PanelLeft";
            PanelLeft.Size = new Size(247, 760);
            PanelLeft.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(247, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 698);
            panel1.TabIndex = 2;
            // 
            // Patients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(990, 760);
            Controls.Add(PatientsPanel);
            Name = "Patients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patients";
            Load += Patients_Load;
            PatientsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PatientsPanel;
        private Panel PanelTop;
        private Panel PanelLeft;
        private Panel panel1;
    }
}