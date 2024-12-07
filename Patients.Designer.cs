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
            MainPanel = new Panel();
            PanelTop = new Panel();
            menuStrip1 = new MenuStrip();
            showPatientsToolStripMenuItem = new ToolStripMenuItem();
            addPatientsToolStripMenuItem = new ToolStripMenuItem();
            neewPatientsToolStripMenuItem = new ToolStripMenuItem();
            oldPatientsToolStripMenuItem = new ToolStripMenuItem();
            PanelLeft = new Panel();
            PatientsPanel.SuspendLayout();
            PanelTop.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // PatientsPanel
            // 
            PatientsPanel.Controls.Add(MainPanel);
            PatientsPanel.Controls.Add(PanelTop);
            PatientsPanel.Controls.Add(PanelLeft);
            PatientsPanel.Dock = DockStyle.Fill;
            PatientsPanel.Location = new Point(0, 0);
            PatientsPanel.Name = "PatientsPanel";
            PatientsPanel.Size = new Size(1082, 716);
            PatientsPanel.TabIndex = 0;
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(247, 62);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(835, 654);
            MainPanel.TabIndex = 2;
            // 
            // PanelTop
            // 
            PanelTop.Controls.Add(menuStrip1);
            PanelTop.Dock = DockStyle.Top;
            PanelTop.Location = new Point(247, 0);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(835, 62);
            PanelTop.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Gainsboro;
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { showPatientsToolStripMenuItem, addPatientsToolStripMenuItem, neewPatientsToolStripMenuItem, oldPatientsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(835, 62);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // showPatientsToolStripMenuItem
            // 
            showPatientsToolStripMenuItem.ForeColor = Color.Black;
            showPatientsToolStripMenuItem.Name = "showPatientsToolStripMenuItem";
            showPatientsToolStripMenuItem.Size = new Size(182, 58);
            showPatientsToolStripMenuItem.Text = "Show Patients";
            showPatientsToolStripMenuItem.Click += showPatientsToolStripMenuItem_Click;
            // 
            // addPatientsToolStripMenuItem
            // 
            addPatientsToolStripMenuItem.ForeColor = Color.Black;
            addPatientsToolStripMenuItem.Name = "addPatientsToolStripMenuItem";
            addPatientsToolStripMenuItem.Size = new Size(170, 58);
            addPatientsToolStripMenuItem.Text = "Add Patients";
            addPatientsToolStripMenuItem.Click += addPatientsToolStripMenuItem_Click;
            // 
            // neewPatientsToolStripMenuItem
            // 
            neewPatientsToolStripMenuItem.Name = "neewPatientsToolStripMenuItem";
            neewPatientsToolStripMenuItem.Size = new Size(170, 58);
            neewPatientsToolStripMenuItem.Text = "New Patients";
            neewPatientsToolStripMenuItem.Click += neewPatientsToolStripMenuItem_Click;
            // 
            // oldPatientsToolStripMenuItem
            // 
            oldPatientsToolStripMenuItem.Name = "oldPatientsToolStripMenuItem";
            oldPatientsToolStripMenuItem.Size = new Size(170, 58);
            oldPatientsToolStripMenuItem.Text = "Old Patients";
            oldPatientsToolStripMenuItem.Click += oldPatientsToolStripMenuItem_Click;
            // 
            // PanelLeft
            // 
            PanelLeft.Dock = DockStyle.Left;
            PanelLeft.Location = new Point(0, 0);
            PanelLeft.Name = "PanelLeft";
            PanelLeft.Size = new Size(247, 716);
            PanelLeft.TabIndex = 0;
            // 
            // Patients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1082, 716);
            Controls.Add(PatientsPanel);
            Name = "Patients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patients";
            Load += Patients_Load;
            PatientsPanel.ResumeLayout(false);
            PanelTop.ResumeLayout(false);
            PanelTop.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PatientsPanel;
        private Panel PanelTop;
        private Panel PanelLeft;
        private Panel MainPanel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem showPatientsToolStripMenuItem;
        private ToolStripMenuItem addPatientsToolStripMenuItem;
        private ToolStripMenuItem neewPatientsToolStripMenuItem;
        private ToolStripMenuItem oldPatientsToolStripMenuItem;
    }
}