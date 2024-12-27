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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Clinic_Management_System
{
    public partial class CertificateOutput : Form
    {
        string name, disease, fromDate, toDate, resumeDate;
        Button printButton;
        PrintDocument printDocument;
        public CertificateOutput(string n, string d, string fd, string td, string rd)
        {
            InitializeComponent();
            name = n;
            disease = d;
            fromDate = fd;
            toDate = td;
            resumeDate = rd;

            printButton = new Button
            {
                Text = "Print Report",
                Location = new Point(900, 640)
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
            lblName.Text ="__" + name + "_______";
            lblDisease.Text ="__" + disease + "____";
            lblFromDate.Text ="__" + fromDate + "__";
            lblToDate.Text = "__" + toDate + "__";
            lblDate.Text = "__" + resumeDate + "__";

            lblCurrentDate.Text = "Date: " + DateTime.Now.ToString("yyyy-MM-dd");
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
