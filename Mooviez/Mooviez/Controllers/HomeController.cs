using System.Web.Mvc;
using Mooviez.Models;

namespace Mooviez.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            string genre = collection.GetValues("genre").GetValue(0).ToString();
            
            Movies m = MovieModels.GetMovie();
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