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
                Size = new Size(1064, 873),
                BackColor = Color.White,
                Location = new Point(10, 10)
            };

            printButton = new Button
            {
                Text = "Print Report",
                Location = new Point(950, 680)
            };
            printButton.Click += PrintButton_Click;

            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            Controls.Add(printPanel);
            printPanel.Dock = DockStyle.Fill;
            printPanel.Controls.Add(printButton);

            Size = new Size(1082, 920);
            Text = "Print Report";
        }

        private void Report_Load(object sender, EventArgs e)
        {
            int currentY = 120;

            // Clinic Title
            Label clinicLabel = new Label
            {
                Text = "Dhanvantari Clinic",
                Font = new System.Drawing.Font("Arial", 20, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                AutoSize = true,
                Location = new Point(40, currentY)
            };
            printPanel.Controls.Add(clinicLabel);
            currentY += 50;
            int  currentY1=currentY;
            // Fetch patient details
            string patientQuery = $"SELECT * FROM patients WHERE patient_id={patientId}";
            DataSet patientData = dbclass.Getdata(patientQuery);

            if (patientData != null && patientData.Tables[0].Rows.Count > 0)
            {
                DataRow patientRow = patientData.Tables[0].Rows[0];

                // Display patient details as labels
                AddLabel($"Patient Name: {patientRow["name"]}", ref currentY);
                AddLabel($"Age: {patientRow["age"]}   Gender: {patientRow["gender"]}", ref currentY);
                AddLabel($"Contact: {patientRow["contact_no"]}", ref currentY);
                AddLabel($"Address: {patientRow["address"]}", ref currentY);
                currentY += 20; // Extra space
            }

            // Fetch prescription details
            string prescriptionQuery = $"SELECT * FROM prescription WHERE patient_id={patientId} ORDER BY prescription_date DESC LIMIT 1";
            DataSet prescriptionData = dbclass.Getdata(prescriptionQuery);

            if (prescriptionData != null && prescriptionData.Tables[0].Rows.Count > 0)
            {
                DataRow prescriptionRow = prescriptionData.Tables[0].Rows[0];

                // Display prescription details as labels
              //  AddLabel($"Prescription ID: {prescriptionRow["prescription_id"]}", ref currentY);
                AddLabel1($"Date: {Convert.ToDateTime(prescriptionRow["prescription_date"]).ToString("dd/MM/yyyy HH:mm")}", ref currentY1);
                AddLabel1($"Disease: {prescriptionRow["disease"]}", ref currentY1);
                AddLabel1($"Prescription: {prescriptionRow["prescription"]}", ref currentY1);
               // AddLabel($"Charges: Rs. {prescriptionRow["charges"]}", ref currentY);
                AddLabel1($"Total Charge: Rs. {prescriptionRow["total_charge"]}", ref currentY1);
                currentY += 20; // Extra space

                // Fetch prescribed medicines in DataGridView format
                //string medicineQuery = $"SELECT medicine_name AS 'Medicine', dosage AS 'Dosage', frequency AS 'Frequency', duration AS 'Duration' FROM Prescribed_Medicine WHERE prescription_id={prescriptionRow["prescription_id"]}";
                string medicineQuery = $"select medicine_name,quantity,usage from prescribed_medicine where prescription_id={prescriptionRow["prescription_id"]}";
                DataSet medicineData = dbclass.Getdata(medicineQuery);

                if (medicineData != null && medicineData.Tables[0].Rows.Count > 0)
                {
                    Label medicinesLabel = new Label
                    {
                        Text = "Prescribed Medicines",
                        Font = new System.Drawing.Font("Arial", 14, FontStyle.Bold),
                        ForeColor = Color.Black,
                        AutoSize = true,
                        Location = new Point(40, currentY)
                    };
                    printPanel.Controls.Add(medicinesLabel);
                    currentY += 30;

                    // Create and display DataGridView
                    DataGridView gridView = new DataGridView
                    {
                        DataSource = medicineData.Tables[0],
                        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                        Location = new Point(40, currentY),
                        Size = new Size(printPanel.Width - 80, 200),
                        AllowUserToAddRows = false,
                        ReadOnly = true,
                        ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
                        {
                            Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold),
                            ForeColor = Color.Black,
                            BackColor = Color.LightGray
                        },
                        DefaultCellStyle = new DataGridViewCellStyle
                        {
                            Font = new System.Drawing.Font("Arial", 12, FontStyle.Regular),
                            ForeColor = Color.Black,
                            BackColor = Color.White
                        }
                    };
                    gridView.CellFormatting += GridView_CellFormatting;

                    //printPanel.Controls.Add(gridView);
                    printPanel.Controls.Add(gridView);
                    currentY += gridView.Height + 20;
                }
                else
                {
                    AddLabel("No prescribed medicines found.", ref currentY);
                }
            }
            else
            {
                AddLabel("No prescription details found.", ref currentY);
            }
        }
        private void GridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView gridView = sender as DataGridView;

            if (gridView != null && gridView.Columns[e.ColumnIndex].Name == "usage" && e.Value != null)
            {
                string originalValue = e.Value.ToString();
                string formattedValue = TranslateUsageToBars(originalValue);
                e.Value = formattedValue; // Set the formatted value for display
                e.FormattingApplied = true; // Indicate that formatting has been applied
            }
        }

        // Helper method to add labels dynamically
        private void AddLabel(string text, ref int currentY)
        {
            Label label = new Label
            {
                Text = text,
                Font = new System.Drawing.Font("Arial", 12, FontStyle.Regular),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point(40, currentY)
            };
            printPanel.Controls.Add(label);
            currentY += 25; // Space between labels
        }
        private void AddLabel1(string text, ref int currentY)
        {
            Label label = new Label
            {
                Text = text,
                Font = new System.Drawing.Font("Arial", 12, FontStyle.Regular),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point(500, currentY)
            };
            printPanel.Controls.Add(label);
            currentY += 25; // Space between labels
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

        private int DisplayData(DataSet ds, Panel panel1, int startY, string sectionTitle)
        {
            int sectionSpacing = 40;

            // Section Title
            Label titleLabel = new Label()
            {
                Text = sectionTitle,
                Location = new Point(40, startY),
                AutoSize = true,
                Font = new System.Drawing.Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.DimGray,
            };
            panel1.Controls.Add(titleLabel);
            startY += sectionSpacing;

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                // Create a DataGridView
                DataGridView gridView = new DataGridView()
                {
                    DataSource = ds.Tables[0],
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    Location = new Point(40, startY),
                    Size = new Size(panel1.Width - 80, 200), // Adjust height as needed
                    AllowUserToAddRows = false,
                    ReadOnly = true,
                    ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle()
                    {
                        Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold),
                        ForeColor = Color.Black,
                        BackColor = Color.LightGray
                    },
                    DefaultCellStyle = new DataGridViewCellStyle()
                    {
                        Font = new System.Drawing.Font("Arial", 12, FontStyle.Regular),
                        ForeColor = Color.Black,
                        BackColor = Color.White
                    },
                };

                panel1.Controls.Add(gridView);
                startY += gridView.Height + sectionSpacing; // Adjust for the next section
            }
            else
            {
                // No data available
                Label noDataLabel = new Label()
                {
                    Text = "No data available.",
                    Location = new Point(40, startY),
                    AutoSize = true,
                    Font = new System.Drawing.Font("Arial", 12, FontStyle.Italic),
                    ForeColor = Color.Gray
                };
                panel1.Controls.Add(noDataLabel);
                startY += sectionSpacing;
            }

            return startY;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
