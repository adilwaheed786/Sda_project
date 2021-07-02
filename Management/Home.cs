using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sumayya;

namespace Management
{
    public partial class Home : Form
    {
        public static int counting = 0;
        public Home()
        {
            InitializeComponent();
            if (counting == 0)
            {
                Thread t = new Thread(new ThreadStart(change));
                t.Start();
                Thread.Sleep(3000);
                t.Abort();
                counting++;
            }
        }
        public void change()
        {
            Application.Run(new splash());
        }
        private void Employees_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
            this.Hide();
        }
    }
}
