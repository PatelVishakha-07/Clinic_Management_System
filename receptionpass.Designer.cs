namespace Clinic_Management_System
{
    partial class receptionpass
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
            txtusername = new TextBox();
            label2 = new Label();
            label4 = new Label();
            txtpass = new TextBox();
            label1 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            btnSave = new Button();
            txtrecpass = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtusername
            // 
            txtusername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtusername.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtusername.Location = new Point(457, 124);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(457, 41);
            txtusername.TabIndex = 42;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(240, 132);
            label2.Name = "label2";
            label2.Size = new Size(135, 33);
            label2.TabIndex = 41;
            label2.Text = "Username";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(404, 57);
            label4.Name = "label4";
            label4.Size = new Size(299, 41);
            label4.TabIndex = 48;
            label4.Text = "Reception Password";
            // 
            // txtpass
            // 
            txtpass.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtpass.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtpass.Location = new Point(457, 214);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(457, 41);
            txtpass.TabIndex = 50;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(240, 214);
            label1.Name = "label1";
            label1.Size = new Size(135, 33);
            label1.TabIndex = 49;
            label1.Text = "Password";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(457, 306);
            txtName.Name = "txtName";
            txtName.Size = new Size(457, 41);
            txtName.TabIndex = 52;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(75, 411);
            label3.Name = "label3";
            label3.Size = new Size(345, 33);
            label3.TabIndex = 51;
            label3.Text = "New Reception Password";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.BackColor = Color.Silver;
            btnSave.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(384, 500);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(179, 69);
            btnSave.TabIndex = 53;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtrecpass
            // 
            txtrecpass.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtrecpass.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtrecpass.Location = new Point(457, 403);
            txtrecpass.Name = "txtrecpass";
            txtrecpass.Size = new Size(457, 41);
            txtrecpass.TabIndex = 55;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(90, 314);
            label5.Name = "label5";
            label5.Size = new Size(285, 33);
            label5.TabIndex = 54;
            label5.Text = "Reception Username";
            // 
            // receptionpass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtrecpass);
            Controls.Add(label5);
            Controls.Add(btnSave);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(txtpass);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(txtusername);
            Controls.Add(label2);
            Name = "receptionpass";
            Size = new Size(1079, 763);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtusername;
        private Label label2;
        private Label label4;
        private TextBox txtpass;
        private Label label1;
        private TextBox txtName;
        private Label label3;
        private Button btnSave;
        private TextBox txtrecpass;
        private Label label5;
    }
}
