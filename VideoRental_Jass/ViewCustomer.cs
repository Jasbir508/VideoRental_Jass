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
    public partial class ViewCustomer : Form
    {
        public ViewCustomer()
        {
            InitializeComponent();
        }

        private void ViewCustomer_Load(object sender, EventArgs e)
        {
            dataGridViewViewCustomer.DataSource = new MainClass().FindAllCustomers();
        }

        private void dataGridViewViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EditCustomer customerForm = new EditCustomer();
            customerForm.txtCustomerID.Text = this.dataGridViewViewCustomer.CurrentRow.Cells[0].Value.ToString();
            customerForm.firstname.Text = this.dataGridViewViewCustomer.CurrentRow.Cells[1].Value.ToString();
            customerForm.lastname.Text = this.dataGridViewViewCustomer.CurrentRow.Cells[2].Value.ToString();
            customerForm.address.Text = this.dataGridViewViewCustomer.CurrentRow.Cells[3].Value.ToString();
            customerForm.phoneno.Text = this.dataGridViewViewCustomer.CurrentRow.Cells[4].Value.ToString();
            customerForm.ShowDialog();
            dataGridViewViewCustomer.DataSource = new MainClass().FindAllCustomers();
        }
    }
}
