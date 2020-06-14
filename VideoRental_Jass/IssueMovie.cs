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
    public partial class IssueMovie : Form
    {
        public IssueMovie()
        {
            InitializeComponent();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter valid Customer ID");
            }
            else
            {
                MainClass database = new MainClass();
                database.AddRentalRecord(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue.ToString()), Convert.ToDateTime(dateTimePicker1.Text));
                MessageBox.Show("Movie Rented");
            }
        }

        private void IssueMovie_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'videoRental_JassDataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.videoRental_JassDataSet1.Customer);
            // TODO: This line of code loads data into the 'videoRental_JassDataSet.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.videoRental_JassDataSet.Movies);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            DataTable table = new MainClass().FindCustomerByID(comboBox2.SelectedValue.ToString());

            if (table.Rows.Count > 0)
            {
                textBox1.Text = table.Rows[0]["FirstName"].ToString();
                textBox2.Text = table.Rows[0]["Address"].ToString();
                textBox3.Text = table.Rows[0]["Phone"].ToString();
            }
        }
    }
}
