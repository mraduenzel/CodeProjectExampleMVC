using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearnMVCDay1.Models;
using LearnMVCDay1.ViewModels;

namespace LearnMVCDay1.Controllers
{
    public class EmployeeController : Controller
    {
        public string GetString()
        {
            return "Hello World is so yesterday. It&rsquo;s time for wassup bro :0";
        }

        public ActionResult Index()
        {
            EmployeeListViewModel vmEmp = new EmployeeListViewModel();
            List<Employee> employees = new EmployeeManager().GetEmployees();
            List<EmployeeViewModel> empViewModels = new List<EmployeeViewModel>();

            foreach (Employee emp in employees)
            {
                EmployeeViewModel vm = new EmployeeViewModel();

                vm.EmployeeName = emp.FirstName + " " + emp.LastName;
                vm.Salary = emp.Salary.ToString("C");
                vm.SalaryColor = emp.Salary > 150000 ? "yellow" : "green";

                empViewModels.Add(vm);
            }

            vmEmp.Employees = empViewModels;

            return View("Index", vmEmp);
        }
    }
}