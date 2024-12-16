namespace Clinic_Management_System
{
    partial class AdmittedPatients
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
            panel1 = new Panel();
            panel2 = new Panel();
            topPanel = new Panel();
            menuStrip1 = new MenuStrip();
            showAdmittedToolStripMenuItem = new ToolStripMenuItem();
            admitPatientsToolStripMenuItem = new ToolStripMenuItem();
            leftPanel = new Panel();
            panel1.SuspendLayout();
            topPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(topPanel);
            panel1.Controls.Add(leftPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1301, 745);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(225, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(1076, 674);
            panel2.TabIndex = 7;
            // 
            // topPanel
            // 
            topPanel.Controls.Add(menuStrip1);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(225, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1076, 71);
            topPanel.TabIndex = 6;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(255, 255, 192);
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Font = new Font("Cinzel Black", 13.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { showAdmittedToolStripMenuItem, admitPatientsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1076, 71);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // showAdmittedToolStripMenuItem
            // 
            showAdmittedToolStripMenuItem.Name = "showAdmittedToolStripMenuItem";
            showAdmittedToolStripMenuItem.Size = new Size(322, 67);
            showAdmittedToolStripMenuItem.Text = "Show Admitted Patients";
            showAdmittedToolStripMenuItem.Click += showAdmittedToolStripMenuItem_Click;
            // 
            // admitPatientsToolStripMenuItem
            // 
            admitPatientsToolStripMenuItem.Name = "admitPatientsToolStripMenuItem";
            admitPatientsToolStripMenuItem.Size = new Size(208, 67);
            admitPatientsToolStripMenuItem.Text = "Admit Patients";
            admitPatientsToolStripMenuItem.Click += admitPatientsToolStripMenuItem_Click;
            // 
            // leftPanel
            // 
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(225, 745);
            leftPanel.TabIndex = 5;
            // 
            // AdmittedPatients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1301, 745);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "AdmittedPatients";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Admitted Patients";
            Load += AdmittedPatients_Load;
            panel1.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel leftPanel;
        private Panel topPanel;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem showAdmittedToolStripMenuItem;
        private ToolStripMenuItem admitPatientsToolStripMenuItem;
    }
}