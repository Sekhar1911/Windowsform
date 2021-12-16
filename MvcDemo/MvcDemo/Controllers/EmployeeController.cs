using MvcDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class EmployeeController : Controller
    {
        
        public ActionResult Details()
        {
            Employee employee = new Employee()
            {
                employeeId = 102,
                name = "JOHN",
                gender = "Male",
                city = "LONDON"
            };
            return View(employee);
        }

    }
}
