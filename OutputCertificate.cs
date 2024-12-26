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
            label1.Text = $"This is to Certify {name} is/was under my treatment for {disease} from {fromDate} to {toDate}." +
                $"He/She is fully fit to resume duty";
        }
    }
}
