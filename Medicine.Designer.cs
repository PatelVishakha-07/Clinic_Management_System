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
            panel1 = new Panel();
            TopPanel = new Panel();
            leftPanel = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(TopPanel);
            panel1.Controls.Add(leftPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1238, 950);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // TopPanel
            // 
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(301, 0);
            TopPanel.Margin = new Padding(4);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(937, 112);
            TopPanel.TabIndex = 1;
            // 
            // leftPanel
            // 
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Margin = new Padding(4);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(301, 950);
            leftPanel.TabIndex = 0;
            // 
            // Medicine
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1238, 950);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "Medicine";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Medicine";
            Load += Medicine_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel leftPanel;
        private Panel TopPanel;
    }
}