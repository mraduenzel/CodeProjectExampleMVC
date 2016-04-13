using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearnMVCDay1.Models;

namespace LearnMVCDay1.Controllers
{
    public class TestController : Controller
    {
        public string GetString()
        {
            return "Hello World is so yesterday. It&rsquo;s time for wassup bro :0";
        }

        public ActionResult GetView()
        {
            Employee emp = new Employee
            {
                FirstName = "Mark",
                LastName = "Raduenzel",
                Salary = 200000
            };

            ViewData["Employee"] = emp;

            return View("MyView", emp);
        }
    }
}