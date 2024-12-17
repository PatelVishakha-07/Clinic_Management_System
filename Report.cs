using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            leftPanel.Controls.Clear();
            dashboard.Dock = DockStyle.Left;
            leftPanel.Controls.Add(dashboard);           

        }

       

    }
}
