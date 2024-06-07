using Microsoft.AspNetCore.Mvc;

namespace BackendMiniTask.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
