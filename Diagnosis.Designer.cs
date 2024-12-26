namespace Clinic_Management_System
{
    partial class Diagnosis
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
            txtmedqty = new TextBox();
            label10 = new Label();
            button1 = new Button();
            btnClear = new Button();
            btnSave = new Button();
            txttreat = new TextBox();
            label3 = new Label();
            txtdiag = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom;
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(txtmedqty);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(txttreat);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtdiag);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1178, 871);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // txtmedqty
            // 
            txtmedqty.Anchor = AnchorStyles.Bottom;
            txtmedqty.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtmedqty.Location = new Point(567, 567);
            txtmedqty.Name = "txtmedqty";
            txtmedqty.Size = new Size(186, 41);
            txtmedqty.TabIndex = 63;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom;
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(467, 544);
            label10.Name = "label10";
            label10.Size = new Size(441, 20);
            label10.TabIndex = 62;
            label10.Text = "How many types of medicine you want to describe?";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = Color.LightSteelBlue;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(567, 626);
            button1.Name = "button1";
            button1.Size = new Size(179, 89);
            button1.TabIndex = 61;
            button1.Text = "Add Medicine";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom;
            btnClear.BackColor = Color.LightSteelBlue;
            btnClear.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(714, 414);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(179, 69);
            btnClear.TabIndex = 60;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.BackColor = Color.LightSteelBlue;
            btnSave.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(413, 414);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(179, 69);
            btnSave.TabIndex = 59;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txttreat
            // 
            txttreat.Anchor = AnchorStyles.Top;
            txttreat.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txttreat.Location = new Point(567, 243);
            txttreat.Multiline = true;
            txttreat.Name = "txttreat";
            txttreat.Size = new Size(457, 76);
            txttreat.TabIndex = 56;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(316, 247);
            label3.Name = "label3";
            label3.Size = new Size(165, 33);
            label3.TabIndex = 55;
            label3.Text = "Treatment:";
            // 
            // txtdiag
            // 
            txtdiag.Anchor = AnchorStyles.Top;
            txtdiag.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtdiag.Location = new Point(567, 119);
            txtdiag.Multiline = true;
            txtdiag.Name = "txtdiag";
            txtdiag.Size = new Size(457, 76);
            txtdiag.TabIndex = 54;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(316, 123);
            label2.Name = "label2";
            label2.Size = new Size(165, 33);
            label2.TabIndex = 39;
            label2.Text = "Diagnosis:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(495, 32);
            label1.Name = "label1";
            label1.Size = new Size(155, 41);
            label1.TabIndex = 1;
            label1.Text = "Diagnosis";
            label1.Click += label1_Click;
            // 
            // Diagnosis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Diagnosis";
            Size = new Size(1178, 871);
            Load += Diagnosis_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txttreat;
        private Label label3;
        private TextBox txtdiag;
        private Button btnClear;
        private Button btnSave;
        private Button button1;
        private TextBox txtmedqty;
        private Label label10;
    }
}
