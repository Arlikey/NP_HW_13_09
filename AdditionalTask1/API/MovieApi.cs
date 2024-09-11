using Microsoft.Extensions.Configuration;
using Movie_Hotflix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Hotflix.API
{
    public class MovieApi
    {
        private static async Task<T> SendApi<T>(string query)
        {
            string apiKey = GetMovieApiKey();

            HttpClient httpClient = new HttpClient();

            HttpResponseMessage responseMessage = await httpClient.GetAsync(query + $"&api_key={apiKey}");

            if (responseMessage.IsSuccessStatusCode)
            {
                var result = await responseMessage.Content.ReadFromJsonAsync<T>();
                return result;
            }
            else
            {
                throw new Exception("Error. Try again later.");
            }
        }

        private static string GetMovieApiKey()
        {
            var builder = new ConfigurationBuilder();

            builder.SetBasePath(Directory.GetCurrentDirectory());


            builder.AddJsonFile("appsettings.json");

            var config = builder.Build();

            var connectionString = config.GetSection("MovieApi:ApiKey");
            return connectionString.Value;
        }

        public static async Task<Movies> GetPopularMovies(int page = 1)
        {
            return await SendApi<Movies>($"https://api.themoviedb.org/3/movie/popular?language=ru-ru&page={page}&include_adult=true");
        }

        public static async Task<Movies> GetSimilarMovies(int movieId, int page = 1)
        {
            return await SendApi<Movies>($"https://api.themoviedb.org/3/movie/{movieId}/similar?&language=ru-ru&page={page}&include_adult=true");
        }

        public static async Task<Movies> GetMoviesByYearAndName(string name, int year, int page = 1)
        {
            return await SendApi<Movies>($"https://api.themoviedb.org/3/search/movie?language=ru-ru&query={name}&page={page}&include_adult=false&year={year}");
        }

        public static async Task<Movies> GetMoviesByName(string name, int page = 1)
        {
            return await SendApi<Movies>($"https://api.themoviedb.org/3/search/movie?language=ru-ru&query={name}&page={page}&include_adult=true");
        }

        public static async Task<Movies> GetMoviesByGenre(int genreId, int page = 1)
        {
            return await SendApi<Movies>($"https://api.themoviedb.org/3/discover/movie?with_genres={genreId}&page={page}&include_adult=true?language=ru-ru");
        }

        public static async Task<Movie> GetMovieById(int id)
        {
            return await SendApi<Movie>($"https://api.themoviedb.org/3/movie/{id}?language=ru-ru");
        }

        public static async Task<Genres> GetGenreList()
        {
            return await SendApi<Genres>("https://api.themoviedb.org/3/genre/movie/list?language=ru-ru");
        }
    }
}
