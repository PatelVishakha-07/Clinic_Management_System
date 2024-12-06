namespace Clinic_Management_System
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            addMedicineToolStripMenuItem = new ToolStripMenuItem();
            showMedicinesToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(807, 67);
            panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(255, 255, 192);
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { showMedicinesToolStripMenuItem, addMedicineToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(807, 67);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // addMedicineToolStripMenuItem
            // 
            addMedicineToolStripMenuItem.Checked = true;
            addMedicineToolStripMenuItem.CheckOnClick = true;
            addMedicineToolStripMenuItem.CheckState = CheckState.Checked;
            addMedicineToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 192);
            addMedicineToolStripMenuItem.Name = "addMedicineToolStripMenuItem";
            addMedicineToolStripMenuItem.Size = new Size(170, 63);
            addMedicineToolStripMenuItem.Text = "Add Medicine";
            // 
            // showMedicinesToolStripMenuItem
            // 
            showMedicinesToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 192);
            showMedicinesToolStripMenuItem.Name = "showMedicinesToolStripMenuItem";
            showMedicinesToolStripMenuItem.Size = new Size(194, 63);
            showMedicinesToolStripMenuItem.Text = "Show Medicines";
            // 
            // MenuMedicine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "MenuMedicine";
            Size = new Size(807, 67);
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
        private ToolStripMenuItem addMedicineToolStripMenuItem;
        private ToolStripMenuItem showMedicinesToolStripMenuItem;
    }
}
