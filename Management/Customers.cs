using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Management
{
    class Customers
    {
        private static string myConn = @"Data Source=DESKTOP-7BNIILF\SQLEXPRESS;Initial Catalog=final;Integrated Security=True";
        public int Cust_id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public string Date { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string city { get; set; }
        public string password { get; set; }
        public string membership { get; set; }

        
        private const string InsertQuery = "Insert Into Customer(Cust_Name,Address,Phone,city,gender,member_ship,Password) Values (@name, @Address, @ContactNo, @city,@gender,@membership,@password)";
      
       
       

        public bool Insert(Customers cus)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, con))
                {
                    // com.Parameters.AddWithValue("@EmployeeID", employee.EmpId);
                    //@name, @Address, @ContactNo, @city,@gender,@membership,@password
                    com.Parameters.AddWithValue("@name", cus.name);
                    com.Parameters.AddWithValue("@Address",cus.Address );
                    com.Parameters.AddWithValue("@ContactNo",cus.ContactNo );
                    com.Parameters.AddWithValue("@city", cus.city);
                    com.Parameters.AddWithValue("@gender",cus.gender );
                    com.Parameters.AddWithValue("@membership", cus.membership);
                    com.Parameters.AddWithValue("@password",cus.password );
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }       
    }
}
