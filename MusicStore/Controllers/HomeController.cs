using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View("~/Views/Home/NewIndex.cshtml");
        }

        public ActionResult About()
        {
            var albums = new List<Album>();
            for (int i = 0; i < 10; i++)
            {
                albums.Add(new Album { Title = "product" + i });
            }
            return View(albums);
        }

        public ActionResult Contact()
        {
            ViewBag.Str = "Your contact page....";
            Album a = new Album() { Title = "Hyman" };
            ViewBag.Name = "Hyman";
            return View();
        }
    }
}