using Bus2MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bus2MVC.Controllers
{
    public class DepController : Controller
    {
        public IActionResult Index()
        {
            List<Department> deps = DAL.ReadAllDepartments();
            return View(deps);
        }
        public IActionResult Detail(string id)
        {
            // Heres an example of how we lock this page down to just admin
            //if (DAL.currentUser != "admin")
            //{
            //    return Content("Sorry you do not have access to this page.");
            //}

            Department dep = DAL.ReadOneDepartments(id);
            ViewBag.depart = dep;
            List<Employee> emps = DAL.ReadEmpsInDep(id);
            return View(emps);
        }

        public IActionResult DeleteEmployee(string dept, int empid)
        {
            //DAL.DeleteEmployee(empid);

            // Make a dynamic object
            //return RedirectToAction("Detail", new { id = dept });
            if (DAL.DeleteEmployee(empid) == false)
            {
                return Content("Sorry, no access!");
            }

            return Redirect($"/dep/Detail?id={dept}"); // Jeff prefers this way
        }
        public IActionResult AddEmployeeForm(string id)
        {
            ViewBag.depid = id;
            return View();
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee emp)
        {
            DAL.AddEmployee(emp);
            return Redirect($"/dep/Detail?id={emp.department}");
        }
    }
}
