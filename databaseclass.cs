using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Npgsql;

namespace Clinic_Management_System
{
    internal class databaseclass
    {
        NpgsqlConnection conn;
        NpgsqlCommand cmd;
        NpgsqlDataAdapter dataAdapter;
        DataSet ds;
        string configPath = "dbconfig.txt";

        public databaseclass()
        {
            TryInitializeConnection();
        }

        private void TryInitializeConnection()
        {
            string ipAddress = GetSavedIPAddress();

            // First attempt using saved/default IP
            if (!TryConnect(ipAddress))
            {
                // Only show dialog box after initial failure
                while (true)
                {
                    string newIp = PromptForIPAddress();
                    if (string.IsNullOrWhiteSpace(newIp))
                    {
                        MessageBox.Show("No IP address provided. The application will now close.", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Environment.Exit(0);
                    }

                    // Try new IP
                    if (TryConnect(newIp))
                    {
                        File.WriteAllText(configPath, newIp);
                        break; // success
                    }
                    else
                    {
                        MessageBox.Show("Connection failed. Please try again.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private bool TryConnect(string ip)
        {
            try
            {
                string connString = $"Host={ip};Port=5432;Username=postgres;Password=2002;Database=Clinic_Management;";
                conn = new NpgsqlConnection(connString);
                conn.Open();
                conn.Close(); // test connection, close it for now
                return true;
            }
            catch
            {
                return false;
            }
        }

        private string GetSavedIPAddress()
        {
            try
            {
                if (File.Exists(configPath))
                {
                    var ip = File.ReadAllText(configPath).Trim();
                    if (!string.IsNullOrWhiteSpace(ip))
                        return ip;
                }
            }
            catch { }

            return "localhost"; // fallback
        }

        public string GetConnectionString()
        {
            string ipAddress = GetSavedIPAddress();
            return $"Host={ipAddress};Port=5432;Username=postgres;Password=2002;Database=Clinic_Management;";
        }

        private string PromptForIPAddress()
        {
            return Microsoft.VisualBasic.Interaction.InputBox("Enter Server IP Address:", "Database Connection Failed", "127.0.0.1").Trim();
        }

        public DataSet Getdata(string query)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

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
                conn.Open();

            if (!string.IsNullOrEmpty(query))
            {
                cmd = new NpgsqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
