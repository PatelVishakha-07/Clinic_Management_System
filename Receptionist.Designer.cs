namespace Clinic_Management_System
{
    partial class Receptionist
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
            panel6 = new Panel();
            pictureBox3 = new PictureBox();
            btnInHouse = new Button();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            btnMedicine = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            btnPrescription = new Button();
            panel5 = new Panel();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 756);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(pictureBox3);
            panel6.Controls.Add(btnInHouse);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 370);
            panel6.Name = "panel6";
            panel6.Size = new Size(248, 100);
            panel6.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.add;
            pictureBox3.Location = new Point(19, 22);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 56);
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
            btnInHouse.Location = new Point(19, 22);
            btnInHouse.Name = "btnInHouse";
            btnInHouse.Padding = new Padding(2, 0, 0, 0);
            btnInHouse.Size = new Size(202, 56);
            btnInHouse.TabIndex = 5;
            btnInHouse.Text = "In-House Patients";
            btnInHouse.TextAlign = ContentAlignment.MiddleRight;
            btnInHouse.UseVisualStyleBackColor = true;
            btnInHouse.Click += btnInHouse_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(btnMedicine);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 270);
            panel4.Name = "panel4";
            panel4.Size = new Size(248, 100);
            panel4.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.medicine;
            pictureBox2.Location = new Point(19, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 56);
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
            btnMedicine.Location = new Point(19, 22);
            btnMedicine.Name = "btnMedicine";
            btnMedicine.Padding = new Padding(2, 0, 0, 0);
            btnMedicine.Size = new Size(202, 55);
            btnMedicine.TabIndex = 3;
            btnMedicine.Text = "Medicines";
            btnMedicine.TextAlign = ContentAlignment.MiddleRight;
            btnMedicine.UseVisualStyleBackColor = true;
            btnMedicine.Click += btnMedicine_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(btnPrescription);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 170);
            panel3.Name = "panel3";
            panel3.Size = new Size(248, 100);
            panel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.patient;
            pictureBox1.Location = new Point(12, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnPrescription
            // 
            btnPrescription.BackgroundImageLayout = ImageLayout.Zoom;
            btnPrescription.FlatStyle = FlatStyle.Popup;
            btnPrescription.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrescription.ForeColor = Color.White;
            btnPrescription.ImageAlign = ContentAlignment.TopLeft;
            btnPrescription.Location = new Point(12, 22);
            btnPrescription.Name = "btnPrescription";
            btnPrescription.Padding = new Padding(2, 0, 0, 0);
            btnPrescription.Size = new Size(202, 55);
            btnPrescription.TabIndex = 1;
            btnPrescription.Text = "Prescription";
            btnPrescription.TextAlign = ContentAlignment.MiddleRight;
            btnPrescription.UseVisualStyleBackColor = true;
            btnPrescription.Click += btnPrescription_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(248, 170);
            panel5.TabIndex = 3;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.doctor;
            pictureBox4.Location = new Point(30, 25);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(162, 118);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(248, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(937, 756);
            panel2.TabIndex = 1;
            // 
            // Receptionist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1185, 756);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Receptionist";
            Text = "Receptionist";
            Load += Receptionist_Load;
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Button btnMedicine;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Button btnPrescription;
        private Panel panel5;
        private PictureBox pictureBox4;
        private Panel panel6;
        private PictureBox pictureBox3;
        private Button btnInHouse;
    }
}