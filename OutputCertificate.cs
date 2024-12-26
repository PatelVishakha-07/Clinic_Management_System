using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class OutputCertificate : UserControl
    {
        string name, disease, fromDate, toDate;
        public OutputCertificate(string n, string d, string fd, string td)
        {
            InitializeComponent();
            name = n;
            disease = d;
            fromDate = fd;
            toDate = td;
        }

        private void OutputCertificate_Load(object sender, EventArgs e)
        {
            string dateTimePart = DateTime.Now.ToString("yyyyMMddHHmmss"); // Current date and time
            string randomPart = new Random().Next(1000, 9999).ToString();

            lblNo.Text = "Certificate No. : " + dateTimePart + randomPart;
            label1.Text = $"This is to Certify that {name} \n\n" +
                $"is/was under my treatment for {disease} \n\n" +
                $"from {fromDate} to {toDate}.\n\n" +
                $"He/She is fully fit to resume duty";
        }
    }
}
