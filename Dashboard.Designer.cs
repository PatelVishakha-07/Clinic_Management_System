namespace Clinic_Management_System
{
    partial class Dashboard
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
            PanelDashboard = new Panel();
            panel5 = new Panel();
            pictureBox3 = new PictureBox();
            btnInHouse = new Button();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            btnMedicine = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            btnPatients = new Button();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            PanelDashboard.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // PanelDashboard
            // 
            PanelDashboard.BackColor = Color.FromArgb(64, 64, 64);
            PanelDashboard.Controls.Add(panel5);
            PanelDashboard.Controls.Add(panel4);
            PanelDashboard.Controls.Add(panel3);
            PanelDashboard.Controls.Add(panel2);
            PanelDashboard.Dock = DockStyle.Left;
            PanelDashboard.Location = new Point(0, 0);
            PanelDashboard.Margin = new Padding(4, 4, 4, 4);
            PanelDashboard.Name = "PanelDashboard";
            PanelDashboard.Size = new Size(301, 1080);
            PanelDashboard.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(btnInHouse);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 462);
            panel5.Margin = new Padding(4, 4, 4, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(301, 125);
            panel5.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.add;
            pictureBox3.Location = new Point(24, 28);
            pictureBox3.Margin = new Padding(4, 4, 4, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(70, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // btnInHouse
            // 
            btnInHouse.BackgroundImageLayout = ImageLayout.Zoom;
            btnInHouse.FlatStyle = FlatStyle.Popup;
            btnInHouse.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInHouse.ForeColor = Color.White;
            btnInHouse.ImageAlign = ContentAlignment.TopLeft;
            btnInHouse.Location = new Point(24, 28);
            btnInHouse.Margin = new Padding(4, 4, 4, 4);
            btnInHouse.Name = "btnInHouse";
            btnInHouse.Padding = new Padding(2, 0, 0, 0);
            btnInHouse.Size = new Size(252, 70);
            btnInHouse.TabIndex = 5;
            btnInHouse.Text = "In-House Patients";
            btnInHouse.TextAlign = ContentAlignment.MiddleRight;
            btnInHouse.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(btnMedicine);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 337);
            panel4.Margin = new Padding(4, 4, 4, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(301, 125);
            panel4.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.medicine;
            pictureBox2.Location = new Point(24, 28);
            pictureBox2.Margin = new Padding(4, 4, 4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // btnMedicine
            // 
            btnMedicine.BackgroundImageLayout = ImageLayout.Zoom;
            btnMedicine.FlatStyle = FlatStyle.Popup;
            btnMedicine.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMedicine.ForeColor = Color.White;
            btnMedicine.ImageAlign = ContentAlignment.TopLeft;
            btnMedicine.Location = new Point(24, 28);
            btnMedicine.Margin = new Padding(4, 4, 4, 4);
            btnMedicine.Name = "btnMedicine";
            btnMedicine.Padding = new Padding(2, 0, 0, 0);
            btnMedicine.Size = new Size(252, 69);
            btnMedicine.TabIndex = 3;
            btnMedicine.Text = "Medicines";
            btnMedicine.TextAlign = ContentAlignment.MiddleRight;
            btnMedicine.UseVisualStyleBackColor = true;
            btnMedicine.Click += btnMedicine_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(btnPatients);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 212);
            panel3.Margin = new Padding(4, 4, 4, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(301, 125);
            panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.patient;
            pictureBox1.Location = new Point(15, 28);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnPatients
            // 
            btnPatients.BackgroundImageLayout = ImageLayout.Zoom;
            btnPatients.FlatStyle = FlatStyle.Popup;
            btnPatients.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPatients.ForeColor = Color.White;
            btnPatients.ImageAlign = ContentAlignment.TopLeft;
            btnPatients.Location = new Point(15, 28);
            btnPatients.Margin = new Padding(4, 4, 4, 4);
            btnPatients.Name = "btnPatients";
            btnPatients.Padding = new Padding(2, 0, 0, 0);
            btnPatients.Size = new Size(252, 69);
            btnPatients.TabIndex = 1;
            btnPatients.Text = "Patients";
            btnPatients.TextAlign = ContentAlignment.MiddleRight;
            btnPatients.UseVisualStyleBackColor = true;
            btnPatients.Click += btnPatients_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(301, 212);
            panel2.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.doctor;
            pictureBox4.Location = new Point(38, 31);
            pictureBox4.Margin = new Padding(4, 4, 4, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(202, 148);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelDashboard);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Dashboard";
            Size = new Size(1920, 1080);
            Load += Dashboard_Load;
            PanelDashboard.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelDashboard;
        private Panel panel2;
        private Panel panel3;
        private Button btnPatients;
        private PictureBox pictureBox1;
        private Panel panel5;
        private PictureBox pictureBox3;
        private Button btnInHouse;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Button btnMedicine;
        private PictureBox pictureBox4;
    }
}