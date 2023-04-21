using MVCDemo.Data;
using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly MVCDemoDBContext _db;

        public HomeController(MVCDemoDBContext db)
        {
            _db = db;
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