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
    public partial class InputCertificate : UserControl
    {
        public InputCertificate()
        {
            InitializeComponent();
        }

        private void InputCertificate_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtDisease.Text = string.Empty;
            dtpFromDate.Text = DateTime.Now.ToString();
            dtpToDate.Text = DateTime.Now.ToString();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            string name=txtName.Text;
            string disease=txtDisease.Text;
            string fromDate=dtpFromDate.Text;
            string toDate=dtpToDate.Text;
            
            Certificate certificate = this.FindForm() as Certificate;
            certificate.ShowControl(new OutputCertificate(name, disease, fromDate, toDate));
        }
    }
}
