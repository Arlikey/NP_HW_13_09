using Movie_Hotflix.API;
using Movie_Hotflix.Models;
using Movie_Hotflix.Views;

namespace Movie_Hotflix
{
    public partial class Form1 : Form
    {
        private int currentPage = 1;
        private string request = "popular";
        private int movie_Id;
        private string movie_Name;
        public Form1()
        {
            InitializeComponent();
            LoadMovies();
        }

        public async void LoadMovies()
        {
            request = "popular";
            flowLayoutPanelMovies.Controls.Clear();
            var movies = await MovieApi.GetPopularMovies(currentPage);

            foreach (var movie in movies.Results)
            {
                Panel moviePanel = CreateMoviePanel(movie);
                flowLayoutPanelMovies.Controls.Add(moviePanel);
            }
        }
        public async void LoadMoviesByName(string movieName)
        {
            request = "name";
            flowLayoutPanelMovies.Controls.Clear();
            var movies = await MovieApi.GetMoviesByName(movieName, currentPage);

            foreach (var movie in movies.Results)
            {
                Panel moviePanel = CreateMoviePanel(movie);
                flowLayoutPanelMovies.Controls.Add(moviePanel);
            }
        }
        public async void LoadSimilarMovies(int movieId, int current_Page)
        {
            currentPage = current_Page;
            request = "similar";
            movie_Id = movieId;
            flowLayoutPanelMovies.Controls.Clear();
            var similarMovies = await MovieApi.GetSimilarMovies(movieId, currentPage);

            foreach (var movie in similarMovies.Results)
            {
                Panel moviePanel = CreateMoviePanel(movie);
                flowLayoutPanelMovies.Controls.Add(moviePanel);
            }
        }
        private Panel CreateMoviePanel(Movie movie)
        {
            Panel panel = new Panel { Width = 200, Height = 300, Margin = new Padding(10) };

            PictureBox poster = new PictureBox
            {
                Width = 170,
                Height = 270,
                ImageLocation = $"https://image.tmdb.org/t/p/w200{movie.poster_path}",
                SizeMode = PictureBoxSizeMode.StretchImage,
                Cursor = Cursors.Hand
            };
            poster.Click += (sender, args) => ShowMovieDetails(movie);

            panel.Controls.Add(poster);

            return panel;
        }

        private void ShowMovieDetails(Movie movie)
        {
            MovieDetailsForm detailsForm = new MovieDetailsForm(movie);
            detailsForm.ShowDialog();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            currentPage++;
            if (request == "popular")
            {
                LoadMovies();
            }
            else if (request == "similar")
            {
                LoadSimilarMovies(movie_Id, currentPage);
            }
            else if (request == "name")
            {
                LoadMoviesByName(movie_Name);
            }
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                if (request == "popular")
                {
                    LoadMovies();
                }
                else if (request == "similar")
                {
                    LoadSimilarMovies(movie_Id, currentPage);
                }
                else if (request == "name")
                {
                    LoadMoviesByName(movie_Name);
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            request = "name";
            movie_Name = movieNameTextBox.Text.Trim();
            if (string.IsNullOrEmpty(movie_Name))
            {
                MessageBox.Show("Enter movie name!");
            }
            else
            {
                LoadMoviesByName(movie_Name);
            }
        }

        private void popularFilmsButton_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadMovies();
        }
    }
}
