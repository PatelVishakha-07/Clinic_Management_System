namespace Clinic_Management_System
{
    partial class OPD_Income
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            lblCharge = new Label();
            lblProfit = new Label();
            dataGridView1 = new DataGridView();
            profit_date = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            total_charge = new DataGridViewTextBoxColumn();
            button1 = new Button();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblCharge);
            panel1.Controls.Add(lblProfit);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(981, 685);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(378, 11);
            label1.Name = "label1";
            label1.Size = new Size(178, 36);
            label1.TabIndex = 13;
            label1.Text = "OPD Income";
            // 
            // lblCharge
            // 
            lblCharge.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCharge.AutoSize = true;
            lblCharge.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCharge.Location = new Point(27, 633);
            lblCharge.Name = "lblCharge";
            lblCharge.Size = new Size(79, 31);
            lblCharge.TabIndex = 11;
            lblCharge.Text = "label3";
            // 
            // lblProfit
            // 
            lblProfit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblProfit.AutoSize = true;
            lblProfit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblProfit.Location = new Point(27, 573);
            lblProfit.Name = "lblProfit";
            lblProfit.Size = new Size(79, 31);
            lblProfit.TabIndex = 10;
            lblProfit.Text = "label3";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Stencil Std", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { profit_date, amount, total_charge });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(27, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(926, 351);
            dataGridView1.TabIndex = 9;
            // 
            // profit_date
            // 
            profit_date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            profit_date.HeaderText = "Date";
            profit_date.MinimumWidth = 6;
            profit_date.Name = "profit_date";
            // 
            // amount
            // 
            amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            amount.HeaderText = "Profit";
            amount.MinimumWidth = 6;
            amount.Name = "amount";
            // 
            // total_charge
            // 
            total_charge.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            total_charge.HeaderText = "Charge";
            total_charge.MinimumWidth = 6;
            total_charge.Name = "total_charge";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(634, 107);
            button1.Name = "button1";
            button1.Size = new Size(136, 36);
            button1.TabIndex = 8;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Today's Income", "Monthly Income", "Yearly Income" });
            comboBox1.Location = new Point(76, 107);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(449, 36);
            comboBox1.TabIndex = 7;
            // 
            // OPD_Income
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "OPD_Income";
            Size = new Size(981, 685);
            Load += OPD_Income_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblCharge;
        private Label lblProfit;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn profit_date;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn total_charge;
        private Button button1;
        private ComboBox comboBox1;
        private Label label1;
    }
}
