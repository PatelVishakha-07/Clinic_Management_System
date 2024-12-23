namespace Clinic_Management_System
{
    partial class Income
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            leftPanel = new Panel();
            topPanel = new Panel();
            menuStrip1 = new MenuStrip();
            todaysIncomeToolStripMenuItem = new ToolStripMenuItem();
            monthlyIncomeToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            lblCharge = new Label();
            lblProfit = new Label();
            dataGridView1 = new DataGridView();
            profit_date = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            total_charge = new DataGridViewTextBoxColumn();
            button1 = new Button();
            comboBox1 = new ComboBox();
            topPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(246, 754);
            leftPanel.TabIndex = 0;
            // 
            // topPanel
            // 
            topPanel.Controls.Add(menuStrip1);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(246, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(981, 69);
            topPanel.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(255, 255, 192);
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Font = new Font("Doppio One", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { todaysIncomeToolStripMenuItem, monthlyIncomeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(981, 69);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // todaysIncomeToolStripMenuItem
            // 
            todaysIncomeToolStripMenuItem.Name = "todaysIncomeToolStripMenuItem";
            todaysIncomeToolStripMenuItem.Size = new Size(163, 65);
            todaysIncomeToolStripMenuItem.Text = "OPD's Income";
            // 
            // monthlyIncomeToolStripMenuItem
            // 
            monthlyIncomeToolStripMenuItem.Name = "monthlyIncomeToolStripMenuItem";
            monthlyIncomeToolStripMenuItem.Size = new Size(139, 65);
            monthlyIncomeToolStripMenuItem.Text = "IPD Income";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(lblCharge);
            panel1.Controls.Add(lblProfit);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(246, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(981, 685);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // lblCharge
            // 
            lblCharge.AutoSize = true;
            lblCharge.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCharge.Location = new Point(25, 646);
            lblCharge.Name = "lblCharge";
            lblCharge.Size = new Size(79, 31);
            lblCharge.TabIndex = 6;
            lblCharge.Text = "label3";
            // 
            // lblProfit
            // 
            lblProfit.AutoSize = true;
            lblProfit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblProfit.Location = new Point(25, 586);
            lblProfit.Name = "lblProfit";
            lblProfit.Size = new Size(79, 31);
            lblProfit.TabIndex = 5;
            lblProfit.Text = "label3";
            // 
            // dataGridView1
            // 
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
            dataGridView1.Location = new Point(25, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(926, 435);
            dataGridView1.TabIndex = 2;
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
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(642, 33);
            button1.Name = "button1";
            button1.Size = new Size(136, 36);
            button1.TabIndex = 1;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Daily Income", "Monthly Income", "Yearly Income" });
            comboBox1.Location = new Point(84, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(449, 36);
            comboBox1.TabIndex = 0;
            // 
            // Income
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 754);
            Controls.Add(panel1);
            Controls.Add(topPanel);
            Controls.Add(leftPanel);
            MainMenuStrip = menuStrip1;
            Name = "Income";
            Text = "Income";
            Load += Income_Load;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel leftPanel;
        private Panel topPanel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem todaysIncomeToolStripMenuItem;
        private ToolStripMenuItem monthlyIncomeToolStripMenuItem;
        private Panel panel1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn profit_date;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn total_charge;
        private Label lblCharge;
        private Label lblProfit;
    }
}