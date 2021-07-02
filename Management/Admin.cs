using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Management
{
    public partial class Admin : Form
    {
        private static string myConn = @"Data Source=DESKTOP-7BNIILF\SQLEXPRESS;Initial Catalog=final;Integrated Security=True";
        public Admin()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void adsignin_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (txtnamead.Text == "")
                {
                    MessageBox.Show("Please Enter UserName");
                }
                else if (txtpassad.Text == "")
                {
                    MessageBox.Show("Please Enter Password");
                }
                else 
                {
                    SqlConnection con =new  SqlConnection(myConn);
                    con.Open();
                    string query = "select * from Admin where username= '" + txtnamead.Text.Trim() + "'and Password='" + txtpassad.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count==1)
                    {
                        AdminPanel a = new AdminPanel();
                        a.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Correct Username and Password!!!");

                    }

                }
               
             
            }
            catch (Exception  )
            {
               
                throw;
            }
            
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void txtnamead_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
