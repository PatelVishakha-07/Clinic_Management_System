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
            btnClear = new Button();
            btnSave = new Button();
            txtcharge = new TextBox();
            label4 = new Label();
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
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(txtcharge);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txttreat);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtdiag);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1178, 871);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom;
            btnClear.BackColor = Color.LightSteelBlue;
            btnClear.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(663, 534);
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
            btnSave.Location = new Point(411, 534);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(179, 69);
            btnSave.TabIndex = 59;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtcharge
            // 
            txtcharge.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtcharge.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtcharge.Location = new Point(567, 371);
            txtcharge.Name = "txtcharge";
            txtcharge.ReadOnly = true;
            txtcharge.Size = new Size(457, 41);
            txtcharge.TabIndex = 58;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(316, 379);
            label4.Name = "label4";
            label4.Size = new Size(135, 33);
            label4.TabIndex = 57;
            label4.Text = "Charges:";
            label4.Click += label4_Click;
            // 
            // txttreat
            // 
            txttreat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txttreat.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txttreat.Location = new Point(567, 243);
            txttreat.Multiline = true;
            txttreat.Name = "txttreat";
            txttreat.Size = new Size(457, 76);
            txttreat.TabIndex = 56;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            txtdiag.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtdiag.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtdiag.Location = new Point(567, 119);
            txtdiag.Multiline = true;
            txtdiag.Name = "txtdiag";
            txtdiag.Size = new Size(457, 76);
            txtdiag.TabIndex = 54;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
        private TextBox txtcharge;
        private Label label4;
        private Button btnClear;
        private Button btnSave;
    }
}
