using Movie_Hotflix.API;
using Movie_Hotflix.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Hotflix.Views
{
    public partial class MovieDetailsForm : Form
    {
        private Movie _movie;

        public MovieDetailsForm(Movie movie)
        {
            InitializeComponent();
            _movie = movie;
            LoadMovieDetails();
            this.Text = _movie.title;
        }

        private void LoadMovieDetails()
        {
            titleLabel.Text = _movie.title;
            overviewTextBox.Text = _movie.overview;
            releaseDateLabel.Text = "Дата выхода: " + _movie.release_date;
            voteAverageLabel.Text = "Рейтинг: " + _movie.vote_average.ToString();
            posterPicture.ImageLocation = $"https://image.tmdb.org/t/p/w300{_movie.poster_path}";
            posterPicture.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnFindSimilarMovies_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)Application.OpenForms["Form1"];
            mainForm.LoadSimilarMovies(_movie.id, 1);
            this.Close();
        }
    }
}
