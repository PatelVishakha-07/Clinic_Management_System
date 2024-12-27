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

namespace Clinic_Management_System
{
    public partial class CertificateOutput : Form
    {
        string name, disease, fromDate, toDate;
        Button printButton;
        PrintDocument printDocument;
        public CertificateOutput(string n, string d, string fd, string td)
        {
            InitializeComponent();
            name = n;
            disease = d;
            fromDate = fd;
            toDate = td;

            printButton = new Button
            {
                Text = "Print Report",
                Location = new Point(900, 740)
            };

            printButton.Click += PrintButton_Click;

            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
            Controls.Add(printButton);
            printButton.Anchor=AnchorStyles.Right & AnchorStyles.Bottom;

        }

        private void CertificateOutput_Load(object sender, EventArgs e)
        {
            string dateTimePart = DateTime.Now.ToString("yyyyMMddHHmmss"); 
            string randomPart = new Random().Next(1000, 9999).ToString();

            lblNo.Text = "Certificate No. : " + dateTimePart + randomPart;
            lblName.Text = name;
            lblDisease.Text = disease;
            lblFromDate.Text = fromDate;
            lblToDate.Text = toDate;
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
            Bitmap bitmap = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, panel1.Width, panel1.Height));

            // Draw the bitmap on the paper
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

    }
}
