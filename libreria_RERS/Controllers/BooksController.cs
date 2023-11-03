using Microsoft.AspNetCore.Mvc;

namespace libreria_RERS.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
