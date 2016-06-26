using System.Web.Mvc;
using Mooviez.Models;

namespace Mooviez.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Genres g = MovieModels.getGenres();
            ViewData["genre"] = g.genres;
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            string genre = Request.Form["genre"];
            genre = genre.Replace(',', '|');
            
            Movies m = MovieModels.GetMovie(genre);
            Genres g = MovieModels.getGenres();
            Config config = MovieModels.GetMovieConfig();
            ViewData["genre"] = g.genres;
            ViewData["baseURL"] = config.images.secure_base_url;
            ViewData["imageSize"] = config.images.poster_sizes[3];
            return View(m);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}