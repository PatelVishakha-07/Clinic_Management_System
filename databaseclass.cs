using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Clinic_Management_System
{
    internal class databaseclass
    {
       NpgsqlConnection conn;
       NpgsqlCommand cmd;
       NpgsqlDataAdapter dataAdapter;
        DataSet ds;
        public databaseclass()
        {
            conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=2002;Database=Clinic_Management;");  
            conn.Open();
        }
        public DataSet Getdata(string query)
        {
            if (conn.State != ConnectionState.Open)
            {  conn.Open();
            }
            if (!string.IsNullOrEmpty(query))
            {
                dataAdapter = new NpgsqlDataAdapter(query, conn);
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
                cmd=new NpgsqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
