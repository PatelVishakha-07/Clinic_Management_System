using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Document = iTextSharp.text.Document;

namespace Clinic_Management_System
{
    public partial class Report : Form
    {
        Panel printPanel;
        Button printButton;
        PrintDocument printDocument;
        int patientId;
        databaseclass dbclass = new databaseclass();
        public Report(int patientId)
        {
            InitializeComponent();
            this.patientId = patientId;

            printPanel = new Panel
            {
                Size = new Size(1082, 860),
                BackColor = Color.LightBlue,
                Location= new Point(10,10)                
            };

            Label label = new Label
            {
                Text="Clinic Name",
                AutoSize= true,
                Location= new Point(10,10)
            };

            printPanel.Controls.Add(label);
            printButton = new Button
            {
                Text="Print Report",
                Location=new Point(30,900)
            };
            printButton.Click += PrintButton_Click;

            printDocument=new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            Controls.Add(printPanel);
            //printPanel.Dock = DockStyle.Fill;
            Controls.Add(printButton);

            Size = new Size(1082, 920);
            Text = "Print Report Example";
        }

        private void Report_Load(object sender, EventArgs e)
        {

            // Fetch and display patient details
            string patientQuery = $"select Distinct * from patients WHERE patient_id={patientId}";
            DataSet patientData = dbclass.Getdata(patientQuery);
            int currentY = 200;
            currentY = DisplayData(patientData, panel1, currentY, "Patient Details", excludeColumns: new[] { "patient_id" });

            // Fetch and display prescription details and their associated prescribed medicines immediately
            string prescriptionQuery = $"select * from prescription where patient_id={patientId} order by prescription_date desc limit 1";
            DataSet prescriptionData = dbclass.Getdata(prescriptionQuery);

            if (prescriptionData != null && prescriptionData.Tables[0].Rows.Count > 0)
            {
                // Display the latest prescription details
                DataRow prescriptionRow = prescriptionData.Tables[0].Rows[0];
                int prescriptionId = Convert.ToInt32(prescriptionRow["prescription_id"]);

                string query = $"select * from prescription where prescription_id={prescriptionId}";
                DataSet currentprescription = dbclass.Getdata(query);
                // Display prescription details
                currentY = DisplayData(currentprescription, panel1, currentY, "Prescription Details", excludeColumns: new[] { "patient_id", "prescription_id" });

                // Fetch and display prescribed medicines for this latest prescription
                string medicineQuery = $"select * from Prescribed_Medicine where prescription_id={prescriptionId}";
                DataSet medicineData = dbclass.Getdata(medicineQuery);

                // Display the medicines immediately below the current prescription
                currentY = DisplayData(medicineData, panel1, currentY + 50, "Prescribed Medicine Details", excludeColumns: new[] { "pres_med_id", "prescription_id" });
                currentY += 20; // Adjust for next prescription and medicine set
            }
            else
            {
                // Handle case where no prescriptions are found
                Label noDataLabel = new Label()
                {
                    Text = "No prescriptions available.",
                    Location = new Point(40, currentY),
                    AutoSize = true,
                    Font = new System.Drawing.Font("Arial", 12, FontStyle.Italic),
                    ForeColor = Color.Gray
                };
                panel1.Controls.Add(noDataLabel);
                currentY += 35; // Adjust for next section
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            // Trigger the print dialog
            /* PrintDialog printDialog = new PrintDialog
             {
                 Document = printDocument
             };

             if (printDialog.ShowDialog() == DialogResult.OK)
             {
                 printDocument.Print();
             }   */

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

        private string TranslateUsageToBars(string usage)
        {
            switch (usage.ToUpper())
            {
                case "OD":
                    return "| ";  // Once a day
                case "BD":
                    return "| |"; // Twice a day
                case "TD":
                    return "| | |"; // Thrice a day
                case "QD":
                    return "| | | |"; // Four times a day
                default:
                    return usage; // If no match, return original value
            }
        }

        private int DisplayData(DataSet ds, Panel panel1, int startY, string sectionTitle, string[] excludeColumns = null)
        {
            int labelSpacing = 35;
            int keyValueSpacing = 250;

            Label titleLabel = new Label()
            {
                Text = sectionTitle,
                Location = new Point(40, startY),
                AutoSize = true,
                Font = new System.Drawing.Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.DimGray,
            };
            panel1.Controls.Add(titleLabel);
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

                        // Check for the "usage" column and translate values
                        if (col.ColumnName.Equals("usage", StringComparison.OrdinalIgnoreCase))
                        {
                            columnValue = TranslateUsageToBars(columnValue);                            
                        }

                        Label keyLabel = new Label()
                        {
                            Text = $"{columnName}:",
                            Location = new Point(40, startY),
                            AutoSize = true,
                            Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold)
                        };

                        Label valueLabel = new Label()
                        {
                            Text = columnValue,
                            Location = new Point(40 + keyValueSpacing, startY),
                            AutoSize = true,
                            Font = new System.Drawing.Font("Arial", 12, FontStyle.Regular)
                        };

                        panel1.Controls.Add(keyLabel);
                        panel1.Controls.Add(valueLabel);

                        startY += labelSpacing;
                    }
                }
            }
            else
            {
                Label noDataLabel = new Label()
                {
                    Text = "No data available.",
                    Location = new Point(40, startY),
                    AutoSize = true,
                    Font = new System.Drawing.Font("Arial", 12, FontStyle.Italic),
                    ForeColor = Color.Gray
                };
                panel1.Controls.Add(noDataLabel);
                startY += labelSpacing;
            }

            return startY;
        }

    }
}
