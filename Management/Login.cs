using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sumayya;

namespace Management
{
    public partial class Login : Form
    {
        
        string myConn = "Data Source=DESKTOP-7BNIILF\\SQLEXPRESS;Initial Catalog=final;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
           
                   
        }       
      
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup up = new Signup();
            up.Show();
            this.Hide();
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home up = new Home();
            up.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string name = txtname.Text;
                string pass = txtpass.Text;
                               
                if (name == "")
                {
                    MessageBox.Show("Please Enter UserName");
                }
                else if (pass == "")
                {
                    MessageBox.Show("Please Enter Password");
                }
               else  
                {


                    SqlConnection con = new SqlConnection(myConn);
                    con.Open();
                    string query = "select Cust_Name,Password from Customer where Cust_name= '" + name + "'and Password='" + pass + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        Form1 a = new Form1();
                        a.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Correct Username and Password!!!");

                    }
                   con.Close();

                }
               
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
