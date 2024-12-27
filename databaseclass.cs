using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace Clinic_Management_System
{
    internal class databaseclass
    {
       OleDbConnection conn;
       OleDbCommand cmd;
        OleDbDataAdapter dataAdapter;
        DataSet ds;
        public databaseclass()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Application.StartupPath + "/Clinic_Management.mdb");  
            conn.Open();
        }
        public DataSet Getdata(string query)
        {
            if (conn.State != ConnectionState.Open)
            {  conn.Open();
            }
            if (!string.IsNullOrEmpty(query))
            {
                dataAdapter = new OleDbDataAdapter(query, conn);
                ds = new DataSet();
                dataAdapter.Fill(ds);
                conn.Close();
                return ds;
            }
            return null;
        }
        public void databaseoperations(string query)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            if (!string.IsNullOrEmpty(query))
            {
                cmd=new OleDbCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
