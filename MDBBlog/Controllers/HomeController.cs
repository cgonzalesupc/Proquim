using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MDBBlog.Controllers
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
        public ActionResult Contact2()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Route("/Home/Category/{categoryID?}")]
        public ActionResult Category(int? categoryID)
        {
            int? cat = 1;
            if (categoryID != null)
            {
                cat = categoryID;
            }
            ViewBag.categoria = cat;
            return View();
        }
        public ActionResult Category2()
        {
            return View();
        }
        public ActionResult Post()
        {
            return View();
        }
    }
}