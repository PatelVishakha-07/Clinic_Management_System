namespace Clinic_Management_System
{
    partial class Prescriped_medicine
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
            lblwrong = new Label();
            listBox1 = new ListBox();
            btnaddmore = new Button();
            btnSave = new Button();
            txtqty = new TextBox();
            txtName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            lblqty = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(lblqty);
            panel1.Controls.Add(lblwrong);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(btnaddmore);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(txtqty);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 763);
            panel1.TabIndex = 0;
//            panel1.Paint += panel1_Paint;
            // 
            // lblwrong
            // 
            lblwrong.AutoSize = true;
            lblwrong.ForeColor = Color.Red;
            lblwrong.Location = new Point(554, 119);
            lblwrong.Name = "lblwrong";
            lblwrong.Size = new Size(100, 20);
            lblwrong.TabIndex = 64;
            lblwrong.Text = "Not Available";
            lblwrong.Visible = false;
          //  lblwrong.Click += lblwrong_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(554, 185);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(457, 104);
            listBox1.TabIndex = 63;
            listBox1.Visible = false;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnaddmore
            // 
            btnaddmore.BackColor = Color.LightSteelBlue;
            btnaddmore.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnaddmore.ForeColor = Color.Black;
            btnaddmore.Location = new Point(407, 322);
            btnaddmore.Name = "btnaddmore";
            btnaddmore.Size = new Size(179, 69);
            btnaddmore.TabIndex = 62;
            btnaddmore.Text = "Add More";
            btnaddmore.UseVisualStyleBackColor = false;
            btnaddmore.Click += btnaddmore_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSteelBlue;
            btnSave.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(723, 322);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(179, 69);
            btnSave.TabIndex = 61;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtqty
            // 
            txtqty.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtqty.Location = new Point(554, 218);
            txtqty.Name = "txtqty";
            txtqty.Size = new Size(457, 41);
            txtqty.TabIndex = 60;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(554, 142);
            txtName.Name = "txtName";
            txtName.Size = new Size(457, 41);
            txtName.TabIndex = 59;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(323, 226);
            label4.Name = "label4";
            label4.Size = new Size(150, 33);
            label4.TabIndex = 58;
            label4.Text = "Quantity:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(335, 289);
            label3.Name = "label3";
            label3.Size = new Size(0, 33);
            label3.TabIndex = 57;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.medicine;
            pictureBox1.Location = new Point(26, 185);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 330);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(323, 150);
            label2.Name = "label2";
            label2.Size = new Size(225, 33);
            label2.TabIndex = 38;
            label2.Text = "Medicine Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(407, 33);
            label1.Name = "label1";
            label1.Size = new Size(304, 41);
            label1.TabIndex = 1;
            label1.Text = "Prescribed Medicine";
            // 
            // lblqty
            // 
            lblqty.AutoSize = true;
            lblqty.ForeColor = Color.Red;
            lblqty.Location = new Point(554, 195);
            lblqty.Name = "lblqty";
            lblqty.Size = new Size(115, 20);
            lblqty.TabIndex = 65;
            lblqty.Text = "Low on quantity";
            lblqty.Visible = false;
            // 
            // Prescriped_medicine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Prescriped_medicine";
            Size = new Size(1100, 763);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private TextBox txtqty;
        private TextBox txtName;
        private Button btnaddmore;
        private Button btnSave;
        private ListBox listBox1;
        private Label lblwrong;
        private Label lblqty;
    }
}
