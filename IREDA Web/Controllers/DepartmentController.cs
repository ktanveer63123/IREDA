using Microsoft.AspNetCore.Mvc;

namespace StaticFilePOC.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
