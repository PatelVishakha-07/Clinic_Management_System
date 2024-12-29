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
                Location = new Point(10, 620)
            };
            printButton.Click += PrintButton_Click;

            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            Controls.Add(printPanel);
            printPanel.Dock = DockStyle.Fill;
            printPanel.Controls.Add(printButton);
            pictureBox1.Dock= DockStyle.Top;
            printPanel.Controls.Add(pictureBox1);

            Size = new Size(500, 700);
            Text = "Print Report";
        }

        private void Report_Load(object sender, EventArgs e)
        {
            int currentY = 100;

            // Clinic Title
            //currentY += 50;
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
                currentY += 10; // Extra space
            }

            // Fetch prescription details
            string prescriptionQuery = $"SELECT * FROM prescription WHERE patient_id={patientId} ORDER BY prescription_date DESC LIMIT 1";
            DataSet prescriptionData = dbclass.Getdata(prescriptionQuery);

            if (prescriptionData != null && prescriptionData.Tables[0].Rows.Count > 0)
            {
                DataRow prescriptionRow = prescriptionData.Tables[0].Rows[0];

                // Display prescription details as labels
                presLabel($"Prescription: {prescriptionRow["prescription"]}", ref currentY);
                //  AddLabel($"Prescription ID: {prescriptionRow["prescription_id"]}", ref currentY);
                AddLabel1($"Date: {Convert.ToDateTime(prescriptionRow["prescription_date"]).ToString("dd/MM/yyyy HH:mm")}", ref currentY1);
                AddLabel1($"Disease: {prescriptionRow["disease"]}", ref currentY1);

                //AddLabel1($"Prescription: {prescriptionRow["prescription"]}", ref currentY1);
                
                // AddLabel($"Charges: Rs. {prescriptionRow["charges"]}", ref currentY);
                AddLabel1($"Total Charge: Rs. {prescriptionRow["total_charge"]}", ref currentY1);

                currentY += 15; // Extra space

                // Fetch prescribed medicines in DataGridView format
                //string medicineQuery = $"SELECT medicine_name AS 'Medicine', dosage AS 'Dosage', frequency AS 'Frequency', duration AS 'Duration' FROM Prescribed_Medicine WHERE prescription_id={prescriptionRow["prescription_id"]}";
                string medicineQuery = $"select medicine_name,quantity,usage from prescribed_medicine where prescription_id={prescriptionRow["prescription_id"]}";
                DataSet medicineData = dbclass.Getdata(medicineQuery);

                if (medicineData != null && medicineData.Tables[0].Rows.Count > 0)
                {
                    Label medicinesLabel = new Label
                    {
                        Text = "Prescribed Medicines",
                        Font = new System.Drawing.Font("Arial", 11, FontStyle.Bold),
                        ForeColor = Color.Black,
                        AutoSize = true,
                        Location = new Point(5, currentY)
                    };
                    printPanel.Controls.Add(medicinesLabel);
                    currentY += 30;

                    // Create and display DataGridView
                    DataGridView gridView = new DataGridView
                    {
                        DataSource = medicineData.Tables[0],
                        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                        Location = new Point(10, currentY),
                        Size = new Size(printPanel.Width - 20, 300),
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

        private void presLabel(string text, ref int currentY)
        {
            //Label label = new Label
            //{
            //    Text = text,
            //    Font = new System.Drawing.Font("Arial", 11, FontStyle.Regular),
            //    ForeColor = Color.Black,
            //    AutoSize = false,
            //    Width = printPanel.Width - 40,
            //    Location = new Point(3, currentY),
            //    //MaximumSize = new Size(printPanel.Width - 40, 0),
            //    TextAlign = ContentAlignment.TopLeft
            //};
            //Size textSize = TextRenderer.MeasureText(text, label.Font, new Size(label.Width, int.MaxValue));

            //// Set the height of the label based on measured height
            //label.Height = textSize.Height;
            //printPanel.Controls.Add(label);
            //currentY = label.Height + 5;

            TextBox richTextBox = new TextBox
            {
                Text = text,
                Font = new System.Drawing.Font("Arial", 9, FontStyle.Regular),
                ForeColor = Color.Black,
                ReadOnly = true,  // Prevent user editing
                BorderStyle = BorderStyle.None,  // Make it look like a Label
                BackColor = printPanel.BackColor,  // Match the panel's background
                Width = printPanel.Width-10,
                Height=60,
                Location = new Point(3, currentY),
                Multiline = true,
                WordWrap = true,
                ScrollBars = ScrollBars.None,
            };

            printPanel.Controls.Add(richTextBox);

            // Update currentY for the next control
            currentY += richTextBox.Height + 3;
        }


        // Helper method to add labels dynamically
        private void AddLabel(string text, ref int currentY)
        {
            Label label = new Label
            {
                Text = text,
                Font = new System.Drawing.Font("Arial", 11, FontStyle.Regular),
                ForeColor = Color.Black,
                AutoSize = true,
                
                Location = new Point(3, currentY),
                
                TextAlign = ContentAlignment.TopLeft
            };
            printPanel.Controls.Add(label);
            currentY += 23; // Space between labels
        }
        private void AddLabel1(string text, ref int currentY)
        {
            Label label = new Label
            {
                Text = text,
                Font = new System.Drawing.Font("Arial", 11, FontStyle.Regular),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point(255, currentY)
            };
            printPanel.Controls.Add(label);
            currentY += 23; // Space between labels
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
