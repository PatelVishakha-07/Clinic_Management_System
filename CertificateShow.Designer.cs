﻿namespace Clinic_Management_System
{
    partial class CertificateShow
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            disease = new DataGridViewTextBoxColumn();
            from_Date = new DataGridViewTextBoxColumn();
            to_Date = new DataGridViewTextBoxColumn();
            rest_from_date = new DataGridViewTextBoxColumn();
            rest_to_date = new DataGridViewTextBoxColumn();
            resume_date = new DataGridViewTextBoxColumn();
            today_date = new DataGridViewTextBoxColumn();
            certificate_number = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 743);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(218, 33);
            label1.Name = "label1";
            label1.Size = new Size(327, 31);
            label1.TabIndex = 1;
            label1.Text = "Certificate Details of Patients";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { name, disease, from_Date, to_Date, rest_from_date, rest_to_date, resume_date, today_date, certificate_number });
            dataGridView1.Location = new Point(27, 99);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(747, 551);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.HeaderText = "Name";
            name.MinimumWidth = 6;
            name.Name = "name";
            // 
            // disease
            // 
            disease.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            disease.HeaderText = "Disease";
            disease.MinimumWidth = 6;
            disease.Name = "disease";
            // 
            // from_Date
            // 
            from_Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            from_Date.HeaderText = "Treatment From Date";
            from_Date.MinimumWidth = 6;
            from_Date.Name = "from_Date";
            // 
            // to_Date
            // 
            to_Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            to_Date.HeaderText = "Treatment To Date";
            to_Date.MinimumWidth = 6;
            to_Date.Name = "to_Date";
            // 
            // rest_from_date
            // 
            rest_from_date.HeaderText = "Rest From Date";
            rest_from_date.MinimumWidth = 6;
            rest_from_date.Name = "rest_from_date";
            rest_from_date.Width = 125;
            // 
            // rest_to_date
            // 
            rest_to_date.HeaderText = "Rest To Date";
            rest_to_date.MinimumWidth = 6;
            rest_to_date.Name = "rest_to_date";
            rest_to_date.Width = 125;
            // 
            // resume_date
            // 
            resume_date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            resume_date.HeaderText = "Resume Date";
            resume_date.MinimumWidth = 6;
            resume_date.Name = "resume_date";
            // 
            // today_date
            // 
            today_date.HeaderText = "Today's Date";
            today_date.MinimumWidth = 6;
            today_date.Name = "today_date";
            today_date.Visible = false;
            today_date.Width = 125;
            // 
            // certificate_number
            // 
            certificate_number.HeaderText = "Certificate Number";
            certificate_number.MinimumWidth = 6;
            certificate_number.Name = "certificate_number";
            certificate_number.Visible = false;
            certificate_number.Width = 125;
            // 
            // CertificateShow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(panel1);
            Name = "CertificateShow";
            Size = new Size(801, 743);
            Load += CertificateShow_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label1;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn disease;
        private DataGridViewTextBoxColumn from_Date;
        private DataGridViewTextBoxColumn to_Date;
        private DataGridViewTextBoxColumn rest_from_date;
        private DataGridViewTextBoxColumn rest_to_date;
        private DataGridViewTextBoxColumn resume_date;
        private DataGridViewTextBoxColumn today_date;
        private DataGridViewTextBoxColumn certificate_number;
    }
}
