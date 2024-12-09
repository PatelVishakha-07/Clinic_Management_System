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
            panel3 = new Panel();
            MainPanel = new Panel();
            topPanel = new Panel();
            menuStrip1 = new MenuStrip();
            showMedicinesToolStripMenuItem = new ToolStripMenuItem();
            addMedicineToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            leftPanel = new Panel();
            MedicinePanel.SuspendLayout();
            panel3.SuspendLayout();
            topPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // MedicinePanel
            // 
            MedicinePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MedicinePanel.BackColor = Color.Transparent;
            MedicinePanel.Controls.Add(panel3);
            MedicinePanel.Controls.Add(topPanel);
            MedicinePanel.Controls.Add(leftPanel);
            MedicinePanel.Dock = DockStyle.Fill;
            MedicinePanel.Location = new Point(0, 0);
            MedicinePanel.Name = "MedicinePanel";
            MedicinePanel.Size = new Size(1327, 873);
            MedicinePanel.TabIndex = 0;
            MedicinePanel.Paint += panel1_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(MainPanel);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(241, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(1086, 817);
            panel3.TabIndex = 4;
            // 
            // MainPanel
            // 
            MainPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1086, 817);
            MainPanel.TabIndex = 3;
            MainPanel.Paint += MainPanel_Paint;
            // 
            // topPanel
            // 
            topPanel.Controls.Add(menuStrip1);
            topPanel.Controls.Add(panel1);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(241, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1086, 56);
            topPanel.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Gainsboro;
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { showMedicinesToolStripMenuItem, addMedicineToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1086, 56);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // showMedicinesToolStripMenuItem
            // 
            showMedicinesToolStripMenuItem.ForeColor = Color.Black;
            showMedicinesToolStripMenuItem.Name = "showMedicinesToolStripMenuItem";
            showMedicinesToolStripMenuItem.Size = new Size(194, 52);
            showMedicinesToolStripMenuItem.Text = "Show Medicines";
            showMedicinesToolStripMenuItem.Click += showMedicinesToolStripMenuItem_Click;
            // 
            // addMedicineToolStripMenuItem
            // 
            addMedicineToolStripMenuItem.ForeColor = Color.Black;
            addMedicineToolStripMenuItem.Name = "addMedicineToolStripMenuItem";
            addMedicineToolStripMenuItem.Size = new Size(170, 52);
            addMedicineToolStripMenuItem.Text = "Add Medicine";
            addMedicineToolStripMenuItem.Click += addMedicineToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(6, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 630);
            panel1.TabIndex = 2;
            // 
            // leftPanel
            // 
            leftPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(241, 873);
            leftPanel.TabIndex = 0;
            // 
            // Medicine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.LightGray;
            ClientSize = new Size(1327, 873);
            Controls.Add(MedicinePanel);
            Name = "Medicine";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Medicine";
            Load += Medicine_Load;
            MedicinePanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MedicinePanel;
        private Panel leftPanel;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem showMedicinesToolStripMenuItem;
        private ToolStripMenuItem addMedicineToolStripMenuItem;
        private Panel topPanel;
        private Panel panel3;
        private Panel MainPanel;
    }
}