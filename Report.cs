using System.Data;
using System.Drawing.Printing;


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
            int  currentY1=currentY;
            string patientQuery = $"SELECT * FROM patients WHERE patient_id={patientId}";
            DataSet patientData = dbclass.Getdata(patientQuery);

            if (patientData != null && patientData.Tables[0].Rows.Count > 0)
            {
                DataRow patientRow = patientData.Tables[0].Rows[0];

                AddLabel($"Patient Name: {patientRow["name"]}", ref currentY);
                AddLabel($"Age: {patientRow["age"]}   Gender: {patientRow["gender"]}", ref currentY);
                AddLabel($"Contact: {patientRow["contact_no"]}", ref currentY);
                AddLabel($"Address: {patientRow["address"]}", ref currentY);
                currentY += 10; 
            }

            string prescriptionQuery = $"SELECT * FROM prescription WHERE patient_id={patientId} ORDER BY prescription_date DESC LIMIT 1";
            DataSet prescriptionData = dbclass.Getdata(prescriptionQuery);

            if (prescriptionData != null && prescriptionData.Tables[0].Rows.Count > 0)
            {
                DataRow prescriptionRow = prescriptionData.Tables[0].Rows[0];
                presLabel($"Prescription: {prescriptionRow["prescription"]}", ref currentY);
                AddLabel1($"Date: {Convert.ToDateTime(prescriptionRow["prescription_date"]).ToString("dd/MM/yyyy HH:mm")}", ref currentY1);
                AddLabel1($"Disease: {prescriptionRow["disease"]}", ref currentY1);
                AddLabel1($"Total Charge: Rs. {prescriptionRow["total_charge"]}", ref currentY1);

                currentY += 15;
                string medicineQuery = $"select medicine_name,quantity,usage from prescribed_medicine where prescription_id={prescriptionRow["prescription_id"]}";
                DataSet medicineData = dbclass.Getdata(medicineQuery);

                if (medicineData != null && medicineData.Tables[0].Rows.Count > 0)
                {
                    //Label medicinesLabel = new Label
                    //{
                    //    Text = "Prescribed Medicines",
                    //    Font = new System.Drawing.Font("Arial", 11, FontStyle.Bold),
                    //    ForeColor = Color.Black,
                    //    AutoSize = true,
                    //    Location = new Point(5, currentY)
                    //};
                    //printPanel.Controls.Add(medicinesLabel);
                    //currentY += 30;

                    DataGridView gridView = new DataGridView
                    {
                        DataSource = medicineData.Tables[0],
                        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                        AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells,
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
                            BackColor = Color.White,
                            WrapMode = DataGridViewTriState.True 
                        }
                    };

                    gridView.CellFormatting += GridView_CellFormatting;
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
                e.Value = formattedValue; 
                e.FormattingApplied = true; 
            }
        }

        private void presLabel(string text, ref int currentY)
        {
          
            TextBox richTextBox = new TextBox
            {
                Text = text,
                Font = new System.Drawing.Font("Arial", 9, FontStyle.Regular),
                ForeColor = Color.Black,
                ReadOnly = true,  
                BorderStyle = BorderStyle.None, 
                BackColor = printPanel.BackColor,
                Width = printPanel.Width-10,
                Height=45,
                Location = new Point(3, currentY),
                Multiline = true,
                WordWrap = true,
                ScrollBars = ScrollBars.None,
            };

            printPanel.Controls.Add(richTextBox);
            currentY += richTextBox.Height + 3;
        }


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
            currentY += 23; 
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
            currentY += 23; 
        }
        private void PrintButton_Click(object sender, EventArgs e)
        {
            printButton.Visible = false;
            try
            {
                printDocument.Print(); 
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
                    return "| ";  
                case "BD":
                    return "| |"; 
                case "TD":
                    return "| | |"; 
                case "QD":
                    return "| | | |"; 
                default:
                    return usage; 
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
