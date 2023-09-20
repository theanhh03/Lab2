using Microsoft.AspNetCore.Mvc;

namespace Thuchanh2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
