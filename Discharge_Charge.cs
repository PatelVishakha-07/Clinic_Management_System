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
    public partial class Discharge_Charge : Form
    {
        public int DischargeAmount { get; private set; }
        public event Action<int> AmountConfirmed;

        public Discharge_Charge()
        {
            InitializeComponent();
        }


        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtamount.Text, out int amount))
            {
                DischargeAmount = amount;
                AmountConfirmed?.Invoke(DischargeAmount); 
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }
        }
    }

}
