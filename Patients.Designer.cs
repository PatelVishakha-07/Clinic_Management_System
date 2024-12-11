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
            PatientsPanel.Margin = new Padding(4);
            PatientsPanel.Name = "PatientsPanel";
            PatientsPanel.Size = new Size(1678, 1050);
            PatientsPanel.TabIndex = 0;
            // 
            // MainPanel
            // 
            MainPanel.AutoScroll = true;
            MainPanel.AutoScrollMargin = new Size(3, 4);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(309, 78);
            MainPanel.Margin = new Padding(4);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1369, 972);
            MainPanel.TabIndex = 2;
            MainPanel.Paint += MainPanel_Paint;
            // 
            // PanelTop
            // 
            PanelTop.Controls.Add(menuStrip1);
            PanelTop.Dock = DockStyle.Top;
            PanelTop.Location = new Point(309, 0);
            PanelTop.Margin = new Padding(4);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(1369, 78);
            PanelTop.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Gainsboro;
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { showPatientsToolStripMenuItem, addPatientsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 2, 0, 2);
            menuStrip1.Size = new Size(1369, 78);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // showPatientsToolStripMenuItem
            // 
            showPatientsToolStripMenuItem.ForeColor = Color.Black;
            showPatientsToolStripMenuItem.Name = "showPatientsToolStripMenuItem";
            showPatientsToolStripMenuItem.Size = new Size(212, 74);
            showPatientsToolStripMenuItem.Text = "Show Patients";
            showPatientsToolStripMenuItem.Click += showPatientsToolStripMenuItem_Click;
            // 
            // addPatientsToolStripMenuItem
            // 
            addPatientsToolStripMenuItem.ForeColor = Color.Black;
            addPatientsToolStripMenuItem.Name = "addPatientsToolStripMenuItem";
            addPatientsToolStripMenuItem.Size = new Size(198, 74);
            addPatientsToolStripMenuItem.Text = "Add Patients";
            addPatientsToolStripMenuItem.Click += addPatientsToolStripMenuItem_Click;
            // 
            // PanelLeft
            // 
            PanelLeft.Dock = DockStyle.Left;
            PanelLeft.Location = new Point(0, 0);
            PanelLeft.Margin = new Padding(4);
            PanelLeft.Name = "PanelLeft";
            PanelLeft.Size = new Size(309, 1050);
            PanelLeft.TabIndex = 0;
            // 
            // Patients
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.LightGray;
            ClientSize = new Size(1678, 1050);
            Controls.Add(PatientsPanel);
            Margin = new Padding(4);
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
    }
}