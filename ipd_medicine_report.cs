using System.Data;
using System.Drawing.Printing;

namespace Clinic_Management_System
{
    public partial class ipd_medicine_report : Form
    {
        Panel printPanel;
        Button printButton;
        PrintDocument printDocument;
        int ipd_id;
        databaseclass dbclass=new databaseclass();
        public ipd_medicine_report(int ipd_id)
        {
            InitializeComponent();
            this.ipd_id = ipd_id;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            printPanel = new Panel
            {
                Size = new Size(500, 700),
                BackColor = Color.White,
                Location = new Point(10, 10)
            };

            printButton = new Button
            {
                Text = "Print Report",
                Location = new Point(10, 610)
            };
            printButton.Click += PrintButton_Click;

            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            Controls.Add(printPanel);
            printPanel.Controls.Add(pictureBox1);
            printPanel.Dock = DockStyle.Fill;
            printPanel.AutoScroll = true;
            //printPanel.Dock = DockStyle.Fill;
            printPanel.Controls.Add(printButton);

            Size = new Size(500, 700);
            Text = "IPD Report";
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            printButton.Visible = false;
            try
            {
                printDocument.Print(); // This sends the content to the default printer 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while printing: {ex.Message}", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Render the panel to a bitmap
            Bitmap bitmap = new Bitmap(printPanel.Width, printPanel.Height);
            printPanel.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, printPanel.Width, printPanel.Height));

            // Draw the bitmap on the paper
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void ipd_medicine_report_Load(object sender, EventArgs e)
        {
            DataSet main_ds = new DataSet();
            string treatment_query = $"select discharge_treatment_id from discharge_treatment_table where discharge_id={ipd_id}";
            DataSet ds = dbclass.Getdata(treatment_query);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dataRow in ds.Tables[0].Rows)
                {
                    int treatment_id = int.Parse(dataRow["discharge_treatment_id"].ToString());
                    string medicine_query = $"select medicine_name,quantity from discharge_prescribed_medicine where discharge_treatment_id={treatment_id}";
                    DataSet ds1=dbclass.Getdata(medicine_query);
                    main_ds.Merge(ds1);
                }
            }
            int currentY = 120;
            DataGridView gridView = new DataGridView
            { 
                DataSource = main_ds.Tables[0],
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill, 
                AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells,  
                Location = new Point(5, currentY),
                Size = new Size(printPanel.Width - 20, 470),
                AllowUserToAddRows = false,
                ReadOnly = true,
                ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
                {
                    Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold),
                    ForeColor = Color.Black,
                    BackColor = Color.LightGray
                },
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Font = new System.Drawing.Font("Arial", 10, FontStyle.Regular),
                    ForeColor = Color.Black,
                    BackColor = Color.White,
                    WrapMode = DataGridViewTriState.True
                }
            };
            gridView.CellFormatting += GridView_CellFormatting;

            printPanel.Controls.Add(gridView);
            currentY += gridView.Height + 15;
        }

        private void GridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
        }


    }
}
