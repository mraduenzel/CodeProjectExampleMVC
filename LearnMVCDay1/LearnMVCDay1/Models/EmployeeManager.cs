using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearnMVCDay1.DataAccessLayer;

namespace LearnMVCDay1.Models
{
    public class EmployeeManager
    {
        public List<Employee> GetEmployees()
        {
            //List<Employee> employees = new List<Employee>();

            //Employee emp = new Employee();
            //emp.FirstName = "Johnson";
            //emp.LastName = "Fernandes";
            //emp.Salary = 120000;

            //employees.Add(emp);

            //Employee emp2 = new Employee
            //{
            //    FirstName = "Mark",
            //    LastName = "Raduenzel",
            //    Salary = 200000
            //};

            //employees.Add(emp2);

            //return employees;

            SalesERPDAL sales = new SalesERPDAL();

            return sales.Employees.ToList();
        }
    }
}