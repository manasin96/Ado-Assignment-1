using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1ADO.NET;

namespace WebApplication1ADO.NET.Controllers
{
    public class HomeController : Controller
    {
        AdodemoEntities context = new AdodemoEntities();
        public ActionResult Index()
        {
            return View(context.FootBallLeagues);
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