using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using WinFormsApp3;
using Management;
namespace Sumayya
{
    class DatabaseHelper
    {
      
            SqlConnection con;
            SqlCommand cmd;
            SqlDataAdapter sda;
            DataTable dt;
            public DatabaseHelper()
            {
                string connectionstring = @"Data Source=DESKTOP-7BNIILF\SQLEXPRESS;Initial Catalog=final;Integrated Security=True";
                con = new SqlConnection(connectionstring);
            }
            public bool insertupdatedelete(string query)
            {
            try
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    con.Close();
                    return true;
                }
                con.Close();
                return false;
            }
            catch (Exception exc)
            {

                Console.WriteLine("Error" + exc.Message);
                throw;
            
            }

            }
            public DataTable Retrieve(string query)
            {
                cmd = new SqlCommand(query, con);
                sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
                return new DataTable();
            }
        }
    }

