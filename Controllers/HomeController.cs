using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CentricTeam9MIS4200.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Dedicated to providing you with an unmatched experience";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "For any inquiries, use the contact information below";

            return View();
        }
    }
}