using System.Linq;
using Microsoft.AspNetCore.Mvc;
using EmployeeManagement.Data;
using System.Collections.Generic;


namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
       private EMContext db;
        public EmployeeController(EMContext _db)
        {
            db=_db;
        }

        public IActionResult Index()
        {
            var moreemployees = db.Employees.ToList();
            return View(moreemployees);

        }
        public ActionResult Detail(int id)
        {
           var employee = db.Employees.Find(id);
            return View(employee);

        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var employee = db.Employees.Find(id);
            
            return View(employee);
        }
        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            db.Employees.Attach(employee);
            db.Employees.Update(employee);
            db.SaveChanges();
            return RedirectToAction("Index");    
        }
        public ActionResult Delete(int id)
        {
            var employee = db.Employees.Find(id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Delete(Employee employee)
        {
            db.Employees.Attach(employee);
            db.Employees.Remove(employee);
            db.SaveChanges();
           return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
         public ActionResult Add(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
