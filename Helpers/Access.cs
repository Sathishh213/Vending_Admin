﻿using log4net;
using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Admin.Helpers
{
    public class Access
    {


        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        //private string ConnectionString = "server=127.0.0.1;user id=nsathishkumar;password=Sathish@21;database=product_store";
        //private string ConnectionString = "SERVER=" + "DESKTOP-6M6VDPQ" + "; PORT = 3306 ;" + "DATABASE=" + "product_store" + ";" + "UID=" + "nsathishkumar" + ";" + "PASSWORD=" + "Sathish@21" + ";";
        public string ConnectionString { get; set; }

        public Access()
        {
            ConnectionString = "SERVER=" + "127.0.0.1" + "; PORT = 3306 ;" + "DATABASE=" + "product_store" + ";" + "UID=" + "nsathishkumar" + ";" + "PASSWORD=" + "Sathish@21" + ";";
        }
        public Access(string hostname)
        {
          ConnectionString = "SERVER=" + hostname + "; PORT = 3306 ;" + "DATABASE=" + "product_store" + ";" + "UID=" + "nsathishkumar" + ";" + "PASSWORD=" + "Sathish@21" + ";";
        }
        public string GetDeviceLoginId()
        {
            string macLast6 = GetDeviceMac();
            if (macLast6 != null)
            {
                int intValue = int.Parse(macLast6, System.Globalization.NumberStyles.HexNumber);
                return intValue.ToString("D6").Substring(0, 6);
            }
            return "000000";
        }

        private string GetDeviceMac()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Only consider Ethernet network interfaces
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    string mac = nic.GetPhysicalAddress().ToString();
                    return mac.Substring(mac.Length - 6);
                }
            }
            return null;
        }


        public void backup(string file)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportInfo.EnableEncryption = true;
                            mb.ExportInfo.EncryptionPassword = "Creative";
                            mb.ExportInfo.AddCreateDatabase = true;
                            mb.ExportToFile(file);
                            conn.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }


        public int ExecuteCmd(string query)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                return i;
            }
        }

        public string ExecuteCmd(MySqlCommand cmd)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {

                if (cmd.Connection == null)
                    cmd.Connection = con;
                con.Open();
                string i = cmd.ExecuteNonQuery().ToString();
                con.Close();
                return i;
            }
        }

        public string GetValue(string query)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                string i = Convert.ToString(cmd.ExecuteScalar());
                con.Close();
                return i;
            }
        }

        public DataTable GetTable(string query)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                con.Open();
                DataTable ds = new DataTable();
                da.Fill(ds);
                con.Close();
                return ds;
            }
        }

        //public string o_ExecuteCmd(string query)
        //{
        //    string i = "";
        //    using (MySqlConnection con = new MySqlConnection(Properties.Settings.Default.s_con))
        //    {
        //        con.Open();
        //        using (MySqlCommand cmd = new MySqlCommand(query, con))
        //        {
        //            i = cmd.ExecuteNonQuery().ToString();
        //            con.Close();
        //            return i;
        //        }
        //    }
        //}

        //public string o_GetValue(string query)
        //{
        //    string i = "";
        //    using (MySqlConnection con = new MySqlConnection(Properties.Settings.Default.s_con))
        //    {
        //        con.Open();
        //        using (MySqlCommand cmd = new MySqlCommand(query, con))
        //        {
        //            i = Convert.ToString(cmd.ExecuteScalar());
        //            con.Close();
        //            return i;
        //        }
        //    }
        //}

        //public DataSet o_GetDataSet(string query)
        //{
        //    using (MySqlConnection con = new MySqlConnection(Properties.Settings.Default.s_con))
        //    {
        //        con.Open();
        //        using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
        //        {
        //            DataSet ds = new DataSet();
        //            da.Fill(ds);
        //            con.Close();
        //            return ds;
        //        }
        //    }
        //}

        //public DataTable o_GetTable(string query)
        //{
        //    using (MySqlConnection con = new MySqlConnection(Properties.Settings.Default.s_con))
        //    {
        //        con.Open();
        //        using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
        //        {
        //            DataTable ds = new DataTable();
        //            da.Fill(ds);
        //            con.Close();
        //            return ds;
        //        }
        //    }
        //}

        public int ExecuteCmd(string con_str, string query)
        {
            using (MySqlConnection con = new MySqlConnection(con_str))
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                return i;
            }
        }



        public int ExecuteCmd(string con_str, MySqlCommand cmd)
        {
            using (MySqlConnection con = new MySqlConnection(con_str))
            {

                if (cmd.Connection == null)
                    cmd.Connection = con;
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                return i;
            }
        }


        public int ExecuteCmd(string con_str, MySqlParameter[] param, string procedure)
        {
            using (MySqlConnection con = new MySqlConnection(con_str))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(procedure, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param);
                int i = cmd.ExecuteNonQuery();
                con.Close();
                return i;
            }
        }

        public object GetValue(string con_str, string query)
        {
            using (MySqlConnection con = new MySqlConnection(con_str))
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                object obj = cmd.ExecuteScalar();
                con.Close();
                return obj;
            }
        }

        public object GetValue(string con_str, MySqlCommand cmd)
        {
            using (MySqlConnection con = new MySqlConnection(con_str))
            {
                if (cmd.Connection == null)
                    cmd.Connection = con;
                con.Open();
                object obj = cmd.ExecuteScalar();
                con.Close();
                return obj;
            }
        }

        public object GetValue(string con_str, MySqlParameter[] param, string procedure)
        {
            using (MySqlConnection con = new MySqlConnection(con_str))
            {
                MySqlCommand cmd = new MySqlCommand(procedure, con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param);
                object obj = cmd.ExecuteScalar();
                con.Close();
                return obj;
            }
        }

        public DataTable GetTable(string con_str, string query)
        {
            using (MySqlConnection con = new MySqlConnection(con_str))
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable ds = new DataTable();
                da.Fill(ds);
                con.Close();
                return ds;
            }
        }


    }
}
