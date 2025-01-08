namespace Clinic_Management_System
{
    partial class AdminPass
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
            label4 = new Label();
            btnSave = new Button();
            txtName = new TextBox();
            label3 = new Label();
            txtpass = new TextBox();
            label1 = new Label();
            txtusername = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtpass);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtusername);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1079, 763);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(396, 38);
            label4.Name = "label4";
            label4.Size = new Size(252, 41);
            label4.TabIndex = 47;
            label4.Text = "Admin Password";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.BackColor = Color.Silver;
            btnSave.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(396, 419);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(179, 69);
            btnSave.TabIndex = 46;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(462, 309);
            txtName.Name = "txtName";
            txtName.Size = new Size(457, 41);
            txtName.TabIndex = 44;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(219, 317);
            label3.Name = "label3";
            label3.Size = new Size(195, 33);
            label3.TabIndex = 43;
            label3.Text = "New Password";
            // 
            // txtpass
            // 
            txtpass.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtpass.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtpass.Location = new Point(462, 222);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(457, 41);
            txtpass.TabIndex = 42;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(245, 222);
            label1.Name = "label1";
            label1.Size = new Size(135, 33);
            label1.TabIndex = 41;
            label1.Text = "Password";
            // 
            // txtusername
            // 
            txtusername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtusername.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtusername.Location = new Point(462, 137);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(457, 41);
            txtusername.TabIndex = 40;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(245, 145);
            label2.Name = "label2";
            label2.Size = new Size(135, 33);
            label2.TabIndex = 39;
            label2.Text = "Username";
            // 
            // AdminPass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(panel1);
            Name = "AdminPass";
            Size = new Size(1079, 763);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtName;
        private Label label3;
        private TextBox txtpass;
        private Label label1;
        private TextBox txtusername;
        private Label label2;
        private Button btnSave;
        private Label label4;
    }
}
