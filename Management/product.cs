using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sumayya;
using Management;
using System.Data.SqlClient;

namespace WinFormsApp3
{
    public partial class product : Form
    {
        DatabaseHelper db;
        String query;
        products p = new products();

       

        public product()
        {
            InitializeComponent();
            db = new DatabaseHelper();
            dataGridView1.DataSource = p.GetProducts();
           
        }
       
         private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
      
    private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Please Enter Product Name ...!!!");
                }
                else if (textBox4.Text == "")
                {
                    MessageBox.Show("Please Product Decription...!!!");
                }
                else if (textBox3.Text == "")
                {
                    MessageBox.Show("Please Price...!!!");
                }
                else if (comboBox2.Text == "")
                {
                    MessageBox.Show("Please Select Category ...!!!");
                }
                else if (textBox6.Text == "")
                {
                    MessageBox.Show("Please Enter Stock .!!!");
                }
                else if (textBox7.Text == "")
                {
                    MessageBox.Show("Please Enter Supplier Id .!!!");
                }
                else
                {
                    p.ProdName = textBox2.Text;
                    p.Decp = textBox4.Text;
                    p.price = int.Parse(textBox3.Text);
                    p.CatName = comboBox2.Text;
                    p.CatId = int.Parse(textBox1.Text);
                    p.stock = int.Parse(textBox6.Text);
                    p.sid = int.Parse(textBox7.Text);
                    var success = p.Insert(p);
                    dataGridView1.DataSource = p.GetProducts();
                    if (success)
                    {
                        // Clear controls once the employee is inserted successfully
                        clear();
                        MessageBox.Show("Products has been added successfully");
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
        public  void clear()
        {
            textBox2.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            comboBox2.Text = "";
            textBox1.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox5.Text = "";
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void product_Load(object sender, EventArgs e)
        {
            try
            {
                query = "select Cat_name from Categories";
                DataTable dt = db.Retrieve(query);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBox2.Items.Add(dt.Rows[i][0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error==>" + ex.Message);
                throw;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
          
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
             //   this.categoriesTableAdapter.FillBy(this.finalDataSet.Categories);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String text = comboBox2.SelectedItem.ToString();
                query = "Select Cat_id from Categories where Cat_name = '" + text + "'";
                DataTable dt = db.Retrieve(query);
                textBox1.Text = dt.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occcured !!!==> " + ex.Message);
                throw;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            clear();
            dataGridView1.DataSource = p.GetProducts();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox5.Text == "")
                {
                    MessageBox.Show("Please Select Row From GridView...!!!");
                }
                else
                {

                    p.ProdName = textBox2.Text;
                    p.Decp = textBox4.Text;
                    p.price = int.Parse(textBox3.Text);
                    p.CatName = comboBox2.Text;
                    p.CatId = int.Parse(textBox1.Text);
                    p.stock = int.Parse(textBox6.Text);
                    p.sid = int.Parse(textBox7.Text);
                    p.id = int.Parse(textBox5.Text);
                    var success = p.Update(p);
                    dataGridView1.DataSource = p.GetProducts();
                    if (success)
                    {                
                        MessageBox.Show("Products Data has  Uptaded successfully");
                        clear();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox5.Text == "")
                {
                    MessageBox.Show("Enter Product Id");
                }
                else
                {
                    //p.ProdName = textBox2.Text;
                    //p.Decp = textBox4.Text;
                    //p.price = int.Parse(textBox3.Text);
                    //p.CatName = comboBox2.Text;
                    //p.CatId = int.Parse(textBox1.Text);
                    //p.stock = int.Parse(textBox6.Text);
                    //p.sid = int.Parse(textBox7.Text);
                    p.id =int.Parse( textBox5.Text);
            
                    var success = p.Delete(p);
                    dataGridView1.DataSource = p.GetProducts();
                    if (success)
                    {

                   
                        MessageBox.Show("Products Data has  deleted successfully");
                        clear();
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

        int indexrow;
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            indexrow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexrow];
            textBox5.Text = row.Cells[0].Value.ToString();
            textBox1.Text = row.Cells[1].Value.ToString();
            comboBox2.Text = row.Cells[2].Value.ToString();
            textBox2.Text = row.Cells[3].Value.ToString();        
            textBox4.Text = row.Cells[4].Value.ToString();
            textBox3.Text = row.Cells[5].Value.ToString();
            textBox7.Text = row.Cells[6].Value.ToString();
            textBox6.Text = row.Cells[7].Value.ToString();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminPanel a = new AdminPanel();
            a.Show();
            this.Hide();
        }
    }
}
