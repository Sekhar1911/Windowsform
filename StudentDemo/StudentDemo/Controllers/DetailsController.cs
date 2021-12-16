using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentDemo.Controllers
{
    public class DetailsController : Controller
    {
        //
        // GET: /Details/

        public ActionResult Index()
        {
            ViewBag.Credentials = new List<string>
            {
                "CHANDRASEKHAR",
                "BHIMAVARAM",
                "SOFTWARE ENGINEER TRAINEE",
                "B.TECH"
            };
            return View();
        }

    }
}
