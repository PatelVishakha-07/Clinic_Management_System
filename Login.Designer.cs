namespace Clinic_Management_System
{
    partial class LoginForm
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
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            textBox2 = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonFace;
            textBox1.Location = new Point(105, 260);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(407, 39);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(105, 237);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(49, 260);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Location = new Point(49, 305);
            panel2.Name = "panel2";
            panel2.Size = new Size(463, 3);
            panel2.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ButtonFace;
            textBox2.Location = new Point(105, 394);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(407, 39);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(105, 371);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 5;
            label2.Text = "Username";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.password;
            pictureBox2.Location = new Point(49, 394);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSlateGray;
            panel3.Location = new Point(49, 439);
            panel3.Name = "panel3";
            panel3.Size = new Size(463, 3);
            panel3.TabIndex = 7;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.med1;
            pictureBox3.Image = Properties.Resources.button;
            pictureBox3.Location = new Point(226, 510);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 54);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.login;
            pictureBox4.Location = new Point(166, 57);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(215, 118);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.med1;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(577, 711);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            BackgroundImage = Properties.Resources.med1;
            ClientSize = new Size(577, 711);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "Login";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TextBox textBox2;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel panel3;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel panel1;
    }
}