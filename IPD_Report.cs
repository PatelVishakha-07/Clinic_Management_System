using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Clinic_Management_System.AddMedicine;

namespace Clinic_Management_System
{
    public partial class IPD_Report : Form
    {
        Panel printPanel;
        Button printButton;
        PrintDocument printDocument;
        int patientId,ipd_id;
        databaseclass dbclass = new databaseclass();

        public IPD_Report(int pid)
        {
            InitializeComponent();
            this.patientId = pid;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            printPanel = new Panel
            {
                Size = new Size(500, 700),
                BackColor = Color.White,
                Location = new Point(10, 10)
            };
            pictureBox1.Dock = DockStyle.Top;
            printPanel.Controls.Add(pictureBox1);
            printButton = new Button
            {
                Text = "Print Report",
                Location = new Point(20, 615)
            };
            printButton.Click += PrintButton_Click;

            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            Controls.Add(printPanel);
            printPanel.Dock= DockStyle.Fill;
            printPanel.AutoScroll = true;
            //printPanel.Dock = DockStyle.Fill;
            printPanel.Controls.Add(printButton);

            Size = new Size(500, 700);
            Text = "IPD Report";
        }

        private void IPD_Report_Load(object sender, EventArgs e)
        {
            string patientQuery = $"SELECT DISTINCT * FROM patients WHERE patient_id={patientId}";
            DataSet patientData = dbclass.Getdata(patientQuery);
            int currentY = 65;
            currentY = DisplayData(patientData, printPanel, currentY, "Patient Details", excludeColumns: new[] { "patient_id" });

            // Fetch the latest IPD entry for the patient
            string latestIpdQuery = $@"SELECT * FROM ipd_table WHERE patient_id={patientId} ORDER BY ipd_id DESC limit 1";
            DataSet ipd = dbclass.Getdata(latestIpdQuery);

            if (ipd != null && ipd.Tables[0].Rows.Count > 0)
            {
                DataRow latestIpdRow = ipd.Tables[0].Rows[0];
                 ipd_id = Convert.ToInt32(latestIpdRow["ipd_id"]);

                // Fetch and display the treatments associated with the latest IPD entry
                string treatmentQuery = $"SELECT diagnosis,treatment,treatment_date FROM ipd_treatment_table WHERE ipd_id={ipd_id}";
                DataSet treatmentData = dbclass.Getdata(treatmentQuery);

                DataGridView gridView = new DataGridView
                {
                    DataSource = treatmentData.Tables[0],
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill, // Adjusts column width to fit panel
                    AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells,   // Adjusts row height for wrapped text
                    Location = new Point(5, currentY),
                    Size = new Size(printPanel.Width - 13, 360),
                    AllowUserToAddRows = false,
                    ReadOnly = true,
                    ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
                    {
                        Font = new System.Drawing.Font("Arial", 9, FontStyle.Bold),
                        ForeColor = Color.Black,
                        BackColor = Color.LightGray
                    },
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Font = new System.Drawing.Font("Arial", 9, FontStyle.Regular),
                        ForeColor = Color.Black,
                        BackColor = Color.White,
                        WrapMode = DataGridViewTriState.True // Enables text wrapping in cells
                    }
                };
                printPanel.Controls.Add(gridView);
                currentY += gridView.Height + 10;
                // Include "treatment_id" in the excludeColumns array
                //  currentY = DisplayData(treatmentData, printPanel, currentY, "Latest Prescription Details", excludeColumns: new[] { "treatment_id", "patient_id", "prescription_id" });
            }
            else
            {
                // Handle case where no IPD records are found
                Label noDataLabel = new Label()
                {
                    Text = "No IPD records available.",
                    Location = new Point(10, currentY),
                    AutoSize = true,
                    Font = new Font("Arial", 11, FontStyle.Italic),
                    ForeColor = Color.Gray
                };
                printPanel.Controls.Add(noDataLabel);
                currentY += 30; // Adjust for next section
            }

        }

        private void PrintButton_Click(object sender, EventArgs e)
        {           
            try
            {
                printDocument.Print(); // This sends the content to the default printer
                ipd_medicine_report report = new ipd_medicine_report(ipd_id);
                this.Hide();
                report.ShowDialog();
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

        private int DisplayData(DataSet ds, Panel panel1, int startY, string sectionTitle, string[] excludeColumns = null)
        {
            int labelSpacing = 23;
            int keyValueSpacing = 160;

            startY += 40;

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    foreach (DataColumn col in ds.Tables[0].Columns)
                    {
                        if (excludeColumns != null && excludeColumns.Contains(col.ColumnName))
                            continue;

                        string columnName = col.ColumnName.ToUpper();
                        string columnValue = row[col].ToString();

                        Label keyLabel = new Label()
                        {
                            Text = $"{columnName}:",
                            Location = new Point(20, startY),
                            AutoSize = true,
                            Font = new Font("Arial", 9, FontStyle.Bold)
                        };

                        Label valueLabel = new Label()
                        {
                            Text = columnValue,
                            Location = new Point(20 + keyValueSpacing, startY),
                            AutoSize = true,
                            Font = new Font("Arial", 9, FontStyle.Regular)
                        };

                        panel1.Controls.Add(keyLabel);
                        panel1.Controls.Add(valueLabel);

                        startY += labelSpacing;
                    }

                    // Add extra space after each treatment's data
                    startY += 20; // Additional spacing
                }
            }
            else
            {
                Label noDataLabel = new Label()
                {
                    Text = "No data available.",
                    Location = new Point(40, startY),
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Italic),
                    ForeColor = Color.Gray
                };
                panel1.Controls.Add(noDataLabel);
                startY += labelSpacing;
            }
            return startY;
        }

    }
}
