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
                dataGridView1.Columns["rest_from_Date"].DataPropertyName = "resume_Date";
                dataGridView1.Columns["rest_to_Date"].DataPropertyName = "resume_Date";
                dataGridView1.Columns["resume_Date"].DataPropertyName = "resume_Date";
                dataGridView1.Columns["today_date"].DataPropertyName = "today_date";
                dataGridView1.Columns["certificate_number"].DataPropertyName = "certificate_number";
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

            string rest_from_date = dataGridView1.Rows[e.RowIndex].Cells["rest_from_Date"].Value.ToString();
            string rest_to_date = dataGridView1.Rows[e.RowIndex].Cells["rest_to_Date"].Value.ToString();

            string resume_Date = dataGridView1.Rows[e.RowIndex].Cells["resume_Date"].Value.ToString();

            string today_date= dataGridView1.Rows[e.RowIndex].Cells["today_date"].Value.ToString();
            string certificate_number= dataGridView1.Rows[e.RowIndex].Cells["certificate_number"].Value.ToString();

            DateTime resumeDateTime = DateTime.Parse(resume_Date);
            string formattedResumeDate = resumeDateTime.ToString("yyyy-MM-dd");

            DateTime fromDateTime = DateTime.Parse(from_Date);
            string formattedFromDate = fromDateTime.ToString("yyyy-MM-dd");

            DateTime toDateTime = DateTime.Parse(to_Date);
            string formattedToDate = toDateTime.ToString("yyyy-MM-dd");

            DateTime restToDateTime = DateTime.Parse(rest_to_date);
            string formattedRestToDate = restToDateTime.ToString("yyyy-MM-dd");

            DateTime restFromDateTime = DateTime.Parse(rest_from_date);
            string formattedrestFromDate = restFromDateTime.ToString("yyyy-MM-dd");

            CertificateOutput certificate = new CertificateOutput(name,disease,formattedFromDate,formattedToDate,formattedrestFromDate, formattedRestToDate, formattedResumeDate,certificate_number,today_date);
            certificate.ShowDialog();
        }
    }
}
