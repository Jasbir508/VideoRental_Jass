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
    public partial class EditMovie : Form
    {
        public EditMovie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(year.Text, out a))
            {
                MessageBox.Show("Year and Copies must be a valid integer");
            }
            else
            {
                int rental = 0;
                if ((DateTime.Now.Year - a) > 5)
                {
                    rental = 2;
                }
                else
                {
                    rental = 5;
                }
                MainClass database = new MainClass();
                database.EditMovie(rating.Text, title.Text, year.Text, copies.Text, rental.ToString(), plot.Text, genre.Text, DateTime.Now, txtMoviesID.Text);
                MessageBox.Show("Movie Updated");
                Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainClass database = new MainClass();
            database.DeleteMovie(txtMoviesID.Text);
            MessageBox.Show("Movie Deleted");
            Dispose();
        }
    }
}
