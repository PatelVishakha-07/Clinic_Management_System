using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class CertificateInput : UserControl
    {
        databaseclass dbClass = new databaseclass();
        public CertificateInput()
        {
            InitializeComponent();
        }

        private void CertificateInput_Load(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            lblDiseaseError.Visible = false;
            lblNameError.Visible = false;
            string name = txtName.Text;
            string disease = txtDisease.Text;
            string fromDate = dtpFromDate.Text.ToString();
            string toDate = dtpToDate.Text;
            string resumeDate = dtpResume.Text;

            if (name == "" && disease == "")
            {
                lblDiseaseError.Visible = true;
                lblNameError.Visible = true;
            }
            else if (name == "")
            {
                lblNameError.Visible = true;
            }
            else if (disease == "")
            {
                lblDiseaseError.Visible = true;
            }
            else
            {
                lblDiseaseError.Visible = false;
                lblNameError.Visible = false;
                //string formattedFromDate = fromDate.ToString("yyyy-MM-dd");

                DateTime fromDateTime = DateTime.Parse(dtpFromDate.Text);
                string formattedFromDate = fromDateTime.ToString("yyyy-MM-dd");

                DateTime ToDateTime = DateTime.Parse(dtpToDate.Text);
                string formattedToDate = ToDateTime.ToString("yyyy-MM-dd");

                DateTime resumeDateTime = DateTime.Parse(dtpResume.Text);
                string formattedResumeDate = resumeDateTime.ToString("yyyy-MM-dd");

                string inputQuery = $"insert into certificate(name,disease, from_Date, to_Date, resume_date) values " +
                    $"('{name}', '{disease}', '{formattedFromDate}', '{formattedToDate}', '{formattedResumeDate}');";
                dbClass.databaseoperations(inputQuery);
                CertificateOutput certificateOutput = new CertificateOutput(name, disease, formattedFromDate, formattedToDate, formattedResumeDate);
                certificateOutput.ShowDialog();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtDisease.Text = string.Empty;
            dtpFromDate.Text = DateTime.Now.ToString();
            dtpToDate.Text = DateTime.Now.ToString();
            dtpResume.Text = DateTime.Now.ToString();
        }
    }
}
