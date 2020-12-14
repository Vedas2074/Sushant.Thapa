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
    public class DepartmentController : Controller
    {

        public IActionResult index()
        {
            var depart = Department.GetDepartments();
            return View(depart);

        }

        public ActionResult detail(int id)
        {
            var departments = Department.GetDepartments();
            Department department = departments.FirstOrDefault(x => x.Id.ToString() == id.ToString());
            return View(department);
        }
        public ActionResult add()
        {
            return View();
        }

    }
}