using Microsoft.AspNetCore.Mvc;

namespace project1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
