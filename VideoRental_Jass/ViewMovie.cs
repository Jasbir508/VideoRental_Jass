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
    public partial class ViewMovie : Form
    {
        public ViewMovie()
        {
            InitializeComponent();
        }

        private void dataGridViewMovieView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EditMovie editMovie = new EditMovie();
            editMovie.txtMoviesID.Text = this.dataGridViewMovieView.CurrentRow.Cells[0].Value.ToString();
            editMovie.title.Text = this.dataGridViewMovieView.CurrentRow.Cells[2].Value.ToString();
            editMovie.rating.Text = this.dataGridViewMovieView.CurrentRow.Cells[1].Value.ToString();
            editMovie.year.Text = this.dataGridViewMovieView.CurrentRow.Cells[3].Value.ToString();
            editMovie.copies.Text = this.dataGridViewMovieView.CurrentRow.Cells[4].Value.ToString();
            editMovie.plot.Text = this.dataGridViewMovieView.CurrentRow.Cells[5].Value.ToString();
            editMovie.genre.Text = this.dataGridViewMovieView.CurrentRow.Cells[6].Value.ToString();
            editMovie.ShowDialog();
            dataGridViewMovieView.DataSource = new MainClass().FindAllMovies();
        }

        private void ViewMovie_Load(object sender, EventArgs e)
        {
            dataGridViewMovieView.DataSource = new MainClass().FindAllMovies();

        }
    }
}
