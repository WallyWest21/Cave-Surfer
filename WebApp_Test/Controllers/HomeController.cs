using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp_Test.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            WebApp_Test.Models.test_Model models1 = new Models.test_Model();
            ViewData["Message"] = models1;
            ViewBag.DataPoints = JsonConvert.SerializeObject(models1.stock_array);

            return View();
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