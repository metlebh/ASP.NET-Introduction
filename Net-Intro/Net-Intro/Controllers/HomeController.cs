using Microsoft.AspNetCore.Mvc;

namespace Net_Intro.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Name = "Metleb";
            ViewBag.Surname = "Huseynov";
            ViewBag.Age = 25;
            ViewData["Country"] = "Azerbaijan";
            ViewData["Phone Number"] = "+994993991019";
            return View();


        }
    }
}
