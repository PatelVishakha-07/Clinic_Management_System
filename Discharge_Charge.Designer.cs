namespace Clinic_Management_System
{
    partial class Discharge_Charge
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
            label1 = new Label();
            txtamount = new TextBox();
            btn_enter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 79);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter Charges";
            // 
            // txtamount
            // 
            txtamount.Location = new Point(233, 113);
            txtamount.Name = "txtamount";
            txtamount.Size = new Size(125, 27);
            txtamount.TabIndex = 1;
            // 
            // btn_enter
            // 
            btn_enter.Location = new Point(252, 146);
            btn_enter.Name = "btn_enter";
            btn_enter.Size = new Size(94, 29);
            btn_enter.TabIndex = 2;
            btn_enter.Text = "Ok";
            btn_enter.UseVisualStyleBackColor = true;
            btn_enter.Click += btn_enter_Click;
            // 
            // Discharge_Charge
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(649, 355);
            Controls.Add(btn_enter);
            Controls.Add(txtamount);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Discharge_Charge";
            Text = "Discharge_Charge";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtamount;
        private Button btn_enter;
    }
}