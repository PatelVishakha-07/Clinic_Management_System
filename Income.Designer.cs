namespace Clinic_Management_System
{
    partial class Income
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
            todaysIncomeToolStripMenuItem = new ToolStripMenuItem();
            monthlyIncomeToolStripMenuItem = new ToolStripMenuItem();
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
            leftPanel.Size = new Size(246, 754);
            leftPanel.TabIndex = 0;
            // 
            // topPanel
            // 
            topPanel.Controls.Add(menuStrip1);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(246, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(981, 69);
            topPanel.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(255, 255, 192);
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Font = new Font("Doppio One", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { todaysIncomeToolStripMenuItem, monthlyIncomeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(981, 69);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // todaysIncomeToolStripMenuItem
            // 
            todaysIncomeToolStripMenuItem.Name = "todaysIncomeToolStripMenuItem";
            todaysIncomeToolStripMenuItem.Size = new Size(163, 65);
            todaysIncomeToolStripMenuItem.Text = "OPD's Income";
            todaysIncomeToolStripMenuItem.Click += todaysIncomeToolStripMenuItem_Click;
            // 
            // monthlyIncomeToolStripMenuItem
            // 
            monthlyIncomeToolStripMenuItem.Name = "monthlyIncomeToolStripMenuItem";
            monthlyIncomeToolStripMenuItem.Size = new Size(139, 65);
            monthlyIncomeToolStripMenuItem.Text = "IPD Income";
            monthlyIncomeToolStripMenuItem.Click += monthlyIncomeToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(246, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(981, 685);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // Income
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 754);
            Controls.Add(panel1);
            Controls.Add(topPanel);
            Controls.Add(leftPanel);
            MainMenuStrip = menuStrip1;
            Name = "Income";
            Text = "Income";
            Load += Income_Load;
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
        private ToolStripMenuItem todaysIncomeToolStripMenuItem;
        private ToolStripMenuItem monthlyIncomeToolStripMenuItem;
        private Panel panel1;
    }
}