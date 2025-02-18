﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Xml.Linq;

namespace Clinic_Management_System
{
    public partial class AddPatients : UserControl
    {
        databaseclass dbclass = new databaseclass();
        string namePattern = @"^[A-Za-z]+(?: [A-Za-z]+)*$";
        string agePattern = @"^\d{1,3}$";
        string contactNoPattern = @"^[6-9]\d{9}$";
        string addressPattern = @"^[A-Za-z0-9\s,.-]+$";
        //string changingname;
        public AddPatients()
        {
            InitializeComponent();
         //   changingname = "";
           // txtName.TextChanged += txtName_TextChanged;
        }

        private void AddPatients_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Male";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string age = txtAge.Text;
            string contact = txtContact.Text;
            string gender = comboBox1.SelectedItem?.ToString() ?? string.Empty;
            string address = txtaddress.Text;


            if (!string.IsNullOrEmpty(name) &&
                !string.IsNullOrEmpty(age) &&
                !string.IsNullOrEmpty(contact) &&
                !string.IsNullOrEmpty(address) &&
                !string.IsNullOrEmpty(gender))
            {
                lblall.Visible = false;


                lblname.Visible = !Regex.IsMatch(name, namePattern);


                lblage.Visible = !Regex.IsMatch(age, agePattern);


                lblph_no.Visible = !Regex.IsMatch(contact, contactNoPattern);


                lbladd.Visible = !Regex.IsMatch(address, addressPattern);
                if (!lblall.Visible && !lbladd.Visible && !lblage.Visible && !lblname.Visible && !lblph_no.Visible)
                {
                    string query = $"insert into Patients(name,age,gender,contact_no,address) values('{name}',{int.Parse(age)},'{gender}','{contact}','{address}');";
                    dbclass.databaseoperations(query);
                    MessageBox.Show("Record Inserted Successfully");
                    AddPrescription prescription = new AddPrescription();
                    query = $"select * from Patients where name='{name}' and age={int.Parse(age)} and gender='{gender}' and contact_no='{contact}' and address='{address}';";
                    DataSet ds = dbclass.Getdata(query);
                    int patientId = int.Parse(ds.Tables[0].Rows[0]["patient_id"].ToString());
                    prescription.getPatientDetails(patientId, name, address, int.Parse(age), contact, gender);
                    Patients patients = this.FindForm() as Patients;
                    patients.ShowContent(prescription);
                    ClearText();
                }
            }
            else
            {
                lblall.Visible = true;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }
        private void ClearText()
        {
            txtaddress.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtName.Text = string.Empty;
            comboBox1.SelectedItem = "Male";
        }

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

