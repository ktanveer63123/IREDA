using Microsoft.AspNetCore.Mvc;

namespace StaticFilePOC.Controllers
{
    public class MasterManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
