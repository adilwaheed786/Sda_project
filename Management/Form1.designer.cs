namespace Sumayya
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.quantityupdown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.totaltxt = new System.Windows.Forms.TextBox();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.itemnametxt = new System.Windows.Forms.TextBox();
            this.customeridtxt = new System.Windows.Forms.TextBox();
            this.orderidtxt = new System.Windows.Forms.TextBox();
            this.addtocartdatagrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proceedtopaymentbtn = new System.Windows.Forms.Button();
            this.removebtn = new System.Windows.Forms.Button();
            this.addtocartbtn = new System.Windows.Forms.Button();
            this.categrorycombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grandtotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quantityupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addtocartdatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 164);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(228, 355);
            this.listBox1.TabIndex = 43;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // quantityupdown
            // 
            this.quantityupdown.Location = new System.Drawing.Point(274, 95);
            this.quantityupdown.Name = "quantityupdown";
            this.quantityupdown.Size = new System.Drawing.Size(195, 20);
            this.quantityupdown.TabIndex = 42;
            this.quantityupdown.ValueChanged += new System.EventHandler(this.quantityupdown_ValueChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 122);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "PRODUCT NAMES";
            // 
            // totaltxt
            // 
            this.totaltxt.Location = new System.Drawing.Point(734, 94);
            this.totaltxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.Size = new System.Drawing.Size(200, 20);
            this.totaltxt.TabIndex = 40;
            this.totaltxt.TextChanged += new System.EventHandler(this.totaltxt_TextChanged);
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(504, 94);
            this.pricetxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(200, 20);
            this.pricetxt.TabIndex = 39;
            // 
            // itemnametxt
            // 
            this.itemnametxt.Location = new System.Drawing.Point(734, 25);
            this.itemnametxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.itemnametxt.Name = "itemnametxt";
            this.itemnametxt.ReadOnly = true;
            this.itemnametxt.Size = new System.Drawing.Size(200, 20);
            this.itemnametxt.TabIndex = 38;
            this.itemnametxt.TextChanged += new System.EventHandler(this.itemnametxt_TextChanged);
            // 
            // customeridtxt
            // 
            this.customeridtxt.Location = new System.Drawing.Point(504, 25);
            this.customeridtxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.customeridtxt.Name = "customeridtxt";
            this.customeridtxt.Size = new System.Drawing.Size(200, 20);
            this.customeridtxt.TabIndex = 37;
            this.customeridtxt.TextChanged += new System.EventHandler(this.customeridtxt_TextChanged);
            // 
            // orderidtxt
            // 
            this.orderidtxt.Location = new System.Drawing.Point(274, 25);
            this.orderidtxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.orderidtxt.Name = "orderidtxt";
            this.orderidtxt.Size = new System.Drawing.Size(200, 20);
            this.orderidtxt.TabIndex = 36;
            this.orderidtxt.TextChanged += new System.EventHandler(this.orderidtxt_TextChanged);
            // 
            // addtocartdatagrid
            // 
            this.addtocartdatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addtocartdatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.addtocartdatagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addtocartdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addtocartdatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.addtocartdatagrid.Location = new System.Drawing.Point(274, 202);
            this.addtocartdatagrid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.addtocartdatagrid.Name = "addtocartdatagrid";
            this.addtocartdatagrid.Size = new System.Drawing.Size(712, 290);
            this.addtocartdatagrid.TabIndex = 35;
            this.addtocartdatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.addtocartdatagrid_CellClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ITEM NAME";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "UNIT PRICE";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "QUANTITY";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "TOTAL";
            this.Column4.Name = "Column4";
            // 
            // proceedtopaymentbtn
            // 
            this.proceedtopaymentbtn.BackColor = System.Drawing.Color.DarkKhaki;
            this.proceedtopaymentbtn.Location = new System.Drawing.Point(783, 500);
            this.proceedtopaymentbtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.proceedtopaymentbtn.Name = "proceedtopaymentbtn";
            this.proceedtopaymentbtn.Size = new System.Drawing.Size(203, 36);
            this.proceedtopaymentbtn.TabIndex = 34;
            this.proceedtopaymentbtn.Text = "PROCEED TO PAYMENT";
            this.proceedtopaymentbtn.UseVisualStyleBackColor = false;
            this.proceedtopaymentbtn.Click += new System.EventHandler(this.proceedtopaymentbtn_Click);
            // 
            // removebtn
            // 
            this.removebtn.BackColor = System.Drawing.Color.DarkKhaki;
            this.removebtn.Location = new System.Drawing.Point(486, 164);
            this.removebtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(238, 30);
            this.removebtn.TabIndex = 33;
            this.removebtn.Text = "REMOVE";
            this.removebtn.UseVisualStyleBackColor = false;
            this.removebtn.Click += new System.EventHandler(this.removebtn_Click_1);
            // 
            // addtocartbtn
            // 
            this.addtocartbtn.BackColor = System.Drawing.Color.DarkKhaki;
            this.addtocartbtn.Location = new System.Drawing.Point(734, 164);
            this.addtocartbtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.addtocartbtn.Name = "addtocartbtn";
            this.addtocartbtn.Size = new System.Drawing.Size(238, 30);
            this.addtocartbtn.TabIndex = 32;
            this.addtocartbtn.Text = "ADD TO CART";
            this.addtocartbtn.UseVisualStyleBackColor = false;
            this.addtocartbtn.Click += new System.EventHandler(this.addtocartbtn_Click_1);
            // 
            // categrorycombo
            // 
            this.categrorycombo.FormattingEnabled = true;
            this.categrorycombo.Location = new System.Drawing.Point(25, 64);
            this.categrorycombo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.categrorycombo.Name = "categrorycombo";
            this.categrorycombo.Size = new System.Drawing.Size(226, 21);
            this.categrorycombo.TabIndex = 31;
            this.categrorycombo.SelectedIndexChanged += new System.EventHandler(this.categrorycombo_SelectedIndexChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(742, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "TOTAL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(532, 64);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "PRICE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(271, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "QUANTITY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(742, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "ITEM NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "CATEGORY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(522, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "CUSTOMER ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "ORDER ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "PLACE ORDER";
            // 
            // grandtotal
            // 
            this.grandtotal.AutoSize = true;
            this.grandtotal.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandtotal.Location = new System.Drawing.Point(461, 506);
            this.grandtotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.grandtotal.Name = "grandtotal";
            this.grandtotal.Size = new System.Drawing.Size(160, 24);
            this.grandtotal.TabIndex = 44;
            this.grandtotal.Text = "GrandTOTAL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(630, 505);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 24);
            this.label11.TabIndex = 45;
            this.label11.Text = "RS:00";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(274, 142);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(271, 122);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 16);
            this.label10.TabIndex = 46;
            this.label10.Text = "PRODUCT ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkKhaki;
            this.button1.Location = new System.Drawing.Point(274, 503);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 30);
            this.button1.TabIndex = 48;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 539);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.grandtotal);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.quantityupdown);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.totaltxt);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.itemnametxt);
            this.Controls.Add(this.customeridtxt);
            this.Controls.Add(this.orderidtxt);
            this.Controls.Add(this.addtocartdatagrid);
            this.Controls.Add(this.proceedtopaymentbtn);
            this.Controls.Add(this.removebtn);
            this.Controls.Add(this.addtocartbtn);
            this.Controls.Add(this.categrorycombo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantityupdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addtocartdatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown quantityupdown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox totaltxt;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.TextBox itemnametxt;
        private System.Windows.Forms.TextBox customeridtxt;
        private System.Windows.Forms.TextBox orderidtxt;
        private System.Windows.Forms.DataGridView addtocartdatagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button proceedtopaymentbtn;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.Button addtocartbtn;
        private System.Windows.Forms.ComboBox categrorycombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label grandtotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}

