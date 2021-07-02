using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sumayya;
using System.Data.SqlClient;
using WinFormsApp3;
using Management;

namespace WinFormsApp3
{
    public partial class categories : Form
    {

        DatabaseHelper db;
        public categories()
        {
            InitializeComponent();
            db = new DatabaseHelper();
            get();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            string query="INSERT INTO [cATEGORIES] VALUES ('"+catname.Text+"','"+catdescription.Text+"')";
            try
            {
                if (catname.Text=="")
                {
                    MessageBox.Show("Enter Category Name");
                }
                else if (catdescription.Text=="")
                {
                    MessageBox.Show("Enter Category Description Name");
                }
               else if (db.insertupdatedelete(query))
                {
                    get();
                    MessageBox.Show("Added succesfully");
                }
                else
                {
                    MessageBox.Show("Error Occured");

                }
            }
            catch (Exception exc)
            {

                Console.WriteLine("Error" + exc.Message);
                throw;

            }

        }
        public void get()
        {
            string query = "Select * from [CATEGORIES]";
            DataTable dt = db.Retrieve(query);
            dataGridView1.DataSource = dt;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            clear();
            get();
        }
        public void clear()
        {
            textBox1.Text = "";
            catname.Text = "";
            catdescription.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string query = "update [cATEGORIES] set cat_name ='"+catname.Text+"',Cat_desc='"+catdescription.Text+"' where cat_id='"+textBox1.Text+"'";
            try
            {
                if (db.insertupdatedelete(query))
                {
                    get();
                    MessageBox.Show("Updated succesfully");
                    clear();
                }
                else
                {
                    MessageBox.Show("Error Occured");

                }
            }
            catch (Exception exc)
            {

                Console.WriteLine("Error" + exc.Message);
                throw;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "delete from [cATEGORIES] where Cat_id='" + textBox1.Text + "'";
            try
            {
                if (db.insertupdatedelete(query))
                {
                    get();
                    MessageBox.Show("Deleted succesfully");
                    clear();
                }
                else
                {
                    MessageBox.Show("Error Occured");

                }
            }
            catch (Exception exc)
            {

                Console.WriteLine("Error" + exc.Message);
                throw;

            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        int indexrow;
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            indexrow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexrow];
          textBox1.Text   = row.Cells[0].Value.ToString();
            catname.Text = row.Cells[1].Value.ToString();
            catdescription.Text = row.Cells[2].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminPanel a = new AdminPanel();
            a.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void catdescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void catname_TextChanged(object sender, EventArgs e)
        {

        }

        private void categories_Load(object sender, EventArgs e)
        {

        }
    }
}
