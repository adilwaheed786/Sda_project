using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Management
{
    public partial class Employee : Form
    {
       // private static string myConn = @"Data Source=DESKTOP-7BNIILF\SQLEXPRESS;Initial Catalog=final;Integrated Security=True";

        Employees employee = new Employees();
        int indexrow;
        public Employee()
        {
            InitializeComponent();
            dataGridView1.DataSource = employee.GetEmployees();
           
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please Enter EmployeeName..!!!");
                }
                else if (comboBox1.Text == "")
                {
                    MessageBox.Show("Please Select Employee Status...!!");
                }                          
                else if (textBox4.Text == "")
                {
                    MessageBox.Show("Please Enter Address....!");
                }
                else if (textBox5.Text == "")
                {
                    MessageBox.Show("Please Enter Phone Number...!!!");
                }
                else
                {
                    //employee.EmpId = empid.Text;
                    employee.EmpName = textBox1.Text;
                    employee.Job = comboBox1.SelectedItem.ToString();
                    employee.Date = dateTimePicker1.Text;
                    employee.Address = textBox4.Text;
                    employee.ContactNo = textBox5.Text;
                    // Call Insert Employee method to insert the employee details to database
                    var success = employee.InsertEmployee(employee);
                    // Refresh the grid to show the updated employee details
                    dataGridView1.DataSource = employee.GetEmployees();
                    if (success)
                    {
                        // Clear controls once the employee is inserted successfully
                        ClearControls();
                        MessageBox.Show("Employee has been added successfully");
                    }
                    else
                        MessageBox.Show("Error occured. Please try again...");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occcured !!!==> " + ex.Message);
                throw;
            }
        }
        private void ClearControls()
        {
            empid.Text = "";
            comboBox1.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please Select Row From GridView...!!!");
                }
                else
                {

                    employee.EmpId = int.Parse(empid.Text);
                    employee.EmpName = textBox1.Text;
                    employee.Job = comboBox1.SelectedItem.ToString();
                    employee.Date = dateTimePicker1.Text;
                    employee.Address = textBox4.Text;
                    employee.ContactNo = textBox5.Text;
                    var success = employee.UpdateEmployee(employee);
                    dataGridView1.DataSource = employee.GetEmployees();
                    if (success)
                    {

                        ClearControls();
                        MessageBox.Show("Employee Data has  Uptaded successfully");
                    }
                    else
                        MessageBox.Show("Error occured. Please try again...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occcured !!!==> " + ex.Message);
                throw;
            }

           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void textBox5_KeyPress_1(object sender, KeyPressEventArgs e)
        {
          e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Employees_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            empid.Text = "";
            textBox1.Text = "";
            comboBox1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            dateTimePicker1.Text = "";
            textBox2.Text = "";
            dataGridView1.DataSource = employee.GetEmployees();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
           // button5.BackColor = Color.DarkCyan;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
           // button5.BackColor = Color.Chocolate;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text=="")
                {
                    MessageBox.Show("Insert Employee Id In Search TextBox");
                }
                dataGridView1.DataSource = employee.GetEmployeeswithid(textBox2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occcured !!!==> " + ex.Message);
                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please Select Row From GridView...!!!");
                }
                else
                {

                    employee.EmpId =int.Parse(empid.Text);
                    var success = employee.DeleteEmployee(employee);                  
                    dataGridView1.DataSource = employee.GetEmployees();
                    if (success)
                    {
                       
                        ClearControls();
                        MessageBox.Show("Employee Data has  deleted successfully");
                    }
                    else
                        MessageBox.Show("Error occured. Please try again...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occcured !!!==> " + ex.Message);
                throw;
            }
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            indexrow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexrow];
            empid.Text = row.Cells[0].Value.ToString();
            textBox1.Text = row.Cells[1].Value.ToString();
            comboBox1.Text = row.Cells[2].Value.ToString();
            dateTimePicker1.Text = row.Cells[3].Value.ToString();
            textBox4.Text = row.Cells[4].Value.ToString();
            textBox5.Text = row.Cells[5].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminPanel a = new AdminPanel();
            a.Show();
            this.Hide();
        }
    }
}
