﻿namespace Clinic_Management_System
{
    partial class Admit_Patient_Details
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
            btn_discharge = new Button();
            btn_add = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(btn_discharge);
            panel1.Controls.Add(btn_add);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 763);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // btn_discharge
            // 
            btn_discharge.Location = new Point(940, 115);
            btn_discharge.Margin = new Padding(2);
            btn_discharge.Name = "btn_discharge";
            btn_discharge.Size = new Size(108, 54);
            btn_discharge.TabIndex = 5;
            btn_discharge.Text = "Discharge";
            btn_discharge.UseVisualStyleBackColor = true;
            btn_discharge.Click += btn_discharge_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(940, 192);
            btn_add.Margin = new Padding(2);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(108, 54);
            btn_add.TabIndex = 2;
            btn_add.Text = "Add Diagnosis";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(514, 28);
            label1.Name = "label1";
            label1.Size = new Size(115, 41);
            label1.TabIndex = 1;
            label1.Text = "Details";
            // 
            // Admit_Patient_Details
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Admit_Patient_Details";
            Size = new Size(1100, 763);
            Load += Admit_Patient_Details_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_add;
        private Label label1;
        private Button btn_discharge;
    }
}
