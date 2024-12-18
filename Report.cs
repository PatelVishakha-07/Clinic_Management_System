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
        public Report()
        {
            InitializeComponent();
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
            

        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            // Trigger the print dialog
            PrintDialog printDialog = new PrintDialog
            {
                Document = printDocument
            };

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
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

       

    }
}
