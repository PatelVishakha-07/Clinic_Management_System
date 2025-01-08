namespace Clinic_Management_System
{
    partial class Certificate
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
            leftPanel = new Panel();
            topPanel = new Panel();
            menuStrip1 = new MenuStrip();
            createCertificateToolStripMenuItem = new ToolStripMenuItem();
            showToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            topPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(254, 778);
            leftPanel.TabIndex = 1;
            // 
            // topPanel
            // 
            topPanel.Controls.Add(menuStrip1);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(254, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(823, 61);
            topPanel.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(255, 255, 192);
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { createCertificateToolStripMenuItem, showToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(823, 61);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // createCertificateToolStripMenuItem
            // 
            createCertificateToolStripMenuItem.Name = "createCertificateToolStripMenuItem";
            createCertificateToolStripMenuItem.Size = new Size(193, 57);
            createCertificateToolStripMenuItem.Text = "Create Certificate";
            createCertificateToolStripMenuItem.Click += createCertificateToolStripMenuItem_Click;
            // 
            // showToolStripMenuItem
            // 
            showToolStripMenuItem.Name = "showToolStripMenuItem";
            showToolStripMenuItem.Size = new Size(84, 57);
            showToolStripMenuItem.Text = "Show ";
            showToolStripMenuItem.Click += showToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(254, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(823, 717);
            panel1.TabIndex = 4;
            // 
            // Certificate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1077, 778);
            Controls.Add(panel1);
            Controls.Add(topPanel);
            Controls.Add(leftPanel);
            MainMenuStrip = menuStrip1;
            Name = "Certificate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Certificate";
            Load += Certificate_Load;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel leftPanel;
        private Panel topPanel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem createCertificateToolStripMenuItem;
        private ToolStripMenuItem showToolStripMenuItem;
        private Panel panel1;
    }
}