﻿namespace Clinic_Management_System
{
    partial class MenuMedicine
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
            menuStrip1 = new MenuStrip();
            showMedicinesToolStripMenuItem = new ToolStripMenuItem();
            addMedicineToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 59);
            panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(255, 255, 192);
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.GripMargin = new Padding(2);
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { showMedicinesToolStripMenuItem, addMedicineToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 59);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // showMedicinesToolStripMenuItem
            // 
            showMedicinesToolStripMenuItem.Checked = true;
            showMedicinesToolStripMenuItem.CheckState = CheckState.Checked;
            showMedicinesToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            showMedicinesToolStripMenuItem.Image = Properties.Resources.medicine__1_;
            showMedicinesToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            showMedicinesToolStripMenuItem.Name = "showMedicinesToolStripMenuItem";
            showMedicinesToolStripMenuItem.Size = new Size(205, 55);
            showMedicinesToolStripMenuItem.Text = " Show Medicines";
            showMedicinesToolStripMenuItem.ToolTipText = "Click here to See Medicine Details";
            // 
            // addMedicineToolStripMenuItem
            // 
            addMedicineToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addMedicineToolStripMenuItem.Image = Properties.Resources.medicinePageBg;
            addMedicineToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            addMedicineToolStripMenuItem.Name = "addMedicineToolStripMenuItem";
            addMedicineToolStripMenuItem.Size = new Size(183, 55);
            addMedicineToolStripMenuItem.Text = " Add Medicine";
            addMedicineToolStripMenuItem.ToolTipText = "Click here to add Medicine";
            // 
            // MenuMedicine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "MenuMedicine";
            Text = "MenuMedicine";
            Load += MenuMedicine_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem showMedicinesToolStripMenuItem;
        private ToolStripMenuItem addMedicineToolStripMenuItem;
    }
}