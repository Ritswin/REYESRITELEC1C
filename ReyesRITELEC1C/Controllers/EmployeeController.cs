using Microsoft.AspNetCore.Mvc;
using ReyesRITELEC1C.Models;

namespace ReyesRITELEC1C.Controllers
{
    public class EmployeeController : Controller
    {
        List<Employee> EmpList = new List<Employee>
            {
                new Employee()
                {
                    FirstName = "Richwin", LastName = "Reyes", Birthday = DateTime.Parse("2003-08-22"), isTenured = true, salaryPerHour = 1, Email = "richwinkyle.reyes.cics@ust.edu.ph"
                }
            };
        public IActionResult Index()
        {
            return View(EmpList);
        }

        public IActionResult OutputB()
        {
            return View(EmpList);
        }
        public IActionResult OutputC()
        {
            return View(EmpList);
        }
        public IActionResult OutputD()
        {
            return View(EmpList);
        }
    }
}
