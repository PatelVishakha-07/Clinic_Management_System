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
    public partial class CertificateShow : UserControl
    {
        databaseclass dbClass=new databaseclass();
        public CertificateShow()
        {
            InitializeComponent();
        }

        private void CertificateShow_Load(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void PopulateGridView()
        {
            DataSet ds = new DataSet();
            string query = "select * from certificate;";
            ds = dbClass.Getdata(query);
            if (ds != null && ds.Tables.Count > 0)
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns["name"].DataPropertyName = "name";
                dataGridView1.Columns["disease"].DataPropertyName = "disease";
                dataGridView1.Columns["from_Date"].DataPropertyName = "from_Date";
                dataGridView1.Columns["to_Date"].DataPropertyName = "to_Date";
                dataGridView1.DataSource = ds.Tables[0];

                if (!dataGridView1.Columns.Contains("certificate_id"))
                {
                    var idColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "certificate_id",
                        DataPropertyName = "certificate_id",
                        Visible = false
                    };
                    dataGridView1.Columns.Add(idColumn);
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
            string disease = dataGridView1.Rows[e.RowIndex].Cells["disease"].Value.ToString();
            string from_Date = dataGridView1.Rows[e.RowIndex].Cells["from_Date"].Value.ToString();
            string to_Date = dataGridView1.Rows[e.RowIndex].Cells["to_Date"].Value.ToString();

            CertificateOutput certificate = new CertificateOutput(name,disease,from_Date,to_Date);
            certificate.ShowDialog();
        }
    }
}
