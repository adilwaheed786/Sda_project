using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Management
{
    class products
    {


        private static string myConn = @"Data Source=DESKTOP-7BNIILF\SQLEXPRESS;Initial Catalog=final;Integrated Security=True";
        public int id { get; set; }
        public int CatId { get; set; }
        public string CatName { get; set; }
        public string ProdName { get; set; }
        public string Decp { get; set; }
        public int price { get; set; }
        public int sid { get; set; }
        public int stock { get; set; }
           // @CatId,@CatName,@ProdName,@Decp,@price,@sid,@stock
        private const string SelectQuery = "Select * from Products";
        private const string InsertQuery = "Insert Into Products (Cat_id,Cat_name,Pr_name,Pr_description,Price,Supplier_id,Stock) Values  (@CatId,@CatName,@ProdName,@Decp,@price,@sid,@stock)";
        private const string UpdateQuery = "Update Products Set Cat_id=@CatId,Cat_name=@Catname,Pr_name=@prodName,Pr_description=@Decp,Price=@price,Supplier_id=@sid,Stock=@stock where Product_id=@id";
        private const string DeleteQuery = "Delete from Products where Product_id=@id";
       

        public DataTable GetProducts()
        {
            var datatable = new DataTable();
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(SelectQuery, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        adapter.Fill(datatable);
                    }
                }
            }
            return datatable;
        }
        public DataTable GetProductswithid(string id)
        {
            var datatable = new DataTable();
            using (SqlConnection con = new SqlConnection(myConn))
            {
                string Id = "Select * from Products where Product_id='" + id + "'";
                con.Open();
                using (SqlCommand com = new SqlCommand(Id, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        adapter.Fill(datatable);
                    }
                }
            }
            return datatable;
        }

        public bool Insert(products p)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, con))
                {
                    // com.Parameters.AddWithValue("@EmployeeID", employee.EmpId);
                   // @CatId,@CatName,@ProdName,@Decp,@price,@sid,@stock
                    com.Parameters.AddWithValue("@CatId", p.CatId);
                    com.Parameters.AddWithValue("@CatName", p.CatName);
                    com.Parameters.AddWithValue("@ProdName", p.ProdName);
                    com.Parameters.AddWithValue("@Decp", p.Decp);
                    com.Parameters.AddWithValue("@price", p.price);
                    com.Parameters.AddWithValue("@sid", p.sid);
                    com.Parameters.AddWithValue("@stock", p.stock);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        public bool Update(products p)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(UpdateQuery, con))
                {

                    com.Parameters.AddWithValue("@CatId", p.CatId);
                    com.Parameters.AddWithValue("@CatName", p.CatName);
                    com.Parameters.AddWithValue("@ProdName", p.ProdName);
                    com.Parameters.AddWithValue("@Decp", p.Decp);
                    com.Parameters.AddWithValue("@price", p.price);
                    com.Parameters.AddWithValue("@sid", p.sid);
                    com.Parameters.AddWithValue("@stock", p.stock);
                    com.Parameters.AddWithValue("@id", p.id);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        public bool Delete(products p)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(DeleteQuery, con))
                {
                    com.Parameters.AddWithValue("@id", p.id);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }
    }
}

