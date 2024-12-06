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
            PatientsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // PatientsPanel
            // 
            PatientsPanel.Controls.Add(PanelTop);
            PatientsPanel.Controls.Add(PanelLeft);
            PatientsPanel.Dock = DockStyle.Fill;
            PatientsPanel.Location = new Point(0, 0);
            PatientsPanel.Margin = new Padding(4);
            PatientsPanel.Name = "PatientsPanel";
            PatientsPanel.Size = new Size(1238, 950);
            PatientsPanel.TabIndex = 0;
            // 
            // PanelTop
            // 
            PanelTop.Dock = DockStyle.Top;
            PanelTop.Location = new Point(309, 0);
            PanelTop.Margin = new Padding(4);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(929, 78);
            PanelTop.TabIndex = 1;
            // 
            // PanelLeft
            // 
            PanelLeft.Dock = DockStyle.Left;
            PanelLeft.Location = new Point(0, 0);
            PanelLeft.Margin = new Padding(4);
            PanelLeft.Name = "PanelLeft";
            PanelLeft.Size = new Size(309, 950);
            PanelLeft.TabIndex = 0;
            // 
            // Patients
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1238, 950);
            Controls.Add(PatientsPanel);
            Margin = new Padding(4);
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
    }
}