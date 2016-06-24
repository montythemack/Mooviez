using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;


namespace Mooviez.Models
{
    public class Genres
    {
        public List<Genre> genres { get; set; }

    }

    public class Genre
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    

    public class Movie
    {
        public bool adult { get; set; }
        public string backdrop_path { get; set; }
        public List<int> genre_ids { get; set; }
        public int id { get; set; }
        public string original_language { get; set; }
        public string original_title { get; set; }
        public string overview { get; set; }
        public string release_date { get; set; }
        public string poster_path { get; set; }
        public double popularity { get; set; }
        public string title { get; set; }
        public bool video { get; set; }
        public double vote_average { get; set; }
        public int vote_count { get; set; }
    }
    public class Movies
    {
        public int page { get; set; }
        public List<Movie> results { get; set; }
        public int total_pages { get; set; }
        public int total_results { get; set; }
    }
    public class MovieModels
    {
        public static string key = "ac8d638fbb365666e840e4e79059dbc2";



        public static Genres getGenres()
        {
            WebClient web = new WebClient();
            var url = "http://api.themoviedb.org/3/genre/movie/list?api_key=ac8d638fbb365666e840e4e79059dbc2";
            var content = web.DownloadString(url);
            Genres g = new Genres();
            g = Newtonsoft.Json.JsonConvert.DeserializeObject<Genres>(content);
            return g;
        }

        public static Movies GetMovie()
        {
            WebClient web = new WebClient();
            var url = "https://api.themoviedb.org/3/discover/movie?api_key=ac8d638fbb365666e840e4e79059dbc2";
            var content = web.DownloadString(url);
            Movies m = new Movies();
            m = Newtonsoft.Json.JsonConvert.DeserializeObject<Movies>(content);
            return m;
            
        }

    }
}