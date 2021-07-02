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
    public partial class PrintBillForm : Form
    {
       
        DatabaseHelper db;
        int totalprice;
        int ordrid;
        public PrintBillForm(int total, int orderid)
         
        //public PrintBillForm(total,ordid)
        {
            db = new DatabaseHelper();
            ordrid = orderid;
            totalprice = total;
            InitializeComponent();
        }
        private void PrintBillForm_Load(object sender, EventArgs e)
        {

        }


        private void ProceedBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void OrderIDTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrderDateTxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void PrintBillForm_Load_1(object sender, EventArgs e)
        {

            string query = "select * from [Order Details] where OrderID=" + ordrid + "";
            DataTable dt = db.Retrieve(query);
            dataGridView2.DataSource = dt;
            //query = "select * from [Order] where Order_id=" + ordrid + "";
            //dt = db.Retrieve(query);
            //OrderIDTxt.Text = ordrid.ToString();
            //dateTimePicker1.Text = dt.Rows[0][6].ToString();
            //int userid = int.Parse(dt.Rows[0][1].ToString());
            ////query = "select Cust_name from Customer where Cust_id=" + userid + "";
            ////dt = db.Retrieve(query);
            ////CustomerNameTxt.Text = dt.Rows[0][2].ToString();
            PriceTxt.Text = totalprice.ToString();
            PriceTxt.Text = totalprice.ToString();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProceedBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PriceTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home a = new Home();
            a.Show();
            this.Hide();
        }
    }
}

