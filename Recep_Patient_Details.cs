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
    public partial class Recep_Patient_Details : UserControl
    {
        int patient_id, pres_id, pres_med_id;
        public Recep_Patient_Details(int patient_id, int pres_id, int pres_med_id)
        {
            InitializeComponent();
            this.patient_id = patient_id;
            this.pres_id = pres_id;
            this.pres_med_id = pres_med_id; 
        }

        private void Recep_Patient_Details_Load(object sender, EventArgs e)
        {

        }
    }
}
