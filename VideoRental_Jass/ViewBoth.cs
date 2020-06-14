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
    public partial class ViewBoth : Form
    {
        public ViewBoth()
        {
            InitializeComponent();
        }

        private void ViewBoth_Load(object sender, EventArgs e)
        {
            dataGridViewCustomer.DataSource = new MainClass().FindBestCustomers();
            dataGridViewMovies.DataSource = new MainClass().GetBestSellingMovies();
        }
    }
}
