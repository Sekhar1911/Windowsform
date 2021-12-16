using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /Student/

        public ActionResult Index()
        {

            ViewBag.Subjects = new List<string>()
            //return List<string>
            {
             "matematics",
             "physics",
             "chemistry"
            };
            return View();
        }
        public ActionResult Colleges()
        {
            ViewBag.College = new List<string>()
            {
                "NARAYANA",
                "SRI CHAITANYA",
                "ADTIYA"
            };
            return View();
        }
    }
}
