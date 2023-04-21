using Microsoft.AspNetCore.Mvc;
using MVCDemo.Web.Models;
using System.Diagnostics;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly Employee employee;
        private readonly Department department;

        public HomeController(Employee employee,Department department)
        {
            
            this.employee = employee;
            this.department = department;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EmployeeForm()
        {
            return View();
        }

    }
}