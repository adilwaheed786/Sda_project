using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;

namespace Management
{
    public partial class Signup : Form
    {

        string mycon = @"Data Source=DESKTOP-7BNIILF\SQLEXPRESS;Initial Catalog=final;Integrated Security=True";
        Customers cus = new Customers();
        public Signup()
        {
            InitializeComponent();
        }
        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lo = new Login();
            lo.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            
                if (txtname.Text == "")
                {
                    MessageBox.Show("Please Enter UserName");
                }
                else if (txtpass.Text == "")
                {
                    MessageBox.Show("Please Enter Password");
                }
                else if (richTextBox1.Text == "")
                {
                    MessageBox.Show("Please Enter Address");
                }
                else if (textBox5.Text == "")
                {
                    MessageBox.Show("Please Enter Contact");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Please Enter City");
                }
                else if (comboBox1.Text == "")
                {
                    MessageBox.Show("Please Select Gender");
                }
                else
                {
                    cus.name = txtname.Text;
                    cus.Address = richTextBox1.Text;
                    cus.ContactNo = textBox5.Text;
                    cus.city = textBox2.Text;
                    cus.gender = comboBox1.SelectedItem.ToString();
                    cus.membership = textBox1.Text;
                    cus.password = txtpass.Text;
       
                    var success = cus.Insert(cus);
                    if (success)
                    {
                        clear();
                        MessageBox.Show("Employee has been added successfully");
                    }
                    else
                        MessageBox.Show("Error occured. Please try again...");

                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
                throw;
            }
          
            
        }
        public void clear()
        {
         
            txtname.Text = "";
            richTextBox1.Text = "";
            txtpass.Text = "";
            textBox5.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            textBox1.Text = "";
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
    
}
