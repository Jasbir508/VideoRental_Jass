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
    public partial class ReturnMovie : Form
    {
        public ReturnMovie()
        {
            InitializeComponent();
            dataGridViewReturn.DataSource = new MainClass().GetPendingRentals();
        }

        private void returnMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to return this rental?", "Return Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MainClass database = new MainClass();
                //string rmid = dataGridViewReturn.SelectedRows[0].Cells[0].Value.ToString();
                string rmid = this.dataGridViewReturn.CurrentRow.Cells[0].Value.ToString();
                database.UpdateReturnRecord(Convert.ToDateTime(DateTime.Now.ToString()), rmid);
                MessageBox.Show("Movie Returned");
                dataGridViewReturn.DataSource = new MainClass().GetPendingRentals();
            }
        }

        private void ReturnMovie_Load(object sender, EventArgs e)
        {

        }
    }
}
