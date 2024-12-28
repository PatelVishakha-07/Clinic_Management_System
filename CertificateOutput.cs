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
        string name, disease, fromDate, toDate, resumeDate, rest_form_date, rest_to_date, certificate_number, today_date;
        Button printButton;
        PrintDocument printDocument;
        public CertificateOutput(string n, string d, string tfd, string t_td, string rest_from_d, string rest_to_d, string resume_d, string certificate_no, string today_d)
        {
            InitializeComponent();
            name = n;
            disease = d;
            fromDate = tfd;
            toDate = t_td;
            resumeDate = resume_d;
            rest_form_date = rest_from_d;
            rest_to_date = rest_to_d;
            certificate_number = certificate_no;
            today_date = today_d;

            printButton = new Button
            {
                Text = "Print Report",
                Location = new Point(900, 800)
            };

            printButton.Click += PrintButton_Click;

            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
            Controls.Add(printButton);
            printButton.Anchor=AnchorStyles.Right & AnchorStyles.Bottom;

        }

        private void CertificateOutput_Load(object sender, EventArgs e)
        {
            

            lblNo.Text = "Certificate No. : " + certificate_number;
            lblName.Text ="__" + name + "___________";
            lblDisease.Text ="__" + disease + "____";
            lblFromDate.Text ="__" + fromDate + "__";
            lblToDate.Text = "__" + toDate + "__ .";
            lblResumeDate.Text = "__" + resumeDate + "__ .";
            lblRestTo.Text = "__" + rest_to_date + "__ .";
            lblRestFrom.Text = "__" + rest_form_date + "__";

            lblCurrentDate.Text = "Date: " + today_date;
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
