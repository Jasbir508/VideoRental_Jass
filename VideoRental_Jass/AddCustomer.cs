using System;
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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (firstname.Text == "" || lastname.Text == "" || address.Text == "" || phoneno.Text == "")
            {
                MessageBox.Show("All fields are required");
            }
            else
            {
                MainClass db = new MainClass();//instance of all functions
                db.AddCustomer(firstname.Text, lastname.Text, address.Text, phoneno.Text);//calling add customer method
                MessageBox.Show("Customer Added");
                Dispose();
            }
        }
    }
}

