using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Management;

namespace Sumayya
{
    public partial class Form1 : Form
    {
        DatabaseHelper db;
        String query;
        public Form1()
        {
            InitializeComponent();

            db = new DatabaseHelper();
           
        }

        private void quantityupdown_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void categrorycombo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void categrorycombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {


            String category = categrorycombo.Text;
            query = "Select pr_name from products where cat_name='" + category + "'";
            showItemList(query);
        }
        private void showItemList(String query)
        {
           listBox1.Items.Clear();

            DataTable dt = db.Retrieve(query);
            try
            {

              
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listBox1.Items.Add(dt.Rows[i][0].ToString());
                }
            }
            catch
            {

            }
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
         

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
      
        private void addtocartbtn_Click(object sender, EventArgs e)
        {
            
        }

       

        private void addtocartdatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        int count = 1;

        private void proceedtopaymentbtn_Click(object sender, EventArgs e)
        {
            int orderid = int.Parse(orderidtxt.Text);
            int productid = int.Parse(textBox1.Text);
            int customerid = int.Parse(customeridtxt.Text);
            //   string addquery = "INSERT INTO [Order](Order_id, Cust_id, Product_id) values (" + orderidtxt.Text + "," + customerid + "," + productid + ")";

           



            query = "insert into [Order Details] values (" + orderidtxt.Text + "," + productid + "," + pricetxt.Text + "," + quantityupdown.Text + ")";


            try
            {
                if (db.insertupdatedelete(query))
                {

                    PrintBillForm pbf = new PrintBillForm(total, orderid);
                    pbf.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("An error occured while adding order");
                }
                count++;
            }
            catch (Exception exc)
            {

                MessageBox.Show("Error " + exc.Message);
                throw;
            }
        }
            

            //PrintBillForm pbf = new PrintBillForm(total, orderid);
            //this.Hide();
            //pbf.Show();
     
            //PrintBillForm pdf = new PrintBillForm();
            //this.Hide();
            //pdf.Show();
        

        private void Form1_Load(object sender, EventArgs e)
        {
            int orderid = GetOrderID();
            orderidtxt.Text = orderid.ToString();
            string query = "select Cat_name from Categories";
            DataTable dt = db.Retrieve(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                categrorycombo.Items.Add(dt.Rows[i][0].ToString());
            }
            int cusid = GetCusId();
            customeridtxt.Text = cusid.ToString();

        }


        private int GetOrderID()
        {
            int orderid;
            string query = "select OrderID from [Order Details]";
            DataTable dt = db.Retrieve(query);
            if (dt.Rows.Count > 0)
            {
                orderid = int.Parse(dt.Rows[dt.Rows.Count - 1][0].ToString()) + 1;
            }
            else
            {
                orderid = 1;
            }
            return orderid;
        }

    

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                quantityupdown.ResetText();
            totaltxt.Clear();
            String text = listBox1.GetItemText(listBox1.SelectedItem);
            itemnametxt.Text = text;
            query = "Select price,Product_Id from products where pr_name = '" + text + "'";
            DataTable dt = db.Retrieve(query);
          

           
                pricetxt.Text = dt.Rows[0][0].ToString();
                textBox1.Text = dt.Rows[0][1].ToString();


            }
            catch(Exception exc)
            {
                MessageBox.Show("Error"+exc.Message);
            }

        }

        private void orderidtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void customeridtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void itemnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void totaltxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantityupdown_ValueChanged_1(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(quantityupdown.Value.ToString());
            Int64 price = Int64.Parse(pricetxt.Text);
            totaltxt.Text = (quan * price).ToString();
        }
        protected int n, total = 0;
        private void addtocartbtn_Click_1(object sender, EventArgs e)
        {

            if (totaltxt.Text != "0" && totaltxt.Text != "")
            {

                n = addtocartdatagrid.Rows.Add();
                addtocartdatagrid.Rows[n].Cells[0].Value = itemnametxt.Text;
                addtocartdatagrid.Rows[n].Cells[1].Value = pricetxt.Text;

                addtocartdatagrid.Rows[n].Cells[2].Value = quantityupdown.Text;
                addtocartdatagrid.Rows[n].Cells[3].Value = totaltxt.Text;

                total += int.Parse(totaltxt.Text);
                label11.Text = "Rs. " + total;
            }


            else
            {
                MessageBox.Show("Minimum Quantity need to be 1", "Information");
            }
            
        }

        int amount;
        private void addtocartdatagrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(addtocartdatagrid.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch
            {

            }
        }

        private void removebtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                addtocartdatagrid.Rows.RemoveAt(this.addtocartdatagrid.SelectedRows[0].Index);

            }
            catch
            {

            }
            total -= amount;
            label11.Text = "Rs. " + total;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home a = new Home();
            a.Show();
            this.Hide();
        }

        private int GetCusId()
        {
            int cusid;
            string query = "select Cust_id from Customer";
            DataTable dt = db.Retrieve(query);
            if (dt.Rows.Count > 0)
            {
                cusid = int.Parse(dt.Rows[dt.Rows.Count - 1][0].ToString()) + 1;
            }
            else
            {
                cusid = 1;
            }
            return cusid;
        }
    }
}
