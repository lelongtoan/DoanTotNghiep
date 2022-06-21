using Microsoft.AspNetCore.Mvc;

namespace doanasp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Shop()
        {
            return View();
        }
    }
}
