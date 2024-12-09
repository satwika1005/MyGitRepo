using MVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: EmployeeList
        public ActionResult GetEmployeeList()
        {
            EmployeeEntities employeeEntities = new EmployeeEntities();
            List<Employee> employees = employeeEntities.Employees.ToList();
            return View(employees);
        }

        // GetEmployeeById
        public ActionResult GetByEmployeeId(int id)
        {
            EmployeeEntities employeeentities = new EmployeeEntities();
            Employee employee = employeeentities.Employees.Find(id);
            return View(employee);
        }
    }
}