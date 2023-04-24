using MVCDemo.Data;
using Microsoft.AspNetCore.Mvc;
using MVCDemo.Data.Models;
using MVCDemo.Data.Interface;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly MVCDemoDBContext _db;
        private readonly IEmployeesData employees;

        public HomeController(MVCDemoDBContext db, IEmployeesData employees)
        {
            _db = db;
            this.employees = employees;
        }

        public IActionResult Index()
        {
            //_db.Departments.Add(new Department
            //{
            //    DepartmentTitle = "Design"
            //});
            //_db.Employees.Add(new Employee
            //{
            //    FirstName = "Tristan",
            //    LastName = "Crain",
            //    Email = "Tristan.Crain@outlook.com",
            //    PhoneNumber = "6134060796",
            //    DepartmentId = 1
            //});
            //_db.SaveChanges();

            IEnumerable<Employee> data = employees.GetData();
            
            return View();
        }

        public IActionResult EmployeeForm()
        {
            return View();
        }

    }
}