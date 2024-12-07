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
            textBox1.Location = new Point(407, 306);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(508, 48);
            textBox1.TabIndex = 0;
           // textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(407, 277);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 1;
            label1.Text = "Username";
           // label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user1;
            pictureBox1.Location = new Point(353, 306);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Location = new Point(353, 362);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(579, 4);
            panel2.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ButtonFace;
            textBox2.Location = new Point(407, 481);
            textBox2.Margin = new Padding(4, 4, 4, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(508, 48);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(407, 452);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 5;
            label2.Text = "Username";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.password1;
            pictureBox2.Location = new Point(353, 481);
            pictureBox2.Margin = new Padding(4, 4, 4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSlateGray;
            panel3.Location = new Point(353, 538);
            panel3.Margin = new Padding(4, 4, 4, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(579, 4);
            panel3.TabIndex = 7;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.med1;
            pictureBox3.Image = Properties.Resources.button;
            pictureBox3.Location = new Point(579, 601);
            pictureBox3.Margin = new Padding(4, 4, 4, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(156, 68);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.login1;
            pictureBox4.Location = new Point(494, 68);
            pictureBox4.Margin = new Padding(4, 4, 4, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(269, 148);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            //pictureBox4.Click += pictureBox4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
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
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1238, 950);
            panel1.TabIndex = 0;
           // panel1.Paint += panel1_Paint;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            BackgroundImage = Properties.Resources.med1;
            ClientSize = new Size(1238, 950);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
           // Load += LoginForm_Load;
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