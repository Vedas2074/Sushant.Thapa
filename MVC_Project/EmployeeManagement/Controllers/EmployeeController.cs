using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EmployeeManagement.Models;

namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {

        public IActionResult index()
        {
            var moreemployees = Employee.GetEmployees();
            return View(moreemployees);

        }
        public ActionResult detail(int id)
        {
            var employees = Employee.GetEmployees();
            Employee employee = employees.FirstOrDefault(x => x.Id.ToString() == id.ToString());
            return View(employee);

        }

        public ActionResult add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult<string> Add(Employee employee) => "record Saved";


    }
}
