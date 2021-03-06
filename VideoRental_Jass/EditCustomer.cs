﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRental_Jass
{
    public partial class EditCustomer : Form
    {
        public EditCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainClass db = new MainClass();
            db.EditCustomer(firstname.Text, lastname.Text, address.Text, phoneno.Text, txtCustomerID.Text);
            MessageBox.Show("Customer Updated");
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainClass db = new MainClass();
            db.DeleteCustomer(txtCustomerID.Text);
            MessageBox.Show("Customer Deleted");
            Dispose();
        }
    }
}
