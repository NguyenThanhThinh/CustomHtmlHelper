using mvc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult Table()
        {
            Human[] humans = new Human[]
            {
              new Human() { Id = 1, Name = "Thanh thinh", Age = 20}  ,
              new Human() {Id = 2, Name = "tinh", Age = 22}
            };

            return this.View(humans);
        }
    }
}