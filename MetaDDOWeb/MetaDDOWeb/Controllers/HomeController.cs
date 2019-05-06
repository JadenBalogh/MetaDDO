using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MetaDDOWeb.Helpers;

namespace MetaDDOWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MetaDDO metaDDO = new MetaDDO();
            List<Item> items = metaDDO.ReadItemsFromFile();
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